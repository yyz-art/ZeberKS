using ZC.BinStructs;

namespace ZitApp.Devices.Screw;

[BinaryStruct(Length = 8, LengthUnit = 2)]
public partial class TightenData
{
	[BinaryPoint(Offset = 0)]
	public ushort 拧紧圈数Step0 { get; set; }
	[BinaryPoint(Offset = 1)]
	public ushort 拧紧速度Step0 { get; set; }
	[BinaryPoint(Offset = 5)]
	public ushort 拧紧圈数Step1 { get; set; }
	[BinaryPoint(Offset = 6)]
	public ushort 拧紧速度Step1 { get; set; }
	[BinaryPoint(Offset = 10)]
	public ushort 拧紧圈数Step2 { get; set; }
	[BinaryPoint(Offset = 11)]
	public ushort 拧紧速度Step2 { get; set; }
	[BinaryPoint(Offset = 15)]
	public ushort 拧紧圈数Step3 { get; set; }
	[BinaryPoint(Offset = 16)]
	public ushort 拧紧速度Step3 { get; set; }
}