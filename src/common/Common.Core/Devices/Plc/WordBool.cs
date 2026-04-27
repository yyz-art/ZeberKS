using ZC.BinStructs;

namespace ZitApp.Devices.Plc;
// [BinaryStruct(Length = 1, LengthUnit = 2)]
// public partial class WordBool
// {
// 	public static readonly WordBool True = new() { Data = 0xFF };
// 	public static readonly byte[] TrueBytes = [0x00, 0xFF];
// 	public static readonly byte[] FalseBytes = [0x00, 0x00];
// 	public static readonly WordBool False = new() { Data = 0 };
// 	[BinaryPoint(Offset = 0)] public ushort Data { get; set; }
// 	public override string ToString() => Data >= True.Data ? "true" : "false";
// 	public static implicit operator bool(WordBool w) => w.Data >= True.Data;
// 	public static implicit operator WordBool(bool v) => v ? True : False;
// }

public enum WordBool : ushort
{
	True = 0xFFFF,
	False = 0
}

public static class WordBoolExtensions
{
	public static readonly byte[] TrueBytes = BitConverter.GetBytes((ushort)WordBool.True);
	public static readonly byte[] FalseBytes = BitConverter.GetBytes((ushort)WordBool.False);
}