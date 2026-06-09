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
using ZitApp.Ext.EapClient;

namespace ZitApp.UI;

/// <summary>
/// 主界面 ViewModel，负责主界面的数据绑定、UI 定时刷新、物料换料操作、吸头点检、
/// 工站/工站名/线别修改、日志显示、PLC 监控入口等。
/// 继承自 <see cref="UiVM{T}"/>，注册为单例。
/// </summary>
[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
	#region ==================== 依赖注入 & 属性 ====================

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	/// <summary>PLC 点位监控 ViewModel，用于打开 IO 监控窗口</summary>
	public required PlcPointMonitorVM PlcPointMonitorVM { get; init; }

	/// <summary>工位1工作服务</summary>
	public required WorkService1 WorkLeft { get; init; }

	/// <summary>工位2工作服务</summary>
	public required WorkService2 WorkRight { get; init; }

	// public required IoMonitorVM IoMonitorVM { get; init; }

	/// <summary>核心业务服务，提供配方、物料、吸头等全局能力</summary>
	public required CoreService CoreService { get; init; }

	/// <summary>PLC 读取结构体引用（绑定到界面显示）</summary>
	public partial PlcStruct PlcRead { get; set; } = new();

	/// <summary>工号输入框文本</summary>
	public partial string WorkNoInput { get; set; } = "";

	/// <summary>工站名输入框文本</summary>
	public partial string StationNameInput { get; set; } = "";

	/// <summary>CT（节拍时间）显示值，单位秒（PLC 原始值为毫秒）</summary>
	public partial double CTSeconds { get; set; }

	/// <summary>当前工单配方名称（界面显示）</summary>
	public partial string WorkRecipeName { get; set; }

	/// <summary>当前工单号（MES 查询后填充）</summary>
	public partial string WorkOrderNo { get; set; }

	/// <summary>机种型号输入框文本（手动加载配方用）</summary>
	public partial string ModelNameInput { get; set; } = "";

	/// <summary>工单号输入框文本（手动加载配方用）</summary>
	public partial string WorkOrderNoInput { get; set; } = "";

	/// <summary>PLC 通信服务</summary>
	public required PlcService Plc { get; init; }

	/// <summary>报警服务</summary>
	public required AlarmService AlarmService { get; init; }

	/// <summary>EAP 客户端服务</summary>
	public required EapClientService EapClient { get; init; }

	/// <summary>设备状态提供者</summary>
	public required IEquipmentStatusProvider StatusProvider { get; init; }

	/// <summary>设备状态快照（排停控制用）</summary>
	public required EquipmentStatusSnapshot StatusSnapshot { get; init; }

	/// <summary>应用配置（工站名、产线、工号等）</summary>
	public required AppConfig AppConfig { get; init; } = new();

	/// <summary>配置管理器，用于持久化保存 AppConfig</summary>
	public required IConfigManager ConfigManager { get; init; }

	/// <summary>配方管理服务</summary>
	public required RecipeService RecipeService { get; init; }

	/// <summary>吸头上下文列表（绑定到界面吸头面板）</summary>
	public partial ObservableList<NozzleContext> NozzleContexts { get; set; } = [];

	/// <summary>物料空间上下文列表（绑定到界面料位面板）</summary>
	public partial ObservableList<MaterialSpaceContext> MaterialSpaceContexts { get; set; } = [];

	/// <summary>设备状态上下文列表（绑定到界面设备状态面板）</summary>
	public partial ObservableList<DeviceStatusContext> DeviceStatusContexts { get; set; } = [];

	/// <summary>工位上下文列表（绑定到界面工位面板）</summary>
	public partial ObservableList<WorkPositionContext> WorkPositionContexts { get; set; } = [];

	/// <summary>当前工单配方对象（界面显示和物料校验用）</summary>
	public partial ProductRecipe? WorkRecipe { get; set; }

	/// <summary>PLC IP 地址显示文本</summary>
	public partial string DisplayPlcIp { get; set; } = "NONE";

	/// <summary>当前正在编辑的料位上下文（换料弹窗用）</summary>
	public partial MaterialSpaceContext? EditMaterialSpaceContext { get; set; }

	/// <summary>排停时长（分钟）</summary>
	public partial int PlannedStopMinutes { get; set; } = 30;

	/// <summary>是否正在排停</summary>
	public partial bool IsPlannedStopActive { get; set; }

	/// <summary>排停剩余时间（MM:SS）</summary>
	public partial string PlannedStopRemaining { get; set; } = "";

	private CancellationTokenSource? _plannedStopCts;
	private DateTime _plannedStopEndTime;

	/// <summary>当前用户是否为管理员（RoleFlags >= 5）</summary>
	public partial bool IsAdmin { get; set; }

	#endregion

	#region ==================== 构造 & 初始化 ====================

	/// <summary>
	/// 构造函数。设计模式下创建模拟数据用于 XAML 预览。
	/// </summary>
	public MainVM()
	{
		if (Design.IsDesignMode)
		{
			NozzleContext.CreateList(NozzleContexts, CommonAppConfig.NozzleCount);             // 设计模式：创建模拟吸头数据
			MaterialSpaceContext.CreateList(MaterialSpaceContexts, CommonAppConfig.MaterialSpaceCount);  // 设计模式：创建模拟料位数据
			WorkPositionContext.CreateList(WorkPositionContexts, 2);                           // 设计模式：创建模拟工位数据
			DeviceStatusContext.CreateList(DeviceStatusContexts);                              // 设计模式：创建模拟设备状态数据
		}
	}

	/// <summary>
	/// 初始化主界面：绑定日志、PLC 数据、工号、工站名、线别到界面。
	/// </summary>
	/// <param name="ctx">上下文对象</param>
	/// <param name="args">初始化参数</param>
	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;                                // 设计模式跳过初始化
		Logs = LogRecordService.LogRecords;                                                // 绑定日志列表
		Logs.CollectionChanged += OnLogsCollectionChanged;                                 // 订阅日志变更事件（自动滚动）
		PlcRead = Plc.Read;                                                                // 绑定 PLC 读取结构体
		WorkNoInput = AppConfig.WorkerNo;                                                  // 初始化工号输入框
		StationNameInput = AppConfig.StationName;                                          // 初始化工站名输入框
		LineNameInput = AppConfig.Line;                                                    // 初始化线别输入框
		ModelNameInput = "";                                                               // 初始化机种型号输入框
		WorkOrderNoInput = "";                                                             // 初始化工单号输入框
		return base.Initialize(ctx, args);
	}

	/// <summary>
	/// 属性初始化完成后注入：将 CoreService 的上下文列表绑定到 VM 的属性。
	/// 由 IoC 容器在属性注入完成后自动调用。
	/// </summary>
	[Inject]
	public void OnPropertyInitialized()
	{
		MaterialSpaceContexts = CoreService.MaterialContexts;                               // 绑定物料上下文
		DeviceStatusContexts = CoreService.DeviceStatusContexts;                            // 绑定设备状态上下文
		NozzleContexts = CoreService.NozzleContexts;                                        // 绑定吸头上下文
		WorkPositionContexts = CoreService.WorkPositionContexts;                            // 绑定工位上下文
	}

	#endregion

	#region ==================== UI 定时刷新 ====================

	/// <summary>
	/// UI 定时刷新回调（由框架周期调用）。更新以下界面数据：
	/// <list type="bullet">
	///   <item><description>工单配方名称、工单号、PLC IP、CT 节拍时间</description></item>
	///   <item><description>料位的锁定/换料命令绑定</description></item>
	///   <item><description>设备连接状态（PLC、扫码枪1、扫码枪2）</description></item>
	///   <item><description>吸头压力值</description></item>
	///   <item><description>工位图片信息</description></item>
	/// </list>
	/// </summary>
	private void @UiTick()
	{
		if (ReferenceEquals(CoreService, null) || ReferenceEquals(WorkLeft, null) || ReferenceEquals(WorkRight, null))
			return;                                                                        // 服务未初始化完成，跳过

		WorkRecipe = CoreService.WorkRecipe;                                               // 同步当前工单配方
		WorkRecipeName = WorkRecipe?.Name ?? "";                                           // 更新配方名称显示
		WorkOrderNo = CoreService.WorkOrderNo;                                             // 更新工单号显示
		DisplayPlcIp = AppConfig.PlcIpAddress;                                             // 更新 PLC IP 显示
		CTSeconds = PlcRead.CT / 1000;                                                     // CT 毫秒转秒

		// 权限刷新
		IsAdmin = (App.Current.IOC.Get<ZitApp.Services.AccountService>().Account?.RoleFlags ?? 0) >= 5;

		// 排停倒计时更新
		if (IsPlannedStopActive && _plannedStopEndTime > DateTime.MinValue)
		{
			var remaining = _plannedStopEndTime - DateTime.Now;
			if (remaining.TotalSeconds <= 0)
			{
				// 时间到，自动恢复
				StatusSnapshot.SetPlannedStop(false);
				IsPlannedStopActive = false;
				PlannedStopRemaining = "";
				_plannedStopCts?.Dispose();
				_plannedStopCts = null;
				ShowToast(CommonUiApp.L("I18N.G.排停已结束").ToString(), UiMessageType.Success);
			}
			else
			{
				if (remaining.TotalHours >= 1)
					PlannedStopRemaining = $"{(int)remaining.TotalHours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
				else
					PlannedStopRemaining = $"{remaining.Minutes:D2}:{remaining.Seconds:D2}";
			}
		}

		// 绑定料位的锁定/换料命令（首次绑定，后续跳过）
		foreach (var item in MaterialSpaceContexts)
		{
			item.ToggleLockCommand ??= MaterialToggleLockCommand;                          // 绑定锁定/解锁命令
			item.MaterialReplaceCommand ??= MaterialReplaceCommand;                        // 绑定换料命令
		}

		// 更新设备连接状态
		foreach (var item in DeviceStatusContexts)
		{
			item.Status = item.Name switch
			{
				"PLC" => Plc.IsConnected ? "Connected" : "Disconnected",                  // PLC 连接状态
				"Scanner1" => WorkLeft.CodeScanner?.IsOpen ?? false ? "Connected" : "Disconnected",  // 扫码枪1 连接状态
				"Scanner2" => WorkRight.CodeScanner?.IsOpen ?? false ? "Connected" : "Disconnected", // 扫码枪2 连接状态
#if ASM15_1
				"Calibration" => CalibrationService?.IsConnected == true ? "Connected" : "Disconnected",
#endif
				_ => ""
			};
		}

		// 更新吸头压力值
		foreach (var item in NozzleContexts)
		{
			item.Value = item.Config.Id switch
			{
				1 => Plc.Read.吸头1压力,                                                   // 读取吸头1压力
				2 => Plc.Read.吸头2压力,                                                   // 读取吸头2压力
				3 => Plc.Read.吸头3压力,                                                   // 读取吸头3压力
				4 => Plc.Read.吸头4压力,                                                   // 读取吸头4压力
				5 => Plc.Read.吸头5压力,                                                   // 读取吸头5压力
				6 => Plc.Read.吸头6压力,                                                   // 读取吸头6压力
				7 => Plc.Read.吸头7压力,                                                   // 读取吸头7压力
				8 => Plc.Read.吸头8压力,  
				9 => Plc.Read.吸头9压力,
				10 => Plc.Read.吸头10压力,
				_ => 0
			};
		}

		// 更新工位图片信息
		foreach (var item in WorkPositionContexts)
		{
			if (item.Id == 1)
			{
				item.UpdateImageInfo();                                                    // 更新工位1视觉检测图片
				// item.AxisPercent = Plc.Read.工位1轨道百分比位置;
				// item.SN = WorkLeft.ScanSnCode;
				// item.WorkStep = WorkLeft.WorkStep;
				// item.ProductionState = WorkLeft.ProductionState;
			}
			else if (item.Id == 2)
			{
				item.UpdateImageInfo();                                                    // 更新工位2视觉检测图片
				// item.AxisPercent = Plc.Read.工位2轨道百分比位置;
				// item.SN = WorkRight.ScanSnCode;
				// item.WorkStep = WorkRight.WorkStep;
				// item.ProductionState = WorkRight.ProductionState;
			}
		}
	}

	/// <summary>
	/// 工单配方变更回调。配方变更时同步物料上下文并更新料位编码。
	/// </summary>
	/// <param name="value">新的配方对象</param>
	partial void OnWorkRecipeChanged(ProductRecipe? value)
	{
		if (value is null) return;
		ModelNameInput = value.Name ?? "";                                                 // 同步机种型号到输入框
		WorkOrderNoInput = CoreService.WorkOrderNo;                                        // 同步工单号到输入框
		LineNameInput = value.LineName ?? "";                                              // 同步线别到输入框
		CoreService.ApplyWorkRecipeToMaterialContexts();                                    // 将配方配置同步到所有料位
		// 更新各料位的位置编码（从 AppConfig 读取）
		for (var i = 0; i < CommonAppConfig.MaterialSpaceCount; i++)
		{
			var item = MaterialSpaceContexts[i];
			item.PositionCode = (1 + i) switch
			{
				1 => AppConfig.MaterialPositionCode1,                                      // 料位1位置编码
				2 => AppConfig.MaterialPositionCode2,                                      // 料位2位置编码
				3 => AppConfig.MaterialPositionCode3,                                      // 料位3位置编码
				4 => AppConfig.MaterialPositionCode4,                                      // 料位4位置编码
				5 => AppConfig.MaterialPositionCode5,                                      // 料位5位置编码
				6 => AppConfig.MaterialPositionCode6,                                      // 料位6位置编码
				_ => "UNKNOWN"
			};
		}
		CoreService.WriteMaterialEnableStatus();                                           // 将物料位启用状态写入PLC
	}

	#endregion

	#region ==================== 日志 ====================

	/// <summary>日志记录服务</summary>
	public required LogRecordService LogRecordService { get; init; }

	/// <summary>日志事件列表（绑定到界面日志 DataGrid）</summary>
	public partial ObservableList<LogEventInfo> Logs { get; set; } = [];

	/// <summary>
	/// 日志集合变更回调。新日志到来时自动滚动到最后一行（除非鼠标悬停在日志列表上）。
	/// </summary>
	/// <param name="sender">事件发送者</param>
	/// <param name="e">集合变更事件参数</param>
	private void OnLogsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		Dispatcher.UIThread.Post(() =>                                                     // 切换到 UI 线程
		{
			if (View.LogsDataGrid.IsPointerOver == false)                                   // 鼠标未悬停时自动滚动
			{
				View.LogsDataGrid.SelectedItem = Logs.LastOrDefault();                     // 选中最后一条日志
				View.LogsDataGrid.ScrollIntoView(View.LogsDataGrid.SelectedItem, null);    // 滚动到可见区域
			}
		});
	}

	#endregion

	#region ==================== 吸头 ====================

	/// <summary>是否有吸头配置（>0 个吸头时显示吸头面板）</summary>
	public bool HasNozzleContexts => CommonAppConfig.NozzleCount > 0;

#if ASM15_1
	public Asm15CalibrationService CalibrationService => CoreService.CalibrationService;
#endif
	public bool HasCalibrationService =>
#if ASM15_1
		true;
#else
		false;
#endif

	#endregion

	#region ==================== 物料操作 ====================

	/// <summary>
	/// 切换料位的锁定/解锁状态。调用 CoreService 发送 PLC 解锁/锁定请求。
	/// </summary>
	/// <param name="spaceContext">要操作的料位上下文</param>
	public async Task @MaterialToggleLock(MaterialSpaceContext spaceContext)
	{
		CoreService.SetMaterialSpaceLock(spaceContext.Id, !spaceContext.IsUnlocked).Unwarp();  // 切换锁定状态
		ShowToast("success", UiMessageType.Success);
	}

	/// <summary>
	/// 打开换料弹窗。前置校验：料位必须已解锁、配方中必须有该料位的启用配置。
	/// </summary>
	/// <param name="spaceContext">要换料的料位上下文</param>
	public async Task @MaterialReplace(MaterialSpaceContext spaceContext)
	{
		// 校验：料位必须已解锁
		if (spaceContext.IsUnlocked == false)
		{
			await ShowMessageBoxOverlay("please first unlock!", "material replace", MessageBoxIcon.Warning);
			return;
		}

		// 校验：配方中必须有该料位的启用配置
		if (WorkRecipe?.HasEnabledMaterialConfig(spaceContext.Id) != true)
		{
			await ShowMessageBoxOverlay(
				$"feeder {spaceContext.Id} has no enabled material row in recipe '{WorkRecipe?.Name ?? ""}'",
				"material replace",
				MessageBoxIcon.Warning);
			return;
		}

		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);                        // 同步配方配置到料位
		InputMaterialCode = "";                                                            // 清空料号输入
		InputMaterialPositionCode = "";                                                    // 清空位置码输入
		InputMaterialCount = spaceContext.Config.DefaultReplaceCount;                       // 设置默认换料数量
		EditMaterialSpaceContext = spaceContext;                                            // 记录当前编辑的料位
		await ShowModalDialog(View.ReplaceMaterialDialog);                                 // 打开换料弹窗
	}

	/// <summary>
	/// 换料确认操作。校验位置码、料号后调用 CoreService 设置物料数量。
	/// </summary>
	/// <param name="spaceContext">料位上下文（实际使用 EditMaterialSpaceContext）</param>
	public async Task @MaterialReplaceConfirm(MaterialSpaceContext spaceContext)
	{
		if (EditMaterialSpaceContext is null)
			return;
		spaceContext = EditMaterialSpaceContext;                                            // 使用弹窗打开时记录的料位
		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);                        // 同步配方配置

		// 校验：配方中必须有该料位的启用配置
		if (WorkRecipe?.HasEnabledMaterialConfig(spaceContext.Id) != true)
		{
			await ShowMessageBoxOverlay("no enabled material config for this feeder", "replace material",
				MessageBoxIcon.Error);
			return;
		}

		// 校验：位置码必须匹配
		var positionCode = InputMaterialPositionCode.Trim();
		if (EditMaterialSpaceContext.PositionCode != positionCode)
		{
			await ShowMessageBoxOverlay(
				$"position code not matched! current is '{positionCode}', need '{EditMaterialSpaceContext.PositionCode}'",
				"replace material",
				MessageBoxIcon.Error);
			return;
		}

		// 校验：料号必须在配方允许列表中
		var materialCode = InputMaterialCode.Trim();
		if (materialCode.Length > 12)
		{
			materialCode = materialCode[..12];                                             // 截断到 12 位
			InputMaterialCode = materialCode;                                              // 回写输入框
		}
		if (!WorkRecipe!.IsAllowedMaterialCode(spaceContext.Id, materialCode))
		{
			CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);
			await MaterialMismatchDialogService.ShowAsync(
				MaterialMismatchMessages.Build(spaceContext, WorkRecipe),
				"物料校验失败");                                                           // 弹窗显示物料不匹配详情
			return;
		}

		// 弹窗确认换料
		var option = await ShowMessageBoxOverlay(
			$"confirm replace material '{spaceContext.Config.PositionName}' x {InputMaterialCount}", "material replace",
			MessageBoxIcon.Question, MessageBoxButton.OKCancel);
		if (option is not MessageBoxResult.OK)
		{
			ShowToast("cancel");
			return;
		}

		// 调用 CoreService 设置物料数量（发送到 PLC）
		var result = await Task.Run(() => CoreService.SetMaterialCount(spaceContext.Id, InputMaterialCount));
		if (result.IsError())
		{
			ShowToast(result.Message!, UiMessageType.Error);
			return;
		}

		ShowToast("replace material success", UiMessageType.Success);
		await ShowMessageBoxOverlay("replace material success ", "replace material", MessageBoxIcon.Success);
		spaceContext.MaterialCode = materialCode;                                          // 更新料号
		CoreService.SyncMaterialContextFromWorkRecipe(spaceContext);                        // 再次同步配方配置
		CoreService.SaveMaterialSpaceCodes();                                              // 持久化料位编码
		View.ReplaceMaterialDialog.Close();                                                // 关闭换料弹窗
	}

	#region 换料弹窗属性

	/// <summary>位置码输入框文本</summary>
	public partial string InputMaterialPositionCode { get; set; } = "MaterialPositionCode";

	/// <summary>料号输入框文本</summary>
	public partial string InputMaterialCode { get; set; } = "MaterialCode";

	/// <summary>位置码输入框边框颜色（匹配时绿色，不匹配时橙色）</summary>
	public partial IBrush InputMaterialPositionCodeBorderBrush { get; set; }

	/// <summary>料号输入框边框颜色（匹配时绿色，不匹配时橙色）</summary>
	public partial IBrush InputMaterialCodeBorderBrush { get; set; }

	/// <summary>换料数量输入框值</summary>
	public partial int InputMaterialCount { get; set; }

	/// <summary>换料提示消息</summary>
	public partial string ReplaceMaterialTipMessage { get; set; } = "";

	/// <summary>线别输入框文本</summary>
	public partial string LineNameInput { get; set; }

	/// <summary>
	/// 位置码输入变更回调。实时校验位置码是否匹配，更新边框颜色。
	/// </summary>
	/// <param name="value">输入的位置码</param>
	partial void OnInputMaterialPositionCodeChanged(string value) =>
		InputMaterialPositionCodeBorderBrush =
			value == EditMaterialSpaceContext?.PositionCode ? Brushes.Green : Brushes.Orange;  // 匹配绿色，不匹配橙色

	/// <summary>
	/// 料号输入变更回调。实时校验料号是否在配方允许列表中，更新边框颜色。
	/// </summary>
	/// <param name="value">输入的料号</param>
	partial void OnInputMaterialCodeChanged(string value)
	{
		var feederId = EditMaterialSpaceContext?.Id;
		var ok = feederId is not null
		         && WorkRecipe?.HasEnabledMaterialConfig(feederId.Value) == true
		         && WorkRecipe.IsAllowedMaterialCode(feederId.Value, value);               // 校验料号是否在允许列表中
		InputMaterialCodeBorderBrush = ok ? Brushes.Green : Brushes.Orange;                // 允许绿色，不允许橙色
	}

	#endregion

	#endregion

	#region ==================== PLC 监控 ====================

	/// <summary>
	/// 打开 PLC 点位监控窗口。将 PLC 的读写结构体传给 PlcPointMonitorVM。
	/// </summary>
	public Task @OpenIoMonitor()
	{
		PlcPointMonitorVM.SetPlcStructs(Plc.Read, Plc.Write);                              // 传入 PLC 读写结构体
		PlcPointMonitorVM.View.Show();                                                     // 显示监控窗口
		// IoMonitorVM.Show();
		return Task.CompletedTask;
	}

	#endregion

	#region ==================== 工站/工号/线别修改 ====================

	/// <summary>
	/// 确认修改线别。校验非空、未变更后弹窗确认，保存到 AppConfig。
	/// </summary>
	public async Task @ConfirmLineNameChange()
	{
		var newStationName = LineNameInput.Trim();
		if (string.IsNullOrWhiteSpace(newStationName))
		{
			await ShowMessageBox("线别不能为空。", "修改线别", MessageBoxIcon.Error);       // 线别不能为空
			LineNameInput = AppConfig.Line;
			return;
		}

		if (string.Equals(AppConfig.Line, newStationName, StringComparison.Ordinal))
		{
			ShowToast("线别未变化。");                                                     // 线别未变更
			return;
		}

		// 弹窗确认修改
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

		AppConfig.Line = newStationName;                                                   // 更新配置
		var saveResult = await SaveAppConfigAsync();                                       // 持久化保存
		if (saveResult.IsError())
		{
			ShowNotification($"线别保存失败，重启后可能不会生效：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		LineNameInput = AppConfig.Line;
		ShowToast("线别已修改。", UiMessageType.Success);
	}

	/// <summary>
	/// 确认修改工号。校验非空、未变更后弹窗确认，同步到 CoreService 和 AppConfig。
	/// </summary>
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
			ShowToast("unchanged");                                                        // 工号未变更
			return;
		}

		// 弹窗确认修改
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

		CoreService.WorkerNo = newWorkNo;                                                  // 更新运行时工号
		AppConfig.WorkerNo = newWorkNo;                                                    // 更新配置工号
		await SaveAppConfigAsync();                                                        // 持久化保存
		WorkNoInput = CoreService.WorkerNo;
		ShowToast("change success", UiMessageType.Success);
	}

	/// <summary>
	/// 确认修改工站名。校验非空、未变更后弹窗确认，保存到 AppConfig。
	/// </summary>
	public async Task @ConfirmStationNameChange()
	{
		var newStationName = StationNameInput.Trim();
		if (string.IsNullOrWhiteSpace(newStationName))
		{
			await ShowMessageBox("工站名不能为空。", "修改工站名", MessageBoxIcon.Error);   // 工站名不能为空
			StationNameInput = AppConfig.StationName;
			return;
		}

		if (string.Equals(AppConfig.StationName, newStationName, StringComparison.Ordinal))
		{
			ShowToast("工站名未变化。");                                                   // 工站名未变更
			return;
		}

		// 弹窗确认修改
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

		AppConfig.StationName = newStationName;                                            // 更新配置
		var saveResult = await SaveAppConfigAsync();                                       // 持久化保存
		if (saveResult.IsError())
		{
			ShowNotification($"工站名保存失败，重启后可能不会生效：{saveResult.Message}", UiMessageType.Error);
			return;
		}

		StationNameInput = AppConfig.StationName;
		ShowToast("工站名已修改。", UiMessageType.Success);
	}

	/// <summary>
	/// 持久化保存 AppConfig 到 JSON 配置文件。
	/// </summary>
	/// <returns>保存结果</returns>
	private async Task<Result> SaveAppConfigAsync()
	{
		var currentConfigContext = AppConfig.AccessConfigContext() as JsonConfigContext;     // 获取配置上下文
		if (currentConfigContext?.SavePath == null)
			return Result.Err("Unable to get the config save path.");                      // 无法获取保存路径

		return await ConfigManager.SaveConfigAsync(AppConfig, currentConfigContext.SavePath);  // 异步保存配置
	}

	#endregion

	#region ==================== 手动加载配方 ====================

	/// <summary>
	/// 手动加载配方。根据输入的机种型号查找配方，找到后设置到 CoreService。
	/// </summary>
	public async Task @LoadRecipe()
	{
		var modelName = ModelNameInput.Trim();
		if (string.IsNullOrWhiteSpace(modelName))
		{
			ShowToast("请输入机种型号", UiMessageType.Warning);
			return;
		}

		var recipeResult = RecipeService.GetRecipe(modelName);
		if (recipeResult.IsError())
		{
			// 配方不存在，弹窗让用户创建
			var option = await ShowMessageBoxOverlay(
				$"配方 '{modelName}' 不存在，是否创建？",
				"配方加载",
				MessageBoxIcon.Question,
				MessageBoxButton.YesNo);
			if (option is MessageBoxResult.Yes)
			{
				await CoreService.TryCreateMaterialRecipe(modelName);
				// 创建后再次尝试加载
				recipeResult = RecipeService.GetRecipe(modelName);
				if (recipeResult.IsError())
				{
					ShowToast($"配方 '{modelName}' 创建失败或未完成", UiMessageType.Error);
					return;
				}
			}
			else
			{
				ShowToast("取消加载配方");
				return;
			}
		}

		var recipe = recipeResult.Value!;

		// 校验关联的完整配方
		if (recipe.RefFullRecipe is not { Points: not null })
		{
			ShowToast($"配方 '{modelName}' 关联的完整配方不存在", UiMessageType.Error);
			return;
		}

		// 设置到 CoreService
		CoreService.WorkRecipe = recipe;
		CoreService.WorkOrderNo = WorkOrderNoInput.Trim();

		ShowToast($"配方 '{modelName}' 加载成功", UiMessageType.Success);
	}

	#endregion

	#region ==================== NG 弹窗测试 ====================

	/// <summary>
	/// 测试工位1 NG弹窗：手动读取PLC NG地址，解析后弹出NG详情弹窗。
	/// 注意：会清零PLC中的NG原因区域，停线时测试。
	/// </summary>
	public async Task @TestNgDialogStation1()
	{
		WorkLeft.ReadNgItems();
		await CoreService.WorkPositionContexts[0].ShowNgDetailDialog();
	}

	/// <summary>
	/// 测试工位2 NG弹窗：手动读取PLC NG地址，解析后弹出NG详情弹窗。
	/// 注意：会清零PLC中的NG原因区域，停线时测试。
	/// </summary>
	public async Task @TestNgDialogStation2()
	{
		WorkRight.ReadNgItems();
		await CoreService.WorkPositionContexts[1].ShowNgDetailDialog();
	}

	#endregion

	#region ==================== EAP 测试 ====================

	/// <summary>
	/// 测试 EAP S5F1 报警上报。推送一个测试报警到 AlarmService，由 EAP 客户端上报。
	/// </summary>
	public async Task @TestEapAlarm()
	{
		if (!EapClient.IsConnected)
		{
			ShowToast("EAP 未连接", UiMessageType.Warning);
			return;
		}

		var alarmInfo = new AlarmInfo
		{
			Id = 1,
			Name = "上料轴1_正极限",
			Value = 1,
			Time = DateTime.Now
		};

		AlarmService.PushAlarm(this, alarmInfo, null);
		ShowToast("EAP S5F1 测试报警已推送", UiMessageType.Success);
	}

	/// <summary>
	/// 测试 EAP S6F11/6001 设备状态变更上报。
	/// </summary>
	public async Task @TestEapStatusChange()
	{
		if (!EapClient.IsConnected)
		{
			ShowToast("EAP 未连接", UiMessageType.Warning);
			return;
		}

		var status = StatusProvider.GetCurrentStatus();
		var result = await EapClient.TrySendStatusChangeReportAsync(status);
		ShowToast(result
			? $"EAP S6F11/6001 状态变更已上报: {status}"
			: "EAP S6F11/6001 上报失败",
			result ? UiMessageType.Success : UiMessageType.Error);
	}

	/// <summary>
	/// 测试 EAP S6F11/6002 产品过站上报。
	/// </summary>
	public async Task @TestEapProductFinish()
	{
		if (!EapClient.IsConnected)
		{
			ShowToast("EAP 未连接", UiMessageType.Warning);
			return;
		}

		var data = new Dictionary<string, string>
		{
			[EapReportIds.EquipmentStatus] = StatusProvider.GetCurrentStatus().ToString(),
			[EapReportIds.Input] = Plc.Read.已生产数量.ToString(),
			[EapReportIds.Output] = Plc.Read.已生产数量.ToString(),
			[EapReportIds.CT] = "0",
			[EapReportIds.WorkOrder] = CoreService.WorkOrderNo ?? "",
			[EapReportIds.ProductSN] = "TEST-SN-001",
			[EapReportIds.ModelName] = "TEST-MODEL",
			[EapReportIds.LaneNo] = AppConfig.Line ?? "",
			[EapReportIds.Yield] = Plc.Read.良率.ToString("F2"),
		};

		EapClient.UpdateReportValues(data);

			var result = await EapClient.TrySendProductFinishReportAsync(data);
		ShowToast(result
			? "EAP S6F11/6002 产品过站已上报"
			: "EAP S6F11/6002 上报失败",
			result ? UiMessageType.Success : UiMessageType.Error);
	}

	#endregion

	#region ==================== 机台排停 ====================

		/// <summary>
		/// 触发机台排停，设置时长后状态变为 E5001，到时自动恢复。
		/// </summary>
		public async Task @TriggerPlannedStop()
		{
			if (!IsAdmin)
			{
				ShowToast(CommonUiApp.L("I18N.G.排停无权").ToString(), UiMessageType.Warning);
				return;
			}

			if (IsPlannedStopActive)
			{
				ShowToast(CommonUiApp.L("I18N.G.排停已进行").ToString(), UiMessageType.Warning);
				return;
			}

			if (PlannedStopMinutes <= 0)
			{
				ShowToast(CommonUiApp.L("I18N.G.排停时长无效").ToString(), UiMessageType.Warning);
				return;
			}

			_plannedStopCts?.Dispose();
			_plannedStopCts = new CancellationTokenSource();
			var duration = TimeSpan.FromMinutes(PlannedStopMinutes);
			_plannedStopEndTime = DateTime.Now + duration;

			StatusSnapshot.SetPlannedStop(true);
			IsPlannedStopActive = true;
			if (duration.TotalHours >= 1)
				PlannedStopRemaining = $"{(int)duration.TotalHours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";
			else
				PlannedStopRemaining = $"{duration.Minutes:D2}:{duration.Seconds:D2}";

			ShowToast($"{CommonUiApp.L("I18N.G.排停已触发")}，{PlannedStopMinutes} {CommonUiApp.L("I18N.G.排停分钟恢复")}", UiMessageType.Success);

			// 后台定时任务，到时间自动恢复（UiTick 做兜底）
			var ctk = _plannedStopCts.Token;
			_ = Task.Run(async () =>
			{
				try
				{
					await Task.Delay(duration, ctk);
					if (!ctk.IsCancellationRequested)
					{
						StatusSnapshot.SetPlannedStop(false);
						IsPlannedStopActive = false;
						PlannedStopRemaining = "";
						ShowToast(CommonUiApp.L("I18N.G.排停已结束").ToString(), UiMessageType.Success);
					}
				}
				catch (TaskCanceledException) { }
			}, ctk);
			await Task.CompletedTask;
		}

		/// <summary>
		/// 取消当前排停，立即恢复设备状态。
		/// </summary>
		public async Task @CancelPlannedStop()
		{
			if (!IsAdmin)
			{
				ShowToast(CommonUiApp.L("I18N.G.排停无权").ToString(), UiMessageType.Warning);
				return;
			}

			if (!IsPlannedStopActive)
			{
				ShowToast(CommonUiApp.L("I18N.G.排停无进行").ToString(), UiMessageType.Warning);
				return;
			}

			_plannedStopCts?.Cancel();
			_plannedStopCts?.Dispose();
			_plannedStopCts = null;
			StatusSnapshot.SetPlannedStop(false);
			IsPlannedStopActive = false;
			PlannedStopRemaining = "";
			ShowToast(CommonUiApp.L("I18N.G.排停已取消").ToString(), UiMessageType.Success);
			await Task.CompletedTask;
		}

	#endregion
}
