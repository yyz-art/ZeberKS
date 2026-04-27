using System;
using System.Text;
using Avalonia.Media;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.Mvvm;
using ZC.Net.Sockets;
using ZitApp.BinStructs;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class WorkLeftService : WorkServiceBase
{
    private readonly byte[] _buffer = new byte[1024];
    private int _flowStepIndex;
    private static readonly string[] FlowSteps =
    [
       "等待扫码",
       "扫码中",
       "扫码完成",
       "MSG7查工单机种",
       "配方检查/切换",
       "MSG1入站",
       "打印处理",
       "允许生产",
       "完成"
    ];

    public partial string FlowSn { get; set; } = "";
    public partial string FlowModel { get; set; } = "";
    public partial string FlowCurrentStep { get; set; } = FlowSteps[0];
    public partial string FlowLastError { get; set; } = "无";
    public partial ObservableList<WorkFlowStepItem> FlowStepItems { get; set; } = CreateFlowStepItems();

    private void ResetFlow()
    {
       FlowSn = "";
       FlowModel = "";
       FlowLastError = "无";
       SetFlowStep(1);
    }

    private void SetFlowStep(int stepIndex)
    {
       _flowStepIndex = Math.Clamp(stepIndex, 0, FlowSteps.Length - 1);
       FlowCurrentStep = FlowSteps[_flowStepIndex];
       UpdateFlowStepItems(false);
    }

    private void SetFlowError(int stepIndex, string error)
    {
       _flowStepIndex = Math.Clamp(stepIndex, 0, FlowSteps.Length - 1);
       FlowCurrentStep = FlowSteps[_flowStepIndex];
       FlowLastError = string.IsNullOrWhiteSpace(error) ? "未知错误" : error;
       UpdateFlowStepItems(true);
    }

    private static ObservableList<WorkFlowStepItem> CreateFlowStepItems()
    {
       var items = new ObservableList<WorkFlowStepItem>();
       for (var i = 0; i < FlowSteps.Length; i++)
       {
          items.Add(new WorkFlowStepItem
          {
             Name = FlowSteps[i],
             Background = i == 0 ? Brush.Parse("#1e88e5") : Brush.Parse("#555555")
          });
       }

       return items;
    }

    private void UpdateFlowStepItems(bool isError)
    {
       for (var i = 0; i < FlowStepItems.Count && i < FlowSteps.Length; i++)
       {
          var item = FlowStepItems[i];
          item.Background = i < _flowStepIndex
             ? Brush.Parse("#2e7d32")
             : i == _flowStepIndex
                ? Brush.Parse(isError ? "#c62828" : "#1e88e5")
                : Brush.Parse("#555555");
       }
    }
    public override string ServiceName => "WorkLeft";
    public required PlcService Plc { get; init; }
    public required CoreService Core { get; init; }
    public required MesService Mes { get; init; }
    public required AppConfig AppConfig { get; init; }
    public IDataSocket CodeScanner { get; set; } = null!;
    public partial string 机种型号 { get; set; } = ""; 
    public partial string 扫码 { get; set; } = "";

    public override Task Initialize(object? ctx = null, object? args = null)
    {
       InitCodeScanner();
       AppConfig.PropertyChanged += (sender, e) =>
       {
           if (e.PropertyName == nameof(AppConfig.Scanner1ComPort) || 
               e.PropertyName == nameof(AppConfig.Scanner1BaudRate))
           {
               Logger.Warn("检测到扫码枪1配置发生改变，正在重新初始化串口...");
               InitCodeScanner(); 
           }
       };

       return base.Initialize(ctx, args);
    }
    
    private void InitCodeScanner()
    {
        try { CodeScanner?.Close(); } catch { }
        CodeScanner = new SerialPortSocket(AppConfig.Scanner1ComPort, AppConfig.Scanner1BaudRate);
        Logger.Info($"扫码枪1实例已绑定至: {AppConfig.Scanner1ComPort} [{AppConfig.Scanner1BaudRate}]");
    }

    protected override Task Main(CancellationToken ctk)
    {
       Span<char> charBuffer = stackalloc char[1024];
       while (ctk.IsCancellationRequested == false)
       {
          Plc.WaitNextCycle();
          
          // 扫码信号清空
          if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
          {
             Plc.Write.扫码枪1触发结果 = 0;
             Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("Clear left scanner result failed!");
             continue;
          }

          // 打印信号清空
          if (Plc.Read.打印机1触发 == 0 && Plc.Read.打印机1触发结果 != 0)
          {
             Plc.Write.打印机1触发结果 = 0;
             Plc.Write.WritePoint(PlcStructInfo.打印机1触发结果).Unwarp("Clear printer 1 result failed!");
             continue;
          }
          
          // 入站扫码及 MES 交互主流程
         
          if (Plc.Read.扫码枪1触发 == 1 && Plc.Read.扫码枪1触发结果 == 0)
          {
             var printer1TriggerLatched = Plc.Read.打印机1触发 == 1;
             ResetFlow();
             try 
             {
                 //前置动作：触发扫码枪获取条码 
                 if (CodeScanner is not { IsOpen: true })
                 {
                    var openResult = CodeScanner?.Open() ?? Result.Err("CodeScanner instance is null");
                    if (openResult.IsError()) { Plc.Write.工位1允许生产 = 2; goto SendCodeNG; }
                 }

                 CodeScanner!.ReadToDiscard();
                 
                 var writeResult = CodeScanner.Write(StartScanCommandBytes);
                 if (writeResult.IsError()) { Plc.Write.工位1允许生产 = 2; goto SendCodeNG; }

                 var readResult = CodeScanner.ReadContinuous(_buffer, 2000, 200);
                 if (readResult.IsError()) { Plc.Write.工位1允许生产 = 2; goto SendCodeNG; }
                 
                 var readLength = readResult.Value;
                 if (false == _buffer.StartsWith(StartScanResponseBytes)) { Plc.Write.工位1允许生产 = 2; goto SendCodeNG; }

                 var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length, readLength - StartScanResponseBytes.Length);
                 if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength)) { Plc.Write.工位1允许生产 = 2; goto SendCodeNG; }

                 扫码 = charBuffer.Slice(0, codeLength).ToString().Trim();
                 if (string.IsNullOrWhiteSpace(扫码) || 扫码.Length < 20)
                 {
                    Logger.Error("扫码枪1未扫到有效二维码或二维码长度不足20位，当前码='{code}'，长度={length}，工位1不允许生产。", 扫码, 扫码.Length);
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }

                 FlowSn = 扫码;
                 SetFlowStep(2);
                 Logger.Info("Scanned code is '{code}'", 扫码);

                 if (Core.MesSkipEnabled)
                 {
                    Logger.Warn("【MES跳过】工位1扫码完成，跳过 MSG7/配方切换/MSG1，直接允许生产。SN={sn}", 扫码);
                    Plc.Write.工位1允许生产 = 1;
                    SetFlowStep(7);
                    goto SendCodeOK;
                 }

                
                 // 【第一步】获取工单号和机种 (MSG7)
                 
                 SetFlowStep(3);
                 Logger.Info("【第一步】请求查工单和机种 (MSG7) -> 开始");
                 var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码); 
                 
                 if (mesMsg7Result.IsError())
                 {
                    Logger.Error("第一步失败: 获取工单通讯异常");
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }

                 string rawAscii = mesMsg7Result.Value;
                 string? 工单号 = null;
                 string? 机种名 = null;

                 if (!string.IsNullOrEmpty(rawAscii))
                 {
                    string[] parts = rawAscii.Split(new[] { ',', ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var part in parts)
                    {
                       string cleanPart = part.Trim().ToUpper();
                       if (cleanPart.StartsWith("MO_NUMBER=")) 工单号 = part.Substring(part.IndexOf('=') + 1).Trim(); 
                       else if (cleanPart.StartsWith("MODEL_NAME=")) 机种名 = part.Substring(part.IndexOf('=') + 1).Trim();
                    }
                 }

                 if (string.IsNullOrEmpty(工单号) || string.IsNullOrEmpty(机种名))
                 {
                    Logger.Error("第一步失败: MES回传的报文中未找到 MO_NUMBER 或 MODEL_NAME");
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }
                 
                 Logger.Info("【第一步】通过！成功获取机种: " + 机种名);
                 Core.工单号 = 工单号;
                 this.机种型号 = 机种名;
                 FlowModel = 机种名;

                 SetFlowStep(4);
                 Logger.Info("【配方切换】工位1开始根据 MES MODEL_NAME 检查当前配方。");
                 var recipePrepareState = Core.PrepareRecipeByMesModelNameAsync(机种名).GetAwaiter().GetResult();
                 if (recipePrepareState == MesRecipePrepareState.RecipeNotFound)
                 {
                    Logger.Error("【配方切换】工位1未找到 MODEL_NAME={modelName} 对应配方，写入 工位1允许生产=3 并退出流程。", 机种名);
                    Plc.Write.工位1允许生产 = 3;
                    goto SendCodeRecipeHold;
                 }

                 if (recipePrepareState == MesRecipePrepareState.PlcResponseTimeout)
                 {
                    Logger.Error("【配方切换】工位1等待 PLC读取配方ID切换成功响应(22414)=1 超过15秒，写入 工位1允许生产=3 并退出流程。");
                    Plc.Write.工位1允许生产 = 3;
                    goto SendCodeRecipeHold;
                 }

                 if (recipePrepareState == MesRecipePrepareState.UserCanceled)
                 {
                    Logger.Warn("【配方切换】工位1用户取消配方切换，写入 工位1允许生产=3 并退出流程。");
                    Plc.Write.工位1允许生产 = 3;
                    goto SendCodeRecipeHold;
                 }

                 if (recipePrepareState == MesRecipePrepareState.Failed)
                 {
                    Logger.Error("【配方切换】工位1配方切换失败，写入 工位1允许生产=2 并退出流程。");
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }

                 Logger.Info("【配方切换】工位1配方检查/切换完成，继续后续 MES 入站流程。");

                 // 本地校验配方和物料
                /* if (false == Core.CheckRecipe(机种名))
                 {
                    Logger.Warn("校验失败: 机种配方不匹配!");
                    Core.RequestStartSwitchRecipe(机种名); 
                    Plc.Write.工位1允许生产 = 3; // 提示状态，非直接通过
                    goto SendCodeOK; 
                 }
                 if (false == Core.CheckRecipeMono(机种名))
                 {
                    Logger.Warn("校验失败: 配方物料不匹配!");
                    Plc.Write.工位1允许生产 = 4; // 提示状态，非直接通过
                    goto SendCodeOK;
                 }*/

                 // ========================================================
                 // ========================================================
                 // 【第二步】发送申请入站请求 (纯 ASCII 模式)
                 // 说明：第一步完全通过后，才允许向 MES 发送入站申请
                 // ========================================================
                 SetFlowStep(5);
                 Logger.Info("【第二步】申请入站过站 (纯 ASCII 模式) -> 开始");
                 
                 // [修改核心] 改用刚才写好的纯 ASCII 方法
                 var mesMsg1Result = Mes.SendRawAsciiMessage1(Core.工号, 扫码);
                 
                 if (mesMsg1Result.IsError())
                 {
                    Logger.Error("第二步失败: 入站请求通讯异常: " + mesMsg1Result.Message);
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }
                 Logger.Info("【第二步】通过！入站请求已成功发送");

                 // ========================================================
                 // 【第三步】判断 MES 回复，决定是否放行
                 // ========================================================
                 Logger.Info("【第三步】校验 MES 入站许可 -> 开始");
                 
                 string response1Ascii = mesMsg1Result.Value.Trim().ToUpper();
                 
                 if (response1Ascii.StartsWith("OK")) 
                 {
                    Logger.Info("【第三步】通过！收到MES回复OK，准许进站加工！");
                    
                    
                    SetFlowStep(6);
                    var shouldPrint = printer1TriggerLatched || Plc.Read.打印机1触发 == 1;
                    if (shouldPrint)
                    {
                        Logger.Info($"[打印任务] 检测到 打印机1触发==1，准备将条码发送至外挂程序...");
                        try 
                        {
                            var printError = CodePrintService.SendContentToMesPrintProgram(扫码);
                            if (printError != null)
                            {
                                Logger.Warn($"[打印服务警告] 无法将条码发送至外挂程序: {printError}");
                                Plc.Write.打印机1触发结果 = CodeOfNG;
                                Plc.Write.WritePoint(PlcStructInfo.打印机1触发结果).Unwarp("write printer 1 result NG failed!");
                            }
                            else
                            {
                                 Logger.Info($"[打印服务成功] 已成功将条码 {扫码} 填入 WORK_STATION_INPUT 程序！");
                                 Plc.Write.打印机1触发结果 = CodeOfOK;
                                 Plc.Write.WritePoint(PlcStructInfo.打印机1触发结果).Unwarp("write printer 1 result OK failed!");
                            }
                        }
                        catch (Exception printEx)
                        {
                            // 即使打印代码抛出致命异常，也只打印错误日志，绝不拦截流水线
                            Logger.Error($"[打印服务崩溃] 外挂打印调用异常，但产品依然放行！错误: {printEx.Message}");
                            Plc.Write.打印机1触发结果 = CodeOfNG;
                            Plc.Write.WritePoint(PlcStructInfo.打印机1触发结果).Unwarp("write printer 1 result NG failed!");
                        }
                    }
                    else
                    {
                        Logger.Info($"[打印任务] 当前 打印机1触发 为 {Plc.Read.打印机1触发}，且本次扫码未锁存打印触发，跳过打印动作。");
                    }
                    
                    Plc.Write.工位1允许生产 = 1;
                    SetFlowStep(7);
                 }
                 else
                 {
                    Logger.Error($"第三步失败: MES 拒绝入站！原始回复内容为: {response1Ascii}");
                    Plc.Write.工位1允许生产 = 2;
                    goto SendCodeNG;
                 }
                
             }
             catch (Exception ex)
             {
                 Logger.Error(ex, "入站扫码工作站发生致命异常: {msg}", ex.Message);
                 Plc.Write.工位1允许生产 = 2;
                 goto SendCodeNG;
             }

             // --- PLC 结果写入统一出口 ---
             SendCodeOK:
             Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce OK failed!");
             Plc.Write.扫码枪1触发结果 = CodeOfOK;
             Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
             SetFlowStep(8);
             continue;

             SendCodeRecipeHold:
             Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce recipe hold failed!");
             Plc.Write.扫码枪1触发结果 = CodeOfRecipeHold;
             Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner recipe hold result failed!");
             continue;
             
             SendCodeNG:
             Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce NG failed!");
             Plc.Write.扫码枪1触发结果 = CodeOfNG;
             Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
             if (printer1TriggerLatched || Plc.Read.打印机1触发 == 1)
             {
                Plc.Write.打印机1触发结果 = CodeOfNG;
                Plc.Write.WritePoint(PlcStructInfo.打印机1触发结果).Unwarp("write printer 1 result NG failed!");
             }

             continue;
          }
       }

       return Task.CompletedTask;
    }
}
