using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.KvStorage;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.UI.Dialogs;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
[ObservableObject]
public partial class CoreService : CoreServiceBase
{
	public SemaphoreSlim RecipeSwitchLock { get; private set; } = new(1, 1);
	public SemaphoreSlim PrinterLock { get; private set; } = new(1, 1);
	public required ConnectionManageService ConnectionManageService { get; init; }
	public required ILogger Logger { get; init; }
	public required IKeyValueStorage KeyValueStorage { get; init; }
	public required PlcService Plc { get; init; }
	public required RecipeService RecipeService { get; init; }

	public required AppConfig AppConfig { get; init; }
	public partial ObservableList<NozzleContext> NozzleContexts { get; set; } = [];
	public partial ObservableList<MaterialSpaceContext> MaterialContexts { get; set; } = [];
	public partial ObservableList<DeviceStatusContext> DeviceStatusContexts { get; set; } = [];
	public partial ObservableList<WorkPositionContext> WorkPositionContexts { get; set; } = [];
	public partial string WorkerNo { get; set; } = "M000086";
	public partial string WorkOrderNo { get; set; } = "";
	public partial bool MesSkipEnabled { get; set; }
	public partial bool MaterialCheck { get; set; } = true;
	public partial bool RecipeCheck { get; set; } = true;
	public partial ProductRecipe? WorkRecipe { get; set; }

	public CoreService()
	{
		NozzleContext.CreateList(NozzleContexts, CommonAppConfig.NozzleCount);
		MaterialSpaceContext.CreateList(MaterialContexts, CommonAppConfig.MaterialSpaceCount);
		WorkPositionContext.CreateList(WorkPositionContexts, 2);
		DeviceStatusContext.CreateList(DeviceStatusContexts);
	}

	protected override Task OnInitialize(object? ctx, object? args)
	{
		var materialCodesRet = KeyValueStorage.GetValue<string[]>("MaterialSpaceCodes");
		if (materialCodesRet.IsOk())
		{
			foreach (var materialContext in MaterialContexts)
			{
				materialContext.MaterialCode = materialCodesRet.Value!.Length >= materialContext.Id
					? materialCodesRet.Value![materialContext.Id]
					: "";
			}
		}


		return base.OnInitialize(ctx, args);
	}


	protected override Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
			UpdateWorkPositionContexts();
			UpdateMaterialSpaceContexts();
			UpdateNozzleContexts();

			if (Plc.Read.PLC读取配方ID切换成功响应 == 1 && Plc.Read.PC配方写入完成信号 == 1)
			{
				Plc.Write.PC配方写入完成信号 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.PC配方写入完成信号)).Unwarp();
			}
		}

		return Task.CompletedTask;
	}

	private void UpdateWorkPositionContexts()
	{
	
	}

	private void UpdateNozzleContexts()
	{
		foreach (var nozzleContext in NozzleContexts)
		{
			nozzleContext.Value = nozzleContext.Config.Id switch
			{
				1 => Plc.Read.吸头1压力,
				2 => Plc.Read.吸头2压力,
				3 => Plc.Read.吸头3压力,
				4 => Plc.Read.吸头4压力,
				5 => Plc.Read.吸头5压力,
				6 => Plc.Read.吸头6压力,
				7 => Plc.Read.吸头7压力,
				8 => Plc.Read.吸头8压力,
				9 => Plc.Read.吸头9压力,
				10 => Plc.Read.吸头10压力,
				_ => 0
			};
		}
	}

	private void UpdateMaterialSpaceContexts()
	{
		if (Plc.Read.Feeder1解锁请求 != 0 && Plc.Read.Feeder1解锁请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder1解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder1解锁请求));
			Logger.Info("Reset material 1 request");
		}

		if (Plc.Read.Feeder2解锁请求 != 0 && Plc.Read.Feeder2解锁请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder2解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder2解锁请求));
			Logger.Info("Reset material 2 request");
		}

		if (Plc.Read.Feeder3解锁请求 != 0 && Plc.Read.Feeder3解锁请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder3解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder3解锁请求));
			Logger.Info("Reset material 3 request");
		}

		if (Plc.Read.Feeder4解锁请求 != 0 && Plc.Read.Feeder4解锁请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder4解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder4解锁请求));
			Logger.Info("Reset material 4 request");
		}

		if (Plc.Read.Feeder5解锁请求 != 0 && Plc.Read.Feeder5解锁请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder5解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder5解锁请求));
			Logger.Info("Reset material 5 request");
		}

		if (Plc.Read.Feeder6解锁请求 != 0 && Plc.Read.Feeder6解锁请求 == Plc.Read.Feeder6换料响应)
		{
			Plc.Write.Feeder6解锁请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder6解锁请求));
			Logger.Info("Reset material 6 request");
		}

		// 
		if (Plc.Read.Feeder1换料请求 != 0 && Plc.Read.Feeder1换料请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder1换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder1换料请求));
			Logger.Info("Reset material 1 request");
		}

		if (Plc.Read.Feeder2换料请求 != 0 && Plc.Read.Feeder2换料请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder2换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder2换料请求));
			Logger.Info("Reset material 2 request");
		}

		if (Plc.Read.Feeder3换料请求 != 0 && Plc.Read.Feeder3换料请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder3换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder3换料请求));
			Logger.Info("Reset material 3 request");
		}

		if (Plc.Read.Feeder4换料请求 != 0 && Plc.Read.Feeder4换料请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder4换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder4换料请求));
			Logger.Info("Reset material 4 request");
		}

		if (Plc.Read.Feeder5换料请求 != 0 && Plc.Read.Feeder5换料请求 == Plc.Read.Feeder1换料响应)
		{
			Plc.Write.Feeder5换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder5换料请求));
			Logger.Info("Reset material 5 request");
		}

		if (Plc.Read.Feeder6换料请求 != 0 && Plc.Read.Feeder6换料请求 == Plc.Read.Feeder6换料响应)
		{
			Plc.Write.Feeder6换料请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.Feeder6换料请求));
			Logger.Info("Reset material 6 request");
		}

		foreach (var context in MaterialContexts)
		{
			switch (context.Id)
			{
				case 1:
					context.IsUnlocked = Plc.Read.Feeder1解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder1抛料率;
					context.RemainCount = Plc.Read.Feeder1物料剩余数量;
					break;
				case 2:
					context.IsUnlocked = Plc.Read.Feeder2解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder2抛料率;
					context.RemainCount = Plc.Read.Feeder2物料剩余数量;
					break;
				case 3:
					context.IsUnlocked = Plc.Read.Feeder3解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder3抛料率;
					context.RemainCount = Plc.Read.Feeder3物料剩余数量;
					break;
				case 4:
					context.IsUnlocked = Plc.Read.Feeder4解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder4抛料率;
					context.RemainCount = Plc.Read.Feeder4物料剩余数量;
					break;
				case 5:
					context.IsUnlocked = Plc.Read.Feeder5解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder5抛料率;
					context.RemainCount = Plc.Read.Feeder5物料剩余数量;
					break;
				case 6:
					context.IsUnlocked = Plc.Read.Feeder6解锁响应 == 1;
					context.ScrapRate = Plc.Read.Feeder6抛料率;
					context.RemainCount = Plc.Read.Feeder6物料剩余数量;
					break;
			}

			context.CheckMaterialState();
		}
	}

	public Result SetMaterialCount(int id, int count)
	{
		var lockedErr = Result.Err("Material space is locked, can't set material count");
		var reqNoResetErr = Result.Err("Material request not reset, can't set material count");
		Result writeResult;
		switch (id)
		{
			case 1:
				if (Plc.Read.Feeder1解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder1换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder1PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder1PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder1换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder1换料请求));

				if (CommonAppConfig.IsDevTestMode)
				{
					Plc.Write.Feeder1物料剩余数量 = count;
					Plc.Write.WritePoint(nameof(PlcStruct.Feeder1物料剩余数量));
					Plc.Write.Feeder1换料响应 = 3;
					Plc.Write.WritePoint(nameof(PlcStruct.Feeder1换料响应));
				}

				break;
			case 2:
				if (Plc.Read.Feeder2解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder2换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder2PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder2PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder2换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder2换料请求));

				break;
			case 3:
				if (Plc.Read.Feeder3解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder3换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder3PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder3PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder3换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder3换料请求));
				break;
			case 4:
				if (Plc.Read.Feeder4解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder4换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder4PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder4PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder4换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder4换料请求));
				break;
			case 5:
				if (Plc.Read.Feeder5解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder5换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder5PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder5PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder5换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder5换料请求));
				break;
			case 6:
				if (Plc.Read.Feeder6解锁响应 != 1) return lockedErr;
				if (Plc.Read.Feeder6换料请求 != 0) return reqNoResetErr;
				Plc.Write.Feeder6PC下发物料上料数量 = count;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder6PC下发物料上料数量));
				if (writeResult.IsError()) break;
				Plc.Write.Feeder6换料请求 = 3;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder6换料请求));
				break;
		}

		return writeResult;
	}

	public Result SetMaterialSpaceLock(int id, bool isLock)
	{
		Result writeResult;
		var value = (short)(isLock ? 1 : 0);
		switch (id)
		{
			case 1:
				Plc.Write.Feeder1解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder1解锁请求));
				break;
			case 2:
				Plc.Write.Feeder2解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder2解锁请求));
				break;
			case 3:
				Plc.Write.Feeder3解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder3解锁请求));
				break;
			case 4:
				Plc.Write.Feeder4解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder4解锁请求));
				break;
			case 5:
				Plc.Write.Feeder5解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder5解锁请求));
				break;
			case 6:
				Plc.Write.Feeder6解锁请求 = value;
				writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder6解锁请求));
				break;
		}

		if (CommonAppConfig.IsDevTestMode)
		{
			switch (id)
			{
				case 1:
					Plc.Write.Feeder1解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder1解锁响应));
					break;
				case 2:
					Plc.Write.Feeder2解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder2解锁响应));
					break;
				case 3:
					Plc.Write.Feeder3解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder3解锁响应));
					break;
				case 4:
					Plc.Write.Feeder4解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder4解锁响应));
					break;
				case 5:
					Plc.Write.Feeder5解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder5解锁响应));
					break;
				case 6:
					Plc.Write.Feeder6解锁响应 = value;
					writeResult = Plc.Write.WritePoint(nameof(PlcStruct.Feeder6解锁响应));
					break;
			}
		}

		return writeResult;
	}

	public async Task<Result> RequestPlcWriteRecipeAsync()
	{
		Logger.Info("【PLC配方写入PC地址握手】开始，使用 PLC配方写入PC地址请求(21011) / PLC配方写入PC地址响应(22011)。");

		Plc.Write.PLC配方写入PC地址请求 = 0;
		var result = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址响应));
		if (result.IsError()) return result;

		Plc.Write.PLC配方写入PC地址响应 = 0;
		result = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址响应));
		if (result.IsError()) return result;

		var resetTimeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < resetTimeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(nameof(PlcStruct.PLC配方写入PC地址响应));
			if (result.IsError()) return result;

			Logger.Info("【PLC配方写入PC地址握手】等待 PLC配方写入PC地址响应(22011)=0，当前响应={response}", Plc.Read.PLC配方写入PC地址响应);
			if (Plc.Read.PLC配方写入PC地址响应 == 0)
				break;
		}

		if (Plc.Read.PLC配方写入PC地址响应 != 0)
			return Result.Err("等待 PLC配方写入PC地址响应(22011)=0 超过15秒。");

		Logger.Info("【PLC配方写入PC地址握手】写入 PLC配方写入PC地址请求(21011)=1。");
		Plc.Write.PLC配方写入PC地址请求 = 1;
		result = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址请求));
		if (result.IsError())
			return result;

		var timeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < timeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(nameof(PlcStruct.PLC配方写入PC地址响应));
			if (result.IsError())
				return result;

			Logger.Info("【PLC配方写入PC地址握手】读取 PLC配方写入PC地址响应(22011)={response}", Plc.Read.PLC配方写入PC地址响应);
			if (Plc.Read.PLC配方写入PC地址响应 == 1)
			{
				Logger.Info("【PLC配方写入PC地址握手】收到响应=1，复位 21011 和 22011。");
				Plc.Write.PLC配方写入PC地址请求 = 0;
				result = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址请求));
				if (result.IsError())
					return result;

				Plc.Write.PLC配方写入PC地址响应 = 0;
				result = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址响应));
				return result;
			}
		}

		Plc.Write.PLC配方写入PC地址请求 = 0;
		_ = await Plc.Write.WritePointAsync(nameof(PlcStruct.PLC配方写入PC地址请求));
		return Result.Err("等待 PLC配方写入PC地址响应(22011)=1 超过15秒。");
	}

	public async Task<Result> DistributeRecipeAsync(ProductRecipe recipe)
	{
		if (recipe.IsFullRecipe == false)
			recipe.RefFullRecipe = RecipeService.GetRecipe(recipe.RefFullRecipeName!).Value;
		var points = recipe.Points ?? recipe.RefFullRecipe?.Points;
		if (points is null)
		{
			return Result.Err("recipe points not found!");
		}

		var structInfo = points.GetStructInfo();
		Logger.Info("[RECIPE CHANGE] start distribute recipe '{recipeName}'", recipe.Name);
		try
		{
			Plc.Write.PC配方写入完成信号 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.PC配方写入完成信号)).Unwarp();
			Plc.Write.PLC读取配方ID切换成功响应 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.PLC读取配方ID切换成功响应)).Unwarp();
			foreach (var group in structInfo.Members.Values.OfType<IBinaryPointGroupInfo>())
			{
				if (group.Points.FirstOrDefault()?.ReaderData is not string readerName)
					continue;
				var connection = ConnectionManageService.GetConnection(readerName) as IBinaryWriter;
				if (connection is null)
					return Result.Err($"distribute recipe writer '{readerName}' is not found.");

				var writePointResult = await Task.Run(() => points.WritePointGroup(group, connection));
				if (writePointResult.IsError())
				{
					Logger.Error(writePointResult.Exception,
						"[RECIPE CHANGE] distribute recipe write point group error! writer='{writer}' start={start} end={end} {msg}",
						readerName, group.Start, group.End,
						writePointResult.Message);
					return writePointResult;
				}
			}

			Plc.Write.上位机当前配方ID = (short)recipe.Id;
			Plc.Write.WritePoint(nameof(PlcStruct.上位机当前配方ID)).Unwarp();
			Plc.Write.PC配方写入完成信号 = 1;
			Plc.Write.WritePoint(nameof(PlcStruct.PC配方写入完成信号)).Unwarp();
		}
		finally
		{
			Logger.Info("[RECIPE CHANGE] end distribute recipe '{recipeName}'", recipe.Name);
		}

		return Result.OK;
	}

	public async Task<Result> CollectRecipeAsync(PointRecipeStruct recipe)
	{
		var reqResult = await RequestPlcWriteRecipeAsync();
		if (reqResult.IsError())
			return reqResult;

		var structInfo = recipe.GetStructInfo();

		foreach (var group in structInfo.Members.Values.OfType<IBinaryPointGroupInfo>()!)
		{
			var firstPoint = group.Points.FirstOrDefault();
			if (firstPoint?.ReaderData is not string readerName)
				continue;
			var connection = ConnectionManageService.GetConnection(readerName) as IBinaryReader;
			if (connection is null)
				return Result.Err($"Collect recipe reader '{readerName}' is not found.");

			var readPointResult = await Task.Run(() => recipe.ReadPointGroup(group, connection));
			if (readPointResult.IsError())
			{
				Logger.Error(readPointResult.Exception,
					"collect recipe read point group error! reader='{reader}' start={start} end={end} {msg}",
					readerName, group.Start, group.End,
					readPointResult.Message);
				return Result.Err(readPointResult);
			}
		}

		return Result.OK;
	}

	public Task TryCreateMaterialRecipe(string name)
	{
		var createMaterialRecipeVM = App.Current.IOC.Get<CreateMaterialRecipeVM>();
		createMaterialRecipeVM.InputRecipeName = name;
		return createMaterialRecipeVM.Show();
	}

	public class DayProductionIdContext
	{
		public static DayProductionIdContext Default { get; } = new DayProductionIdContext();
		public int Value { get; set; }
		public DateTime Time { get; set; }
	}

	public bool IsWorkPositionFree() => Plc.Read.工位1生产状态 == 2 && Plc.Read.工位2生产状态 == 2;

	public int GetDayProductionId()
	{
		lock (this)
		{
			var ctx = KeyValueStorage.GetValue("DayProductionIdContext", DayProductionIdContext.Default).Unwarp();
			var now = DateTime.Now;
			if (ctx.Time.Date != now.Date)
				ctx.Value = 1;
			else ctx.Value += 1;
			ctx.Time = now;
			KeyValueStorage.SetValue("DayProductionIdContext", ctx).Unwarp();
			return ctx.Value;
		}
	}

	public string GetImageZipID()
	{
		return Guid.NewGuid().ToString();
	}

	public void SaveMaterialSpaceCodes()
	{
		var array = MaterialContexts.Select(t => t.MaterialCode).ToArray();
		KeyValueStorage.SetValue("MaterialSpaceCodes", array);
	}
}