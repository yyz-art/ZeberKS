
// GENERATE AT 2026/5/10 18:03:27
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
public partial class PointRecipeStruct
{

	#region CSV INCLUDE POINTS: PLC

	[BinaryPoint(Offset = 24000, Source = "24000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24000", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24002, Source = "24002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24002", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24004, Source = "24004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24004", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24006, Source = "24006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24006", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24008, Source = "24008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24008", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24010, Source = "24010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24010", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24012, Source = "24012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24012", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24014, Source = "24014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24014", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24016, Source = "24016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24016", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24018, Source = "24018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24018", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24020, Source = "24020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24020", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24022, Source = "24022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24022", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24024, Source = "24024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24024", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24026, Source = "24026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24026", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24028, Source = "24028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24028", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24030, Source = "24030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24030", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24032, Source = "24032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24032", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24034, Source = "24034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24034", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24036, Source = "24036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24036", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24038, Source = "24038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24038", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24040, Source = "24040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24040", Category = "PLC/X_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24050, Source = "24050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24050", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24052, Source = "24052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24052", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24054, Source = "24054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24054", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24056, Source = "24056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24056", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24058, Source = "24058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24058", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24060, Source = "24060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24060", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24062, Source = "24062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24062", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24064, Source = "24064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24064", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24066, Source = "24066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24066", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24068, Source = "24068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24068", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24070, Source = "24070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24070", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24072, Source = "24072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24072", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24074, Source = "24074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24074", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24076, Source = "24076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24076", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24078, Source = "24078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24078", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24080, Source = "24080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24080", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24082, Source = "24082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24082", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24084, Source = "24084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24084", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24086, Source = "24086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24086", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24088, Source = "24088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24088", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24090, Source = "24090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24090", Category = "PLC/X_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24100, Source = "24100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24100", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24102, Source = "24102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24102", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24104, Source = "24104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24104", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24106, Source = "24106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24106", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24108, Source = "24108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24108", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24110, Source = "24110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24110", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24112, Source = "24112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24112", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24114, Source = "24114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24114", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24116, Source = "24116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24116", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24118, Source = "24118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24118", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24120, Source = "24120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24120", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24122, Source = "24122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24122", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24124, Source = "24124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24124", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24126, Source = "24126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24126", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24128, Source = "24128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24128", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24130, Source = "24130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24130", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24132, Source = "24132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24132", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24134, Source = "24134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24134", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24136, Source = "24136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24136", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24138, Source = "24138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24138", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24140, Source = "24140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24140", Category = "PLC/Y_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24150, Source = "24150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24150", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24152, Source = "24152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24152", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24154, Source = "24154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24154", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24156, Source = "24156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24156", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24158, Source = "24158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24158", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24160, Source = "24160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24160", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24162, Source = "24162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24162", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24164, Source = "24164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24164", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24166, Source = "24166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24166", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24168, Source = "24168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24168", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24170, Source = "24170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24170", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24172, Source = "24172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24172", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24174, Source = "24174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24174", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24176, Source = "24176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24176", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24178, Source = "24178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24178", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24180, Source = "24180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24180", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24182, Source = "24182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24182", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24184, Source = "24184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24184", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24186, Source = "24186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24186", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24188, Source = "24188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24188", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24190, Source = "24190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24190", Category = "PLC/Y_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24200, Source = "24200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24200", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24202, Source = "24202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24202", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24204, Source = "24204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24204", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24206, Source = "24206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24206", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24208, Source = "24208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24208", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24210, Source = "24210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24210", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24212, Source = "24212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24212", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24214, Source = "24214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24214", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24216, Source = "24216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24216", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24218, Source = "24218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24218", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24220, Source = "24220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24220", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24222, Source = "24222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24222", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24224, Source = "24224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24224", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24226, Source = "24226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24226", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24228, Source = "24228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24228", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24230, Source = "24230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24230", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24232, Source = "24232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24232", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24234, Source = "24234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24234", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24236, Source = "24236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24236", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24238, Source = "24238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24238", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24240, Source = "24240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24240", Category = "PLC/Z_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24250, Source = "24250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24250", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24252, Source = "24252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24252", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24254, Source = "24254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24254", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24256, Source = "24256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24256", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24258, Source = "24258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24258", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24260, Source = "24260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24260", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24262, Source = "24262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24262", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24264, Source = "24264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24264", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24266, Source = "24266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24266", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24268, Source = "24268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24268", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24270, Source = "24270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24270", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24272, Source = "24272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24272", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24274, Source = "24274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24274", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24276, Source = "24276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24276", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24278, Source = "24278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24278", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24280, Source = "24280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24280", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24282, Source = "24282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24282", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24284, Source = "24284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24284", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24286, Source = "24286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24286", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24288, Source = "24288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24288", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24290, Source = "24290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24290", Category = "PLC/Z_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Z_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Z_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24300, Source = "24300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24300", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24302, Source = "24302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24302", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24304, Source = "24304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24304", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24306, Source = "24306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24306", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24308, Source = "24308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24308", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24310, Source = "24310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24310", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24312, Source = "24312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24312", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24314, Source = "24314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24314", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24316, Source = "24316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24316", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24318, Source = "24318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24318", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24320, Source = "24320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24320", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24322, Source = "24322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24322", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24324, Source = "24324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24324", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24326, Source = "24326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24326", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24328, Source = "24328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24328", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24330, Source = "24330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24330", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24332, Source = "24332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24332", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24334, Source = "24334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24334", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24336, Source = "24336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24336", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24338, Source = "24338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24338", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24340, Source = "24340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24340", Category = "PLC/R_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24350, Source = "24350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24350", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24352, Source = "24352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24352", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24354, Source = "24354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24354", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24356, Source = "24356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24356", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24358, Source = "24358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24358", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24360, Source = "24360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24360", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24362, Source = "24362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24362", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24364, Source = "24364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24364", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24366, Source = "24366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24366", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24368, Source = "24368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24368", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24370, Source = "24370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24370", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24372, Source = "24372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24372", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24374, Source = "24374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24374", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24376, Source = "24376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24376", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24378, Source = "24378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24378", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24380, Source = "24380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24380", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24382, Source = "24382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24382", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24384, Source = "24384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24384", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24386, Source = "24386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24386", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24388, Source = "24388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24388", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24390, Source = "24390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24390", Category = "PLC/R_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "R_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "R_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float R_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24400, Source = "24400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24400", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24402, Source = "24402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24402", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24404, Source = "24404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24404", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24406, Source = "24406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24406", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24408, Source = "24408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24408", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24410, Source = "24410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24410", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24412, Source = "24412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24412", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24414, Source = "24414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24414", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24416, Source = "24416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24416", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24418, Source = "24418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24418", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24420, Source = "24420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24420", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24422, Source = "24422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24422", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24424, Source = "24424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24424", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24426, Source = "24426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24426", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24428, Source = "24428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24428", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24430, Source = "24430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24430", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24432, Source = "24432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24432", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24434, Source = "24434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24434", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24436, Source = "24436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24436", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24438, Source = "24438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24438", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24440, Source = "24440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24440", Category = "PLC/上料轴1__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1__Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1__Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24450, Source = "24450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24450", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24452, Source = "24452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24452", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24454, Source = "24454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24454", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24456, Source = "24456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24456", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24458, Source = "24458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24458", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24460, Source = "24460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24460", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24462, Source = "24462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24462", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24464, Source = "24464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24464", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24466, Source = "24466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24466", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24468, Source = "24468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24468", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24470, Source = "24470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24470", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24472, Source = "24472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24472", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24474, Source = "24474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24474", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24476, Source = "24476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24476", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24478, Source = "24478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24478", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24480, Source = "24480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24480", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24482, Source = "24482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24482", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24484, Source = "24484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24484", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24486, Source = "24486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24486", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24488, Source = "24488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24488", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24490, Source = "24490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24490", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24500, Source = "24500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24500", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24502, Source = "24502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24502", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24504, Source = "24504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24504", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24506, Source = "24506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24506", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24508, Source = "24508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24508", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24510, Source = "24510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24510", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24512, Source = "24512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24512", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24514, Source = "24514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24514", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24516, Source = "24516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24516", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24518, Source = "24518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24518", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24520, Source = "24520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24520", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24522, Source = "24522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24522", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24524, Source = "24524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24524", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24526, Source = "24526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24526", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24528, Source = "24528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24528", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24530, Source = "24530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24530", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24532, Source = "24532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24532", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24534, Source = "24534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24534", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24536, Source = "24536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24536", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24538, Source = "24538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24538", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24540, Source = "24540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24540", Category = "PLC/上料轴2__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2__Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2__Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24550, Source = "24550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24550", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24552, Source = "24552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24552", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24554, Source = "24554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24554", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24556, Source = "24556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24556", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24558, Source = "24558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24558", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24560, Source = "24560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24560", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24562, Source = "24562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24562", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24564, Source = "24564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24564", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24566, Source = "24566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24566", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24568, Source = "24568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24568", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24570, Source = "24570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24570", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24572, Source = "24572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24572", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24574, Source = "24574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24574", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24576, Source = "24576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24576", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24578, Source = "24578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24578", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24580, Source = "24580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24580", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24582, Source = "24582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24582", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24584, Source = "24584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24584", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24586, Source = "24586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24586", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24588, Source = "24588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24588", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24590, Source = "24590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24590", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24600, Source = "24600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24600", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24602, Source = "24602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24602", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24604, Source = "24604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24604", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24606, Source = "24606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24606", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24608, Source = "24608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24608", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24610, Source = "24610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24610", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24612, Source = "24612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24612", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24614, Source = "24614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24614", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24616, Source = "24616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24616", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24618, Source = "24618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24618", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24620, Source = "24620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24620", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24622, Source = "24622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24622", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24624, Source = "24624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24624", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24626, Source = "24626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24626", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24628, Source = "24628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24628", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24630, Source = "24630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24630", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24632, Source = "24632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24632", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24634, Source = "24634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24634", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24636, Source = "24636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24636", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24638, Source = "24638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24638", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24640, Source = "24640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24640", Category = "PLC/步进电机__Axis", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机__Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机__Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24650, Source = "24650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24650", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24652, Source = "24652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24652", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24654, Source = "24654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24654", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24656, Source = "24656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24656", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24658, Source = "24658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24658", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24660, Source = "24660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24660", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24662, Source = "24662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24662", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24664, Source = "24664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24664", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24666, Source = "24666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24666", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24668, Source = "24668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24668", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24670, Source = "24670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24670", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24672, Source = "24672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24672", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24674, Source = "24674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24674", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24676, Source = "24676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24676", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24678, Source = "24678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24678", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24680, Source = "24680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24680", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24682, Source = "24682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24682", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24684, Source = "24684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24684", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24686, Source = "24686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24686", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24688, Source = "24688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24688", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24690, Source = "24690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24690", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 步进电机_Axis_Vel_20 { get; set; }

	#endregion

}