using ZC.BinStructs;

namespace ZitApp.Devices.Screw;

[BinaryStruct(Length = 6, LengthUnit = 2)]
public partial class LoosenData
{
	[BinaryPoint(Offset = 0)] public ushort 拧松行程Step0 { get; set; }
	[BinaryPoint(Offset = 1)] public ushort 拧松速度Step0 { get; set; }
	[BinaryPoint(Offset = 5)] public ushort 拧松行程Step1 { get; set; }
	[BinaryPoint(Offset = 6)] public ushort 拧松速度Step1 { get; set; }
}