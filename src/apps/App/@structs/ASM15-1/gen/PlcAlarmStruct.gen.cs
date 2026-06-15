
// GENERATE AT 2026/6/12 13:26:21
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "Part1", Source = "22500", Tags = "WordBool", Start = 22500, End = 22700, Points = ["*"])]
public partial class PlcAlarmStruct
{

	#region CSV INCLUDE POINTS: 报警

	[BinaryPoint(Offset = 22500, Source = "22500", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22500", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "1",
		DataDefine.KeyValue,"NameByCN", "工位1Z轴M1指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Z轴M1指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22501, Source = "22501", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22501", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "工位2Z轴M2指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Z轴M2指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22502, Source = "22502", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22502", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "工位1X轴M3指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1X轴M3指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22503, Source = "22503", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22503", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "工位2X轴M4指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2X轴M4指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22504, Source = "22504", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22504", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "工位1Y轴M5指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Y轴M5指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22505, Source = "22505", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22505", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "工位2Y轴M6指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Y轴M6指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22506, Source = "22506", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22506", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "工位1步进Z1轴M7指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis1_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1步进Z1轴M7指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22507, Source = "22507", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22507", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "工位2步进Z2轴M8指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2步进Z2轴M8指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22508, Source = "22508", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22508", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "工位1固高Y1轴M9指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1固高Y1轴M9指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22509, Source = "22509", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22509", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "工位2固高Y2轴M10指令报错",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2固高Y2轴M10指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22510, Source = "22510", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22510", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "工位1升降Z轴未使能",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1升降Z轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22511, Source = "22511", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22511", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "工位1Z轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Z轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22512, Source = "22512", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22512", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "工位1Z轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Z轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22513, Source = "22513", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22513", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "工位1Z轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Load_Axis2_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Z轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22514, Source = "22514", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22514", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "工位2Z轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Z轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22515, Source = "22515", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22515", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "工位2Z轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Z轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22516, Source = "22516", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22516", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "工位2Z轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Z轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22517, Source = "22517", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22517", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "工位2升降Z轴未使能",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2升降Z轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22518, Source = "22518", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22518", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "工位1X轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1X轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22519, Source = "22519", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22519", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "工位1X轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1X轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22520, Source = "22520", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22520", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "工位1X轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X_Axis_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1X轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22521, Source = "22521", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22521", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "工位1X轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1X轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22522, Source = "22522", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22522", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "工位2X轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2X轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22523, Source = "22523", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22523", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "工位2X轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2X轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22524, Source = "22524", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22524", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "工位2X轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2X轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22525, Source = "22525", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22525", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "工位2X轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2X轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22526, Source = "22526", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22526", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "工位1Y轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Y轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22527, Source = "22527", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22527", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "工位1Y轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y_Axis_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Y轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22528, Source = "22528", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22528", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "工位1Y轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Y轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22529, Source = "22529", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22529", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "工位1Y轴未使能",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1Y轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22530, Source = "22530", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22530", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "工位2Y轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Y轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22531, Source = "22531", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22531", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "工位2Y轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Y轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22532, Source = "22532", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22532", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "工位2Y轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Y轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22533, Source = "22533", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22533", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "工位2Y轴未使能",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2Y轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22534, Source = "22534", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22534", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "工位1步进Z轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Cam_Adj_Step_Axis_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1步进Z轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22535, Source = "22535", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22535", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "工位1步进Z轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1步进Z轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22536, Source = "22536", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22536", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "工位1步进Z轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1步进Z轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22537, Source = "22537", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22537", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "工位1步进Z轴未使能",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1步进Z轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22538, Source = "22538", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22538", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "工位2步进Z轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2步进Z轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22539, Source = "22539", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22539", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "工位2步进Z轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2步进Z轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22540, Source = "22540", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22540", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "工位2步进Z轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2步进Z轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22541, Source = "22541", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22541", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "工位2步进Z轴未使能",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z1_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2步进Z轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22542, Source = "22542", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22542", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "工位1固高Y轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1固高Y轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22543, Source = "22543", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22543", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "工位1固高Y轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1固高Y轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22544, Source = "22544", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22544", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "工位1固高Y轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1固高Y轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22545, Source = "22545", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22545", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "工位1固高Y轴未使能",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1固高Y轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22546, Source = "22546", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22546", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "工位2固高Y轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2固高Y轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22547, Source = "22547", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22547", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "工位2固高Y轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2固高Y轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22548, Source = "22548", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22548", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "工位2固高Y轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R1_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2固高Y轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22549, Source = "22549", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22549", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "工位2固高Y轴未使能",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2固高Y轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22550, Source = "22550", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22550", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22551, Source = "22551", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22551", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22552, Source = "22552", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22552", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22553, Source = "22553", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22553", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22554, Source = "22554", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22554", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22555, Source = "22555", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22555", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z2_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22556, Source = "22556", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22556", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22557, Source = "22557", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22557", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22558, Source = "22558", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22558", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22559, Source = "22559", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22559", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22560, Source = "22560", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22560", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22561, Source = "22561", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22561", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22562, Source = "22562", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22562", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R2_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22563, Source = "22563", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22563", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22564, Source = "22564", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22564", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22565, Source = "22565", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22565", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22566, Source = "22566", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22566", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22567, Source = "22567", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22567", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22568, Source = "22568", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22568", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22569, Source = "22569", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22569", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z3_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22570, Source = "22570", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22570", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22571, Source = "22571", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22571", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22572, Source = "22572", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22572", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22573, Source = "22573", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22573", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22574, Source = "22574", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22574", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22575, Source = "22575", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22575", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22576, Source = "22576", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22576", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R3_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22577, Source = "22577", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22577", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22578, Source = "22578", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22578", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "螺丝机吸螺丝真空报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机吸螺丝真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22579, Source = "22579", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22579", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "待定1",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 待定1 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22580, Source = "22580", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22580", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "81",
		DataDefine.KeyValue,"NameByCN", "载具1真空报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 载具1真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22581, Source = "22581", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22581", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "82",
		DataDefine.KeyValue,"NameByCN", "载具2真空报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 载具2真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22582, Source = "22582", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22582", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "83",
		DataDefine.KeyValue,"NameByCN", "工位1打螺丝失败报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1打螺丝失败报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22583, Source = "22583", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22583", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "84",
		DataDefine.KeyValue,"NameByCN", "工位2打螺丝失败报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z4_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2打螺丝失败报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22584, Source = "22584", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22584", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "85",
		DataDefine.KeyValue,"NameByCN", "工位1视觉引导拍照失败",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1视觉引导拍照失败 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22585, Source = "22585", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22585", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "86",
		DataDefine.KeyValue,"NameByCN", "工位2视觉引导拍照失败",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2视觉引导拍照失败 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22586, Source = "22586", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22586", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "87",
		DataDefine.KeyValue,"NameByCN", "急停中",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 急停中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22587, Source = "22587", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22587", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "88",
		DataDefine.KeyValue,"NameByCN", "工位1相机引导误差值过大",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1相机引导误差值过大 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22588, Source = "22588", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22588", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "89",
		DataDefine.KeyValue,"NameByCN", "工位2相机引导误差值过大",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2相机引导误差值过大 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22589, Source = "22589", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22589", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "90",
		DataDefine.KeyValue,"NameByCN", "工位1扫码多次NG",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1扫码多次NG { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22590, Source = "22590", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22590", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "91",
		DataDefine.KeyValue,"NameByCN", "工位2扫码多次NG",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R4_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2扫码多次NG { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22591, Source = "22591", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22591", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "92",
		DataDefine.KeyValue,"NameByCN", "工位1螺丝拍照多次NG",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1螺丝拍照多次NG { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22592, Source = "22592", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22592", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "93",
		DataDefine.KeyValue,"NameByCN", "工位2螺丝拍照多次NG",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2螺丝拍照多次NG { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22593, Source = "22593", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22593", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "94",
		DataDefine.KeyValue,"NameByCN", "安全门打开1",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 安全门打开1 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22594, Source = "22594", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22594", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "95",
		DataDefine.KeyValue,"NameByCN", "安全门打开2",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 安全门打开2 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22595, Source = "22595", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22595", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "96",
		DataDefine.KeyValue,"NameByCN", "螺丝机1缺螺丝信号",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_JOG_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1缺螺丝信号 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22596, Source = "22596", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22596", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "97",
		DataDefine.KeyValue,"NameByCN", "螺丝机2缺螺丝信号",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_PTP_Safety_Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机2缺螺丝信号 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22597, Source = "22597", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22597", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "98",
		DataDefine.KeyValue,"NameByCN", "手伸入机台报警",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_Z5_Manual_Auto_Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 手伸入机台报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22598, Source = "22598", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22598", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "99",
		DataDefine.KeyValue,"NameByCN", "等待工位1相机反馈",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R5_Not_Enabled",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 等待工位1相机反馈 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22599, Source = "22599", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22599", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "100",
		DataDefine.KeyValue,"NameByCN", "等待工位2相机反馈",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R5_Command_Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 等待工位2相机反馈 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22600, Source = "22600", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22600", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "101",
		DataDefine.KeyValue,"NameByCN", "工位1等待扫码器等待信息",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R5_Pos_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1等待扫码器等待信息 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22601, Source = "22601", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22601", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "102",
		DataDefine.KeyValue,"NameByCN", "工位2等待扫码器等待信息",
		DataDefine.KeyValue,"NameByEN", "Pick_Axis_R5_Neg_Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2等待扫码器等待信息 { get; set; }= new WordBool();

	#endregion

}