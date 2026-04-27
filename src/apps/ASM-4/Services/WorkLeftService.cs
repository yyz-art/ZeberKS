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
	private short _pendingUploadResponse;
	private int _flowStepIndex;
	private static readonly string[] FlowSteps =
	[
		"等待扫码",
		"扫码中",
		"扫码完成",
		"MSG7查工单机种",
		"配方检查/切换",
		"MSG1入站",
		"允许生产",
		"等待过站",
		"MSG2过站",
		"完成"
	];

	public override string ServiceName => "WorkLeft";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public required AppConfig AppConfig { get; init; }
	public IDataSocket CodeScanner { get; set; } = null!;
	public partial string 机种型号 { get; set; } = "";
	public partial string 扫码 { get; set; } = "";
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
			if (isError && i == _flowStepIndex)
			{
				item.Background = Brush.Parse("#c62828");
				item.Foreground = Brushes.White;
			}
			else if (i < _flowStepIndex)
			{
				item.Background = Brush.Parse("#2e7d32");
				item.Foreground = Brushes.White;
			}
			else if (i == _flowStepIndex)
			{
				item.Background = Brush.Parse("#1e88e5");
				item.Foreground = Brushes.White;
			}
			else
			{
				item.Background = Brush.Parse("#555555");
				item.Foreground = Brushes.White;
			}
		}
	}

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
		Logger.Info("扫码枪1实例已绑定至: {port} [{baudRate}]", AppConfig.Scanner1ComPort, AppConfig.Scanner1BaudRate);
	}

	protected override async Task Main(CancellationToken ctk)
	{
		var charBuffer = new char[1024];
		while (ctk.IsCancellationRequested == false)
		{
			try
			{
				Plc.WaitNextCycle();

				if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
				{
					Plc.Write.扫码枪1触发结果 = 0;
					Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("Clear left scanner result failed!");
					continue;
				}

			if (Plc.Read.扫码枪1触发 == 1 && Plc.Read.扫码枪1触发结果 == 0)
			{
				ResetFlow();
				扫码 = "";
				机种型号 = "";
				try
				{
					if (CodeScanner is not { IsOpen: true })
					{
						var openResult = CodeScanner?.Open() ?? Result.Err("CodeScanner instance is null");
						if (openResult.IsError())
						{
							Logger.Error("扫码枪1打开失败: {msg}", openResult.Message);
							Plc.Write.工位1允许生产 = 2;
							goto SendCodeNG;
						}
					}

					CodeScanner!.ReadToDiscard();

					var writeResult = CodeScanner!.Write(StartScanCommandBytes);
					if (writeResult.IsError())
					{
						Logger.Error("扫码枪1触发命令发送失败: {msg}", writeResult.Message);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					var readResult = CodeScanner!.ReadContinuous(_buffer, 2000, 200);
					if (readResult.IsError())
					{
						Logger.Error("扫码枪1读取超时或失败: {msg}", readResult.Message);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					var readLength = readResult.Value;
					if (false == _buffer.StartsWith(StartScanResponseBytes))
					{
						var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
						Logger.Error("扫码枪1响应格式错误: {hex}", responseHex);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length, readLength - StartScanResponseBytes.Length);
					if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
					{
						var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
						Logger.Error("扫码枪1条码解析失败: {hex}", responseHex);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					扫码 = new string(charBuffer, 0, codeLength).Trim();
					if (string.IsNullOrWhiteSpace(扫码) || 扫码.Length < 20)
					{
						Logger.Error("扫码枪1未扫到有效二维码或二维码长度不足20位，当前码='{code}'，长度={length}，工位1不允许生产。", 扫码, 扫码.Length);
						Plc.Write.工位1允许生产 = 2;
						SetFlowError(1, "扫码失败或长度不足20位");
						goto SendCodeNG;
					}

					FlowSn = 扫码;
					SetFlowStep(2);
					Logger.Info("Scanned code is '{code}'", 扫码);

					if (Core.MesSkipEnabled)
					{
						Logger.Warn("【MES跳过】工位1扫码完成，跳过 MSG7/配方切换/MSG1，直接允许生产。SN={sn}", 扫码);
						Plc.Write.工位1允许生产 = 1;
						SetFlowStep(6);
						goto SendCodeOK;
					}

					SetFlowStep(3);
					Logger.Info("【第一步】请求查工单和机种(MSG7) -> 开始");
					var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码);
					if (mesMsg7Result.IsError())
					{
						Logger.Error("第一步失败: 获取工单通讯异常: {msg}", mesMsg7Result.Message);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					var rawAscii = mesMsg7Result.Value;
					var parseResult = ParseMesModelInfo(rawAscii);
					if (parseResult.WorkOrder is null || parseResult.ModelName is null)
					{
						Logger.Error("第一步失败: MES回传的报文中未找到 MO_NUMBER 或 MODEL_NAME");
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					Core.工单号 = parseResult.WorkOrder;
					机种型号 = parseResult.ModelName;
					FlowModel = 机种型号;
					Logger.Info("【第一步】通过，工单={workOrder}，机种={modelName}", Core.工单号, 机种型号);

					SetFlowStep(4);
					Logger.Info("【配方切换】工位1开始根据 MES MODEL_NAME 检查当前配方。");
					var recipePrepareState = await Core.PrepareRecipeByMesModelNameAsync(机种型号);
					if (recipePrepareState == MesRecipePrepareState.RecipeNotFound)
					{
						Logger.Error("【配方切换】工位1未找到 MODEL_NAME={modelName} 对应配方，写入 工位1允许生产=3 并退出流程。", 机种型号);
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

					Logger.Info("【第二步】申请入站过站(MSG1) -> 开始");
					SetFlowStep(5);
					var mesMsg1Result = Mes.SendRawAsciiMessage1(Core.工号, 扫码);
					if (mesMsg1Result.IsError())
					{
						Logger.Error("第二步失败: 入站请求通讯异常: {msg}", mesMsg1Result.Message);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					var response1Ascii = mesMsg1Result.Value!.Trim().ToUpperInvariant();
					if (response1Ascii.StartsWith("OK") == false)
					{
						Logger.Error("第三步失败: MES 拒绝入站，原始回复内容为: {response}", response1Ascii);
						Plc.Write.工位1允许生产 = 2;
						goto SendCodeNG;
					}

					Logger.Info("【第三步】收到 MES 回复 OK，准许进站加工。");
					Plc.Write.工位1允许生产 = 1;
					SetFlowStep(6);
					goto SendCodeOK;
				}
				catch (Exception ex)
				{
					Logger.Error(ex, "入站扫码工作站发生致命异常: {msg}", ex.Message);
					Plc.Write.工位1允许生产 = 2;
					goto SendCodeNG;
				}

				SendCodeOK:
				Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce OK failed!");
				Plc.Write.扫码枪1触发结果 = CodeOfOK;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
				SetFlowStep(7);
				continue;

				SendCodeRecipeHold:
				扫码 = "";
				SetFlowError(_flowStepIndex, FlowLastError == "无" ? "配方检查失败" : FlowLastError);
				Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce recipe hold failed!");
				Plc.Write.扫码枪1触发结果 = CodeOfRecipeHold;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner recipe hold result failed!");
				continue;

				SendCodeNG:
				扫码 = "";
				SetFlowError(_flowStepIndex, FlowLastError == "无" ? "流程失败" : FlowLastError);
				Plc.Write.WritePoint(PlcStructInfo.工位1允许生产).Unwarp("write left allow produce NG failed!");
				Plc.Write.扫码枪1触发结果 = CodeOfNG;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
				continue;
			}

			if (_pendingUploadResponse != 0)
			{
				if (TryWritePendingUploadResponse())
					continue;
			}

			if (Plc.Read.工位1数据上报请求 is 0 && Plc.Read.工位1数据上报响应 is not 0)
			{
				Plc.Write.工位1数据上报响应 = 0;
				Plc.Write.WritePoint(PlcStructInfo.工位1数据上报响应).Unwarp("clear work left upload result!");
				continue;
			}

			if (Plc.Read.工位1数据上报请求 == 1 && Plc.Read.工位1数据上报响应 == 0)
			{
				SetFlowStep(8);
				try
				{
					if (string.IsNullOrEmpty(扫码))
					{
						Logger.Error("plc upload result must scan code, current code is null!");
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					if (Core.MesSkipEnabled)
					{
						Logger.Warn("【MES跳过】收到 工位1数据上报请求(22015)=1，跳过 MSG2，直接响应 OK。SN={sn}", 扫码);
						_pendingUploadResponse = 1;
						goto WritePendingResponse;
					}

					Logger.Info("【过站】收到 工位1数据上报请求(22015)=1，开始发送 MES MSG2 过站请求。");
					var respMsg2Result = Mes.SendRawAsciiMessage2(Core.工号, 扫码);
					if (respMsg2Result.IsError())
					{
						Logger.Error(respMsg2Result.Exception, "【过站】MES MSG2 通讯失败: {msg}", respMsg2Result.Message);
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					var responseAscii = respMsg2Result.Value?.Trim() ?? "";
					var firstThree = responseAscii.Length > 3 ? responseAscii[..3] : responseAscii;
					var isMesOk = string.Equals(responseAscii, "OK", StringComparison.OrdinalIgnoreCase) ||
					              responseAscii.StartsWith("OK,", StringComparison.OrdinalIgnoreCase) ||
					              responseAscii.StartsWith("OK2", StringComparison.OrdinalIgnoreCase);
					if (isMesOk == false)
					{
						Logger.Error("【过站】MES MSG2 返回非 OK/OK2，前三位={firstThree}，原始回复={response}", firstThree, responseAscii);
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					Logger.Info("【过站】MES MSG2 返回 OK/OK2，前三位={firstThree}。", firstThree);
					_pendingUploadResponse = 1;
				}
				catch (Exception ex)
				{
					Logger.Error(ex, "数据上报发生致命异常: {msg}", ex.Message);
					_pendingUploadResponse = 2;
				}

				WritePendingResponse:
				TryWritePendingUploadResponse();
				continue;
			}
			}
			catch (Exception ex)
			{
				Logger.Error(ex, "WorkLeft main loop error, will retry.");
				Thread.Sleep(1000);
			}
		}
	}

	private bool TryWritePendingUploadResponse()
	{
		if (_pendingUploadResponse == 0)
			return true;

		try
		{
			var response = _pendingUploadResponse;
			Plc.Write.工位1数据上报请求 = 0;
			Plc.Write.WritePoint(PlcStructInfo.工位1数据上报请求).Unwarp("reset work left upload request failed!");
			Plc.Write.工位1数据上报响应 = response;
			Plc.Write.WritePoint(PlcStructInfo.工位1数据上报响应).Unwarp("write work left upload response failed!");
			_pendingUploadResponse = 0;
			Logger.Info("【过站】工位1数据上报PLC响应写入完成，响应={response}。", response);
			SetFlowStep(response == 1 ? 9 : 8);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error(ex, "【过站】工位1数据上报PLC响应写入失败，将在下一轮重试，不重复发送MES。");
			return false;
		}
	}

	private static (string? WorkOrder, string? ModelName) ParseMesModelInfo(string? rawAscii)
	{
		if (string.IsNullOrEmpty(rawAscii))
			return (null, null);

		string? workOrder = null;
		string? modelName = null;
		var parts = rawAscii.Split([',', ' ', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
		foreach (var part in parts)
		{
			var cleanPart = part.Trim();
			var upper = cleanPart.ToUpperInvariant();
			var equalsIndex = cleanPart.IndexOf('=');
			if (equalsIndex < 0)
				continue;

			var value = cleanPart[(equalsIndex + 1)..].Trim();
			if (upper.StartsWith("MO_NUMBER="))
				workOrder = value;
			else if (upper.StartsWith("MODEL_NAME="))
				modelName = value;
		}

		return (workOrder, modelName);
	}
}
