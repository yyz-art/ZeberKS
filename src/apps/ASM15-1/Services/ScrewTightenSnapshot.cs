using ZC.BinStructs;
using ZC.DP.Memory;
using ZC.Mvvm;
using ZitApp.BinStructs;

namespace ZitApp.Services;

[ObservableObject]
public partial class ScrewTightenSnapshot
{
	public partial int ScrewNo { get; set; }
	public partial double MaxTorque { get; set; }
	public partial double Turns { get; set; }
	public partial string Sn1 { get; set; } = "";
	public partial string Sn2 { get; set; } = "";
	public partial DateTime CollectedAt { get; set; }
	public partial bool HasValue { get; set; }
	public partial string StateText { get; set; } = "";
}

internal static class WorkScrewSignalPoints
{
	public static readonly IBinaryPointInfo LeftScrewFinishedSignal = new BinaryPointInfo
	{
		Offset = 22075,
		Name = nameof(PlcStruct.工位1螺丝拧紧完成信号),
		Type = typeof(short),
		ByteLength = 2,
		ByteFormat = ByteFormat.CDAB,
		RawType = typeof(short),
		Source = "22075",
		ReaderData = "PLC",
		WriterData = "PLC",
		Tags = "交互信号PLC->PC",
	};

	public static readonly IBinaryPointInfo RightScrewFinishedSignal = new BinaryPointInfo
	{
		Offset = 22076,
		Name = nameof(PlcStruct.工位2螺丝拧紧完成信号),
		Type = typeof(short),
		ByteLength = 2,
		ByteFormat = ByteFormat.CDAB,
		RawType = typeof(short),
		Source = "22076",
		ReaderData = "PLC",
		WriterData = "PLC",
		Tags = "交互信号PLC->PC",
	};
}
