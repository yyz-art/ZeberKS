using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.DP;
using ZC.DP.Memory;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Models;
using ZitApp.UI;

namespace ZitApp.Services;

public enum FeederMonoState
{
	Matched,
	NotMatched,
}

public enum MesRecipePrepareState
{
	Ready,
	RecipeNotFound,
	PlcResponseTimeout,
	UserCanceled,
	Failed,
}

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
public partial class CoreService : CoreServiceBase
{
	private readonly SemaphoreSlim _mesRecipePrepareLock = new(1, 1);

	public required ConnectionManageService ConnectionManageService { get; init; }
	public required ILogger Logger { get; init; }
	public required PlcService Plc { get; init; }
	public required RecipeService Recipe { get; init; }
	public required AppConfig AppConfig { get; init; }

	public partial string RecipeName { get; set; } = "";
	public partial int ProductCount { get; private set; } = 1234;
	public partial double OkPrecent { get; private set; } = 55.69;
	public partial int CT { get; private set; } = 10;
	public partial string 工号 { get; set; } = "TestWorkNo0001";
	public partial string 工单号 { get; set; } = "WorkOrderNo0001";
	public partial bool MesSkipEnabled { get; set; }
	public partial ProductRecipe? 请求切换的配方 { get; set; }
	public partial ProductRecipe? 当前下发配方 { get; set; }
	public partial string 飞达1物料码 { get; set; } = "L-Test1";
	public partial FeederMonoState 飞达1物料状态 { get; set; } = FeederMonoState.NotMatched;
	public partial string 飞达2物料码 { get; set; } = "L-Test2";
	public partial FeederMonoState 飞达2物料状态 { get; set; } = FeederMonoState.NotMatched;
	public partial string 飞达3物料码 { get; set; } = "R-Test1";
	public partial FeederMonoState 飞达3物料状态 { get; set; } = FeederMonoState.NotMatched;
	public partial string 飞达4物料码 { get; set; } = "R-Test2";
	public partial FeederMonoState 飞达4物料状态 { get; set; } = FeederMonoState.NotMatched;
	public partial string 飞达5物料码 { get; set; } = "";
	public partial FeederMonoState 飞达5物料状态 { get; set; } = FeederMonoState.NotMatched;
	public partial string 飞达6物料码 { get; set; } = "";
	public partial FeederMonoState 飞达6物料状态 { get; set; } = FeederMonoState.NotMatched;

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	public override Task Initialize(object? ctx = null, object? args = null)
	{
		if (string.IsNullOrWhiteSpace(AppConfig.WorkNo) == false)
			工号 = AppConfig.WorkNo;

		return base.Initialize(ctx, args);
	}

	protected override async Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
			if (请求切换的配方 is not { } reqRecipe)
				continue;

			请求切换的配方 = null;
			Logger.Info("find switch recipe request, start distribute recipe ...");
			var distributeRecipeResult = await DistributeRecipeAsync(reqRecipe);
			if (distributeRecipeResult.IsError())
			{
				Logger.Error("distribute recipe result error! {}", distributeRecipeResult.Message);
				continue;
			}

			Logger.Info("distribute recipe success!");
			当前下发配方 = reqRecipe;
			RecipeName = reqRecipe.Name;
		}
	}

	public async Task<Result> RequestPlcWriteRecipeAsync()
	{
		Logger.Info("【PLC配方写入PC地址握手】开始，使用 PLC配方写入PC地址请求(21011) / PLC配方写入PC地址响应(22011)。");

		Plc.Write.PLC配方写入PC地址请求 = 0;
		var result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
		if (result.IsError())
			return result;

		Plc.Write.PLC配方写入PC地址响应 = 0;
		result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址响应);
		if (result.IsError())
			return result;

		var resetTimeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < resetTimeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
			if (result.IsError())
				return result;

			Logger.Info("【PLC配方写入PC地址握手】等待 PLC配方写入PC地址响应(22011)=0，当前响应={response}", Plc.Read.PLC配方写入PC地址响应);
			if (Plc.Read.PLC配方写入PC地址响应 == 0)
				break;
		}

		if (Plc.Read.PLC配方写入PC地址响应 != 0)
			return Result.Err("等待 PLC配方写入PC地址响应(22011)=0 超过15秒。");

		Logger.Info("【PLC配方写入PC地址握手】写入 PLC配方写入PC地址请求(21011)=1。");
		Plc.Write.PLC配方写入PC地址请求 = 1;
		result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
		if (result.IsError())
			return result;

		var timeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < timeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
			if (result.IsError())
				return result;

			Logger.Info("【PLC配方写入PC地址握手】读取 PLC配方写入PC地址响应(22011)={response}", Plc.Read.PLC配方写入PC地址响应);
			if (Plc.Read.PLC配方写入PC地址响应 == 1)
			{
				Logger.Info("【PLC配方写入PC地址握手】收到响应=1，复位 21011 和 22011。");
				Plc.Write.PLC配方写入PC地址请求 = 0;
				result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
				if (result.IsError())
					return result;

				Plc.Write.PLC配方写入PC地址响应 = 0;
				result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址响应);
				return result;
			}
		}

		Plc.Write.PLC配方写入PC地址请求 = 0;
		_ = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
		return Result.Err("等待 PLC配方写入PC地址响应(22011)=1 超过15秒。");
	}

	public async Task<Result> DistributeRecipeAsync(ProductRecipe recipe)
	{
		var structInfo = recipe.GetStructInfo();
		Logger.Info("Start distribute recipe '{recipeName}'", recipe.Name);
		try
		{
			foreach (var group in BuildRecipePointGroups(recipe, structInfo, p => p.WriterData?.ToString()))
			{
				var connection = ConnectionManageService.GetConnection(group.ConnectionName) as IBinaryWriter;
				if (connection is null)
					return Result.Err($"Distribute recipe writer '{group.ConnectionName}' is not found.");

				var writePointResult = await Task.Run(() => recipe.WritePointGroup(group.PointGroup, connection));
				if (writePointResult.IsError())
				{
					Logger.Error(writePointResult.Exception,
						"Distribute recipe write point group error! writer='{writer}' start={start} end={end} {msg}",
						group.ConnectionName, group.PointGroup.Start, group.PointGroup.End,
						writePointResult.Message);
					return writePointResult;
				}
			}

			Plc.Write.上位机当前配方ID = (short)recipe.Id;
			Plc.Write.WritePoint(PlcStructInfo.上位机当前配方ID).Unwarp();
		}
		finally
		{
			Logger.Info("End distribute recipe '{recipeName}'", recipe.Name);
		}

		return Result.OK;
	}

	public async Task<Result> NotifyRecipeDistributedToPlcAsync()
	{
		Logger.Info("【配方下发】配方值写入完成，开始执行 PLC配方写入PC地址请求/响应 握手。");
		return await RequestPlcWriteRecipeAsync();
	}

	public async Task<Result> RequestDevicePrepareRecipeAsync()
	{
		Logger.Info("【请求设备准备配方】开始，使用 PC配方写入完成信号(21230) / PLC读取配方ID切换成功响应(22414)。");
		var state = await RequestPlcRecipeWriteCompleteAckAsync("请求设备准备配方");
		return state == MesRecipePrepareState.Ready
			? Result.OK
			: Result.Err($"请求设备准备配方失败：{state}");
	}

	public async Task<Result> CollectRecipeAsync(ProductRecipe recipe)
	{
		var reqResult = await RequestPlcWriteRecipeAsync();
		if (reqResult.IsError())
			return reqResult;

		var structInfo = recipe.GetStructInfo();
		foreach (var group in BuildRecipePointGroups(recipe, structInfo, p => p.ReaderData?.ToString()))
		{
			var connection = ConnectionManageService.GetConnection(group.ConnectionName) as IBinaryReader;
			if (connection is null)
				return Result.Err($"Collect recipe reader '{group.ConnectionName}' is not found.");

			var readPointResult = await Task.Run(() => recipe.ReadPointGroup(group.PointGroup, connection));
			if (readPointResult.IsError())
			{
				Logger.Error(readPointResult.Exception,
					"collect recipe read point group error! reader='{reader}' start={start} end={end} {msg}",
					group.ConnectionName, group.PointGroup.Start, group.PointGroup.End,
					readPointResult.Message);
				return Result.Err(readPointResult);
			}
		}

		return Result.OK;
	}

	private static List<(string ConnectionName, IBinaryPointGroupInfo PointGroup)> BuildRecipePointGroups(
		ProductRecipe recipe,
		IBinaryStructInfo structInfo,
		Func<IBinaryPointInfo, string?> getConnectionName)
	{
		const int maxWordsPerGroup = 100;
		var points = structInfo.Members.Values
			.OfType<IBinaryPointInfo>()
			.Select(pointInfo => ProductRecipe.GetEffectivePointInfo(recipe, pointInfo))
			.Select(pointInfo => new
			{
				Point = pointInfo,
				ConnectionName = getConnectionName(pointInfo),
				WordLength = Math.Max(1, (int)Math.Ceiling(pointInfo.ByteLength / 2.0)),
			})
			.Where(t => string.IsNullOrWhiteSpace(t.ConnectionName) == false)
			.OrderBy(t => t.ConnectionName)
			.ThenBy(t => t.Point.Offset)
			.ToList();

		var groups = new List<(string ConnectionName, IBinaryPointGroupInfo PointGroup)>();
		foreach (var connectionGroup in points.GroupBy(t => t.ConnectionName!))
		{
			var currentPoints = new List<IBinaryPointInfo>();
			var currentStart = 0;
			var currentEndExclusive = 0;

			foreach (var item in connectionGroup)
			{
				var pointStart = item.Point.Offset;
				var pointEndExclusive = item.Point.Offset + item.WordLength;
				var wouldExceedGroup = currentPoints.Count > 0 && pointEndExclusive - currentStart > maxWordsPerGroup;
				if (wouldExceedGroup)
				{
					groups.Add((connectionGroup.Key, CreateRecipePointGroup(connectionGroup.Key, currentStart, currentEndExclusive, currentPoints)));
					currentPoints = [];
					currentStart = 0;
					currentEndExclusive = 0;
				}

				if (currentPoints.Count == 0)
				{
					currentStart = pointStart;
					currentEndExclusive = pointEndExclusive;
				}
				else
				{
					currentEndExclusive = Math.Max(currentEndExclusive, pointEndExclusive);
				}

				currentPoints.Add(item.Point);
			}

			if (currentPoints.Count > 0)
				groups.Add((connectionGroup.Key, CreateRecipePointGroup(connectionGroup.Key, currentStart, currentEndExclusive, currentPoints)));
		}

		return groups;
	}

	private static IBinaryPointGroupInfo CreateRecipePointGroup(
		string connectionName,
		int start,
		int endExclusive,
		List<IBinaryPointInfo> points)
	{
		return new BinaryPointGroupInfo
		{
			Name = $"Recipe_{connectionName}_{start}_{endExclusive}",
			Start = start,
			End = endExclusive,
			Source = start.ToString(),
			ByteLength = Math.Max(0, (endExclusive - start) * 2),
			ByteFormat = ByteFormat.CDAB,
			Points = points,
		};
	}

	public bool CheckRecipe(string 机种型号)
	{
		var productRecipe = Recipe.GetRecipes().FirstOrDefault(t => t.机种型号 == 机种型号);
		return productRecipe?.Name == RecipeName;
	}

	public Result RequestStartSwitchRecipe(string 机种型号)
	{
		var productRecipe = Recipe.GetRecipes().FirstOrDefault(t => t.机种型号 == 机种型号);
		if (productRecipe is null)
			return Result.Err("recipe not found!");

		请求切换的配方 = productRecipe;
		return Result.OK;
	}

	public ProductRecipe SetCurrentRecipeByMesModelName(string modelName)
	{
		var recipes = Recipe.GetRecipes().ToList();
		if (recipes.Count == 0)
		{
			var loadResult = Recipe.LoadRecipes();
			if (loadResult.IsError())
				Logger.Warn("MES下发当前配方 '{modelName}'，但读取本地配方列表失败: {msg}", modelName, loadResult.Message);

			recipes = Recipe.GetRecipes().ToList();
		}

		var productRecipe = recipes.FirstOrDefault(t => string.Equals(t.Name, modelName, StringComparison.OrdinalIgnoreCase))
		                    ?? recipes.FirstOrDefault(t => string.Equals(t.机种型号, modelName, StringComparison.OrdinalIgnoreCase));

		if (productRecipe is null)
		{
			productRecipe = new ProductRecipe
			{
				Name = modelName,
				机种型号 = modelName,
			};
			Logger.Warn("MES下发当前配方 '{modelName}'，本地配方列表未找到同名配方，仅用于生产信息显示。", modelName);
		}

		当前下发配方 = productRecipe;
		RecipeName = productRecipe.Name;
		return productRecipe;
	}

	public async Task<MesRecipePrepareState> PrepareRecipeByMesModelNameAsync(string modelName)
	{
		var lockTaken = await _mesRecipePrepareLock.WaitAsync(TimeSpan.FromSeconds(35));
		if (lockTaken == false)
		{
			Logger.Error("【配方切换】等待其它工站配方切换释放锁超过35秒，流程退出。");
			return MesRecipePrepareState.PlcResponseTimeout;
		}

		try
		{
			Logger.Info("【配方切换】MES MODEL_NAME={modelName}，开始与当前配方对比。", modelName);

			var recipes = Recipe.GetRecipes().ToList();
			if (recipes.Count == 0)
			{
				Logger.Info("【配方切换】本地配方缓存为空，开始重新加载全部配方。");
				var loadResult = Recipe.LoadRecipes();
				if (loadResult.IsError())
				{
					Logger.Error("【配方切换】读取本地配方列表失败: {msg}", loadResult.Message);
					return MesRecipePrepareState.Failed;
				}

				recipes = Recipe.GetRecipes().ToList();
			}

			var targetRecipe = recipes.FirstOrDefault(t => IsMesModelMatched(t, modelName));
			if (targetRecipe is null)
			{
				Logger.Error("【配方切换】未找到与 MES MODEL_NAME={modelName} 相同的本地配方，流程退出。", modelName);
				return MesRecipePrepareState.RecipeNotFound;
			}

			var readPlcRecipeIdResult = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC当前配方ID);
			if (readPlcRecipeIdResult.IsError())
			{
				Logger.Error("【配方切换】读取 PLC当前配方ID 失败: {msg}", readPlcRecipeIdResult.Message);
				return MesRecipePrepareState.Failed;
			}

			var currentRecipeText = 当前下发配方 is null
				? RecipeName
				: $"{当前下发配方.Name}(Id={当前下发配方.Id}, 机种={当前下发配方.机种型号})";
			Logger.Info("【配方切换】当前配方={currentRecipe}，PLC当前配方ID={plcRecipeId}，MES目标配方={targetRecipe}(Id={targetId}, 机种={targetModel})。",
				currentRecipeText, Plc.Read.PLC当前配方ID, targetRecipe.Name, targetRecipe.Id, targetRecipe.机种型号);

			var isSoftwareRecipeMatched = IsCurrentRecipeMatched(targetRecipe, modelName);
			var isPlcRecipeIdMatched = Plc.Read.PLC当前配方ID == targetRecipe.Id;
			if (isSoftwareRecipeMatched && isPlcRecipeIdMatched)
			{
				当前下发配方 = targetRecipe;
				RecipeName = targetRecipe.Name;
				Logger.Info("【配方切换】当前配方与 PLC当前配方ID 均已与 MES MODEL_NAME 一致，无需下发。");
				return MesRecipePrepareState.Ready;
			}

			Logger.Warn("【配方切换】检测到配方不一致，软件配方匹配={softwareMatched}，PLC当前配方ID匹配={plcMatched}，目标配方={recipeName}(Id={recipeId})。",
				isSoftwareRecipeMatched, isPlcRecipeIdMatched, targetRecipe.Name, targetRecipe.Id);

			var confirmSwitch = await ConfirmRecipeSwitchAsync(targetRecipe, Plc.Read.PLC当前配方ID);
			if (confirmSwitch == false)
			{
				Logger.Warn("【配方切换】用户取消配方切换，流程退出。");
				return MesRecipePrepareState.UserCanceled;
			}

			Logger.Info("【配方切换】用户确认配方切换，开始执行配方下发逻辑: {recipeName}。", targetRecipe.Name);
			var distributeResult = await DistributeRecipeAsync(targetRecipe);
			if (distributeResult.IsError())
			{
				Logger.Error("【配方切换】配方下发失败: {msg}", distributeResult.Message);
				return MesRecipePrepareState.Failed;
			}

			Logger.Info("【配方切换】配方下发完成，开始执行 PLC配方写入PC地址请求/响应 握手。");
			var plcAckResult = await RequestPlcWriteRecipeAsync();
			if (plcAckResult.IsError())
			{
				Logger.Error("【配方切换】PLC配方写入PC地址请求/响应握手失败: {msg}", plcAckResult.Message);
				return MesRecipePrepareState.Failed;
			}

			当前下发配方 = targetRecipe;
			RecipeName = targetRecipe.Name;
			Logger.Info("【配方切换】PLC配方写入PC地址响应(22011)=1，配方切换成功。");
			return MesRecipePrepareState.Ready;
		}
		finally
		{
			if (lockTaken)
				_mesRecipePrepareLock.Release();
		}
	}

	private async Task<bool> ConfirmRecipeSwitchAsync(ProductRecipe targetRecipe, short plcRecipeId)
	{
		var tcs = new TaskCompletionSource<bool>();
		Avalonia.Threading.Dispatcher.UIThread.Post(async () =>
		{
			try
			{
				if (AvaloniaApplication.Current?.AppVM is not AppVM appVM)
				{
					Logger.Error("【配方切换】无法获取 UI AppVM，取消自动配方切换。");
					tcs.TrySetResult(false);
					return;
				}

				var message =
					$"是否执行配方切换？\n\n当前PLC配方ID：{plcRecipeId}\n目标配方：{targetRecipe.Name}\n目标配方ID：{targetRecipe.Id}";
				var confirm = await appVM.ShowConfirmMessageBox(message, "配方切换确认");
				tcs.TrySetResult(confirm);
			}
			catch (Exception ex)
			{
				Logger.Error(ex, "【配方切换】弹出配方切换确认框失败: {msg}", ex.Message);
				tcs.TrySetResult(false);
			}
		});

		var completedTask = await Task.WhenAny(tcs.Task, Task.Delay(TimeSpan.FromSeconds(30)));
		if (completedTask == tcs.Task)
			return await tcs.Task;

		Logger.Warn("【配方切换】配方切换确认框30秒未确认，按取消处理。");
		return false;
	}

	private async Task<MesRecipePrepareState> RequestPlcRecipeWriteCompleteAckAsync(string logPrefix = "配方切换")
	{
		var resetResult = await ResetRecipeCompleteHandshakeAsync(logPrefix);
		if (resetResult.IsError())
			return MesRecipePrepareState.Failed;

		var resetTimeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < resetTimeoutAt)
		{
			await Task.Delay(200);
			var resetReadResult = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC读取配方ID切换成功响应);
			if (resetReadResult.IsError())
			{
				Logger.Error("【{logPrefix}】读取 PLC读取配方ID切换成功响应(22414) 失败: {msg}", logPrefix, resetReadResult.Message);
				return MesRecipePrepareState.Failed;
			}

			Logger.Info("【{logPrefix}】等待 PLC读取配方ID切换成功响应(22414) 复位，当前响应={response}", logPrefix, Plc.Read.PLC读取配方ID切换成功响应);
			if (Plc.Read.PLC读取配方ID切换成功响应 == 0)
				break;
		}

		if (Plc.Read.PLC读取配方ID切换成功响应 != 0)
		{
			Logger.Error("【{logPrefix}】等待 PLC读取配方ID切换成功响应(22414)=0 超过15秒。", logPrefix);
			return MesRecipePrepareState.PlcResponseTimeout;
		}

		Logger.Info("【{logPrefix}】写入 PC配方写入完成信号(21230)=1。", logPrefix);
		Plc.Write.PC配方写入完成信号 = 1;
		var writeResult = await Plc.Write.WritePointAsync(PlcStructInfo.PC配方写入完成信号);
		if (writeResult.IsError())
		{
			Logger.Error("【{logPrefix}】写入 PC配方写入完成信号(21230)=1 失败: {msg}", logPrefix, writeResult.Message);
			return MesRecipePrepareState.Failed;
		}

		var timeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < timeoutAt)
		{
			await Task.Delay(200);
			var readResult = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC读取配方ID切换成功响应);
			if (readResult.IsError())
			{
				Logger.Error("【{logPrefix}】读取 PLC读取配方ID切换成功响应(22414) 失败: {msg}", logPrefix, readResult.Message);
				return MesRecipePrepareState.Failed;
			}

			Logger.Info("【{logPrefix}】读取 PLC读取配方ID切换成功响应(22414)={response}", logPrefix, Plc.Read.PLC读取配方ID切换成功响应);
			if (Plc.Read.PLC读取配方ID切换成功响应 == 1)
			{
				Logger.Info("【{logPrefix}】收到 PLC 响应=1，复位 PC配方写入完成信号(21230) 和 PLC读取配方ID切换成功响应(22414)。", logPrefix);
				var clearResult = await ResetRecipeCompleteHandshakeAsync(logPrefix);
				if (clearResult.IsError())
				{
					Logger.Error("【{logPrefix}】成功响应后复位配方完成握手信号失败: {msg}", logPrefix, clearResult.Message);
					return MesRecipePrepareState.Failed;
				}

				return MesRecipePrepareState.Ready;
			}
		}

		Logger.Error("【{logPrefix}】等待 PLC读取配方ID切换成功响应(22414)=1 超过15秒。", logPrefix);
		return MesRecipePrepareState.PlcResponseTimeout;
	}

	private async Task<Result> ResetRecipeCompleteHandshakeAsync(string logPrefix)
	{
		Logger.Info("【{logPrefix}】复位 PC配方写入完成信号(21230)=0。", logPrefix);
		Plc.Write.PC配方写入完成信号 = 0;
		var clearRequestResult = await Plc.Write.WritePointAsync(PlcStructInfo.PC配方写入完成信号);
		if (clearRequestResult.IsError())
		{
			Logger.Error("【{logPrefix}】复位 PC配方写入完成信号(21230) 失败: {msg}", logPrefix, clearRequestResult.Message);
			return clearRequestResult;
		}

		var readResponseResult = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC读取配方ID切换成功响应);
		if (readResponseResult.IsError())
		{
			Logger.Error("【{logPrefix}】读取 PLC读取配方ID切换成功响应(22414) 失败: {msg}", logPrefix, readResponseResult.Message);
			return readResponseResult;
		}

		if (Plc.Read.PLC读取配方ID切换成功响应 == 0)
			return Result.OK;

		Logger.Info("【{logPrefix}】复位 PLC读取配方ID切换成功响应(22414)=0。", logPrefix);
		Plc.Write.PLC读取配方ID切换成功响应 = 0;
		var clearResponseResult = await Plc.Write.WritePointAsync(PlcStructInfo.PLC读取配方ID切换成功响应);
		if (clearResponseResult.IsError())
		{
			Logger.Error("【{logPrefix}】复位 PLC读取配方ID切换成功响应(22414) 失败: {msg}", logPrefix, clearResponseResult.Message);
			return clearResponseResult;
		}

		return Result.OK;
	}

	private bool IsCurrentRecipeMatched(ProductRecipe targetRecipe, string modelName)
	{
		if (当前下发配方 is not null)
		{
			return 当前下发配方.Id == targetRecipe.Id ||
			       IsMesModelMatched(当前下发配方, modelName);
		}

		return string.Equals(RecipeName, targetRecipe.Name, StringComparison.OrdinalIgnoreCase) ||
		       string.Equals(RecipeName, targetRecipe.机种型号, StringComparison.OrdinalIgnoreCase);
	}

	private static bool IsMesModelMatched(ProductRecipe recipe, string modelName)
	{
		return string.Equals(recipe.Name, modelName, StringComparison.OrdinalIgnoreCase) ||
		       string.Equals(recipe.机种型号, modelName, StringComparison.OrdinalIgnoreCase);
	}

	public bool CheckRecipeMono(string 机种型号)
	{
		var productRecipe = Recipe.GetRecipes().FirstOrDefault(t => t.机种型号 == 机种型号);
		if (productRecipe?.Name != RecipeName)
			return false;

		EnsureFeederRows(productRecipe, 6);
		var 产品上料信息 = productRecipe.产品上料信息;

		bool CheckFeeder(int index, string currentMono, Action<FeederMonoState> setState, bool skipWhenCurrentEmpty = false)
		{
			var configInfo = 产品上料信息[index];
			if (configInfo.是否使用 == false || (skipWhenCurrentEmpty && string.IsNullOrWhiteSpace(currentMono)))
			{
				setState(FeederMonoState.Matched);
				return true;
			}

			var matched = IsMatch(currentMono, configInfo);
			setState(matched ? FeederMonoState.Matched : FeederMonoState.NotMatched);
			return matched;
		}

		var feeder1Matched = CheckFeeder(0, 飞达1物料码, state => 飞达1物料状态 = state);
		var feeder2Matched = CheckFeeder(1, 飞达2物料码, state => 飞达2物料状态 = state);
		var feeder3Matched = CheckFeeder(2, 飞达3物料码, state => 飞达3物料状态 = state);
		var feeder4Matched = CheckFeeder(3, 飞达4物料码, state => 飞达4物料状态 = state);
		var feeder5Matched = CheckFeeder(4, 飞达5物料码, state => 飞达5物料状态 = state, true);
		var feeder6Matched = CheckFeeder(5, 飞达6物料码, state => 飞达6物料状态 = state, true);

		return feeder1Matched &&
		       feeder2Matched &&
		       feeder3Matched &&
		       feeder4Matched &&
		       feeder5Matched &&
		       feeder6Matched;
	}

	private static bool IsMatch(string currentMono, 产品上料信息 configInfo)
	{
		if (string.IsNullOrWhiteSpace(currentMono))
			return false;

		return string.Equals(configInfo.上料码1, currentMono, StringComparison.Ordinal) ||
		       string.Equals(configInfo.上料码2, currentMono, StringComparison.Ordinal) ||
		       string.Equals(configInfo.上料码3, currentMono, StringComparison.Ordinal) ||
		       string.Equals(configInfo.上料码4, currentMono, StringComparison.Ordinal) ||
		       string.Equals(configInfo.上料码5, currentMono, StringComparison.Ordinal);
	}

	private static void EnsureFeederRows(ProductRecipe recipe, int count)
	{
		recipe.产品上料信息 ??= [];
		for (var i = recipe.产品上料信息.Count; i < count; i++)
		{
			recipe.产品上料信息.Add(new 产品上料信息
			{
				是否使用 = true,
				上料位置名 = $"飞达{i + 1}",
				上料位置识别码 = "",
				上料码1 = "",
			});
		}
	}
}
