using ZC.DP.Number;
using ZC.IO;
using ZC.LOG;

namespace ZitApp.Services;


public abstract class WorkServiceBase : MainTaskService
{
	public static readonly byte[] StartScanCommandBytes = HexUtils.Parse("04 E4 04 00 FF 14");
	public static readonly byte[] StartScanResponseBytes = HexUtils.Parse("04 D0 00 00 FF 2C");
	public static readonly byte[] StopScanCommandBytes = HexUtils.Parse("04 E5 04 00 FF 13");
	public const int CodeOfOK = 1;
	public const int CodeOfNG = 2;
	public required IDataSocket Socket { get; init; }
	public required ILogger Logger { get; init; }


	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

}