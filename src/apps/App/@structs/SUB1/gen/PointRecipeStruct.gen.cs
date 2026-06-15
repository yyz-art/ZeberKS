
// GENERATE AT 2026/6/12 13:26:22
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
	[ValueInfo(Source = "PLC:24000", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24002, Source = "24002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24002", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24004, Source = "24004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24004", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24006, Source = "24006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24006", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24008, Source = "24008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24008", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24010, Source = "24010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24010", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24012, Source = "24012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24012", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24014, Source = "24014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24014", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24016, Source = "24016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24016", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24018, Source = "24018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24018", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24020, Source = "24020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24020", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24022, Source = "24022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24022", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24024, Source = "24024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24024", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24026, Source = "24026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24026", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24028, Source = "24028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24028", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24030, Source = "24030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24030", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24032, Source = "24032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24032", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24034, Source = "24034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24034", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24036, Source = "24036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24036", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24038, Source = "24038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24038", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24040, Source = "24040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24040", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24042, Source = "24042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24042", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24044, Source = "24044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24044", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24046, Source = "24046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24046", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24048, Source = "24048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24048", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24050, Source = "24050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24050", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24052, Source = "24052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24052", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24054, Source = "24054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24054", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24056, Source = "24056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24056", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24058, Source = "24058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24058", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24060, Source = "24060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24060", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24062, Source = "24062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24062", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24064, Source = "24064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24064", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24066, Source = "24066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24066", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24068, Source = "24068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24068", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24070, Source = "24070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24070", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24072, Source = "24072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24072", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24074, Source = "24074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24074", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24076, Source = "24076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24076", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24078, Source = "24078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24078", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24080, Source = "24080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24080", Category = "PLC/上料轴1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24100, Source = "24100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24100", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24102, Source = "24102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24102", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24104, Source = "24104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24104", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24106, Source = "24106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24106", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24108, Source = "24108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24108", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24110, Source = "24110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24110", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24112, Source = "24112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24112", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24114, Source = "24114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24114", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24116, Source = "24116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24116", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24118, Source = "24118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24118", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24120, Source = "24120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24120", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24122, Source = "24122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24122", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24124, Source = "24124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24124", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24126, Source = "24126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24126", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24128, Source = "24128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24128", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24130, Source = "24130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24130", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24132, Source = "24132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24132", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24134, Source = "24134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24134", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24136, Source = "24136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24136", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24138, Source = "24138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24138", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24140, Source = "24140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24140", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24142, Source = "24142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24142", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24144, Source = "24144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24144", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24146, Source = "24146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24146", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24148, Source = "24148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24148", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24150, Source = "24150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24150", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24152, Source = "24152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24152", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24154, Source = "24154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24154", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24156, Source = "24156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24156", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24158, Source = "24158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24158", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24160, Source = "24160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24160", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24162, Source = "24162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24162", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24164, Source = "24164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24164", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24166, Source = "24166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24166", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24168, Source = "24168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24168", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24170, Source = "24170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24170", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24172, Source = "24172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24172", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24174, Source = "24174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24174", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24176, Source = "24176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24176", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24178, Source = "24178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24178", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24180, Source = "24180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24180", Category = "PLC/上料轴1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24200, Source = "24200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24200", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24202, Source = "24202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24202", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24204, Source = "24204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24204", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24206, Source = "24206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24206", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24208, Source = "24208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24208", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24210, Source = "24210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24210", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24212, Source = "24212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24212", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24214, Source = "24214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24214", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24216, Source = "24216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24216", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24218, Source = "24218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24218", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24220, Source = "24220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24220", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24222, Source = "24222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24222", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24224, Source = "24224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24224", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24226, Source = "24226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24226", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24228, Source = "24228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24228", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24230, Source = "24230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24230", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24232, Source = "24232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24232", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24234, Source = "24234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24234", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24236, Source = "24236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24236", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24238, Source = "24238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24238", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24240, Source = "24240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24240", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24242, Source = "24242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24242", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24244, Source = "24244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24244", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24246, Source = "24246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24246", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24248, Source = "24248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24248", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24250, Source = "24250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24250", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24252, Source = "24252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24252", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24254, Source = "24254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24254", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24256, Source = "24256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24256", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24258, Source = "24258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24258", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24260, Source = "24260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24260", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24262, Source = "24262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24262", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24264, Source = "24264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24264", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24266, Source = "24266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24266", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24268, Source = "24268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24268", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24270, Source = "24270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24270", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24272, Source = "24272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24272", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24274, Source = "24274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24274", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24276, Source = "24276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24276", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24278, Source = "24278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24278", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24280, Source = "24280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24280", Category = "PLC/上料轴2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24300, Source = "24300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24300", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24302, Source = "24302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24302", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24304, Source = "24304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24304", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24306, Source = "24306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24306", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24308, Source = "24308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24308", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24310, Source = "24310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24310", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24312, Source = "24312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24312", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24314, Source = "24314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24314", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24316, Source = "24316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24316", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24318, Source = "24318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24318", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24320, Source = "24320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24320", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24322, Source = "24322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24322", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24324, Source = "24324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24324", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24326, Source = "24326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24326", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24328, Source = "24328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24328", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24330, Source = "24330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24330", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24332, Source = "24332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24332", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24334, Source = "24334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24334", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24336, Source = "24336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24336", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24338, Source = "24338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24338", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24340, Source = "24340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24340", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24342, Source = "24342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24342", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24344, Source = "24344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24344", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24346, Source = "24346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24346", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24348, Source = "24348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24348", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24350, Source = "24350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24350", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24352, Source = "24352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24352", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24354, Source = "24354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24354", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24356, Source = "24356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24356", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24358, Source = "24358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24358", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24360, Source = "24360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24360", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24362, Source = "24362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24362", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24364, Source = "24364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24364", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24366, Source = "24366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24366", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24368, Source = "24368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24368", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24370, Source = "24370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24370", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24372, Source = "24372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24372", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24374, Source = "24374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24374", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24376, Source = "24376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24376", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24378, Source = "24378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24378", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24380, Source = "24380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24380", Category = "PLC/上料轴2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 上料轴2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24400, Source = "24400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24400", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24402, Source = "24402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24402", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24404, Source = "24404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24404", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24406, Source = "24406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24406", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24408, Source = "24408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24408", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24410, Source = "24410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24410", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24412, Source = "24412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24412", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24414, Source = "24414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24414", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24416, Source = "24416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24416", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24418, Source = "24418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24418", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24420, Source = "24420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24420", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24422, Source = "24422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24422", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24424, Source = "24424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24424", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24426, Source = "24426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24426", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24428, Source = "24428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24428", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24430, Source = "24430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24430", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24432, Source = "24432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24432", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24434, Source = "24434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24434", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24436, Source = "24436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24436", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24438, Source = "24438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24438", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24440, Source = "24440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24440", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24442, Source = "24442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24442", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24444, Source = "24444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24444", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24446, Source = "24446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24446", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24448, Source = "24448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24448", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24450, Source = "24450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24450", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24452, Source = "24452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24452", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24454, Source = "24454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24454", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24456, Source = "24456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24456", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24458, Source = "24458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24458", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24460, Source = "24460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24460", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24462, Source = "24462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24462", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24464, Source = "24464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24464", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24466, Source = "24466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24466", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24468, Source = "24468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24468", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24470, Source = "24470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24470", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24472, Source = "24472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24472", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24474, Source = "24474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24474", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24476, Source = "24476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24476", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24478, Source = "24478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24478", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24480, Source = "24480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24480", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24482, Source = "24482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24482", Category = "PLC/X轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24500, Source = "24500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24500", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24502, Source = "24502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24502", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24504, Source = "24504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24504", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24506, Source = "24506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24506", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24508, Source = "24508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24508", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24510, Source = "24510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24510", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24512, Source = "24512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24512", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24514, Source = "24514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24514", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24516, Source = "24516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24516", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24518, Source = "24518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24518", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24520, Source = "24520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24520", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24522, Source = "24522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24522", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24524, Source = "24524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24524", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24526, Source = "24526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24526", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24528, Source = "24528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24528", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24530, Source = "24530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24530", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24532, Source = "24532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24532", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24534, Source = "24534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24534", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24536, Source = "24536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24536", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24538, Source = "24538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24538", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24540, Source = "24540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24540", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24542, Source = "24542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24542", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24544, Source = "24544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24544", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24546, Source = "24546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24546", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24548, Source = "24548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24548", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24550, Source = "24550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24550", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24552, Source = "24552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24552", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24554, Source = "24554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24554", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24556, Source = "24556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24556", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24558, Source = "24558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24558", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24560, Source = "24560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24560", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24562, Source = "24562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24562", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24564, Source = "24564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24564", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24566, Source = "24566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24566", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24568, Source = "24568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24568", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24570, Source = "24570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24570", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24572, Source = "24572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24572", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24574, Source = "24574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24574", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24576, Source = "24576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24576", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24578, Source = "24578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24578", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24580, Source = "24580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24580", Category = "PLC/X轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float X轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24600, Source = "24600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24600", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24602, Source = "24602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24602", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24604, Source = "24604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24604", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24606, Source = "24606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24606", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24608, Source = "24608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24608", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24610, Source = "24610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24610", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24612, Source = "24612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24612", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24614, Source = "24614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24614", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24616, Source = "24616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24616", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24618, Source = "24618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24618", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24620, Source = "24620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24620", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24622, Source = "24622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24622", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24624, Source = "24624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24624", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24626, Source = "24626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24626", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24628, Source = "24628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24628", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24630, Source = "24630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24630", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24632, Source = "24632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24632", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24634, Source = "24634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24634", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24636, Source = "24636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24636", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24638, Source = "24638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24638", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24640, Source = "24640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24640", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24642, Source = "24642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24642", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24644, Source = "24644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24644", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24646, Source = "24646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24646", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24648, Source = "24648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24648", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24650, Source = "24650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24650", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24652, Source = "24652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24652", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24654, Source = "24654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24654", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24656, Source = "24656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24656", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24658, Source = "24658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24658", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24660, Source = "24660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24660", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24662, Source = "24662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24662", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24664, Source = "24664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24664", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24666, Source = "24666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24666", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24668, Source = "24668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24668", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24670, Source = "24670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24670", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24672, Source = "24672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24672", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24674, Source = "24674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24674", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24676, Source = "24676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24676", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24678, Source = "24678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24678", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24680, Source = "24680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24680", Category = "PLC/Y轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24700, Source = "24700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24700", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24702, Source = "24702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24702", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24704, Source = "24704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24704", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24706, Source = "24706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24706", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24708, Source = "24708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24708", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24710, Source = "24710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24710", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24712, Source = "24712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24712", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24714, Source = "24714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24714", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24716, Source = "24716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24716", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24718, Source = "24718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24718", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24720, Source = "24720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24720", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24722, Source = "24722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24722", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24724, Source = "24724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24724", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24726, Source = "24726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24726", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24728, Source = "24728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24728", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24730, Source = "24730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24730", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24732, Source = "24732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24732", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24734, Source = "24734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24734", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24736, Source = "24736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24736", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24738, Source = "24738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24738", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24740, Source = "24740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24740", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24742, Source = "24742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24742", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24744, Source = "24744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24744", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24746, Source = "24746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24746", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24748, Source = "24748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24748", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24750, Source = "24750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24750", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24752, Source = "24752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24752", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24754, Source = "24754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24754", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24756, Source = "24756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24756", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24758, Source = "24758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24758", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24760, Source = "24760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24760", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24762, Source = "24762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24762", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24764, Source = "24764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24764", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24766, Source = "24766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24766", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24768, Source = "24768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24768", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24770, Source = "24770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24770", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24772, Source = "24772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24772", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24774, Source = "24774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24774", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24776, Source = "24776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24776", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24778, Source = "24778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24778", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24780, Source = "24780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24780", Category = "PLC/Y轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Y轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24800, Source = "24800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24800", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24802, Source = "24802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24802", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24804, Source = "24804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24804", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24806, Source = "24806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24806", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24808, Source = "24808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24808", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24810, Source = "24810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24810", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24812, Source = "24812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24812", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24814, Source = "24814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24814", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24816, Source = "24816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24816", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24818, Source = "24818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24818", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24820, Source = "24820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24820", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24822, Source = "24822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24822", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24824, Source = "24824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24824", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24826, Source = "24826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24826", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24828, Source = "24828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24828", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24830, Source = "24830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24830", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24832, Source = "24832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24832", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24834, Source = "24834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24834", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24836, Source = "24836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24836", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24838, Source = "24838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24838", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24840, Source = "24840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24840", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24842, Source = "24842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24842", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24844, Source = "24844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24844", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24846, Source = "24846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24846", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24848, Source = "24848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24848", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24850, Source = "24850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24850", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24852, Source = "24852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24852", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24854, Source = "24854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24854", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24856, Source = "24856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24856", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24858, Source = "24858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24858", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24860, Source = "24860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24860", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24862, Source = "24862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24862", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24864, Source = "24864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24864", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24866, Source = "24866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24866", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24868, Source = "24868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24868", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24870, Source = "24870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24870", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24872, Source = "24872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24872", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24874, Source = "24874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24874", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24876, Source = "24876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24876", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24878, Source = "24878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24878", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24880, Source = "24880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24880", Category = "PLC/相机调节步进轴_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24900, Source = "24900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24900", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24902, Source = "24902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24902", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24904, Source = "24904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24904", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24906, Source = "24906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24906", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24908, Source = "24908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24908", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24910, Source = "24910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24910", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24912, Source = "24912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24912", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24914, Source = "24914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24914", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24916, Source = "24916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24916", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24918, Source = "24918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24918", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24920, Source = "24920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24920", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24922, Source = "24922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24922", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24924, Source = "24924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24924", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24926, Source = "24926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24926", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24928, Source = "24928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24928", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24930, Source = "24930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24930", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24932, Source = "24932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24932", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24934, Source = "24934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24934", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24936, Source = "24936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24936", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24938, Source = "24938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24938", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24940, Source = "24940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24940", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24942, Source = "24942", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24942", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24944, Source = "24944", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24944", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24946, Source = "24946", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24946", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24948, Source = "24948", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24948", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24950, Source = "24950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24950", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24952, Source = "24952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24952", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24954, Source = "24954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24954", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24956, Source = "24956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24956", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24958, Source = "24958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24958", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24960, Source = "24960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24960", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24962, Source = "24962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24962", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24964, Source = "24964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24964", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24966, Source = "24966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24966", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24968, Source = "24968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24968", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24970, Source = "24970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24970", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24972, Source = "24972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24972", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24974, Source = "24974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24974", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24976, Source = "24976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24976", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24978, Source = "24978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24978", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24980, Source = "24980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24980", Category = "PLC/相机调节步进轴_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 相机调节步进轴_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25000, Source = "25000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25000", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25002, Source = "25002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25002", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25004, Source = "25004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25004", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25006, Source = "25006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25006", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25008, Source = "25008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25008", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25010, Source = "25010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25010", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25012, Source = "25012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25012", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25014, Source = "25014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25014", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25016, Source = "25016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25016", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25018, Source = "25018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25018", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25020, Source = "25020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25020", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25022, Source = "25022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25022", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25024, Source = "25024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25024", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25026, Source = "25026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25026", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25028, Source = "25028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25028", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25030, Source = "25030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25030", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25032, Source = "25032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25032", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25034, Source = "25034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25034", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25036, Source = "25036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25036", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25038, Source = "25038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25038", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25040, Source = "25040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25040", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25042, Source = "25042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25042", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25044, Source = "25044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25044", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25046, Source = "25046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25046", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25048, Source = "25048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25048", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25050, Source = "25050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25050", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25052, Source = "25052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25052", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25054, Source = "25054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25054", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25056, Source = "25056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25056", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25058, Source = "25058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25058", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25060, Source = "25060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25060", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25062, Source = "25062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25062", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25064, Source = "25064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25064", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25066, Source = "25066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25066", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25068, Source = "25068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25068", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25070, Source = "25070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25070", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25072, Source = "25072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25072", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25074, Source = "25074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25074", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25076, Source = "25076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25076", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25078, Source = "25078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25078", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25080, Source = "25080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25080", Category = "PLC/吸料轴Z1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25100, Source = "25100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25100", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25102, Source = "25102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25102", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25104, Source = "25104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25104", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25106, Source = "25106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25106", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25108, Source = "25108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25108", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25110, Source = "25110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25110", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25112, Source = "25112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25112", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25114, Source = "25114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25114", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25116, Source = "25116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25116", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25118, Source = "25118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25118", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25120, Source = "25120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25120", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25122, Source = "25122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25122", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25124, Source = "25124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25124", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25126, Source = "25126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25126", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25128, Source = "25128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25128", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25130, Source = "25130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25130", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25132, Source = "25132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25132", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25134, Source = "25134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25134", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25136, Source = "25136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25136", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25138, Source = "25138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25138", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25140, Source = "25140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25140", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25142, Source = "25142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25142", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25144, Source = "25144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25144", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25146, Source = "25146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25146", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25148, Source = "25148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25148", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25150, Source = "25150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25150", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25152, Source = "25152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25152", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25154, Source = "25154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25154", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25156, Source = "25156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25156", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25158, Source = "25158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25158", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25160, Source = "25160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25160", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25162, Source = "25162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25162", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25164, Source = "25164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25164", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25166, Source = "25166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25166", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25168, Source = "25168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25168", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25170, Source = "25170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25170", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25172, Source = "25172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25172", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25174, Source = "25174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25174", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25176, Source = "25176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25176", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25178, Source = "25178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25178", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25180, Source = "25180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25180", Category = "PLC/吸料轴Z1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25200, Source = "25200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25200", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25202, Source = "25202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25202", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25204, Source = "25204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25204", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25206, Source = "25206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25206", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25208, Source = "25208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25208", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25210, Source = "25210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25210", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25212, Source = "25212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25212", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25214, Source = "25214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25214", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25216, Source = "25216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25216", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25218, Source = "25218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25218", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25220, Source = "25220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25220", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25222, Source = "25222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25222", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25224, Source = "25224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25224", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25226, Source = "25226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25226", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25228, Source = "25228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25228", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25230, Source = "25230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25230", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25232, Source = "25232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25232", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25234, Source = "25234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25234", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25236, Source = "25236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25236", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25238, Source = "25238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25238", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25240, Source = "25240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25240", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25242, Source = "25242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25242", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25244, Source = "25244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25244", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25246, Source = "25246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25246", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25248, Source = "25248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25248", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25250, Source = "25250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25250", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25252, Source = "25252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25252", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25254, Source = "25254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25254", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25256, Source = "25256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25256", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25258, Source = "25258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25258", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25260, Source = "25260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25260", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25262, Source = "25262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25262", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25264, Source = "25264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25264", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25266, Source = "25266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25266", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25268, Source = "25268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25268", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25270, Source = "25270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25270", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25272, Source = "25272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25272", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25274, Source = "25274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25274", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25276, Source = "25276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25276", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25278, Source = "25278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25278", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25280, Source = "25280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25280", Category = "PLC/吸料轴R1_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25300, Source = "25300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25300", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25302, Source = "25302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25302", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25304, Source = "25304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25304", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25306, Source = "25306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25306", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25308, Source = "25308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25308", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25310, Source = "25310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25310", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25312, Source = "25312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25312", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25314, Source = "25314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25314", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25316, Source = "25316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25316", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25318, Source = "25318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25318", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25320, Source = "25320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25320", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25322, Source = "25322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25322", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25324, Source = "25324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25324", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25326, Source = "25326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25326", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25328, Source = "25328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25328", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25330, Source = "25330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25330", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25332, Source = "25332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25332", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25334, Source = "25334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25334", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25336, Source = "25336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25336", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25338, Source = "25338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25338", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25340, Source = "25340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25340", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25342, Source = "25342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25342", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25344, Source = "25344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25344", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25346, Source = "25346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25346", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25348, Source = "25348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25348", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25350, Source = "25350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25350", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25352, Source = "25352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25352", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25354, Source = "25354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25354", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25356, Source = "25356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25356", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25358, Source = "25358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25358", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25360, Source = "25360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25360", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25362, Source = "25362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25362", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25364, Source = "25364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25364", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25366, Source = "25366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25366", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25368, Source = "25368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25368", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25370, Source = "25370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25370", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25372, Source = "25372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25372", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25374, Source = "25374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25374", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25376, Source = "25376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25376", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25378, Source = "25378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25378", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25380, Source = "25380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25380", Category = "PLC/吸料轴R1_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R1_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25400, Source = "25400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25400", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25402, Source = "25402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25402", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25404, Source = "25404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25404", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25406, Source = "25406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25406", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25408, Source = "25408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25408", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25410, Source = "25410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25410", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25412, Source = "25412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25412", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25414, Source = "25414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25414", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25416, Source = "25416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25416", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25418, Source = "25418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25418", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25420, Source = "25420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25420", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25422, Source = "25422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25422", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25424, Source = "25424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25424", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25426, Source = "25426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25426", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25428, Source = "25428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25428", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25430, Source = "25430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25430", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25432, Source = "25432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25432", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25434, Source = "25434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25434", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25436, Source = "25436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25436", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25438, Source = "25438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25438", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25440, Source = "25440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25440", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25442, Source = "25442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25442", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25444, Source = "25444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25444", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25446, Source = "25446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25446", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25448, Source = "25448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25448", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25450, Source = "25450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25450", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25452, Source = "25452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25452", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25454, Source = "25454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25454", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25456, Source = "25456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25456", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25458, Source = "25458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25458", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25460, Source = "25460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25460", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25462, Source = "25462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25462", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25464, Source = "25464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25464", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25466, Source = "25466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25466", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25468, Source = "25468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25468", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25470, Source = "25470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25470", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25472, Source = "25472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25472", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25474, Source = "25474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25474", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25476, Source = "25476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25476", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25478, Source = "25478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25478", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25480, Source = "25480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25480", Category = "PLC/吸料轴Z2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25500, Source = "25500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25500", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25502, Source = "25502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25502", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25504, Source = "25504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25504", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25506, Source = "25506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25506", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25508, Source = "25508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25508", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25510, Source = "25510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25510", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25512, Source = "25512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25512", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25514, Source = "25514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25514", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25516, Source = "25516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25516", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25518, Source = "25518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25518", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25520, Source = "25520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25520", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25522, Source = "25522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25522", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25524, Source = "25524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25524", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25526, Source = "25526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25526", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25528, Source = "25528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25528", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25530, Source = "25530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25530", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25532, Source = "25532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25532", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25534, Source = "25534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25534", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25536, Source = "25536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25536", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25538, Source = "25538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25538", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25540, Source = "25540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25540", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25542, Source = "25542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25542", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25544, Source = "25544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25544", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25546, Source = "25546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25546", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25548, Source = "25548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25548", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25550, Source = "25550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25550", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25552, Source = "25552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25552", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25554, Source = "25554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25554", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25556, Source = "25556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25556", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25558, Source = "25558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25558", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25560, Source = "25560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25560", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25562, Source = "25562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25562", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25564, Source = "25564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25564", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25566, Source = "25566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25566", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25568, Source = "25568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25568", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25570, Source = "25570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25570", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25572, Source = "25572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25572", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25574, Source = "25574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25574", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25576, Source = "25576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25576", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25578, Source = "25578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25578", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25580, Source = "25580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25580", Category = "PLC/吸料轴Z2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25600, Source = "25600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25600", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25602, Source = "25602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25602", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25604, Source = "25604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25604", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25606, Source = "25606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25606", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25608, Source = "25608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25608", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25610, Source = "25610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25610", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25612, Source = "25612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25612", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25614, Source = "25614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25614", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25616, Source = "25616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25616", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25618, Source = "25618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25618", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25620, Source = "25620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25620", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25622, Source = "25622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25622", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25624, Source = "25624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25624", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25626, Source = "25626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25626", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25628, Source = "25628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25628", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25630, Source = "25630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25630", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25632, Source = "25632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25632", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25634, Source = "25634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25634", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25636, Source = "25636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25636", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25638, Source = "25638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25638", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25640, Source = "25640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25640", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25642, Source = "25642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25642", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25644, Source = "25644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25644", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25646, Source = "25646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25646", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25648, Source = "25648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25648", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25650, Source = "25650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25650", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25652, Source = "25652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25652", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25654, Source = "25654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25654", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25656, Source = "25656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25656", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25658, Source = "25658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25658", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25660, Source = "25660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25660", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25662, Source = "25662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25662", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25664, Source = "25664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25664", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25666, Source = "25666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25666", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25668, Source = "25668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25668", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25670, Source = "25670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25670", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25672, Source = "25672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25672", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25674, Source = "25674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25674", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25676, Source = "25676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25676", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25678, Source = "25678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25678", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25680, Source = "25680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25680", Category = "PLC/吸料轴R2_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25700, Source = "25700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25700", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25702, Source = "25702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25702", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25704, Source = "25704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25704", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25706, Source = "25706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25706", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25708, Source = "25708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25708", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25710, Source = "25710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25710", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25712, Source = "25712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25712", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25714, Source = "25714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25714", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25716, Source = "25716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25716", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25718, Source = "25718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25718", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25720, Source = "25720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25720", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25722, Source = "25722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25722", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25724, Source = "25724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25724", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25726, Source = "25726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25726", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25728, Source = "25728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25728", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25730, Source = "25730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25730", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25732, Source = "25732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25732", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25734, Source = "25734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25734", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25736, Source = "25736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25736", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25738, Source = "25738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25738", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25740, Source = "25740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25740", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25742, Source = "25742", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25742", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25744, Source = "25744", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25744", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25746, Source = "25746", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25746", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25748, Source = "25748", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25748", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25750, Source = "25750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25750", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25752, Source = "25752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25752", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25754, Source = "25754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25754", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25756, Source = "25756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25756", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25758, Source = "25758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25758", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25760, Source = "25760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25760", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25762, Source = "25762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25762", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25764, Source = "25764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25764", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25766, Source = "25766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25766", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25768, Source = "25768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25768", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25770, Source = "25770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25770", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25772, Source = "25772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25772", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25774, Source = "25774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25774", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25776, Source = "25776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25776", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25778, Source = "25778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25778", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25780, Source = "25780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25780", Category = "PLC/吸料轴R2_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R2_Vel_41 { get; set; }

	[BinaryPoint(Offset = 25800, Source = "25800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25800", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25802, Source = "25802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25802", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25804, Source = "25804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25804", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25806, Source = "25806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25806", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25808, Source = "25808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25808", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25810, Source = "25810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25810", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25812, Source = "25812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25812", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25814, Source = "25814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25814", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25816, Source = "25816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25816", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25818, Source = "25818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25818", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25820, Source = "25820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25820", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25822, Source = "25822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25822", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25824, Source = "25824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25824", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25826, Source = "25826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25826", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25828, Source = "25828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25828", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25830, Source = "25830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25830", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25832, Source = "25832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25832", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25834, Source = "25834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25834", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25836, Source = "25836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25836", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25838, Source = "25838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25838", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25840, Source = "25840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25840", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_21 { get; set; }

	[BinaryPoint(Offset = 25842, Source = "25842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25842", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_22 { get; set; }

	[BinaryPoint(Offset = 25844, Source = "25844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25844", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_23 { get; set; }

	[BinaryPoint(Offset = 25846, Source = "25846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25846", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_24 { get; set; }

	[BinaryPoint(Offset = 25848, Source = "25848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25848", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_25 { get; set; }

	[BinaryPoint(Offset = 25850, Source = "25850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25850", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_26 { get; set; }

	[BinaryPoint(Offset = 25852, Source = "25852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25852", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_27 { get; set; }

	[BinaryPoint(Offset = 25854, Source = "25854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25854", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_28 { get; set; }

	[BinaryPoint(Offset = 25856, Source = "25856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25856", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_29 { get; set; }

	[BinaryPoint(Offset = 25858, Source = "25858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25858", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_30 { get; set; }

	[BinaryPoint(Offset = 25860, Source = "25860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25860", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_31 { get; set; }

	[BinaryPoint(Offset = 25862, Source = "25862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25862", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_32 { get; set; }

	[BinaryPoint(Offset = 25864, Source = "25864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25864", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_33 { get; set; }

	[BinaryPoint(Offset = 25866, Source = "25866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25866", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_34 { get; set; }

	[BinaryPoint(Offset = 25868, Source = "25868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25868", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_35 { get; set; }

	[BinaryPoint(Offset = 25870, Source = "25870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25870", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_36 { get; set; }

	[BinaryPoint(Offset = 25872, Source = "25872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25872", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_37 { get; set; }

	[BinaryPoint(Offset = 25874, Source = "25874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25874", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_38 { get; set; }

	[BinaryPoint(Offset = 25876, Source = "25876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25876", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_39 { get; set; }

	[BinaryPoint(Offset = 25878, Source = "25878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25878", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_40 { get; set; }

	[BinaryPoint(Offset = 25880, Source = "25880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25880", Category = "PLC/吸料轴Z3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Pos_41 { get; set; }

	[BinaryPoint(Offset = 25900, Source = "25900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25900", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25902, Source = "25902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25902", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25904, Source = "25904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25904", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25906, Source = "25906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25906", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25908, Source = "25908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25908", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25910, Source = "25910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25910", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25912, Source = "25912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25912", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25914, Source = "25914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25914", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25916, Source = "25916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25916", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25918, Source = "25918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25918", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25920, Source = "25920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25920", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25922, Source = "25922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25922", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25924, Source = "25924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25924", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25926, Source = "25926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25926", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25928, Source = "25928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25928", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25930, Source = "25930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25930", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25932, Source = "25932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25932", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25934, Source = "25934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25934", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25936, Source = "25936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25936", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25938, Source = "25938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25938", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25940, Source = "25940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25940", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_21 { get; set; }

	[BinaryPoint(Offset = 25942, Source = "25942", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25942", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_22 { get; set; }

	[BinaryPoint(Offset = 25944, Source = "25944", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25944", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_23 { get; set; }

	[BinaryPoint(Offset = 25946, Source = "25946", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25946", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_24 { get; set; }

	[BinaryPoint(Offset = 25948, Source = "25948", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25948", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_25 { get; set; }

	[BinaryPoint(Offset = 25950, Source = "25950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25950", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_26 { get; set; }

	[BinaryPoint(Offset = 25952, Source = "25952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25952", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_27 { get; set; }

	[BinaryPoint(Offset = 25954, Source = "25954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25954", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_28 { get; set; }

	[BinaryPoint(Offset = 25956, Source = "25956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25956", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_29 { get; set; }

	[BinaryPoint(Offset = 25958, Source = "25958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25958", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_30 { get; set; }

	[BinaryPoint(Offset = 25960, Source = "25960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25960", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_31 { get; set; }

	[BinaryPoint(Offset = 25962, Source = "25962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25962", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_32 { get; set; }

	[BinaryPoint(Offset = 25964, Source = "25964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25964", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_33 { get; set; }

	[BinaryPoint(Offset = 25966, Source = "25966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25966", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_34 { get; set; }

	[BinaryPoint(Offset = 25968, Source = "25968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25968", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_35 { get; set; }

	[BinaryPoint(Offset = 25970, Source = "25970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25970", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_36 { get; set; }

	[BinaryPoint(Offset = 25972, Source = "25972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25972", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_37 { get; set; }

	[BinaryPoint(Offset = 25974, Source = "25974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25974", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_38 { get; set; }

	[BinaryPoint(Offset = 25976, Source = "25976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25976", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_39 { get; set; }

	[BinaryPoint(Offset = 25978, Source = "25978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25978", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_40 { get; set; }

	[BinaryPoint(Offset = 25980, Source = "25980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25980", Category = "PLC/吸料轴Z3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z3_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26000, Source = "26000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26000", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26002, Source = "26002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26002", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26004, Source = "26004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26004", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26006, Source = "26006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26006", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26008, Source = "26008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26008", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26010, Source = "26010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26010", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26012, Source = "26012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26012", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26014, Source = "26014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26014", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26016, Source = "26016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26016", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26018, Source = "26018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26018", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26020, Source = "26020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26020", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26022, Source = "26022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26022", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26024, Source = "26024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26024", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26026, Source = "26026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26026", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26028, Source = "26028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26028", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26030, Source = "26030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26030", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26032, Source = "26032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26032", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26034, Source = "26034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26034", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26036, Source = "26036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26036", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26038, Source = "26038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26038", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26040, Source = "26040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26040", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26042, Source = "26042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26042", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26044, Source = "26044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26044", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26046, Source = "26046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26046", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26048, Source = "26048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26048", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26050, Source = "26050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26050", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26052, Source = "26052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26052", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26054, Source = "26054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26054", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26056, Source = "26056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26056", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26058, Source = "26058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26058", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26060, Source = "26060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26060", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26062, Source = "26062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26062", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26064, Source = "26064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26064", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26066, Source = "26066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26066", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26068, Source = "26068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26068", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26070, Source = "26070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26070", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26072, Source = "26072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26072", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26074, Source = "26074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26074", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26076, Source = "26076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26076", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26078, Source = "26078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26078", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26080, Source = "26080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26080", Category = "PLC/吸料轴R3_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26100, Source = "26100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26100", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26102, Source = "26102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26102", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26104, Source = "26104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26104", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26106, Source = "26106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26106", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26108, Source = "26108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26108", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26110, Source = "26110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26110", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26112, Source = "26112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26112", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26114, Source = "26114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26114", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26116, Source = "26116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26116", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26118, Source = "26118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26118", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26120, Source = "26120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26120", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26122, Source = "26122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26122", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26124, Source = "26124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26124", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26126, Source = "26126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26126", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26128, Source = "26128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26128", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26130, Source = "26130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26130", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26132, Source = "26132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26132", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26134, Source = "26134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26134", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26136, Source = "26136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26136", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26138, Source = "26138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26138", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26140, Source = "26140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26140", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26142, Source = "26142", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26142", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26144, Source = "26144", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26144", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26146, Source = "26146", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26146", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26148, Source = "26148", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26148", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26150, Source = "26150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26150", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26152, Source = "26152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26152", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26154, Source = "26154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26154", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26156, Source = "26156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26156", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26158, Source = "26158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26158", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26160, Source = "26160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26160", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26162, Source = "26162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26162", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26164, Source = "26164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26164", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26166, Source = "26166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26166", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26168, Source = "26168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26168", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26170, Source = "26170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26170", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26172, Source = "26172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26172", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26174, Source = "26174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26174", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26176, Source = "26176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26176", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26178, Source = "26178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26178", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26180, Source = "26180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26180", Category = "PLC/吸料轴R3_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R3_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26200, Source = "26200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26200", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26202, Source = "26202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26202", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26204, Source = "26204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26204", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26206, Source = "26206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26206", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26208, Source = "26208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26208", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26210, Source = "26210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26210", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26212, Source = "26212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26212", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26214, Source = "26214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26214", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26216, Source = "26216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26216", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26218, Source = "26218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26218", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26220, Source = "26220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26220", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26222, Source = "26222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26222", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26224, Source = "26224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26224", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26226, Source = "26226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26226", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26228, Source = "26228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26228", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26230, Source = "26230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26230", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26232, Source = "26232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26232", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26234, Source = "26234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26234", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26236, Source = "26236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26236", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26238, Source = "26238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26238", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26240, Source = "26240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26240", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26242, Source = "26242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26242", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26244, Source = "26244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26244", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26246, Source = "26246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26246", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26248, Source = "26248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26248", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26250, Source = "26250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26250", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26252, Source = "26252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26252", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26254, Source = "26254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26254", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26256, Source = "26256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26256", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26258, Source = "26258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26258", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26260, Source = "26260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26260", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26262, Source = "26262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26262", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26264, Source = "26264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26264", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26266, Source = "26266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26266", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26268, Source = "26268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26268", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26270, Source = "26270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26270", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26272, Source = "26272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26272", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26274, Source = "26274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26274", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26276, Source = "26276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26276", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26278, Source = "26278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26278", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26280, Source = "26280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26280", Category = "PLC/吸料轴Z4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26300, Source = "26300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26300", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26302, Source = "26302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26302", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26304, Source = "26304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26304", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26306, Source = "26306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26306", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26308, Source = "26308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26308", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26310, Source = "26310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26310", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26312, Source = "26312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26312", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26314, Source = "26314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26314", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26316, Source = "26316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26316", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26318, Source = "26318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26318", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26320, Source = "26320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26320", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26322, Source = "26322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26322", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26324, Source = "26324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26324", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26326, Source = "26326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26326", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26328, Source = "26328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26328", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26330, Source = "26330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26330", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26332, Source = "26332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26332", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26334, Source = "26334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26334", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26336, Source = "26336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26336", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26338, Source = "26338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26338", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26340, Source = "26340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26340", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26342, Source = "26342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26342", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26344, Source = "26344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26344", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26346, Source = "26346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26346", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26348, Source = "26348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26348", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26350, Source = "26350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26350", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26352, Source = "26352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26352", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26354, Source = "26354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26354", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26356, Source = "26356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26356", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26358, Source = "26358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26358", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26360, Source = "26360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26360", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26362, Source = "26362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26362", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26364, Source = "26364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26364", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26366, Source = "26366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26366", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26368, Source = "26368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26368", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26370, Source = "26370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26370", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26372, Source = "26372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26372", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26374, Source = "26374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26374", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26376, Source = "26376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26376", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26378, Source = "26378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26378", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26380, Source = "26380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26380", Category = "PLC/吸料轴Z4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴Z4_Vel_41 { get; set; }

	[BinaryPoint(Offset = 26400, Source = "26400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26400", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26402, Source = "26402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26402", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26404, Source = "26404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26404", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26406, Source = "26406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26406", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26408, Source = "26408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26408", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26410, Source = "26410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26410", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26412, Source = "26412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26412", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26414, Source = "26414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26414", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26416, Source = "26416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26416", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26418, Source = "26418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26418", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26420, Source = "26420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26420", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26422, Source = "26422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26422", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26424, Source = "26424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26424", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26426, Source = "26426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26426", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26428, Source = "26428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26428", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26430, Source = "26430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26430", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26432, Source = "26432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26432", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26434, Source = "26434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26434", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26436, Source = "26436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26436", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26438, Source = "26438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26438", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26440, Source = "26440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26440", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_21 { get; set; }

	[BinaryPoint(Offset = 26442, Source = "26442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26442", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_22 { get; set; }

	[BinaryPoint(Offset = 26444, Source = "26444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26444", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_23 { get; set; }

	[BinaryPoint(Offset = 26446, Source = "26446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26446", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_24 { get; set; }

	[BinaryPoint(Offset = 26448, Source = "26448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26448", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_25 { get; set; }

	[BinaryPoint(Offset = 26450, Source = "26450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26450", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_26 { get; set; }

	[BinaryPoint(Offset = 26452, Source = "26452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26452", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_27 { get; set; }

	[BinaryPoint(Offset = 26454, Source = "26454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26454", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_28 { get; set; }

	[BinaryPoint(Offset = 26456, Source = "26456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26456", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_29 { get; set; }

	[BinaryPoint(Offset = 26458, Source = "26458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26458", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_30 { get; set; }

	[BinaryPoint(Offset = 26460, Source = "26460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26460", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_31 { get; set; }

	[BinaryPoint(Offset = 26462, Source = "26462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26462", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_32 { get; set; }

	[BinaryPoint(Offset = 26464, Source = "26464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26464", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_33 { get; set; }

	[BinaryPoint(Offset = 26466, Source = "26466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26466", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_34 { get; set; }

	[BinaryPoint(Offset = 26468, Source = "26468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26468", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_35 { get; set; }

	[BinaryPoint(Offset = 26470, Source = "26470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26470", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_36 { get; set; }

	[BinaryPoint(Offset = 26472, Source = "26472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26472", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_37 { get; set; }

	[BinaryPoint(Offset = 26474, Source = "26474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26474", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_38 { get; set; }

	[BinaryPoint(Offset = 26476, Source = "26476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26476", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_39 { get; set; }

	[BinaryPoint(Offset = 26478, Source = "26478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26478", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_40 { get; set; }

	[BinaryPoint(Offset = 26480, Source = "26480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26480", Category = "PLC/吸料轴R4_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Pos_41 { get; set; }

	[BinaryPoint(Offset = 26500, Source = "26500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26500", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26502, Source = "26502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26502", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26504, Source = "26504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26504", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26506, Source = "26506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26506", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26508, Source = "26508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26508", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26510, Source = "26510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26510", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26512, Source = "26512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26512", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26514, Source = "26514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26514", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26516, Source = "26516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26516", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26518, Source = "26518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26518", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26520, Source = "26520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26520", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26522, Source = "26522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26522", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26524, Source = "26524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26524", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26526, Source = "26526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26526", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26528, Source = "26528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26528", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26530, Source = "26530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26530", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26532, Source = "26532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26532", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26534, Source = "26534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26534", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26536, Source = "26536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26536", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26538, Source = "26538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26538", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26540, Source = "26540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26540", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_21 { get; set; }

	[BinaryPoint(Offset = 26542, Source = "26542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26542", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_22 { get; set; }

	[BinaryPoint(Offset = 26544, Source = "26544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26544", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_23 { get; set; }

	[BinaryPoint(Offset = 26546, Source = "26546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26546", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_24 { get; set; }

	[BinaryPoint(Offset = 26548, Source = "26548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26548", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_25 { get; set; }

	[BinaryPoint(Offset = 26550, Source = "26550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26550", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_26 { get; set; }

	[BinaryPoint(Offset = 26552, Source = "26552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26552", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_27 { get; set; }

	[BinaryPoint(Offset = 26554, Source = "26554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26554", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_28 { get; set; }

	[BinaryPoint(Offset = 26556, Source = "26556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26556", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_29 { get; set; }

	[BinaryPoint(Offset = 26558, Source = "26558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26558", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_30 { get; set; }

	[BinaryPoint(Offset = 26560, Source = "26560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26560", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_31 { get; set; }

	[BinaryPoint(Offset = 26562, Source = "26562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26562", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_32 { get; set; }

	[BinaryPoint(Offset = 26564, Source = "26564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26564", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_33 { get; set; }

	[BinaryPoint(Offset = 26566, Source = "26566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26566", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_34 { get; set; }

	[BinaryPoint(Offset = 26568, Source = "26568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26568", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_35 { get; set; }

	[BinaryPoint(Offset = 26570, Source = "26570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26570", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_36 { get; set; }

	[BinaryPoint(Offset = 26572, Source = "26572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26572", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_37 { get; set; }

	[BinaryPoint(Offset = 26574, Source = "26574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26574", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_38 { get; set; }

	[BinaryPoint(Offset = 26576, Source = "26576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26576", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_39 { get; set; }

	[BinaryPoint(Offset = 26578, Source = "26578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26578", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_40 { get; set; }

	[BinaryPoint(Offset = 26580, Source = "26580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26580", Category = "PLC/吸料轴R4_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸料轴R4_Vel_41 { get; set; }

	#endregion

}