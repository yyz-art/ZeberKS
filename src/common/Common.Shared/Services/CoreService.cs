// using NLog;
// using ZC;
// using ZC.BinStructs;
// using ZC.BinStructs.Ext;
// using ZC.Mvvm;
// using ZitApp.BinStructs;
// namespace ZitApp.Services;
// public enum FeederMonoState
// {
// 	Matched,
// 	NotMatched,
// }
// [RegisterToIOC(LifetimeType.Singleton)]
// [ObservableObject]
// public partial class CoreService : CoreServiceBase
// {
// 	public required ConnectionManageService ConnectionManageService { get; init; }
// 	public required ILogger Logger { get; init; }
// 	public required PlcService Plc { get; init; }
// 	public required RecipeService Recipe { get; init; }
// 	public partial string RecipeName { get; set; } = "";
// 	public partial int ProductCount { get; private set; } = 1234;
// 	public partial double OkPrecent { get; private set; } = 55.69;
// 	public partial int CT { get; private set; } = 10;
// 	public partial string 工号 { get; set; } = "TestWorkNo0001";
// 	public partial string 工单号 { get; set; } = "WorkOrderNo0001";
// 	public partial ProductRecipe? 请求切换的配方 { get; set; }
// 	public partial ProductRecipe? 当前下发配方 { get; set; }
// 	public partial string 飞达1物料码 { get; set; } = "L-Test1";
// 	public partial FeederMonoState 飞达1物料状态 { get; set; } = FeederMonoState.NotMatched;
// 	public partial string 飞达2物料码 { get; set; } = "L-Test2";
// 	public partial FeederMonoState 飞达2物料状态 { get; set; } = FeederMonoState.NotMatched;
// 	public partial string 飞达3物料码 { get; set; } = "R-Test1";
// 	public partial FeederMonoState 飞达3物料状态 { get; set; } = FeederMonoState.NotMatched;
// 	public partial string 飞达4物料码 { get; set; } = "R-Test2";
// 	public partial FeederMonoState 飞达4物料状态 { get; set; } = FeederMonoState.NotMatched;
// 	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;
// 	protected override Task Main(CancellationToken ctk)
// 	{
// 		while (ctk.IsCancellationRequested == false)
// 		{
// 			Plc.WaitNextCycle();
// 			if (请求切换的配方 is { } reqRecipe)
// 			{
// 				请求切换的配方 = null;
// 				Logger.Info("find switch recipe request, start distribute recipe ...");
// 				var distributeRecipeResult = DistributeRecipeAsync(reqRecipe).Result;
// 				if (distributeRecipeResult.IsError())
// 				{
// 					Logger.Error("distribute recipe result error! {}", distributeRecipeResult.Message);
// 					continue;
// 				}
// 				Logger.Info("distribute recipe success!");
// 				当前下发配方 = reqRecipe;
// 			}
// 		}
// 		return Task.CompletedTask;
// 	}
// 	public async Task<Result> RequestPlcWriteRecipeAsync()
// 	{
// 		Result result;
// 		Logger.Info("Requesting plc write recipe...");
// 		do
// 		{
// 			Plc.Write.PLC配方写入PC地址请求 = 0;
// 			result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
// 			if (result.IsError()) break;
// 			// wait plc reset signal
// 			await Task.Delay(200);
// 			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
// 			if (result.IsError()) break;
// 			if (Plc.Read.PLC配方写入PC地址响应 != 0)
// 			{
// 				result = Result.Err("plc is not reset response signal!");
// 				break;
// 			}
// 			Plc.Write.PLC配方写入PC地址请求 = 1;
// 			result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
// 			if (result.IsError())
// 				break;
// 			// waiting plc write recipe
// 			await Task.Delay(500);
// 			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
// 			if (result.IsError()) break;
// 			if (Plc.Read.PLC配方写入PC地址响应 != 1)
// 			{
// 				result = Result.Err("plc write recipe response signal timeout!");
// 				break;
// 			}
// 		} while (false);
// 		Logger.Info("Request Plc write recipe end.");
// 		return result;
// 	}
// 	public async Task<Result> DistributeRecipeAsync(ProductRecipe recipe)
// 	{
// 		var structInfo = recipe.GetStructInfo();
// 		Logger.Info("Start distribute recipe '{recipeName}'", recipe.Name);
// 		try
// 		{
// 			foreach (var pointInfo in structInfo.Members.Values.OfType<IBinaryPointInfo>())
// 			{
// 				var writerName = pointInfo.WriterData?.ToString();
// 				if (writerName == null)
// 					continue;
// 				var connection = ConnectionManageService.GetConnection(writerName) as IBinaryWriter;
// 				var writePointResult = await recipe.WritePointAsync(pointInfo, connection);
// 				if (writePointResult.IsError())
// 				{
// 					Logger.Error(writePointResult.Exception,
// 						"Distribute recipe write point error! writer='{writer}' {msg}", writerName,
// 						writePointResult.Message);
// 					return writePointResult;
// 				}
// 			}
// 			Plc.Write.上位机当前配方ID = (short)recipe.Id;
// 			Plc.Write.WritePoint(PlcStructInfo.上位机当前配方ID).Unwarp();
// 		}
// 		finally
// 		{
// 			Logger.Info("End distribute recipe '{recipeName}'", recipe.Name);
// 		}
// 		return Result.OK;
// 	}
// 	public async Task<Result> CollectRecipeAsync(ProductRecipe recipe)
// 	{
// 		var reqResult = await RequestPlcWriteRecipeAsync();
// 		if (reqResult.IsError())
// 			return reqResult;
// 		var structInfo = recipe.GetStructInfo();
// 		foreach (var pointInfo in structInfo.Members.Values.OfType<IBinaryPointInfo>())
// 		{
// 			var readerName = pointInfo.ReaderData?.ToString();
// 			if (readerName == null)
// 				continue;
// 			var connection = ConnectionManageService.GetConnection(readerName) as IBinaryReader;
// 			var readPointResult = await recipe.ReadPointAsync(pointInfo, connection);
// 			Logger.Error(readPointResult.Exception,
// 				"collect recipe read point error! {msg}",
// 				readPointResult.Message);
// 			return Result.Err(readPointResult);
// 		}
// 		return Result.OK;
// 	}
// 	public bool CheckRecipe(string 机种型号)
// 	{
// 		var recipes = Recipe.GetRecipes() as List<ProductRecipe>;
// 		var productRecipe = recipes?.FirstOrDefault(t => t.机种型号 == 机种型号);
// 		if (productRecipe?.Name == RecipeName)
// 			return true;
// 		return false;
// 	}
// 	public Result RequestStartSwitchRecipe(string 机种型号)
// 	{
// 		var recipes = Recipe.GetRecipes() as List<ProductRecipe>;
// 		var productRecipe = recipes?.FirstOrDefault(t => t.机种型号 == 机种型号);
// 		if (productRecipe is null)
// 			return Result.Err("recipe not found!");
// 		请求切换的配方 = productRecipe;
// 		return Result.OK;
// 	}
// 	public bool CheckRecipeMono(string 机种型号)
// 	{
// 		var recipes = Recipe.GetRecipes() as List<ProductRecipe>;
// 		var productRecipe = recipes?.FirstOrDefault(t => t.机种型号 == 机种型号);
// 		// 配方不一致直接NG
// 		if (productRecipe?.Name != RecipeName)
// 			return false;
// 		var 产品上料信息 = productRecipe.产品上料信息;
// 		var l1 = 产品上料信息[0];
// 		var l2 = 产品上料信息[1];
// 		var r1 = 产品上料信息[2];
// 		var r2 = 产品上料信息[3];
// 		// 飞达1验证
// 		if (false == ((l1.上料码1 == 飞达1物料码) || (l1.上料码2 == 飞达1物料码) || (l1.上料码3 == 飞达1物料码) || (l1.上料码4 == 飞达1物料码)))
// 			飞达1物料状态 = FeederMonoState.NotMatched;
// 		else
// 			飞达1物料状态 = FeederMonoState.Matched;
// 		// 飞达2验证
// 		if (false == ((l2.上料码1 == 飞达2物料码) || (l2.上料码2 == 飞达2物料码) || (l2.上料码3 == 飞达2物料码) || (l2.上料码4 == 飞达2物料码)))
// 			飞达2物料状态 = FeederMonoState.NotMatched;
// 		else
// 			飞达2物料状态 = FeederMonoState.Matched;
// 		// 飞达3验证
// 		if (false == ((r1.上料码1 == 飞达3物料码) || (r1.上料码2 == 飞达3物料码) || (r1.上料码3 == 飞达3物料码) || (r1.上料码4 == 飞达3物料码)))
// 			飞达3物料状态 = FeederMonoState.NotMatched;
// 		else
// 			飞达3物料状态 = FeederMonoState.Matched;
// 		// 飞达4验证
// 		if (false == ((r2.上料码1 == 飞达4物料码) || (r2.上料码2 == 飞达4物料码) || (r2.上料码3 == 飞达4物料码) || (r2.上料码4 == 飞达4物料码)))
// 			飞达4物料状态 = FeederMonoState.NotMatched;
// 		else
// 			飞达4物料状态 = FeederMonoState.Matched;
// 		return 飞达1物料状态 == FeederMonoState.Matched &&
// 		       飞达2物料状态 == FeederMonoState.Matched &&
// 		       飞达3物料状态 == FeederMonoState.Matched &&
// 		       飞达4物料状态 == FeederMonoState.Matched;
// 	}
// }