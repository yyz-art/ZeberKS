using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.Mvvm;
using ZC.Text;
using ZC.UI.Utils;
using ZC.Utils;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Devices.Screw;
using ZitApp.Ext.EapClient;
using ZitApp.Models;
using ZitApp.UI.Dialogs;

namespace ZitApp.Services;

/// <summary>
/// 工位1工作服务，负责工位1的完整生产流程：扫码入站 → MES查询 → 配方校验 → 物料校验 → MES进站 → 过站出站。
/// 通过PLC信号驱动状态机，每个周期轮询PLC读取触发信号并执行对应业务逻辑。
/// 支持ASM4/SUB1/ASM12/ASM15_1/ASM15_2/MFG15等多机型编译。
/// </summary>
[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class WorkService1 : WorkServiceBase
{
#if ASM15_1
	[Inject(SpecialName = "Screw工位1")] public required ScrewMachineConnection Screw { get; init; } // 螺丝枪TCP连接（仅ASM15_1）
	public ScrewMachineData ScrewData { get; private set; } = new();          // 螺丝枪实时数据
	public const int ScrewCount = 16;                                         // 螺丝总数
	public double[] ScrewTurns { get; private set; } = new double[ScrewCount]; // 每颗螺丝的圈数
	public double[] ScrewMaxTorque { get; private set; } = new double[ScrewCount]; // 每颗螺丝的最大扭矩
	public int 螺丝拧紧完成信号 { get; private set; } = 0;                     // PLC上报的螺丝拧紧完成序号
#endif
	public StringBuilder DataBuilder { get; private set; } = new();           // MES出站上报数据拼接器

	public override string ServiceName => $"WP-{GetType().Name[^1]}";         // 服务名取类名末字符，即"1"
	public required PlcService Plc { get; init; }                             // PLC通信服务（Modbus TCP）
	public required CoreService Core { get; init; }                           // 核心业务服务（配方、物料、吸头管理）
	public required MesService Mes { get; init; }                             // MES通信服务（SIFS TCP协议）
	public required AppConfig AppConfig { get; init; }                        // 应用配置（站点名、线体、端口等）
	public required CreateMaterialRecipeVM CreateMaterialRecipeVM { get; init; } // 创建物料配方弹窗VM
	public required NgService NgService { get; init; }                        // NG记录持久化服务
	public required EapClientService EapClient { get; init; }                 // EAP客户端服务
	public required IEquipmentStatusProvider StatusProvider { get; init; }     // 设备状态提供者
	public IDataSocket CodeScanner { get; set; } = null!;                     // 扫码枪串口连接（SN扫码）
#if ASM15_1
	public IDataSocket CodeScannerKeyPart { get; set; } = null!;                   // 扫码枪串口连接（KeyPart扫码）
#endif
	public WorkPositionContext Context { get; set; } = null!;                 // 工位1上下文（扫码结果、生产状态等）

	public int 料座感应状态 { get; set; }                                     // 上一次料座感应状态（用于边沿检测）

	/// <summary>
	/// 服务初始化：绑定工位1上下文，获取扫码枪串口实例并异步打开连接。
	/// </summary>
	protected override Task OnInitialize(object? ctx, object? args)
	{
		Context = Core.WorkPositionContexts.First(t => t.Name == ServiceName); // 从CoreService获取工位1上下文
		CodeScanner = App.Current.IOC.Get<IDataSocket>("Scanner工位1");        // 从IOC获取扫码枪串口实例（SN）
		Task.Run(() => CodeScanner.Open());                                    // 异步打开扫码枪串口，避免阻塞初始化
#if ASM15_1
		CodeScannerKeyPart = App.Current.IOC.Get<IDataSocket>("Scanner工位1_2");   // 从IOC获取扫码枪串口实例（KeyPart）
		Task.Run(() => CodeScannerKeyPart.Open());
#endif
		return base.OnInitialize(ctx, args);
	}

	/// <summary>
	/// 工位1主循环，每个PLC周期轮询一次，按状态机驱动生产流程。
	/// 流程：扫码触发 → 吸头点检 → 扫码 → MES查询 → 配方校验/切换 → 物料校验 → MES进站 → 写PLC允许生产。
	/// 过站：PLC数据上报请求 → MES出站 → 写PLC上报响应。
	/// 信号复位：PLC请求信号清零后复位响应信号。
	/// </summary>
	protected override Task Main(CancellationToken ctk)
	{
		Thread.Sleep(5000); // 启动后等待5秒，确保PLC和其他服务就绪

		while (ctk.IsCancellationRequested == false)
		{

			Plc.WaitNextCycle();                                              // 等待下一个PLC通信周期（同步PLC读写节奏）
			Context.AxisPercent = Plc.Read.工位1轨道百分比位置;                // 更新轨道位置百分比（UI显示用）

			// ==================== 入站流程 ====================
			// PLC扫码枪1触发信号=1时开始入站：吸头点检 → 扫码 → MES查询 → 配方校验 → 物料校验 → MES进站

#if ASM15_1
			if (Plc.Read is { 扫码枪1触发: 2, 扫码枪1触发结果: 0 }) // ASM15_1: 触发=2表示扫码KeyPart
#else
			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 }) // 其他机型: 触发=1表示扫码SN
#endif
			{
#if ASM15_1
				Context.ScanKeyPartCode = "";                     // 清空KeyPart码
				螺丝拧紧完成信号 = 0;                            // 重置PC本地螺丝拧紧完成序号
				Plc.Write.工位1螺丝拧紧完成信号 = 0;              // 清零PLC侧信号，防止残留数据重复读取
				Plc.Write.WritePoint(nameof(PlcStruct.工位1螺丝拧紧完成信号));
				Array.Clear(ScrewTurns);                          // 清空螺丝圈数数组
				Array.Clear(ScrewMaxTorque);                      // 清空螺丝扭矩数组
				if (Plc.Read.工位1螺丝拧紧完成信号 > 1)
					Plc.Read.工位1螺丝拧紧完成信号 = 0;
				UiUtils.InvokeOnUiThread(() =>                    // 在UI线程清空螺丝安装数据列表
				{
					foreach (var item in Context.ScrewInstallDataList)
					{
						item.ScrewNo = 0;
						item.MaxTorque = 0;
						item.Turns = 0;
						item.CollectedAt = default;
						item.HasValue = false;
					}
				});
#else
				Context.ScanSnCode = "";                          // 清空SN码，准备新一轮扫码
#endif
				Context.TestScanner = false;                      // 重置测试扫码标志
				Context.ErrorMessage = null;                      // 清空错误消息
				Context.ModelName = "";                           // 清空机种型号
				Context.ProductionState = ProductionState.NA;     // 重置生产状态为NA

				if (Core.IsNozzlePressureOk == false) // 吸嘴压力未就绪（未点检）
				{
					Logger.Error("[NOZZLE CHECK] [ERROR] nozzle pressure not ready!");
					Context.ErrorMessage = "nozzle pressure not ready!";
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
					goto SendResult;
				}

#if ASM15_1
				if (Core.CalibrationService?.CalibrationCheckEnabled == true && !Core.IsCalibrationOk) // ASM15_1: 校准检查
				{
					Logger.Error("[CALIBRATION CHECK] calibration check failed — production blocked!");
					Context.ErrorMessage = "calibration check failed!";
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
					goto SendResult;
				}
#endif

				Context.WorkStep = WorkStep.SCAN_SN;              // 设置工作步骤为扫码阶段

				string scanCode;

				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [DOING] ...");
				if (CommonAppConfig.IsDevTestMode == false)       // 非调试模式才真正调用扫码枪
				{
#if ASM15_1
					var scanner = CodeScannerKeyPart;
#else
					var scanner = CodeScanner;
#endif
#if SUB1
					var scanCodeResult = AppConfig.UseTcpScanner ? DoScanCodeTcp(scanner) : DoScanCode(scanner);
#else
					var scanCodeResult = DoScanCode(scanner);
#endif
					if (scanCodeResult.IsError())
					{
						Logger.Error($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [ERROR] {scanCodeResult.Message}");
						Context.ErrorMessage = "scan code failed, code scanner connection error!";
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
						goto SendResult;
					}

					scanCode = scanCodeResult.Value!;
					int codeMinLength;
#if ASM15_1
					Context.ScanKeyPartCode = scanCode;                   // ASM15_1: 存储KeyPart码
					codeMinLength = AppConfig.KeyPartCodeMinLength;       // KeyPart码最小长度校验
#else
					Context.ScanSnCode = scanCode;                        // 存储SN码到工位上下文
					codeMinLength = AppConfig.SnCodeMinLength;            // SN码最小长度校验
#endif
					if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength) // 条码长度校验
					{
						Logger.Error(
							$"[SCAN CODE-{Plc.Read.扫码枪1触发}] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
						Context.ErrorMessage = "scan code check failed, length out of range!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}
				}
				else
				{
					scanCode = $"DEBUG-TEST-{DateTime.Now:yyyyMMdd-HHmmss}"; // 调试模式生成模拟条码
				}


				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [OK] CONTENT='{scanCode}'");

				MesQueryPoint:
				if (Context.MesEnabled)                                            // MES开关开启时执行MES查询
				{
					Context.WorkStep = WorkStep.MES_QUERY;                         // 设置工作步骤为MES查询
					var mes7 = $"SMD_QUERY,{Context.ScanSnCode},7,,SMD,,OK,MO_NUMBER=??? MODEL_NAME=???"; // 构造MSG7查询工单和机种
					Logger.Info($"[MES QUERY] [DOING] MES << '{mes7}'");
					var mesMsg7Result = Mes.SendAndReadString(mes7);               // 发送MSG7并读取MES响应
					if (mesMsg7Result.IsError() || mesMsg7Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error(
							mesMsg7Result.IsError()
								? $"[MES QUERY] [ERROR] MES connection error! {mesMsg7Result.Message}"
								: $"[MES QUERY] [ERROR] MES << '{mesMsg7Result.Value}'");

						Context.ErrorMessage = mesMsg7Result.IsError()
							? "mes query failed, mes connection error!"
							: $"mes query failed, mes return >> '{mesMsg7Result.Value}'";
						Plc.Write.工位1允许生产 = 2;                              // 禁止生产
						Plc.Write.扫码枪1触发结果 = CodeOfNG;                      // 扫码结果NG
						goto SendResult;                                           // 跳到发送结果
					}

					var rawAscii = mesMsg7Result.Value;
					var parseResult = ParseMesModelInfo(rawAscii);                 // 解析MES响应中的MO_NUMBER和MODEL_NAME
					if (parseResult.WorkOrder is null || parseResult.ModelName is null)
					{
						Logger.Error(
							$"[MES QUERY] [ERROR] (MO_NUMBER='{parseResult.WorkOrder}',MODEL_NAME='{parseResult.ModelName}')] has empty value!");
						Context.ErrorMessage =
							$"mes query error (MO_NUMBER='{parseResult.WorkOrder}',MODEL_NAME='{parseResult.ModelName}') has empty value!";
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}


					Core.WorkOrderNo = parseResult.WorkOrder;                    // 保存工单号到核心服务
					Context.ModelName = parseResult.ModelName;                     // 保存机种型号到工位上下文
					Logger.Info($"[MES QUERY] [OK] MO_NUMBER='{Core.WorkOrderNo}' MODEL_NAME='{Context.ModelName}'");
				}
				else
				{
					Logger.Info($"[MES IN-STA] [OK:Skip] SN='{Context.ScanSnCode}' KEY-PART='{Context.ScanKeyPartCode}'");
					Plc.Write.扫码枪1触发结果 = CodeOfOK;                          // MES关闭时直接返回OK
					Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;                    // 允许生产
					goto SendResult;
				}


				// ==================== 配方校验 ====================
				RecipeCheckPoint:
				if (Context.RecipeCheck)                                           // 配方校验开关开启时执行
				{
					Context.WorkStep = WorkStep.RECIPE_CHECK;                      // 设置工作步骤为配方校验
					var recipeResult = Core.RecipeService.GetRecipe(Context.ModelName); // 按机种型号查找配方
					if (recipeResult.IsError())                                        // 配方不存在
					{
						var wait = Core.TryCreateMaterialRecipe(Context.ModelName); // 弹窗让用户创建配方
						wait.Wait(TimeSpan.FromSeconds(60));                        // 等待用户操作，最长60秒
						recipeResult = Core.RecipeService.GetRecipe(Context.ModelName); // 再次尝试获取
					}

					if (recipeResult.IsError())
					{
						Logger.Error(
							$"[RECIPE CHECK] [ERROR] recipe not found! SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						Context.ErrorMessage = "recipe check failed, recipe not found!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var recipe = recipeResult.Value!;
					if (recipe.RefFullRecipe is not { Points: not null })          // 校验关联的完整配方是否存在
					{
						Logger.Error(
							$"[RECIPE CHECK] [ERROR] recipe ref tcx recipe not found! (recipe='{recipe.Name}', ref tcx ='{recipe.RefFullRecipeName}')");
						Context.ErrorMessage = "recipe check failed, recipe ref tcx recipe not found!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					if (Plc.Read.上位机当前配方ID == Plc.Read.PLC当前配方ID &&      // PC与PLC配方ID一致
					    Core.WorkRecipe?.Id == recipe.Id ||                          // 且当前配方匹配
					    Core.WorkRecipe?.RefFullRecipe?.Id == Plc.Read.上位机当前配方ID) // 或完整配方ID匹配
					{
						Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						Core.WriteMaterialEnableStatus();                            // 同种配方也同步物料位状态到PLC
						goto MaterialCheckPoint;                                    // 配方一致，跳到物料校验
					}

					Logger.Info($"[RECIPE CHANGE] [DOING]" +                        // 需要切换配方
					            $" Old(PLC-ID={Plc.Read.PLC当前配方ID}', PC-ID={Plc.Read.上位机当前配方ID}) =>" +
					            $" New(Id={recipe.Id}, Name={recipe.Name}')");

					if (false == Core.RecipeSwitchLock.Wait(TimeSpan.FromSeconds(AppConfig.RecipeSwitchWaitTimeout))) // 获取配方切换锁
					{
						Logger.Error("[RECIPE CHANGE] [ERROR] Wait lock timeout! ");
						Context.ErrorMessage = "recipe change failed, wait lock timeout!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					try
					{
						if (Plc.Read.上位机当前配方ID == Plc.Read.PLC当前配方ID &&  // 二次检查：锁内再确认配方是否已切换
						    Core.WorkRecipe?.Id == recipe.Id ||
						    Core.WorkRecipe?.RefFullRecipe?.Id == Plc.Read.上位机当前配方ID)
						{
							Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
							Core.WriteMaterialEnableStatus();                        // 同种配方也同步物料位状态到PLC
							goto MaterialCheckPoint;
						}

						if (Core.IsWorkPositionFree() == false)                     // 工位正在生产中，不允许切换配方
						{
							Logger.Warn($"[RECIPE CHANGE] [FAILL] work position is doing ,can't change recipe!");
							Context.ErrorMessage = "recipe change failed, work position is doing!";
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						if (recipe.RefFullRecipe!.Id != Plc.Read.上位机当前配方ID)   // 完整配方ID与PLC不一致，需要下发
						{
							Context.WorkStep = WorkStep.RECIPE_SEND;                // 设置工作步骤为配方下发
							Logger.Info("[RECIPE CHANGE] recipe data sending ...! ");
							var distributeRecipeTask = Core.DistributeRecipeAsync(recipeResult.Value!); // 向PLC下发配方数据
							distributeRecipeTask.Wait();                            // 等待下发完成
							if (distributeRecipeTask.Result.IsError())
							{
								Logger.Error(
									$"[RECIPE CHANGE] [ERROR] Recipe data send failed! {distributeRecipeTask.Exception?.Message ?? distributeRecipeTask.Result.Message} ");
								Context.ErrorMessage = "recipe change failed, recipe data send failed!";
								Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
								Plc.Write.扫码枪1触发结果 = CodeOfNG;
								goto SendResult;
							}

							Logger.Info("[RECIPE CHANGE] Recipe data sended.");
							Context.WorkStep = WorkStep.RECIPE_WAIT;                // 设置工作步骤为等待PLC确认
							var startWaitTime = DateTime.Now;
							var endWaitTime = startWaitTime.AddMilliseconds(AppConfig.RecipeSwitchWaitTimeout); // 计算超时时间
							if (CommonAppConfig.IsDevTestMode)
							{
								Plc.Write.PLC当前配方ID = (short)recipe.Id;         // 调试模式模拟PLC写入配方ID
								Plc.Write.WritePoint(nameof(PlcStruct.PLC当前配方ID));
								Plc.Write.配方下发响应 = 1;                          // 调试模式模拟PLC确认
								Plc.Write.WritePoint(nameof(PlcStruct.配方下发响应));
							}

							while (Plc.Read.配方下发响应 != 1 &&                    // 等待PLC配方下发响应=1
							       DateTime.Now < endWaitTime)
								Thread.Sleep(100);                                  // 每100ms检查一次
							if (Plc.Read.配方下发响应 != 1)                         // 超时未收到响应
							{
								Logger.Error("[RECIPE CHANGE] [ERROR] Wait plc change recipe timeout.");
								Context.ErrorMessage = "recipe change failed, wait plc change recipe timeout!";
								Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
								Plc.Write.扫码枪1触发结果 = CodeOfNG;
								goto SendResult;
							}
						}

						Core.WorkRecipe = recipe;                                   // 更新当前工作配方
#if ASM12
						Plc.Plc.Write("23000", recipe.Name ?? "", 20);              // 写入PC当前配方名称到PLC
						Logger.Info($"[RECIPE CHANGE] [OK] Write recipe name to PLC: '{recipe.Name}'");
#endif
						Logger.Info("[RECIPE CHANGE] [OK] Recipe changed successfully!.");
					}
					finally
					{
						Core.RecipeSwitchLock.Release();                            // 释放配方切换锁
					}

					Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
				}
				else
					Logger.Warn(
						$"[RECIPE CHECK] [OK:UnCheck] SN='{Context.ScanSnCode}'  MODEL_NAME='{Context.ModelName}'");


				// ==================== 物料校验 ====================
				MaterialCheckPoint:
				if (Context.MaterialCheck)                                             // 物料校验开关开启时执行
				{
					if (Core.TryValidateMaterialsForProduction(out var material, out var materialDetail)) // 校验所有料位物料与配方匹配
						Logger.Info($"[MATERIAL CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
					else
					{
						Logger.Error(
							$"[MATERIAL CHECK] [ERROR] {materialDetail} SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						if (material is not null)
							Core.NotifyMaterialCheckFailed(material);                    // 弹窗提示物料校验失败详情
						Context.ErrorMessage = $"material {material?.Id} check failed!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MATERIAL;       // 物料校验失败禁止生产
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						Context.ErrorMessage = "MATERIAL CHECK FAILED!";
						goto SendResult;
					}
				}
				else
					Logger.Warn(
						$"[MATERIAL CHECK] [OK:UnCheck] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'"); // 物料校验关闭时跳过


			// ==================== NG SN码校验 ====================
			NgSnCheckPoint:
			if (Context.NgSnCheck)
			{
				if (NgService.ExistsBySnCodeAsync(Context.ScanSnCode).Result)
				{
					Logger.Error($"[NG SN CHECK] [ERROR] SN='{Context.ScanSnCode}' already exists in NG database, not allow production!");
					Context.ErrorMessage = "NG SN check failed, product was already rejected!";
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}
			}
			else
				Logger.Warn($"[NG SN CHECK] [OK:UnCheck] SN='{Context.ScanSnCode}'");


			// ==================== MES进站 ====================
			InStationExecutePoint:
				var msg1 =
					$"{AppConfig.StationName.Trim()},{Context.ScanSnCode.Trim()},1,{Core.WorkerNo.Trim()},{AppConfig.Line.Trim()},,OK,,,";
				Context.WorkStep = WorkStep.IN_STATION;                              // 设置工作步骤为MES进站
				Logger.Info($"[MES IN-STA] [DOING] MES1 << '{msg1}'");
				var mesMsg1Result = Mes.SendAndReadString(msg1);                     // 发送MSG1进站请求
				if (mesMsg1Result.IsError() || mesMsg1Result.Value!.StartsWith("OK") is false)
				{
					Logger.Error(Context.ErrorMessage = mesMsg1Result.IsError()
						? $"[MES IN-STA] [ERROR] MES1 connection error!"
						: $"[MES IN-STA] [ERROR] MES1 >> '{mesMsg1Result.Value}'");
					Context.ErrorMessage = $"in-station failed, mes return >> '{mesMsg1Result.Value}'";
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;            // MES进站失败禁止生产
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}

				Logger.Info($"[MES IN-STA] [OK] MES1 >> '{mesMsg1Result.Value}'");
#if ASM15_1
				var msg3 =                                                           // ASM15_1: 发送MSG3关联KeyPart码
					$"{AppConfig.StationName},{Context.ScanSnCode},3,{Core.WorkerNo},{AppConfig.Line},,OK,{Context.ScanKeyPartCode},,";
				var respMsg3Result = Mes.SendAndReadString(msg3);                    // 发送MSG3并读取响应
				Logger.Info($"[MES IN-STA] [DOING] MES3 << '{msg3}'");
				if (respMsg3Result.IsError() || respMsg3Result.Value?.StartsWith("OK") == false)
				{
					Logger.Error(respMsg3Result.IsError()
						? $"[MES IN-STA] [ERROR] {respMsg3Result.Message}"
						: $"[MES IN-STA] [ERROR]  MES3 >> '{respMsg3Result.Value}");
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}
				Logger.Info($"[MES IN-STA] [OK] MES3 >> '{respMsg3Result.Value}'");
#endif

				Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;                        // 所有校验通过，允许生产
				Plc.Write.扫码枪1触发结果 = CodeOfOK;                              // 扫码结果OK

				SendResult:
				Context.WorkStep = Plc.Write.工位1允许生产 == 1 ? WorkStep.ALLOW_PRODUCTION : WorkStep.NOT_ALLOW_PRODUCTION; // 设置工作步骤
				if (Context.DayProductionId == 0)
					{
						Context.DayProductionId = Core.GetDayProductionId();            // 获取当日生产序号（每天从1开始）
					}
				var now = DateTime.Now;
				Context.ImagePathRoot = Path.Combine(AppConfig.VisionImagePath,     // 构建图像保存路径：根目录/年月/日/序号_SN
					now.ToString("yyyy-MM"), now.ToString("dd"), $"{Context.DayProductionId}_{Context.ScanSnCode}");
				Plc.Write.扫码枪1触发 = 0;                                          // 复位PLC扫码触发信号
				Logger.Info(
					$"[MES IN-STA] [DONE] SCAN=({Plc.Write.扫码枪1触发结果},'{Context.ScanSnCode}') EN={Plc.Write.工位1允许生产}");
				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1允许生产), this, static ctx => // 写入PLC允许生产信号（带重试）
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc allow production result failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);                                              // 写入失败时等待5秒后重试
					return true;
				});
				Plc.Write.工位1生产序号 = Context.DayProductionId;                  // 写入当日生产序号到PLC
				Plc.Write.WritePoint(nameof(PlcStruct.工位1生产序号));
				Plc.Plc.Write($"{PlcStructInfo.扫码枪1扫码内容.Offset}", Context.ScanSnCode, 80); // 写入扫码内容到PLC（80字符）
				Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发结果), this, static ctx => // 写入扫码结果信号（带重试）
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc code scan signal failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});

				if (CommonAppConfig.IsDevTestMode)                                   // 调试模式：手动复位扫码触发信号
				{
					Plc.Write.扫码枪1触发 = 0;
					Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发), this, static ctx =>
					{
						ctx.Context.Logger.Error(
							$"[MES IN-STA] [ERROR] write plc code scan result failed by plc connection error! {ctx.Result.Message}");
						Thread.Sleep(5000);
						return true;
					});
				}

				continue;                                                          // 入站流程完成，跳过后续逻辑进入下一周期
			}

			// ==================== 过站流程 ====================
			// PLC数据上报请求=1且响应=0时开始出站：组装数据 → MES出站(MSG2) → 写PLC上报响应

			if (Plc.Read is { 工位1数据上报请求: 1, 工位1数据上报响应: 0 })          // PLC请求数据上报
			{
				Logger.Info($"[MES OUT-STA] [TRIGGER] PLC数据上报请求=1, 上报结果={Plc.Read.工位1数据上报结果}, SN='{Context.ScanSnCode}'");
				var uploadResultCode = Plc.Read.工位1数据上报结果;                  // 读取PLC上报的生产结果（1=OK, 2=NG）
#if !ASM15_1
				if (uploadResultCode == 0)                                           // 防止PLC未配置此信号时默认为OK
				{
					uploadResultCode = 1;
					Logger.Info("plc need to add 工位数据上报结果 point");
				}
#endif
				Context.ErrorMessage = null;
				Context.WorkStep = WorkStep.OUT_STATION;                             // 设置工作步骤为出站
				Context.ProductionState = ProductionState.NA;
				if (string.IsNullOrEmpty(Context.ScanSnCode))                       // SN码为空说明未经过入站流程
				{
					Context.ErrorMessage = "out-station failed, sn code is null!";
					Logger.Error("[MES OUT-STA] [ERROR] plc call out-station, but sn code is null!");
					Plc.Write.工位1数据上报响应 = 2;                                // 响应NG
					uploadResultCode = 2;
					goto SendOutStationResult;
				}

				if (Context.MesEnabled == false)                                     // MES关闭时跳过出站上报
				{
					Logger.Info("[MES OUT-STA] [OK:Skip] SN='{sn}'", Context.ScanSnCode);
					Plc.Write.工位1数据上报响应 = 2;
					uploadResultCode = 2;
					goto SendOutStationResult;
				}

				DataBuilder.Clear();                                                 // 清空数据拼接器，准备出站数据
#if ASM15_1
				for (var i = 0; i < ScrewCount; i++)                               // ASM15_1: 拼接每颗螺丝的扭矩和圈数数据
				{
					var screwNo = i + 1;
					var screwLimit = AppConfig.ScrewLimitConfigs?.FirstOrDefault(t => t.ScrewNo == screwNo);
					var torqueLowLimit = screwLimit?.TorqueLowLimit ?? 0;
					var torqueUpperLimit = screwLimit?.TorqueUpperLimit ?? 0;
					var turnsLowLimit = screwLimit?.TurnsLowLimit ?? 0;
					var turnsUpperLimit = screwLimit?.TurnsUpperLimit ?? 0;
					DataBuilder.Append(
						$"\"[VR]SCREW{screwNo}(KGF-CM)={ScrewMaxTorque[i]:F2};{torqueLowLimit};{torqueUpperLimit}\"");
					DataBuilder.Append(
						$"\"[VR]TURN{screwNo}(Lap)={ScrewTurns[i]:F2};{turnsLowLimit};{turnsUpperLimit}\"");
				}
#elif ASM12
				var uuid = Guid.NewGuid().ToString().ToUpper();                    // ASM12: 生成UUID用于图片上传关联
				DataBuilder.Append($"[VR]UUID='{uuid}'\"");
#endif
#if !MFG15
				if (uploadResultCode == 1)                                           // 生产结果OK时上报MES
				{
					var msg2 =
						$"{AppConfig.StationName},{Context.ScanSnCode},2,{Core.WorkerNo},{AppConfig.Line},,OK,,,{DataBuilder}";
					Logger.Info($"[MES OUT-STA] [DOING] RESULT={Plc.Read.工位1数据上报结果} MES << '{msg2}'");
					var respMsg2Result = Mes.SendAndReadString(msg2);                // 发送MSG2出站请求
					if (respMsg2Result.IsError() || respMsg2Result.Value!.StartsWith("OK") is false)
					{
						Context.ErrorMessage = respMsg2Result.IsError()
							? "out-station failed, mes connection error!"
							: $"out-station failed, mes return error '{respMsg2Result.Value}'";
						Logger.Error(respMsg2Result.IsError()
							? $"[MES OUT-STA] [ERROR] {respMsg2Result.Message}"
							: $"[MES OUT-STA] [ERROR] RESULT={Plc.Read.工位1数据上报结果} MES >> '{respMsg2Result.Value}'");
						Plc.Write.工位1数据上报响应 = 2;
						goto SendOutStationResult;
					}

					Logger.Info($"[MES OUT-STA] [OK] RESULT={Plc.Read.工位1数据上报结果} MES >> '{respMsg2Result.Value}'");
				}
				else                                                               // 生产结果NG时上报MES
				{
#if !ASM15_1
					var msg2 =
						$"{AppConfig.StationName},{Context.ScanSnCode},2,{Core.WorkerNo},{AppConfig.Line},,FAIL,,,{DataBuilder}"; // NG时FAIL标记
#endif

#if ASM15_1
					var failCode = "";                                               // ASM15_1: 读取螺丝枪故障码
					var alarmResult = Screw.ReadInt16("60638");                      // 读取螺丝枪报警寄存器
					Logger.Info($"[SCREW ALARM] 60638 raw value = {(alarmResult.IsSuccess ? alarmResult.Content.ToString() : $"read failed: {alarmResult.Message}")}");
					if (alarmResult.IsSuccess)
					{
						failCode = alarmResult.Content switch                        // 映射故障码到MES编码
						{
							1 => "L043",                                             // 螺丝浮高
							2 => "L044",                                             // 螺丝滑牙
							_ => "L043"
						};
						if (failCode != "")
							Logger.Info($"[SCREW ALARM] 60638={alarmResult.Content} -> {failCode}");
					}
					else
						Logger.Error($"[SCREW ALARM] read 60638 failed! {alarmResult.Message}");

					var msg2 =
						$"{AppConfig.StationName},{Context.ScanSnCode},2,{Core.WorkerNo},{AppConfig.Line},,FAIL,1,{failCode},,"; // 携带故障码
					Logger.Info($"[MES OUT-STA] [DOING] RESULT={Plc.Read.工位1数据上报结果} MES << '{msg2}'");
					var respMsg2Result = Mes.SendAndReadString(msg2);
					if (respMsg2Result.IsError() || respMsg2Result.Value!.StartsWith("OK") is false)
					{
						Context.ErrorMessage = respMsg2Result.IsError()
							? "out-station failed, mes connection error!"
							: $"out-station failed, mes return error '{respMsg2Result.Value}'";
						Logger.Error(respMsg2Result.IsError()
							? $"[MES OUT-STA] [ERROR] {respMsg2Result.Message}"
							: $"[MES OUT-STA] [ERROR] RESULT={Plc.Read.工位1数据上报结果} MES >> '{respMsg2Result.Value}'");
						Plc.Write.工位1数据上报响应 = 2;
						goto SendOutStationResult;
					}
#else
					Logger.Info($"[MES OUT-STA] [SKIP] RESULT={Plc.Read.工位1数据上报结果} FAIL不上报MES");
#endif
				}
				
#endif

#if ASM12
				// ASM12: 出站后查询MES获取产品信息用于图片上传
				if (uploadResultCode == 1)											//仅ok产品才图片上传
				{
					var mes7 = $"SMD_QUERY,{Context.ScanSnCode},7,,SMD,,OK,GET_PN=??? ZEBRA_DTG=??? SN_NOW_GROUP=???";
					Logger.Info($"[MES OUT-STA] [DOING] MES7 << '{mes7}'");
					var mesMsg7Result = Mes.SendAndReadString(mes7); // 查询产品PN、DTG、分组信息
					if (mesMsg7Result.IsError() || mesMsg7Result.Value?.StartsWith("OK") == false)
					{

						Logger.Error(mesMsg7Result.IsError()
							? $"[MES OUT-STA] [ERROR] {mesMsg7Result.Message}"
							: $"[MES OUT-STA] [ERROR] MES >> '{mesMsg7Result.Value}'");
						Plc.Write.工位1数据上报响应 = 2;
						goto SendOutStationResult;
					}

					Logger.Info($"[MES OUT-STA] [OK] MES7 >> '{mesMsg7Result.Value}'");
					var topic = GenerateTopic(mesMsg7Result.Value!, AppConfig.StationName); // 根据MES返回生成上传主题
					Logger.Info($"TOPIC = {topic}");
					try
					{
						Debug.Assert(string.IsNullOrEmpty(Context.ImagePathRoot) == false);
						var images = Directory.Exists(Context.ImagePathRoot)
							? // 获取图像目录下非NG图片
							Directory.GetFiles(Context.ImagePathRoot).Where(t => t.Contains("_NG") == false).ToArray()
							: [];
						CreateImagePackageZip(AppConfig.ImageZipOutputPath, images, Context.ScanSnCode, topic,
							uuid, // 打包图片为ZIP
							t => Logger.Debug(t));
					}
					catch (Exception e)
					{
						Logger.Error(e); // 图片打包失败不影响生产流程
					}
				}
#endif
				Plc.Write.工位1数据上报响应 = 1;                                  // MES出站成功，响应=1
				SendOutStationResult:
				uploadResultCode = Plc.Read.工位1数据上报结果;
				if (uploadResultCode != 1)                                           // 生产结果NG
				{
					Plc.Write.工位1数据上报响应 = 2;
					Context.ProductionState = ProductionState.NG;
					ReadNgItems();                                                   // 从PLC读取NG原因列表
					Context.ShowNgDetailDialog();                                    // 弹窗显示NG详情
				}
				else Context.ProductionState = ProductionState.OK;                   // 生产结果OK

#if !ASM15_1
				var productionResult = Context.ProductionState == ProductionState.OK ? "PASS" : "FAIL";
#else
				var productionResult = "PASS";
#endif
				// EAP S6F11/6002 产品过站上报
				var eapData = new Dictionary<string, string>
				{
					[EapReportIds.EquipmentStatus] = StatusProvider.GetCurrentStatus().ToString(),
					[EapReportIds.Input] = Plc.Read.已生产数量.ToString(),
					[EapReportIds.Output] = Plc.Read.已生产数量.ToString(),
					[EapReportIds.CT] = Plc.Read.CT.ToString(),
					[EapReportIds.WorkOrder] = Core.WorkOrderNo ?? "",
					[EapReportIds.ModelName] = Context.ModelName,
					[EapReportIds.ProductSN] = Context.ScanSnCode,
					[EapReportIds.LaneNo] = AppConfig.Line ?? "",
					[EapReportIds.Yield] = Plc.Read.良率.ToString("F2"),
					[EapReportIds.ProductionResult] =  productionResult,
				};
				EapClient.UpdateReportValues(eapData);
					_ = EapClient.TrySendProductFinishReportAsync(eapData);

				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1数据上报响应), this, static ctx => // 写入PLC上报响应（带重试）
				{
					ctx.Context.Logger.Error(
						$"[MES OUT-STA] [ERROR] write plc upload response failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});

				if (CommonAppConfig.IsDevTestMode)                                   // 调试模式：手动复位上报请求信号
				{
					Plc.Write.工位1数据上报请求 = 0;
					Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报请求));
				}

				Context.WorkStep = WorkStep.FREE;                                    // 重置工作步骤为空闲
				Context.DayProductionId = 0;                                         // 重置生产序号
			}

			// ==================== 信号复位 ====================
			// PLC已复位触发信号但PC响应未清零时，复位PC响应信号，完成握手闭环
			if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)          // 扫码信号：PLC已复位，PC未复位
			{
				Logger.Debug($"[SIGNAL RESET] 扫码枪1触发={Plc.Read.扫码枪1触发}, 扫码枪1触发结果={Plc.Read.扫码枪1触发结果} => 复位PC响应");
				Plc.Write.扫码枪1触发结果 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.扫码枪1触发结果)).Unwarp("clear code scanner signal failed!");
				continue;
			}

			if (Plc.Read.工位1数据上报请求 is 0 && Plc.Read.工位1数据上报响应 is not 0) // 上报信号：PLC已复位，PC未复位
			{
				Logger.Debug($"[SIGNAL RESET] 数据上报请求={Plc.Read.工位1数据上报请求}, 数据上报响应={Plc.Read.工位1数据上报响应} => 复位PC响应");
				Plc.Write.工位1数据上报响应 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报响应)).Unwarp("clear work left upload result!");
				continue;
			}

			// ==================== 工站本地逻辑 ====================

#if ASM15_1
			
#endif

#if MFG15
				// MFG15: 打印机触发流程
				if (Plc.Read.打印机1触发 is 1 && Plc.Read.打印机1触发结果 is 0)      // PLC触发打印
				{
					if (string.IsNullOrEmpty(Context.ScanSnCode))                   // SN码为空无法打印
					{
						Logger.Error("[CODE-PRINT] [ERROR] SN code is null or empty!");
						Plc.Write.打印机1触发结果 = 2;
						goto SendResult;
					}



					Logger.Info($"[CODE-PRINT] [DOING] SN='{Context.ScanSnCode}'");
					Core.PrinterLock.Wait();                                           // 获取打印机锁（防止并发打印）
					try
					{
						if (Plc.Read.工位1允许生产 != 1)                               // 未允许生产时不打印
						{
							Logger.Error($"[CODE-PRINT] [ERROR] SN='{Context.ScanSnCode}' is not allow production!");
							Plc.Write.打印机1触发结果 = 2;
							goto SendResult;
						}

						var error = CodePrintService.SendContentToMesPrintProgram(Context.ScanSnCode); // 发送打印内容到打印程序
						if (error is not null)
						{
							Logger.Error($"[CODE-PRINT] [ERROR] SN='{Context.ScanSnCode}' {error}");
							Plc.Write.打印机1触发结果 = 2;
							goto SendResult;
						}

						Thread.Sleep(7000);                                            // 等待打印完成
					}
					finally
					{
						Core.PrinterLock.Release();                                    // 释放打印机锁
					}

					Logger.Info($"[CODE-PRINT] [OK] SN='{Context.ScanSnCode}'");
					Plc.Write.打印机1触发结果 = 1;                                    // 打印成功
					SendResult:
					Plc.Write.TryWritePoint(nameof(PlcStruct.打印机1触发结果), this, static ctx => // 写入打印结果（带重试）
					{
						ctx.Context.Logger.Error(
							$"[CODE-PRINT] [ERROR] write plc code print result failed by plc connection error! {ctx.Result.Message}");
						Thread.Sleep(5000);
						return true;
					});
				}

				if (Plc.Read.打印机1触发 is 0 && Plc.Read.打印机1触发结果 is not 0)  // PLC复位后清零响应
				{
					Plc.Write.打印机1触发结果 = 0;
					Plc.Write.WritePoint(nameof(PlcStruct.打印机1触发结果));
				}
#endif

#if ASM15_1
			// ASM15_1: 第二次扫码（扫码SN，触发=1），用于关联KeyPart和SN
			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 })
			{
				Logger.Info($"[SCAN-CODE-1] [DOING] ...");
#if SUB1
				var scanCodeResult = AppConfig.UseTcpScanner ? DoScanCodeTcp(CodeScanner) : DoScanCode(CodeScanner);
#else
				var scanCodeResult = DoScanCode(CodeScanner);
#endif
				if (scanCodeResult.IsError())
				{
					Logger.Error($"[SCAN-CODE-1] [ERROR] {scanCodeResult.Message}");
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
				}

				var scanCode = Context.ScanSnCode = scanCodeResult.Value!;
				var codeMinLength = AppConfig.SnCodeMinLength;
				if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength)
				{
					Logger.Error(
						$"[SCAN CODE-1] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
					Context.ErrorMessage = "code length check failed!";
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}

				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [OK] CONTENT='{scanCode}'");
				Plc.Write.扫码枪1触发结果 = CodeOfOK;
				SendResult:
				Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发结果), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc code scan signal failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
			}

			// ASM15_1: 螺丝拧紧完成信号变化时，从螺丝枪读取扭矩和圈数数据
			while (Plc.Read.工位1螺丝拧紧完成信号 != 螺丝拧紧完成信号 && Plc.Read.工位1螺丝拧紧完成信号 <= ScrewCount)
			{
				螺丝拧紧完成信号 = Plc.Read.工位1螺丝拧紧完成信号;                // 更新本地完成序号
				if (螺丝拧紧完成信号 == 0)
					break;
				var readResult1 = Screw.ReadInt16("60653");                        // 读取螺丝圈数寄存器
				var readResult2 = Screw.ReadInt16("60650");                        // 读取螺丝最大扭矩寄存器
				if (readResult1.IsSuccess == false || readResult2.IsSuccess == false)
				{
					Logger.Error(
						$"[SCREW COMPLETE] at [{螺丝拧紧完成信号}], but read data failed! {readResult1.Message ?? readResult2.Message}");
					break;
				}

				var turns = readResult1.Content / 100.0;                           // 圈数除以100得到实际值
				var maxTorque = readResult2.Content / 100.0;                       // 扭矩除以100得到实际值
				Logger.Info($"[SCREW COMPLETE] AT [{螺丝拧紧完成信号}] Turns:{turns}  MaxTorque:{maxTorque}");
				ScrewTurns[螺丝拧紧完成信号 - 1] = turns;                          // 存储到圈数数组
				ScrewMaxTorque[螺丝拧紧完成信号 - 1] = maxTorque;                  // 存储到扭矩数组
				if (螺丝拧紧完成信号 == ScrewCount)
				{
					Logger.Info($"[SCREW ALL DONE] All {ScrewCount} screws completed, waiting for PLC data upload request...");
					Logger.Info($"[SCREW ALL DONE] Current PLC state: 数据上报请求={Plc.Read.工位1数据上报请求}, 数据上报响应={Plc.Read.工位1数据上报响应}");
				}
				var screwIndex = 螺丝拧紧完成信号 - 1;
				if (screwIndex >= 0 && screwIndex < Context.ScrewInstallDataList.Count)
				{
					var idx = screwIndex;
					var no = 螺丝拧紧完成信号;
					UiUtils.InvokeOnUiThread(() =>                                 // 在UI线程更新螺丝安装数据
					{
						var item = Context.ScrewInstallDataList[idx];
						item.ScrewNo = no;
						item.MaxTorque = maxTorque;
						item.Turns = turns;
						item.CollectedAt = DateTime.Now;
						item.HasValue = true;
					});
				}
				break;                                                             // 每次只处理一颗螺丝
			}
#endif

			// ==================== 料座感应 & 测试扫码 ====================
			if (Plc.Read.工位1料座感应状态 == 0 && 料座感应状态 != 0)               // 料座感应下降沿：关闭NG详情弹窗
			{
				料座感应状态 = Plc.Read.工位1料座感应状态;
				Context.HideNgDetailDialog();                                         // 工件离开时隐藏NG弹窗
			}

			料座感应状态 = Plc.Read.工位1料座感应状态;                               // 更新料座感应状态

			if (Context.TestScanner && Plc.Read.工位1生产状态 != 1)                 // 测试扫码模式：非生产状态时持续扫码
			{
#if SUB1
				var testScanResult = AppConfig.UseTcpScanner ? DoScanCodeTcp(CodeScanner) : DoScanCode(CodeScanner);
#else
				var testScanResult = DoScanCode(CodeScanner);
#endif
				if (testScanResult.IsError())
				{
					Logger.Error($"test scaner error! {testScanResult.Message}");
					Thread.Sleep(5000);                                              // 扫码失败时等待5秒后重试
				}
				else
				{
					Context.ScanSnCode = testScanResult.Value!;                      // 更新SN码到上下文
				}
			}
		}

		return Task.CompletedTask;
	}

	/// <summary>
	/// 主循环异常处理：记录致命日志，等待5秒后返回true继续重试。
	/// 防止因偶发异常（如网络抖动）导致服务停止。
	/// </summary>
	protected override Task<bool> OnMainException(Exception exception)
	{
		Logger.Fatal(exception, "work position is error, will retry.");
		Thread.Sleep(5000);                                              // 异常后等待5秒再重试
		return TaskUtils.ConstValues.TaskTrue;                           // 返回true表示继续运行
	}


	/// <summary>
	/// 从PLC读取工位1的NG原因布尔数组（200位），解析后在UI线程更新NG详情列表。
	/// 读取后立即清零PLC中的NG原因区域，防止重复读取。
	/// </summary>
	public void ReadNgItems()
	{
		var result = Plc.Plc.ReadBool(PlcStructInfo.工位1NG原因.Source!.ToString(), 200); // 读取200个布尔NG原因位
		if (result.IsSuccess == false)
		{
			Logger.Error("read ng items failed!");
			return;
		}

		Plc.Plc.Write(PlcStructInfo.工位1NG原因.Source!.ToString(), EmptyBoolX200);  // 清零PLC NG原因区域

		var items = result.Content!;
		UiUtils.InvokeOnUiThread(() =>                                     // 在UI线程更新NG列表
		{
			Context.NgItems.Clear();
			for (var i = 0; i < items.Length; i++)
			{
				var isOn = items[i];
				if (isOn == false) continue;                               // 跳过未触发的NG位
				var define = AppConfig.NgDefines.FirstOrDefault(t => t.Id == i + 1); // 按ID查找NG定义
				if (define is null)
				{
					Logger.Warn($"ng define [{i + 1}] not found!");
					continue;
				}

				Context.NgItems.Add(define);                                // 添加到NG详情列表
			}
		});

		NgService.PushNg(new NgRecord                                   // 异步写入NG记录到数据库
		{
			StationId = 1,
			StationName = AppConfig.StationName,
			SnCode = Context.ScanSnCode,
			KeyPartCode = Context.ScanKeyPartCode,
			ModelName = Context.ModelName,
			ErrorMessage = Context.ErrorMessage,
			NgItems = JsonSerializer.Serialize(Context.NgItems.Select(t => new { t.Id, t.Sender, t.Name, t.Reason }), new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }),
			CreateTime = DateTime.Now
		});
	}
}