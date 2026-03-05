
// GENERATE AT 2026/3/5 17:59:26
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
public partial class ProductRecipe
{

	#region CSV INCLUDE POINTS: 模板

	#endregion

	#region CSV INCLUDE POINTS: PLC

	[BinaryPoint(Offset = 24000, Source = "24000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24000", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_0", ])]
	public float 上料轴1_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24002, Source = "24002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24002", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_1", ])]
	public float 上料轴1_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24004, Source = "24004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24004", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_2", ])]
	public float 上料轴1_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24006, Source = "24006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24006", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_3", ])]
	public float 上料轴1_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24008, Source = "24008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24008", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_4", ])]
	public float 上料轴1_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24010, Source = "24010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24010", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_5", ])]
	public float 上料轴1_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24012, Source = "24012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24012", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_6", ])]
	public float 上料轴1_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24014, Source = "24014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24014", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_7", ])]
	public float 上料轴1_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24016, Source = "24016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24016", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_8", ])]
	public float 上料轴1_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24018, Source = "24018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24018", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_9", ])]
	public float 上料轴1_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24020, Source = "24020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24020", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_10", ])]
	public float 上料轴1_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24022, Source = "24022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24022", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_11", ])]
	public float 上料轴1_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24024, Source = "24024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24024", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_12", ])]
	public float 上料轴1_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24026, Source = "24026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24026", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_13", ])]
	public float 上料轴1_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24028, Source = "24028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24028", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_14", ])]
	public float 上料轴1_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24030, Source = "24030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24030", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_15", ])]
	public float 上料轴1_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24032, Source = "24032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24032", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_16", ])]
	public float 上料轴1_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24034, Source = "24034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24034", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_17", ])]
	public float 上料轴1_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24036, Source = "24036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24036", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_18", ])]
	public float 上料轴1_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24038, Source = "24038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24038", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_19", ])]
	public float 上料轴1_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24040, Source = "24040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24040", Category = "PLC/上料轴1_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_Địa điểm_20", ])]
	public float 上料轴1_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24050, Source = "24050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24050", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_0", ])]
	public float 上料轴1_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24052, Source = "24052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24052", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_1", ])]
	public float 上料轴1_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24054, Source = "24054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24054", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_2", ])]
	public float 上料轴1_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24056, Source = "24056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24056", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_3", ])]
	public float 上料轴1_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24058, Source = "24058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24058", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_4", ])]
	public float 上料轴1_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24060, Source = "24060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24060", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_5", ])]
	public float 上料轴1_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24062, Source = "24062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24062", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_6", ])]
	public float 上料轴1_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24064, Source = "24064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24064", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_7", ])]
	public float 上料轴1_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24066, Source = "24066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24066", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_8", ])]
	public float 上料轴1_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24068, Source = "24068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24068", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_9", ])]
	public float 上料轴1_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24070, Source = "24070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24070", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_10", ])]
	public float 上料轴1_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24072, Source = "24072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24072", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_11", ])]
	public float 上料轴1_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24074, Source = "24074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24074", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_12", ])]
	public float 上料轴1_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24076, Source = "24076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24076", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_13", ])]
	public float 上料轴1_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24078, Source = "24078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24078", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_14", ])]
	public float 上料轴1_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24080, Source = "24080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24080", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_15", ])]
	public float 上料轴1_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24082, Source = "24082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24082", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_16", ])]
	public float 上料轴1_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24084, Source = "24084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24084", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_17", ])]
	public float 上料轴1_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24086, Source = "24086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24086", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_18", ])]
	public float 上料轴1_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24088, Source = "24088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24088", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_19", ])]
	public float 上料轴1_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24090, Source = "24090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24090", Category = "PLC/上料轴1_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴1_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1_trục_tốc độ_20", ])]
	public float 上料轴1_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24100, Source = "24100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24100", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_0", ])]
	public float 上料轴2_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24102, Source = "24102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24102", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_1", ])]
	public float 上料轴2_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24104, Source = "24104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24104", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_2", ])]
	public float 上料轴2_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24106, Source = "24106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24106", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_3", ])]
	public float 上料轴2_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24108, Source = "24108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24108", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_4", ])]
	public float 上料轴2_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24110, Source = "24110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24110", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_5", ])]
	public float 上料轴2_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24112, Source = "24112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24112", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_6", ])]
	public float 上料轴2_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24114, Source = "24114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24114", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_7", ])]
	public float 上料轴2_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24116, Source = "24116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24116", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_8", ])]
	public float 上料轴2_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24118, Source = "24118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24118", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_9", ])]
	public float 上料轴2_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24120, Source = "24120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24120", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_10", ])]
	public float 上料轴2_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24122, Source = "24122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24122", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_11", ])]
	public float 上料轴2_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24124, Source = "24124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24124", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_12", ])]
	public float 上料轴2_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24126, Source = "24126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24126", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_13", ])]
	public float 上料轴2_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24128, Source = "24128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24128", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_14", ])]
	public float 上料轴2_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24130, Source = "24130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24130", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_15", ])]
	public float 上料轴2_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24132, Source = "24132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24132", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_16", ])]
	public float 上料轴2_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24134, Source = "24134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24134", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_17", ])]
	public float 上料轴2_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24136, Source = "24136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24136", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_18", ])]
	public float 上料轴2_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24138, Source = "24138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24138", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_19", ])]
	public float 上料轴2_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24140, Source = "24140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24140", Category = "PLC/上料轴2_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_Địa điểm_20", ])]
	public float 上料轴2_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24150, Source = "24150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24150", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_0", ])]
	public float 上料轴2_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24152, Source = "24152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24152", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_1", ])]
	public float 上料轴2_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24154, Source = "24154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24154", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_2", ])]
	public float 上料轴2_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24156, Source = "24156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24156", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_3", ])]
	public float 上料轴2_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24158, Source = "24158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24158", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_4", ])]
	public float 上料轴2_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24160, Source = "24160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24160", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_5", ])]
	public float 上料轴2_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24162, Source = "24162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24162", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_6", ])]
	public float 上料轴2_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24164, Source = "24164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24164", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_7", ])]
	public float 上料轴2_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24166, Source = "24166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24166", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_8", ])]
	public float 上料轴2_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24168, Source = "24168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24168", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_9", ])]
	public float 上料轴2_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24170, Source = "24170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24170", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_10", ])]
	public float 上料轴2_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24172, Source = "24172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24172", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_11", ])]
	public float 上料轴2_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24174, Source = "24174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24174", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_12", ])]
	public float 上料轴2_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24176, Source = "24176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24176", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_13", ])]
	public float 上料轴2_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24178, Source = "24178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24178", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_14", ])]
	public float 上料轴2_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24180, Source = "24180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24180", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_15", ])]
	public float 上料轴2_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24182, Source = "24182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24182", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_16", ])]
	public float 上料轴2_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24184, Source = "24184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24184", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_17", ])]
	public float 上料轴2_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24186, Source = "24186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24186", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_18", ])]
	public float 上料轴2_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24188, Source = "24188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24188", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_19", ])]
	public float 上料轴2_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24190, Source = "24190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24190", Category = "PLC/上料轴2_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "上料轴2_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2_trục_tốc độ_20", ])]
	public float 上料轴2_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24200, Source = "24200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24200", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_0", ])]
	public float X轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24202, Source = "24202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24202", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_1", ])]
	public float X轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24204, Source = "24204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24204", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_2", ])]
	public float X轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24206, Source = "24206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24206", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_3", ])]
	public float X轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24208, Source = "24208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24208", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Phos_4",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_4", ])]
	public float X轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24210, Source = "24210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24210", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_5", ])]
	public float X轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24212, Source = "24212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24212", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Phos_6",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_6", ])]
	public float X轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24214, Source = "24214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24214", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_7", ])]
	public float X轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24216, Source = "24216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24216", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_8", ])]
	public float X轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24218, Source = "24218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24218", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_9", ])]
	public float X轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24220, Source = "24220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24220", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_10", ])]
	public float X轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24222, Source = "24222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24222", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_11", ])]
	public float X轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24224, Source = "24224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24224", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_12", ])]
	public float X轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24226, Source = "24226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24226", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_13", ])]
	public float X轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24228, Source = "24228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24228", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_14", ])]
	public float X轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24230, Source = "24230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24230", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_15", ])]
	public float X轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24232, Source = "24232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24232", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_16", ])]
	public float X轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24234, Source = "24234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24234", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_17", ])]
	public float X轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24236, Source = "24236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24236", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_18", ])]
	public float X轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24238, Source = "24238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24238", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_19", ])]
	public float X轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24240, Source = "24240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24240", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_20", ])]
	public float X轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24242, Source = "24242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24242", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_21",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_21",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_21", ])]
	public float X轴_Axis_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24244, Source = "24244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24244", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_22",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_22",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_22", ])]
	public float X轴_Axis_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24246, Source = "24246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24246", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_23",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_23",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_23", ])]
	public float X轴_Axis_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24248, Source = "24248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24248", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_24",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_24",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_24", ])]
	public float X轴_Axis_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24250, Source = "24250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24250", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_25",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_25",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_25", ])]
	public float X轴_Axis_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24252, Source = "24252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24252", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_26",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_26",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_26", ])]
	public float X轴_Axis_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24254, Source = "24254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24254", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_27",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_27",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_27", ])]
	public float X轴_Axis_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24256, Source = "24256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24256", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_28",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_28",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_28", ])]
	public float X轴_Axis_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24258, Source = "24258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24258", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_29",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_29",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_29", ])]
	public float X轴_Axis_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24260, Source = "24260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24260", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_30",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_30",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_30", ])]
	public float X轴_Axis_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24262, Source = "24262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24262", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_31",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_31",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_31", ])]
	public float X轴_Axis_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24264, Source = "24264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24264", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_32",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_32",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_32", ])]
	public float X轴_Axis_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24266, Source = "24266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24266", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_33",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_33",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_33", ])]
	public float X轴_Axis_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24268, Source = "24268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24268", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_34",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_34",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_34", ])]
	public float X轴_Axis_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24270, Source = "24270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24270", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_35",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_35",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_35", ])]
	public float X轴_Axis_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24272, Source = "24272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24272", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_36",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_36",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_36", ])]
	public float X轴_Axis_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24274, Source = "24274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24274", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_37",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_37",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_37", ])]
	public float X轴_Axis_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24276, Source = "24276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24276", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_38",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_38",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_38", ])]
	public float X轴_Axis_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24278, Source = "24278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24278", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_39",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_39",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_39", ])]
	public float X轴_Axis_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24280, Source = "24280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24280", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_40",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos-40",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_40", ])]
	public float X轴_Axis_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24282, Source = "24282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24282", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_41",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_41",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_41", ])]
	public float X轴_Axis_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24284, Source = "24284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24284", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_42",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_42",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_42", ])]
	public float X轴_Axis_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24286, Source = "24286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24286", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_43",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos-43",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_43", ])]
	public float X轴_Axis_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24288, Source = "24288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24288", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_44",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_44",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_44", ])]
	public float X轴_Axis_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24290, Source = "24290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24290", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_45",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_45",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_45", ])]
	public float X轴_Axis_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24292, Source = "24292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24292", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_46",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos-46",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_46", ])]
	public float X轴_Axis_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24294, Source = "24294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24294", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_47",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_47",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_47", ])]
	public float X轴_Axis_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24296, Source = "24296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24296", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_48",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos_48",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_48", ])]
	public float X轴_Axis_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24298, Source = "24298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24298", Category = "PLC/X轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Pos_49",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Pos-49",
		DataDefine.KeyValue,"NameByVI", "Trục X_Vị trí_49", ])]
	public float X轴_Axis_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24300, Source = "24300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24300", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_0", ])]
	public float X轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24302, Source = "24302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24302", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_1", ])]
	public float X轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24304, Source = "24304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24304", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_2", ])]
	public float X轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24306, Source = "24306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24306", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_3", ])]
	public float X轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24308, Source = "24308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24308", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_4", ])]
	public float X轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24310, Source = "24310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24310", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_5", ])]
	public float X轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24312, Source = "24312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24312", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_6", ])]
	public float X轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24314, Source = "24314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24314", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_7", ])]
	public float X轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24316, Source = "24316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24316", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_8", ])]
	public float X轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24318, Source = "24318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24318", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_9", ])]
	public float X轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24320, Source = "24320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24320", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_10", ])]
	public float X轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24322, Source = "24322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24322", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_11", ])]
	public float X轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24324, Source = "24324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24324", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_12", ])]
	public float X轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24326, Source = "24326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24326", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_13", ])]
	public float X轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24328, Source = "24328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24328", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_14", ])]
	public float X轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24330, Source = "24330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24330", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_15", ])]
	public float X轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24332, Source = "24332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24332", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_16", ])]
	public float X轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24334, Source = "24334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24334", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_17", ])]
	public float X轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24336, Source = "24336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24336", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_18", ])]
	public float X轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24338, Source = "24338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24338", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_19", ])]
	public float X轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24340, Source = "24340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24340", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_20", ])]
	public float X轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24342, Source = "24342", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24342", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_21",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_21",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_21", ])]
	public float X轴_Axis_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24344, Source = "24344", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24344", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_22",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_22",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_22", ])]
	public float X轴_Axis_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24346, Source = "24346", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24346", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_23",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_23",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_23", ])]
	public float X轴_Axis_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24348, Source = "24348", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24348", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_24",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_24",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_24", ])]
	public float X轴_Axis_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24350, Source = "24350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24350", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_25",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_25",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_25", ])]
	public float X轴_Axis_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24352, Source = "24352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24352", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_26",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_26",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_26", ])]
	public float X轴_Axis_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24354, Source = "24354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24354", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_27",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_27",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_27", ])]
	public float X轴_Axis_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24356, Source = "24356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24356", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_28",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_28",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_28", ])]
	public float X轴_Axis_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24358, Source = "24358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24358", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_29",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_29",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_29", ])]
	public float X轴_Axis_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24360, Source = "24360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24360", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_30",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_30",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_30", ])]
	public float X轴_Axis_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24362, Source = "24362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24362", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_31",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_31",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_31", ])]
	public float X轴_Axis_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24364, Source = "24364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24364", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_32",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_32",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_32", ])]
	public float X轴_Axis_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24366, Source = "24366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24366", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_33",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_33",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_33", ])]
	public float X轴_Axis_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24368, Source = "24368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24368", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_34",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_34",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_34", ])]
	public float X轴_Axis_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24370, Source = "24370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24370", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_35",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_35",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_35", ])]
	public float X轴_Axis_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24372, Source = "24372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24372", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_36",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_36",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_36", ])]
	public float X轴_Axis_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24374, Source = "24374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24374", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_37",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_37",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_37", ])]
	public float X轴_Axis_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24376, Source = "24376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24376", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_38",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_38",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_38", ])]
	public float X轴_Axis_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24378, Source = "24378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24378", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_39",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_39",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_39", ])]
	public float X轴_Axis_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24380, Source = "24380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24380", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_40",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_40",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_40", ])]
	public float X轴_Axis_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24382, Source = "24382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24382", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_41",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_41",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_41", ])]
	public float X轴_Axis_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24384, Source = "24384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24384", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_42",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_42",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_42", ])]
	public float X轴_Axis_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24386, Source = "24386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24386", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_43",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_43",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_43", ])]
	public float X轴_Axis_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24388, Source = "24388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24388", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_44",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_44",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_44", ])]
	public float X轴_Axis_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24390, Source = "24390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24390", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_45",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_45",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_45", ])]
	public float X轴_Axis_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24392, Source = "24392", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24392", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_46",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_46",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_46", ])]
	public float X轴_Axis_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24394, Source = "24394", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24394", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_47",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_47",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_47", ])]
	public float X轴_Axis_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24396, Source = "24396", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24396", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_48",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_48",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_48", ])]
	public float X轴_Axis_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24398, Source = "24398", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24398", Category = "PLC/X轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "X轴_Axis_Vel_49",
		DataDefine.KeyValue,"NameByEN", "X axis_Axis_Vel_49",
		DataDefine.KeyValue,"NameByVI", "Trục X_Tốc độ_49", ])]
	public float X轴_Axis_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24400, Source = "24400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24400", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_0", ])]
	public float Y轴_AYis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24402, Source = "24402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24402", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_1", ])]
	public float Y轴_AYis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24404, Source = "24404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24404", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_2", ])]
	public float Y轴_AYis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24406, Source = "24406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24406", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_3", ])]
	public float Y轴_AYis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24408, Source = "24408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24408", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Phos_4",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_4", ])]
	public float Y轴_AYis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24410, Source = "24410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24410", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_5", ])]
	public float Y轴_AYis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24412, Source = "24412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24412", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Phos_6",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_6", ])]
	public float Y轴_AYis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24414, Source = "24414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24414", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_7", ])]
	public float Y轴_AYis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24416, Source = "24416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24416", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_8", ])]
	public float Y轴_AYis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24418, Source = "24418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24418", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_9", ])]
	public float Y轴_AYis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24420, Source = "24420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24420", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_10", ])]
	public float Y轴_AYis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24422, Source = "24422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24422", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_11", ])]
	public float Y轴_AYis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24424, Source = "24424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24424", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_12", ])]
	public float Y轴_AYis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24426, Source = "24426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24426", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_13", ])]
	public float Y轴_AYis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24428, Source = "24428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24428", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_14", ])]
	public float Y轴_AYis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24430, Source = "24430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24430", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_15", ])]
	public float Y轴_AYis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24432, Source = "24432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24432", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_16", ])]
	public float Y轴_AYis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24434, Source = "24434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24434", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_17", ])]
	public float Y轴_AYis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24436, Source = "24436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24436", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_18", ])]
	public float Y轴_AYis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24438, Source = "24438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24438", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_19", ])]
	public float Y轴_AYis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24440, Source = "24440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24440", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_20", ])]
	public float Y轴_AYis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24442, Source = "24442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24442", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_21",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_21",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_21", ])]
	public float Y轴_AYis_Pos_21 { get; set; }

	[BinaryPoint(Offset = 24444, Source = "24444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24444", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_22",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_22",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_22", ])]
	public float Y轴_AYis_Pos_22 { get; set; }

	[BinaryPoint(Offset = 24446, Source = "24446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24446", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_23",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_23",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_23", ])]
	public float Y轴_AYis_Pos_23 { get; set; }

	[BinaryPoint(Offset = 24448, Source = "24448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24448", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_24",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_24",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_24", ])]
	public float Y轴_AYis_Pos_24 { get; set; }

	[BinaryPoint(Offset = 24450, Source = "24450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24450", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_25",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_25",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_25", ])]
	public float Y轴_AYis_Pos_25 { get; set; }

	[BinaryPoint(Offset = 24452, Source = "24452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24452", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_26",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_26",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_26", ])]
	public float Y轴_AYis_Pos_26 { get; set; }

	[BinaryPoint(Offset = 24454, Source = "24454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24454", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_27",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_27",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_27", ])]
	public float Y轴_AYis_Pos_27 { get; set; }

	[BinaryPoint(Offset = 24456, Source = "24456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24456", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_28",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_28",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_28", ])]
	public float Y轴_AYis_Pos_28 { get; set; }

	[BinaryPoint(Offset = 24458, Source = "24458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24458", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_29",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_29",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_29", ])]
	public float Y轴_AYis_Pos_29 { get; set; }

	[BinaryPoint(Offset = 24460, Source = "24460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24460", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_30",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_30",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_30", ])]
	public float Y轴_AYis_Pos_30 { get; set; }

	[BinaryPoint(Offset = 24462, Source = "24462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24462", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_31",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_31",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_31", ])]
	public float Y轴_AYis_Pos_31 { get; set; }

	[BinaryPoint(Offset = 24464, Source = "24464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24464", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_32",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_32",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_32", ])]
	public float Y轴_AYis_Pos_32 { get; set; }

	[BinaryPoint(Offset = 24466, Source = "24466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24466", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_33",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_33",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_33", ])]
	public float Y轴_AYis_Pos_33 { get; set; }

	[BinaryPoint(Offset = 24468, Source = "24468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24468", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_34",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_34",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_34", ])]
	public float Y轴_AYis_Pos_34 { get; set; }

	[BinaryPoint(Offset = 24470, Source = "24470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24470", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_35",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_35",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_35", ])]
	public float Y轴_AYis_Pos_35 { get; set; }

	[BinaryPoint(Offset = 24472, Source = "24472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24472", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_36",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_36",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_36", ])]
	public float Y轴_AYis_Pos_36 { get; set; }

	[BinaryPoint(Offset = 24474, Source = "24474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24474", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_37",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_37",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_37", ])]
	public float Y轴_AYis_Pos_37 { get; set; }

	[BinaryPoint(Offset = 24476, Source = "24476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24476", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_38",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_38",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_38", ])]
	public float Y轴_AYis_Pos_38 { get; set; }

	[BinaryPoint(Offset = 24478, Source = "24478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24478", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_39",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_39",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_39", ])]
	public float Y轴_AYis_Pos_39 { get; set; }

	[BinaryPoint(Offset = 24480, Source = "24480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24480", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_40",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos-40",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_40", ])]
	public float Y轴_AYis_Pos_40 { get; set; }

	[BinaryPoint(Offset = 24482, Source = "24482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24482", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_41",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_41",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_41", ])]
	public float Y轴_AYis_Pos_41 { get; set; }

	[BinaryPoint(Offset = 24484, Source = "24484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24484", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_42",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_42",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_42", ])]
	public float Y轴_AYis_Pos_42 { get; set; }

	[BinaryPoint(Offset = 24486, Source = "24486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24486", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_43",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos-43",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_43", ])]
	public float Y轴_AYis_Pos_43 { get; set; }

	[BinaryPoint(Offset = 24488, Source = "24488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24488", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_44",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_44",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_44", ])]
	public float Y轴_AYis_Pos_44 { get; set; }

	[BinaryPoint(Offset = 24490, Source = "24490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24490", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_45",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_45",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_45", ])]
	public float Y轴_AYis_Pos_45 { get; set; }

	[BinaryPoint(Offset = 24492, Source = "24492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24492", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_46",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos-46",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_46", ])]
	public float Y轴_AYis_Pos_46 { get; set; }

	[BinaryPoint(Offset = 24494, Source = "24494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24494", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_47",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_47",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_47", ])]
	public float Y轴_AYis_Pos_47 { get; set; }

	[BinaryPoint(Offset = 24496, Source = "24496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24496", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_48",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos_48",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_48", ])]
	public float Y轴_AYis_Pos_48 { get; set; }

	[BinaryPoint(Offset = 24498, Source = "24498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24498", Category = "PLC/Y轴_AYis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Pos_49",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Pos-49",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Vị trí_49", ])]
	public float Y轴_AYis_Pos_49 { get; set; }

	[BinaryPoint(Offset = 24500, Source = "24500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24500", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_0", ])]
	public float Y轴_AYis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24501, Source = "24501", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24501", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_1", ])]
	public float Y轴_AYis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24502, Source = "24502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24502", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_2", ])]
	public float Y轴_AYis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24503, Source = "24503", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24503", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_3", ])]
	public float Y轴_AYis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24504, Source = "24504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24504", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_4", ])]
	public float Y轴_AYis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24505, Source = "24505", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24505", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_5", ])]
	public float Y轴_AYis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24506, Source = "24506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24506", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_6", ])]
	public float Y轴_AYis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24507, Source = "24507", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24507", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_7", ])]
	public float Y轴_AYis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24508, Source = "24508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24508", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_8", ])]
	public float Y轴_AYis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24509, Source = "24509", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24509", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_9", ])]
	public float Y轴_AYis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24510, Source = "24510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24510", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_10", ])]
	public float Y轴_AYis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24511, Source = "24511", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24511", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_11", ])]
	public float Y轴_AYis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24512, Source = "24512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24512", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_12", ])]
	public float Y轴_AYis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24513, Source = "24513", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24513", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_13", ])]
	public float Y轴_AYis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24514, Source = "24514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24514", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_14", ])]
	public float Y轴_AYis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24515, Source = "24515", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24515", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_15", ])]
	public float Y轴_AYis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24516, Source = "24516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24516", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_16", ])]
	public float Y轴_AYis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24517, Source = "24517", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24517", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_17", ])]
	public float Y轴_AYis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24518, Source = "24518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24518", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_18", ])]
	public float Y轴_AYis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24519, Source = "24519", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24519", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_19", ])]
	public float Y轴_AYis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24520, Source = "24520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24520", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_20", ])]
	public float Y轴_AYis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24521, Source = "24521", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24521", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_21",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_21",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_21", ])]
	public float Y轴_AYis_Vel_21 { get; set; }

	[BinaryPoint(Offset = 24522, Source = "24522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24522", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_22",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_22",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_22", ])]
	public float Y轴_AYis_Vel_22 { get; set; }

	[BinaryPoint(Offset = 24523, Source = "24523", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24523", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_23",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_23",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_23", ])]
	public float Y轴_AYis_Vel_23 { get; set; }

	[BinaryPoint(Offset = 24524, Source = "24524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24524", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_24",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_24",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_24", ])]
	public float Y轴_AYis_Vel_24 { get; set; }

	[BinaryPoint(Offset = 24525, Source = "24525", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24525", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_25",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_25",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_25", ])]
	public float Y轴_AYis_Vel_25 { get; set; }

	[BinaryPoint(Offset = 24526, Source = "24526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24526", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_26",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_26",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_26", ])]
	public float Y轴_AYis_Vel_26 { get; set; }

	[BinaryPoint(Offset = 24527, Source = "24527", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24527", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_27",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_27",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_27", ])]
	public float Y轴_AYis_Vel_27 { get; set; }

	[BinaryPoint(Offset = 24528, Source = "24528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24528", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_28",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_28",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_28", ])]
	public float Y轴_AYis_Vel_28 { get; set; }

	[BinaryPoint(Offset = 24529, Source = "24529", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24529", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_29",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_29",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_29", ])]
	public float Y轴_AYis_Vel_29 { get; set; }

	[BinaryPoint(Offset = 24530, Source = "24530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24530", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_30",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_30",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_30", ])]
	public float Y轴_AYis_Vel_30 { get; set; }

	[BinaryPoint(Offset = 24531, Source = "24531", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24531", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_31",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_31",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_31", ])]
	public float Y轴_AYis_Vel_31 { get; set; }

	[BinaryPoint(Offset = 24532, Source = "24532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24532", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_32",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_32",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_32", ])]
	public float Y轴_AYis_Vel_32 { get; set; }

	[BinaryPoint(Offset = 24533, Source = "24533", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24533", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_33",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_33",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_33", ])]
	public float Y轴_AYis_Vel_33 { get; set; }

	[BinaryPoint(Offset = 24534, Source = "24534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24534", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_34",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_34",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_34", ])]
	public float Y轴_AYis_Vel_34 { get; set; }

	[BinaryPoint(Offset = 24535, Source = "24535", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24535", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_35",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_35",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_35", ])]
	public float Y轴_AYis_Vel_35 { get; set; }

	[BinaryPoint(Offset = 24536, Source = "24536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24536", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_36",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_36",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_36", ])]
	public float Y轴_AYis_Vel_36 { get; set; }

	[BinaryPoint(Offset = 24537, Source = "24537", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24537", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_37",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_37",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_37", ])]
	public float Y轴_AYis_Vel_37 { get; set; }

	[BinaryPoint(Offset = 24538, Source = "24538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24538", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_38",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_38",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_38", ])]
	public float Y轴_AYis_Vel_38 { get; set; }

	[BinaryPoint(Offset = 24539, Source = "24539", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24539", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_39",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_39",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_39", ])]
	public float Y轴_AYis_Vel_39 { get; set; }

	[BinaryPoint(Offset = 24540, Source = "24540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24540", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_40",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_40",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_40", ])]
	public float Y轴_AYis_Vel_40 { get; set; }

	[BinaryPoint(Offset = 24541, Source = "24541", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24541", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_41",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_41",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_41", ])]
	public float Y轴_AYis_Vel_41 { get; set; }

	[BinaryPoint(Offset = 24542, Source = "24542", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24542", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_42",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_42",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_42", ])]
	public float Y轴_AYis_Vel_42 { get; set; }

	[BinaryPoint(Offset = 24543, Source = "24543", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24543", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_43",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_43",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_43", ])]
	public float Y轴_AYis_Vel_43 { get; set; }

	[BinaryPoint(Offset = 24544, Source = "24544", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24544", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_44",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_44",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_44", ])]
	public float Y轴_AYis_Vel_44 { get; set; }

	[BinaryPoint(Offset = 24545, Source = "24545", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24545", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_45",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_45",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_45", ])]
	public float Y轴_AYis_Vel_45 { get; set; }

	[BinaryPoint(Offset = 24546, Source = "24546", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24546", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_46",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_46",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_46", ])]
	public float Y轴_AYis_Vel_46 { get; set; }

	[BinaryPoint(Offset = 24547, Source = "24547", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24547", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_47",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_47",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_47", ])]
	public float Y轴_AYis_Vel_47 { get; set; }

	[BinaryPoint(Offset = 24548, Source = "24548", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24548", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_48",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_48",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_48", ])]
	public float Y轴_AYis_Vel_48 { get; set; }

	[BinaryPoint(Offset = 24549, Source = "24549", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24549", Category = "PLC/Y轴_AYis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "Y轴_AYis_Vel_49",
		DataDefine.KeyValue,"NameByEN", "Y aYis_AYis_Vel_49",
		DataDefine.KeyValue,"NameByVI", "Trục Y_Tốc độ_49", ])]
	public float Y轴_AYis_Vel_49 { get; set; }

	[BinaryPoint(Offset = 24600, Source = "24600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24600", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_0", ])]
	public float 步进电机_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24602, Source = "24602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24602", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_1", ])]
	public float 步进电机_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24604, Source = "24604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24604", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_2", ])]
	public float 步进电机_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24606, Source = "24606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24606", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_3", ])]
	public float 步进电机_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24608, Source = "24608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24608", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_4", ])]
	public float 步进电机_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24610, Source = "24610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24610", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_5", ])]
	public float 步进电机_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24612, Source = "24612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24612", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_6", ])]
	public float 步进电机_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24614, Source = "24614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24614", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_7", ])]
	public float 步进电机_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24616, Source = "24616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24616", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_8", ])]
	public float 步进电机_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24618, Source = "24618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24618", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_9", ])]
	public float 步进电机_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24620, Source = "24620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24620", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_10", ])]
	public float 步进电机_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24622, Source = "24622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24622", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_11", ])]
	public float 步进电机_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24624, Source = "24624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24624", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_12", ])]
	public float 步进电机_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24626, Source = "24626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24626", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_13", ])]
	public float 步进电机_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24628, Source = "24628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24628", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_14", ])]
	public float 步进电机_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24630, Source = "24630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24630", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_15", ])]
	public float 步进电机_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24632, Source = "24632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24632", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_16", ])]
	public float 步进电机_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24634, Source = "24634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24634", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_17", ])]
	public float 步进电机_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24636, Source = "24636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24636", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_18", ])]
	public float 步进电机_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24638, Source = "24638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24638", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_19", ])]
	public float 步进电机_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24640, Source = "24640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24640", Category = "PLC/步进电机_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_Địa điểm_20", ])]
	public float 步进电机_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24650, Source = "24650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24650", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_0", ])]
	public float 步进电机_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24652, Source = "24652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24652", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_1", ])]
	public float 步进电机_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24654, Source = "24654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24654", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_2", ])]
	public float 步进电机_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24656, Source = "24656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24656", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_3", ])]
	public float 步进电机_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24658, Source = "24658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24658", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_4", ])]
	public float 步进电机_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24660, Source = "24660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24660", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_5", ])]
	public float 步进电机_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24662, Source = "24662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24662", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_6",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_6", ])]
	public float 步进电机_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24664, Source = "24664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24664", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_7", ])]
	public float 步进电机_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24666, Source = "24666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24666", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_8", ])]
	public float 步进电机_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24668, Source = "24668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24668", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_9", ])]
	public float 步进电机_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24670, Source = "24670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24670", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_10", ])]
	public float 步进电机_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24672, Source = "24672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24672", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_11", ])]
	public float 步进电机_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24674, Source = "24674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24674", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_12", ])]
	public float 步进电机_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24676, Source = "24676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24676", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_13", ])]
	public float 步进电机_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24678, Source = "24678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24678", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_14", ])]
	public float 步进电机_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24680, Source = "24680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24680", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_15", ])]
	public float 步进电机_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24682, Source = "24682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24682", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_16", ])]
	public float 步进电机_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24684, Source = "24684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24684", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_17", ])]
	public float 步进电机_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24686, Source = "24686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24686", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_18", ])]
	public float 步进电机_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24688, Source = "24688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24688", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_19", ])]
	public float 步进电机_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24690, Source = "24690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24690", Category = "PLC/步进电机_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "步进电机_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "stepper motor_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Động cơ bước_trục_tốc độ_20", ])]
	public float 步进电机_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24700, Source = "24700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24700", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_0", ])]
	public float 取料1Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24702, Source = "24702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24702", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_1", ])]
	public float 取料1Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24704, Source = "24704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24704", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_2", ])]
	public float 取料1Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24706, Source = "24706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24706", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_3", ])]
	public float 取料1Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24708, Source = "24708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24708", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_4", ])]
	public float 取料1Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24710, Source = "24710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24710", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_5", ])]
	public float 取料1Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24712, Source = "24712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24712", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_6", ])]
	public float 取料1Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24714, Source = "24714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24714", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_7", ])]
	public float 取料1Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24716, Source = "24716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24716", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_8", ])]
	public float 取料1Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24718, Source = "24718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24718", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_9", ])]
	public float 取料1Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24720, Source = "24720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24720", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_10", ])]
	public float 取料1Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24722, Source = "24722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24722", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_11", ])]
	public float 取料1Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24724, Source = "24724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24724", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_12", ])]
	public float 取料1Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24726, Source = "24726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24726", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_13", ])]
	public float 取料1Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24728, Source = "24728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24728", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_14", ])]
	public float 取料1Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24730, Source = "24730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24730", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_15", ])]
	public float 取料1Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24732, Source = "24732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24732", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_16", ])]
	public float 取料1Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24734, Source = "24734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24734", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_17", ])]
	public float 取料1Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24736, Source = "24736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24736", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_18", ])]
	public float 取料1Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24738, Source = "24738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24738", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_19", ])]
	public float 取料1Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24740, Source = "24740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24740", Category = "PLC/取料1Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking: Z-axis _Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_Địa điểm_20", ])]
	public float 取料1Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24800, Source = "24800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24800", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_0", ])]
	public float 取料1Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24802, Source = "24802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24802", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_1", ])]
	public float 取料1Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24804, Source = "24804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24804", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_2", ])]
	public float 取料1Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24806, Source = "24806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24806", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_3", ])]
	public float 取料1Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24808, Source = "24808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24808", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_4", ])]
	public float 取料1Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24810, Source = "24810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24810", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_5", ])]
	public float 取料1Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24812, Source = "24812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24812", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_6", ])]
	public float 取料1Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24814, Source = "24814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24814", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_7", ])]
	public float 取料1Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24816, Source = "24816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24816", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_8", ])]
	public float 取料1Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24818, Source = "24818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24818", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_9", ])]
	public float 取料1Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24820, Source = "24820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24820", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_10", ])]
	public float 取料1Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24822, Source = "24822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24822", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_11", ])]
	public float 取料1Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24824, Source = "24824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24824", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_12", ])]
	public float 取料1Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24826, Source = "24826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24826", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_13", ])]
	public float 取料1Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24828, Source = "24828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24828", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_14", ])]
	public float 取料1Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24830, Source = "24830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24830", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_15", ])]
	public float 取料1Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24832, Source = "24832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24832", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_16", ])]
	public float 取料1Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24834, Source = "24834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24834", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_17", ])]
	public float 取料1Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24836, Source = "24836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24836", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_18", ])]
	public float 取料1Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24838, Source = "24838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24838", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_19", ])]
	public float 取料1Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24840, Source = "24840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24840", Category = "PLC/取料1Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 1Z-axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 1Z_trục_tốc độ_20", ])]
	public float 取料1Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24840, Source = "24840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24840", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis _Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_0", ])]
	public float 取料1R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24842, Source = "24842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24842", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_1", ])]
	public float 取料1R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24844, Source = "24844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24844", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_2", ])]
	public float 取料1R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24846, Source = "24846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24846", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_3", ])]
	public float 取料1R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24848, Source = "24848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24848", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_4", ])]
	public float 取料1R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24850, Source = "24850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24850", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_5", ])]
	public float 取料1R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24852, Source = "24852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24852", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_6", ])]
	public float 取料1R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24854, Source = "24854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24854", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_7", ])]
	public float 取料1R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24856, Source = "24856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24856", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_8", ])]
	public float 取料1R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24858, Source = "24858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24858", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_9", ])]
	public float 取料1R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24860, Source = "24860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24860", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_10", ])]
	public float 取料1R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24862, Source = "24862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24862", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_11", ])]
	public float 取料1R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24864, Source = "24864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24864", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_12", ])]
	public float 取料1R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24866, Source = "24866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24866", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_13", ])]
	public float 取料1R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24868, Source = "24868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24868", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_14", ])]
	public float 取料1R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24870, Source = "24870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24870", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_15", ])]
	public float 取料1R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24872, Source = "24872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24872", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_16", ])]
	public float 取料1R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24874, Source = "24874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24874", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_17", ])]
	public float 取料1R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24876, Source = "24876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24876", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_18", ])]
	public float 取料1R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24878, Source = "24878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24878", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 1R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_19", ])]
	public float 取料1R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24880, Source = "24880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24880", Category = "PLC/取料1R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_Địa điểm_20", ])]
	public float 取料1R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 24900, Source = "24900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24900", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_0", ])]
	public float 取料1R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 24902, Source = "24902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24902", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_1", ])]
	public float 取料1R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 24904, Source = "24904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24904", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_2", ])]
	public float 取料1R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 24906, Source = "24906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24906", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_3", ])]
	public float 取料1R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 24908, Source = "24908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24908", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_4", ])]
	public float 取料1R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 24910, Source = "24910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24910", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_5", ])]
	public float 取料1R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 24912, Source = "24912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24912", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_6", ])]
	public float 取料1R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 24914, Source = "24914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24914", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_7", ])]
	public float 取料1R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 24916, Source = "24916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24916", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_8", ])]
	public float 取料1R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 24918, Source = "24918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24918", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_9", ])]
	public float 取料1R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 24920, Source = "24920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24920", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_10", ])]
	public float 取料1R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 24922, Source = "24922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24922", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_11", ])]
	public float 取料1R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 24924, Source = "24924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24924", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_12", ])]
	public float 取料1R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 24926, Source = "24926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24926", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_13", ])]
	public float 取料1R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 24928, Source = "24928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24928", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_14", ])]
	public float 取料1R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 24930, Source = "24930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24930", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_15", ])]
	public float 取料1R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 24932, Source = "24932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24932", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_16", ])]
	public float 取料1R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 24934, Source = "24934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24934", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_17", ])]
	public float 取料1R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 24936, Source = "24936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24936", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_18", ])]
	public float 取料1R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 24938, Source = "24938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24938", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_19", ])]
	public float 取料1R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 24940, Source = "24940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24940", Category = "PLC/取料1R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料1R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 1R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 1R_trục_tốc độ_20", ])]
	public float 取料1R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 24950, Source = "24950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24950", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_0", ])]
	public float 取料2Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 24952, Source = "24952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24952", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_1", ])]
	public float 取料2Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 24954, Source = "24954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24954", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_2", ])]
	public float 取料2Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 24956, Source = "24956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24956", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_3", ])]
	public float 取料2Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 24958, Source = "24958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24958", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_4", ])]
	public float 取料2Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 24960, Source = "24960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24960", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_5", ])]
	public float 取料2Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 24962, Source = "24962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24962", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_6", ])]
	public float 取料2Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 24964, Source = "24964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24964", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_7", ])]
	public float 取料2Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 24966, Source = "24966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24966", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_8", ])]
	public float 取料2Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 24968, Source = "24968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24968", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_9", ])]
	public float 取料2Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 24970, Source = "24970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24970", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_10", ])]
	public float 取料2Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 24972, Source = "24972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24972", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_11", ])]
	public float 取料2Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 24974, Source = "24974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24974", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_12", ])]
	public float 取料2Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 24976, Source = "24976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24976", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_13", ])]
	public float 取料2Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 24978, Source = "24978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24978", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_14", ])]
	public float 取料2Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 24980, Source = "24980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24980", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_15", ])]
	public float 取料2Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 24982, Source = "24982", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24982", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_16", ])]
	public float 取料2Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 24984, Source = "24984", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24984", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_17", ])]
	public float 取料2Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 24986, Source = "24986", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24986", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_18", ])]
	public float 取料2Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 24988, Source = "24988", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24988", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_19", ])]
	public float 取料2Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 24990, Source = "24990", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:24990", Category = "PLC/取料2Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2Z axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_Địa điểm_20", ])]
	public float 取料2Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25000, Source = "25000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25000", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_0", ])]
	public float 取料2Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25002, Source = "25002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25002", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_1", ])]
	public float 取料2Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25004, Source = "25004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25004", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_2", ])]
	public float 取料2Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25006, Source = "25006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25006", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_3", ])]
	public float 取料2Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25008, Source = "25008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25008", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_4", ])]
	public float 取料2Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25010, Source = "25010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25010", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_5", ])]
	public float 取料2Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25012, Source = "25012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25012", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_6", ])]
	public float 取料2Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25014, Source = "25014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25014", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_7", ])]
	public float 取料2Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25016, Source = "25016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25016", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_8", ])]
	public float 取料2Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25018, Source = "25018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25018", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_9", ])]
	public float 取料2Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25020, Source = "25020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25020", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_10", ])]
	public float 取料2Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25022, Source = "25022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25022", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_11", ])]
	public float 取料2Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25024, Source = "25024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25024", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_12", ])]
	public float 取料2Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25026, Source = "25026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25026", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_13", ])]
	public float 取料2Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25028, Source = "25028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25028", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_14", ])]
	public float 取料2Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25030, Source = "25030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25030", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_15", ])]
	public float 取料2Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25032, Source = "25032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25032", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_16", ])]
	public float 取料2Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25034, Source = "25034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25034", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_17", ])]
	public float 取料2Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25036, Source = "25036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25036", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_18", ])]
	public float 取料2Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25038, Source = "25038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25038", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_19", ])]
	public float 取料2Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25040, Source = "25040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25040", Category = "PLC/取料2Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 2Z axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 2Z_trục_tốc độ_20", ])]
	public float 取料2Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25050, Source = "25050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25050", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis __Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_0", ])]
	public float 取料2R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25052, Source = "25052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25052", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_1", ])]
	public float 取料2R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25054, Source = "25054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25054", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_2", ])]
	public float 取料2R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25056, Source = "25056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25056", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_3", ])]
	public float 取料2R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25058, Source = "25058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25058", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_4", ])]
	public float 取料2R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25060, Source = "25060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25060", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_5", ])]
	public float 取料2R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25062, Source = "25062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25062", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_6", ])]
	public float 取料2R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25064, Source = "25064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25064", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_7", ])]
	public float 取料2R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25066, Source = "25066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25066", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_8", ])]
	public float 取料2R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25068, Source = "25068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25068", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_9", ])]
	public float 取料2R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25070, Source = "25070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25070", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_10", ])]
	public float 取料2R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25072, Source = "25072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25072", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_11", ])]
	public float 取料2R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25074, Source = "25074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25074", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_12", ])]
	public float 取料2R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25076, Source = "25076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25076", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_13", ])]
	public float 取料2R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25078, Source = "25078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25078", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_14", ])]
	public float 取料2R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25080, Source = "25080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25080", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_15", ])]
	public float 取料2R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25082, Source = "25082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25082", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_16", ])]
	public float 取料2R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25084, Source = "25084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25084", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_17", ])]
	public float 取料2R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25086, Source = "25086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25086", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_18", ])]
	public float 取料2R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25088, Source = "25088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25088", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 2R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_19", ])]
	public float 取料2R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25090, Source = "25090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25090", Category = "PLC/取料2R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_Địa điểm_20", ])]
	public float 取料2R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25100, Source = "25100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25100", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_0", ])]
	public float 取料2R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25102, Source = "25102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25102", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_1", ])]
	public float 取料2R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25104, Source = "25104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25104", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_2", ])]
	public float 取料2R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25106, Source = "25106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25106", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_3", ])]
	public float 取料2R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25108, Source = "25108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25108", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_4", ])]
	public float 取料2R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25110, Source = "25110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25110", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_5", ])]
	public float 取料2R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25112, Source = "25112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25112", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_6", ])]
	public float 取料2R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25114, Source = "25114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25114", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_7", ])]
	public float 取料2R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25116, Source = "25116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25116", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_8", ])]
	public float 取料2R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25118, Source = "25118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25118", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_9", ])]
	public float 取料2R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25120, Source = "25120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25120", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_10", ])]
	public float 取料2R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25122, Source = "25122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25122", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_11", ])]
	public float 取料2R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25124, Source = "25124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25124", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_12", ])]
	public float 取料2R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25126, Source = "25126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25126", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_13", ])]
	public float 取料2R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25128, Source = "25128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25128", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_14", ])]
	public float 取料2R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25130, Source = "25130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25130", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_15", ])]
	public float 取料2R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25132, Source = "25132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25132", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_16", ])]
	public float 取料2R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25134, Source = "25134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25134", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_17", ])]
	public float 取料2R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25136, Source = "25136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25136", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_18", ])]
	public float 取料2R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25138, Source = "25138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25138", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_19", ])]
	public float 取料2R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25140, Source = "25140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25140", Category = "PLC/取料2R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料2R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 2R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 2R_trục_tốc độ_20", ])]
	public float 取料2R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25150, Source = "25150", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25150", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_0", ])]
	public float 取料3Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25152, Source = "25152", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25152", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_1", ])]
	public float 取料3Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25154, Source = "25154", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25154", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_2", ])]
	public float 取料3Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25156, Source = "25156", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25156", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_3", ])]
	public float 取料3Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25158, Source = "25158", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25158", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_4", ])]
	public float 取料3Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25160, Source = "25160", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25160", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_5", ])]
	public float 取料3Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25162, Source = "25162", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25162", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_6", ])]
	public float 取料3Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25164, Source = "25164", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25164", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_7", ])]
	public float 取料3Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25166, Source = "25166", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25166", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_8", ])]
	public float 取料3Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25168, Source = "25168", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25168", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_9", ])]
	public float 取料3Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25170, Source = "25170", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25170", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_10", ])]
	public float 取料3Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25172, Source = "25172", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25172", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_11", ])]
	public float 取料3Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25174, Source = "25174", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25174", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_12", ])]
	public float 取料3Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25176, Source = "25176", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25176", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_13", ])]
	public float 取料3Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25178, Source = "25178", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25178", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_14", ])]
	public float 取料3Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25180, Source = "25180", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25180", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_15", ])]
	public float 取料3Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25182, Source = "25182", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25182", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_16", ])]
	public float 取料3Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25184, Source = "25184", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25184", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_17", ])]
	public float 取料3Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25186, Source = "25186", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25186", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_18", ])]
	public float 取料3Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25188, Source = "25188", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25188", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_19", ])]
	public float 取料3Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25190, Source = "25190", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25190", Category = "PLC/取料3Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_Địa điểm_20", ])]
	public float 取料3Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25200, Source = "25200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25200", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_0", ])]
	public float 取料3Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25202, Source = "25202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25202", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_1", ])]
	public float 取料3Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25204, Source = "25204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25204", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_2", ])]
	public float 取料3Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25206, Source = "25206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25206", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_3", ])]
	public float 取料3Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25208, Source = "25208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25208", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_4", ])]
	public float 取料3Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25210, Source = "25210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25210", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_5", ])]
	public float 取料3Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25212, Source = "25212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25212", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_6", ])]
	public float 取料3Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25214, Source = "25214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25214", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_7", ])]
	public float 取料3Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25216, Source = "25216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25216", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_8", ])]
	public float 取料3Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25218, Source = "25218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25218", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_9", ])]
	public float 取料3Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25220, Source = "25220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25220", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_10", ])]
	public float 取料3Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25222, Source = "25222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25222", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_11", ])]
	public float 取料3Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25224, Source = "25224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25224", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_12", ])]
	public float 取料3Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25226, Source = "25226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25226", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_13", ])]
	public float 取料3Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25228, Source = "25228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25228", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_14", ])]
	public float 取料3Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25230, Source = "25230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25230", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_15", ])]
	public float 取料3Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25232, Source = "25232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25232", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_16", ])]
	public float 取料3Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25234, Source = "25234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25234", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_17", ])]
	public float 取料3Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25236, Source = "25236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25236", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_18", ])]
	public float 取料3Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25238, Source = "25238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25238", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_19", ])]
	public float 取料3Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25240, Source = "25240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25240", Category = "PLC/取料3Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 3Z-axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 3Z_trục_tốc độ_20", ])]
	public float 取料3Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25250, Source = "25250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25250", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis __Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_0", ])]
	public float 取料3R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25252, Source = "25252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25252", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_1", ])]
	public float 取料3R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25254, Source = "25254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25254", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_2", ])]
	public float 取料3R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25256, Source = "25256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25256", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_3", ])]
	public float 取料3R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25258, Source = "25258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25258", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_4", ])]
	public float 取料3R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25260, Source = "25260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25260", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_5", ])]
	public float 取料3R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25262, Source = "25262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25262", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_6", ])]
	public float 取料3R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25264, Source = "25264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25264", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_7", ])]
	public float 取料3R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25266, Source = "25266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25266", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_8", ])]
	public float 取料3R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25268, Source = "25268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25268", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_9", ])]
	public float 取料3R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25270, Source = "25270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25270", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_10", ])]
	public float 取料3R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25272, Source = "25272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25272", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_11", ])]
	public float 取料3R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25274, Source = "25274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25274", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_12", ])]
	public float 取料3R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25276, Source = "25276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25276", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_13", ])]
	public float 取料3R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25278, Source = "25278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25278", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_14", ])]
	public float 取料3R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25280, Source = "25280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25280", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_15", ])]
	public float 取料3R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25282, Source = "25282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25282", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_16", ])]
	public float 取料3R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25284, Source = "25284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25284", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_17", ])]
	public float 取料3R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25286, Source = "25286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25286", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis __Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_18", ])]
	public float 取料3R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25288, Source = "25288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25288", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 3R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_19", ])]
	public float 取料3R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25290, Source = "25290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25290", Category = "PLC/取料3R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_trục_Địa điểm_20", ])]
	public float 取料3R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25300, Source = "25300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25300", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_0", ])]
	public float 取料3R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25302, Source = "25302", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25302", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_1", ])]
	public float 取料3R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25304, Source = "25304", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25304", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_2", ])]
	public float 取料3R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25306, Source = "25306", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25306", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_3", ])]
	public float 取料3R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25308, Source = "25308", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25308", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_4", ])]
	public float 取料3R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25310, Source = "25310", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25310", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_5", ])]
	public float 取料3R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25312, Source = "25312", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25312", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_6", ])]
	public float 取料3R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25314, Source = "25314", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25314", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_7", ])]
	public float 取料3R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25316, Source = "25316", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25316", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_8", ])]
	public float 取料3R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25318, Source = "25318", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25318", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_9", ])]
	public float 取料3R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25320, Source = "25320", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25320", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_10", ])]
	public float 取料3R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25322, Source = "25322", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25322", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_11", ])]
	public float 取料3R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25324, Source = "25324", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25324", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_12", ])]
	public float 取料3R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25326, Source = "25326", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25326", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_13", ])]
	public float 取料3R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25328, Source = "25328", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25328", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_14", ])]
	public float 取料3R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25330, Source = "25330", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25330", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_15", ])]
	public float 取料3R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25332, Source = "25332", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25332", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_16", ])]
	public float 取料3R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25334, Source = "25334", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25334", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_17", ])]
	public float 取料3R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25336, Source = "25336", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25336", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_18", ])]
	public float 取料3R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25338, Source = "25338", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25338", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_19", ])]
	public float 取料3R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25340, Source = "25340", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25340", Category = "PLC/取料3R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料3R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 3R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 3R_Axis_Vel_20", ])]
	public float 取料3R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25350, Source = "25350", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25350", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_0", ])]
	public float 取料4Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25352, Source = "25352", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25352", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_1", ])]
	public float 取料4Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25354, Source = "25354", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25354", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_2", ])]
	public float 取料4Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25356, Source = "25356", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25356", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_3", ])]
	public float 取料4Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25358, Source = "25358", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25358", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_4", ])]
	public float 取料4Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25360, Source = "25360", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25360", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_5", ])]
	public float 取料4Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25362, Source = "25362", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25362", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_6", ])]
	public float 取料4Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25364, Source = "25364", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25364", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_7", ])]
	public float 取料4Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25366, Source = "25366", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25366", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_8", ])]
	public float 取料4Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25368, Source = "25368", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25368", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_9", ])]
	public float 取料4Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25370, Source = "25370", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25370", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_10", ])]
	public float 取料4Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25372, Source = "25372", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25372", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_11", ])]
	public float 取料4Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25374, Source = "25374", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25374", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_12", ])]
	public float 取料4Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25376, Source = "25376", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25376", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_13", ])]
	public float 取料4Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25378, Source = "25378", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25378", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_14", ])]
	public float 取料4Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25380, Source = "25380", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25380", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_15", ])]
	public float 取料4Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25382, Source = "25382", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25382", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_16", ])]
	public float 取料4Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25384, Source = "25384", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25384", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_17", ])]
	public float 取料4Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25386, Source = "25386", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25386", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_18", ])]
	public float 取料4Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25388, Source = "25388", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25388", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_19", ])]
	public float 取料4Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25390, Source = "25390", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25390", Category = "PLC/取料4Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_Địa điểm_20", ])]
	public float 取料4Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25400, Source = "25400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25400", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_0", ])]
	public float 取料4Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25402, Source = "25402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25402", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_1", ])]
	public float 取料4Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25404, Source = "25404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25404", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_2", ])]
	public float 取料4Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25406, Source = "25406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25406", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_3", ])]
	public float 取料4Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25408, Source = "25408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25408", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_4", ])]
	public float 取料4Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25410, Source = "25410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25410", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_5", ])]
	public float 取料4Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25412, Source = "25412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25412", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_6", ])]
	public float 取料4Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25414, Source = "25414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25414", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_7", ])]
	public float 取料4Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25416, Source = "25416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25416", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_8", ])]
	public float 取料4Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25418, Source = "25418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25418", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_9", ])]
	public float 取料4Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25420, Source = "25420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25420", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_10", ])]
	public float 取料4Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25422, Source = "25422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25422", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_11", ])]
	public float 取料4Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25424, Source = "25424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25424", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_12", ])]
	public float 取料4Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25426, Source = "25426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25426", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_13", ])]
	public float 取料4Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25428, Source = "25428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25428", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_14", ])]
	public float 取料4Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25430, Source = "25430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25430", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_15", ])]
	public float 取料4Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25432, Source = "25432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25432", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_16", ])]
	public float 取料4Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25434, Source = "25434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25434", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_17", ])]
	public float 取料4Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25436, Source = "25436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25436", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_18", ])]
	public float 取料4Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25438, Source = "25438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25438", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_19", ])]
	public float 取料4Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25440, Source = "25440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25440", Category = "PLC/取料4Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 4Z-axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 4Z_trục_tốc độ_20", ])]
	public float 取料4Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25450, Source = "25450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25450", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_0", ])]
	public float 取料4R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25452, Source = "25452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25452", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_1", ])]
	public float 取料4R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25454, Source = "25454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25454", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_2", ])]
	public float 取料4R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25456, Source = "25456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25456", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_3", ])]
	public float 取料4R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25458, Source = "25458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25458", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_4", ])]
	public float 取料4R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25460, Source = "25460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25460", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_5", ])]
	public float 取料4R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25462, Source = "25462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25462", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_6",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_6", ])]
	public float 取料4R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25464, Source = "25464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25464", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_7", ])]
	public float 取料4R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25466, Source = "25466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25466", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_8", ])]
	public float 取料4R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25468, Source = "25468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25468", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_9", ])]
	public float 取料4R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25470, Source = "25470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25470", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_10", ])]
	public float 取料4R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25472, Source = "25472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25472", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_11", ])]
	public float 取料4R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25474, Source = "25474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25474", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_12", ])]
	public float 取料4R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25476, Source = "25476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25476", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_13", ])]
	public float 取料4R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25478, Source = "25478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25478", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_14", ])]
	public float 取料4R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25480, Source = "25480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25480", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_15", ])]
	public float 取料4R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25482, Source = "25482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25482", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_16", ])]
	public float 取料4R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25484, Source = "25484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25484", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_17", ])]
	public float 取料4R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25486, Source = "25486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25486", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_18", ])]
	public float 取料4R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25488, Source = "25488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25488", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_19", ])]
	public float 取料4R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25490, Source = "25490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25490", Category = "PLC/取料4R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis _Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_Địa điểm_20", ])]
	public float 取料4R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25500, Source = "25500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25500", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_0", ])]
	public float 取料4R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25502, Source = "25502", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25502", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_1", ])]
	public float 取料4R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25504, Source = "25504", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25504", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_2", ])]
	public float 取料4R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25506, Source = "25506", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25506", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_3", ])]
	public float 取料4R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25508, Source = "25508", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25508", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_4", ])]
	public float 取料4R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25510, Source = "25510", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25510", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_5", ])]
	public float 取料4R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25512, Source = "25512", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25512", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_6", ])]
	public float 取料4R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25514, Source = "25514", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25514", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_7", ])]
	public float 取料4R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25516, Source = "25516", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25516", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_8", ])]
	public float 取料4R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25518, Source = "25518", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25518", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_9", ])]
	public float 取料4R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25520, Source = "25520", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25520", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_10", ])]
	public float 取料4R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25522, Source = "25522", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25522", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_11", ])]
	public float 取料4R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25524, Source = "25524", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25524", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_12", ])]
	public float 取料4R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25526, Source = "25526", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25526", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_13", ])]
	public float 取料4R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25528, Source = "25528", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25528", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_14", ])]
	public float 取料4R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25530, Source = "25530", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25530", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_15", ])]
	public float 取料4R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25532, Source = "25532", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25532", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_16", ])]
	public float 取料4R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25534, Source = "25534", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25534", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_17", ])]
	public float 取料4R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25536, Source = "25536", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25536", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_18", ])]
	public float 取料4R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25538, Source = "25538", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25538", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_19", ])]
	public float 取料4R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25540, Source = "25540", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25540", Category = "PLC/取料4R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料4R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 4R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 4R_trục_tốc độ_20", ])]
	public float 取料4R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25550, Source = "25550", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25550", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_0", ])]
	public float 取料5Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25552, Source = "25552", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25552", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_1", ])]
	public float 取料5Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25554, Source = "25554", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25554", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_2", ])]
	public float 取料5Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25556, Source = "25556", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25556", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_3", ])]
	public float 取料5Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25558, Source = "25558", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25558", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_4", ])]
	public float 取料5Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25560, Source = "25560", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25560", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_5", ])]
	public float 取料5Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25562, Source = "25562", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25562", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_6", ])]
	public float 取料5Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25564, Source = "25564", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25564", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_7", ])]
	public float 取料5Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25566, Source = "25566", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25566", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_8", ])]
	public float 取料5Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25568, Source = "25568", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25568", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_9", ])]
	public float 取料5Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25570, Source = "25570", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25570", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_10", ])]
	public float 取料5Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25572, Source = "25572", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25572", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_11", ])]
	public float 取料5Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25574, Source = "25574", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25574", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_12", ])]
	public float 取料5Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25576, Source = "25576", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25576", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_13", ])]
	public float 取料5Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25578, Source = "25578", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25578", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_14", ])]
	public float 取料5Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25580, Source = "25580", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25580", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_15", ])]
	public float 取料5Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25582, Source = "25582", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25582", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_16", ])]
	public float 取料5Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25584, Source = "25584", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25584", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_17", ])]
	public float 取料5Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25586, Source = "25586", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25586", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_18", ])]
	public float 取料5Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25588, Source = "25588", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25588", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_19", ])]
	public float 取料5Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25590, Source = "25590", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25590", Category = "PLC/取料5Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking: Z-axis _Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_Địa điểm_20", ])]
	public float 取料5Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25600, Source = "25600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25600", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_0", ])]
	public float 取料5Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25602, Source = "25602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25602", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_1", ])]
	public float 取料5Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25604, Source = "25604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25604", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_2", ])]
	public float 取料5Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25606, Source = "25606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25606", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_3", ])]
	public float 取料5Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25608, Source = "25608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25608", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_4", ])]
	public float 取料5Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25610, Source = "25610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25610", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_5", ])]
	public float 取料5Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25612, Source = "25612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25612", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_6", ])]
	public float 取料5Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25614, Source = "25614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25614", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_7", ])]
	public float 取料5Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25616, Source = "25616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25616", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_8", ])]
	public float 取料5Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25618, Source = "25618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25618", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_9", ])]
	public float 取料5Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25620, Source = "25620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25620", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_10", ])]
	public float 取料5Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25622, Source = "25622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25622", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_11", ])]
	public float 取料5Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25624, Source = "25624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25624", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_12", ])]
	public float 取料5Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25626, Source = "25626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25626", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_13", ])]
	public float 取料5Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25628, Source = "25628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25628", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_14", ])]
	public float 取料5Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25630, Source = "25630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25630", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_15", ])]
	public float 取料5Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25632, Source = "25632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25632", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_16", ])]
	public float 取料5Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25634, Source = "25634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25634", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_17", ])]
	public float 取料5Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25636, Source = "25636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25636", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_18", ])]
	public float 取料5Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25638, Source = "25638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25638", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_19", ])]
	public float 取料5Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25640, Source = "25640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25640", Category = "PLC/取料5Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 5Z-axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 5Z_trục_tốc độ_20", ])]
	public float 取料5Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25650, Source = "25650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25650", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis _Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_0", ])]
	public float 取料5R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25652, Source = "25652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25652", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_1", ])]
	public float 取料5R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25654, Source = "25654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25654", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_2", ])]
	public float 取料5R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25656, Source = "25656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25656", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_3", ])]
	public float 取料5R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25658, Source = "25658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25658", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_4", ])]
	public float 取料5R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25660, Source = "25660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25660", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_5", ])]
	public float 取料5R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25662, Source = "25662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25662", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_6", ])]
	public float 取料5R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25664, Source = "25664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25664", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_7", ])]
	public float 取料5R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25666, Source = "25666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25666", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_8", ])]
	public float 取料5R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25668, Source = "25668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25668", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_9", ])]
	public float 取料5R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25670, Source = "25670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25670", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_10", ])]
	public float 取料5R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25672, Source = "25672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25672", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_11", ])]
	public float 取料5R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25674, Source = "25674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25674", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_12", ])]
	public float 取料5R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25676, Source = "25676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25676", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_13", ])]
	public float 取料5R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25678, Source = "25678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25678", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_14", ])]
	public float 取料5R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25680, Source = "25680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25680", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_15", ])]
	public float 取料5R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25682, Source = "25682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25682", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_16", ])]
	public float 取料5R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25684, Source = "25684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25684", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_17", ])]
	public float 取料5R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25686, Source = "25686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25686", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_18", ])]
	public float 取料5R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25688, Source = "25688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25688", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 5R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_19", ])]
	public float 取料5R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25690, Source = "25690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25690", Category = "PLC/取料5R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_Địa điểm_20", ])]
	public float 取料5R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25700, Source = "25700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25700", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_0", ])]
	public float 取料5R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25702, Source = "25702", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25702", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_1", ])]
	public float 取料5R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25704, Source = "25704", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25704", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_2", ])]
	public float 取料5R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25706, Source = "25706", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25706", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_3", ])]
	public float 取料5R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25708, Source = "25708", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25708", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_4", ])]
	public float 取料5R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25710, Source = "25710", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25710", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_5", ])]
	public float 取料5R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25712, Source = "25712", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25712", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_6", ])]
	public float 取料5R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25714, Source = "25714", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25714", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_7", ])]
	public float 取料5R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25716, Source = "25716", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25716", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_8", ])]
	public float 取料5R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25718, Source = "25718", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25718", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_9", ])]
	public float 取料5R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25720, Source = "25720", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25720", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_10", ])]
	public float 取料5R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25722, Source = "25722", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25722", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_11", ])]
	public float 取料5R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25724, Source = "25724", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25724", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_12", ])]
	public float 取料5R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25726, Source = "25726", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25726", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_13", ])]
	public float 取料5R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25728, Source = "25728", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25728", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_14", ])]
	public float 取料5R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25730, Source = "25730", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25730", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_15", ])]
	public float 取料5R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25732, Source = "25732", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25732", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_16", ])]
	public float 取料5R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25734, Source = "25734", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25734", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_17", ])]
	public float 取料5R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25736, Source = "25736", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25736", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_18", ])]
	public float 取料5R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25738, Source = "25738", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25738", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_19", ])]
	public float 取料5R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25740, Source = "25740", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25740", Category = "PLC/取料5R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料5R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 5R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 5R_trục_tốc độ_20", ])]
	public float 取料5R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25750, Source = "25750", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25750", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_0", ])]
	public float 取料6Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25752, Source = "25752", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25752", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_1", ])]
	public float 取料6Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25754, Source = "25754", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25754", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_2", ])]
	public float 取料6Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25756, Source = "25756", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25756", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_3", ])]
	public float 取料6Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25758, Source = "25758", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25758", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_4", ])]
	public float 取料6Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25760, Source = "25760", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25760", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_5", ])]
	public float 取料6Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25762, Source = "25762", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25762", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_6", ])]
	public float 取料6Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25764, Source = "25764", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25764", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_7", ])]
	public float 取料6Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25766, Source = "25766", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25766", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_8", ])]
	public float 取料6Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25768, Source = "25768", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25768", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_9", ])]
	public float 取料6Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25770, Source = "25770", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25770", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_10", ])]
	public float 取料6Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25772, Source = "25772", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25772", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_11", ])]
	public float 取料6Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25774, Source = "25774", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25774", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_12", ])]
	public float 取料6Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25776, Source = "25776", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25776", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_13", ])]
	public float 取料6Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25778, Source = "25778", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25778", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_14", ])]
	public float 取料6Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25780, Source = "25780", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25780", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_15", ])]
	public float 取料6Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25782, Source = "25782", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25782", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_16", ])]
	public float 取料6Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25784, Source = "25784", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25784", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_17", ])]
	public float 取料6Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25786, Source = "25786", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25786", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_18", ])]
	public float 取料6Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25788, Source = "25788", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25788", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_19", ])]
	public float 取料6Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25790, Source = "25790", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25790", Category = "PLC/取料6Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6Z axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_Địa điểm_20", ])]
	public float 取料6Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25800, Source = "25800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25800", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_0", ])]
	public float 取料6Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25802, Source = "25802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25802", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_1", ])]
	public float 取料6Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25804, Source = "25804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25804", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_2", ])]
	public float 取料6Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25806, Source = "25806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25806", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_3", ])]
	public float 取料6Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25808, Source = "25808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25808", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_4", ])]
	public float 取料6Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25810, Source = "25810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25810", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_5", ])]
	public float 取料6Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25812, Source = "25812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25812", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_6", ])]
	public float 取料6Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25814, Source = "25814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25814", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_7", ])]
	public float 取料6Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25816, Source = "25816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25816", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_8", ])]
	public float 取料6Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25818, Source = "25818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25818", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_9", ])]
	public float 取料6Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25820, Source = "25820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25820", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_10", ])]
	public float 取料6Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25822, Source = "25822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25822", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_11", ])]
	public float 取料6Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25824, Source = "25824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25824", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_12", ])]
	public float 取料6Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25826, Source = "25826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25826", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_13", ])]
	public float 取料6Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25828, Source = "25828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25828", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_14", ])]
	public float 取料6Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25830, Source = "25830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25830", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_15", ])]
	public float 取料6Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25832, Source = "25832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25832", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_16", ])]
	public float 取料6Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25834, Source = "25834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25834", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_17", ])]
	public float 取料6Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25836, Source = "25836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25836", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_18", ])]
	public float 取料6Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25838, Source = "25838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25838", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_19", ])]
	public float 取料6Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25840, Source = "25840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25840", Category = "PLC/取料6Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 6Z axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 6Z_trục_tốc độ_20", ])]
	public float 取料6Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25850, Source = "25850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25850", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis __Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_0", ])]
	public float 取料6R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25852, Source = "25852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25852", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_1", ])]
	public float 取料6R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25854, Source = "25854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25854", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_2", ])]
	public float 取料6R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25856, Source = "25856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25856", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_3", ])]
	public float 取料6R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25858, Source = "25858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25858", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_4", ])]
	public float 取料6R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25860, Source = "25860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25860", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_5", ])]
	public float 取料6R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25862, Source = "25862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25862", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_6", ])]
	public float 取料6R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25864, Source = "25864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25864", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_7", ])]
	public float 取料6R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25866, Source = "25866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25866", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_8", ])]
	public float 取料6R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25868, Source = "25868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25868", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_9", ])]
	public float 取料6R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25870, Source = "25870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25870", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_10", ])]
	public float 取料6R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25872, Source = "25872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25872", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_11", ])]
	public float 取料6R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25874, Source = "25874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25874", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_12", ])]
	public float 取料6R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25876, Source = "25876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25876", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_13", ])]
	public float 取料6R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25878, Source = "25878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25878", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_14", ])]
	public float 取料6R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25880, Source = "25880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25880", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_15", ])]
	public float 取料6R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25882, Source = "25882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25882", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_16", ])]
	public float 取料6R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25884, Source = "25884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25884", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_17", ])]
	public float 取料6R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25886, Source = "25886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25886", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_18", ])]
	public float 取料6R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25888, Source = "25888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25888", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 6R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_19", ])]
	public float 取料6R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25890, Source = "25890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25890", Category = "PLC/取料6R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_Địa điểm_20", ])]
	public float 取料6R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 25900, Source = "25900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25900", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_0", ])]
	public float 取料6R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 25902, Source = "25902", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25902", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_1", ])]
	public float 取料6R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 25904, Source = "25904", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25904", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_2", ])]
	public float 取料6R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 25906, Source = "25906", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25906", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_3", ])]
	public float 取料6R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 25908, Source = "25908", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25908", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_4", ])]
	public float 取料6R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 25910, Source = "25910", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25910", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_5", ])]
	public float 取料6R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 25912, Source = "25912", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25912", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_6", ])]
	public float 取料6R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 25914, Source = "25914", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25914", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_7", ])]
	public float 取料6R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 25916, Source = "25916", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25916", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_8", ])]
	public float 取料6R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 25918, Source = "25918", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25918", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_9", ])]
	public float 取料6R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 25920, Source = "25920", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25920", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_10", ])]
	public float 取料6R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 25922, Source = "25922", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25922", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_11", ])]
	public float 取料6R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 25924, Source = "25924", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25924", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_12", ])]
	public float 取料6R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 25926, Source = "25926", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25926", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_13", ])]
	public float 取料6R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 25928, Source = "25928", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25928", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_14", ])]
	public float 取料6R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 25930, Source = "25930", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25930", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_15", ])]
	public float 取料6R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 25932, Source = "25932", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25932", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_16", ])]
	public float 取料6R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 25934, Source = "25934", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25934", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_17", ])]
	public float 取料6R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 25936, Source = "25936", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25936", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_18", ])]
	public float 取料6R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 25938, Source = "25938", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25938", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_19", ])]
	public float 取料6R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 25940, Source = "25940", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25940", Category = "PLC/取料6R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料6R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 6R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 6R_trục_tốc độ_20", ])]
	public float 取料6R轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 25950, Source = "25950", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25950", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_0", ])]
	public float 取料7Z轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 25952, Source = "25952", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25952", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_1", ])]
	public float 取料7Z轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 25954, Source = "25954", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25954", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_2", ])]
	public float 取料7Z轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 25956, Source = "25956", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25956", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_3", ])]
	public float 取料7Z轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 25958, Source = "25958", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25958", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_4", ])]
	public float 取料7Z轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 25960, Source = "25960", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25960", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_5", ])]
	public float 取料7Z轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 25962, Source = "25962", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25962", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_6", ])]
	public float 取料7Z轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 25964, Source = "25964", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25964", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_7", ])]
	public float 取料7Z轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 25966, Source = "25966", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25966", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_8", ])]
	public float 取料7Z轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 25968, Source = "25968", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25968", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_9", ])]
	public float 取料7Z轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 25970, Source = "25970", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25970", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_10", ])]
	public float 取料7Z轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 25972, Source = "25972", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25972", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_11", ])]
	public float 取料7Z轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 25974, Source = "25974", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25974", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_12", ])]
	public float 取料7Z轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 25976, Source = "25976", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25976", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_13", ])]
	public float 取料7Z轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 25978, Source = "25978", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25978", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_14", ])]
	public float 取料7Z轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 25980, Source = "25980", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25980", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_15", ])]
	public float 取料7Z轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 25982, Source = "25982", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25982", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_16", ])]
	public float 取料7Z轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 25984, Source = "25984", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25984", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_17", ])]
	public float 取料7Z轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 25986, Source = "25986", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25986", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_18", ])]
	public float 取料7Z轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 25988, Source = "25988", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25988", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_19", ])]
	public float 取料7Z轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 25990, Source = "25990", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:25990", Category = "PLC/取料7Z轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_Địa điểm_20", ])]
	public float 取料7Z轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26000, Source = "26000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26000", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_0", ])]
	public float 取料7Z轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 26002, Source = "26002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26002", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_1", ])]
	public float 取料7Z轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26004, Source = "26004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26004", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_2", ])]
	public float 取料7Z轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26006, Source = "26006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26006", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_3", ])]
	public float 取料7Z轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26008, Source = "26008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26008", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_4", ])]
	public float 取料7Z轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26010, Source = "26010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26010", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_5", ])]
	public float 取料7Z轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26012, Source = "26012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26012", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_6", ])]
	public float 取料7Z轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26014, Source = "26014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26014", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_7", ])]
	public float 取料7Z轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26016, Source = "26016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26016", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_8", ])]
	public float 取料7Z轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26018, Source = "26018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26018", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_9", ])]
	public float 取料7Z轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26020, Source = "26020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26020", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_10", ])]
	public float 取料7Z轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26022, Source = "26022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26022", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_11", ])]
	public float 取料7Z轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26024, Source = "26024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26024", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_12", ])]
	public float 取料7Z轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26026, Source = "26026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26026", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_13", ])]
	public float 取料7Z轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26028, Source = "26028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26028", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_14", ])]
	public float 取料7Z轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26030, Source = "26030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26030", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_15", ])]
	public float 取料7Z轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26032, Source = "26032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26032", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_16", ])]
	public float 取料7Z轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26034, Source = "26034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26034", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_17", ])]
	public float 取料7Z轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26036, Source = "26036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26036", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_18", ])]
	public float 取料7Z轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26038, Source = "26038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26038", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_19", ])]
	public float 取料7Z轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26040, Source = "26040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26040", Category = "PLC/取料7Z轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7Z轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 7Z-axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 7Z_trục_tốc độ_20", ])]
	public float 取料7Z轴_Axis_Vel_20 { get; set; }

	[BinaryPoint(Offset = 26050, Source = "26050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26050", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis __Axis_Pos-0",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_0", ])]
	public float 取料7R轴_Axis_Pos_0 { get; set; }

	[BinaryPoint(Offset = 26052, Source = "26052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26052", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_1",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_1", ])]
	public float 取料7R轴_Axis_Pos_1 { get; set; }

	[BinaryPoint(Offset = 26054, Source = "26054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26054", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_2",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_2", ])]
	public float 取料7R轴_Axis_Pos_2 { get; set; }

	[BinaryPoint(Offset = 26056, Source = "26056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26056", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Pos_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_3", ])]
	public float 取料7R轴_Axis_Pos_3 { get; set; }

	[BinaryPoint(Offset = 26058, Source = "26058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26058", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_4",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_4", ])]
	public float 取料7R轴_Axis_Pos_4 { get; set; }

	[BinaryPoint(Offset = 26060, Source = "26060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26060", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_5",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_5", ])]
	public float 取料7R轴_Axis_Pos_5 { get; set; }

	[BinaryPoint(Offset = 26062, Source = "26062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26062", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_6",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_6", ])]
	public float 取料7R轴_Axis_Pos_6 { get; set; }

	[BinaryPoint(Offset = 26064, Source = "26064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26064", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_7",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_7", ])]
	public float 取料7R轴_Axis_Pos_7 { get; set; }

	[BinaryPoint(Offset = 26066, Source = "26066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26066", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_8",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_8", ])]
	public float 取料7R轴_Axis_Pos_8 { get; set; }

	[BinaryPoint(Offset = 26068, Source = "26068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26068", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_9",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_9", ])]
	public float 取料7R轴_Axis_Pos_9 { get; set; }

	[BinaryPoint(Offset = 26070, Source = "26070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26070", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis __Axis_Pos_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_10", ])]
	public float 取料7R轴_Axis_Pos_10 { get; set; }

	[BinaryPoint(Offset = 26072, Source = "26072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26072", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_11",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_11", ])]
	public float 取料7R轴_Axis_Pos_11 { get; set; }

	[BinaryPoint(Offset = 26074, Source = "26074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26074", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_12",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_12", ])]
	public float 取料7R轴_Axis_Pos_12 { get; set; }

	[BinaryPoint(Offset = 26076, Source = "26076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26076", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_13",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_13", ])]
	public float 取料7R轴_Axis_Pos_13 { get; set; }

	[BinaryPoint(Offset = 26078, Source = "26078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26078", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_14",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_14", ])]
	public float 取料7R轴_Axis_Pos_14 { get; set; }

	[BinaryPoint(Offset = 26080, Source = "26080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26080", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_15",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_15", ])]
	public float 取料7R轴_Axis_Pos_15 { get; set; }

	[BinaryPoint(Offset = 26082, Source = "26082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26082", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_16",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_16", ])]
	public float 取料7R轴_Axis_Pos_16 { get; set; }

	[BinaryPoint(Offset = 26084, Source = "26084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26084", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_17",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_17", ])]
	public float 取料7R轴_Axis_Pos_17 { get; set; }

	[BinaryPoint(Offset = 26086, Source = "26086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26086", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis __Axis_Pos_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_18", ])]
	public float 取料7R轴_Axis_Pos_18 { get; set; }

	[BinaryPoint(Offset = 26088, Source = "26088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26088", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_19",
		DataDefine.KeyValue,"NameByEN", "Material retrieval 7R axis_Axis_Pos_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_19", ])]
	public float 取料7R轴_Axis_Pos_19 { get; set; }

	[BinaryPoint(Offset = 26090, Source = "26090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26090", Category = "PLC/取料7R轴_Axis_Pos", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Pos_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis __Axis_Pos_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_trục_Địa điểm_20", ])]
	public float 取料7R轴_Axis_Pos_20 { get; set; }

	[BinaryPoint(Offset = 26100, Source = "26100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26100", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_0",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_0",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_0", ])]
	public float 取料7R轴_Axis_Vel_0 { get; set; }

	[BinaryPoint(Offset = 26102, Source = "26102", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26102", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_1",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_1",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_1", ])]
	public float 取料7R轴_Axis_Vel_1 { get; set; }

	[BinaryPoint(Offset = 26104, Source = "26104", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26104", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_2",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_2",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_2", ])]
	public float 取料7R轴_Axis_Vel_2 { get; set; }

	[BinaryPoint(Offset = 26106, Source = "26106", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26106", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_3",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_3",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_3", ])]
	public float 取料7R轴_Axis_Vel_3 { get; set; }

	[BinaryPoint(Offset = 26108, Source = "26108", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26108", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_4",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_4",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_4", ])]
	public float 取料7R轴_Axis_Vel_4 { get; set; }

	[BinaryPoint(Offset = 26110, Source = "26110", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26110", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_5",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_5",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_5", ])]
	public float 取料7R轴_Axis_Vel_5 { get; set; }

	[BinaryPoint(Offset = 26112, Source = "26112", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26112", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_6",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel-6",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_6", ])]
	public float 取料7R轴_Axis_Vel_6 { get; set; }

	[BinaryPoint(Offset = 26114, Source = "26114", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26114", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_7",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_7",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_7", ])]
	public float 取料7R轴_Axis_Vel_7 { get; set; }

	[BinaryPoint(Offset = 26116, Source = "26116", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26116", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_8",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_8",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_8", ])]
	public float 取料7R轴_Axis_Vel_8 { get; set; }

	[BinaryPoint(Offset = 26118, Source = "26118", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26118", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_9",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_9",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_9", ])]
	public float 取料7R轴_Axis_Vel_9 { get; set; }

	[BinaryPoint(Offset = 26120, Source = "26120", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26120", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_10",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_10",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_10", ])]
	public float 取料7R轴_Axis_Vel_10 { get; set; }

	[BinaryPoint(Offset = 26122, Source = "26122", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26122", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_11",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_11",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_11", ])]
	public float 取料7R轴_Axis_Vel_11 { get; set; }

	[BinaryPoint(Offset = 26124, Source = "26124", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26124", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_12",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_12",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_12", ])]
	public float 取料7R轴_Axis_Vel_12 { get; set; }

	[BinaryPoint(Offset = 26126, Source = "26126", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26126", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_13",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_13",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_13", ])]
	public float 取料7R轴_Axis_Vel_13 { get; set; }

	[BinaryPoint(Offset = 26128, Source = "26128", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26128", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_14",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_14",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_14", ])]
	public float 取料7R轴_Axis_Vel_14 { get; set; }

	[BinaryPoint(Offset = 26130, Source = "26130", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26130", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_15",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_15",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_15", ])]
	public float 取料7R轴_Axis_Vel_15 { get; set; }

	[BinaryPoint(Offset = 26132, Source = "26132", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26132", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_16",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_16",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_16", ])]
	public float 取料7R轴_Axis_Vel_16 { get; set; }

	[BinaryPoint(Offset = 26134, Source = "26134", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26134", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_17",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_17",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_17", ])]
	public float 取料7R轴_Axis_Vel_17 { get; set; }

	[BinaryPoint(Offset = 26136, Source = "26136", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26136", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_18",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_18",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_18", ])]
	public float 取料7R轴_Axis_Vel_18 { get; set; }

	[BinaryPoint(Offset = 26138, Source = "26138", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26138", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_19",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_19",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_19", ])]
	public float 取料7R轴_Axis_Vel_19 { get; set; }

	[BinaryPoint(Offset = 26140, Source = "26140", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:26140", Category = "PLC/取料7R轴_Axis_Vel", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "取料7R轴_Axis_Vel_20",
		DataDefine.KeyValue,"NameByEN", "Material taking 7R axis_Axis_Vel_20",
		DataDefine.KeyValue,"NameByVI", "Lấy 7R_Axis_Vel_20", ])]
	public float 取料7R轴_Axis_Vel_20 { get; set; }

	#endregion

}