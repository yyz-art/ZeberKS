
// GENERATE AT 2026/6/6 14:09:27
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
	[ValueInfo(Source = "PLC:24000", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24002, Source = "24002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24002", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24004, Source = "24004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24004", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24006, Source = "24006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24006", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24008, Source = "24008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24008", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24010, Source = "24010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24010", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24012, Source = "24012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24012", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24014, Source = "24014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24014", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24016, Source = "24016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24016", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24018, Source = "24018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24018", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24020, Source = "24020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24020", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24022, Source = "24022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24022", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24024, Source = "24024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24024", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24026, Source = "24026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24026", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24028, Source = "24028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24028", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24030, Source = "24030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24030", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24032, Source = "24032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24032", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24034, Source = "24034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24034", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24036, Source = "24036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24036", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24038, Source = "24038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24038", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24040, Source = "24040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24040", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24042, Source = "24042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24042", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24044, Source = "24044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24044", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24046, Source = "24046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24046", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24048, Source = "24048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24048", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24050, Source = "24050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24050", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24052, Source = "24052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24052", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24054, Source = "24054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24054", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24056, Source = "24056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24056", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24058, Source = "24058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24058", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24060, Source = "24060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24060", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24062, Source = "24062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24062", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24064, Source = "24064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24064", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24066, Source = "24066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24066", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24068, Source = "24068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24068", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24070, Source = "24070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24070", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24072, Source = "24072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24072", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24074, Source = "24074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24074", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24076, Source = "24076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24076", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24078, Source = "24078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24078", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24080, Source = "24080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24080", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24082, Source = "24082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24082", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24084, Source = "24084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24084", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24086, Source = "24086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24086", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24088, Source = "24088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24088", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24090, Source = "24090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24090", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24092, Source = "24092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24092", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24094, Source = "24094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24094", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24096, Source = "24096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24096", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24098, Source = "24098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24098", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_50 { get; set; }

	[BinaryPoint(Offset = 24100, Source = "24100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24100", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_51 { get; set; }

	[BinaryPoint(Offset = 24102, Source = "24102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24102", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_52 { get; set; }

	[BinaryPoint(Offset = 24104, Source = "24104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24104", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_53 { get; set; }

	[BinaryPoint(Offset = 24106, Source = "24106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24106", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_54 { get; set; }

	[BinaryPoint(Offset = 24108, Source = "24108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24108", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_55 { get; set; }

	[BinaryPoint(Offset = 24110, Source = "24110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24110", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_56 { get; set; }

	[BinaryPoint(Offset = 24112, Source = "24112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24112", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_57 { get; set; }

	[BinaryPoint(Offset = 24114, Source = "24114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24114", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_58 { get; set; }

	[BinaryPoint(Offset = 24116, Source = "24116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24116", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_59 { get; set; }

	[BinaryPoint(Offset = 24118, Source = "24118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24118", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_60 { get; set; }

	[BinaryPoint(Offset = 24120, Source = "24120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24120", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24122, Source = "24122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24122", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24124, Source = "24124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24124", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24126, Source = "24126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24126", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24128, Source = "24128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24128", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24130, Source = "24130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24130", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24132, Source = "24132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24132", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24134, Source = "24134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24134", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24136, Source = "24136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24136", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24138, Source = "24138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24138", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24140, Source = "24140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24140", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24142, Source = "24142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24142", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24144, Source = "24144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24144", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24146, Source = "24146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24146", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24148, Source = "24148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24148", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24150, Source = "24150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24150", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24152, Source = "24152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24152", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24154, Source = "24154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24154", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24156, Source = "24156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24156", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24158, Source = "24158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24158", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24160, Source = "24160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24160", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24162, Source = "24162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24162", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24164, Source = "24164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24164", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24166, Source = "24166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24166", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24168, Source = "24168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24168", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24170, Source = "24170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24170", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24172, Source = "24172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24172", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24174, Source = "24174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24174", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24176, Source = "24176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24176", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24178, Source = "24178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24178", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24180, Source = "24180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24180", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24182, Source = "24182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24182", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24184, Source = "24184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24184", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24186, Source = "24186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24186", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24188, Source = "24188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24188", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24190, Source = "24190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24190", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24192, Source = "24192", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24192", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24194, Source = "24194", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24194", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24196, Source = "24196", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24196", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24198, Source = "24198", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24198", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24200, Source = "24200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24200", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24202, Source = "24202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24202", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24204, Source = "24204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24204", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24206, Source = "24206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24206", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24208, Source = "24208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24208", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24210, Source = "24210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24210", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24212, Source = "24212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24212", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24214, Source = "24214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24214", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24216, Source = "24216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24216", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24218, Source = "24218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24218", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_50 { get; set; }

	[BinaryPoint(Offset = 24220, Source = "24220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24220", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_51 { get; set; }

	[BinaryPoint(Offset = 24222, Source = "24222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24222", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_52 { get; set; }

	[BinaryPoint(Offset = 24224, Source = "24224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24224", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_53 { get; set; }

	[BinaryPoint(Offset = 24226, Source = "24226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24226", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_54 { get; set; }

	[BinaryPoint(Offset = 24228, Source = "24228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24228", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_55 { get; set; }

	[BinaryPoint(Offset = 24230, Source = "24230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24230", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_56 { get; set; }

	[BinaryPoint(Offset = 24232, Source = "24232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24232", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_57 { get; set; }

	[BinaryPoint(Offset = 24234, Source = "24234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24234", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_58 { get; set; }

	[BinaryPoint(Offset = 24236, Source = "24236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24236", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_59 { get; set; }

	[BinaryPoint(Offset = 24240, Source = "24240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24240", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24241, Source = "24241", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24241", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24242, Source = "24242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24242", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24243, Source = "24243", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24243", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24244, Source = "24244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24244", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24245, Source = "24245", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24245", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24246, Source = "24246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24246", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24247, Source = "24247", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24247", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24248, Source = "24248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24248", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24249, Source = "24249", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24249", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24250, Source = "24250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24250", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24251, Source = "24251", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24251", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24252, Source = "24252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24252", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24253, Source = "24253", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24253", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24254, Source = "24254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24254", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24255, Source = "24255", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24255", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24256, Source = "24256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24256", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24257, Source = "24257", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24257", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24258, Source = "24258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24258", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24259, Source = "24259", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24259", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24260, Source = "24260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24260", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24261, Source = "24261", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24261", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24262, Source = "24262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24262", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24263, Source = "24263", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24263", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24264, Source = "24264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24264", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24265, Source = "24265", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24265", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24266, Source = "24266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24266", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24267, Source = "24267", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24267", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24268, Source = "24268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24268", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24269, Source = "24269", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24269", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24270, Source = "24270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24270", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24271, Source = "24271", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24271", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24272, Source = "24272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24272", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24273, Source = "24273", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24273", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24274, Source = "24274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24274", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24275, Source = "24275", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24275", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24276, Source = "24276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24276", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24277, Source = "24277", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24277", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24278, Source = "24278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24278", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24279, Source = "24279", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24279", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24280, Source = "24280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24280", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24281, Source = "24281", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24281", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24282, Source = "24282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24282", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24283, Source = "24283", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24283", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24284, Source = "24284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24284", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24285, Source = "24285", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24285", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24286, Source = "24286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24286", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24287, Source = "24287", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24287", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24288, Source = "24288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24288", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24289, Source = "24289", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24289", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_50 { get; set; }

	[BinaryPoint(Offset = 24290, Source = "24290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24290", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_51 { get; set; }

	[BinaryPoint(Offset = 24291, Source = "24291", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24291", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_52 { get; set; }

	[BinaryPoint(Offset = 24292, Source = "24292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24292", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_53 { get; set; }

	[BinaryPoint(Offset = 24293, Source = "24293", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24293", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_54 { get; set; }

	[BinaryPoint(Offset = 24294, Source = "24294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24294", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_55 { get; set; }

	[BinaryPoint(Offset = 24295, Source = "24295", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24295", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_56 { get; set; }

	[BinaryPoint(Offset = 24296, Source = "24296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24296", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_57 { get; set; }

	[BinaryPoint(Offset = 24297, Source = "24297", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24297", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_58 { get; set; }

	[BinaryPoint(Offset = 24298, Source = "24298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24298", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_59 { get; set; }

	[BinaryPoint(Offset = 24299, Source = "24299", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24299", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_60 { get; set; }

	[BinaryPoint(Offset = 24360, Source = "24360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24360", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24362, Source = "24362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24362", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24364, Source = "24364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24364", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24366, Source = "24366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24366", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24368, Source = "24368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24368", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24370, Source = "24370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24370", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24372, Source = "24372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24372", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24374, Source = "24374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24374", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24376, Source = "24376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24376", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24378, Source = "24378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24378", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24380, Source = "24380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24380", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24382, Source = "24382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24382", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24384, Source = "24384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24384", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24386, Source = "24386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24386", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24388, Source = "24388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24388", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24390, Source = "24390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24390", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24392, Source = "24392", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24392", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24394, Source = "24394", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24394", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24396, Source = "24396", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24396", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24398, Source = "24398", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24398", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24400, Source = "24400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24400", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24402, Source = "24402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24402", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24404, Source = "24404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24404", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24406, Source = "24406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24406", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24408, Source = "24408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24408", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24410, Source = "24410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24410", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24412, Source = "24412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24412", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24414, Source = "24414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24414", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24416, Source = "24416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24416", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24418, Source = "24418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24418", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24420, Source = "24420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24420", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24422, Source = "24422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24422", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24424, Source = "24424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24424", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24426, Source = "24426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24426", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24428, Source = "24428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24428", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24430, Source = "24430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24430", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24432, Source = "24432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24432", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24434, Source = "24434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24434", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24436, Source = "24436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24436", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24438, Source = "24438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24438", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24440, Source = "24440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24440", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24442, Source = "24442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24442", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24444, Source = "24444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24444", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24446, Source = "24446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24446", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24448, Source = "24448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24448", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24450, Source = "24450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24450", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24452, Source = "24452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24452", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24454, Source = "24454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24454", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24456, Source = "24456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24456", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24458, Source = "24458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24458", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_50 { get; set; }

	[BinaryPoint(Offset = 24460, Source = "24460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24460", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_51 { get; set; }

	[BinaryPoint(Offset = 24462, Source = "24462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24462", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_52 { get; set; }

	[BinaryPoint(Offset = 24464, Source = "24464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24464", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_53 { get; set; }

	[BinaryPoint(Offset = 24466, Source = "24466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24466", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_54 { get; set; }

	[BinaryPoint(Offset = 24468, Source = "24468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24468", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_55 { get; set; }

	[BinaryPoint(Offset = 24470, Source = "24470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24470", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_56 { get; set; }

	[BinaryPoint(Offset = 24472, Source = "24472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24472", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_57 { get; set; }

	[BinaryPoint(Offset = 24474, Source = "24474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24474", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_58 { get; set; }

	[BinaryPoint(Offset = 24476, Source = "24476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24476", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_59 { get; set; }

	[BinaryPoint(Offset = 24478, Source = "24478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24478", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_60 { get; set; }

	[BinaryPoint(Offset = 24480, Source = "24480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24480", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24482, Source = "24482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24482", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24484, Source = "24484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24484", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24486, Source = "24486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24486", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24488, Source = "24488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24488", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24490, Source = "24490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24490", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24492, Source = "24492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24492", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24494, Source = "24494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24494", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24496, Source = "24496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24496", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24498, Source = "24498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24498", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24500, Source = "24500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24500", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24502, Source = "24502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24502", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24504, Source = "24504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24504", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24506, Source = "24506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24506", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24508, Source = "24508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24508", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24510, Source = "24510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24510", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24512, Source = "24512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24512", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24514, Source = "24514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24514", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24516, Source = "24516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24516", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24518, Source = "24518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24518", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24520, Source = "24520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24520", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24522, Source = "24522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24522", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24524, Source = "24524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24524", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24526, Source = "24526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24526", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24528, Source = "24528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24528", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24530, Source = "24530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24530", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24532, Source = "24532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24532", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24534, Source = "24534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24534", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24536, Source = "24536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24536", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24538, Source = "24538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24538", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24540, Source = "24540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24540", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24542, Source = "24542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24542", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24544, Source = "24544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24544", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24546, Source = "24546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24546", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24548, Source = "24548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24548", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24550, Source = "24550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24550", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24552, Source = "24552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24552", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24554, Source = "24554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24554", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24556, Source = "24556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24556", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24558, Source = "24558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24558", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24560, Source = "24560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24560", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24562, Source = "24562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24562", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24564, Source = "24564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24564", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24566, Source = "24566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24566", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24568, Source = "24568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24568", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24570, Source = "24570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24570", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24572, Source = "24572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24572", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24574, Source = "24574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24574", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24576, Source = "24576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24576", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24578, Source = "24578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24578", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_50 { get; set; }

	[BinaryPoint(Offset = 24580, Source = "24580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24580", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_51 { get; set; }

	[BinaryPoint(Offset = 24582, Source = "24582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24582", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_52 { get; set; }

	[BinaryPoint(Offset = 24584, Source = "24584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24584", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_53 { get; set; }

	[BinaryPoint(Offset = 24586, Source = "24586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24586", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_54 { get; set; }

	[BinaryPoint(Offset = 24588, Source = "24588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24588", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_55 { get; set; }

	[BinaryPoint(Offset = 24590, Source = "24590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24590", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_56 { get; set; }

	[BinaryPoint(Offset = 24592, Source = "24592", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24592", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_57 { get; set; }

	[BinaryPoint(Offset = 24594, Source = "24594", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24594", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_58 { get; set; }

	[BinaryPoint(Offset = 24596, Source = "24596", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24596", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_59 { get; set; }

	[BinaryPoint(Offset = 24598, Source = "24598", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24598", Category = "PLC/Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Pos_60 { get; set; }

	[BinaryPoint(Offset = 24600, Source = "24600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24600", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24602, Source = "24602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24602", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24604, Source = "24604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24604", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24606, Source = "24606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24606", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24608, Source = "24608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24608", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24610, Source = "24610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24610", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24612, Source = "24612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24612", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24614, Source = "24614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24614", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24616, Source = "24616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24616", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24618, Source = "24618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24618", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24620, Source = "24620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24620", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24622, Source = "24622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24622", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24624, Source = "24624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24624", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24626, Source = "24626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24626", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24628, Source = "24628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24628", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24630, Source = "24630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24630", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24632, Source = "24632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24632", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24634, Source = "24634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24634", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24636, Source = "24636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24636", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24638, Source = "24638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24638", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24640, Source = "24640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24640", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24642, Source = "24642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24642", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24644, Source = "24644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24644", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24646, Source = "24646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24646", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24648, Source = "24648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24648", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24650, Source = "24650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24650", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24652, Source = "24652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24652", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24654, Source = "24654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24654", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24656, Source = "24656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24656", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24658, Source = "24658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24658", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24660, Source = "24660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24660", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24662, Source = "24662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24662", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24664, Source = "24664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24664", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24666, Source = "24666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24666", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24668, Source = "24668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24668", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24670, Source = "24670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24670", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24672, Source = "24672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24672", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24674, Source = "24674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24674", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24676, Source = "24676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24676", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24678, Source = "24678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24678", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24680, Source = "24680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24680", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24682, Source = "24682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24682", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24684, Source = "24684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24684", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24686, Source = "24686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24686", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24688, Source = "24688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24688", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24690, Source = "24690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24690", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24692, Source = "24692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24692", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24694, Source = "24694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24694", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24696, Source = "24696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24696", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24698, Source = "24698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24698", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_50 { get; set; }

	[BinaryPoint(Offset = 24700, Source = "24700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24700", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_51 { get; set; }

	[BinaryPoint(Offset = 24702, Source = "24702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24702", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_52 { get; set; }

	[BinaryPoint(Offset = 24704, Source = "24704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24704", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_53 { get; set; }

	[BinaryPoint(Offset = 24706, Source = "24706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24706", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_54 { get; set; }

	[BinaryPoint(Offset = 24708, Source = "24708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24708", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_55 { get; set; }

	[BinaryPoint(Offset = 24710, Source = "24710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24710", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_56 { get; set; }

	[BinaryPoint(Offset = 24712, Source = "24712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24712", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_57 { get; set; }

	[BinaryPoint(Offset = 24714, Source = "24714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24714", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_58 { get; set; }

	[BinaryPoint(Offset = 24716, Source = "24716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24716", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_59 { get; set; }

	[BinaryPoint(Offset = 24718, Source = "24718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24718", Category = "PLC/Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Z轴_Vel_60 { get; set; }

	[BinaryPoint(Offset = 24720, Source = "24720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24720", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24722, Source = "24722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24722", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24724, Source = "24724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24724", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24726, Source = "24726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24726", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24728, Source = "24728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24728", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24730, Source = "24730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24730", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24732, Source = "24732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24732", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24734, Source = "24734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24734", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24736, Source = "24736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24736", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24738, Source = "24738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24738", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24740, Source = "24740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24740", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24742, Source = "24742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24742", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24744, Source = "24744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24744", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24746, Source = "24746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24746", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24748, Source = "24748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24748", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24750, Source = "24750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24750", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24752, Source = "24752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24752", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24754, Source = "24754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24754", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24756, Source = "24756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24756", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24758, Source = "24758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24758", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24760, Source = "24760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24760", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24762, Source = "24762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24762", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24764, Source = "24764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24764", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24766, Source = "24766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24766", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24768, Source = "24768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24768", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24770, Source = "24770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24770", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24772, Source = "24772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24772", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24774, Source = "24774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24774", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24776, Source = "24776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24776", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24778, Source = "24778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24778", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24780, Source = "24780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24780", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24782, Source = "24782", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24782", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24784, Source = "24784", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24784", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24786, Source = "24786", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24786", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24788, Source = "24788", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24788", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24790, Source = "24790", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24790", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24792, Source = "24792", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24792", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24794, Source = "24794", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24794", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24796, Source = "24796", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24796", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24798, Source = "24798", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24798", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24800, Source = "24800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24800", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24802, Source = "24802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24802", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24804, Source = "24804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24804", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24806, Source = "24806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24806", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24808, Source = "24808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24808", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24810, Source = "24810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24810", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24812, Source = "24812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24812", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24814, Source = "24814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24814", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24816, Source = "24816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24816", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24818, Source = "24818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24818", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_50 { get; set; }

	[BinaryPoint(Offset = 24820, Source = "24820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24820", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_51 { get; set; }

	[BinaryPoint(Offset = 24822, Source = "24822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24822", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_52 { get; set; }

	[BinaryPoint(Offset = 24824, Source = "24824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24824", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_53 { get; set; }

	[BinaryPoint(Offset = 24826, Source = "24826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24826", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_54 { get; set; }

	[BinaryPoint(Offset = 24828, Source = "24828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24828", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_55 { get; set; }

	[BinaryPoint(Offset = 24830, Source = "24830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24830", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_56 { get; set; }

	[BinaryPoint(Offset = 24832, Source = "24832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24832", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_57 { get; set; }

	[BinaryPoint(Offset = 24834, Source = "24834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24834", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_58 { get; set; }

	[BinaryPoint(Offset = 24836, Source = "24836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24836", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_59 { get; set; }

	[BinaryPoint(Offset = 24838, Source = "24838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24838", Category = "PLC/进料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Pos_60 { get; set; }

	[BinaryPoint(Offset = 24840, Source = "24840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24840", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24842, Source = "24842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24842", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24844, Source = "24844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24844", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24846, Source = "24846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24846", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24848, Source = "24848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24848", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24850, Source = "24850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24850", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24852, Source = "24852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24852", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24854, Source = "24854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24854", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24856, Source = "24856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24856", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24858, Source = "24858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24858", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24860, Source = "24860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24860", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24862, Source = "24862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24862", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24864, Source = "24864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24864", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24866, Source = "24866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24866", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24868, Source = "24868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24868", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24870, Source = "24870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24870", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24872, Source = "24872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24872", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24874, Source = "24874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24874", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24876, Source = "24876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24876", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24878, Source = "24878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24878", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24880, Source = "24880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24880", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24882, Source = "24882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24882", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24884, Source = "24884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24884", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24886, Source = "24886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24886", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24888, Source = "24888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24888", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24890, Source = "24890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24890", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24892, Source = "24892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24892", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24894, Source = "24894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24894", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24896, Source = "24896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24896", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24898, Source = "24898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24898", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24900, Source = "24900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24900", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24902, Source = "24902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24902", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24904, Source = "24904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24904", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24906, Source = "24906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24906", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24908, Source = "24908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24908", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24910, Source = "24910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24910", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24912, Source = "24912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24912", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24914, Source = "24914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24914", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24916, Source = "24916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24916", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24918, Source = "24918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24918", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24920, Source = "24920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24920", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24922, Source = "24922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24922", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24924, Source = "24924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24924", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24926, Source = "24926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24926", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24928, Source = "24928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24928", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24930, Source = "24930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24930", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24932, Source = "24932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24932", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24934, Source = "24934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24934", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24936, Source = "24936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24936", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24938, Source = "24938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24938", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_50 { get; set; }

	[BinaryPoint(Offset = 24940, Source = "24940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24940", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_51 { get; set; }

	[BinaryPoint(Offset = 24942, Source = "24942", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24942", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_52 { get; set; }

	[BinaryPoint(Offset = 24944, Source = "24944", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24944", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_53 { get; set; }

	[BinaryPoint(Offset = 24946, Source = "24946", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24946", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_54 { get; set; }

	[BinaryPoint(Offset = 24948, Source = "24948", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24948", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_55 { get; set; }

	[BinaryPoint(Offset = 24950, Source = "24950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24950", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_56 { get; set; }

	[BinaryPoint(Offset = 24952, Source = "24952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24952", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_57 { get; set; }

	[BinaryPoint(Offset = 24954, Source = "24954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24954", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_58 { get; set; }

	[BinaryPoint(Offset = 24956, Source = "24956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24956", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_59 { get; set; }

	[BinaryPoint(Offset = 24958, Source = "24958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24958", Category = "PLC/进料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴1_Vel_60 { get; set; }

	[BinaryPoint(Offset = 24960, Source = "24960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24960", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24962, Source = "24962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24962", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24964, Source = "24964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24964", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24966, Source = "24966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24966", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24968, Source = "24968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24968", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24970, Source = "24970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24970", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24972, Source = "24972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24972", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24974, Source = "24974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24974", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24976, Source = "24976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24976", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24978, Source = "24978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24978", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24980, Source = "24980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24980", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24982, Source = "24982", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24982", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24984, Source = "24984", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24984", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24986, Source = "24986", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24986", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24988, Source = "24988", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24988", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24990, Source = "24990", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24990", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24992, Source = "24992", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24992", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24994, Source = "24994", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24994", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24996, Source = "24996", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24996", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24998, Source = "24998", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24998", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25000, Source = "25000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25000", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25002, Source = "25002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25002", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25004, Source = "25004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25004", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25006, Source = "25006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25006", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25008, Source = "25008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25008", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25010, Source = "25010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25010", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25012, Source = "25012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25012", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25014, Source = "25014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25014", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25016, Source = "25016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25016", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25018, Source = "25018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25018", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25020, Source = "25020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25020", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25022, Source = "25022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25022", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25024, Source = "25024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25024", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25026, Source = "25026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25026", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25028, Source = "25028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25028", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25030, Source = "25030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25030", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25032, Source = "25032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25032", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25034, Source = "25034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25034", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25036, Source = "25036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25036", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25038, Source = "25038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25038", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25040, Source = "25040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25040", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25042, Source = "25042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25042", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_42 { get; set; }

	[BinaryPoint(Offset = 25044, Source = "25044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25044", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_43 { get; set; }

	[BinaryPoint(Offset = 25046, Source = "25046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25046", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_44 { get; set; }

	[BinaryPoint(Offset = 25048, Source = "25048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25048", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_45 { get; set; }

	[BinaryPoint(Offset = 25050, Source = "25050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25050", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_46 { get; set; }

	[BinaryPoint(Offset = 25052, Source = "25052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25052", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_47 { get; set; }

	[BinaryPoint(Offset = 25054, Source = "25054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25054", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_48 { get; set; }

	[BinaryPoint(Offset = 25056, Source = "25056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25056", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_49 { get; set; }

	[BinaryPoint(Offset = 25058, Source = "25058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25058", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_50 { get; set; }

	[BinaryPoint(Offset = 25060, Source = "25060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25060", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_51 { get; set; }

	[BinaryPoint(Offset = 25062, Source = "25062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25062", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_52 { get; set; }

	[BinaryPoint(Offset = 25064, Source = "25064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25064", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_53 { get; set; }

	[BinaryPoint(Offset = 25066, Source = "25066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25066", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_54 { get; set; }

	[BinaryPoint(Offset = 25068, Source = "25068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25068", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_55 { get; set; }

	[BinaryPoint(Offset = 25070, Source = "25070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25070", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_56 { get; set; }

	[BinaryPoint(Offset = 25072, Source = "25072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25072", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_57 { get; set; }

	[BinaryPoint(Offset = 25074, Source = "25074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25074", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_58 { get; set; }

	[BinaryPoint(Offset = 25076, Source = "25076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25076", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_59 { get; set; }

	[BinaryPoint(Offset = 25078, Source = "25078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25078", Category = "PLC/进料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Pos_60 { get; set; }

	[BinaryPoint(Offset = 25080, Source = "25080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25080", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25082, Source = "25082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25082", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25084, Source = "25084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25084", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25086, Source = "25086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25086", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25088, Source = "25088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25088", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25090, Source = "25090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25090", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25092, Source = "25092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25092", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25094, Source = "25094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25094", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25096, Source = "25096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25096", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25098, Source = "25098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25098", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25100, Source = "25100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25100", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25102, Source = "25102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25102", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25104, Source = "25104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25104", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25106, Source = "25106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25106", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25108, Source = "25108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25108", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25110, Source = "25110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25110", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25112, Source = "25112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25112", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25114, Source = "25114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25114", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25116, Source = "25116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25116", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25118, Source = "25118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25118", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25120, Source = "25120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25120", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25122, Source = "25122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25122", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25124, Source = "25124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25124", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25126, Source = "25126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25126", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25128, Source = "25128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25128", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25130, Source = "25130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25130", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25132, Source = "25132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25132", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25134, Source = "25134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25134", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25136, Source = "25136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25136", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25138, Source = "25138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25138", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25140, Source = "25140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25140", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25142, Source = "25142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25142", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25144, Source = "25144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25144", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25146, Source = "25146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25146", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25148, Source = "25148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25148", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25150, Source = "25150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25150", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25152, Source = "25152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25152", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25154, Source = "25154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25154", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25156, Source = "25156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25156", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25158, Source = "25158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25158", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25160, Source = "25160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25160", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25162, Source = "25162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25162", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_42 { get; set; }

	[BinaryPoint(Offset = 25164, Source = "25164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25164", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_43 { get; set; }

	[BinaryPoint(Offset = 25166, Source = "25166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25166", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_44 { get; set; }

	[BinaryPoint(Offset = 25168, Source = "25168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25168", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_45 { get; set; }

	[BinaryPoint(Offset = 25170, Source = "25170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25170", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_46 { get; set; }

	[BinaryPoint(Offset = 25172, Source = "25172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25172", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_47 { get; set; }

	[BinaryPoint(Offset = 25174, Source = "25174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25174", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_48 { get; set; }

	[BinaryPoint(Offset = 25176, Source = "25176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25176", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_49 { get; set; }

	[BinaryPoint(Offset = 25178, Source = "25178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25178", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_50 { get; set; }

	[BinaryPoint(Offset = 25180, Source = "25180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25180", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_51 { get; set; }

	[BinaryPoint(Offset = 25182, Source = "25182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25182", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_52 { get; set; }

	[BinaryPoint(Offset = 25184, Source = "25184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25184", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_53 { get; set; }

	[BinaryPoint(Offset = 25186, Source = "25186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25186", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_54 { get; set; }

	[BinaryPoint(Offset = 25188, Source = "25188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25188", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_55 { get; set; }

	[BinaryPoint(Offset = 25190, Source = "25190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25190", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_56 { get; set; }

	[BinaryPoint(Offset = 25192, Source = "25192", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25192", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_57 { get; set; }

	[BinaryPoint(Offset = 25194, Source = "25194", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25194", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_58 { get; set; }

	[BinaryPoint(Offset = 25196, Source = "25196", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25196", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_59 { get; set; }

	[BinaryPoint(Offset = 25198, Source = "25198", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25198", Category = "PLC/进料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 进料轴2_Vel_60 { get; set; }

	[BinaryPoint(Offset = 25200, Source = "25200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25200", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25202, Source = "25202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25202", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25204, Source = "25204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25204", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25206, Source = "25206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25206", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25208, Source = "25208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25208", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25210, Source = "25210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25210", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25212, Source = "25212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25212", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25214, Source = "25214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25214", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25216, Source = "25216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25216", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25218, Source = "25218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25218", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25220, Source = "25220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25220", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25222, Source = "25222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25222", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25224, Source = "25224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25224", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25226, Source = "25226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25226", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25228, Source = "25228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25228", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25230, Source = "25230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25230", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25232, Source = "25232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25232", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25234, Source = "25234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25234", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25236, Source = "25236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25236", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25238, Source = "25238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25238", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25240, Source = "25240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25240", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25242, Source = "25242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25242", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25244, Source = "25244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25244", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25246, Source = "25246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25246", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25248, Source = "25248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25248", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25250, Source = "25250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25250", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25252, Source = "25252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25252", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25254, Source = "25254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25254", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25256, Source = "25256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25256", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25258, Source = "25258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25258", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25260, Source = "25260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25260", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25262, Source = "25262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25262", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25264, Source = "25264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25264", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25266, Source = "25266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25266", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25268, Source = "25268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25268", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25270, Source = "25270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25270", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25272, Source = "25272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25272", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25274, Source = "25274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25274", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25276, Source = "25276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25276", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25278, Source = "25278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25278", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25280, Source = "25280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25280", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25282, Source = "25282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25282", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_42 { get; set; }

	[BinaryPoint(Offset = 25284, Source = "25284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25284", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_43 { get; set; }

	[BinaryPoint(Offset = 25286, Source = "25286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25286", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_44 { get; set; }

	[BinaryPoint(Offset = 25288, Source = "25288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25288", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_45 { get; set; }

	[BinaryPoint(Offset = 25290, Source = "25290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25290", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_46 { get; set; }

	[BinaryPoint(Offset = 25292, Source = "25292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25292", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_47 { get; set; }

	[BinaryPoint(Offset = 25294, Source = "25294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25294", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_48 { get; set; }

	[BinaryPoint(Offset = 25296, Source = "25296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25296", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_49 { get; set; }

	[BinaryPoint(Offset = 25298, Source = "25298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25298", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_50 { get; set; }

	[BinaryPoint(Offset = 25300, Source = "25300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25300", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_51 { get; set; }

	[BinaryPoint(Offset = 25302, Source = "25302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25302", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_52 { get; set; }

	[BinaryPoint(Offset = 25304, Source = "25304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25304", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_53 { get; set; }

	[BinaryPoint(Offset = 25306, Source = "25306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25306", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_54 { get; set; }

	[BinaryPoint(Offset = 25308, Source = "25308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25308", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_55 { get; set; }

	[BinaryPoint(Offset = 25310, Source = "25310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25310", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_56 { get; set; }

	[BinaryPoint(Offset = 25312, Source = "25312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25312", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_57 { get; set; }

	[BinaryPoint(Offset = 25314, Source = "25314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25314", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_58 { get; set; }

	[BinaryPoint(Offset = 25316, Source = "25316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25316", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_59 { get; set; }

	[BinaryPoint(Offset = 25318, Source = "25318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25318", Category = "PLC/龙门轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Pos_60 { get; set; }

	[BinaryPoint(Offset = 25320, Source = "25320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25320", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25322, Source = "25322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25322", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25324, Source = "25324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25324", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25326, Source = "25326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25326", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25328, Source = "25328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25328", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25330, Source = "25330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25330", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25332, Source = "25332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25332", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25334, Source = "25334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25334", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25336, Source = "25336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25336", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25338, Source = "25338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25338", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25340, Source = "25340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25340", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25342, Source = "25342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25342", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25344, Source = "25344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25344", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25346, Source = "25346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25346", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25348, Source = "25348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25348", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25350, Source = "25350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25350", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25352, Source = "25352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25352", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25354, Source = "25354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25354", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25356, Source = "25356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25356", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25358, Source = "25358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25358", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25360, Source = "25360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25360", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25362, Source = "25362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25362", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25364, Source = "25364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25364", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25366, Source = "25366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25366", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25368, Source = "25368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25368", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25370, Source = "25370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25370", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25372, Source = "25372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25372", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25374, Source = "25374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25374", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25376, Source = "25376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25376", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25378, Source = "25378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25378", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25380, Source = "25380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25380", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25382, Source = "25382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25382", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25384, Source = "25384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25384", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25386, Source = "25386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25386", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25388, Source = "25388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25388", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25390, Source = "25390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25390", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25392, Source = "25392", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25392", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25394, Source = "25394", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25394", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25396, Source = "25396", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25396", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25398, Source = "25398", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25398", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25400, Source = "25400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25400", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25402, Source = "25402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25402", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_42 { get; set; }

	[BinaryPoint(Offset = 25404, Source = "25404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25404", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_43 { get; set; }

	[BinaryPoint(Offset = 25406, Source = "25406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25406", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_44 { get; set; }

	[BinaryPoint(Offset = 25408, Source = "25408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25408", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_45 { get; set; }

	[BinaryPoint(Offset = 25410, Source = "25410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25410", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_46 { get; set; }

	[BinaryPoint(Offset = 25412, Source = "25412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25412", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_47 { get; set; }

	[BinaryPoint(Offset = 25414, Source = "25414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25414", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_48 { get; set; }

	[BinaryPoint(Offset = 25416, Source = "25416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25416", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_49 { get; set; }

	[BinaryPoint(Offset = 25418, Source = "25418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25418", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_50 { get; set; }

	[BinaryPoint(Offset = 25420, Source = "25420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25420", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_51 { get; set; }

	[BinaryPoint(Offset = 25422, Source = "25422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25422", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_52 { get; set; }

	[BinaryPoint(Offset = 25424, Source = "25424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25424", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_53 { get; set; }

	[BinaryPoint(Offset = 25426, Source = "25426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25426", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_54 { get; set; }

	[BinaryPoint(Offset = 25428, Source = "25428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25428", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_55 { get; set; }

	[BinaryPoint(Offset = 25430, Source = "25430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25430", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_56 { get; set; }

	[BinaryPoint(Offset = 25432, Source = "25432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25432", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_57 { get; set; }

	[BinaryPoint(Offset = 25434, Source = "25434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25434", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_58 { get; set; }

	[BinaryPoint(Offset = 25436, Source = "25436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25436", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_59 { get; set; }

	[BinaryPoint(Offset = 25438, Source = "25438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25438", Category = "PLC/龙门轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门轴1_Vel_60 { get; set; }

	[BinaryPoint(Offset = 25440, Source = "25440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25440", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25442, Source = "25442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25442", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25444, Source = "25444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25444", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25446, Source = "25446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25446", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25448, Source = "25448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25448", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25450, Source = "25450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25450", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25452, Source = "25452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25452", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25454, Source = "25454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25454", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25456, Source = "25456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25456", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25458, Source = "25458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25458", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25460, Source = "25460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25460", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25462, Source = "25462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25462", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25464, Source = "25464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25464", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25466, Source = "25466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25466", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25468, Source = "25468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25468", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25470, Source = "25470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25470", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25472, Source = "25472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25472", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25474, Source = "25474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25474", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25476, Source = "25476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25476", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25478, Source = "25478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25478", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25480, Source = "25480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25480", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25482, Source = "25482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25482", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25484, Source = "25484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25484", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25486, Source = "25486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25486", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25488, Source = "25488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25488", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25490, Source = "25490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25490", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25492, Source = "25492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25492", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25494, Source = "25494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25494", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25496, Source = "25496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25496", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25498, Source = "25498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25498", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25500, Source = "25500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25500", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25502, Source = "25502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25502", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25504, Source = "25504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25504", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25506, Source = "25506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25506", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25508, Source = "25508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25508", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25510, Source = "25510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25510", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25512, Source = "25512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25512", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25514, Source = "25514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25514", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25516, Source = "25516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25516", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25518, Source = "25518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25518", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25520, Source = "25520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25520", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25522, Source = "25522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25522", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 25524, Source = "25524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25524", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_43 { get; set; }

	[BinaryPoint(Offset = 25526, Source = "25526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25526", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_44 { get; set; }

	[BinaryPoint(Offset = 25528, Source = "25528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25528", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_45 { get; set; }

	[BinaryPoint(Offset = 25530, Source = "25530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25530", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_46 { get; set; }

	[BinaryPoint(Offset = 25532, Source = "25532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25532", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_47 { get; set; }

	[BinaryPoint(Offset = 25534, Source = "25534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25534", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_48 { get; set; }

	[BinaryPoint(Offset = 25536, Source = "25536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25536", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_49 { get; set; }

	[BinaryPoint(Offset = 25538, Source = "25538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25538", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_50 { get; set; }

	[BinaryPoint(Offset = 25540, Source = "25540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25540", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_51 { get; set; }

	[BinaryPoint(Offset = 25542, Source = "25542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25542", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_52 { get; set; }

	[BinaryPoint(Offset = 25544, Source = "25544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25544", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_53 { get; set; }

	[BinaryPoint(Offset = 25546, Source = "25546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25546", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_54 { get; set; }

	[BinaryPoint(Offset = 25548, Source = "25548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25548", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_55 { get; set; }

	[BinaryPoint(Offset = 25550, Source = "25550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25550", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_56 { get; set; }

	[BinaryPoint(Offset = 25552, Source = "25552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25552", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_57 { get; set; }

	[BinaryPoint(Offset = 25554, Source = "25554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25554", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_58 { get; set; }

	[BinaryPoint(Offset = 25556, Source = "25556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25556", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_59 { get; set; }

	[BinaryPoint(Offset = 25558, Source = "25558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25558", Category = "PLC/龙门平移轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Pos_60 { get; set; }

	[BinaryPoint(Offset = 25560, Source = "25560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25560", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25562, Source = "25562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25562", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25564, Source = "25564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25564", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25566, Source = "25566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25566", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25568, Source = "25568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25568", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25570, Source = "25570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25570", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25572, Source = "25572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25572", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25574, Source = "25574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25574", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25576, Source = "25576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25576", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25578, Source = "25578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25578", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25580, Source = "25580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25580", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25582, Source = "25582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25582", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25584, Source = "25584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25584", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25586, Source = "25586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25586", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25588, Source = "25588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25588", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25590, Source = "25590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25590", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25592, Source = "25592", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25592", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25594, Source = "25594", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25594", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25596, Source = "25596", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25596", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25598, Source = "25598", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25598", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25600, Source = "25600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25600", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25602, Source = "25602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25602", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25604, Source = "25604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25604", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25606, Source = "25606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25606", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25608, Source = "25608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25608", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25610, Source = "25610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25610", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25612, Source = "25612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25612", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25614, Source = "25614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25614", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25616, Source = "25616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25616", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25618, Source = "25618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25618", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25620, Source = "25620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25620", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25622, Source = "25622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25622", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25624, Source = "25624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25624", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25626, Source = "25626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25626", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25628, Source = "25628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25628", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25630, Source = "25630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25630", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25632, Source = "25632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25632", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25634, Source = "25634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25634", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25636, Source = "25636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25636", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25638, Source = "25638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25638", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25640, Source = "25640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25640", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25642, Source = "25642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25642", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_42 { get; set; }

	[BinaryPoint(Offset = 25644, Source = "25644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25644", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_43 { get; set; }

	[BinaryPoint(Offset = 25646, Source = "25646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25646", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_44 { get; set; }

	[BinaryPoint(Offset = 25648, Source = "25648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25648", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_45 { get; set; }

	[BinaryPoint(Offset = 25650, Source = "25650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25650", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_46 { get; set; }

	[BinaryPoint(Offset = 25652, Source = "25652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25652", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_47 { get; set; }

	[BinaryPoint(Offset = 25654, Source = "25654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25654", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_48 { get; set; }

	[BinaryPoint(Offset = 25656, Source = "25656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25656", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_49 { get; set; }

	[BinaryPoint(Offset = 25658, Source = "25658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25658", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_50 { get; set; }

	[BinaryPoint(Offset = 25660, Source = "25660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25660", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_51 { get; set; }

	[BinaryPoint(Offset = 25662, Source = "25662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25662", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_52 { get; set; }

	[BinaryPoint(Offset = 25664, Source = "25664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25664", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_53 { get; set; }

	[BinaryPoint(Offset = 25666, Source = "25666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25666", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_54 { get; set; }

	[BinaryPoint(Offset = 25668, Source = "25668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25668", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_55 { get; set; }

	[BinaryPoint(Offset = 25670, Source = "25670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25670", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_56 { get; set; }

	[BinaryPoint(Offset = 25672, Source = "25672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25672", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_57 { get; set; }

	[BinaryPoint(Offset = 25674, Source = "25674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25674", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_58 { get; set; }

	[BinaryPoint(Offset = 25676, Source = "25676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25676", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_59 { get; set; }

	[BinaryPoint(Offset = 25678, Source = "25678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25678", Category = "PLC/龙门平移轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 龙门平移轴_Vel_60 { get; set; }

	[BinaryPoint(Offset = 25680, Source = "25680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25680", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25682, Source = "25682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25682", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25684, Source = "25684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25684", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25686, Source = "25686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25686", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25688, Source = "25688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25688", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25690, Source = "25690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25690", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25692, Source = "25692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25692", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25694, Source = "25694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25694", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25696, Source = "25696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25696", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25698, Source = "25698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25698", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25700, Source = "25700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25700", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25702, Source = "25702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25702", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25704, Source = "25704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25704", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25706, Source = "25706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25706", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25708, Source = "25708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25708", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25710, Source = "25710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25710", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25712, Source = "25712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25712", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25714, Source = "25714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25714", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25716, Source = "25716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25716", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25718, Source = "25718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25718", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25720, Source = "25720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25720", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25722, Source = "25722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25722", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25724, Source = "25724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25724", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25726, Source = "25726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25726", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25728, Source = "25728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25728", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25730, Source = "25730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25730", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25732, Source = "25732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25732", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25734, Source = "25734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25734", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25736, Source = "25736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25736", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25738, Source = "25738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25738", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25740, Source = "25740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25740", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25742, Source = "25742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25742", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25744, Source = "25744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25744", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25746, Source = "25746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25746", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25748, Source = "25748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25748", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25750, Source = "25750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25750", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25752, Source = "25752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25752", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25754, Source = "25754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25754", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25756, Source = "25756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25756", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25758, Source = "25758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25758", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25760, Source = "25760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25760", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25762, Source = "25762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25762", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 25764, Source = "25764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25764", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_43 { get; set; }

	[BinaryPoint(Offset = 25766, Source = "25766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25766", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_44 { get; set; }

	[BinaryPoint(Offset = 25768, Source = "25768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25768", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_45 { get; set; }

	[BinaryPoint(Offset = 25770, Source = "25770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25770", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_46 { get; set; }

	[BinaryPoint(Offset = 25772, Source = "25772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25772", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_47 { get; set; }

	[BinaryPoint(Offset = 25774, Source = "25774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25774", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_48 { get; set; }

	[BinaryPoint(Offset = 25776, Source = "25776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25776", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_49 { get; set; }

	[BinaryPoint(Offset = 25778, Source = "25778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25778", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_50 { get; set; }

	[BinaryPoint(Offset = 25780, Source = "25780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25780", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_51 { get; set; }

	[BinaryPoint(Offset = 25782, Source = "25782", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25782", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_52 { get; set; }

	[BinaryPoint(Offset = 25784, Source = "25784", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25784", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_53 { get; set; }

	[BinaryPoint(Offset = 25786, Source = "25786", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25786", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_54 { get; set; }

	[BinaryPoint(Offset = 25788, Source = "25788", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25788", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_55 { get; set; }

	[BinaryPoint(Offset = 25790, Source = "25790", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25790", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_56 { get; set; }

	[BinaryPoint(Offset = 25792, Source = "25792", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25792", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_57 { get; set; }

	[BinaryPoint(Offset = 25794, Source = "25794", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25794", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_58 { get; set; }

	[BinaryPoint(Offset = 25796, Source = "25796", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25796", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_59 { get; set; }

	[BinaryPoint(Offset = 25798, Source = "25798", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25798", Category = "PLC/相机Z轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Pos_60 { get; set; }

	[BinaryPoint(Offset = 25800, Source = "25800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25800", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25802, Source = "25802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25802", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25804, Source = "25804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25804", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25806, Source = "25806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25806", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25808, Source = "25808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25808", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25810, Source = "25810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25810", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25812, Source = "25812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25812", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25814, Source = "25814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25814", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25816, Source = "25816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25816", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25818, Source = "25818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25818", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25820, Source = "25820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25820", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25822, Source = "25822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25822", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25824, Source = "25824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25824", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25826, Source = "25826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25826", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25828, Source = "25828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25828", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25830, Source = "25830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25830", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25832, Source = "25832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25832", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25834, Source = "25834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25834", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25836, Source = "25836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25836", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25838, Source = "25838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25838", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25840, Source = "25840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25840", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25842, Source = "25842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25842", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25844, Source = "25844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25844", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25846, Source = "25846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25846", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25848, Source = "25848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25848", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25850, Source = "25850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25850", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25852, Source = "25852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25852", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25854, Source = "25854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25854", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25856, Source = "25856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25856", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25858, Source = "25858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25858", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25860, Source = "25860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25860", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25862, Source = "25862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25862", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25864, Source = "25864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25864", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25866, Source = "25866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25866", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25868, Source = "25868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25868", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25870, Source = "25870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25870", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25872, Source = "25872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25872", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25874, Source = "25874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25874", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25876, Source = "25876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25876", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25878, Source = "25878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25878", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25880, Source = "25880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25880", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25882, Source = "25882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25882", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_42 { get; set; }

	[BinaryPoint(Offset = 25884, Source = "25884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25884", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_43 { get; set; }

	[BinaryPoint(Offset = 25886, Source = "25886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25886", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_44 { get; set; }

	[BinaryPoint(Offset = 25888, Source = "25888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25888", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_45 { get; set; }

	[BinaryPoint(Offset = 25890, Source = "25890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25890", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_46 { get; set; }

	[BinaryPoint(Offset = 25892, Source = "25892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25892", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_47 { get; set; }

	[BinaryPoint(Offset = 25894, Source = "25894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25894", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_48 { get; set; }

	[BinaryPoint(Offset = 25896, Source = "25896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25896", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_49 { get; set; }

	[BinaryPoint(Offset = 25898, Source = "25898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25898", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_50 { get; set; }

	[BinaryPoint(Offset = 25900, Source = "25900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25900", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_51 { get; set; }

	[BinaryPoint(Offset = 25902, Source = "25902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25902", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_52 { get; set; }

	[BinaryPoint(Offset = 25904, Source = "25904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25904", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_53 { get; set; }

	[BinaryPoint(Offset = 25906, Source = "25906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25906", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_54 { get; set; }

	[BinaryPoint(Offset = 25908, Source = "25908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25908", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_55 { get; set; }

	[BinaryPoint(Offset = 25910, Source = "25910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25910", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_56 { get; set; }

	[BinaryPoint(Offset = 25912, Source = "25912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25912", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_57 { get; set; }

	[BinaryPoint(Offset = 25914, Source = "25914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25914", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_58 { get; set; }

	[BinaryPoint(Offset = 25916, Source = "25916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25916", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_59 { get; set; }

	[BinaryPoint(Offset = 25918, Source = "25918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25918", Category = "PLC/相机Z轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机Z轴_Vel_60 { get; set; }

	[BinaryPoint(Offset = 25920, Source = "25920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25920", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25922, Source = "25922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25922", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25924, Source = "25924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25924", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25926, Source = "25926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25926", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25928, Source = "25928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25928", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25930, Source = "25930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25930", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25932, Source = "25932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25932", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25934, Source = "25934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25934", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25936, Source = "25936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25936", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25938, Source = "25938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25938", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25940, Source = "25940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25940", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25942, Source = "25942", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25942", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25944, Source = "25944", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25944", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25946, Source = "25946", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25946", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25948, Source = "25948", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25948", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25950, Source = "25950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25950", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25952, Source = "25952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25952", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25954, Source = "25954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25954", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25956, Source = "25956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25956", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25958, Source = "25958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25958", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25960, Source = "25960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25960", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25962, Source = "25962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25962", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25964, Source = "25964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25964", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25966, Source = "25966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25966", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25968, Source = "25968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25968", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25970, Source = "25970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25970", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25972, Source = "25972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25972", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25974, Source = "25974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25974", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25976, Source = "25976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25976", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25978, Source = "25978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25978", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25980, Source = "25980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25980", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25982, Source = "25982", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25982", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25984, Source = "25984", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25984", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25986, Source = "25986", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25986", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25988, Source = "25988", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25988", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25990, Source = "25990", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25990", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25992, Source = "25992", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25992", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25994, Source = "25994", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25994", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25996, Source = "25996", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25996", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25998, Source = "25998", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25998", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26000, Source = "26000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26000", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26002, Source = "26002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26002", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_42 { get; set; }

	[BinaryPoint(Offset = 26004, Source = "26004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26004", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_43 { get; set; }

	[BinaryPoint(Offset = 26006, Source = "26006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26006", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_44 { get; set; }

	[BinaryPoint(Offset = 26008, Source = "26008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26008", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_45 { get; set; }

	[BinaryPoint(Offset = 26010, Source = "26010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26010", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_46 { get; set; }

	[BinaryPoint(Offset = 26012, Source = "26012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26012", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_47 { get; set; }

	[BinaryPoint(Offset = 26014, Source = "26014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26014", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_48 { get; set; }

	[BinaryPoint(Offset = 26016, Source = "26016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26016", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_49 { get; set; }

	[BinaryPoint(Offset = 26018, Source = "26018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26018", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_50 { get; set; }

	[BinaryPoint(Offset = 26020, Source = "26020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26020", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_51 { get; set; }

	[BinaryPoint(Offset = 26022, Source = "26022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26022", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_52 { get; set; }

	[BinaryPoint(Offset = 26024, Source = "26024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26024", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_53 { get; set; }

	[BinaryPoint(Offset = 26026, Source = "26026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26026", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_54 { get; set; }

	[BinaryPoint(Offset = 26028, Source = "26028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26028", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_55 { get; set; }

	[BinaryPoint(Offset = 26030, Source = "26030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26030", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_56 { get; set; }

	[BinaryPoint(Offset = 26032, Source = "26032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26032", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_57 { get; set; }

	[BinaryPoint(Offset = 26034, Source = "26034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26034", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_58 { get; set; }

	[BinaryPoint(Offset = 26036, Source = "26036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26036", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_59 { get; set; }

	[BinaryPoint(Offset = 26038, Source = "26038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26038", Category = "PLC/取料1_Z轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Pos_60 { get; set; }

	[BinaryPoint(Offset = 26040, Source = "26040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26040", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26042, Source = "26042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26042", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26044, Source = "26044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26044", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26046, Source = "26046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26046", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26048, Source = "26048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26048", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26050, Source = "26050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26050", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26052, Source = "26052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26052", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26054, Source = "26054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26054", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26056, Source = "26056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26056", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26058, Source = "26058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26058", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26060, Source = "26060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26060", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26062, Source = "26062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26062", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26064, Source = "26064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26064", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26066, Source = "26066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26066", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26068, Source = "26068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26068", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26070, Source = "26070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26070", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26072, Source = "26072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26072", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26074, Source = "26074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26074", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26076, Source = "26076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26076", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26078, Source = "26078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26078", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26080, Source = "26080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26080", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26082, Source = "26082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26082", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26084, Source = "26084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26084", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26086, Source = "26086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26086", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26088, Source = "26088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26088", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26090, Source = "26090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26090", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26092, Source = "26092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26092", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26094, Source = "26094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26094", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26096, Source = "26096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26096", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26098, Source = "26098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26098", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26100, Source = "26100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26100", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26102, Source = "26102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26102", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26104, Source = "26104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26104", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26106, Source = "26106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26106", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26108, Source = "26108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26108", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26110, Source = "26110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26110", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26112, Source = "26112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26112", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26114, Source = "26114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26114", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26116, Source = "26116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26116", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26118, Source = "26118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26118", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26120, Source = "26120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26120", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26122, Source = "26122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26122", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_42 { get; set; }

	[BinaryPoint(Offset = 26124, Source = "26124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26124", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_43 { get; set; }

	[BinaryPoint(Offset = 26126, Source = "26126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26126", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_44 { get; set; }

	[BinaryPoint(Offset = 26128, Source = "26128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26128", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_45 { get; set; }

	[BinaryPoint(Offset = 26130, Source = "26130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26130", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_46 { get; set; }

	[BinaryPoint(Offset = 26132, Source = "26132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26132", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_47 { get; set; }

	[BinaryPoint(Offset = 26134, Source = "26134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26134", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_48 { get; set; }

	[BinaryPoint(Offset = 26136, Source = "26136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26136", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_49 { get; set; }

	[BinaryPoint(Offset = 26138, Source = "26138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26138", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_50 { get; set; }

	[BinaryPoint(Offset = 26140, Source = "26140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26140", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_51 { get; set; }

	[BinaryPoint(Offset = 26142, Source = "26142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26142", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_52 { get; set; }

	[BinaryPoint(Offset = 26144, Source = "26144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26144", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_53 { get; set; }

	[BinaryPoint(Offset = 26146, Source = "26146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26146", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_54 { get; set; }

	[BinaryPoint(Offset = 26148, Source = "26148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26148", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_55 { get; set; }

	[BinaryPoint(Offset = 26150, Source = "26150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26150", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_56 { get; set; }

	[BinaryPoint(Offset = 26152, Source = "26152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26152", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_57 { get; set; }

	[BinaryPoint(Offset = 26154, Source = "26154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26154", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_58 { get; set; }

	[BinaryPoint(Offset = 26156, Source = "26156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26156", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_59 { get; set; }

	[BinaryPoint(Offset = 26158, Source = "26158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26158", Category = "PLC/取料1_Z轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴1_Vel_60 { get; set; }

	[BinaryPoint(Offset = 26160, Source = "26160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26160", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26162, Source = "26162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26162", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26164, Source = "26164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26164", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26166, Source = "26166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26166", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26168, Source = "26168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26168", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26170, Source = "26170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26170", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26172, Source = "26172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26172", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26174, Source = "26174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26174", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26176, Source = "26176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26176", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26178, Source = "26178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26178", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26180, Source = "26180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26180", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26182, Source = "26182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26182", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26184, Source = "26184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26184", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26186, Source = "26186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26186", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26188, Source = "26188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26188", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26190, Source = "26190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26190", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26192, Source = "26192", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26192", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26194, Source = "26194", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26194", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26196, Source = "26196", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26196", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26198, Source = "26198", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26198", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26200, Source = "26200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26200", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26202, Source = "26202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26202", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26204, Source = "26204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26204", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26206, Source = "26206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26206", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26208, Source = "26208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26208", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26210, Source = "26210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26210", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26212, Source = "26212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26212", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26214, Source = "26214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26214", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26216, Source = "26216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26216", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26218, Source = "26218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26218", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26220, Source = "26220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26220", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26222, Source = "26222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26222", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26224, Source = "26224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26224", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26226, Source = "26226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26226", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26228, Source = "26228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26228", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26230, Source = "26230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26230", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26232, Source = "26232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26232", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26234, Source = "26234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26234", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26236, Source = "26236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26236", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26238, Source = "26238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26238", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26240, Source = "26240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26240", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26242, Source = "26242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26242", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_42 { get; set; }

	[BinaryPoint(Offset = 26244, Source = "26244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26244", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_43 { get; set; }

	[BinaryPoint(Offset = 26246, Source = "26246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26246", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_44 { get; set; }

	[BinaryPoint(Offset = 26248, Source = "26248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26248", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_45 { get; set; }

	[BinaryPoint(Offset = 26250, Source = "26250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26250", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_46 { get; set; }

	[BinaryPoint(Offset = 26252, Source = "26252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26252", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_47 { get; set; }

	[BinaryPoint(Offset = 26254, Source = "26254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26254", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_48 { get; set; }

	[BinaryPoint(Offset = 26256, Source = "26256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26256", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_49 { get; set; }

	[BinaryPoint(Offset = 26258, Source = "26258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26258", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_50 { get; set; }

	[BinaryPoint(Offset = 26260, Source = "26260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26260", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_51 { get; set; }

	[BinaryPoint(Offset = 26262, Source = "26262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26262", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_52 { get; set; }

	[BinaryPoint(Offset = 26264, Source = "26264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26264", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_53 { get; set; }

	[BinaryPoint(Offset = 26266, Source = "26266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26266", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_54 { get; set; }

	[BinaryPoint(Offset = 26268, Source = "26268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26268", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_55 { get; set; }

	[BinaryPoint(Offset = 26270, Source = "26270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26270", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_56 { get; set; }

	[BinaryPoint(Offset = 26272, Source = "26272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26272", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_57 { get; set; }

	[BinaryPoint(Offset = 26274, Source = "26274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26274", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_58 { get; set; }

	[BinaryPoint(Offset = 26276, Source = "26276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26276", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_59 { get; set; }

	[BinaryPoint(Offset = 26278, Source = "26278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26278", Category = "PLC/取料1_R轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Pos_60 { get; set; }

	[BinaryPoint(Offset = 26280, Source = "26280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26280", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26282, Source = "26282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26282", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26284, Source = "26284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26284", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26286, Source = "26286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26286", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26288, Source = "26288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26288", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26290, Source = "26290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26290", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26292, Source = "26292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26292", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26294, Source = "26294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26294", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26296, Source = "26296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26296", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26298, Source = "26298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26298", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26300, Source = "26300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26300", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26302, Source = "26302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26302", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26304, Source = "26304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26304", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26306, Source = "26306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26306", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26308, Source = "26308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26308", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26310, Source = "26310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26310", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26312, Source = "26312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26312", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26314, Source = "26314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26314", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26316, Source = "26316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26316", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26318, Source = "26318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26318", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26320, Source = "26320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26320", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26322, Source = "26322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26322", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26324, Source = "26324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26324", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26326, Source = "26326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26326", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26328, Source = "26328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26328", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26330, Source = "26330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26330", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26332, Source = "26332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26332", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26334, Source = "26334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26334", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26336, Source = "26336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26336", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26338, Source = "26338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26338", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26340, Source = "26340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26340", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26342, Source = "26342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26342", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26344, Source = "26344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26344", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26346, Source = "26346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26346", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26348, Source = "26348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26348", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26350, Source = "26350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26350", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26352, Source = "26352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26352", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26354, Source = "26354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26354", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26356, Source = "26356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26356", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26358, Source = "26358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26358", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26360, Source = "26360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26360", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26362, Source = "26362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26362", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_42 { get; set; }

	[BinaryPoint(Offset = 26364, Source = "26364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26364", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_43 { get; set; }

	[BinaryPoint(Offset = 26366, Source = "26366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26366", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_44 { get; set; }

	[BinaryPoint(Offset = 26368, Source = "26368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26368", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_45 { get; set; }

	[BinaryPoint(Offset = 26370, Source = "26370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26370", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_46 { get; set; }

	[BinaryPoint(Offset = 26372, Source = "26372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26372", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_47 { get; set; }

	[BinaryPoint(Offset = 26374, Source = "26374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26374", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_48 { get; set; }

	[BinaryPoint(Offset = 26376, Source = "26376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26376", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_49 { get; set; }

	[BinaryPoint(Offset = 26378, Source = "26378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26378", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_50 { get; set; }

	[BinaryPoint(Offset = 26380, Source = "26380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26380", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_51 { get; set; }

	[BinaryPoint(Offset = 26382, Source = "26382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26382", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_52 { get; set; }

	[BinaryPoint(Offset = 26384, Source = "26384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26384", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_53 { get; set; }

	[BinaryPoint(Offset = 26386, Source = "26386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26386", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_54 { get; set; }

	[BinaryPoint(Offset = 26388, Source = "26388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26388", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_55 { get; set; }

	[BinaryPoint(Offset = 26390, Source = "26390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26390", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_56 { get; set; }

	[BinaryPoint(Offset = 26392, Source = "26392", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26392", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_57 { get; set; }

	[BinaryPoint(Offset = 26394, Source = "26394", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26394", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_58 { get; set; }

	[BinaryPoint(Offset = 26396, Source = "26396", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26396", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_59 { get; set; }

	[BinaryPoint(Offset = 26398, Source = "26398", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26398", Category = "PLC/取料1_R轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴1_Vel_60 { get; set; }

	[BinaryPoint(Offset = 26400, Source = "26400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26400", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26402, Source = "26402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26402", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26404, Source = "26404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26404", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26406, Source = "26406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26406", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26408, Source = "26408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26408", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26410, Source = "26410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26410", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26412, Source = "26412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26412", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26414, Source = "26414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26414", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26416, Source = "26416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26416", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26418, Source = "26418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26418", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26420, Source = "26420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26420", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26422, Source = "26422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26422", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26424, Source = "26424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26424", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26426, Source = "26426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26426", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26428, Source = "26428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26428", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26430, Source = "26430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26430", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26432, Source = "26432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26432", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26434, Source = "26434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26434", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26436, Source = "26436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26436", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26438, Source = "26438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26438", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26440, Source = "26440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26440", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26442, Source = "26442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26442", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26444, Source = "26444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26444", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26446, Source = "26446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26446", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26448, Source = "26448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26448", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26450, Source = "26450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26450", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26452, Source = "26452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26452", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26454, Source = "26454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26454", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26456, Source = "26456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26456", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26458, Source = "26458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26458", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26460, Source = "26460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26460", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26462, Source = "26462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26462", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26464, Source = "26464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26464", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26466, Source = "26466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26466", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26468, Source = "26468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26468", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26470, Source = "26470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26470", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26472, Source = "26472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26472", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26474, Source = "26474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26474", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26476, Source = "26476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26476", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26478, Source = "26478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26478", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26480, Source = "26480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26480", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26482, Source = "26482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26482", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_42 { get; set; }

	[BinaryPoint(Offset = 26484, Source = "26484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26484", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_43 { get; set; }

	[BinaryPoint(Offset = 26486, Source = "26486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26486", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_44 { get; set; }

	[BinaryPoint(Offset = 26488, Source = "26488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26488", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_45 { get; set; }

	[BinaryPoint(Offset = 26490, Source = "26490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26490", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_46 { get; set; }

	[BinaryPoint(Offset = 26492, Source = "26492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26492", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_47 { get; set; }

	[BinaryPoint(Offset = 26494, Source = "26494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26494", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_48 { get; set; }

	[BinaryPoint(Offset = 26496, Source = "26496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26496", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_49 { get; set; }

	[BinaryPoint(Offset = 26498, Source = "26498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26498", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_50 { get; set; }

	[BinaryPoint(Offset = 26500, Source = "26500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26500", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_51 { get; set; }

	[BinaryPoint(Offset = 26502, Source = "26502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26502", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_52 { get; set; }

	[BinaryPoint(Offset = 26504, Source = "26504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26504", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_53 { get; set; }

	[BinaryPoint(Offset = 26506, Source = "26506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26506", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_54 { get; set; }

	[BinaryPoint(Offset = 26508, Source = "26508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26508", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_55 { get; set; }

	[BinaryPoint(Offset = 26510, Source = "26510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26510", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_56 { get; set; }

	[BinaryPoint(Offset = 26512, Source = "26512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26512", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_57 { get; set; }

	[BinaryPoint(Offset = 26514, Source = "26514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26514", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_58 { get; set; }

	[BinaryPoint(Offset = 26516, Source = "26516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26516", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_59 { get; set; }

	[BinaryPoint(Offset = 26518, Source = "26518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26518", Category = "PLC/取料1_Z轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Pos_60 { get; set; }

	[BinaryPoint(Offset = 26520, Source = "26520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26520", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26522, Source = "26522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26522", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26524, Source = "26524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26524", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26526, Source = "26526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26526", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26528, Source = "26528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26528", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26530, Source = "26530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26530", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26532, Source = "26532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26532", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26534, Source = "26534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26534", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26536, Source = "26536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26536", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26538, Source = "26538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26538", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26540, Source = "26540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26540", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26542, Source = "26542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26542", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26544, Source = "26544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26544", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26546, Source = "26546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26546", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26548, Source = "26548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26548", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26550, Source = "26550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26550", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26552, Source = "26552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26552", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26554, Source = "26554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26554", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26556, Source = "26556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26556", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26558, Source = "26558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26558", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26560, Source = "26560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26560", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26562, Source = "26562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26562", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26564, Source = "26564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26564", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26566, Source = "26566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26566", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26568, Source = "26568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26568", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26570, Source = "26570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26570", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26572, Source = "26572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26572", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26574, Source = "26574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26574", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26576, Source = "26576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26576", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26578, Source = "26578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26578", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26580, Source = "26580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26580", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26582, Source = "26582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26582", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26584, Source = "26584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26584", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26586, Source = "26586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26586", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26588, Source = "26588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26588", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26590, Source = "26590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26590", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26592, Source = "26592", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26592", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26594, Source = "26594", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26594", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26596, Source = "26596", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26596", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26598, Source = "26598", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26598", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26600, Source = "26600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26600", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26602, Source = "26602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26602", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_42 { get; set; }

	[BinaryPoint(Offset = 26604, Source = "26604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26604", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_43 { get; set; }

	[BinaryPoint(Offset = 26606, Source = "26606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26606", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_44 { get; set; }

	[BinaryPoint(Offset = 26608, Source = "26608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26608", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_45 { get; set; }

	[BinaryPoint(Offset = 26610, Source = "26610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26610", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_46 { get; set; }

	[BinaryPoint(Offset = 26612, Source = "26612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26612", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_47 { get; set; }

	[BinaryPoint(Offset = 26614, Source = "26614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26614", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_48 { get; set; }

	[BinaryPoint(Offset = 26616, Source = "26616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26616", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_49 { get; set; }

	[BinaryPoint(Offset = 26618, Source = "26618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26618", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_50 { get; set; }

	[BinaryPoint(Offset = 26620, Source = "26620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26620", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_51 { get; set; }

	[BinaryPoint(Offset = 26622, Source = "26622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26622", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_52 { get; set; }

	[BinaryPoint(Offset = 26624, Source = "26624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26624", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_53 { get; set; }

	[BinaryPoint(Offset = 26626, Source = "26626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26626", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_54 { get; set; }

	[BinaryPoint(Offset = 26628, Source = "26628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26628", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_55 { get; set; }

	[BinaryPoint(Offset = 26630, Source = "26630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26630", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_56 { get; set; }

	[BinaryPoint(Offset = 26632, Source = "26632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26632", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_57 { get; set; }

	[BinaryPoint(Offset = 26634, Source = "26634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26634", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_58 { get; set; }

	[BinaryPoint(Offset = 26636, Source = "26636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26636", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_59 { get; set; }

	[BinaryPoint(Offset = 26638, Source = "26638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26638", Category = "PLC/取料1_Z轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴2_Vel_60 { get; set; }

	[BinaryPoint(Offset = 26640, Source = "26640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26640", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26642, Source = "26642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26642", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26644, Source = "26644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26644", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26646, Source = "26646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26646", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26648, Source = "26648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26648", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26650, Source = "26650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26650", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26652, Source = "26652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26652", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26654, Source = "26654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26654", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26656, Source = "26656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26656", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26658, Source = "26658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26658", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26660, Source = "26660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26660", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26662, Source = "26662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26662", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26664, Source = "26664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26664", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26666, Source = "26666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26666", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26668, Source = "26668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26668", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26670, Source = "26670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26670", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26672, Source = "26672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26672", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26674, Source = "26674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26674", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26676, Source = "26676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26676", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26678, Source = "26678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26678", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26680, Source = "26680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26680", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26682, Source = "26682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26682", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26684, Source = "26684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26684", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26686, Source = "26686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26686", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26688, Source = "26688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26688", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26690, Source = "26690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26690", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26692, Source = "26692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26692", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26694, Source = "26694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26694", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26696, Source = "26696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26696", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26698, Source = "26698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26698", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26700, Source = "26700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26700", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26702, Source = "26702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26702", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26704, Source = "26704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26704", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26706, Source = "26706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26706", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26708, Source = "26708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26708", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26710, Source = "26710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26710", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26712, Source = "26712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26712", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26714, Source = "26714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26714", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26716, Source = "26716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26716", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26718, Source = "26718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26718", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26720, Source = "26720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26720", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26722, Source = "26722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26722", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_42 { get; set; }

	[BinaryPoint(Offset = 26724, Source = "26724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26724", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_43 { get; set; }

	[BinaryPoint(Offset = 26726, Source = "26726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26726", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_44 { get; set; }

	[BinaryPoint(Offset = 26728, Source = "26728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26728", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_45 { get; set; }

	[BinaryPoint(Offset = 26730, Source = "26730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26730", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_46 { get; set; }

	[BinaryPoint(Offset = 26732, Source = "26732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26732", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_47 { get; set; }

	[BinaryPoint(Offset = 26734, Source = "26734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26734", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_48 { get; set; }

	[BinaryPoint(Offset = 26736, Source = "26736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26736", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_49 { get; set; }

	[BinaryPoint(Offset = 26738, Source = "26738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26738", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_50 { get; set; }

	[BinaryPoint(Offset = 26740, Source = "26740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26740", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_51 { get; set; }

	[BinaryPoint(Offset = 26742, Source = "26742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26742", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_52 { get; set; }

	[BinaryPoint(Offset = 26744, Source = "26744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26744", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_53 { get; set; }

	[BinaryPoint(Offset = 26746, Source = "26746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26746", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_54 { get; set; }

	[BinaryPoint(Offset = 26748, Source = "26748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26748", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_55 { get; set; }

	[BinaryPoint(Offset = 26750, Source = "26750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26750", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_56 { get; set; }

	[BinaryPoint(Offset = 26752, Source = "26752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26752", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_57 { get; set; }

	[BinaryPoint(Offset = 26754, Source = "26754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26754", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_58 { get; set; }

	[BinaryPoint(Offset = 26756, Source = "26756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26756", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_59 { get; set; }

	[BinaryPoint(Offset = 26758, Source = "26758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26758", Category = "PLC/取料1_R轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Pos_60 { get; set; }

	[BinaryPoint(Offset = 26760, Source = "26760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26760", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26762, Source = "26762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26762", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26764, Source = "26764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26764", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26766, Source = "26766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26766", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26768, Source = "26768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26768", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26770, Source = "26770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26770", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26772, Source = "26772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26772", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26774, Source = "26774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26774", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26776, Source = "26776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26776", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26778, Source = "26778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26778", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26780, Source = "26780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26780", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26782, Source = "26782", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26782", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26784, Source = "26784", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26784", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26786, Source = "26786", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26786", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26788, Source = "26788", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26788", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26790, Source = "26790", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26790", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26792, Source = "26792", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26792", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26794, Source = "26794", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26794", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26796, Source = "26796", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26796", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26798, Source = "26798", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26798", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26800, Source = "26800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26800", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26802, Source = "26802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26802", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26804, Source = "26804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26804", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26806, Source = "26806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26806", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26808, Source = "26808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26808", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26810, Source = "26810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26810", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26812, Source = "26812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26812", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26814, Source = "26814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26814", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26816, Source = "26816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26816", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26818, Source = "26818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26818", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26820, Source = "26820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26820", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26822, Source = "26822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26822", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26824, Source = "26824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26824", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26826, Source = "26826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26826", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26828, Source = "26828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26828", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26830, Source = "26830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26830", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26832, Source = "26832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26832", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26834, Source = "26834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26834", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26836, Source = "26836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26836", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26838, Source = "26838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26838", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26840, Source = "26840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26840", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26842, Source = "26842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26842", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_42 { get; set; }

	[BinaryPoint(Offset = 26844, Source = "26844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26844", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_43 { get; set; }

	[BinaryPoint(Offset = 26846, Source = "26846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26846", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_44 { get; set; }

	[BinaryPoint(Offset = 26848, Source = "26848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26848", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_45 { get; set; }

	[BinaryPoint(Offset = 26850, Source = "26850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26850", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_46 { get; set; }

	[BinaryPoint(Offset = 26852, Source = "26852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26852", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_47 { get; set; }

	[BinaryPoint(Offset = 26854, Source = "26854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26854", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_48 { get; set; }

	[BinaryPoint(Offset = 26856, Source = "26856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26856", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_49 { get; set; }

	[BinaryPoint(Offset = 26858, Source = "26858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26858", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_50 { get; set; }

	[BinaryPoint(Offset = 26860, Source = "26860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26860", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_51 { get; set; }

	[BinaryPoint(Offset = 26862, Source = "26862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26862", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_52 { get; set; }

	[BinaryPoint(Offset = 26864, Source = "26864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26864", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_53 { get; set; }

	[BinaryPoint(Offset = 26866, Source = "26866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26866", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_54 { get; set; }

	[BinaryPoint(Offset = 26868, Source = "26868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26868", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_55 { get; set; }

	[BinaryPoint(Offset = 26870, Source = "26870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26870", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_56 { get; set; }

	[BinaryPoint(Offset = 26872, Source = "26872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26872", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_57 { get; set; }

	[BinaryPoint(Offset = 26874, Source = "26874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26874", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_58 { get; set; }

	[BinaryPoint(Offset = 26876, Source = "26876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26876", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_59 { get; set; }

	[BinaryPoint(Offset = 26878, Source = "26878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26878", Category = "PLC/取料1_R轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴2_Vel_60 { get; set; }

	[BinaryPoint(Offset = 26880, Source = "26880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26880", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26882, Source = "26882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26882", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26884, Source = "26884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26884", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26886, Source = "26886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26886", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26888, Source = "26888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26888", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26890, Source = "26890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26890", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26892, Source = "26892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26892", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26894, Source = "26894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26894", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26896, Source = "26896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26896", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26898, Source = "26898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26898", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26900, Source = "26900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26900", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26902, Source = "26902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26902", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26904, Source = "26904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26904", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26906, Source = "26906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26906", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26908, Source = "26908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26908", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26910, Source = "26910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26910", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26912, Source = "26912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26912", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26914, Source = "26914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26914", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26916, Source = "26916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26916", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26918, Source = "26918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26918", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26920, Source = "26920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26920", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26922, Source = "26922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26922", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26924, Source = "26924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26924", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26926, Source = "26926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26926", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26928, Source = "26928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26928", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26930, Source = "26930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26930", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26932, Source = "26932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26932", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26934, Source = "26934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26934", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26936, Source = "26936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26936", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26938, Source = "26938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26938", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26940, Source = "26940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26940", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26942, Source = "26942", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26942", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26944, Source = "26944", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26944", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26946, Source = "26946", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26946", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26948, Source = "26948", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26948", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26950, Source = "26950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26950", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26952, Source = "26952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26952", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26954, Source = "26954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26954", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26956, Source = "26956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26956", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26958, Source = "26958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26958", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26960, Source = "26960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26960", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26962, Source = "26962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26962", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_42 { get; set; }

	[BinaryPoint(Offset = 26964, Source = "26964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26964", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_43 { get; set; }

	[BinaryPoint(Offset = 26966, Source = "26966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26966", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_44 { get; set; }

	[BinaryPoint(Offset = 26968, Source = "26968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26968", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_45 { get; set; }

	[BinaryPoint(Offset = 26970, Source = "26970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26970", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_46 { get; set; }

	[BinaryPoint(Offset = 26972, Source = "26972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26972", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_47 { get; set; }

	[BinaryPoint(Offset = 26974, Source = "26974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26974", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_48 { get; set; }

	[BinaryPoint(Offset = 26976, Source = "26976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26976", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_49 { get; set; }

	[BinaryPoint(Offset = 26978, Source = "26978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26978", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_50 { get; set; }

	[BinaryPoint(Offset = 26980, Source = "26980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26980", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_51 { get; set; }

	[BinaryPoint(Offset = 26982, Source = "26982", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26982", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_52 { get; set; }

	[BinaryPoint(Offset = 26984, Source = "26984", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26984", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_53 { get; set; }

	[BinaryPoint(Offset = 26986, Source = "26986", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26986", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_54 { get; set; }

	[BinaryPoint(Offset = 26988, Source = "26988", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26988", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_55 { get; set; }

	[BinaryPoint(Offset = 26990, Source = "26990", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26990", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_56 { get; set; }

	[BinaryPoint(Offset = 26992, Source = "26992", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26992", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_57 { get; set; }

	[BinaryPoint(Offset = 26994, Source = "26994", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26994", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_58 { get; set; }

	[BinaryPoint(Offset = 26996, Source = "26996", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26996", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_59 { get; set; }

	[BinaryPoint(Offset = 26998, Source = "26998", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26998", Category = "PLC/取料1_Z轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Pos_60 { get; set; }

	[BinaryPoint(Offset = 27000, Source = "27000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27000", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_1 { get; set; }

	[BinaryPoint(Offset = 27002, Source = "27002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27002", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_2 { get; set; }

	[BinaryPoint(Offset = 27004, Source = "27004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27004", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_3 { get; set; }

	[BinaryPoint(Offset = 27006, Source = "27006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27006", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_4 { get; set; }

	[BinaryPoint(Offset = 27008, Source = "27008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27008", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_5 { get; set; }

	[BinaryPoint(Offset = 27010, Source = "27010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27010", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_6 { get; set; }

	[BinaryPoint(Offset = 27012, Source = "27012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27012", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_7 { get; set; }

	[BinaryPoint(Offset = 27014, Source = "27014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27014", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_8 { get; set; }

	[BinaryPoint(Offset = 27016, Source = "27016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27016", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_9 { get; set; }

	[BinaryPoint(Offset = 27018, Source = "27018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27018", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_10 { get; set; }

	[BinaryPoint(Offset = 27020, Source = "27020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27020", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_11 { get; set; }

	[BinaryPoint(Offset = 27022, Source = "27022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27022", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_12 { get; set; }

	[BinaryPoint(Offset = 27024, Source = "27024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27024", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_13 { get; set; }

	[BinaryPoint(Offset = 27026, Source = "27026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27026", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_14 { get; set; }

	[BinaryPoint(Offset = 27028, Source = "27028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27028", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_15 { get; set; }

	[BinaryPoint(Offset = 27030, Source = "27030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27030", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_16 { get; set; }

	[BinaryPoint(Offset = 27032, Source = "27032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27032", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_17 { get; set; }

	[BinaryPoint(Offset = 27034, Source = "27034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27034", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_18 { get; set; }

	[BinaryPoint(Offset = 27036, Source = "27036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27036", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_19 { get; set; }

	[BinaryPoint(Offset = 27038, Source = "27038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27038", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_20 { get; set; }

	[BinaryPoint(Offset = 27040, Source = "27040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27040", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_21 { get; set; }

	[BinaryPoint(Offset = 27042, Source = "27042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27042", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_22 { get; set; }

	[BinaryPoint(Offset = 27044, Source = "27044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27044", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_23 { get; set; }

	[BinaryPoint(Offset = 27046, Source = "27046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27046", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_24 { get; set; }

	[BinaryPoint(Offset = 27048, Source = "27048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27048", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_25 { get; set; }

	[BinaryPoint(Offset = 27050, Source = "27050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27050", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_26 { get; set; }

	[BinaryPoint(Offset = 27052, Source = "27052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27052", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_27 { get; set; }

	[BinaryPoint(Offset = 27054, Source = "27054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27054", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_28 { get; set; }

	[BinaryPoint(Offset = 27056, Source = "27056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27056", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_29 { get; set; }

	[BinaryPoint(Offset = 27058, Source = "27058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27058", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_30 { get; set; }

	[BinaryPoint(Offset = 27060, Source = "27060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27060", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_31 { get; set; }

	[BinaryPoint(Offset = 27062, Source = "27062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27062", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_32 { get; set; }

	[BinaryPoint(Offset = 27064, Source = "27064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27064", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_33 { get; set; }

	[BinaryPoint(Offset = 27066, Source = "27066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27066", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_34 { get; set; }

	[BinaryPoint(Offset = 27068, Source = "27068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27068", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_35 { get; set; }

	[BinaryPoint(Offset = 27070, Source = "27070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27070", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_36 { get; set; }

	[BinaryPoint(Offset = 27072, Source = "27072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27072", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_37 { get; set; }

	[BinaryPoint(Offset = 27074, Source = "27074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27074", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_38 { get; set; }

	[BinaryPoint(Offset = 27076, Source = "27076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27076", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_39 { get; set; }

	[BinaryPoint(Offset = 27078, Source = "27078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27078", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_40 { get; set; }

	[BinaryPoint(Offset = 27080, Source = "27080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27080", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_41 { get; set; }

	[BinaryPoint(Offset = 27082, Source = "27082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27082", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_42 { get; set; }

	[BinaryPoint(Offset = 27084, Source = "27084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27084", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_43 { get; set; }

	[BinaryPoint(Offset = 27086, Source = "27086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27086", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_44 { get; set; }

	[BinaryPoint(Offset = 27088, Source = "27088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27088", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_45 { get; set; }

	[BinaryPoint(Offset = 27090, Source = "27090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27090", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_46 { get; set; }

	[BinaryPoint(Offset = 27092, Source = "27092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27092", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_47 { get; set; }

	[BinaryPoint(Offset = 27094, Source = "27094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27094", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_48 { get; set; }

	[BinaryPoint(Offset = 27096, Source = "27096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27096", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_49 { get; set; }

	[BinaryPoint(Offset = 27098, Source = "27098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27098", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_50 { get; set; }

	[BinaryPoint(Offset = 27100, Source = "27100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27100", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_51 { get; set; }

	[BinaryPoint(Offset = 27102, Source = "27102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27102", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_52 { get; set; }

	[BinaryPoint(Offset = 27104, Source = "27104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27104", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_53 { get; set; }

	[BinaryPoint(Offset = 27106, Source = "27106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27106", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_54 { get; set; }

	[BinaryPoint(Offset = 27108, Source = "27108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27108", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_55 { get; set; }

	[BinaryPoint(Offset = 27110, Source = "27110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27110", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_56 { get; set; }

	[BinaryPoint(Offset = 27112, Source = "27112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27112", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_57 { get; set; }

	[BinaryPoint(Offset = 27114, Source = "27114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27114", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_58 { get; set; }

	[BinaryPoint(Offset = 27116, Source = "27116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27116", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_59 { get; set; }

	[BinaryPoint(Offset = 27118, Source = "27118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27118", Category = "PLC/取料1_Z轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴3_Vel_60 { get; set; }

	[BinaryPoint(Offset = 27120, Source = "27120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27120", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_1 { get; set; }

	[BinaryPoint(Offset = 27122, Source = "27122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27122", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_2 { get; set; }

	[BinaryPoint(Offset = 27124, Source = "27124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27124", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_3 { get; set; }

	[BinaryPoint(Offset = 27126, Source = "27126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27126", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_4 { get; set; }

	[BinaryPoint(Offset = 27128, Source = "27128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27128", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_5 { get; set; }

	[BinaryPoint(Offset = 27130, Source = "27130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27130", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_6 { get; set; }

	[BinaryPoint(Offset = 27132, Source = "27132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27132", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_7 { get; set; }

	[BinaryPoint(Offset = 27134, Source = "27134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27134", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_8 { get; set; }

	[BinaryPoint(Offset = 27136, Source = "27136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27136", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_9 { get; set; }

	[BinaryPoint(Offset = 27138, Source = "27138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27138", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_10 { get; set; }

	[BinaryPoint(Offset = 27140, Source = "27140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27140", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_11 { get; set; }

	[BinaryPoint(Offset = 27142, Source = "27142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27142", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_12 { get; set; }

	[BinaryPoint(Offset = 27144, Source = "27144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27144", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_13 { get; set; }

	[BinaryPoint(Offset = 27146, Source = "27146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27146", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_14 { get; set; }

	[BinaryPoint(Offset = 27148, Source = "27148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27148", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_15 { get; set; }

	[BinaryPoint(Offset = 27150, Source = "27150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27150", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_16 { get; set; }

	[BinaryPoint(Offset = 27152, Source = "27152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27152", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_17 { get; set; }

	[BinaryPoint(Offset = 27154, Source = "27154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27154", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_18 { get; set; }

	[BinaryPoint(Offset = 27156, Source = "27156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27156", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_19 { get; set; }

	[BinaryPoint(Offset = 27158, Source = "27158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27158", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_20 { get; set; }

	[BinaryPoint(Offset = 27160, Source = "27160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27160", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_21 { get; set; }

	[BinaryPoint(Offset = 27162, Source = "27162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27162", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_22 { get; set; }

	[BinaryPoint(Offset = 27164, Source = "27164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27164", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_23 { get; set; }

	[BinaryPoint(Offset = 27166, Source = "27166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27166", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_24 { get; set; }

	[BinaryPoint(Offset = 27168, Source = "27168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27168", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_25 { get; set; }

	[BinaryPoint(Offset = 27170, Source = "27170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27170", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_26 { get; set; }

	[BinaryPoint(Offset = 27172, Source = "27172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27172", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_27 { get; set; }

	[BinaryPoint(Offset = 27174, Source = "27174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27174", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_28 { get; set; }

	[BinaryPoint(Offset = 27176, Source = "27176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27176", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_29 { get; set; }

	[BinaryPoint(Offset = 27178, Source = "27178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27178", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_30 { get; set; }

	[BinaryPoint(Offset = 27180, Source = "27180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27180", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_31 { get; set; }

	[BinaryPoint(Offset = 27182, Source = "27182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27182", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_32 { get; set; }

	[BinaryPoint(Offset = 27184, Source = "27184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27184", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_33 { get; set; }

	[BinaryPoint(Offset = 27186, Source = "27186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27186", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_34 { get; set; }

	[BinaryPoint(Offset = 27188, Source = "27188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27188", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_35 { get; set; }

	[BinaryPoint(Offset = 27190, Source = "27190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27190", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_36 { get; set; }

	[BinaryPoint(Offset = 27192, Source = "27192", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27192", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_37 { get; set; }

	[BinaryPoint(Offset = 27194, Source = "27194", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27194", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_38 { get; set; }

	[BinaryPoint(Offset = 27196, Source = "27196", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27196", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_39 { get; set; }

	[BinaryPoint(Offset = 27198, Source = "27198", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27198", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_40 { get; set; }

	[BinaryPoint(Offset = 27200, Source = "27200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27200", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_41 { get; set; }

	[BinaryPoint(Offset = 27202, Source = "27202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27202", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_42 { get; set; }

	[BinaryPoint(Offset = 27204, Source = "27204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27204", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_43 { get; set; }

	[BinaryPoint(Offset = 27206, Source = "27206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27206", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_44 { get; set; }

	[BinaryPoint(Offset = 27208, Source = "27208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27208", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_45 { get; set; }

	[BinaryPoint(Offset = 27210, Source = "27210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27210", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_46 { get; set; }

	[BinaryPoint(Offset = 27212, Source = "27212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27212", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_47 { get; set; }

	[BinaryPoint(Offset = 27214, Source = "27214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27214", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_48 { get; set; }

	[BinaryPoint(Offset = 27216, Source = "27216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27216", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_49 { get; set; }

	[BinaryPoint(Offset = 27218, Source = "27218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27218", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_50 { get; set; }

	[BinaryPoint(Offset = 27220, Source = "27220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27220", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_51 { get; set; }

	[BinaryPoint(Offset = 27222, Source = "27222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27222", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_52 { get; set; }

	[BinaryPoint(Offset = 27224, Source = "27224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27224", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_53 { get; set; }

	[BinaryPoint(Offset = 27226, Source = "27226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27226", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_54 { get; set; }

	[BinaryPoint(Offset = 27228, Source = "27228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27228", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_55 { get; set; }

	[BinaryPoint(Offset = 27230, Source = "27230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27230", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_56 { get; set; }

	[BinaryPoint(Offset = 27232, Source = "27232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27232", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_57 { get; set; }

	[BinaryPoint(Offset = 27234, Source = "27234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27234", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_58 { get; set; }

	[BinaryPoint(Offset = 27236, Source = "27236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27236", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_59 { get; set; }

	[BinaryPoint(Offset = 27238, Source = "27238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27238", Category = "PLC/取料1_R轴3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Pos_60 { get; set; }

	[BinaryPoint(Offset = 27240, Source = "27240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27240", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_1 { get; set; }

	[BinaryPoint(Offset = 27242, Source = "27242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27242", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_2 { get; set; }

	[BinaryPoint(Offset = 27244, Source = "27244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27244", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_3 { get; set; }

	[BinaryPoint(Offset = 27246, Source = "27246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27246", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_4 { get; set; }

	[BinaryPoint(Offset = 27248, Source = "27248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27248", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_5 { get; set; }

	[BinaryPoint(Offset = 27250, Source = "27250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27250", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_6 { get; set; }

	[BinaryPoint(Offset = 27252, Source = "27252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27252", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_7 { get; set; }

	[BinaryPoint(Offset = 27254, Source = "27254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27254", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_8 { get; set; }

	[BinaryPoint(Offset = 27256, Source = "27256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27256", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_9 { get; set; }

	[BinaryPoint(Offset = 27258, Source = "27258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27258", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_10 { get; set; }

	[BinaryPoint(Offset = 27260, Source = "27260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27260", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_11 { get; set; }

	[BinaryPoint(Offset = 27262, Source = "27262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27262", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_12 { get; set; }

	[BinaryPoint(Offset = 27264, Source = "27264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27264", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_13 { get; set; }

	[BinaryPoint(Offset = 27266, Source = "27266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27266", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_14 { get; set; }

	[BinaryPoint(Offset = 27268, Source = "27268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27268", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_15 { get; set; }

	[BinaryPoint(Offset = 27270, Source = "27270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27270", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_16 { get; set; }

	[BinaryPoint(Offset = 27272, Source = "27272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27272", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_17 { get; set; }

	[BinaryPoint(Offset = 27274, Source = "27274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27274", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_18 { get; set; }

	[BinaryPoint(Offset = 27276, Source = "27276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27276", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_19 { get; set; }

	[BinaryPoint(Offset = 27278, Source = "27278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27278", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_20 { get; set; }

	[BinaryPoint(Offset = 27280, Source = "27280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27280", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_21 { get; set; }

	[BinaryPoint(Offset = 27282, Source = "27282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27282", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_22 { get; set; }

	[BinaryPoint(Offset = 27284, Source = "27284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27284", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_23 { get; set; }

	[BinaryPoint(Offset = 27286, Source = "27286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27286", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_24 { get; set; }

	[BinaryPoint(Offset = 27288, Source = "27288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27288", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_25 { get; set; }

	[BinaryPoint(Offset = 27290, Source = "27290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27290", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_26 { get; set; }

	[BinaryPoint(Offset = 27292, Source = "27292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27292", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_27 { get; set; }

	[BinaryPoint(Offset = 27294, Source = "27294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27294", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_28 { get; set; }

	[BinaryPoint(Offset = 27296, Source = "27296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27296", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_29 { get; set; }

	[BinaryPoint(Offset = 27298, Source = "27298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27298", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_30 { get; set; }

	[BinaryPoint(Offset = 27300, Source = "27300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27300", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_31 { get; set; }

	[BinaryPoint(Offset = 27302, Source = "27302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27302", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_32 { get; set; }

	[BinaryPoint(Offset = 27304, Source = "27304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27304", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_33 { get; set; }

	[BinaryPoint(Offset = 27306, Source = "27306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27306", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_34 { get; set; }

	[BinaryPoint(Offset = 27308, Source = "27308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27308", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_35 { get; set; }

	[BinaryPoint(Offset = 27310, Source = "27310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27310", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_36 { get; set; }

	[BinaryPoint(Offset = 27312, Source = "27312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27312", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_37 { get; set; }

	[BinaryPoint(Offset = 27314, Source = "27314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27314", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_38 { get; set; }

	[BinaryPoint(Offset = 27316, Source = "27316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27316", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_39 { get; set; }

	[BinaryPoint(Offset = 27318, Source = "27318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27318", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_40 { get; set; }

	[BinaryPoint(Offset = 27320, Source = "27320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27320", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_41 { get; set; }

	[BinaryPoint(Offset = 27322, Source = "27322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27322", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_42 { get; set; }

	[BinaryPoint(Offset = 27324, Source = "27324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27324", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_43 { get; set; }

	[BinaryPoint(Offset = 27326, Source = "27326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27326", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_44 { get; set; }

	[BinaryPoint(Offset = 27328, Source = "27328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27328", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_45 { get; set; }

	[BinaryPoint(Offset = 27330, Source = "27330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27330", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_46 { get; set; }

	[BinaryPoint(Offset = 27332, Source = "27332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27332", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_47 { get; set; }

	[BinaryPoint(Offset = 27334, Source = "27334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27334", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_48 { get; set; }

	[BinaryPoint(Offset = 27336, Source = "27336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27336", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_49 { get; set; }

	[BinaryPoint(Offset = 27338, Source = "27338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27338", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_50 { get; set; }

	[BinaryPoint(Offset = 27340, Source = "27340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27340", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_51 { get; set; }

	[BinaryPoint(Offset = 27342, Source = "27342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27342", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_52 { get; set; }

	[BinaryPoint(Offset = 27344, Source = "27344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27344", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_53 { get; set; }

	[BinaryPoint(Offset = 27346, Source = "27346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27346", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_54 { get; set; }

	[BinaryPoint(Offset = 27348, Source = "27348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27348", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_55 { get; set; }

	[BinaryPoint(Offset = 27350, Source = "27350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27350", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_56 { get; set; }

	[BinaryPoint(Offset = 27352, Source = "27352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27352", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_57 { get; set; }

	[BinaryPoint(Offset = 27354, Source = "27354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27354", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_58 { get; set; }

	[BinaryPoint(Offset = 27356, Source = "27356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27356", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_59 { get; set; }

	[BinaryPoint(Offset = 27358, Source = "27358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27358", Category = "PLC/取料1_R轴3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴3_Vel_60 { get; set; }

	[BinaryPoint(Offset = 27360, Source = "27360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27360", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_1 { get; set; }

	[BinaryPoint(Offset = 27362, Source = "27362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27362", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_2 { get; set; }

	[BinaryPoint(Offset = 27364, Source = "27364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27364", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_3 { get; set; }

	[BinaryPoint(Offset = 27366, Source = "27366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27366", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_4 { get; set; }

	[BinaryPoint(Offset = 27368, Source = "27368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27368", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_5 { get; set; }

	[BinaryPoint(Offset = 27370, Source = "27370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27370", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_6 { get; set; }

	[BinaryPoint(Offset = 27372, Source = "27372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27372", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_7 { get; set; }

	[BinaryPoint(Offset = 27374, Source = "27374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27374", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_8 { get; set; }

	[BinaryPoint(Offset = 27376, Source = "27376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27376", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_9 { get; set; }

	[BinaryPoint(Offset = 27378, Source = "27378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27378", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_10 { get; set; }

	[BinaryPoint(Offset = 27380, Source = "27380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27380", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_11 { get; set; }

	[BinaryPoint(Offset = 27382, Source = "27382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27382", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_12 { get; set; }

	[BinaryPoint(Offset = 27384, Source = "27384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27384", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_13 { get; set; }

	[BinaryPoint(Offset = 27386, Source = "27386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27386", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_14 { get; set; }

	[BinaryPoint(Offset = 27388, Source = "27388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27388", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_15 { get; set; }

	[BinaryPoint(Offset = 27390, Source = "27390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27390", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_16 { get; set; }

	[BinaryPoint(Offset = 27392, Source = "27392", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27392", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_17 { get; set; }

	[BinaryPoint(Offset = 27394, Source = "27394", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27394", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_18 { get; set; }

	[BinaryPoint(Offset = 27396, Source = "27396", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27396", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_19 { get; set; }

	[BinaryPoint(Offset = 27398, Source = "27398", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27398", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_20 { get; set; }

	[BinaryPoint(Offset = 27400, Source = "27400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27400", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_21 { get; set; }

	[BinaryPoint(Offset = 27402, Source = "27402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27402", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_22 { get; set; }

	[BinaryPoint(Offset = 27404, Source = "27404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27404", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_23 { get; set; }

	[BinaryPoint(Offset = 27406, Source = "27406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27406", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_24 { get; set; }

	[BinaryPoint(Offset = 27408, Source = "27408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27408", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_25 { get; set; }

	[BinaryPoint(Offset = 27410, Source = "27410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27410", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_26 { get; set; }

	[BinaryPoint(Offset = 27412, Source = "27412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27412", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_27 { get; set; }

	[BinaryPoint(Offset = 27414, Source = "27414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27414", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_28 { get; set; }

	[BinaryPoint(Offset = 27416, Source = "27416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27416", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_29 { get; set; }

	[BinaryPoint(Offset = 27418, Source = "27418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27418", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_30 { get; set; }

	[BinaryPoint(Offset = 27420, Source = "27420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27420", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_31 { get; set; }

	[BinaryPoint(Offset = 27422, Source = "27422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27422", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_32 { get; set; }

	[BinaryPoint(Offset = 27424, Source = "27424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27424", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_33 { get; set; }

	[BinaryPoint(Offset = 27426, Source = "27426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27426", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_34 { get; set; }

	[BinaryPoint(Offset = 27428, Source = "27428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27428", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_35 { get; set; }

	[BinaryPoint(Offset = 27430, Source = "27430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27430", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_36 { get; set; }

	[BinaryPoint(Offset = 27432, Source = "27432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27432", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_37 { get; set; }

	[BinaryPoint(Offset = 27434, Source = "27434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27434", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_38 { get; set; }

	[BinaryPoint(Offset = 27436, Source = "27436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27436", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_39 { get; set; }

	[BinaryPoint(Offset = 27438, Source = "27438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27438", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_40 { get; set; }

	[BinaryPoint(Offset = 27440, Source = "27440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27440", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_41 { get; set; }

	[BinaryPoint(Offset = 27442, Source = "27442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27442", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_42 { get; set; }

	[BinaryPoint(Offset = 27444, Source = "27444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27444", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_43 { get; set; }

	[BinaryPoint(Offset = 27446, Source = "27446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27446", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_44 { get; set; }

	[BinaryPoint(Offset = 27448, Source = "27448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27448", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_45 { get; set; }

	[BinaryPoint(Offset = 27450, Source = "27450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27450", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_46 { get; set; }

	[BinaryPoint(Offset = 27452, Source = "27452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27452", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_47 { get; set; }

	[BinaryPoint(Offset = 27454, Source = "27454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27454", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_48 { get; set; }

	[BinaryPoint(Offset = 27456, Source = "27456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27456", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_49 { get; set; }

	[BinaryPoint(Offset = 27458, Source = "27458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27458", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_50 { get; set; }

	[BinaryPoint(Offset = 27460, Source = "27460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27460", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_51 { get; set; }

	[BinaryPoint(Offset = 27462, Source = "27462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27462", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_52 { get; set; }

	[BinaryPoint(Offset = 27464, Source = "27464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27464", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_53 { get; set; }

	[BinaryPoint(Offset = 27466, Source = "27466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27466", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_54 { get; set; }

	[BinaryPoint(Offset = 27468, Source = "27468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27468", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_55 { get; set; }

	[BinaryPoint(Offset = 27470, Source = "27470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27470", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_56 { get; set; }

	[BinaryPoint(Offset = 27472, Source = "27472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27472", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_57 { get; set; }

	[BinaryPoint(Offset = 27474, Source = "27474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27474", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_58 { get; set; }

	[BinaryPoint(Offset = 27476, Source = "27476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27476", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_59 { get; set; }

	[BinaryPoint(Offset = 27478, Source = "27478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27478", Category = "PLC/取料1_Z轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Pos_60 { get; set; }

	[BinaryPoint(Offset = 27480, Source = "27480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27480", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_1 { get; set; }

	[BinaryPoint(Offset = 27482, Source = "27482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27482", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_2 { get; set; }

	[BinaryPoint(Offset = 27484, Source = "27484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27484", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_3 { get; set; }

	[BinaryPoint(Offset = 27486, Source = "27486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27486", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_4 { get; set; }

	[BinaryPoint(Offset = 27488, Source = "27488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27488", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_5 { get; set; }

	[BinaryPoint(Offset = 27490, Source = "27490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27490", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_6 { get; set; }

	[BinaryPoint(Offset = 27492, Source = "27492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27492", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_7 { get; set; }

	[BinaryPoint(Offset = 27494, Source = "27494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27494", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_8 { get; set; }

	[BinaryPoint(Offset = 27496, Source = "27496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27496", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_9 { get; set; }

	[BinaryPoint(Offset = 27498, Source = "27498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27498", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_10 { get; set; }

	[BinaryPoint(Offset = 27500, Source = "27500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27500", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_11 { get; set; }

	[BinaryPoint(Offset = 27502, Source = "27502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27502", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_12 { get; set; }

	[BinaryPoint(Offset = 27504, Source = "27504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27504", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_13 { get; set; }

	[BinaryPoint(Offset = 27506, Source = "27506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27506", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_14 { get; set; }

	[BinaryPoint(Offset = 27508, Source = "27508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27508", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_15 { get; set; }

	[BinaryPoint(Offset = 27510, Source = "27510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27510", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_16 { get; set; }

	[BinaryPoint(Offset = 27512, Source = "27512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27512", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_17 { get; set; }

	[BinaryPoint(Offset = 27514, Source = "27514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27514", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_18 { get; set; }

	[BinaryPoint(Offset = 27516, Source = "27516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27516", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_19 { get; set; }

	[BinaryPoint(Offset = 27518, Source = "27518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27518", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_20 { get; set; }

	[BinaryPoint(Offset = 27520, Source = "27520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27520", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_21 { get; set; }

	[BinaryPoint(Offset = 27522, Source = "27522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27522", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_22 { get; set; }

	[BinaryPoint(Offset = 27524, Source = "27524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27524", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_23 { get; set; }

	[BinaryPoint(Offset = 27526, Source = "27526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27526", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_24 { get; set; }

	[BinaryPoint(Offset = 27528, Source = "27528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27528", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_25 { get; set; }

	[BinaryPoint(Offset = 27530, Source = "27530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27530", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_26 { get; set; }

	[BinaryPoint(Offset = 27532, Source = "27532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27532", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_27 { get; set; }

	[BinaryPoint(Offset = 27534, Source = "27534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27534", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_28 { get; set; }

	[BinaryPoint(Offset = 27536, Source = "27536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27536", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_29 { get; set; }

	[BinaryPoint(Offset = 27538, Source = "27538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27538", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_30 { get; set; }

	[BinaryPoint(Offset = 27540, Source = "27540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27540", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_31 { get; set; }

	[BinaryPoint(Offset = 27542, Source = "27542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27542", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_32 { get; set; }

	[BinaryPoint(Offset = 27544, Source = "27544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27544", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_33 { get; set; }

	[BinaryPoint(Offset = 27546, Source = "27546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27546", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_34 { get; set; }

	[BinaryPoint(Offset = 27548, Source = "27548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27548", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_35 { get; set; }

	[BinaryPoint(Offset = 27550, Source = "27550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27550", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_36 { get; set; }

	[BinaryPoint(Offset = 27552, Source = "27552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27552", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_37 { get; set; }

	[BinaryPoint(Offset = 27554, Source = "27554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27554", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_38 { get; set; }

	[BinaryPoint(Offset = 27556, Source = "27556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27556", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_39 { get; set; }

	[BinaryPoint(Offset = 27558, Source = "27558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27558", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_40 { get; set; }

	[BinaryPoint(Offset = 27560, Source = "27560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27560", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_41 { get; set; }

	[BinaryPoint(Offset = 27562, Source = "27562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27562", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_42 { get; set; }

	[BinaryPoint(Offset = 27564, Source = "27564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27564", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_43 { get; set; }

	[BinaryPoint(Offset = 27566, Source = "27566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27566", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_44 { get; set; }

	[BinaryPoint(Offset = 27568, Source = "27568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27568", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_45 { get; set; }

	[BinaryPoint(Offset = 27570, Source = "27570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27570", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_46 { get; set; }

	[BinaryPoint(Offset = 27572, Source = "27572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27572", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_47 { get; set; }

	[BinaryPoint(Offset = 27574, Source = "27574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27574", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_48 { get; set; }

	[BinaryPoint(Offset = 27576, Source = "27576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27576", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_49 { get; set; }

	[BinaryPoint(Offset = 27578, Source = "27578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27578", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_50 { get; set; }

	[BinaryPoint(Offset = 27580, Source = "27580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27580", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_51 { get; set; }

	[BinaryPoint(Offset = 27582, Source = "27582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27582", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_52 { get; set; }

	[BinaryPoint(Offset = 27584, Source = "27584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27584", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_53 { get; set; }

	[BinaryPoint(Offset = 27586, Source = "27586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27586", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_54 { get; set; }

	[BinaryPoint(Offset = 27588, Source = "27588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27588", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_55 { get; set; }

	[BinaryPoint(Offset = 27590, Source = "27590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27590", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_56 { get; set; }

	[BinaryPoint(Offset = 27592, Source = "27592", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27592", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_57 { get; set; }

	[BinaryPoint(Offset = 27594, Source = "27594", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27594", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_58 { get; set; }

	[BinaryPoint(Offset = 27596, Source = "27596", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27596", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_59 { get; set; }

	[BinaryPoint(Offset = 27598, Source = "27598", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27598", Category = "PLC/取料1_Z轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_Z轴4_Vel_60 { get; set; }

	[BinaryPoint(Offset = 27600, Source = "27600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27600", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_1 { get; set; }

	[BinaryPoint(Offset = 27602, Source = "27602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27602", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_2 { get; set; }

	[BinaryPoint(Offset = 27604, Source = "27604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27604", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_3 { get; set; }

	[BinaryPoint(Offset = 27606, Source = "27606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27606", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_4 { get; set; }

	[BinaryPoint(Offset = 27608, Source = "27608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27608", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_5 { get; set; }

	[BinaryPoint(Offset = 27610, Source = "27610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27610", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_6 { get; set; }

	[BinaryPoint(Offset = 27612, Source = "27612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27612", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_7 { get; set; }

	[BinaryPoint(Offset = 27614, Source = "27614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27614", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_8 { get; set; }

	[BinaryPoint(Offset = 27616, Source = "27616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27616", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_9 { get; set; }

	[BinaryPoint(Offset = 27618, Source = "27618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27618", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_10 { get; set; }

	[BinaryPoint(Offset = 27620, Source = "27620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27620", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_11 { get; set; }

	[BinaryPoint(Offset = 27622, Source = "27622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27622", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_12 { get; set; }

	[BinaryPoint(Offset = 27624, Source = "27624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27624", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_13 { get; set; }

	[BinaryPoint(Offset = 27626, Source = "27626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27626", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_14 { get; set; }

	[BinaryPoint(Offset = 27628, Source = "27628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27628", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_15 { get; set; }

	[BinaryPoint(Offset = 27630, Source = "27630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27630", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_16 { get; set; }

	[BinaryPoint(Offset = 27632, Source = "27632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27632", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_17 { get; set; }

	[BinaryPoint(Offset = 27634, Source = "27634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27634", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_18 { get; set; }

	[BinaryPoint(Offset = 27636, Source = "27636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27636", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_19 { get; set; }

	[BinaryPoint(Offset = 27638, Source = "27638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27638", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_20 { get; set; }

	[BinaryPoint(Offset = 27640, Source = "27640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27640", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_21 { get; set; }

	[BinaryPoint(Offset = 27642, Source = "27642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27642", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_22 { get; set; }

	[BinaryPoint(Offset = 27644, Source = "27644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27644", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_23 { get; set; }

	[BinaryPoint(Offset = 27646, Source = "27646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27646", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_24 { get; set; }

	[BinaryPoint(Offset = 27648, Source = "27648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27648", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_25 { get; set; }

	[BinaryPoint(Offset = 27650, Source = "27650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27650", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_26 { get; set; }

	[BinaryPoint(Offset = 27652, Source = "27652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27652", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_27 { get; set; }

	[BinaryPoint(Offset = 27654, Source = "27654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27654", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_28 { get; set; }

	[BinaryPoint(Offset = 27656, Source = "27656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27656", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_29 { get; set; }

	[BinaryPoint(Offset = 27658, Source = "27658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27658", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_30 { get; set; }

	[BinaryPoint(Offset = 27660, Source = "27660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27660", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_31 { get; set; }

	[BinaryPoint(Offset = 27662, Source = "27662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27662", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_32 { get; set; }

	[BinaryPoint(Offset = 27664, Source = "27664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27664", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_33 { get; set; }

	[BinaryPoint(Offset = 27666, Source = "27666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27666", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_34 { get; set; }

	[BinaryPoint(Offset = 27668, Source = "27668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27668", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_35 { get; set; }

	[BinaryPoint(Offset = 27670, Source = "27670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27670", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_36 { get; set; }

	[BinaryPoint(Offset = 27672, Source = "27672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27672", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_37 { get; set; }

	[BinaryPoint(Offset = 27674, Source = "27674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27674", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_38 { get; set; }

	[BinaryPoint(Offset = 27676, Source = "27676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27676", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_39 { get; set; }

	[BinaryPoint(Offset = 27678, Source = "27678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27678", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_40 { get; set; }

	[BinaryPoint(Offset = 27680, Source = "27680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27680", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_41 { get; set; }

	[BinaryPoint(Offset = 27682, Source = "27682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27682", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_42 { get; set; }

	[BinaryPoint(Offset = 27684, Source = "27684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27684", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_43 { get; set; }

	[BinaryPoint(Offset = 27686, Source = "27686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27686", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_44 { get; set; }

	[BinaryPoint(Offset = 27688, Source = "27688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27688", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_45 { get; set; }

	[BinaryPoint(Offset = 27690, Source = "27690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27690", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_46 { get; set; }

	[BinaryPoint(Offset = 27692, Source = "27692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27692", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_47 { get; set; }

	[BinaryPoint(Offset = 27694, Source = "27694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27694", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_48 { get; set; }

	[BinaryPoint(Offset = 27696, Source = "27696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27696", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_49 { get; set; }

	[BinaryPoint(Offset = 27698, Source = "27698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27698", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_50 { get; set; }

	[BinaryPoint(Offset = 27700, Source = "27700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27700", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_51 { get; set; }

	[BinaryPoint(Offset = 27702, Source = "27702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27702", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_52 { get; set; }

	[BinaryPoint(Offset = 27704, Source = "27704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27704", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_53 { get; set; }

	[BinaryPoint(Offset = 27706, Source = "27706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27706", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_54 { get; set; }

	[BinaryPoint(Offset = 27708, Source = "27708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27708", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_55 { get; set; }

	[BinaryPoint(Offset = 27710, Source = "27710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27710", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_56 { get; set; }

	[BinaryPoint(Offset = 27712, Source = "27712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27712", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_57 { get; set; }

	[BinaryPoint(Offset = 27714, Source = "27714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27714", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_58 { get; set; }

	[BinaryPoint(Offset = 27716, Source = "27716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27716", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_59 { get; set; }

	[BinaryPoint(Offset = 27718, Source = "27718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27718", Category = "PLC/取料1_R轴4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Pos_60 { get; set; }

	[BinaryPoint(Offset = 27720, Source = "27720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27720", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_1 { get; set; }

	[BinaryPoint(Offset = 27722, Source = "27722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27722", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_2 { get; set; }

	[BinaryPoint(Offset = 27724, Source = "27724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27724", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_3 { get; set; }

	[BinaryPoint(Offset = 27726, Source = "27726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27726", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_4 { get; set; }

	[BinaryPoint(Offset = 27728, Source = "27728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27728", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_5 { get; set; }

	[BinaryPoint(Offset = 27730, Source = "27730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27730", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_6 { get; set; }

	[BinaryPoint(Offset = 27732, Source = "27732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27732", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_7 { get; set; }

	[BinaryPoint(Offset = 27734, Source = "27734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27734", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_8 { get; set; }

	[BinaryPoint(Offset = 27736, Source = "27736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27736", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_9 { get; set; }

	[BinaryPoint(Offset = 27738, Source = "27738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27738", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_10 { get; set; }

	[BinaryPoint(Offset = 27740, Source = "27740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27740", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_11 { get; set; }

	[BinaryPoint(Offset = 27742, Source = "27742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27742", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_12 { get; set; }

	[BinaryPoint(Offset = 27744, Source = "27744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27744", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_13 { get; set; }

	[BinaryPoint(Offset = 27746, Source = "27746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27746", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_14 { get; set; }

	[BinaryPoint(Offset = 27748, Source = "27748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27748", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_15 { get; set; }

	[BinaryPoint(Offset = 27750, Source = "27750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27750", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_16 { get; set; }

	[BinaryPoint(Offset = 27752, Source = "27752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27752", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_17 { get; set; }

	[BinaryPoint(Offset = 27754, Source = "27754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27754", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_18 { get; set; }

	[BinaryPoint(Offset = 27756, Source = "27756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27756", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_19 { get; set; }

	[BinaryPoint(Offset = 27758, Source = "27758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27758", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_20 { get; set; }

	[BinaryPoint(Offset = 27760, Source = "27760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27760", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_21 { get; set; }

	[BinaryPoint(Offset = 27762, Source = "27762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27762", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_22 { get; set; }

	[BinaryPoint(Offset = 27764, Source = "27764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27764", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_23 { get; set; }

	[BinaryPoint(Offset = 27766, Source = "27766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27766", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_24 { get; set; }

	[BinaryPoint(Offset = 27768, Source = "27768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27768", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_25 { get; set; }

	[BinaryPoint(Offset = 27770, Source = "27770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27770", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_26 { get; set; }

	[BinaryPoint(Offset = 27772, Source = "27772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27772", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_27 { get; set; }

	[BinaryPoint(Offset = 27774, Source = "27774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27774", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_28 { get; set; }

	[BinaryPoint(Offset = 27776, Source = "27776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27776", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_29 { get; set; }

	[BinaryPoint(Offset = 27778, Source = "27778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27778", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_30 { get; set; }

	[BinaryPoint(Offset = 27780, Source = "27780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27780", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_31 { get; set; }

	[BinaryPoint(Offset = 27782, Source = "27782", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27782", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_32 { get; set; }

	[BinaryPoint(Offset = 27784, Source = "27784", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27784", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_33 { get; set; }

	[BinaryPoint(Offset = 27786, Source = "27786", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27786", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_34 { get; set; }

	[BinaryPoint(Offset = 27788, Source = "27788", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27788", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_35 { get; set; }

	[BinaryPoint(Offset = 27790, Source = "27790", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27790", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_36 { get; set; }

	[BinaryPoint(Offset = 27792, Source = "27792", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27792", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_37 { get; set; }

	[BinaryPoint(Offset = 27794, Source = "27794", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27794", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_38 { get; set; }

	[BinaryPoint(Offset = 27796, Source = "27796", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27796", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_39 { get; set; }

	[BinaryPoint(Offset = 27798, Source = "27798", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27798", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_40 { get; set; }

	[BinaryPoint(Offset = 27800, Source = "27800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27800", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_41 { get; set; }

	[BinaryPoint(Offset = 27802, Source = "27802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27802", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_42 { get; set; }

	[BinaryPoint(Offset = 27804, Source = "27804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27804", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_43 { get; set; }

	[BinaryPoint(Offset = 27806, Source = "27806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27806", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_44 { get; set; }

	[BinaryPoint(Offset = 27808, Source = "27808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27808", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_45 { get; set; }

	[BinaryPoint(Offset = 27810, Source = "27810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27810", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_46 { get; set; }

	[BinaryPoint(Offset = 27812, Source = "27812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27812", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_47 { get; set; }

	[BinaryPoint(Offset = 27814, Source = "27814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27814", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_48 { get; set; }

	[BinaryPoint(Offset = 27816, Source = "27816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27816", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_49 { get; set; }

	[BinaryPoint(Offset = 27818, Source = "27818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27818", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_50 { get; set; }

	[BinaryPoint(Offset = 27820, Source = "27820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27820", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_51 { get; set; }

	[BinaryPoint(Offset = 27822, Source = "27822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27822", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_52 { get; set; }

	[BinaryPoint(Offset = 27824, Source = "27824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27824", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_53 { get; set; }

	[BinaryPoint(Offset = 27826, Source = "27826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27826", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_54 { get; set; }

	[BinaryPoint(Offset = 27828, Source = "27828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27828", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_55 { get; set; }

	[BinaryPoint(Offset = 27830, Source = "27830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27830", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_56 { get; set; }

	[BinaryPoint(Offset = 27832, Source = "27832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27832", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_57 { get; set; }

	[BinaryPoint(Offset = 27834, Source = "27834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27834", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_58 { get; set; }

	[BinaryPoint(Offset = 27836, Source = "27836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27836", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_59 { get; set; }

	[BinaryPoint(Offset = 27838, Source = "27838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:27838", Category = "PLC/取料1_R轴4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 取料1_R轴4_Vel_60 { get; set; }

	#endregion

}