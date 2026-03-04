using System.Text;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.LOG;
using ZitApp.BinStructs;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Transient)]
// [RegisterToTaskService(TaskStartMode.Automatic)]
public class ScanLeftCodeService : ScanCodeServiceBase
{
	public override string ServiceName => "ScanLeftCodeService";
	public required PlcService Plc { get; init; }
	private byte[] _buffer = new byte[1024];

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;
	protected override Task Main(CancellationToken ctk)
	{
		Span<char> charBuffer = stackalloc char[1024];
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
			// 复位
			if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
			{
				Plc.Write.扫码枪1触发结果 = 0;
				Plc.Write.WritePoint(PlcStructStructInfo.扫码枪1触发结果).Unwarp("Clear left scanner result failed!");
				continue;
			}

			if (Plc.Read.扫码枪1触发 != 1) continue;
			Socket.ReadToDiscard().Unwarp("Clear left scanner cache failed!");
			Socket.Write(StartScanCommandBytes).Unwarp("Send left scanner scan command failed!");
			var readLength = Socket.ReadContinuous(_buffer, 2000, 200).Unwarp("Read scan result");
			// OK: start with "04 D0 00 00 FF 2C{code}"
			if (false == _buffer.StartsWith(StartScanResponseBytes))
			{
				var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
				Logger.Error("Start scan command response data is error! {}", responseHex);
				goto SendNG;
			}

			var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length, readLength - StartScanResponseBytes.Length);
			if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
			{
				var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
				Logger.Error("Start scan command response code is error! {}", responseHex);
				goto SendNG;
			}

			var code = charBuffer.Slice(0, codeLength).ToString();
			Logger.Info("Scanned code is '{code}'", code);

			SendOK:
			Plc.Write.扫码枪1触发结果 = CodeOfOK;
			Plc.Write.WritePoint(PlcStructStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
			continue;
			SendNG:
			Plc.Write.扫码枪1触发结果 = CodeOfNG;
			Plc.Write.WritePoint(PlcStructStructInfo.扫码枪1触发结果).Unwarp("write left scanner scan result failed!");
			continue;
		}

		return Task.CompletedTask;
	}
	
}