using Oinet;
using Oinet.BinStructs;
using Oinet.DP.Memory;
using Oinet.Mvvm;

namespace OinetApp.Ext.BinStructs;

[BinaryStruct(Length = 201)]
[BinaryPointGroup(Name = "All", Start = 0, End = 90)]
public partial class PlcStruct : ObservableObject
{
	public IMemoryClient? MemoryClient { get; set; }

	[BinaryPoint(Offset = 0, ByteLength = 2, RawTo = "value * 10", ToRaw = "value / 10")]
	public int Id { get; set; }

	[BinaryPoint(Offset = 15)] public BitBool IsOpen { get; set; } = new(1);

	[BinaryPoint(Offset = 0, RawTo = "value * 10", ToRaw = "value / 10")]
	public int Id2 { get; set; }

	[BinaryPoint(Offset = 15)] public ByteFormat ByteFormat { get; set; }
	[BinaryPoint(Offset = 15)] public ByteFormat ByteFormat1 { get; set; }

	
}

[BinaryStruct(Length = 10, LengthUnit = 1)]
public partial class MyData
{
	[BinaryPoint(Offset = 0)] public short SerialNo { get; set; }
	[BinaryPoint(Offset = 2)] public double Temperature { get; set; }
}