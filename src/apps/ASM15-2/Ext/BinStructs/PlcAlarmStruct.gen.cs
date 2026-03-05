
// GENERATE AT 2026/3/5 17:59:26
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
		DataDefine.KeyValue,"NameByCN", "X轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "X-axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c X Kh?ng cho phép nh?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22501, Source = "22501", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22501", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "X轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "X-axis command error",
		DataDefine.KeyValue,"NameByVI", "Tr?c X - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22502, Source = "22502", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22502", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "X轴_正极限",
		DataDefine.KeyValue,"NameByEN", "X-axis_positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c X Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22503, Source = "22503", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22503", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "X轴_负极限",
		DataDefine.KeyValue,"NameByEN", "X-axis_negative limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c X Gi?i h?n am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22504, Source = "22504", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22504", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "X轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c X_JOG Báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22505, Source = "22505", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22505", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "X轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c X_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22506, Source = "22506", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22506", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "X轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "X-axis_hand automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Tr?c X Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22507, Source = "22507", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22507", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "Y轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Y-axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22508, Source = "22508", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22508", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "Y轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Y-axis command error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22509, Source = "22509", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22509", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "Y轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Y-axis positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22510, Source = "22510", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22510", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "Y轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Y-axis - Negative Limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y Gi?i h?n am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22511, Source = "22511", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22511", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "Y轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y_JOG Báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22512, Source = "22512", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22512", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "Y轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Y-axis_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22513, Source = "22513", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22513", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "Y轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Y-axis automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22514, Source = "22514", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22514", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "Z轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Z-axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22515, Source = "22515", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22515", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "Z轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Z-axis command error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22516, Source = "22516", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22516", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "Z轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Z-axis positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22517, Source = "22517", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22517", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "Z轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Z-axis_negative limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z Gi?i h?n am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22518, Source = "22518", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22518", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "Z轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Z-axis_JOG báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22519, Source = "22519", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22519", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "Z轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Z-axis_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22520, Source = "22520", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22520", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "Z轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Z-axis automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22521, Source = "22521", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22521", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1 M?o kh?ng ???c cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22522, Source = "22522", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22522", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_command error",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1 - H??ng d?n sai",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22523, Source = "22523", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22523", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_positive limit",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22524, Source = "22524", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22524", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_negative limit",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22525, Source = "22525", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22525", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1_JOG báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22526, Source = "22526", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22526", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22527, Source = "22527", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22527", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "龙门轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 1_manual automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 1 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22528, Source = "22528", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22528", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 2 not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Gantry tr?c 2 Kh?ng cho phép nh?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22529, Source = "22529", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22529", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 2-command error",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2 - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22530, Source = "22530", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22530", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Longmen Axis 2-Positive Limit",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22531, Source = "22531", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22531", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Longmen Axis 2-Negative Limit",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22532, Source = "22532", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22532", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen Axis 2-JOG Safety Condition Alarm",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2_JOG báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22533, Source = "22533", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22533", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 2-PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22534, Source = "22534", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22534", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "龙门轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Longmen axis 2-hand automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "C?ng tr?c 2 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22535, Source = "22535", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22535", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan Shaft Kh?ng cho phép M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22536, Source = "22536", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22536", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axial-command error",
		DataDefine.KeyValue,"NameByVI", "Giàn xoay tr?c H??ng d?n báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22537, Source = "22537", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22537", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan Shaft Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22538, Source = "22538", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22538", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan tr?c Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22539, Source = "22539", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22539", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axial-JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan Shaft_JOG Báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22540, Source = "22540", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22540", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan Shaft_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22541, Source = "22541", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22541", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "龙门平移轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Longmen translation axial-hand automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Gantry Pan Shaft Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 龙门平移轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22542, Source = "22542", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22542", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "上料轴1_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_ not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 Kh?ng cho phép nh?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22543, Source = "22543", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22543", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "上料轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_instruction error",
		DataDefine.KeyValue,"NameByVI", "H??ng d?n s?a l?i #1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22544, Source = "22544", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22544", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "上料轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c n?p 1 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22545, Source = "22545", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22545", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "上料轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_negative limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 Gi?i h?n am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22546, Source = "22546", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22546", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "上料轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1_JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22547, Source = "22547", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22547", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "上料轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22548, Source = "22548", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22548", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "上料轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The feeding axis 1_manual and automatic are inconsistent",
		DataDefine.KeyValue,"NameByVI", "Tr?c n?p 1 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22549, Source = "22549", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22549", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "上料轴2_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2h not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 Kh?ng cho phép nh?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22550, Source = "22550", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22550", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "上料轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2 instruction error",
		DataDefine.KeyValue,"NameByVI", "H??ng d?n s?a l?i #2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22551, Source = "22551", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22551", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "上料轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2-positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c n?p 2 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22552, Source = "22552", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22552", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "上料轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2-negative limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 Gi?i h?n am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22553, Source = "22553", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22553", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "上料轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Feeding shaft 2-JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2_JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22554, Source = "22554", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22554", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "上料轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Feeding axis 2-PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2_PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22555, Source = "22555", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22555", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "上料轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The feeding axis is not consistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22556, Source = "22556", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22556", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Tr?c b??c ?i?u ch?nh máy ?nh Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22557, Source = "22557", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22557", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-command error",
		DataDefine.KeyValue,"NameByVI", "?i?u ch?nh tr?c b??c c?a máy ?nh L?i h??ng d?n",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22558, Source = "22558", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22558", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c b??c ?i?u ch?nh máy ?nh Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22559, Source = "22559", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22559", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Tr?c b??c ?i?u ch?nh máy ?nh Negative Limit",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22560, Source = "22560", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22560", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment stepper shaft_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Máy ?nh ?i?u ch?nh b??c tr?c _JOG?i?u ki?n an ninh báo ??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22561, Source = "22561", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22561", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "?i?u ch?nh máy ?nh Step Shaft_PTP Báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22562, Source = "22562", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22562", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Tr?c b??c ?i?u ch?nh máy ?nh Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22563, Source = "22563", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22563", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Z1 axis for material retrieval - not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z1 Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22564, Source = "22564", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22564", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Z1 axis material retrieval instruction error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z1 - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22565, Source = "22565", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22565", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material collection Z1 axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z1 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22566, Source = "22566", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22566", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material collection Z1 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z1 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22567, Source = "22567", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22567", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis for material retrieval and JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z1_JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22568, Source = "22568", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22568", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis for material retrieval and PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác Z1 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22569, Source = "22569", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22569", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "取料Z1轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The Z1 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z1 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z1轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22570, Source = "22570", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22570", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "R1 axis not enabled prompt for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Rút R1 tr?c Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22571, Source = "22571", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22571", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Retrieve R1 axial-command error",
		DataDefine.KeyValue,"NameByVI", "R1 tr?c - sai l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22572, Source = "22572", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22572", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material collection R1 axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Rút R1 tr?c Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22573, Source = "22573", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22573", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material R1 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Rút R1 tr?c Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22574, Source = "22574", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22574", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R1 axis JOG safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Khai thác R1 tr?c JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22575, Source = "22575", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22575", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R1 axis PTP safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Khai thác R1 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22576, Source = "22576", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22576", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "取料R1轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The R1 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Rút R1 tr?c Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R1轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22577, Source = "22577", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22577", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Material retrieval Z2 axis_not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z2 Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22578, Source = "22578", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22578", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Material retrieval Z2 axis instruction error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z2 - H??ng d?n sai",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22579, Source = "22579", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22579", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material collection Z2 axis_positive limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z2 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22580, Source = "22580", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22580", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "81",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material taking Z2 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z2 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22581, Source = "22581", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22581", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "82",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis for material retrieval and JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z2_JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22582, Source = "22582", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22582", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "83",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis for material retrieval and PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác Z2 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22583, Source = "22583", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22583", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "84",
		DataDefine.KeyValue,"NameByCN", "取料Z2轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The Z2 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Chi?t xu?t tr?c Z2 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z2轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22584, Source = "22584", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22584", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "85",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "R2 axis not enabled prompt for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Rút R2 tr?c Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22585, Source = "22585", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22585", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "86",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "R2 axis material retrieval instruction error",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R2 L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22586, Source = "22586", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22586", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "87",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material taking R2 axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Rút R2 Axis Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22587, Source = "22587", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22587", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "88",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material taking R2 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Rút R2 tr?c Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22588, Source = "22588", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22588", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "89",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R2 axis JOG safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c R2 JOG Báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22589, Source = "22589", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22589", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "90",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R2 axis safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Khai thác R2 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22590, Source = "22590", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22590", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "91",
		DataDefine.KeyValue,"NameByCN", "取料R2轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The R2 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Rút R2 tr?c Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R2轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22591, Source = "22591", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22591", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "92",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Z3 axis for material retrieval - not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z3 Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22592, Source = "22592", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22592", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "93",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Material retrieval Z3 axial-command error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z3 - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22593, Source = "22593", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22593", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "94",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Z3 Axis for Material Retrieval - Positive Limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z3 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22594, Source = "22594", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22594", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "95",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Z3 Axis for Material Retrieval - Negative Limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z3 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22595, Source = "22595", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22595", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "96",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z3 axis for material retrieval and JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác Z3 tr?c JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22596, Source = "22596", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22596", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "97",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z3 axis for material retrieval and PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác Z3 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22597, Source = "22597", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22597", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "98",
		DataDefine.KeyValue,"NameByCN", "取料Z3轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The Z3 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z3 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z3轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22598, Source = "22598", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22598", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "99",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "R3 axis not enabled prompt for material retrieval",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R3 Kh?ng ???c cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22599, Source = "22599", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22599", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "100",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Material retrieval R3 axis instruction error",
		DataDefine.KeyValue,"NameByVI", "Tr?c R3 - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22600, Source = "22600", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22600", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "101",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material taking R3 axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R3 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22601, Source = "22601", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22601", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "102",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material taking R3 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R3 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22602, Source = "22602", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22602", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "103",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R3 axis JOG safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R3 JOG Báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22603, Source = "22603", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22603", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "104",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R3 axis for material retrieval and PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác R3 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22604, Source = "22604", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22604", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "105",
		DataDefine.KeyValue,"NameByCN", "取料R3轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The R3 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Rút tr?c R3 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R3轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22605, Source = "22605", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22605", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "106",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Material Z4 axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z4 Kh?ng cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22606, Source = "22606", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22606", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "107",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Z4 axis material retrieval instruction error",
		DataDefine.KeyValue,"NameByVI", "Tr?c Z4 - L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22607, Source = "22607", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22607", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "108",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Material taking Z4 axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c Z4 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22608, Source = "22608", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22608", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "109",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Z4 axis for material retrieval - negative limit",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z4 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22609, Source = "22609", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22609", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "110",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z4 axis for material retrieval and JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Khai thác tr?c Z4_JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22610, Source = "22610", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22610", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "111",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z4 axis safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "Khai thác Z4 tr?c PTP báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22611, Source = "22611", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22611", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "112",
		DataDefine.KeyValue,"NameByCN", "取料Z4轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Z4 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Chi?t xu?t tr?c Z4 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料Z4轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22612, Source = "22612", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22612", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "113",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "R4 axis not enabled prompt for material retrieval",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R4 Kh?ng ???c cho phép nh?c nh?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22613, Source = "22613", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22613", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "114",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "R4 axis material retrieval instruction error",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R4 L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22614, Source = "22614", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22614", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "115",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_正极限",
		DataDefine.KeyValue,"NameByEN", "R4 axis for material collection - positive limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R4 Gi?i h?n tích c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22615, Source = "22615", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22615", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "116",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Material taking R4 axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "L?y tr?c R4 Gi?i h?n tiêu c?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22616, Source = "22616", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22616", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "117",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R4 axis for material retrieval and JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "L?y R4 tr?c JOG báo ??ng ?i?u ki?n an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22617, Source = "22617", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22617", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "118",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R4 axis safety condition alarm for material retrieval",
		DataDefine.KeyValue,"NameByVI", "L?y R4 Axis_PTP Báo ??ng ?i?u ki?n an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22618, Source = "22618", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22618", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "119",
		DataDefine.KeyValue,"NameByCN", "取料R4轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "R4 axis for material retrieval is inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Rút tr?c R4 Tay t? ??ng kh?ng phù h?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料R4轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22619, Source = "22619", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22619", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "120",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 1 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22620, Source = "22620", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22620", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "121",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 1 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22621, Source = "22621", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22621", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "122",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Origin Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 1 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22622, Source = "22622", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22622", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "123",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 1 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22623, Source = "22623", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22623", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "124",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 1 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22624, Source = "22624", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22624", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "125",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 2 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22625, Source = "22625", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22625", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "126",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 2 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22626, Source = "22626", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22626", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "127",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 2 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22627, Source = "22627", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22627", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "128",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Abnormal Safety Condition Triggered in Working Position",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 2 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22628, Source = "22628", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22628", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "129",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 2 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22629, Source = "22629", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22629", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "130",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 3 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22630, Source = "22630", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22630", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "131",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 3 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22631, Source = "22631", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22631", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "132",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 3 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22632, Source = "22632", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22632", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "133",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 3 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22633, Source = "22633", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22633", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "134",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 1 ??nh v? xi lanh 3 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22634, Source = "22634", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22634", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "135",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 1 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22635, Source = "22635", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22635", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "136",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 1 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22636, Source = "22636", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22636", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "137",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Origin Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 1 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22637, Source = "22637", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22637", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "138",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 1 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22638, Source = "22638", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22638", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "139",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 1 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22639, Source = "22639", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22639", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "140",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 2 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22640, Source = "22640", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22640", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "141",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 2 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22641, Source = "22641", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22641", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "142",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 2 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22642, Source = "22642", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22642", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "143",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 2 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22643, Source = "22643", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22643", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "144",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 2 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22644, Source = "22644", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22644", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "145",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 3 - Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22645, Source = "22645", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22645", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "146",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 3 - Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22646, Source = "22646", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22646", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "147",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 3 - ?i?u ki?n an toàn g?c Kích ho?t ngo?i l?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22647, Source = "22647", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22647", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "148",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 3 - ?i?u ki?n an toàn v? trí làm vi?c Kích ho?t b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22648, Source = "22648", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22648", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "149",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Tr?c 2 ??nh v? xi lanh 3 - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22649, Source = "22649", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22649", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "150",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material detection 1_Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 1 Báo ??ng áp su?t am chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22650, Source = "22650", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22650", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "151",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material detection 1_Vacuum - No vacuum breaking alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 1 Chan kh?ng - Kh?ng phá v? báo ??ng chan kh?ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22651, Source = "22651", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22651", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "152",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material Testing 1_Vacuum Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 1 Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22652, Source = "22652", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22652", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "153",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material detection 2-Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 2 Báo ??ng áp su?t am chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22653, Source = "22653", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22653", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "154",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material detection 2-Vacuum - No vacuum breaking alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 2 Chan kh?ng - Kh?ng phá v? báo ??ng chan kh?ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22654, Source = "22654", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22654", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "155",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material Testing 2-Vacuum Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Phát hi?n v?t li?u 2 Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22655, Source = "22655", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22655", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "156",
		DataDefine.KeyValue,"NameByCN", "上料吸嘴_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Loading nozzle _ Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Vòi hút th?c ?n Chan kh?ng - Báo ??ng áp su?t am",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料吸嘴_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22656, Source = "22656", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22656", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "157",
		DataDefine.KeyValue,"NameByCN", "上料吸嘴_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Loading nozzle - Vacuum - No breaking vacuum alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "Cho ?n mi?ng hút Chan kh?ng - Kh?ng phá v? chan kh?ng báo ??ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料吸嘴_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22657, Source = "22657", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22657", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "158",
		DataDefine.KeyValue,"NameByCN", "上料吸嘴_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Loading nozzle in vacuum manual automatic interlocking system",
		DataDefine.KeyValue,"NameByVI", "Vòi hút th?c ?n Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料吸嘴_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22658, Source = "22658", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22658", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "159",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴1_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 1_Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Vòi hút th?c ?n 1 Báo ??ng áp su?t am - chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴1_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22659, Source = "22659", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22659", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "160",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴1_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 1_Vacuum - No breaking vacuum alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "Khai thác vòi hút 1 Chan kh?ng - Kh?ng phá v? chan kh?ng báo ??ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴1_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22660, Source = "22660", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22660", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "161",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴1_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 1_vacuum manual automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "Vòi hút hút 1 Chan kh?ng - Tay t? ??ng khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴1_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22661, Source = "22661", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22661", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "162",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴2_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 2-Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Vòi hút th?c ?n 2 Báo ??ng áp su?t am - chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴2_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22662, Source = "22662", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22662", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "163",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴2_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 2-Vacuum - No breaking vacuum alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "Khai thác vòi hút 2 Chan kh?ng - Kh?ng phá v? chan kh?ng báo ??ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴2_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22663, Source = "22663", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22663", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "164",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴2_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 2-Vacuum manual automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "M?o hút 2 Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴2_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22664, Source = "22664", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22664", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "165",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴3_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 3_ Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Vòi hút 3 Báo ??ng áp su?t am - chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴3_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22665, Source = "22665", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22665", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "166",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴3_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 3_ Vacuum - No breaking vacuum alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "M?o hút 3 Chan kh?ng - Kh?ng phá v? báo ??ng chan kh?ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴3_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22666, Source = "22666", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22666", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "167",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴3_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 3_ Vacuum hand automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "M?o hút 3 Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴3_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22667, Source = "22667", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22667", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "168",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴4_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 4_ Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Vòi hút th?c ?n 4 Báo ??ng áp su?t am - chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴4_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22668, Source = "22668", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22668", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "169",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴4_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 4_ Vacuum - No breaking vacuum alarm - prompt",
		DataDefine.KeyValue,"NameByVI", "M?o hút 4 Chan kh?ng - Kh?ng phá v? báo ??ng chan kh?ng - M?o",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴4_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22669, Source = "22669", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22669", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "170",
		DataDefine.KeyValue,"NameByCN", "取料吸嘴4_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material suction nozzle 4_ Vacuum hand automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "L?y vòi hút 4 Chan kh?ng - Tay t? ??ng l?ng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料吸嘴4_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22670, Source = "22670", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22670", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "171",
		DataDefine.KeyValue,"NameByCN", "急停中",
		DataDefine.KeyValue,"NameByEN", "Emergency stop in progress",
		DataDefine.KeyValue,"NameByVI", "D?ng kh?n c?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 急停中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22671, Source = "22671", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22671", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "172",
		DataDefine.KeyValue,"NameByCN", "上视觉拍飞达1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Upper visual camera Feida 1 NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Ch?p ?nh tr?c quan lên 1- NG b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上视觉拍飞达1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22672, Source = "22672", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22672", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "173",
		DataDefine.KeyValue,"NameByCN", "上视觉拍飞达2-NG异常",
		DataDefine.KeyValue,"NameByEN", "Upper visual camera Feida 2 NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Ch?p ?nh tr?c quan lên 2- NG b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上视觉拍飞达2_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22673, Source = "22673", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22673", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "174",
		DataDefine.KeyValue,"NameByCN", "上视觉拍飞达3-NG异常",
		DataDefine.KeyValue,"NameByEN", "Upper visual camera Feida 3 NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Ch?p ?nh tr?c quan lên 3- NG b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上视觉拍飞达3_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22674, Source = "22674", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22674", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "175",
		DataDefine.KeyValue,"NameByCN", "上视觉拍飞达4-NG异常",
		DataDefine.KeyValue,"NameByEN", "Upper visual camera Feida 4 NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Ch?p ?nh tr?c quan lên 4- NG b?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上视觉拍飞达4_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22675, Source = "22675", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22675", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "176",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera product 1-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 1 - S?n ph?m ch?p ?nh tr?c quan 1-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22676, Source = "22676", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22676", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "177",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品2-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera product 2-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 1 - S?n ph?m ch?p ?nh tr?c quan 2-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品2_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22677, Source = "22677", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22677", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "178",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品3-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera product 3-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 1 - S?n ph?m ch?p ?nh tr?c quan 3-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品3_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22678, Source = "22678", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22678", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "179",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品4-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera product 4-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 1 - S?n ph?m ch?p ?nh tr?c quan 4-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品4_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22679, Source = "22679", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22679", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "180",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper visual camera product 1-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 2 - S?n ph?m ch?p ?nh tr?c quan 1-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22680, Source = "22680", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22680", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "181",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品2-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper visual camera product 2-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 2 - S?n ph?m ch?p ?nh tr?c quan 2-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品2_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22681, Source = "22681", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22681", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "182",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品3-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper visual camera product 3-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 2 - S?n ph?m ch?p ?nh tr?c quan 3-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品3_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22682, Source = "22682", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22682", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "183",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品4-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper visual camera product 4-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Tr?m 2 - S?n ph?m ch?p ?nh tr?c quan 4-NG B?t th??ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品4_NG异常 { get; set; }= new WordBool();

	#endregion

}