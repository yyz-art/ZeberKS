#if ASM15_1
using System.Net.Sockets;
using NLog;
using ZC;
using ZC.Mvvm;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
[ObservableObject]
public partial class Asm15CalibrationService : MainTaskService
{
	private static readonly Logger Logger = LogManager.GetLogger("ASM15-CALIBRATION");

	/// <summary>Modbus TCP 读保持寄存器请求：地址 0x0002，数量 1</summary>
	private static readonly byte[] SendBuffer = [0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x02, 0x00, 0x01];
	private const int ResponseLength = 11;
	private const int ReconnectDelayMs = 10_000;
	private const int PollIntervalMs = 1_000;
	private const int ReceiveTimeoutMs = 3_000;

	public required AppConfig AppConfig { get; init; }

	public partial bool IsConnected { get; set; }
	public partial bool IsCalibrationOk { get; set; }
	public partial bool CalibrationCheckEnabled { get; set; } = true;
	public partial DateTime CalibrationCompleteTime { get; set; }

	partial void OnCalibrationCheckEnabledChanged(bool value)
	{
		if (value)
			Logger.Info("[CALIBRATION] calibration check enabled");
		else
			Logger.Warn("[CALIBRATION] calibration check disabled — production will NOT be gated");
	}

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected override async Task Main(CancellationToken ctk)
	{
		bool wasConnected = false;

		while (!ctk.IsCancellationRequested)
		{
			try
			{
				using var client = new TcpClient();
				await client.ConnectAsync(AppConfig.Asm15CalibrationIpAddress, AppConfig.Asm15CalibrationPort, ctk);
				IsConnected = true;
				wasConnected = true;
				Logger.Info("[CALIBRATION] connected to {ip}:{port}", AppConfig.Asm15CalibrationIpAddress, AppConfig.Asm15CalibrationPort);

				var stream = client.GetStream();

				while (!ctk.IsCancellationRequested && client.Connected)
				{
					try
					{
						await stream.WriteAsync(SendBuffer, ctk);

						var recvBuffer = new byte[ResponseLength];
						using (var cts = CancellationTokenSource.CreateLinkedTokenSource(ctk))
						{
							cts.CancelAfter(ReceiveTimeoutMs);

							int totalRead = 0;
							while (totalRead < ResponseLength)
							{
								int bytesRead = await stream.ReadAsync(recvBuffer.AsMemory(totalRead, ResponseLength - totalRead), cts.Token);
								if (bytesRead == 0) throw new IOException("connection closed");
								totalRead += bytesRead;
							}
						}

						ushort registerValue = (ushort)((recvBuffer[9] << 8) | recvBuffer[10]);
						switch (registerValue)
						{
							case 0x0000:
								break;
							case 0x0001:
								CalibrationCompleteTime = DateTime.Now;
								IsCalibrationOk = true;
								Logger.Info("[CALIBRATION] OK at {time}", CalibrationCompleteTime);
								break;
							case 0x0002:
								IsCalibrationOk = false;
								Logger.Warn("[CALIBRATION] FAILED");
								break;
							default:
								Logger.Warn("[CALIBRATION] unexpected register: 0x{val:X4}", registerValue);
								break;
						}
					}
					catch (OperationCanceledException) when (!ctk.IsCancellationRequested)
					{
						// 接收超时，静默跳过本轮
					}
					catch (IOException) { throw; }
					catch (SocketException) { throw; }

					await Task.Delay(PollIntervalMs, ctk);
				}
			}
			catch (OperationCanceledException) when (ctk.IsCancellationRequested)
			{
				break;
			}
			catch (Exception ex) when (ex is IOException or SocketException)
			{
				if (wasConnected)
				{
					IsConnected = false;
					wasConnected = false;
					Logger.Warn("[CALIBRATION] disconnected, will retry in 10s");
				}
				await Task.Delay(ReconnectDelayMs, ctk);
			}
		}
	}
}
#endif
