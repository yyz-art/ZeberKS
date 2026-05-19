using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.KvStorage;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZC.UI.Utils;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Models;
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

	// public partial bool MesSkipEnabled { get; set; }
	// public partial bool MaterialCheck { get; set; } = true;
	// public partial bool RecipeCheck { get; set; } = true;
	public partial ProductRecipe? WorkRecipe { get; set; }

	private readonly object _materialSyncLock = new();

	/// <summary>
	/// 将工单配方中各 Id 的启用行同步到料位（界面颜色与扫码校验一致）。
	/// </summary>
	public void ApplyWorkRecipeToMaterialContexts()
	{
		lock (_materialSyncLock)
			ApplyWorkRecipeToMaterialContextsCore();
	}

	public void SyncMaterialContextFromWorkRecipe(MaterialSpaceContext context)
	{
		lock (_materialSyncLock)
			context.SyncFromWorkRecipe(WorkRecipe);
	}

	/// <summary>
	/// 扫码物料校验：同 Id 有启用行则与界面料号比对；无启用行则跳过。
	/// </summary>
	public bool TryValidateMaterialsForProduction(out MaterialSpaceContext? failed, out string detail)
	{
		failed = null;
		detail = "";
		lock (_materialSyncLock)
		{
			if (WorkRecipe is null) return true;

			ApplyWorkRecipeToMaterialContextsCore();
			foreach (var item in MaterialContexts)
			{
				if (!WorkRecipe.HasEnabledMaterialConfig(item.Id))
					continue;

				var active = WorkRecipe.GetActiveMaterialConfig(item.Id)!;
				if (item.MaterialState is MaterialState.OK)
					continue;

				failed = item;
				var allowed = WorkRecipe.GetAllowedMaterialCodes(item.Id);
				detail =
					$"material {item.Id} ({active.PositionName}) state={item.MaterialState} " +
					$"uiCode='{item.MaterialCode}' allowed=[{string.Join(", ", allowed)}]";
				return false;
			}

			return true;
		}
	}

	void ApplyWorkRecipeToMaterialContextsCore()
	{
		if (WorkRecipe is null) return;
		foreach (var context in MaterialContexts)
			context.SyncFromWorkRecipe(WorkRecipe);
	}

	public static string BuildMaterialMismatchMessage(MaterialSpaceContext failed, ProductRecipeBase? recipe) =>
		MaterialMismatchMessages.Build(failed, recipe);

	public static void ShowMaterialMismatchMessageBox(string message, string title = "物料校验失败") =>
		MaterialMismatchDialogService.Show(message, title);

	public void NotifyMaterialCheckFailed(MaterialSpaceContext failed) =>
		MaterialMismatchDialogService.Show(failed, WorkRecipe);

	public partial bool NozzleCheck { get; set; } = true;
	public partial DateTime NozzleSpotCheckCompleteTime { get; set; } = DateTime.MaxValue;
	public partial bool IsNozzleSpotCheckOk { get; set; }

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
					? materialCodesRet.Value![materialContext.Id-1]
					: "";
			}
		}

		foreach (var nozzleContext in NozzleContexts)
		{
			nozzleContext.Config = AppConfig.NozzleConfigs.FirstOrDefault(t => t.Id == nozzleContext.Id)!;
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

			if (Plc.Read.配方下发响应 == 1 && Plc.Read.配方下发请求 == 1)
			{
				Plc.Write.配方下发请求 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.配方下发请求)).Unwarp();
			}
		}

		return Task.CompletedTask;
	}

	private void UpdateWorkPositionContexts()
	{
	}

	public Result NozzleSpotCheck()
	{
		foreach (var nozzleContext in NozzleContexts)
		{
			if (nozzleContext.ProductionState != ProductionState.OK)
			{
				return Result.Err($"nozzle '{nozzleContext.Config.Id}:{nozzleContext.Config.Name}' check failed!");
			}
		}

		return Result.OK;
	}

	public void ResetNozzleSpotCheck()
	{
		Plc.Write.吸头1压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头1压力));
		Plc.Write.吸头2压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头2压力));
		Plc.Write.吸头3压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头3压力));
		Plc.Write.吸头4压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头4压力));
		Plc.Write.吸头5压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头5压力));
		Plc.Write.吸头6压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头6压力));
		Plc.Write.吸头7压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头7压力));
		Plc.Write.吸头8压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头8压力));
		Plc.Write.吸头9压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头9压力));
		Plc.Write.吸头10压力 = 0;
		Plc.Write.WritePoint(nameof(PlcStruct.吸头10压力));
	}

	private void UpdateNozzleContexts()
	{
		var now = DateTime.Now;
		var 吸头点检完成时间 = DateTime.FromBinary(Plc.Read.吸头点检完成时间);
		if (吸头点检完成时间 > now) // 防止时间错误
		{
			Plc.Write.吸头点检完成时间 = DateTime.MinValue.Ticks;
			Plc.Write.WritePoint(nameof(PlcStruct.吸头点检完成时间));
		}
		else if (NozzleSpotCheckCompleteTime != 吸头点检完成时间 &&
		         now - 吸头点检完成时间 > TimeSpan.FromHours(AppConfig.NozzleSpotCheckTimeoutHours))
			// 点检超时重置
		{
			ResetNozzleSpotCheck();
			NozzleSpotCheckCompleteTime = 吸头点检完成时间;
			UiUtils.InvokeOnUiThread(() =>
			{
				MessageBox.ShowOverlay("nozzle spot check result is timeout, please do nozzle spot check!",
					"nozzle spot check tip", MessageBoxIcon.Warning, host: AvaloniaApplication.Current.MainView);
			});
		}

		var isAllOk = true;
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
			if (nozzleContext.Value >= nozzleContext.Config.PressureMinValue &&
			    nozzleContext.Value <= nozzleContext.Config.PressureMaxValue)
				nozzleContext.ProductionState = ProductionState.OK;
			else
			{
				nozzleContext.ProductionState = ProductionState.NG;
				isAllOk = false;
			}
		}

		if (isAllOk != IsNozzleSpotCheckOk)
		{
			if (isAllOk)
			{
				NozzleSpotCheckCompleteTime = DateTime.Now;
				Plc.Write.吸头点检完成时间 = NozzleSpotCheckCompleteTime.Ticks;
				Plc.Write.WritePoint(nameof(PlcStruct.吸头点检完成时间));
			}

			IsNozzleSpotCheckOk = isAllOk;
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

		lock (_materialSyncLock)
		{
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
		Logger.Info("【PLC配方写入PC地址握手】开始，使用 配方上报请求(21011) / 配方上报响应(22011)。");

		Plc.Write.配方上报请求 = 0;
		var result = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报响应));
		if (result.IsError()) return result;

		Plc.Write.配方上报响应 = 0;
		result = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报响应));
		if (result.IsError()) return result;

		var resetTimeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < resetTimeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(nameof(PlcStruct.配方上报响应));
			if (result.IsError()) return result;

			Logger.Info("【PLC配方写入PC地址握手】等待 配方上报响应(22011)=0，当前响应={response}", Plc.Read.配方上报响应);
			if (Plc.Read.配方上报响应 == 0)
				break;
		}

		if (Plc.Read.配方上报响应 != 0)
			return Result.Err("等待 配方上报响应(22011)=0 超过15秒。");

		Logger.Info("【PLC配方写入PC地址握手】写入 配方上报请求(21011)=1。");
		Plc.Write.配方上报请求 = 1;
		result = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报请求));
		if (result.IsError())
			return result;

		var timeoutAt = DateTime.Now.AddSeconds(15);
		while (DateTime.Now < timeoutAt)
		{
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(nameof(PlcStruct.配方上报响应));
			if (result.IsError())
				return result;

			Logger.Info("【PLC配方写入PC地址握手】读取 配方上报响应(22011)={response}", Plc.Read.配方上报响应);
			if (Plc.Read.配方上报响应 == 1)
			{
				Logger.Info("【PLC配方写入PC地址握手】收到响应=1，复位 21011 和 22011。");
				Plc.Write.配方上报请求 = 0;
				result = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报请求));
				if (result.IsError())
					return result;

				Plc.Write.配方上报响应 = 0;
				result = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报响应));
				return result;
			}
		}

		Plc.Write.配方上报请求 = 0;
		_ = await Plc.Write.WritePointAsync(nameof(PlcStruct.配方上报请求));
		return Result.Err("等待 配方上报响应(22011)=1 超过15秒。");
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
			Plc.Write.配方下发请求 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.配方下发请求)).Unwarp();
			Plc.Write.配方下发响应 = 0;
			Plc.Write.WritePoint(nameof(PlcStruct.配方下发响应)).Unwarp();
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
			Plc.Write.配方下发请求 = 1;
			Plc.Write.WritePoint(nameof(PlcStruct.配方下发请求)).Unwarp();
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