

using ZC.BinStructs;

namespace ZitApp.Devices.Screw;
[BinaryStruct(Length = 2, LengthUnit = 2)]
public partial class FreeRotationData
{
	[BinaryPoint(Offset = 0)]
	public ushort 自由行程Step0 { get; set; }
	[BinaryPoint(Offset = 1)]
	public ushort 自由速度Step0 { get; set; }

}