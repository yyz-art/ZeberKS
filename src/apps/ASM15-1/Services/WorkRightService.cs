using System.Text;
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
public partial class WorkRightService : WorkServiceBase
{
	private readonly byte[] _buffer = new byte[1024];
	private short _pendingUploadResponse;
	private bool _waitingSecondScan;
	private bool _screwCollectEnabled;
	private string _sn1 = "";
	private string _sn2 = "";

	public override string ServiceName => "WorkRight";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public required AppConfig AppConfig { get; init; }
	public IDataSocket CodeScanner2 { get; set; } = null!;
	public ScrewTightenSnapshot[] ScrewTightenResults { get; } = CreateScrewTightenResults();
	public partial string 机种型号 { get; set; } = "";
	public partial string 扫码 { get; set; } = "";

	public override Task Initialize(object? ctx = null, object? args = null)
	{
		InitCodeScanner2();
		AppConfig.PropertyChanged += (sender, e) =>
		{
			if (e.PropertyName == nameof(AppConfig.Scanner2ComPort) ||
			    e.PropertyName == nameof(AppConfig.Scanner2BaudRate))
			{
				Logger.Warn("检测到扫码枪2配置发生改变，正在重新初始化串口...");
				InitCodeScanner2();
			}
		};

		return base.Initialize(ctx, args);
	}

	private void InitCodeScanner2()
	{
		try { CodeScanner2?.Close(); } catch { }
		CodeScanner2 = new SerialPortSocket(AppConfig.Scanner2ComPort, AppConfig.Scanner2BaudRate);
		Logger.Info("扫码枪2实例已绑定至: {port} [{baudRate}]", AppConfig.Scanner2ComPort, AppConfig.Scanner2BaudRate);
	}

	private Result<string> ScanCodeOnce(char[] charBuffer)
	{
		if (CodeScanner2 is not { IsOpen: true })
		{
			var openResult = CodeScanner2?.Open() ?? Result.Err("CodeScanner2 instance is null");
			if (openResult.IsError())
			{
				Logger.Error("扫码枪2打开失败: {msg}", openResult.Message);
				return Result.Err<string>(openResult);
			}
		}

		CodeScanner2!.ReadToDiscard();

		var writeResult = CodeScanner2!.Write(StartScanCommandBytes);
		if (writeResult.IsError())
		{
			Logger.Error("扫码枪2触发命令发送失败: {msg}", writeResult.Message);
			return Result.Err<string>(writeResult);
		}

		Plc.Write.扫码枪2触发 = 0;
		Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发).Unwarp("reset right scanner trigger failed!");
		Logger.Info("扫码枪2触发命令发送成功，已复位 扫码枪2触发=0。");

		var readResult = CodeScanner2!.ReadContinuous(_buffer, 2000, 200);
		if (readResult.IsError())
		{
			Logger.Error("扫码枪2读取超时或失败: {msg}", readResult.Message);
			return Result.Err<string>(readResult);
		}

		var readLength = readResult.Value;
		if (false == _buffer.StartsWith(StartScanResponseBytes))
		{
			var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
			Logger.Error("扫码枪2响应格式错误: {hex}", responseHex);
			return Result.Err<string>("扫码枪2响应格式错误");
		}

		var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length, readLength - StartScanResponseBytes.Length);
		if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
		{
			var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
			Logger.Error("扫码枪2条码解析失败: {hex}", responseHex);
			return Result.Err<string>("扫码枪2条码解析失败");
		}

		var code = new string(charBuffer, 0, codeLength).Trim();
		if (string.IsNullOrWhiteSpace(code) || code.Length < 20)
		{
			Logger.Error("扫码枪2未扫到有效二维码或二维码长度不足20位，当前码='{code}'，长度={length}，工位2不允许生产。", code, code.Length);
			return Result.Err<string>("扫码枪2未扫到有效二维码或二维码长度不足20位");
		}

		Logger.Info("Scanned code is '{code}'", code);
		return Result.Ok(code);
	}

	protected override async Task Main(CancellationToken ctk)
	{
		var charBuffer = new char[1024];
		while (ctk.IsCancellationRequested == false)
		{
			try
			{
				Plc.WaitNextCycle();

				if (Plc.Read.扫码枪2触发 == 0 && Plc.Read.扫码枪2触发结果 != 0)
				{
					Plc.Write.扫码枪2触发结果 = 0;
					Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp("Clear right scanner result failed!");
					continue;
				}

				if (TryCollectScrewTightenResult())
					continue;

			if (Plc.Read.扫码枪2触发 == 1 && Plc.Read.扫码枪2触发结果 == 0)
			{
				var writeAllowProduceOnOk = false;
				try
				{
					var scanResult = ScanCodeOnce(charBuffer);

					if (scanResult.IsError())
					{
						Plc.Write.工位2允许生产 = 2;
						goto SendCodeNG;
					}

					var scannedCode = scanResult.Value!;
					if (_waitingSecondScan)
					{
						_sn2 = scannedCode.Trim();
						if (Core.MesSkipEnabled)
						{
							Logger.Warn("【MES跳过】工位2第二次扫码完成，跳过 MSG3，写允许生产=1。SN1={sn1}, SN2={sn2}", _sn1, _sn2);
							_screwCollectEnabled = true;
							Plc.Write.工位2允许生产 = 1;
							writeAllowProduceOnOk = true;
							goto SendCodeOK;
						}

						Logger.Info("【第二次扫码】收到 SN2={sn2}，开始发送 MES MSG3。", _sn2);
						var mesMsg3Result = Mes.SendRawAsciiMessage3(Core.工号, _sn1, _sn2);
						if (mesMsg3Result.IsError())
						{
							Logger.Error("第二次扫码失败: MSG3 通讯异常: {msg}", mesMsg3Result.Message);
							Plc.Write.工位2允许生产 = 2;
							goto SendCodeNG;
						}

						var response3Ascii = mesMsg3Result.Value!.Trim().ToUpperInvariant();
						if (IsMesResponseOkInFirstThree(response3Ascii) == false)
						{
							Logger.Error("第二次扫码失败: MES MSG3 回复前三位未包含 OK，原始回复内容为: {response}", response3Ascii);
							Plc.Write.工位2允许生产 = 2;
							goto SendCodeNG;
						}

						Logger.Info("【第二次扫码】MES MSG3 回复前三位包含 OK，允许入站。SN1={sn1}, SN2={sn2}", _sn1, _sn2);
						_screwCollectEnabled = true;
						Plc.Write.工位2允许生产 = 1;
						writeAllowProduceOnOk = true;
						goto SendCodeOK;
					}

					扫码 = scannedCode.Trim();
					_sn1 = 扫码;
					_sn2 = "";
					机种型号 = "";
					_waitingSecondScan = false;
					_screwCollectEnabled = false;
					ResetScrewTightenResults();

					if (Core.MesSkipEnabled)
					{
						Logger.Warn("【MES跳过】工位2第一次扫码完成，跳过 MSG7/MSG1，仅写扫码枪2触发结果=1，等待第二次扫码。SN1={sn1}", _sn1);
						_waitingSecondScan = true;
						goto SendCodeOK;
					}

					Logger.Info("【第一步】请求查工单和机种(MSG7) -> 开始");
					var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码);
					if (mesMsg7Result.IsError())
					{
						Logger.Error("第一步失败: 获取工单通讯异常: {msg}", mesMsg7Result.Message);
						Plc.Write.工位2允许生产 = 2;
						goto SendCodeNG;
					}

					var rawAscii = mesMsg7Result.Value;
					var parseResult = ParseMesModelInfo(rawAscii);
					if (parseResult.WorkOrder is null || parseResult.ModelName is null)
					{
						Logger.Error("第一步失败: MES回传的报文中未找到 MO_NUMBER 或 MODEL_NAME");
						Plc.Write.工位2允许生产 = 2;
						goto SendCodeNG;
					}

					Core.工单号 = parseResult.WorkOrder;
					机种型号 = parseResult.ModelName;
					Logger.Info("【第一步】通过，工单={workOrder}，机种={modelName}", Core.工单号, 机种型号);
					Logger.Info("【配方切换】ASM15-1 不需要配方功能，本次不执行配方判断和下发。");

					Logger.Info("【第二步】申请入站过站(MSG1) -> 开始");
					var mesMsg1Result = Mes.SendRawAsciiMessage1(Core.工号, 扫码);
					if (mesMsg1Result.IsError())
					{
						Logger.Error("第二步失败: 入站请求通讯异常: {msg}", mesMsg1Result.Message);
						Plc.Write.工位2允许生产 = 2;
						goto SendCodeNG;
					}

					var response1Ascii = mesMsg1Result.Value!.Trim().ToUpperInvariant();
					if (IsMesResponseOkInFirstThree(response1Ascii) == false)
					{
						Logger.Error("第三步失败: MES MSG1 回复前三位未包含 OK，原始回复内容为: {response}", response1Ascii);
						Plc.Write.工位2允许生产 = 2;
						goto SendCodeNG;
					}

					Logger.Info("【第三步】收到 MES 回复前三位包含 OK，仅写扫码枪2触发结果=1，等待到位后第二次扫码。SN1={sn1}", _sn1);
					_waitingSecondScan = true;
					goto SendCodeOK;
				}
				catch (Exception ex)
				{
					Logger.Error(ex, "入站扫码工作站发生致命异常: {msg}", ex.Message);
					Plc.Write.工位2允许生产 = 2;
					goto SendCodeNG;
				}

				SendCodeOK:
				if (writeAllowProduceOnOk)
					Plc.Write.WritePoint(PlcStructInfo.工位2允许生产).Unwarp("write right allow produce OK failed!");
				Plc.Write.扫码枪2触发结果 = CodeOfOK;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp("write right scanner scan result failed!");
				continue;

				SendCodeNG:
				扫码 = "";
				_sn1 = "";
				_sn2 = "";
				_waitingSecondScan = false;
				_screwCollectEnabled = false;
				Plc.Write.WritePoint(PlcStructInfo.工位2允许生产).Unwarp("write right allow produce NG failed!");
				Plc.Write.扫码枪2触发结果 = CodeOfNG;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp("write right scanner scan result failed!");
				continue;
			}

			if (_pendingUploadResponse != 0)
			{
				if (TryWritePendingUploadResponse())
					continue;
			}

			if (Plc.Read.工位2数据上报请求 is 0 && Plc.Read.工位2数据上报响应 is not 0)
			{
				Plc.Write.工位2数据上报响应 = 0;
				Plc.Write.WritePoint(PlcStructInfo.工位2数据上报响应).Unwarp("clear work right upload result!");
				continue;
			}

			if (Plc.Read.工位2数据上报请求 == 1 && Plc.Read.工位2数据上报响应 == 0)
			{
				try
				{
					if (string.IsNullOrEmpty(扫码))
					{
						Logger.Error("plc upload result must scan code, current code is null!");
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					if (TryGetScrewUploadData(out var screwData, out var missingScrews) == false)
					{
						Logger.Error("【过站】收到 工位2数据上报请求(22016)=1，但16颗螺丝数据未收齐，缺少螺丝: {missingScrews}。", missingScrews);
						ResetWorkRightUploadRequest();
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					if (Core.MesSkipEnabled)
					{
						Logger.Warn("【MES跳过】收到 工位2数据上报请求(22016)=1，16颗螺丝数据已收齐，跳过 MSG2，直接复位请求并响应 OK。");
						ResetWorkRightUploadRequest();
						_pendingUploadResponse = 1;
						goto WritePendingResponse;
					}

					Logger.Info("【过站】收到 工位2数据上报请求(22016)=1，先复位请求信号，再发送带16颗螺丝数据的 MES MSG2。");
					ResetWorkRightUploadRequest();
					var respMsg2Result = Mes.SendRawAsciiMessage2WithScrewData(Core.工号, _sn1, screwData);
					if (respMsg2Result.IsError())
					{
						Logger.Error(respMsg2Result.Exception, "【过站】MES MSG2 螺丝数据通讯失败: {msg}", respMsg2Result.Message);
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					var responseAscii = respMsg2Result.Value?.Trim() ?? "";
					var firstThree = responseAscii.Length > 3 ? responseAscii[..3] : responseAscii;
					var isMesOk = IsMesResponseOkInFirstThree(responseAscii);
					if (isMesOk == false)
					{
						Logger.Error("【过站】MES MSG2 螺丝数据返回非 OK，前三位={firstThree}，原始回复={response}", firstThree, responseAscii);
						_pendingUploadResponse = 2;
						goto WritePendingResponse;
					}

					Logger.Info("【过站】MES MSG2 螺丝数据返回 OK，前三位={firstThree}。", firstThree);
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
				Logger.Error(ex, "WorkRight main loop error, will retry.");
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
			Plc.Write.工位2数据上报请求 = 0;
			Plc.Write.WritePoint(PlcStructInfo.工位2数据上报请求).Unwarp("reset work right upload request failed!");
			Plc.Write.工位2数据上报响应 = response;
			Plc.Write.WritePoint(PlcStructInfo.工位2数据上报响应).Unwarp("write work right upload response failed!");
			_pendingUploadResponse = 0;
			Logger.Info("【过站】工位2数据上报PLC响应写入完成，响应={response}。", response);
			if (response == 1)
				ClearCompletedProductState();
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error(ex, "【过站】工位2数据上报PLC响应写入失败，将在下一轮重试，不重复发送MES。");
			return false;
		}
	}

	private void ResetWorkRightUploadRequest()
	{
		Plc.Write.工位2数据上报请求 = 0;
		Plc.Write.WritePoint(PlcStructInfo.工位2数据上报请求).Unwarp("reset work right upload request failed!");
	}

	private bool TryGetScrewUploadData(out List<(double Torque, double Turns)> screwData, out string missingScrews)
	{
		screwData = new List<(double Torque, double Turns)>(ScrewTightenResults.Length);
		var missing = new List<int>();

		foreach (var snapshot in ScrewTightenResults.OrderBy(x => x.ScrewNo))
		{
			if (snapshot.HasValue == false)
			{
				missing.Add(snapshot.ScrewNo);
				continue;
			}

			screwData.Add((snapshot.MaxTorque, snapshot.Turns));
		}

		missingScrews = string.Join(",", missing);
		return missing.Count == 0 && screwData.Count == 16;
	}

	private bool TryCollectScrewTightenResult()
	{
		var screwNo = Plc.Read.工位2螺丝拧紧完成信号;
		if (screwNo == 0)
			return false;

		try
		{
			if (_screwCollectEnabled == false)
			{
				Logger.Warn("【螺丝采集】收到工位2螺丝拧紧完成信号(22076)={screwNo}，但当前扫码流程未完成，忽略并复位。", screwNo);
				return ResetRightScrewFinishedSignal();
			}

			if (screwNo is < 1 or > 16)
			{
				Logger.Warn("【螺丝采集】收到工位2螺丝拧紧完成信号(22076)={screwNo}，超出1-16范围，忽略并复位。", screwNo);
				return ResetRightScrewFinishedSignal();
			}

			var screwService = App.Current.ScrewService2;
			if (screwService is null)
			{
				Logger.Error("【螺丝采集】工位2螺丝服务未启动，无法保存第{screwNo}颗螺丝数据。", screwNo);
				return ResetRightScrewFinishedSignal();
			}

			if (IsScrewServiceFresh(screwService) == false)
			{
				Logger.Error("【螺丝采集】工位2螺丝机未连接或实时数据已过期，无法保存第{screwNo}颗螺丝数据。连接状态={isConnected}，最后成功读取时间={lastReadAt:yyyy-MM-dd HH:mm:ss.fff}",
					screwNo, screwService.IsConnected, screwService.LastSuccessfulReadAt);
				return ResetRightScrewFinishedSignal();
			}

			var snapshot = ScrewTightenResults[screwNo - 1];
			snapshot.ScrewNo = screwNo;
			snapshot.MaxTorque = ConvertMilliNewtonMeterToKgfCm(screwService.Data.最大扭力值);
			snapshot.Turns = ConvertTurns(screwService.Data.总圈数);
			snapshot.Sn1 = _sn1;
			snapshot.Sn2 = _sn2;
			snapshot.CollectedAt = DateTime.Now;
			snapshot.HasValue = true;
			snapshot.StateText = "已采集";

			Logger.Info("【螺丝采集】工位2第{screwNo}颗螺丝保存完成，扭力={torque}，圈数={turns}，SN1={sn1}，SN2={sn2}。",
				screwNo, snapshot.MaxTorque, snapshot.Turns, snapshot.Sn1, snapshot.Sn2);
			return ResetRightScrewFinishedSignal();
		}
		catch (Exception ex)
		{
			Logger.Error(ex, "【螺丝采集】工位2处理螺丝完成信号失败。");
			return false;
		}
	}

	private bool ResetRightScrewFinishedSignal()
	{
		Plc.Write.工位2螺丝拧紧完成信号 = 0;
		Plc.Write.WritePoint(WorkScrewSignalPoints.RightScrewFinishedSignal).Unwarp("reset work right screw finished signal failed!");
		return true;
	}

	private static double ConvertMilliNewtonMeterToKgfCm(ushort value)
	{
		const double mNmToKgfCm = 0.01019716213d;
		return Math.Round(value * mNmToKgfCm, 2);
	}

	private static double ConvertTurns(ushort value)
	{
		return Math.Round(value / 100d, 2);
	}

	private static bool IsScrewServiceFresh(ScrewService screwService)
	{
		return screwService.IsConnected &&
		       screwService.LastSuccessfulReadAt != default &&
		       DateTime.Now - screwService.LastSuccessfulReadAt <= TimeSpan.FromSeconds(3);
	}

	private void ClearCompletedProductState()
	{
		扫码 = "";
		_sn1 = "";
		_sn2 = "";
		_waitingSecondScan = false;
		_screwCollectEnabled = false;
		ResetScrewTightenResults();
	}

	private void ResetScrewTightenResults()
	{
		for (var i = 0; i < ScrewTightenResults.Length; i++)
		{
			var snapshot = ScrewTightenResults[i];
			snapshot.ScrewNo = i + 1;
			snapshot.MaxTorque = 0;
			snapshot.Turns = 0;
			snapshot.Sn1 = "";
			snapshot.Sn2 = "";
			snapshot.CollectedAt = default;
			snapshot.HasValue = false;
			snapshot.StateText = "";
		}
	}

	private static ScrewTightenSnapshot[] CreateScrewTightenResults()
	{
		var results = new ScrewTightenSnapshot[16];
		for (var i = 0; i < results.Length; i++)
			results[i] = new ScrewTightenSnapshot { ScrewNo = i + 1 };
		return results;
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

	private static bool IsMesResponseOkInFirstThree(string? responseAscii)
	{
		if (string.IsNullOrWhiteSpace(responseAscii))
			return false;

		var trimmed = responseAscii.Trim();
		var firstThree = trimmed.Length > 3 ? trimmed[..3] : trimmed;
		return firstThree.Contains("OK", StringComparison.OrdinalIgnoreCase);
	}
}
