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
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.UI.Account;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
	private static readonly IBrush NormalPressureBackground = Brush.Parse("#1f1f1f");
	private static readonly IBrush LimitPressureBackground = Brush.Parse("#8b1f1f");
	private readonly bool[] _nozzlePressureLimitLogged = new bool[4];
	private bool _isRefreshingNozzlePressure;
	private DateTime _lastNozzlePressureRefresh = DateTime.MinValue;
	private int _editingNozzlePressureIndex = 1;

#if ASM15_1
	public required ScrewService ScrewService { get; init; }
	public ScrewMachineData ScrewData => field ??= (Design.IsDesignMode ? new ScrewMachineData() : ScrewService.Data)!;
#endif
	public required CoreService CoreService { get; init; }
	public required WorkLeftService WorkLeft { get; init; }
	public required WorkRightService WorkRight { get; init; }
	public partial PlcStruct PlcRead { get; set; } = new();
	public partial string WorkNoInput { get; set; } = "";
	public partial string StationNameInput { get; set; } = "";
	public partial string CTSecondsDisplay { get; set; } = "0.00 秒";

	public required PlcService Plc { get; init; }
	public required AppConfig AppConfig { get; init; } = new();
	public required IConfigManager ConfigManager { get; init; }
	public required RecipeService RecipeService { get; init; }
	public partial string Feeder1MaterialCode { get; set; } = "";
	public partial string Feeder1Code { get; set; } = "";
	public partial string Feeder2MaterialCode { get; set; } = "";
	public partial string Feeder2Code { get; set; } = "";
	public partial string Feeder3MaterialCode { get; set; } = "";
	public partial string Feeder3Code { get; set; } = "";
	public partial string Feeder4MaterialCode { get; set; } = "";
	public partial string Feeder4Code { get; set; } = "";
	public partial string Feeder5MaterialCode { get; set; } = "";
	public partial string Feeder5Code { get; set; } = "";
	public partial string Feeder6MaterialCode { get; set; } = "";
	public partial string Feeder6Code { get; set; } = "";
	public partial bool Feeder1IsUsed { get; set; }
	public partial bool Feeder2IsUsed { get; set; }
	public partial bool Feeder3IsUsed { get; set; }
	public partial bool Feeder4IsUsed { get; set; }
	public partial bool Feeder5IsUsed { get; set; }
	public partial bool Feeder6IsUsed { get; set; }
	public partial string Nozzle1PressureCheckValue { get; set; } = "未配置";
	public partial string Nozzle2PressureCheckValue { get; set; } = "未配置";
	public partial string Nozzle3PressureCheckValue { get; set; } = "未配置";
	public partial string Nozzle4PressureCheckValue { get; set; } = "未配置";

	public partial IBrush Nozzle1PressureBackground { get; set; } = NormalPressureBackground;
	public partial IBrush Nozzle2PressureBackground { get; set; } = NormalPressureBackground;
	public partial IBrush Nozzle3PressureBackground { get; set; } = NormalPressureBackground;
	public partial IBrush Nozzle4PressureBackground { get; set; } = NormalPressureBackground;
	public partial string NozzlePressureDialogTitle { get; set; } = "吸嘴压力点检设置";
	public partial string NozzlePressureAddressInput { get; set; } = "";
	public partial string NozzlePressureMaxInput { get; set; } = "";
	public partial string NozzlePressureMinInput { get; set; } = "";

	private void @UiTick()
	{
		Axis1Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
		Axis2Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
		RefreshProductionInfoDisplay();
		RefreshFeederConfigDisplay();
		RefreshNozzlePressureCheckDisplay();
	}

	private void RefreshProductionInfoDisplay()
	{
		CTSecondsDisplay = $"{PlcRead.CT / 1000f:F2} 秒";
	}

	public Task @SetNozzlePressureCheck(string? nozzleIndex)
	{
		_editingNozzlePressureIndex = ParseNozzlePressureIndex(nozzleIndex);
		NozzlePressureDialogTitle = $"吸嘴{_editingNozzlePressureIndex}压力点检设置";
		NozzlePressureAddressInput = GetNozzlePressureAddress(_editingNozzlePressureIndex);
		NozzlePressureMaxInput = GetNozzlePressureMax(_editingNozzlePressureIndex).ToString(CultureInfo.InvariantCulture);
		NozzlePressureMinInput = GetNozzlePressureMin(_editingNozzlePressureIndex).ToString(CultureInfo.InvariantCulture);
		return ShowModalDialog(View.NozzlePressureDialog);
	}

	public async Task @ConfirmNozzlePressureCheck()
	{
		var address = NozzlePressureAddressInput.Trim();
		if (string.IsNullOrWhiteSpace(address))
		{
			await ShowMessageBox("地址不能为空。", "吸嘴压力点检设置", MessageBoxIcon.Error);
			return;
		}

		if (ProductRecipe.TryParsePlcSource(address, out _) == false)
		{
			await ShowMessageBox("地址格式不正确，请输入数字地址，例如 22054 或 PLC:22054。", "吸嘴压力点检设置", MessageBoxIcon.Error);
			return;
		}

		if (TryParseFloat(NozzlePressureMaxInput, out var max) == false)
		{
			await ShowMessageBox("最大值必须是数字。", "吸嘴压力点检设置", MessageBoxIcon.Error);
			return;
		}

		if (TryParseFloat(NozzlePressureMinInput, out var min) == false)
		{
			await ShowMessageBox("最小值必须是数字。", "吸嘴压力点检设置", MessageBoxIcon.Error);
			return;
		}

		if (max < min)
		{
			await ShowMessageBox("最大值不能小于最小值。", "吸嘴压力点检设置", MessageBoxIcon.Error);
			return;
		}

		SetNozzlePressureConfig(_editingNozzlePressureIndex, ProductRecipe.ToPlcSource(ParsePlcAddress(address)), max, min);
		var saveResult = await SaveAppConfigAsync();
		if (saveResult.IsError())
		{
			ShowNotification($"吸嘴压力点检配置保存失败：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		_nozzlePressureLimitLogged[_editingNozzlePressureIndex - 1] = false;
		View.NozzlePressureDialog.Close();
		ShowToast("吸嘴压力点检配置已保存。", UiMessageType.Success);
		await RefreshNozzlePressureCheckDisplayAsync(force: true);
	}

	private void RefreshNozzlePressureCheckDisplay()
	{
		if (_isRefreshingNozzlePressure || DateTime.Now - _lastNozzlePressureRefresh < TimeSpan.FromSeconds(1))
			return;

		_ = RefreshNozzlePressureCheckDisplayAsync();
	}

	private async Task RefreshNozzlePressureCheckDisplayAsync(bool force = false)
	{
		if (_isRefreshingNozzlePressure && force == false)
			return;

		_isRefreshingNozzlePressure = true;
		_lastNozzlePressureRefresh = DateTime.Now;
		try
		{
			for (var index = 1; index <= 4; index++)
			{
				var address = GetNozzlePressureAddress(index);
				if (string.IsNullOrWhiteSpace(address))
				{
					SetNozzlePressureDisplay(index, "未配置", NormalPressureBackground);
					_nozzlePressureLimitLogged[index - 1] = false;
					continue;
				}

				if (ProductRecipe.TryParsePlcSource(address, out var offset) == false)
				{
					SetNozzlePressureDisplay(index, "地址错误", LimitPressureBackground);
					continue;
				}

				var readResult = await TryReadPressureValueAsync(offset);
				if (readResult.IsError())
				{
					SetNozzlePressureDisplay(index, "读取失败", LimitPressureBackground);
					continue;
				}

				var value = readResult.Value;
				var min = GetNozzlePressureMin(index);
				var max = GetNozzlePressureMax(index);
				var isOutOfRange = value < min || value > max;
				SetNozzlePressureDisplay(index, value.ToString("F2", CultureInfo.InvariantCulture),
					isOutOfRange ? LimitPressureBackground : NormalPressureBackground);

				if (isOutOfRange)
				{
					if (_nozzlePressureLimitLogged[index - 1] == false)
					{
						Logger.Warn("吸嘴{Index}压力值超限，地址={Address}，当前值={Value:F2}，允许范围={Min:F2}~{Max:F2}",
							index, ProductRecipe.ToPlcSource(offset), value, min, max);
						_nozzlePressureLimitLogged[index - 1] = true;
					}
				}
				else
				{
					_nozzlePressureLimitLogged[index - 1] = false;
				}
			}
		}
		finally
		{
			_isRefreshingNozzlePressure = false;
		}
	}

	private async Task<Result<float>> TryReadPressureValueAsync(int offset)
	{
		var template = PlcStructInfo.CT;
		var pointInfo = new BinaryPointInfo
		{
			Offset = offset,
			Name = nameof(PlcStruct.CT),
			Type = template.Type,
			ByteLength = template.ByteLength,
			ByteFormat = template.ByteFormat,
			Description = template.Description,
			Id = template.Id,
			RawType = template.RawType,
			Source = offset.ToString(CultureInfo.InvariantCulture),
			ToRaw = template.ToRaw,
			RawTo = template.RawTo,
			ReaderData = template.ReaderData,
			WriterData = template.WriterData,
			Tags = template.Tags,
			CustomData = template.CustomData,
		};
		var reader = new PlcStruct { Connection = Plc.Read.Connection };
		var readResult = await reader.ReadPointAsync(pointInfo);
		return readResult.IsError() ? Result.Err<float>(readResult.Message) : Result.Ok(reader.CT);
	}

	private static bool TryParseFloat(string text, out float value)
	{
		return float.TryParse(text?.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out value)
		       || float.TryParse(text?.Trim(), NumberStyles.Float, CultureInfo.CurrentCulture, out value);
	}

	private static int ParsePlcAddress(string address)
	{
		ProductRecipe.TryParsePlcSource(address, out var offset);
		return offset;
	}

	private static int ParseNozzlePressureIndex(string? nozzleIndex)
	{
		return int.TryParse(nozzleIndex, out var index) && index is >= 1 and <= 4 ? index : 1;
	}

	private string GetNozzlePressureAddress(int index) => index switch
	{
		1 => AppConfig.Nozzle1PressureAddress,
		2 => AppConfig.Nozzle2PressureAddress,
		3 => AppConfig.Nozzle3PressureAddress,
		4 => AppConfig.Nozzle4PressureAddress,
		_ => "",
	};

	private float GetNozzlePressureMax(int index) => index switch
	{
		1 => AppConfig.Nozzle1PressureMax,
		2 => AppConfig.Nozzle2PressureMax,
		3 => AppConfig.Nozzle3PressureMax,
		4 => AppConfig.Nozzle4PressureMax,
		_ => 0,
	};

	private float GetNozzlePressureMin(int index) => index switch
	{
		1 => AppConfig.Nozzle1PressureMin,
		2 => AppConfig.Nozzle2PressureMin,
		3 => AppConfig.Nozzle3PressureMin,
		4 => AppConfig.Nozzle4PressureMin,
		_ => 0,
	};

	private void SetNozzlePressureConfig(int index, string address, float max, float min)
	{
		switch (index)
		{
			case 1:
				AppConfig.Nozzle1PressureAddress = address;
				AppConfig.Nozzle1PressureMax = max;
				AppConfig.Nozzle1PressureMin = min;
				break;
			case 2:
				AppConfig.Nozzle2PressureAddress = address;
				AppConfig.Nozzle2PressureMax = max;
				AppConfig.Nozzle2PressureMin = min;
				break;
			case 3:
				AppConfig.Nozzle3PressureAddress = address;
				AppConfig.Nozzle3PressureMax = max;
				AppConfig.Nozzle3PressureMin = min;
				break;
			case 4:
				AppConfig.Nozzle4PressureAddress = address;
				AppConfig.Nozzle4PressureMax = max;
				AppConfig.Nozzle4PressureMin = min;
				break;
		}
	}

	private void SetNozzlePressureDisplay(int index, string value, IBrush background)
	{
		switch (index)
		{
			case 1:
				Nozzle1PressureCheckValue = value;
				Nozzle1PressureBackground = background;
				break;
			case 2:
				Nozzle2PressureCheckValue = value;
				Nozzle2PressureBackground = background;
				break;
			case 3:
				Nozzle3PressureCheckValue = value;
				Nozzle3PressureBackground = background;
				break;
			case 4:
				Nozzle4PressureCheckValue = value;
				Nozzle4PressureBackground = background;
				break;
		}
	}

	#region LOG

	public required LogRecordService LogRecordService { get; init; }

	public partial ObservableList<LogEventInfo> Logs { get; set; } = [new(), new()];

	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		Logs = LogRecordService.LogRecords;
		Logs.CollectionChanged += OnLogsCollectionChanged;

		PlcRead = Plc.Read;
		CoreService.工号 = string.IsNullOrWhiteSpace(AppConfig.WorkNo) ? CoreService.工号 : AppConfig.WorkNo;
		WorkNoInput = CoreService.工号;
		StationNameInput = AppConfig.StationName;
		RefreshProductionInfoDisplay();
		RefreshFeederConfigDisplay();
		StartDeviceStatusMonitor();

		DisplayPlcIp = PlcService.IsConnected ? AppConfig.PlcIpAddress : "NONE";

		PlcService.PropertyChanged += (sender, args) =>
		{
			if (args.PropertyName == nameof(PlcService.IsConnected))
				DisplayPlcIp = PlcService.IsConnected ? AppConfig.PlcIpAddress : "NONE";
		};

		return base.Initialize(ctx, args);
	}

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

	#region WorkPosition

	public partial string LeftBarcode { get; set; } = "XXXXXX-L";
	public partial PassState LeftPassState { get; set; } = PassState.OK;
	public partial string RightBarcode { get; set; } = "xxxxxx-L";
	public partial PassState RightPassState { get; set; } = PassState.NA;
	public partial ObservableList<string> LeftImageNames { get; set; } = ["A-png", "B-png", "C-png"];
	public partial ObservableList<string> RightImageNames { get; set; } = ["A-png", "B-png", "C-png"];

	#endregion

	#region Axis

	public partial double Axis1Percent { get; set; } = 0.5;
	public partial double Axis2Percent { get; set; }

	#endregion

	#region Feeder

	public async Task @FeederUnlock(string? feederName)
	{
		var feederIndex = ParseFeederIndex(feederName);
		if (IsFeederUsed(feederIndex) == false)
		{
			ShowToast($"Feeder{feederIndex}未启用，不能解锁。", UiMessageType.Warning);
			return;
		}

		SetFeederUnlockRequest(feederIndex, 1);
		var requestPoint = GetFeederUnlockRequestPoint(feederIndex);
		var responsePoint = GetFeederUnlockResponsePoint(feederIndex);
		SetFeederUnlockRequest(feederIndex, 0);
		var resetBeforeResult = Plc.Write.WritePoint(requestPoint);
		if (resetBeforeResult.IsError())
		{
			await ShowMessageBox($"Feeder{feederIndex}解锁请求复位失败：{resetBeforeResult.Message}", $"Feeder{feederIndex}解锁", MessageBoxIcon.Error);
			return;
		}

		SetFeederUnlockRequest(feederIndex, 1);
		var writeResult = Plc.Write.WritePoint(requestPoint);
		if (writeResult.IsError())
		{
			SetFeederUnlockRequest(feederIndex, 0);
			Plc.Write.WritePoint(requestPoint);
			await ShowMessageBox($"Feeder{feederIndex}解锁请求写入失败：{writeResult.Message}", $"Feeder{feederIndex}解锁", MessageBoxIcon.Error);
			return;
		}

		var message = $"Feeder{feederIndex}解锁超时，未收到解锁成功响应。";
		var messageIcon = MessageBoxIcon.Warning;
		try
		{
			var timeoutAt = DateTime.Now.AddSeconds(5);
			while (DateTime.Now < timeoutAt)
			{
				await Task.Delay(200);
				var readResult = await Plc.Read.ReadPointAsync(responsePoint);
				if (readResult.IsError())
				{
					message = $"Feeder{feederIndex}解锁响应读取失败：{readResult.Message}";
					messageIcon = MessageBoxIcon.Error;
					break;
				}

				if (GetFeederUnlockResponse(feederIndex) == 1)
				{
					message = $"Feeder{feederIndex}解锁成功。";
					messageIcon = MessageBoxIcon.Question;
					break;
				}
			}
		}
		finally
		{
			SetFeederUnlockRequest(feederIndex, 0);
			var resetAfterResult = Plc.Write.WritePoint(requestPoint);
			if (resetAfterResult.IsError())
				ShowToast($"Feeder{feederIndex}解锁请求复位失败：{resetAfterResult.Message}", UiMessageType.Error);
		}

		await ShowMessageBox(message, $"Feeder{feederIndex}解锁", messageIcon);
	}

	public required ReplaceMonoVM ReplaceMonoVM { get; init; }

	public Task @StartReplaceMono(string? feederName)
	{
		var feederIndex = ParseFeederIndex(feederName);
		if (IsFeederUsed(feederIndex) == false)
		{
			ShowToast($"Feeder{feederIndex}未启用，不能换料。", UiMessageType.Warning);
			return Task.CompletedTask;
		}

		ReplaceMonoVM.Show(CoreService.当前下发配方, feederIndex);
		return Task.CompletedTask;
	}

	private void RefreshFeederConfigDisplay()
	{
		var recipe = CoreService.当前下发配方;
		if (recipe is null && string.IsNullOrWhiteSpace(CoreService.RecipeName) == false)
		{
			var getRecipeResult = RecipeService.GetRecipe(CoreService.RecipeName, true);
			if (getRecipeResult.IsOk())
				recipe = getRecipeResult.Value;
		}

		Feeder1MaterialCode = GetFeederMaterialCode(recipe, 0);
		Feeder1Code = GetFeederCode(recipe, 0);
		Feeder2MaterialCode = GetFeederMaterialCode(recipe, 1);
		Feeder2Code = GetFeederCode(recipe, 1);
		Feeder3MaterialCode = GetFeederMaterialCode(recipe, 2);
		Feeder3Code = GetFeederCode(recipe, 2);
		Feeder4MaterialCode = GetFeederMaterialCode(recipe, 3);
		Feeder4Code = GetFeederCode(recipe, 3);
		Feeder5MaterialCode = GetFeederMaterialCode(recipe, 4);
		Feeder5Code = GetFeederCode(recipe, 4);
		Feeder6MaterialCode = GetFeederMaterialCode(recipe, 5);
		Feeder6Code = GetFeederCode(recipe, 5);
		Feeder1IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(0)?.是否使用 == true;
		Feeder2IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(1)?.是否使用 == true;
		Feeder3IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(2)?.是否使用 == true;
		Feeder4IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(3)?.是否使用 == true;
		Feeder5IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(4)?.是否使用 == true;
		Feeder6IsUsed = recipe?.产品上料信息?.ElementAtOrDefault(5)?.是否使用 == true;
	}

	private static string GetFeederMaterialCode(ProductRecipe? recipe, int index)
	{
		return recipe?.产品上料信息?.ElementAtOrDefault(index)?.上料码1 ?? "";
	}

	private static string GetFeederCode(ProductRecipe? recipe, int index)
	{
		return recipe?.产品上料信息?.ElementAtOrDefault(index)?.上料位置识别码 ?? "";
	}

	private static int ParseFeederIndex(string? feederName)
	{
		if (string.IsNullOrWhiteSpace(feederName))
			return 1;

		var digits = new string(feederName.Where(char.IsDigit).ToArray());
		return int.TryParse(digits, out var index) && index is >= 1 and <= 6 ? index : 1;
	}

	private bool IsFeederUsed(int feederIndex) => feederIndex switch
	{
		1 => Feeder1IsUsed,
		2 => Feeder2IsUsed,
		3 => Feeder3IsUsed,
		4 => Feeder4IsUsed,
		5 => Feeder5IsUsed,
		6 => Feeder6IsUsed,
		_ => false,
	};

	private static IBinaryPointInfo GetFeederUnlockRequestPoint(int feederIndex) => feederIndex switch
	{
		1 => PlcStructInfo.Feeder1解锁请求,
		2 => PlcStructInfo.Feeder2解锁请求,
		3 => PlcStructInfo.Feeder3解锁请求,
		4 => PlcStructInfo.Feeder4解锁请求,
		5 => PlcStructInfo.Feeder5解锁请求,
		6 => PlcStructInfo.Feeder6解锁请求,
		_ => PlcStructInfo.Feeder1解锁请求,
	};

	private static IBinaryPointInfo GetFeederUnlockResponsePoint(int feederIndex) => feederIndex switch
	{
		1 => PlcStructInfo.Feeder1解锁响应,
		2 => PlcStructInfo.Feeder2解锁响应,
		3 => PlcStructInfo.Feeder3解锁响应,
		4 => PlcStructInfo.Feeder4解锁响应,
		5 => PlcStructInfo.Feeder5解锁响应,
		6 => PlcStructInfo.Feeder6解锁响应,
		_ => PlcStructInfo.Feeder1解锁响应,
	};

	private void SetFeederUnlockRequest(int feederIndex, short value)
	{
		switch (feederIndex)
		{
			case 1: Plc.Write.Feeder1解锁请求 = value; break;
			case 2: Plc.Write.Feeder2解锁请求 = value; break;
			case 3: Plc.Write.Feeder3解锁请求 = value; break;
			case 4: Plc.Write.Feeder4解锁请求 = value; break;
			case 5: Plc.Write.Feeder5解锁请求 = value; break;
			case 6: Plc.Write.Feeder6解锁请求 = value; break;
		}
	}

	private short GetFeederUnlockResponse(int feederIndex) => feederIndex switch
	{
		1 => Plc.Read.Feeder1解锁响应,
		2 => Plc.Read.Feeder2解锁响应,
		3 => Plc.Read.Feeder3解锁响应,
		4 => Plc.Read.Feeder4解锁响应,
		5 => Plc.Read.Feeder5解锁响应,
		6 => Plc.Read.Feeder6解锁响应,
		_ => 0,
	};

	#endregion

	public required PlcService PlcService { get; init; }
	public required WorkLeftService WorkLeftService { get; init; }
	public required WorkRightService WorkRightService { get; init; }
	public partial string DisplayPlcIp { get; set; } = "NONE";
	public required IoMonitorVM IoMonitorVM { get; init; }
	public partial bool IsScanner1Connected { get; set; }
	public partial bool IsScanner2Connected { get; set; }

	private void StartDeviceStatusMonitor()
	{
		_ = Task.Run(async () =>
		{
			while (true)
			{
				await Task.Delay(1000);
				Dispatcher.UIThread.Post(() =>
				{
					IsScanner1Connected = WorkLeftService?.CodeScanner?.IsOpen == true;
					IsScanner2Connected = WorkRightService?.CodeScanner2?.IsOpen == true;
				});
			}
		});
	}

	public Task @OpenIoMonitor()
	{
		IoMonitorVM.Show();
		return Task.CompletedTask;
	}

	public async Task @ConfirmWorkNoChange()
	{
		var newWorkNo = WorkNoInput.Trim();
		if (string.IsNullOrWhiteSpace(newWorkNo))
		{
			await ShowMessageBox("工号不能为空。", "修改工号", MessageBoxIcon.Error);
			WorkNoInput = CoreService.工号;
			return;
		}

		if (string.Equals(CoreService.工号, newWorkNo, StringComparison.Ordinal))
		{
			ShowToast("工号未变化。");
			return;
		}

		var option = await ShowMessageBox(
			$"确认将工号从 '{CoreService.工号}' 修改为 '{newWorkNo}' 吗？",
			"确认修改工号",
			MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			WorkNoInput = CoreService.工号;
			ShowToast("已取消修改工号。");
			return;
		}

		CoreService.工号 = newWorkNo;
		AppConfig.WorkNo = newWorkNo;
		var saveResult = await SaveAppConfigAsync();
		if (saveResult.IsError())
		{
			ShowNotification($"工号保存失败，重启后可能不会生效：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		WorkNoInput = CoreService.工号;
		ShowToast("工号已修改。", UiMessageType.Success);
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
