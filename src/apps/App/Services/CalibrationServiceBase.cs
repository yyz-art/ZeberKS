#if ASM15_1
using System.Net.Sockets;
using NLog;
using ZC;
using ZC.Mvvm;

namespace ZitApp.Services;

[ObservableObject]
public abstract partial class CalibrationServiceBase : MainTaskService
{
	private static readonly Logger Logger = LogManager.GetLogger("CALIBRATION");
	private static readonly byte[] SendBuffer = [0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x02, 0x00, 0x01];
	private const int ResponseLength = 11;
	private const int ReconnectDelayMs = 10_000;
	private const int PollIntervalMs = 1_000;
	private const int ReceiveTimeoutMs = 3_000;

	private readonly byte[] _recvBuffer = new byte[ResponseLength];
	private readonly CancellationTokenSource _receiveCts = new();

	public partial bool IsConnected { get; set; }
	public partial bool IsCalibrationOk { get; set; }
	public partial bool CalibrationCheckEnabled { get; set; } = true;
	public partial DateTime CalibrationCompleteTime { get; set; }

	protected abstract string CalibrationIp { get; }
	protected abstract int CalibrationPort { get; }

	partial void OnCalibrationCheckEnabledChanged(bool value) =>
		Logger.Info("[CALIBRATION] calibration check {status}", value ? "enabled" : "disabled");

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected override async Task Main(CancellationToken ctk)
	{
		var wasConnected = false;

		while (!ctk.IsCancellationRequested)
		{
			try
			{
				using var client = new TcpClient();
				await client.ConnectAsync(CalibrationIp, CalibrationPort, ctk);
				IsConnected = true;
				wasConnected = true;
				Logger.Info("[CALIBRATION] connected to {ip}:{port}", CalibrationIp, CalibrationPort);

				var stream = client.GetStream();
				while (!ctk.IsCancellationRequested && client.Connected)
				{
					try
					{
						await stream.WriteAsync(SendBuffer.AsMemory(), ctk);
						_receiveCts.CancelAfter(ReceiveTimeoutMs);

						int totalRead = 0;
						while (totalRead < ResponseLength)
						{
							var bytesRead = await stream.ReadAsync(_recvBuffer.AsMemory(totalRead, ResponseLength - totalRead), _receiveCts.Token);
							if (bytesRead == 0) throw new IOException("connection closed");
							totalRead += bytesRead;
						}

						var registerValue = (ushort)((_recvBuffer[9] << 8) | _recvBuffer[10]);
						switch (registerValue)
						{
							case 0x0001:
								CalibrationCompleteTime = DateTime.Now;
								IsCalibrationOk = true;
								Logger.Info("[CALIBRATION] OK at {time}", CalibrationCompleteTime);
								break;
							case 0x0002:
								IsCalibrationOk = false;
								Logger.Warn("[CALIBRATION] FAILED");
								break;
							case > 0x0002:
								Logger.Warn("[CALIBRATION] unexpected register: 0x{val:X4}", registerValue);
								break;
						}
					}
					catch (OperationCanceledException) when (!ctk.IsCancellationRequested)
					{
						Logger.Debug("[CALIBRATION] receive timeout");
					}

					await Task.Delay(PollIntervalMs, ctk);
				}
			}
			catch (OperationCanceledException) when (ctk.IsCancellationRequested)
			{
				break;
			}
			catch (Exception ex) when (ex is IOException or SocketException)
			{
				Logger.Warn(ex, "[CALIBRATION] {action}, will retry in 10s", wasConnected ? "disconnected" : "connect failed");
				IsConnected = false;
				wasConnected = false;
				await Task.Delay(ReconnectDelayMs, ctk);
			}
		}
	}
}
#endif
