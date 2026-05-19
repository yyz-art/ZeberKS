using System.Collections.Specialized;
using System.Globalization;
using Avalonia.Media;
using Avalonia.Threading;
using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.CFG;
using ZC.DP.Memory;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.UI.Account;
using ZitApp.UI.Dialogs;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public required PlcPointMonitorVM PlcPointMonitorVM { get; init; }
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
		WorkNoInput = AppConfig.WorkerNo;
		StationNameInput = AppConfig.StationName;
		LineNameInput = AppConfig.Line;
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
				item.UpdateImageInfo();
				// item.AxisPercent = Plc.Read.工位1轨道百分比位置;
				// item.SN = WorkLeft.ScanSnCode;
				// item.WorkStep = WorkLeft.WorkStep;
				// item.ProductionState = WorkLeft.ProductionState;
			}
			else if (item.Id == 2)
			{
				item.UpdateImageInfo();
				// item.AxisPercent = Plc.Read.工位2轨道百分比位置;
				// item.SN = WorkRight.ScanSnCode;
				// item.WorkStep = WorkRight.WorkStep;
				// item.ProductionState = WorkRight.ProductionState;
			}
		}
	}

	partial void OnWorkRecipeChanged(ProductRecipe? value)
	{
		if (value is null) return;
		CoreService.ApplyWorkRecipeToMaterialContexts();
		for (var i = 0; i < CommonAppConfig.MaterialSpaceCount; i++)
		{
			var item = MaterialSpaceContexts[i];
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

		nozzleContext.ProductionState =
			nozzleContext.Value >= nozzleContext.Config.PressureMinValue &&
			nozzleContext.Value <= nozzleContext.Config.PressureMaxValue
				? ProductionState.OK
				: ProductionState.NG;
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

		if (WorkRecipe?.HasEnabledMaterialConfig(spaceContext.Id) != true)
		{
			await ShowMessageBoxOverlay(
				$"feeder {spaceContext.Id} has no enabled material row in recipe '{WorkRecipe?.Name ?? ""}'",
				"material replace",
				MessageBoxIcon.Warning);
			return;
		}

		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);
		InputMaterialCode = "";
		InputMaterialPositionCode = "";
		InputMaterialCount = spaceContext.Config.DefaultReplaceCount;
		EditMaterialSpaceContext = spaceContext;
		await ShowModalDialog(View.ReplaceMaterialDialog);
	}

	public async Task @MaterialReplaceConfirm(MaterialSpaceContext spaceContext)
	{
		if (EditMaterialSpaceContext is null)
			return;
		spaceContext = EditMaterialSpaceContext;
		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);

		if (WorkRecipe?.HasEnabledMaterialConfig(spaceContext.Id) != true)
		{
			await ShowMessageBoxOverlay("no enabled material config for this feeder", "replace material",
				MessageBoxIcon.Error);
			return;
		}

		var positionCode = InputMaterialPositionCode.Trim();
		if (EditMaterialSpaceContext.PositionCode != positionCode)
		{
			await ShowMessageBoxOverlay(
				$"position code not matched! current is '{positionCode}', need '{EditMaterialSpaceContext.PositionCode}'",
				"replace material",
				MessageBoxIcon.Error);
			return;
		}

		var materialCode = InputMaterialCode.Trim();
		if (!WorkRecipe!.IsAllowedMaterialCode(spaceContext.Id, materialCode))
		{
			CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);
			await MaterialMismatchDialogService.ShowAsync(
				MaterialMismatchMessages.Build(spaceContext, WorkRecipe),
				"物料校验失败");
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
		await ShowMessageBoxOverlay("replace material success ", "replace material", MessageBoxIcon.Success);
		spaceContext.MaterialCode = materialCode;
		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);
		CoreService.SaveMaterialSpaceCodes();
		View.ReplaceMaterialDialog.Close();
	}

	// public required ReplaceMaterialVM ReplaceMaterialVM { get; init; }

	#region 换料

	public partial string InputMaterialPositionCode { get; set; } = "MaterialPositionCode";
	public partial string InputMaterialCode { get; set; } = "MaterialCode";
	public partial IBrush InputMaterialPositionCodeBorderBrush { get; set; }
	public partial IBrush InputMaterialCodeBorderBrush { get; set; }
	public partial int InputMaterialCount { get; set; }
	public partial string ReplaceMaterialTipMessage { get; set; } = "";

	public bool HasNozzleContexts => CommonAppConfig.NozzleCount > 0;
	public partial string LineNameInput { get; set; }

	public async Task @ResetNozzleSpotCheck()
	{
		var option = await ShowMessageBoxOverlay("confirm reset nozzle spot check value?", "nozzle spot check",
			MessageBoxIcon.Question, MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("cancel");
			return;
		}

		await Task.Run(() => CoreService.ResetNozzleSpotCheck());
		ShowToast("success", UiMessageType.Success);
	}

	partial void OnInputMaterialPositionCodeChanged(string value) =>
		InputMaterialPositionCodeBorderBrush =
			value == EditMaterialSpaceContext?.PositionCode ? Brushes.Green : Brushes.Orange;

	partial void OnInputMaterialCodeChanged(string value)
	{
		var feederId = EditMaterialSpaceContext?.Id;
		var ok = feederId is not null
		         && WorkRecipe?.HasEnabledMaterialConfig(feederId.Value) == true
		         && WorkRecipe.IsAllowedMaterialCode(feederId.Value, value);
		InputMaterialCodeBorderBrush = ok ? Brushes.Green : Brushes.Orange;
	}

	#endregion

	#endregion


	public Task @OpenIoMonitor()
	{
		PlcPointMonitorVM.SetPlcStructs(Plc.Read, Plc.Write);
		PlcPointMonitorVM.View.Show();
		// IoMonitorVM.Show();
		return Task.CompletedTask;
	}

	public async Task @ConfirmLineNameChange()
	{
		var newStationName = LineNameInput.Trim();
		if (string.IsNullOrWhiteSpace(newStationName))
		{
			await ShowMessageBox("线别不能为空。", "修改线别", MessageBoxIcon.Error);
			LineNameInput = AppConfig.Line;
			return;
		}

		if (string.Equals(AppConfig.Line, newStationName, StringComparison.Ordinal))
		{
			ShowToast("线别未变化。");
			return;
		}

		var option = await ShowMessageBox(
			$"确认将线别从 '{AppConfig.Line}' 修改为 '{newStationName}' 吗？",
			"确认修改线别",
			MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			LineNameInput = AppConfig.Line;
			ShowToast("已取消修改线别。");
			return;
		}

		AppConfig.Line = newStationName;
		var saveResult = await SaveAppConfigAsync();
		if (saveResult.IsError())
		{
			ShowNotification($"线别保存失败，重启后可能不会生效：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		LineNameInput = AppConfig.Line;
		ShowToast("线别已修改。", UiMessageType.Success);
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
		AppConfig.WorkerNo = newWorkNo;
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