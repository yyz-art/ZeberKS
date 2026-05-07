using System.Collections.Specialized;
using System.Globalization;
using Avalonia.Media;
using Avalonia.Threading;
using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.CFG;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.UI.Account;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

#if ASM15_1
	// [Inject(SpecialName = "L")] public required ScrewService ScrewService1 { get; init; }
	// [Inject(SpecialName = "R")] public required ScrewService ScrewService2 { get; init; }
	// public ScrewMachineData ScrewData => field ??= (Design.IsDesignMode ? new ScrewMachineData() : ScrewService.Data)!;
#endif

	public required WorkService1 WorkLeft { get; init; }

	public required WorkService2 WorkRight { get; init; }

	// public required IoMonitorVM IoMonitorVM { get; init; }
	public required CoreService CoreService { get; init; }
	public partial PlcStruct PlcRead { get; set; } = new();
	public partial string WorkNoInput { get; set; } = "";
	public partial string StationNameInput { get; set; } = "";
	public partial double CTSeconds { get; set; }

	public partial string WorkRecipeName { get; set; }
	public partial string WorkOrderNo { get; set; }
	public required PlcService Plc { get; init; }
	public required AppConfig AppConfig { get; init; } = new();
	public required IConfigManager ConfigManager { get; init; }
	public required RecipeService RecipeService { get; init; }
	public partial ObservableList<NozzleContext> NozzleContexts { get; set; } = [];
	public partial ObservableList<MaterialSpaceContext> MaterialSpaceContexts { get; set; } = [];
	public partial ObservableList<DeviceStatusContext> DeviceStatusContexts { get; set; } = [];
	public partial ObservableList<WorkPositionContext> WorkPositionContexts { get; set; } = [];
	public partial ProductRecipe? WorkRecipe { get; set; }

	public MainVM()
	{
		if (Design.IsDesignMode)
		{
			NozzleContext.CreateList(NozzleContexts, CommonAppConfig.NozzleCount);
			MaterialSpaceContext.CreateList(MaterialSpaceContexts, CommonAppConfig.MaterialSpaceCount);
			WorkPositionContext.CreateList(WorkPositionContexts, 2);
			DeviceStatusContext.CreateList(DeviceStatusContexts);
		}
	}


	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		Logs = LogRecordService.LogRecords;
		Logs.CollectionChanged += OnLogsCollectionChanged;
		PlcRead = Plc.Read;
		WorkNoInput = AppConfig.WorkNo;
		StationNameInput = AppConfig.StationName;
		return base.Initialize(ctx, args);
	}

	[Inject]
	public void OnPropertyInitialized()
	{
		MaterialSpaceContexts = CoreService.MaterialContexts;
		DeviceStatusContexts = CoreService.DeviceStatusContexts;
		NozzleContexts = CoreService.NozzleContexts;
		WorkPositionContexts = CoreService.WorkPositionContexts;
	}

	private void @UiTick()
	{
		if (ReferenceEquals(CoreService, null) || ReferenceEquals(WorkLeft, null) || ReferenceEquals(WorkRight, null))
			return;

		WorkRecipe = CoreService.WorkRecipe;
		WorkRecipeName = WorkRecipe?.Name ?? "";
		WorkOrderNo = CoreService.WorkOrderNo;
		DisplayPlcIp = AppConfig.PlcIpAddress;
		CTSeconds = PlcRead.CT / 1000;

		foreach (var item in MaterialSpaceContexts)
		{
			item.ToggleLockCommand ??= MaterialToggleLockCommand;
			item.MaterialReplaceCommand ??= MaterialReplaceCommand;
		}

		foreach (var item in DeviceStatusContexts)
		{
			item.Status = item.Name switch
			{
				"PLC" => Plc.IsConnected ? "Connected" : "Disconnected",
				"Scanner1" => WorkLeft.CodeScanner?.IsOpen ?? false ? "Connected" : "Disconnected",
				"Scanner2" => WorkRight.CodeScanner?.IsOpen ?? false ? "Connected" : "Disconnected",
				_ => ""
			};
		}


		foreach (var item in NozzleContexts)
		{
			item.Value = item.Config.Id switch
			{
				1 => Plc.Read.吸头1压力,
				2 => Plc.Read.吸头2压力,
				3 => Plc.Read.吸头3压力,
				4 => Plc.Read.吸头4压力,
				5 => Plc.Read.吸头5压力,
				6 => Plc.Read.吸头6压力,
				7 => Plc.Read.吸头7压力,
				_ => 0
			};
		}

		foreach (var item in WorkPositionContexts)
		{
			if (item.Id == 1)
			{
				item.AxisPercent = Plc.Read.工位1轨道百分比位置;
				item.SN = WorkLeft.ScanSnCode;
				item.WorkStep = WorkLeft.WorkStep;
				item.OkNgState = WorkLeft.OkNgState;
			}
			else if (item.Id == 2)
			{
				item.AxisPercent = Plc.Read.工位2轨道百分比位置;
				item.SN = WorkRight.ScanSnCode;
				item.WorkStep = WorkRight.WorkStep;
				item.OkNgState = WorkRight.OkNgState;
			}
		}
	}

	partial void OnWorkRecipeChanged(ProductRecipe? value)
	{
		if (value is null) return;
		for (var i = 0; i < CommonAppConfig.MaterialSpaceCount; i++)
		{
			var item = MaterialSpaceContexts[i];
			item.Config = value.MaterialConfigs.FirstOrDefault(t => t.Id == i + 1)!;
			Debug.Assert(item.Config != null);
			item.PositionCode = (1 + i) switch
			{
				1 => AppConfig.MaterialPositionCode1,
				2 => AppConfig.MaterialPositionCode2,
				3 => AppConfig.MaterialPositionCode3,
				4 => AppConfig.MaterialPositionCode4,
				5 => AppConfig.MaterialPositionCode5,
				6 => AppConfig.MaterialPositionCode6,
				_ => "UNKNOWN"
			};
		}
	}

	public partial string DisplayPlcIp { get; set; } = "NONE";


	public partial MaterialSpaceContext? EditMaterialSpaceContext { get; set; }

	#region LOG

	public required LogRecordService LogRecordService { get; init; }

	public partial ObservableList<LogEventInfo> Logs { get; set; } = [];

	private void OnLogsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		Dispatcher.UIThread.Post(() =>
		{
			if (View.LogsDataGrid.IsPointerOver == false)
			{
				View.LogsDataGrid.SelectedItem = Logs.LastOrDefault();
				View.LogsDataGrid.ScrollIntoView(View.LogsDataGrid.SelectedItem, null);
			}
		});
	}

	#endregion

	#region Nozzle

	public async Task @NozzleInspection(NozzleContext nozzleContext)
	{
		if (ReferenceEquals(nozzleContext, null))
			return;

		var option = await ShowMessageBoxOverlay(
			$"confirm inspection nozzle {nozzleContext.Config.Id}:{nozzleContext.Config.Name}?",
			"inspection nozzle", MessageBoxIcon.Question, MessageBoxButton.OKCancel);
		if (option is not MessageBoxResult.OK)
		{
			ShowToast("cancel");
			return;
		}

		nozzleContext.OkNgState =
			nozzleContext.Value >= nozzleContext.Config.PressureMinValue &&
			nozzleContext.Value <= nozzleContext.Config.PressureMaxValue
				? OkNgState.OK
				: OkNgState.NG;
		ShowToast("inspection completed!", UiMessageType.Success);
	}

	#endregion

	#region Feeder

	public async Task @MaterialToggleLock(MaterialSpaceContext spaceContext)
	{
		CoreService.SetMaterialSpaceLock(spaceContext.Id, !spaceContext.IsUnlocked).Unwarp();
		ShowToast("success", UiMessageType.Success);
	}

	public async Task @MaterialReplace(MaterialSpaceContext spaceContext)
	{
		if (spaceContext.IsUnlocked == false)
		{
			await ShowMessageBoxOverlay("please first unlock!", "material replace", MessageBoxIcon.Warning);
			return;
		}

		InputMaterialCode = "";
		InputMaterialPositionCode = "";
		EditMaterialSpaceContext = spaceContext;
		await ShowModalDialog(View.ReplaceMaterialDialog);
	}

	public async Task @MaterialReplaceConfirm(MaterialSpaceContext spaceContext)
	{
		if (EditMaterialSpaceContext is null)
			return;
		spaceContext = EditMaterialSpaceContext;
		if (EditMaterialSpaceContext.PositionCode != InputMaterialPositionCode)
		{
			// ReplaceMaterialTipMessage = "Position code not matched";
			ShowToast("Position code not matched", UiMessageType.Error);
			return;
		}

		if (EditMaterialSpaceContext.Config.MaterialCodes.Contains(InputMaterialCode) == false)
		{
			// ReplaceMaterialTipMessage = "Material code not matched";
			ShowToast("Material code not matched", UiMessageType.Error);
			return;
		}

		var option = await ShowMessageBoxOverlay(
			$"confirm replace material '{spaceContext.Config.PositionName}' x {InputMaterialCount}", "material replace",
			MessageBoxIcon.Question, MessageBoxButton.OKCancel);
		if (option is not MessageBoxResult.OK)
		{
			ShowToast("cancel");
			return;
		}

		var result = await Task.Run(() => CoreService.SetMaterialCount(spaceContext.Id, InputMaterialCount));
		if (result.IsError())
		{
			ShowToast(result.Message!, UiMessageType.Error);
			return;
		}

		ShowToast("replace material success", UiMessageType.Success);
		spaceContext.MaterialCode = InputMaterialCode;
		spaceContext.CheckMaterialState();
		View.ReplaceMaterialDialog.Close();
	}

	public required ReplaceMaterialVM ReplaceMaterialVM { get; init; }

	#region 换料

	public partial string InputMaterialPositionCode { get; set; } = "MaterialPositionCode";
	public partial string InputMaterialCode { get; set; } = "MaterialCode";
	public partial IBrush InputMaterialPositionCodeBorderBrush { get; set; }
	public partial IBrush InputMaterialCodeBorderBrush { get; set; }
	public partial int InputMaterialCount { get; set; }
	public partial string ReplaceMaterialTipMessage { get; set; } = "";

	partial void OnInputMaterialPositionCodeChanged(string value) =>
		InputMaterialPositionCodeBorderBrush =
			value == EditMaterialSpaceContext?.PositionCode ? Brushes.Green : Brushes.Orange;

	partial void OnInputMaterialCodeChanged(string value) =>
		InputMaterialCodeBorderBrush = EditMaterialSpaceContext?.Config.MaterialCodes.Contains(value) ?? false
			? Brushes.Green
			: Brushes.Orange;

	#endregion

	#endregion


	public Task @OpenIoMonitor()
	{
		// IoMonitorVM.Show();
		return Task.CompletedTask;
	}

	public async Task @ConfirmWorkNoChange()
	{
		var newWorkNo = WorkNoInput.Trim();
		if (string.IsNullOrWhiteSpace(newWorkNo))
		{
			await ShowMessageBox("work no can't be null!", "change work no", MessageBoxIcon.Error);
			WorkNoInput = CoreService.WorkerNo;
			return;
		}

		if (string.Equals(CoreService.WorkerNo, newWorkNo, StringComparison.Ordinal))
		{
			ShowToast("unchanged");
			return;
		}

		var option = await ShowMessageBox(
			$"change work no from '{CoreService.WorkerNo}' to '{newWorkNo}' ?",
			"confirm change work no",
			MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			WorkNoInput = CoreService.WorkerNo;
			ShowToast("cancel");
			return;
		}

		CoreService.WorkerNo = newWorkNo;
		AppConfig.WorkNo = newWorkNo;
		await SaveAppConfigAsync();
		WorkNoInput = CoreService.WorkerNo;
		ShowToast("change success", UiMessageType.Success);
	}

	public async Task @ConfirmStationNameChange()
	{
		var newStationName = StationNameInput.Trim();
		if (string.IsNullOrWhiteSpace(newStationName))
		{
			await ShowMessageBox("工站名不能为空。", "修改工站名", MessageBoxIcon.Error);
			StationNameInput = AppConfig.StationName;
			return;
		}

		if (string.Equals(AppConfig.StationName, newStationName, StringComparison.Ordinal))
		{
			ShowToast("工站名未变化。");
			return;
		}

		var option = await ShowMessageBox(
			$"确认将工站名从 '{AppConfig.StationName}' 修改为 '{newStationName}' 吗？",
			"确认修改工站名",
			MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			StationNameInput = AppConfig.StationName;
			ShowToast("已取消修改工站名。");
			return;
		}

		AppConfig.StationName = newStationName;
		var saveResult = await SaveAppConfigAsync();
		if (saveResult.IsError())
		{
			ShowNotification($"工站名保存失败，重启后可能不会生效：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		StationNameInput = AppConfig.StationName;
		ShowToast("工站名已修改。", UiMessageType.Success);
	}

	private async Task<Result> SaveAppConfigAsync()
	{
		var currentConfigContext = AppConfig.AccessConfigContext() as JsonConfigContext;
		if (currentConfigContext?.SavePath == null)
			return Result.Err("Unable to get the config save path.");

		return await ConfigManager.SaveConfigAsync(AppConfig, currentConfigContext.SavePath);
	}
}