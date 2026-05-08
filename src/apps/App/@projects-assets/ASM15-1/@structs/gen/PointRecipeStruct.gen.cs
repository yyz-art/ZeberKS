
// GENERATE AT 2026/5/8 19:34:25
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
public partial class PointRecipeStruct
{

	#region CSV INCLUDE POINTS: PLC

	[BinaryPoint(Offset = 43000, Source = "43000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43000", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_0", ])]
	public float 信捷Z1轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 43002, Source = "43002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43002", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_1", ])]
	public float 信捷Z1轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 43004, Source = "43004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43004", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_2", ])]
	public float 信捷Z1轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 43006, Source = "43006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43006", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_3", ])]
	public float 信捷Z1轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 43008, Source = "43008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43008", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_4", ])]
	public float 信捷Z1轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 43010, Source = "43010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43010", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_5", ])]
	public float 信捷Z1轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 43012, Source = "43012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43012", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_6", ])]
	public float 信捷Z1轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 43014, Source = "43014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43014", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_7", ])]
	public float 信捷Z1轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 43016, Source = "43016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43016", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_8", ])]
	public float 信捷Z1轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 43018, Source = "43018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43018", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_9", ])]
	public float 信捷Z1轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 43020, Source = "43020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43020", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_10", ])]
	public float 信捷Z1轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 43022, Source = "43022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43022", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_11", ])]
	public float 信捷Z1轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 43024, Source = "43024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43024", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_12", ])]
	public float 信捷Z1轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 43026, Source = "43026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43026", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_13", ])]
	public float 信捷Z1轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 43028, Source = "43028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43028", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_14", ])]
	public float 信捷Z1轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 43030, Source = "43030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43030", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_15", ])]
	public float 信捷Z1轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 43032, Source = "43032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43032", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_16", ])]
	public float 信捷Z1轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 43034, Source = "43034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43034", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_17", ])]
	public float 信捷Z1轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 43036, Source = "43036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43036", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_18", ])]
	public float 信捷Z1轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 43038, Source = "43038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43038", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_19", ])]
	public float 信捷Z1轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 43040, Source = "43040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43040", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_20", ])]
	public float 信捷Z1轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 43042, Source = "43042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43042", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_21", ])]
	public float 信捷Z1轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 43044, Source = "43044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43044", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_22", ])]
	public float 信捷Z1轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 43046, Source = "43046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43046", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_23", ])]
	public float 信捷Z1轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 43048, Source = "43048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43048", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_24", ])]
	public float 信捷Z1轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 43050, Source = "43050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43050", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_25", ])]
	public float 信捷Z1轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 43052, Source = "43052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43052", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_26", ])]
	public float 信捷Z1轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 43054, Source = "43054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43054", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_27", ])]
	public float 信捷Z1轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 43056, Source = "43056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43056", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_28", ])]
	public float 信捷Z1轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 43058, Source = "43058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43058", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_29", ])]
	public float 信捷Z1轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 43060, Source = "43060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43060", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_30", ])]
	public float 信捷Z1轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 43062, Source = "43062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43062", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_31", ])]
	public float 信捷Z1轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 43064, Source = "43064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43064", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_32", ])]
	public float 信捷Z1轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 43066, Source = "43066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43066", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_33", ])]
	public float 信捷Z1轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 43068, Source = "43068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43068", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_34", ])]
	public float 信捷Z1轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 43070, Source = "43070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43070", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_35", ])]
	public float 信捷Z1轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 43072, Source = "43072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43072", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_36", ])]
	public float 信捷Z1轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 43074, Source = "43074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43074", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_37", ])]
	public float 信捷Z1轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 43076, Source = "43076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43076", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_38", ])]
	public float 信捷Z1轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 43078, Source = "43078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43078", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_39", ])]
	public float 信捷Z1轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 43080, Source = "43080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43080", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_40", ])]
	public float 信捷Z1轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 43082, Source = "43082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43082", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_41", ])]
	public float 信捷Z1轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 43084, Source = "43084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43084", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_42", ])]
	public float 信捷Z1轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 43086, Source = "43086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43086", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_43", ])]
	public float 信捷Z1轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 43088, Source = "43088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43088", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_44", ])]
	public float 信捷Z1轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 43090, Source = "43090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43090", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_45", ])]
	public float 信捷Z1轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 43092, Source = "43092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43092", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_46", ])]
	public float 信捷Z1轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 43094, Source = "43094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43094", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_47", ])]
	public float 信捷Z1轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 43096, Source = "43096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43096", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_48", ])]
	public float 信捷Z1轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 43098, Source = "43098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43098", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_49", ])]
	public float 信捷Z1轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 43100, Source = "43100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43100", Category = "PLC/信捷Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 XINJE_V? trí_PC_50", ])]
	public float 信捷Z1轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 43200, Source = "43200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43200", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_0", ])]
	public float 信捷Z2轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 43202, Source = "43202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43202", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_1", ])]
	public float 信捷Z2轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 43204, Source = "43204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43204", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_2", ])]
	public float 信捷Z2轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 43206, Source = "43206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43206", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_3", ])]
	public float 信捷Z2轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 43208, Source = "43208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43208", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_4", ])]
	public float 信捷Z2轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 43210, Source = "43210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43210", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_5", ])]
	public float 信捷Z2轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 43212, Source = "43212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43212", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_6", ])]
	public float 信捷Z2轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 43214, Source = "43214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43214", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_7", ])]
	public float 信捷Z2轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 43216, Source = "43216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43216", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_8", ])]
	public float 信捷Z2轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 43218, Source = "43218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43218", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_9", ])]
	public float 信捷Z2轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 43220, Source = "43220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43220", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_10", ])]
	public float 信捷Z2轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 43222, Source = "43222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43222", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_11", ])]
	public float 信捷Z2轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 43224, Source = "43224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43224", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_12", ])]
	public float 信捷Z2轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 43226, Source = "43226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43226", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_13", ])]
	public float 信捷Z2轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 43228, Source = "43228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43228", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_14", ])]
	public float 信捷Z2轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 43230, Source = "43230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43230", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_15", ])]
	public float 信捷Z2轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 43232, Source = "43232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43232", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_16", ])]
	public float 信捷Z2轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 43234, Source = "43234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43234", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_17", ])]
	public float 信捷Z2轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 43236, Source = "43236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43236", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_18", ])]
	public float 信捷Z2轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 43238, Source = "43238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43238", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_19", ])]
	public float 信捷Z2轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 43240, Source = "43240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43240", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_20", ])]
	public float 信捷Z2轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 43242, Source = "43242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43242", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_21", ])]
	public float 信捷Z2轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 43244, Source = "43244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43244", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_22", ])]
	public float 信捷Z2轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 43246, Source = "43246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43246", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_23", ])]
	public float 信捷Z2轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 43248, Source = "43248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43248", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_24", ])]
	public float 信捷Z2轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 43250, Source = "43250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43250", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_25", ])]
	public float 信捷Z2轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 43252, Source = "43252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43252", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_26", ])]
	public float 信捷Z2轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 43254, Source = "43254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43254", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_27", ])]
	public float 信捷Z2轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 43256, Source = "43256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43256", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_28", ])]
	public float 信捷Z2轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 43258, Source = "43258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43258", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_29", ])]
	public float 信捷Z2轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 43260, Source = "43260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43260", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_30", ])]
	public float 信捷Z2轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 43262, Source = "43262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43262", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_31", ])]
	public float 信捷Z2轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 43264, Source = "43264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43264", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_32", ])]
	public float 信捷Z2轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 43266, Source = "43266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43266", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_33", ])]
	public float 信捷Z2轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 43268, Source = "43268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43268", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_34", ])]
	public float 信捷Z2轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 43270, Source = "43270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43270", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_35", ])]
	public float 信捷Z2轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 43272, Source = "43272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43272", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_36", ])]
	public float 信捷Z2轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 43274, Source = "43274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43274", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_37", ])]
	public float 信捷Z2轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 43276, Source = "43276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43276", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_38", ])]
	public float 信捷Z2轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 43278, Source = "43278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43278", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_39", ])]
	public float 信捷Z2轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 43280, Source = "43280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43280", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_40", ])]
	public float 信捷Z2轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 43282, Source = "43282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43282", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_41", ])]
	public float 信捷Z2轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 43284, Source = "43284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43284", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_42", ])]
	public float 信捷Z2轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 43286, Source = "43286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43286", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_43", ])]
	public float 信捷Z2轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 43288, Source = "43288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43288", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_44", ])]
	public float 信捷Z2轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 43290, Source = "43290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43290", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_45", ])]
	public float 信捷Z2轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 43292, Source = "43292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43292", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_46", ])]
	public float 信捷Z2轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 43294, Source = "43294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43294", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_47", ])]
	public float 信捷Z2轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 43296, Source = "43296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43296", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_48", ])]
	public float 信捷Z2轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 43298, Source = "43298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43298", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_49", ])]
	public float 信捷Z2轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 43300, Source = "43300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43300", Category = "PLC/信捷Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 XINJE_V? trí_PC_50", ])]
	public float 信捷Z2轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 43400, Source = "43400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43400", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_0", ])]
	public float 信捷X1轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 43402, Source = "43402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43402", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_1", ])]
	public float 信捷X1轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 43404, Source = "43404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43404", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_2", ])]
	public float 信捷X1轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 43406, Source = "43406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43406", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_3", ])]
	public float 信捷X1轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 43408, Source = "43408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43408", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_4", ])]
	public float 信捷X1轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 43410, Source = "43410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43410", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_5", ])]
	public float 信捷X1轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 43412, Source = "43412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43412", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_6", ])]
	public float 信捷X1轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 43414, Source = "43414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43414", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_7", ])]
	public float 信捷X1轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 43416, Source = "43416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43416", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_8", ])]
	public float 信捷X1轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 43418, Source = "43418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43418", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_9", ])]
	public float 信捷X1轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 43420, Source = "43420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43420", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_10", ])]
	public float 信捷X1轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 43422, Source = "43422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43422", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_11", ])]
	public float 信捷X1轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 43424, Source = "43424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43424", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_12", ])]
	public float 信捷X1轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 43426, Source = "43426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43426", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_13", ])]
	public float 信捷X1轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 43428, Source = "43428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43428", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_14", ])]
	public float 信捷X1轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 43430, Source = "43430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43430", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_15", ])]
	public float 信捷X1轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 43432, Source = "43432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43432", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_16", ])]
	public float 信捷X1轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 43434, Source = "43434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43434", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_17", ])]
	public float 信捷X1轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 43436, Source = "43436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43436", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_18", ])]
	public float 信捷X1轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 43438, Source = "43438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43438", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_19", ])]
	public float 信捷X1轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 43440, Source = "43440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43440", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_20", ])]
	public float 信捷X1轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 43442, Source = "43442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43442", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_21", ])]
	public float 信捷X1轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 43444, Source = "43444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43444", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_22", ])]
	public float 信捷X1轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 43446, Source = "43446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43446", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_23", ])]
	public float 信捷X1轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 43448, Source = "43448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43448", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_24", ])]
	public float 信捷X1轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 43450, Source = "43450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43450", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_25", ])]
	public float 信捷X1轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 43452, Source = "43452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43452", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_26", ])]
	public float 信捷X1轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 43454, Source = "43454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43454", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_27", ])]
	public float 信捷X1轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 43456, Source = "43456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43456", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_28", ])]
	public float 信捷X1轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 43458, Source = "43458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43458", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_29", ])]
	public float 信捷X1轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 43460, Source = "43460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43460", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_30", ])]
	public float 信捷X1轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 43462, Source = "43462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43462", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_31", ])]
	public float 信捷X1轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 43464, Source = "43464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43464", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_32", ])]
	public float 信捷X1轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 43466, Source = "43466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43466", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_33", ])]
	public float 信捷X1轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 43468, Source = "43468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43468", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_34", ])]
	public float 信捷X1轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 43470, Source = "43470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43470", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_35", ])]
	public float 信捷X1轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 43472, Source = "43472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43472", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_36", ])]
	public float 信捷X1轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 43474, Source = "43474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43474", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_37", ])]
	public float 信捷X1轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 43476, Source = "43476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43476", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_38", ])]
	public float 信捷X1轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 43478, Source = "43478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43478", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_39", ])]
	public float 信捷X1轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 43480, Source = "43480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43480", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_40", ])]
	public float 信捷X1轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 43482, Source = "43482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43482", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_41", ])]
	public float 信捷X1轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 43484, Source = "43484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43484", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_42", ])]
	public float 信捷X1轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 43486, Source = "43486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43486", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_43", ])]
	public float 信捷X1轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 43488, Source = "43488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43488", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_44", ])]
	public float 信捷X1轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 43490, Source = "43490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43490", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_45", ])]
	public float 信捷X1轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 43492, Source = "43492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43492", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_46", ])]
	public float 信捷X1轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 43494, Source = "43494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43494", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_47", ])]
	public float 信捷X1轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 43496, Source = "43496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43496", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_48", ])]
	public float 信捷X1轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 43498, Source = "43498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43498", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_49", ])]
	public float 信捷X1轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 43500, Source = "43500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43500", Category = "PLC/信捷X1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 XINJE_V? trí_PC_50", ])]
	public float 信捷X1轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 43600, Source = "43600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43600", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_0", ])]
	public float 信捷X2轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 43602, Source = "43602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43602", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_1", ])]
	public float 信捷X2轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 43604, Source = "43604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43604", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_2", ])]
	public float 信捷X2轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 43606, Source = "43606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43606", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_3", ])]
	public float 信捷X2轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 43608, Source = "43608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43608", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_4", ])]
	public float 信捷X2轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 43610, Source = "43610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43610", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_5", ])]
	public float 信捷X2轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 43612, Source = "43612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43612", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_6", ])]
	public float 信捷X2轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 43614, Source = "43614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43614", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_7", ])]
	public float 信捷X2轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 43616, Source = "43616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43616", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_8", ])]
	public float 信捷X2轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 43618, Source = "43618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43618", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_9", ])]
	public float 信捷X2轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 43620, Source = "43620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43620", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_10", ])]
	public float 信捷X2轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 43622, Source = "43622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43622", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_11", ])]
	public float 信捷X2轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 43624, Source = "43624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43624", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_12", ])]
	public float 信捷X2轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 43626, Source = "43626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43626", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_13", ])]
	public float 信捷X2轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 43628, Source = "43628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43628", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_14", ])]
	public float 信捷X2轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 43630, Source = "43630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43630", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_15", ])]
	public float 信捷X2轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 43632, Source = "43632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43632", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_16", ])]
	public float 信捷X2轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 43634, Source = "43634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43634", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_17", ])]
	public float 信捷X2轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 43636, Source = "43636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43636", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_18", ])]
	public float 信捷X2轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 43638, Source = "43638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43638", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_19", ])]
	public float 信捷X2轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 43640, Source = "43640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43640", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_20", ])]
	public float 信捷X2轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 43642, Source = "43642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43642", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_21", ])]
	public float 信捷X2轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 43644, Source = "43644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43644", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_22", ])]
	public float 信捷X2轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 43646, Source = "43646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43646", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_23", ])]
	public float 信捷X2轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 43648, Source = "43648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43648", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_24", ])]
	public float 信捷X2轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 43650, Source = "43650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43650", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_25", ])]
	public float 信捷X2轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 43652, Source = "43652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43652", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_26", ])]
	public float 信捷X2轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 43654, Source = "43654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43654", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_27", ])]
	public float 信捷X2轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 43656, Source = "43656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43656", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_28", ])]
	public float 信捷X2轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 43658, Source = "43658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43658", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_29", ])]
	public float 信捷X2轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 43660, Source = "43660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43660", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_30", ])]
	public float 信捷X2轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 43662, Source = "43662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43662", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_31", ])]
	public float 信捷X2轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 43664, Source = "43664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43664", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_32", ])]
	public float 信捷X2轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 43666, Source = "43666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43666", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_33", ])]
	public float 信捷X2轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 43668, Source = "43668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43668", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_34", ])]
	public float 信捷X2轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 43670, Source = "43670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43670", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_35", ])]
	public float 信捷X2轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 43672, Source = "43672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43672", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_36", ])]
	public float 信捷X2轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 43674, Source = "43674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43674", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_37", ])]
	public float 信捷X2轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 43676, Source = "43676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43676", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_38", ])]
	public float 信捷X2轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 43678, Source = "43678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43678", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_39", ])]
	public float 信捷X2轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 43680, Source = "43680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43680", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_40", ])]
	public float 信捷X2轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 43682, Source = "43682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43682", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_41", ])]
	public float 信捷X2轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 43684, Source = "43684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43684", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_42", ])]
	public float 信捷X2轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 43686, Source = "43686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43686", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_43", ])]
	public float 信捷X2轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 43688, Source = "43688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43688", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_44", ])]
	public float 信捷X2轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 43690, Source = "43690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43690", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_45", ])]
	public float 信捷X2轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 43692, Source = "43692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43692", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_46", ])]
	public float 信捷X2轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 43694, Source = "43694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43694", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_47", ])]
	public float 信捷X2轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 43696, Source = "43696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43696", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_48", ])]
	public float 信捷X2轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 43698, Source = "43698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43698", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_49", ])]
	public float 信捷X2轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 43700, Source = "43700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43700", Category = "PLC/信捷X2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 XINJE_V? trí_PC_50", ])]
	public float 信捷X2轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 43800, Source = "43800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43800", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_0", ])]
	public float 信捷Y1轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 43802, Source = "43802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43802", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_1", ])]
	public float 信捷Y1轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 43804, Source = "43804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43804", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_2", ])]
	public float 信捷Y1轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 43806, Source = "43806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43806", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_3", ])]
	public float 信捷Y1轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 43808, Source = "43808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43808", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_4", ])]
	public float 信捷Y1轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 43810, Source = "43810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43810", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_5", ])]
	public float 信捷Y1轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 43812, Source = "43812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43812", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_6", ])]
	public float 信捷Y1轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 43814, Source = "43814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43814", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_7", ])]
	public float 信捷Y1轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 43816, Source = "43816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43816", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_8", ])]
	public float 信捷Y1轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 43818, Source = "43818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43818", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_9", ])]
	public float 信捷Y1轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 43820, Source = "43820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43820", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_10", ])]
	public float 信捷Y1轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 43822, Source = "43822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43822", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_11", ])]
	public float 信捷Y1轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 43824, Source = "43824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43824", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_12", ])]
	public float 信捷Y1轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 43826, Source = "43826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43826", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_13", ])]
	public float 信捷Y1轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 43828, Source = "43828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43828", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_14", ])]
	public float 信捷Y1轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 43830, Source = "43830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43830", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_15", ])]
	public float 信捷Y1轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 43832, Source = "43832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43832", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_16", ])]
	public float 信捷Y1轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 43834, Source = "43834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43834", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_17", ])]
	public float 信捷Y1轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 43836, Source = "43836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43836", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_18", ])]
	public float 信捷Y1轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 43838, Source = "43838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43838", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_19", ])]
	public float 信捷Y1轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 43840, Source = "43840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43840", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_20", ])]
	public float 信捷Y1轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 43842, Source = "43842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43842", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_21", ])]
	public float 信捷Y1轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 43844, Source = "43844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43844", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_22", ])]
	public float 信捷Y1轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 43846, Source = "43846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43846", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_23", ])]
	public float 信捷Y1轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 43848, Source = "43848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43848", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_24", ])]
	public float 信捷Y1轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 43850, Source = "43850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43850", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_25", ])]
	public float 信捷Y1轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 43852, Source = "43852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43852", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_26", ])]
	public float 信捷Y1轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 43854, Source = "43854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43854", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_27", ])]
	public float 信捷Y1轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 43856, Source = "43856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43856", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_28", ])]
	public float 信捷Y1轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 43858, Source = "43858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43858", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_29", ])]
	public float 信捷Y1轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 43860, Source = "43860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43860", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_30", ])]
	public float 信捷Y1轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 43862, Source = "43862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43862", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_31", ])]
	public float 信捷Y1轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 43864, Source = "43864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43864", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_32", ])]
	public float 信捷Y1轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 43866, Source = "43866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43866", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_33", ])]
	public float 信捷Y1轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 43868, Source = "43868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43868", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_34", ])]
	public float 信捷Y1轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 43870, Source = "43870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43870", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_35", ])]
	public float 信捷Y1轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 43872, Source = "43872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43872", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_36", ])]
	public float 信捷Y1轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 43874, Source = "43874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43874", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_37", ])]
	public float 信捷Y1轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 43876, Source = "43876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43876", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_38", ])]
	public float 信捷Y1轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 43878, Source = "43878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43878", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_39", ])]
	public float 信捷Y1轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 43880, Source = "43880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43880", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_40", ])]
	public float 信捷Y1轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 43882, Source = "43882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43882", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_41", ])]
	public float 信捷Y1轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 43884, Source = "43884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43884", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_42", ])]
	public float 信捷Y1轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 43886, Source = "43886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43886", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_43", ])]
	public float 信捷Y1轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 43888, Source = "43888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43888", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_44", ])]
	public float 信捷Y1轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 43890, Source = "43890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43890", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_45", ])]
	public float 信捷Y1轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 43892, Source = "43892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43892", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_46", ])]
	public float 信捷Y1轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 43894, Source = "43894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43894", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_47", ])]
	public float 信捷Y1轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 43896, Source = "43896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43896", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_48", ])]
	public float 信捷Y1轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 43898, Source = "43898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43898", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_49", ])]
	public float 信捷Y1轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 43900, Source = "43900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:43900", Category = "PLC/信捷Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 XINJE_V? trí_PC_50", ])]
	public float 信捷Y1轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 44000, Source = "44000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44000", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_0", ])]
	public float 信捷Y2轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 44002, Source = "44002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44002", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_1", ])]
	public float 信捷Y2轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 44004, Source = "44004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44004", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_2", ])]
	public float 信捷Y2轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 44006, Source = "44006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44006", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_3", ])]
	public float 信捷Y2轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 44008, Source = "44008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44008", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_4", ])]
	public float 信捷Y2轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 44010, Source = "44010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44010", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_5", ])]
	public float 信捷Y2轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 44012, Source = "44012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44012", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_6", ])]
	public float 信捷Y2轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 44014, Source = "44014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44014", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_7", ])]
	public float 信捷Y2轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 44016, Source = "44016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44016", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_8", ])]
	public float 信捷Y2轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 44018, Source = "44018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44018", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_9", ])]
	public float 信捷Y2轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 44020, Source = "44020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44020", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_10", ])]
	public float 信捷Y2轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 44022, Source = "44022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44022", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_11", ])]
	public float 信捷Y2轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 44024, Source = "44024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44024", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_12", ])]
	public float 信捷Y2轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 44026, Source = "44026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44026", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_13", ])]
	public float 信捷Y2轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 44028, Source = "44028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44028", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_14", ])]
	public float 信捷Y2轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 44030, Source = "44030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44030", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_15", ])]
	public float 信捷Y2轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 44032, Source = "44032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44032", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_16", ])]
	public float 信捷Y2轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 44034, Source = "44034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44034", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_17", ])]
	public float 信捷Y2轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 44036, Source = "44036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44036", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_18", ])]
	public float 信捷Y2轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 44038, Source = "44038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44038", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_19", ])]
	public float 信捷Y2轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 44040, Source = "44040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44040", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_20", ])]
	public float 信捷Y2轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 44042, Source = "44042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44042", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_21", ])]
	public float 信捷Y2轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 44044, Source = "44044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44044", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_22", ])]
	public float 信捷Y2轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 44046, Source = "44046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44046", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_23", ])]
	public float 信捷Y2轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 44048, Source = "44048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44048", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_24", ])]
	public float 信捷Y2轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 44050, Source = "44050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44050", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_25", ])]
	public float 信捷Y2轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 44052, Source = "44052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44052", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_26", ])]
	public float 信捷Y2轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 44054, Source = "44054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44054", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_27", ])]
	public float 信捷Y2轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 44056, Source = "44056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44056", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_28", ])]
	public float 信捷Y2轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 44058, Source = "44058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44058", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_29", ])]
	public float 信捷Y2轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 44060, Source = "44060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44060", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_30", ])]
	public float 信捷Y2轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 44062, Source = "44062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44062", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_31", ])]
	public float 信捷Y2轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 44064, Source = "44064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44064", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_32", ])]
	public float 信捷Y2轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 44066, Source = "44066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44066", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_33", ])]
	public float 信捷Y2轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 44068, Source = "44068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44068", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_34", ])]
	public float 信捷Y2轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 44070, Source = "44070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44070", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_35", ])]
	public float 信捷Y2轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 44072, Source = "44072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44072", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_36", ])]
	public float 信捷Y2轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 44074, Source = "44074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44074", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_37", ])]
	public float 信捷Y2轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 44076, Source = "44076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44076", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_38", ])]
	public float 信捷Y2轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 44078, Source = "44078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44078", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_39", ])]
	public float 信捷Y2轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 44080, Source = "44080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44080", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_40", ])]
	public float 信捷Y2轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 44082, Source = "44082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44082", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_41", ])]
	public float 信捷Y2轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 44084, Source = "44084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44084", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_42", ])]
	public float 信捷Y2轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 44086, Source = "44086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44086", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_43", ])]
	public float 信捷Y2轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 44088, Source = "44088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44088", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_44", ])]
	public float 信捷Y2轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 44090, Source = "44090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44090", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_45", ])]
	public float 信捷Y2轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 44092, Source = "44092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44092", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_46", ])]
	public float 信捷Y2轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 44094, Source = "44094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44094", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_47", ])]
	public float 信捷Y2轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 44096, Source = "44096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44096", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_48", ])]
	public float 信捷Y2轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 44098, Source = "44098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44098", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_49", ])]
	public float 信捷Y2轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 44100, Source = "44100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44100", Category = "PLC/信捷Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 XINJE_V? trí_PC_50", ])]
	public float 信捷Y2轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 44200, Source = "44200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44200", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_0", ])]
	public float 雷赛步进Z1轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 44202, Source = "44202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44202", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_1", ])]
	public float 雷赛步进Z1轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 44204, Source = "44204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44204", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_2", ])]
	public float 雷赛步进Z1轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 44206, Source = "44206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44206", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_3", ])]
	public float 雷赛步进Z1轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 44208, Source = "44208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44208", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_4", ])]
	public float 雷赛步进Z1轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 44210, Source = "44210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44210", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_5", ])]
	public float 雷赛步进Z1轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 44212, Source = "44212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44212", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_6", ])]
	public float 雷赛步进Z1轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 44214, Source = "44214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44214", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_7", ])]
	public float 雷赛步进Z1轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 44216, Source = "44216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44216", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_8", ])]
	public float 雷赛步进Z1轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 44218, Source = "44218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44218", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_9", ])]
	public float 雷赛步进Z1轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 44220, Source = "44220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44220", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_10", ])]
	public float 雷赛步进Z1轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 44222, Source = "44222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44222", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_11", ])]
	public float 雷赛步进Z1轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 44224, Source = "44224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44224", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_12", ])]
	public float 雷赛步进Z1轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 44226, Source = "44226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44226", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_13", ])]
	public float 雷赛步进Z1轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 44228, Source = "44228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44228", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_14", ])]
	public float 雷赛步进Z1轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 44230, Source = "44230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44230", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_15", ])]
	public float 雷赛步进Z1轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 44232, Source = "44232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44232", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_16", ])]
	public float 雷赛步进Z1轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 44234, Source = "44234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44234", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_17", ])]
	public float 雷赛步进Z1轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 44236, Source = "44236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44236", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_18", ])]
	public float 雷赛步进Z1轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 44238, Source = "44238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44238", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_19", ])]
	public float 雷赛步进Z1轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 44240, Source = "44240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44240", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_20", ])]
	public float 雷赛步进Z1轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 44242, Source = "44242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44242", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_21", ])]
	public float 雷赛步进Z1轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 44244, Source = "44244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44244", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_22", ])]
	public float 雷赛步进Z1轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 44246, Source = "44246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44246", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_23", ])]
	public float 雷赛步进Z1轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 44248, Source = "44248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44248", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_24", ])]
	public float 雷赛步进Z1轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 44250, Source = "44250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44250", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_25", ])]
	public float 雷赛步进Z1轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 44252, Source = "44252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44252", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_26", ])]
	public float 雷赛步进Z1轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 44254, Source = "44254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44254", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_27", ])]
	public float 雷赛步进Z1轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 44256, Source = "44256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44256", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_28", ])]
	public float 雷赛步进Z1轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 44258, Source = "44258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44258", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_29", ])]
	public float 雷赛步进Z1轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 44260, Source = "44260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44260", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_30", ])]
	public float 雷赛步进Z1轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 44262, Source = "44262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44262", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_31", ])]
	public float 雷赛步进Z1轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 44264, Source = "44264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44264", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_32", ])]
	public float 雷赛步进Z1轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 44266, Source = "44266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44266", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_33", ])]
	public float 雷赛步进Z1轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 44268, Source = "44268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44268", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_34", ])]
	public float 雷赛步进Z1轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 44270, Source = "44270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44270", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_35", ])]
	public float 雷赛步进Z1轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 44272, Source = "44272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44272", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_36", ])]
	public float 雷赛步进Z1轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 44274, Source = "44274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44274", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_37", ])]
	public float 雷赛步进Z1轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 44276, Source = "44276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44276", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_38", ])]
	public float 雷赛步进Z1轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 44278, Source = "44278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44278", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_39", ])]
	public float 雷赛步进Z1轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 44280, Source = "44280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44280", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_40", ])]
	public float 雷赛步进Z1轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 44282, Source = "44282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44282", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_41", ])]
	public float 雷赛步进Z1轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 44284, Source = "44284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44284", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_42", ])]
	public float 雷赛步进Z1轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 44286, Source = "44286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44286", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_43", ])]
	public float 雷赛步进Z1轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 44288, Source = "44288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44288", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_44", ])]
	public float 雷赛步进Z1轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 44290, Source = "44290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44290", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_45", ])]
	public float 雷赛步进Z1轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 44292, Source = "44292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44292", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_46", ])]
	public float 雷赛步进Z1轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 44294, Source = "44294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44294", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_47", ])]
	public float 雷赛步进Z1轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 44296, Source = "44296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44296", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_48", ])]
	public float 雷赛步进Z1轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 44298, Source = "44298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44298", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_49", ])]
	public float 雷赛步进Z1轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 44300, Source = "44300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44300", Category = "PLC/雷赛步进Z1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 LEADSHINE Stepper_V? trí_PC_50", ])]
	public float 雷赛步进Z1轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 44400, Source = "44400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44400", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_0", ])]
	public float 雷赛步进Z2轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 44402, Source = "44402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44402", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_1", ])]
	public float 雷赛步进Z2轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 44404, Source = "44404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44404", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_2", ])]
	public float 雷赛步进Z2轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 44406, Source = "44406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44406", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_3", ])]
	public float 雷赛步进Z2轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 44408, Source = "44408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44408", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_4", ])]
	public float 雷赛步进Z2轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 44410, Source = "44410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44410", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_5", ])]
	public float 雷赛步进Z2轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 44412, Source = "44412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44412", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_6", ])]
	public float 雷赛步进Z2轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 44414, Source = "44414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44414", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_7", ])]
	public float 雷赛步进Z2轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 44416, Source = "44416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44416", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_8", ])]
	public float 雷赛步进Z2轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 44418, Source = "44418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44418", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_9", ])]
	public float 雷赛步进Z2轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 44420, Source = "44420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44420", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_10", ])]
	public float 雷赛步进Z2轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 44422, Source = "44422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44422", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_11", ])]
	public float 雷赛步进Z2轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 44424, Source = "44424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44424", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_12", ])]
	public float 雷赛步进Z2轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 44426, Source = "44426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44426", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_13", ])]
	public float 雷赛步进Z2轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 44428, Source = "44428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44428", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_14", ])]
	public float 雷赛步进Z2轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 44430, Source = "44430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44430", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_15", ])]
	public float 雷赛步进Z2轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 44432, Source = "44432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44432", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_16", ])]
	public float 雷赛步进Z2轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 44434, Source = "44434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44434", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_17", ])]
	public float 雷赛步进Z2轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 44436, Source = "44436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44436", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_18", ])]
	public float 雷赛步进Z2轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 44438, Source = "44438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44438", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_19", ])]
	public float 雷赛步进Z2轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 44440, Source = "44440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44440", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_20", ])]
	public float 雷赛步进Z2轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 44442, Source = "44442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44442", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_21", ])]
	public float 雷赛步进Z2轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 44444, Source = "44444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44444", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_22", ])]
	public float 雷赛步进Z2轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 44446, Source = "44446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44446", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_23", ])]
	public float 雷赛步进Z2轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 44448, Source = "44448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44448", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_24", ])]
	public float 雷赛步进Z2轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 44450, Source = "44450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44450", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_25", ])]
	public float 雷赛步进Z2轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 44452, Source = "44452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44452", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_26", ])]
	public float 雷赛步进Z2轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 44454, Source = "44454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44454", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_27", ])]
	public float 雷赛步进Z2轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 44456, Source = "44456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44456", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_28", ])]
	public float 雷赛步进Z2轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 44458, Source = "44458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44458", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_29", ])]
	public float 雷赛步进Z2轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 44460, Source = "44460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44460", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_30", ])]
	public float 雷赛步进Z2轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 44462, Source = "44462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44462", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_31", ])]
	public float 雷赛步进Z2轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 44464, Source = "44464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44464", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_32", ])]
	public float 雷赛步进Z2轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 44466, Source = "44466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44466", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_33", ])]
	public float 雷赛步进Z2轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 44468, Source = "44468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44468", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_34", ])]
	public float 雷赛步进Z2轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 44470, Source = "44470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44470", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_35", ])]
	public float 雷赛步进Z2轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 44472, Source = "44472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44472", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_36", ])]
	public float 雷赛步进Z2轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 44474, Source = "44474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44474", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_37", ])]
	public float 雷赛步进Z2轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 44476, Source = "44476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44476", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_38", ])]
	public float 雷赛步进Z2轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 44478, Source = "44478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44478", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_39", ])]
	public float 雷赛步进Z2轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 44480, Source = "44480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44480", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_40", ])]
	public float 雷赛步进Z2轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 44482, Source = "44482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44482", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_41", ])]
	public float 雷赛步进Z2轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 44484, Source = "44484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44484", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_42", ])]
	public float 雷赛步进Z2轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 44486, Source = "44486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44486", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_43", ])]
	public float 雷赛步进Z2轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 44488, Source = "44488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44488", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_44", ])]
	public float 雷赛步进Z2轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 44490, Source = "44490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44490", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_45", ])]
	public float 雷赛步进Z2轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 44492, Source = "44492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44492", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_46", ])]
	public float 雷赛步进Z2轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 44494, Source = "44494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44494", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_47", ])]
	public float 雷赛步进Z2轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 44496, Source = "44496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44496", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_48", ])]
	public float 雷赛步进Z2轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 44498, Source = "44498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44498", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_49", ])]
	public float 雷赛步进Z2轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 44500, Source = "44500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44500", Category = "PLC/雷赛步进Z2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 LEADSHINE Stepper_V? trí_PC_50", ])]
	public float 雷赛步进Z2轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 44600, Source = "44600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44600", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_0", ])]
	public float 固高直线Y1轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 44602, Source = "44602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44602", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_1", ])]
	public float 固高直线Y1轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 44604, Source = "44604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44604", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_2", ])]
	public float 固高直线Y1轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 44606, Source = "44606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44606", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_3", ])]
	public float 固高直线Y1轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 44608, Source = "44608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44608", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_4", ])]
	public float 固高直线Y1轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 44610, Source = "44610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44610", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_5", ])]
	public float 固高直线Y1轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 44612, Source = "44612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44612", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_6", ])]
	public float 固高直线Y1轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 44614, Source = "44614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44614", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_7", ])]
	public float 固高直线Y1轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 44616, Source = "44616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44616", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_8", ])]
	public float 固高直线Y1轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 44618, Source = "44618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44618", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_9", ])]
	public float 固高直线Y1轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 44620, Source = "44620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44620", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_10", ])]
	public float 固高直线Y1轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 44622, Source = "44622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44622", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_11", ])]
	public float 固高直线Y1轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 44624, Source = "44624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44624", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_12", ])]
	public float 固高直线Y1轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 44626, Source = "44626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44626", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_13", ])]
	public float 固高直线Y1轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 44628, Source = "44628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44628", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_14", ])]
	public float 固高直线Y1轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 44630, Source = "44630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44630", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_15", ])]
	public float 固高直线Y1轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 44632, Source = "44632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44632", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_16", ])]
	public float 固高直线Y1轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 44634, Source = "44634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44634", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_17", ])]
	public float 固高直线Y1轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 44636, Source = "44636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44636", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_18", ])]
	public float 固高直线Y1轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 44638, Source = "44638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44638", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_19", ])]
	public float 固高直线Y1轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 44640, Source = "44640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44640", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_20", ])]
	public float 固高直线Y1轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 44642, Source = "44642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44642", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_21", ])]
	public float 固高直线Y1轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 44644, Source = "44644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44644", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_22", ])]
	public float 固高直线Y1轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 44646, Source = "44646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44646", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_23", ])]
	public float 固高直线Y1轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 44648, Source = "44648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44648", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_24", ])]
	public float 固高直线Y1轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 44650, Source = "44650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44650", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_25", ])]
	public float 固高直线Y1轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 44652, Source = "44652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44652", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_26", ])]
	public float 固高直线Y1轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 44654, Source = "44654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44654", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_27", ])]
	public float 固高直线Y1轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 44656, Source = "44656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44656", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_28", ])]
	public float 固高直线Y1轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 44658, Source = "44658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44658", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_29", ])]
	public float 固高直线Y1轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 44660, Source = "44660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44660", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_30", ])]
	public float 固高直线Y1轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 44662, Source = "44662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44662", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_31", ])]
	public float 固高直线Y1轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 44664, Source = "44664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44664", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_32", ])]
	public float 固高直线Y1轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 44666, Source = "44666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44666", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_33", ])]
	public float 固高直线Y1轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 44668, Source = "44668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44668", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_34", ])]
	public float 固高直线Y1轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 44670, Source = "44670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44670", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_35", ])]
	public float 固高直线Y1轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 44672, Source = "44672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44672", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_36", ])]
	public float 固高直线Y1轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 44674, Source = "44674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44674", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_37", ])]
	public float 固高直线Y1轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 44676, Source = "44676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44676", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_38", ])]
	public float 固高直线Y1轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 44678, Source = "44678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44678", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_39", ])]
	public float 固高直线Y1轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 44680, Source = "44680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44680", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_40", ])]
	public float 固高直线Y1轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 44682, Source = "44682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44682", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_41", ])]
	public float 固高直线Y1轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 44684, Source = "44684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44684", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_42", ])]
	public float 固高直线Y1轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 44686, Source = "44686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44686", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_43", ])]
	public float 固高直线Y1轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 44688, Source = "44688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44688", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_44", ])]
	public float 固高直线Y1轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 44690, Source = "44690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44690", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_45", ])]
	public float 固高直线Y1轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 44692, Source = "44692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44692", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_46", ])]
	public float 固高直线Y1轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 44694, Source = "44694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44694", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_47", ])]
	public float 固高直线Y1轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 44696, Source = "44696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44696", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_48", ])]
	public float 固高直线Y1轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 44698, Source = "44698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44698", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_49", ])]
	public float 固高直线Y1轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 44700, Source = "44700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44700", Category = "PLC/固高直线Y1轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 GUGAO Linear_V? trí_PC_50", ])]
	public float 固高直线Y1轴_PC位置_50 { get; set; }

	[BinaryPoint(Offset = 44800, Source = "44800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44800", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_0",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 0",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_0", ])]
	public float 固高直线Y2轴_PC位置_0 { get; set; }

	[BinaryPoint(Offset = 44802, Source = "44802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44802", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_1",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 1",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_1", ])]
	public float 固高直线Y2轴_PC位置_1 { get; set; }

	[BinaryPoint(Offset = 44804, Source = "44804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44804", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_2",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 2",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_2", ])]
	public float 固高直线Y2轴_PC位置_2 { get; set; }

	[BinaryPoint(Offset = 44806, Source = "44806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44806", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_3",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 3",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_3", ])]
	public float 固高直线Y2轴_PC位置_3 { get; set; }

	[BinaryPoint(Offset = 44808, Source = "44808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44808", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_4",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 4",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_4", ])]
	public float 固高直线Y2轴_PC位置_4 { get; set; }

	[BinaryPoint(Offset = 44810, Source = "44810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44810", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_5",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 5",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_5", ])]
	public float 固高直线Y2轴_PC位置_5 { get; set; }

	[BinaryPoint(Offset = 44812, Source = "44812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44812", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_6",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 6",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_6", ])]
	public float 固高直线Y2轴_PC位置_6 { get; set; }

	[BinaryPoint(Offset = 44814, Source = "44814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44814", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_7",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 7",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_7", ])]
	public float 固高直线Y2轴_PC位置_7 { get; set; }

	[BinaryPoint(Offset = 44816, Source = "44816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44816", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_8",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 8",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_8", ])]
	public float 固高直线Y2轴_PC位置_8 { get; set; }

	[BinaryPoint(Offset = 44818, Source = "44818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44818", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_9",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 9",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_9", ])]
	public float 固高直线Y2轴_PC位置_9 { get; set; }

	[BinaryPoint(Offset = 44820, Source = "44820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44820", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_10",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 10",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_10", ])]
	public float 固高直线Y2轴_PC位置_10 { get; set; }

	[BinaryPoint(Offset = 44822, Source = "44822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44822", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_11",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 11",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_11", ])]
	public float 固高直线Y2轴_PC位置_11 { get; set; }

	[BinaryPoint(Offset = 44824, Source = "44824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44824", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_12",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 12",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_12", ])]
	public float 固高直线Y2轴_PC位置_12 { get; set; }

	[BinaryPoint(Offset = 44826, Source = "44826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44826", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_13",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 13",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_13", ])]
	public float 固高直线Y2轴_PC位置_13 { get; set; }

	[BinaryPoint(Offset = 44828, Source = "44828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44828", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_14",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 14",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_14", ])]
	public float 固高直线Y2轴_PC位置_14 { get; set; }

	[BinaryPoint(Offset = 44830, Source = "44830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44830", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_15",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 15",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_15", ])]
	public float 固高直线Y2轴_PC位置_15 { get; set; }

	[BinaryPoint(Offset = 44832, Source = "44832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44832", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_16",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 16",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_16", ])]
	public float 固高直线Y2轴_PC位置_16 { get; set; }

	[BinaryPoint(Offset = 44834, Source = "44834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44834", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_17",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 17",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_17", ])]
	public float 固高直线Y2轴_PC位置_17 { get; set; }

	[BinaryPoint(Offset = 44836, Source = "44836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44836", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_18",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 18",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_18", ])]
	public float 固高直线Y2轴_PC位置_18 { get; set; }

	[BinaryPoint(Offset = 44838, Source = "44838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44838", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_19",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 19",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_19", ])]
	public float 固高直线Y2轴_PC位置_19 { get; set; }

	[BinaryPoint(Offset = 44840, Source = "44840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44840", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_20",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 20",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_20", ])]
	public float 固高直线Y2轴_PC位置_20 { get; set; }

	[BinaryPoint(Offset = 44842, Source = "44842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44842", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_21",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 21",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_21", ])]
	public float 固高直线Y2轴_PC位置_21 { get; set; }

	[BinaryPoint(Offset = 44844, Source = "44844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44844", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_22",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 22",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_22", ])]
	public float 固高直线Y2轴_PC位置_22 { get; set; }

	[BinaryPoint(Offset = 44846, Source = "44846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44846", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_23",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 23",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_23", ])]
	public float 固高直线Y2轴_PC位置_23 { get; set; }

	[BinaryPoint(Offset = 44848, Source = "44848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44848", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_24",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 24",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_24", ])]
	public float 固高直线Y2轴_PC位置_24 { get; set; }

	[BinaryPoint(Offset = 44850, Source = "44850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44850", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_25",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 25",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_25", ])]
	public float 固高直线Y2轴_PC位置_25 { get; set; }

	[BinaryPoint(Offset = 44852, Source = "44852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44852", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_26",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 26",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_26", ])]
	public float 固高直线Y2轴_PC位置_26 { get; set; }

	[BinaryPoint(Offset = 44854, Source = "44854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44854", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_27",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 27",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_27", ])]
	public float 固高直线Y2轴_PC位置_27 { get; set; }

	[BinaryPoint(Offset = 44856, Source = "44856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44856", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_28",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 28",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_28", ])]
	public float 固高直线Y2轴_PC位置_28 { get; set; }

	[BinaryPoint(Offset = 44858, Source = "44858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44858", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_29",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 29",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_29", ])]
	public float 固高直线Y2轴_PC位置_29 { get; set; }

	[BinaryPoint(Offset = 44860, Source = "44860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44860", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_30",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 30",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_30", ])]
	public float 固高直线Y2轴_PC位置_30 { get; set; }

	[BinaryPoint(Offset = 44862, Source = "44862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44862", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_31",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 31",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_31", ])]
	public float 固高直线Y2轴_PC位置_31 { get; set; }

	[BinaryPoint(Offset = 44864, Source = "44864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44864", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_32",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 32",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_32", ])]
	public float 固高直线Y2轴_PC位置_32 { get; set; }

	[BinaryPoint(Offset = 44866, Source = "44866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44866", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_33",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 33",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_33", ])]
	public float 固高直线Y2轴_PC位置_33 { get; set; }

	[BinaryPoint(Offset = 44868, Source = "44868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44868", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_34",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 34",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_34", ])]
	public float 固高直线Y2轴_PC位置_34 { get; set; }

	[BinaryPoint(Offset = 44870, Source = "44870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44870", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_35",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 35",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_35", ])]
	public float 固高直线Y2轴_PC位置_35 { get; set; }

	[BinaryPoint(Offset = 44872, Source = "44872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44872", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_36",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 36",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_36", ])]
	public float 固高直线Y2轴_PC位置_36 { get; set; }

	[BinaryPoint(Offset = 44874, Source = "44874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44874", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_37",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 37",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_37", ])]
	public float 固高直线Y2轴_PC位置_37 { get; set; }

	[BinaryPoint(Offset = 44876, Source = "44876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44876", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_38",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 38",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_38", ])]
	public float 固高直线Y2轴_PC位置_38 { get; set; }

	[BinaryPoint(Offset = 44878, Source = "44878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44878", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_39",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 39",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_39", ])]
	public float 固高直线Y2轴_PC位置_39 { get; set; }

	[BinaryPoint(Offset = 44880, Source = "44880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44880", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_40",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 40",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_40", ])]
	public float 固高直线Y2轴_PC位置_40 { get; set; }

	[BinaryPoint(Offset = 44882, Source = "44882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44882", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_41",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 41",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_41", ])]
	public float 固高直线Y2轴_PC位置_41 { get; set; }

	[BinaryPoint(Offset = 44884, Source = "44884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44884", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_42",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 42",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_42", ])]
	public float 固高直线Y2轴_PC位置_42 { get; set; }

	[BinaryPoint(Offset = 44886, Source = "44886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44886", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_43",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 43",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_43", ])]
	public float 固高直线Y2轴_PC位置_43 { get; set; }

	[BinaryPoint(Offset = 44888, Source = "44888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44888", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_44",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 44",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_44", ])]
	public float 固高直线Y2轴_PC位置_44 { get; set; }

	[BinaryPoint(Offset = 44890, Source = "44890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44890", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_45",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 45",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_45", ])]
	public float 固高直线Y2轴_PC位置_45 { get; set; }

	[BinaryPoint(Offset = 44892, Source = "44892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44892", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_46",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 46",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_46", ])]
	public float 固高直线Y2轴_PC位置_46 { get; set; }

	[BinaryPoint(Offset = 44894, Source = "44894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44894", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_47",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 47",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_47", ])]
	public float 固高直线Y2轴_PC位置_47 { get; set; }

	[BinaryPoint(Offset = 44896, Source = "44896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44896", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_48",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 48",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_48", ])]
	public float 固高直线Y2轴_PC位置_48 { get; set; }

	[BinaryPoint(Offset = 44898, Source = "44898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44898", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_49",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 49",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_49", ])]
	public float 固高直线Y2轴_PC位置_49 { get; set; }

	[BinaryPoint(Offset = 44900, Source = "44900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:44900", Category = "PLC/固高直线Y2轴_PC位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴_PC位置_50",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis_PC Position 50",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 GUGAO Linear_V? trí_PC_50", ])]
	public float 固高直线Y2轴_PC位置_50 { get; set; }

	#endregion

}