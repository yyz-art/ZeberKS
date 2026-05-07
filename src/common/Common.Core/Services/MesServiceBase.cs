using System;
using System.Text;
using System.Threading;
using ZC;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.LOG;
using ZC.Net.Sockets;
using ZitApp.SIFS;
using ZC.IFS.Objects;

namespace ZitApp.Services;

public class MesServiceBase<T> : INamedObject where T : CommonAppConfig
{
	public virtual string GetObjectName() => "MES-SERVICE";

	public required T Config { get; set; }
	public required ILogger Logger { get; init; }

	private readonly object _syncLock = new object();
	private static readonly object MesLogFileLock = new();

	public SifsClient Client
	{
		get
		{
			if (field == null)
			{
				lock (_syncLock)
				{
					field ??= new SifsClient(new NetworkSocketConfig(Config.SifsHostIp, Config.SifsHostPort));
				}
			}

			return field;
		}
	}

	public Result<string> SendAndReadString(string msg)
	{
		if (CommonAppConfig.IsDevTestMode)
		{
			Thread.Sleep(1000);
			return Result.Ok("OK7,MO_NUMBER=9001812-UG MODEL_NAME=1005-042301-Z0");
		}
		
		var openResult = Client.Open();
		if (openResult.IsError())
			return Result.Err<string>(openResult);
		try
		{
			Client.Socket!.WriteUtf8(msg);
			Span<byte> buffer = stackalloc byte[4096];
			var readResult = Client.Socket!.ReadContinuous(buffer, 3000, 200);
			if (readResult.IsError())
				return Result.Err<string>(readResult);
			Span<char> charBuffer = stackalloc char[4096];
			if (false == Encoding.UTF8.TryGetChars(buffer[..readResult.Value], charBuffer, out var len))
				return Result.Err<string>(
					$"response format error! hex raw data = '{HexUtils.ToString(buffer[..readResult.Value])}'");
			var result = charBuffer[..len].Trim().ToString();
			return Result.Ok(result);
		}
		finally
		{
			Client.Close();
		}
	}

	public Result<Message1Response> SendMessage1(string operatorID, string sn)
	{
		lock (_syncLock)
		{
			try
			{
				if (Client.Socket is not { IsOpen: true })
				{
					var openResult = Client.Socket!.Open();
					if (openResult.IsError())
					{
						Logger.Error($"[MES MSG1 进站] 网络连接打开失败: {openResult.Message}");
						return Result.Err<Message1Response>(openResult);
					}
				}

				var request = new SifsRequest();
				request.Line = Config.Line;
				request.OperatorID = operatorID;
				request.MessageType = "1";
				request.Result = "OK";
				request.SN = sn;
				request.StationName = Config.StationName;

				var requestLog =
					$"Line: {request.Line}, Op: {request.OperatorID}, Type: {request.MessageType}, Result: {request.Result}, SN: {request.SN}, Station: {request.StationName}";
				Logger.Info($"[MES MSG1 请求] -> {requestLog}");
				WriteMesLog("SEND", "MSG1", requestLog);

				var responseResult = Client.SendMessage1(request);

				if (!responseResult.IsError())
				{
					Logger.Info($"[MES MSG1 响应] <- {responseResult.Value}");
					WriteMesLog("RECV", "MSG1", responseResult.Value.ToString() ?? "");
				}
				else
				{
					Logger.Error($"[MES MSG1 失败] <- MES未响应或通讯异常: {responseResult.Message}");
					WriteMesLog("RECV", "MSG1", $"ERROR: {responseResult.Message}");
				}

				return responseResult;
			}
			catch (Exception ex)
			{
				Logger.Error($"[MES MSG1 崩溃] 底层库发生异常: {ex.Message}");
				WriteMesLog("RECV", "MSG1", $"EXCEPTION: {ex.Message}");
				return Result.Err<Message1Response>(ex.Message);
			}
		}
	}

	public Result<Message7Response> SendMessage7(string operatorID, string sn, string customStation = null,
		string customLine = null)
	{
		lock (_syncLock)
		{
			try
			{
				if (Client.Socket is not { IsOpen: true })
				{
					var openResult = Client.Socket!.Open();
					if (openResult.IsError())
					{
						Logger.Error($"[MES MSG7 查工单] 网络连接打开失败: {openResult.Message}");
						return Result.Err<Message7Response>(openResult);
					}
				}

				var request = new SifsRequest();
				request.Line = customLine ?? Config.Line;
				request.OperatorID = operatorID;
				request.MessageType = "7";
				request.Result = "OK";
				request.SN = sn;
				request.StationName = customStation ?? Config.StationName;

				var msg7Payload = new SifsPayloadBuilder()
					.AddGetVariable("MO_NUMBER")
					.AddGetVariable("MODEL_NAME");

				var requestLog =
					$"Line: {request.Line}, Op: {request.OperatorID}, Type: {request.MessageType}, SN: {request.SN}, Station: {request.StationName} | 查询变量: MO_NUMBER, MODEL_NAME";
				Logger.Info($"[MES MSG7 请求] -> {requestLog}");
				WriteMesLog("SEND", "MSG7", requestLog);

				var responseResult = Client.SendMessage7(request, msg7Payload);

				if (!responseResult.IsError())
				{
					Logger.Info($"[MES MSG7 响应] <- {responseResult.Value}");
					WriteMesLog("RECV", "MSG7", responseResult.Value.ToString() ?? "");
				}
				else
				{
					Logger.Error($"[MES MSG7 失败] <- MES未响应或通讯异常: {responseResult.Message}");
					WriteMesLog("RECV", "MSG7", $"ERROR: {responseResult.Message}");
				}

				return responseResult;
			}
			catch (Exception ex)
			{
				Logger.Error($"[MES MSG7 崩溃] 底层库发生异常: {ex.Message}");
				WriteMesLog("RECV", "MSG7", $"EXCEPTION: {ex.Message}");
				return Result.Err<Message7Response>(ex.Message);
			}
		}
	}

	public Result<Message2Response> SendMessage2(
		string operatorID, string sn, SifsPayloadBuilder? payload, string productResult = "OK")
	{
		lock (_syncLock)
		{
			try
			{
				if (Client.Socket is not { IsOpen: true })
				{
					var openResult = Client.Socket!.Open();
					if (openResult.IsError())
					{
						Logger.Error($"[MES MSG2 出站上报] 网络连接打开失败: {openResult.Message}");
						return Result.Err<Message2Response>(openResult);
					}
				}

				var request = new SifsRequest();
				request.Line = Config.Line;
				request.OperatorID = operatorID;
				request.MessageType = "2";
				request.Result = productResult;
				request.SN = sn;
				request.StationName = Config.StationName;

				var payloadLog = payload != null ? "已携带工艺参数" : "无工艺参数";

				var requestLog =
					$"Line: {request.Line}, Op: {request.OperatorID}, Type: {request.MessageType}, Result: {request.Result}, SN: {request.SN}, Station: {request.StationName} | {payloadLog}";
				Logger.Info($"[MES MSG2 请求] -> {requestLog}");
				WriteMesLog("SEND", "MSG2", requestLog);

				var responseResult = Client.SendMessage2(request, payload);

				if (!responseResult.IsError())
				{
					Logger.Info($"[MES MSG2 响应] <- {responseResult.Value}");
					WriteMesLog("RECV", "MSG2", responseResult.Value.ToString() ?? "");
				}
				else
				{
					Logger.Error($"[MES MSG2 失败] <- MES未响应或通讯异常: {responseResult.Message}");
					WriteMesLog("RECV", "MSG2", $"ERROR: {responseResult.Message}");
				}

				return responseResult;
			}
			catch (Exception ex)
			{
				Logger.Error($"[MES MSG2 崩溃] 底层库发生异常: {ex.Message}");
				WriteMesLog("RECV", "MSG2", $"EXCEPTION: {ex.Message}");
				return Result.Err<Message2Response>(ex.Message);
			}
		}
	}

	public Result<string> SendRawAsciiMessage7(string sn)
	{
		lock (_syncLock)
		{
			try
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}

				var openResult = Client.Socket!.Open();
				if (openResult.IsError()) return Result.Err<string>($"TCP打开失败: {openResult.Message}");

				//.Trim() 防呆
				string cleanSn = sn?.Trim() ?? "";
				string requestAscii = $"ASM_QUERY,{cleanSn},7,,SMD,,OK,MO_NUMBER=??? MODEL_NAME=???";

				Logger.Info($"[MSG7发送] -> {requestAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("SEND", "MSG7-ASCII", requestAscii);

				// 2. 发送出去
				byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(requestAscii);
				var writeResult = Client.Socket.Write(sendBytes);
				if (writeResult.IsError())
				{
					WriteMesLog("RECV", "MSG7-ASCII", "ERROR: Socket写入失败");
					return Result.Err<string>("Socket写入失败");
				}

				// 3. 读取 MES 的回复
				byte[] recvBuffer = new byte[2048];
				var readResult = Client.Socket.ReadContinuous(recvBuffer, 3000, 200);
				if (readResult.IsError())
				{
					WriteMesLog("RECV", "MSG7-ASCII", "ERROR: Socket读取超时");
					return Result.Err<string>("Socket读取超时");
				}

				// 4. 转成字符串
				string responseAscii = System.Text.Encoding.ASCII.GetString(recvBuffer, 0, readResult.Value);
				Logger.Info($"[MSG7接收] <- {responseAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("RECV", "MSG7-ASCII", responseAscii);

				return Result.Ok(responseAscii);
			}
			catch (Exception ex)
			{
				WriteMesLog("RECV", "MSG7-ASCII", $"EXCEPTION: {ex.Message}");
				return Result.Err<string>(ex.Message);
			}
			finally
			{
				// 清理死连接
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}
			}
		}
	}


	public Result<string> SendRawAsciiMessage1(string operatorID, string sn)
	{
		lock (_syncLock)
		{
			try
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}

				var openResult = Client.Socket!.Open();
				if (openResult.IsError()) return Result.Err<string>($"TCP打开失败: {openResult.Message}");

				string cleanStation = Config.StationName?.Trim() ?? "";
				string cleanSn = sn?.Trim() ?? "";
				string cleanOp = operatorID?.Trim() ?? "";
				string cleanLine = Config.Line?.Trim() ?? "";

				string requestAscii = $"{cleanStation},{cleanSn},1,{cleanOp},{cleanLine},,OK,,,";

				Logger.Info($"[MSG1发送] -> {requestAscii}");
				WriteMesLog("SEND", "MSG1-ASCII", requestAscii);

				byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(requestAscii);
				var writeResult = Client.Socket.Write(sendBytes);
				if (writeResult.IsError())
				{
					WriteMesLog("RECV", "MSG1-ASCII", "ERROR: Socket写入失败");
					return Result.Err<string>("Socket写入失败");
				}

				//  读取 MES 回复
				byte[] recvBuffer = new byte[2048];
				var readResult = Client.Socket.ReadContinuous(recvBuffer, 3000, 200);
				if (readResult.IsError())
				{
					WriteMesLog("RECV", "MSG1-ASCII", "ERROR: Socket读取超时");
					return Result.Err<string>("Socket读取超时");
				}

				string responseAscii = System.Text.Encoding.ASCII.GetString(recvBuffer, 0, readResult.Value);
				Logger.Info($"[MSG1接收] <- {responseAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("RECV", "MSG1-ASCII", responseAscii);

				return Result.Ok(responseAscii);
			}
			catch (Exception ex)
			{
				WriteMesLog("RECV", "MSG1-ASCII", $"EXCEPTION: {ex.Message}");
				return Result.Err<string>(ex.Message);
			}
			finally
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}
			}
		}
	}

	public Result<string> SendRawAsciiMessage3(string operatorID, string sn1, string sn2)
	{
		lock (_syncLock)
		{
			try
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}

				var openResult = Client.Socket!.Open();
				if (openResult.IsError()) return Result.Err<string>($"TCP打开失败: {openResult.Message}");

				string cleanStation = Config.StationName?.Trim() ?? "";
				string cleanSn1 = sn1?.Trim() ?? "";
				string cleanSn2 = sn2?.Trim() ?? "";
				string cleanOp = operatorID?.Trim() ?? "";
				string cleanLine = Config.Line?.Trim() ?? "";

				string requestAscii = $"{cleanStation},{cleanSn1},3,{cleanOp},{cleanLine},,OK,{cleanSn2},,";

				Logger.Info($"[MSG3发送] -> {requestAscii}");
				WriteMesLog("SEND", "MSG3-ASCII", requestAscii);

				byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(requestAscii);
				var writeResult = Client.Socket.Write(sendBytes);
				if (writeResult.IsError())
				{
					WriteMesLog("RECV", "MSG3-ASCII", "ERROR: Socket写入失败");
					return Result.Err<string>("Socket写入失败");
				}

				byte[] recvBuffer = new byte[2048];
				var readResult = Client.Socket.ReadContinuous(recvBuffer, 3000, 200);
				if (readResult.IsError())
				{
					WriteMesLog("RECV", "MSG3-ASCII", "ERROR: Socket读取超时");
					return Result.Err<string>("Socket读取超时");
				}

				string responseAscii = System.Text.Encoding.ASCII.GetString(recvBuffer, 0, readResult.Value);
				Logger.Info($"[MSG3接收] <- {responseAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("RECV", "MSG3-ASCII", responseAscii);

				return Result.Ok(responseAscii);
			}
			catch (Exception ex)
			{
				WriteMesLog("RECV", "MSG3-ASCII", $"EXCEPTION: {ex.Message}");
				return Result.Err<string>(ex.Message);
			}
			finally
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}
			}
		}
	}

	public Result<string> SendRawAsciiMessage2(string operatorID, string sn)
	{
		lock (_syncLock)
		{
			try
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}

				var openResult = Client.Socket!.Open();
				if (openResult.IsError()) return Result.Err<string>($"TCP打开失败: {openResult.Message}");

				string cleanStation = Config.StationName?.Trim() ?? "";
				string cleanSn = sn?.Trim() ?? "";
				string cleanOp = operatorID?.Trim() ?? "";
				string cleanLine = Config.Line?.Trim() ?? "";
				string requestAscii = $"{cleanStation},{cleanSn},2,{cleanOp},{cleanLine},,OK,,,";

				Logger.Info($"[MSG2发送] -> {requestAscii}");
				WriteMesLog("SEND", "MSG2-ASCII", requestAscii);

				byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(requestAscii);
				var writeResult = Client.Socket.Write(sendBytes);
				if (writeResult.IsError())
				{
					WriteMesLog("RECV", "MSG2-ASCII", "ERROR: Socket写入失败");
					return Result.Err<string>("Socket写入失败");
				}

				byte[] recvBuffer = new byte[2048];
				var readResult = Client.Socket.ReadContinuous(recvBuffer, 3000, 200);
				if (readResult.IsError())
				{
					WriteMesLog("RECV", "MSG2-ASCII", "ERROR: Socket读取超时");
					return Result.Err<string>("Socket读取超时");
				}

				string responseAscii = System.Text.Encoding.ASCII.GetString(recvBuffer, 0, readResult.Value);
				Logger.Info($"[MSG2 纯ASCII接收] <- {responseAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("RECV", "MSG2-ASCII", responseAscii);

				return Result.Ok(responseAscii);
			}
			catch (Exception ex)
			{
				WriteMesLog("RECV", "MSG2-ASCII", $"EXCEPTION: {ex.Message}");
				return Result.Err<string>(ex.Message);
			}
			finally
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}
			}
		}
	}

	public Result<string> SendRawAsciiMessage2WithScrewData(string operatorID, string sn,
		IReadOnlyList<(double Torque, double Turns)> screwData)
	{
		lock (_syncLock)
		{
			try
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}

				var openResult = Client.Socket!.Open();
				if (openResult.IsError()) return Result.Err<string>($"TCP打开失败: {openResult.Message}");

				string cleanStation = Config.StationName?.Trim() ?? "";
				string cleanSn = sn?.Trim() ?? "";
				string cleanOp = operatorID?.Trim() ?? "";
				string cleanLine = Config.Line?.Trim() ?? "";
				var payloadParts = new List<string>(screwData.Count * 2);
				for (var i = 0; i < screwData.Count; i++)
				{
					var screwNo = i + 1;
					payloadParts.Add($"\"[VR]SCREW{screwNo}(KGF-CM)={screwData[i].Torque:F2}\"");
					payloadParts.Add($"\"[VR]TURN{screwNo}(Lap)={screwData[i].Turns:F2}\"");
				}

				string requestAscii =
					$"{cleanStation},{cleanSn},2,{cleanOp},{cleanLine},,OK,,,{string.Join(" ", payloadParts)}";

				Logger.Info($"[MSG2螺丝数据发送] -> {requestAscii}");
				WriteMesLog("SEND", "MSG2-SCREW-ASCII", requestAscii);

				byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes(requestAscii);
				var writeResult = Client.Socket.Write(sendBytes);
				if (writeResult.IsError())
				{
					WriteMesLog("RECV", "MSG2-SCREW-ASCII", "ERROR: Socket写入失败");
					return Result.Err<string>("Socket写入失败");
				}

				byte[] recvBuffer = new byte[4096];
				var readResult = Client.Socket.ReadContinuous(recvBuffer, 3000, 200);
				if (readResult.IsError())
				{
					WriteMesLog("RECV", "MSG2-SCREW-ASCII", "ERROR: Socket读取超时");
					return Result.Err<string>("Socket读取超时");
				}

				string responseAscii = System.Text.Encoding.ASCII.GetString(recvBuffer, 0, readResult.Value);
				Logger.Info($"[MSG2螺丝数据接收] <- {responseAscii.Replace("\r\n", "<换行>")}");
				WriteMesLog("RECV", "MSG2-SCREW-ASCII", responseAscii);

				return Result.Ok(responseAscii);
			}
			catch (Exception ex)
			{
				WriteMesLog("RECV", "MSG2-SCREW-ASCII", $"EXCEPTION: {ex.Message}");
				return Result.Err<string>(ex.Message);
			}
			finally
			{
				try
				{
					Client.Socket?.Close();
				}
				catch
				{
				}
			}
		}
	}

	private static void WriteMesLog(string direction, string messageType, string content)
	{
		try
		{
			var logDir = Path.Combine(Environment.CurrentDirectory, "data", "logs");
			Directory.CreateDirectory(logDir);

			var logFile = Path.Combine(logDir, $"MES-{DateTime.Now:yyyyMMdd}.txt");
			var normalizedContent = content
				.Replace("\r\n", Environment.NewLine)
				.Replace("\n", Environment.NewLine)
				.Replace("\r", Environment.NewLine);
			var text =
				$"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{direction}] [{messageType}]{Environment.NewLine}{normalizedContent}{Environment.NewLine}{Environment.NewLine}";

			lock (MesLogFileLock)
			{
				File.AppendAllText(logFile, text, System.Text.Encoding.UTF8);
			}
		}
		catch
		{
		}
	}
}