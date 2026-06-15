
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
		DataDefine.KeyValue,"NameByCN", "X轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22501, Source = "22501", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22501", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "X轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22502, Source = "22502", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22502", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "X轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22503, Source = "22503", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22503", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "X轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22504, Source = "22504", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22504", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "X轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22505, Source = "22505", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22505", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "X轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22506, Source = "22506", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22506", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "X轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "X Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22507, Source = "22507", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22507", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "X轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22508, Source = "22508", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22508", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "X轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22509, Source = "22509", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22509", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "X轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22510, Source = "22510", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22510", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "X轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22511, Source = "22511", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22511", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "X轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22512, Source = "22512", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22512", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "X轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22513, Source = "22513", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22513", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "X轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "X Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22514, Source = "22514", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22514", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "上料轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22515, Source = "22515", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22515", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "上料轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22516, Source = "22516", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22516", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "上料轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22517, Source = "22517", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22517", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "上料轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22518, Source = "22518", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22518", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "上料轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22519, Source = "22519", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22519", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "上料轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22520, Source = "22520", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22520", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "上料轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22521, Source = "22521", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22521", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "上料轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22522, Source = "22522", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22522", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "上料轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22523, Source = "22523", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22523", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "上料轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22524, Source = "22524", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22524", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "上料轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22525, Source = "22525", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22525", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "上料轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22526, Source = "22526", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22526", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "上料轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22527, Source = "22527", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22527", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "上料轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22528, Source = "22528", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22528", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "线扫轴_未使能",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22529, Source = "22529", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22529", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "线扫轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22530, Source = "22530", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22530", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "线扫轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22531, Source = "22531", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22531", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "线扫轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22532, Source = "22532", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22532", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "线扫轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22533, Source = "22533", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22533", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "线扫轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22534, Source = "22534", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22534", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "线扫轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Line Scan Axis_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 线扫轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22535, Source = "22535", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22535", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "Y轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22536, Source = "22536", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22536", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "Y轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22537, Source = "22537", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22537", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "Y轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22538, Source = "22538", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22538", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "Y轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22539, Source = "22539", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22539", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "Y轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22540, Source = "22540", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22540", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "Y轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22541, Source = "22541", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22541", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "Y轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Y Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22542, Source = "22542", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22542", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "Y轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22543, Source = "22543", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22543", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "Y轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22544, Source = "22544", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22544", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "Y轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22545, Source = "22545", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22545", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "Y轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22546, Source = "22546", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22546", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "Y轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22547, Source = "22547", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22547", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "Y轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22548, Source = "22548", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22548", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "Y轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Y Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22549, Source = "22549", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22549", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22550, Source = "22550", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22550", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22551, Source = "22551", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22551", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22552, Source = "22552", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22552", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22553, Source = "22553", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22553", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22554, Source = "22554", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22554", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22555, Source = "22555", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22555", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22556, Source = "22556", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22556", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22557, Source = "22557", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22557", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22558, Source = "22558", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22558", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22559, Source = "22559", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22559", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22560, Source = "22560", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22560", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22561, Source = "22561", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22561", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22562, Source = "22562", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22562", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Camera Adjustment Stepper Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22563, Source = "22563", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22563", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22564, Source = "22564", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22564", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22565, Source = "22565", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22565", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22566, Source = "22566", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22566", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22567, Source = "22567", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22567", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22568, Source = "22568", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22568", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22569, Source = "22569", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22569", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22570, Source = "22570", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22570", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22571, Source = "22571", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22571", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22572, Source = "22572", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22572", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22573, Source = "22573", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22573", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22574, Source = "22574", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22574", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22575, Source = "22575", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22575", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22576, Source = "22576", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22576", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22577, Source = "22577", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22577", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22578, Source = "22578", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22578", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22579, Source = "22579", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22579", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22580, Source = "22580", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22580", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "81",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22581, Source = "22581", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22581", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "82",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22582, Source = "22582", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22582", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "83",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22583, Source = "22583", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22583", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "84",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22584, Source = "22584", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22584", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "85",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22585, Source = "22585", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22585", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "86",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22586, Source = "22586", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22586", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "87",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22587, Source = "22587", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22587", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "88",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22588, Source = "22588", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22588", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "89",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22589, Source = "22589", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22589", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "90",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22590, Source = "22590", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22590", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "91",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22591, Source = "22591", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22591", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "92",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22592, Source = "22592", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22592", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "93",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22593, Source = "22593", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22593", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "94",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22594, Source = "22594", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22594", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "95",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22595, Source = "22595", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22595", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "96",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22596, Source = "22596", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22596", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "97",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22597, Source = "22597", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22597", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "98",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴3_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 3_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴3_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22598, Source = "22598", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22598", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "99",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22599, Source = "22599", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22599", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "100",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22600, Source = "22600", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22600", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "101",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22601, Source = "22601", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22601", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "102",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22602, Source = "22602", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22602", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "103",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22603, Source = "22603", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22603", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "104",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22604, Source = "22604", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22604", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "105",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴3_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 3_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴3_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22605, Source = "22605", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22605", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "106",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22606, Source = "22606", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22606", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "107",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22607, Source = "22607", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22607", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "108",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22608, Source = "22608", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22608", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "109",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22609, Source = "22609", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22609", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "110",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22610, Source = "22610", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22610", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "111",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22611, Source = "22611", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22611", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "112",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴4_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 4_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴4_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22612, Source = "22612", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22612", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "113",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22613, Source = "22613", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22613", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "114",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22614, Source = "22614", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22614", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "115",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22615, Source = "22615", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22615", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "116",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22616, Source = "22616", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22616", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "117",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22617, Source = "22617", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22617", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "118",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22618, Source = "22618", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22618", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "119",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴4_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 4_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴4_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22619, Source = "22619", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22619", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "120",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22620, Source = "22620", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22620", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "121",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22621, Source = "22621", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22621", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "122",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22622, Source = "22622", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22622", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "123",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22623, Source = "22623", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22623", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "124",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22624, Source = "22624", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22624", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "125",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22625, Source = "22625", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22625", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "126",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴5_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 5_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴5_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22626, Source = "22626", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22626", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "127",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22627, Source = "22627", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22627", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "128",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22628, Source = "22628", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22628", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "129",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22629, Source = "22629", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22629", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "130",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22630, Source = "22630", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22630", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "131",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22631, Source = "22631", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22631", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "132",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22632, Source = "22632", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22632", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "133",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴5_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 5_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴5_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22633, Source = "22633", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22633", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "134",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22634, Source = "22634", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22634", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "135",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22635, Source = "22635", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22635", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "136",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22636, Source = "22636", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22636", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "137",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22637, Source = "22637", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22637", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "138",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22638, Source = "22638", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22638", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "139",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22639, Source = "22639", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22639", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "140",
		DataDefine.KeyValue,"NameByCN", "取料1_Z轴6_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_Z Axis 6_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_Z轴6_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22640, Source = "22640", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22640", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "141",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22641, Source = "22641", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22641", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "142",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22642, Source = "22642", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22642", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "143",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22643, Source = "22643", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22643", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "144",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22644, Source = "22644", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22644", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "145",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22645, Source = "22645", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22645", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "146",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22646, Source = "22646", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22646", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "147",
		DataDefine.KeyValue,"NameByCN", "取料1_R轴6_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 1_R Axis 6_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料1_R轴6_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22647, Source = "22647", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22647", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "148",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22648, Source = "22648", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22648", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "149",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22649, Source = "22649", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22649", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "150",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22650, Source = "22650", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22650", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "151",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22651, Source = "22651", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22651", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "152",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22652, Source = "22652", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22652", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "153",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22653, Source = "22653", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22653", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "154",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22654, Source = "22654", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22654", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "155",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22655, Source = "22655", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22655", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "156",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22656, Source = "22656", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22656", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "157",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22657, Source = "22657", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22657", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "158",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22658, Source = "22658", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22658", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "159",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22659, Source = "22659", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22659", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "160",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22660, Source = "22660", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22660", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "161",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 1_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22661, Source = "22661", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22661", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "162",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22662, Source = "22662", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22662", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "163",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22663, Source = "22663", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22663", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "164",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22664, Source = "22664", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22664", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "165",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22665, Source = "22665", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22665", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "166",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22666, Source = "22666", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22666", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "167",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22667, Source = "22667", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22667", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "168",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22668, Source = "22668", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22668", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "169",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22669, Source = "22669", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22669", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "170",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22670, Source = "22670", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22670", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "171",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22671, Source = "22671", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22671", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "172",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22672, Source = "22672", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22672", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "173",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22673, Source = "22673", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22673", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "174",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22674, Source = "22674", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22674", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "175",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 2_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22675, Source = "22675", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22675", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "176",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22676, Source = "22676", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22676", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "177",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22677, Source = "22677", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22677", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "178",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22678, Source = "22678", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22678", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "179",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22679, Source = "22679", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22679", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "180",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22680, Source = "22680", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22680", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "181",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22681, Source = "22681", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22681", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "182",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴3_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 3_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴3_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22682, Source = "22682", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22682", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "183",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22683, Source = "22683", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22683", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "184",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22684, Source = "22684", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22684", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "185",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22685, Source = "22685", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22685", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "186",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22686, Source = "22686", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22686", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "187",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22687, Source = "22687", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22687", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "188",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22688, Source = "22688", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22688", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "189",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴3_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 3_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴3_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22689, Source = "22689", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22689", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "190",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22690, Source = "22690", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22690", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "191",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22691, Source = "22691", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22691", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "192",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22692, Source = "22692", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22692", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "193",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22693, Source = "22693", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22693", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "194",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22694, Source = "22694", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22694", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "195",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22695, Source = "22695", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22695", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "196",
		DataDefine.KeyValue,"NameByCN", "取料2_Z轴4_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_Z Axis 4_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_Z轴4_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22696, Source = "22696", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22696", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "197",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_未使能",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_Not Enabled Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22697, Source = "22697", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22697", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "198",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_指令报错",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_Command Error",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22698, Source = "22698", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22698", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "199",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_正极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_Positive Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22699, Source = "22699", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22699", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "200",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_负极限",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_Negative Limit",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22700, Source = "22700", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22700", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "201",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22701, Source = "22701", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22701", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "202",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_PTP Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22702, Source = "22702", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22702", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "203",
		DataDefine.KeyValue,"NameByCN", "取料2_R轴4_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Pickup 2_R Axis 4_Manual/Auto Mismatch",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料2_R轴4_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22703, Source = "22703", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22703", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "204",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 1Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22704, Source = "22704", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22704", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "205",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 1Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22705, Source = "22705", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22705", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "206",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸1原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 1Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸1原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22706, Source = "22706", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22706", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "207",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸1工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 1Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸1工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22707, Source = "22707", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22707", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "208",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸1手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 1Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸1手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22708, Source = "22708", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22708", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "209",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 2Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22709, Source = "22709", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22709", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "210",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 2Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22710, Source = "22710", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22710", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "211",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸2原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 2Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸2原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22711, Source = "22711", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22711", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "212",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸2工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 2Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸2工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22712, Source = "22712", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22712", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "213",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸2手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 2Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸2手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22713, Source = "22713", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22713", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "214",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 3Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22714, Source = "22714", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22714", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "215",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 3Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22715, Source = "22715", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22715", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "216",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸3原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 3Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸3原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22716, Source = "22716", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22716", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "217",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸3工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 3Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸3工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22717, Source = "22717", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22717", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "218",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸3手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 3Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸3手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22718, Source = "22718", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22718", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "219",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 4Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22719, Source = "22719", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22719", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "220",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 4Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22720, Source = "22720", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22720", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "221",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸4原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 4Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸4原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22721, Source = "22721", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22721", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "222",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸4工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 4Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸4工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22722, Source = "22722", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22722", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "223",
		DataDefine.KeyValue,"NameByCN", "上料轴1定位气缸4手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 1 Position Cylinder 4Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1定位气缸4手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22723, Source = "22723", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22723", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "224",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 1Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22724, Source = "22724", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22724", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "225",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 1Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22725, Source = "22725", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22725", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "226",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸1原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 1Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸1原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22726, Source = "22726", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22726", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "227",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸1工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 1Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸1工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22727, Source = "22727", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22727", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "228",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸1手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 1Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸1手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22728, Source = "22728", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22728", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "229",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 2Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22729, Source = "22729", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22729", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "230",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 2Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22730, Source = "22730", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22730", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "231",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸2原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 2Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸2原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22731, Source = "22731", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22731", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "232",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸2工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 2Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸2工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22732, Source = "22732", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22732", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "233",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸2手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 2Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸2手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22733, Source = "22733", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22733", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "234",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 3Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22734, Source = "22734", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22734", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "235",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 3Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22735, Source = "22735", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22735", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "236",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸3原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 3Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸3原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22736, Source = "22736", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22736", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "237",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸3工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 3Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸3工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22737, Source = "22737", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22737", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "238",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸3手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 3Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸3手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22738, Source = "22738", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22738", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "239",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 4Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22739, Source = "22739", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22739", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "240",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 4Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22740, Source = "22740", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22740", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "241",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸4原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 4Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸4原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22741, Source = "22741", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22741", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "242",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸4工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 4Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸4工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22742, Source = "22742", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22742", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "243",
		DataDefine.KeyValue,"NameByCN", "上料轴2定位气缸4手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Axis 2 Position Cylinder 4Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2定位气缸4手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22743, Source = "22743", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22743", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "244",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 1Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22744, Source = "22744", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22744", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "245",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 1Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22745, Source = "22745", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22745", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "246",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸1原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 1Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸1原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22746, Source = "22746", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22746", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "247",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸1工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 1Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸1工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22747, Source = "22747", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22747", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "248",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸1手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 1Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸1手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22748, Source = "22748", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22748", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "249",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 2Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22749, Source = "22749", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22749", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "250",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 2Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22750, Source = "22750", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22750", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "251",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸2原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 2Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸2原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22751, Source = "22751", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22751", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "252",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸2工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 2Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸2工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22752, Source = "22752", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22752", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "253",
		DataDefine.KeyValue,"NameByCN", "上料顶升1定位气缸2手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 1 Position Cylinder 2Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升1定位气缸2手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22753, Source = "22753", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22753", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "254",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 1Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22754, Source = "22754", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22754", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "255",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 1Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22755, Source = "22755", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22755", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "256",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸1原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 1Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸1原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22756, Source = "22756", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22756", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "257",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸1工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 1Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸1工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22757, Source = "22757", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22757", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "258",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸1手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 1Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸1手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22758, Source = "22758", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22758", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "259",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 2Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22759, Source = "22759", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22759", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "260",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 2Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22760, Source = "22760", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22760", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "261",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸2原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 2Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸2原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22761, Source = "22761", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22761", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "262",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸2工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 2Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸2工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22762, Source = "22762", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22762", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "263",
		DataDefine.KeyValue,"NameByCN", "上料顶升2定位气缸2手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 2 Position Cylinder 2Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升2定位气缸2手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22763, Source = "22763", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22763", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "264",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 1Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22764, Source = "22764", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22764", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "265",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 1Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22765, Source = "22765", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22765", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "266",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸1原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 1Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸1原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22766, Source = "22766", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22766", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "267",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸1工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 1Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸1工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22767, Source = "22767", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22767", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "268",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸1手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 1Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸1手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22768, Source = "22768", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22768", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "269",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 2Home Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22769, Source = "22769", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22769", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "270",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 2Work Position Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22770, Source = "22770", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22770", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "271",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸2原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 2Home Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸2原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22771, Source = "22771", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22771", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "272",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸2工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 2Work Position Safety Condition Trigger Abnormality",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸2工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22772, Source = "22772", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22772", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "273",
		DataDefine.KeyValue,"NameByCN", "上料顶升3定位气缸2手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading Lift 3 Position Cylinder 2Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料顶升3定位气缸2手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22773, Source = "22773", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22773", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "274",
		DataDefine.KeyValue,"NameByCN", "_1吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 1_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _1吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22774, Source = "22774", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22774", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "275",
		DataDefine.KeyValue,"NameByCN", "_1吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 1_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _1吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22775, Source = "22775", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22775", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "276",
		DataDefine.KeyValue,"NameByCN", "_1吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 1_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _1吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22776, Source = "22776", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22776", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "277",
		DataDefine.KeyValue,"NameByCN", "_2吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 2_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _2吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22777, Source = "22777", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22777", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "278",
		DataDefine.KeyValue,"NameByCN", "_2吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 2_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _2吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22778, Source = "22778", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22778", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "279",
		DataDefine.KeyValue,"NameByCN", "_2吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 2_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _2吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22779, Source = "22779", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22779", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "280",
		DataDefine.KeyValue,"NameByCN", "_3吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 3_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _3吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22780, Source = "22780", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22780", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "281",
		DataDefine.KeyValue,"NameByCN", "_3吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 3_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _3吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22781, Source = "22781", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22781", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "282",
		DataDefine.KeyValue,"NameByCN", "_3吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 3_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _3吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22782, Source = "22782", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22782", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "283",
		DataDefine.KeyValue,"NameByCN", "_4吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 4_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _4吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22783, Source = "22783", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22783", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "284",
		DataDefine.KeyValue,"NameByCN", "_4吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 4_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _4吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22784, Source = "22784", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22784", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "285",
		DataDefine.KeyValue,"NameByCN", "_4吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 4_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _4吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22785, Source = "22785", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22785", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "286",
		DataDefine.KeyValue,"NameByCN", "_5吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 5_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _5吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22786, Source = "22786", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22786", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "287",
		DataDefine.KeyValue,"NameByCN", "_5吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 5_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _5吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22787, Source = "22787", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22787", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "288",
		DataDefine.KeyValue,"NameByCN", "_5吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 5_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _5吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22788, Source = "22788", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22788", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "289",
		DataDefine.KeyValue,"NameByCN", "_6吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 6_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _6吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22789, Source = "22789", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22789", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "290",
		DataDefine.KeyValue,"NameByCN", "_6吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 6_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _6吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22790, Source = "22790", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22790", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "291",
		DataDefine.KeyValue,"NameByCN", "_6吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 6_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _6吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22791, Source = "22791", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22791", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "292",
		DataDefine.KeyValue,"NameByCN", "_7吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 7_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _7吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22792, Source = "22792", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22792", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "293",
		DataDefine.KeyValue,"NameByCN", "_7吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 7_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _7吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22793, Source = "22793", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22793", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "294",
		DataDefine.KeyValue,"NameByCN", "_7吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 7_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _7吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22794, Source = "22794", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22794", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "295",
		DataDefine.KeyValue,"NameByCN", "_8吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 8_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _8吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22795, Source = "22795", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22795", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "296",
		DataDefine.KeyValue,"NameByCN", "_8吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 8_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _8吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22796, Source = "22796", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22796", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "297",
		DataDefine.KeyValue,"NameByCN", "_8吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 8_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _8吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22797, Source = "22797", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22797", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "298",
		DataDefine.KeyValue,"NameByCN", "_9吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 9_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _9吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22798, Source = "22798", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22798", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "299",
		DataDefine.KeyValue,"NameByCN", "_9吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 9_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _9吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22799, Source = "22799", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22799", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "300",
		DataDefine.KeyValue,"NameByCN", "_9吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 9_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _9吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22800, Source = "22800", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22800", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "301",
		DataDefine.KeyValue,"NameByCN", "_10吸嘴_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 10_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _10吸嘴_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22801, Source = "22801", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22801", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "302",
		DataDefine.KeyValue,"NameByCN", "_10吸嘴_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Nozzle 10_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _10吸嘴_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22802, Source = "22802", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22802", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "303",
		DataDefine.KeyValue,"NameByCN", "_10吸嘴_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Nozzle 10_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _10吸嘴_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22803, Source = "22803", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22803", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "304",
		DataDefine.KeyValue,"NameByCN", "_物料1检测1_真空检测_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 1_Vacuum Detection_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测1_真空检测_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22804, Source = "22804", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22804", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "305",
		DataDefine.KeyValue,"NameByCN", "_物料1检测1_真空检测_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 1_Vacuum Detection_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测1_真空检测_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22805, Source = "22805", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22805", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "306",
		DataDefine.KeyValue,"NameByCN", "_物料1检测1_真空检测_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 1_Vacuum Detection_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测1_真空检测_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22806, Source = "22806", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22806", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "307",
		DataDefine.KeyValue,"NameByCN", "_物料1检测2_真空检测_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 2_Vacuum Detection_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测2_真空检测_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22807, Source = "22807", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22807", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "308",
		DataDefine.KeyValue,"NameByCN", "_物料1检测2_真空检测_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 2_Vacuum Detection_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测2_真空检测_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22808, Source = "22808", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22808", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "309",
		DataDefine.KeyValue,"NameByCN", "_物料1检测2_真空检测_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material 1 Detection 2_Vacuum Detection_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料1检测2_真空检测_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22809, Source = "22809", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22809", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "310",
		DataDefine.KeyValue,"NameByCN", "_物料2检测1_真空检测_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 1_Vacuum Detection_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测1_真空检测_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22810, Source = "22810", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22810", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "311",
		DataDefine.KeyValue,"NameByCN", "_物料2检测1_真空检测_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 1_Vacuum Detection_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测1_真空检测_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22811, Source = "22811", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22811", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "312",
		DataDefine.KeyValue,"NameByCN", "_物料2检测1_真空检测_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 1_Vacuum Detection_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测1_真空检测_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22812, Source = "22812", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22812", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "313",
		DataDefine.KeyValue,"NameByCN", "_物料2检测2_真空检测_真空负压报警",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 2_Vacuum Detection_Vacuum  Negative Pressure Alarm",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测2_真空检测_真空负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22813, Source = "22813", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22813", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "314",
		DataDefine.KeyValue,"NameByCN", "_物料2检测2_真空检测_真空禁止破真空报警",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 2_Vacuum Detection_Vacuum  Vacuum Break Prohibited Alarm Prompt",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测2_真空检测_真空禁止破真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22814, Source = "22814", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22814", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "315",
		DataDefine.KeyValue,"NameByCN", "_物料2检测2_真空检测_真空手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material 2 Detection 2_Vacuum Detection_Vacuum  Manual/Auto Interlock Active",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool _物料2检测2_真空检测_真空手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22815, Source = "22815", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22815", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "316",
		DataDefine.KeyValue,"NameByCN", "急停中",
		DataDefine.KeyValue,"NameByEN", "Emergency stop",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 急停中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22816, Source = "22816", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22816", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "317",
		DataDefine.KeyValue,"NameByCN", "安全门1被打开",
		DataDefine.KeyValue,"NameByEN", "Security door 1 was opened",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 安全门1被打开 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22817, Source = "22817", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22817", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "318",
		DataDefine.KeyValue,"NameByCN", "安全门2被打开",
		DataDefine.KeyValue,"NameByEN", "Security door 2 was opened",
		DataDefine.KeyValue,"NameByVI", "",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 安全门2被打开 { get; set; }= new WordBool();

	#endregion

}