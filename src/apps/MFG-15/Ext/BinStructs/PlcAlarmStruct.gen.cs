
// GENERATE AT 2026/4/8 9:56:05
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
		DataDefine.KeyValue,"NameByVI", "Trục X Không cho phép nhắc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22501, Source = "22501", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22501", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "X轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "X-axis command error",
		DataDefine.KeyValue,"NameByVI", "Trục X - Lỗi lệnh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22502, Source = "22502", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22502", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "X轴_正极限",
		DataDefine.KeyValue,"NameByEN", "X-axis_positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục X Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22503, Source = "22503", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22503", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "X轴_负极限",
		DataDefine.KeyValue,"NameByEN", "X-axis_negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục X Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22504, Source = "22504", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22504", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "X轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Trục X_JOG Báo động điều kiện an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22505, Source = "22505", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22505", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "X轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "X-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Trục X_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22506, Source = "22506", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22506", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "X轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "X-axis_hand automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Trục X Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22507, Source = "22507", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22507", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "Y轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Y-axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục Y Không cho phép nhắc nhở",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22508, Source = "22508", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22508", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "Y轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Y-axis command error",
		DataDefine.KeyValue,"NameByVI", "Trục Y Lỗi lệnh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22509, Source = "22509", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22509", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "Y轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Y-axis positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục Y Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22510, Source = "22510", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22510", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "Y轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Y-axis - Negative Limit",
		DataDefine.KeyValue,"NameByVI", "Trục Y Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22511, Source = "22511", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22511", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "Y轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Trục Y_JOG Báo động điều kiện an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22512, Source = "22512", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22512", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "Y轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Y-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Y-axis_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22513, Source = "22513", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22513", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "Y轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Y-axis automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Trục Y Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22514, Source = "22514", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22514", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "Z轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Z-axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục Z Không cho phép nhắc nhở",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22515, Source = "22515", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22515", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "Z轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Z-axis command error",
		DataDefine.KeyValue,"NameByVI", "Trục Z - Lỗi lệnh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22516, Source = "22516", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22516", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "Z轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Z-axis positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục Z Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22517, Source = "22517", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22517", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "Z轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Z-axis_negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục Z Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22518, Source = "22518", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22518", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "Z轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z-axis JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Z-axis_JOG báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22519, Source = "22519", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22519", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "Z轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Z-axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Z-axis_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22520, Source = "22520", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22520", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "Z轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Z-axis automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Trục Z Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22521, Source = "22521", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22521", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "R轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "R-axis_not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục R Không cho phép nhắc nhở",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22522, Source = "22522", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22522", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "R轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "R-axis_instruction error",
		DataDefine.KeyValue,"NameByVI", "Trục R Lỗi lệnh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22523, Source = "22523", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22523", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "R轴_正极限",
		DataDefine.KeyValue,"NameByEN", "R-axis_positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục R Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22524, Source = "22524", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22524", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "R轴_负极限",
		DataDefine.KeyValue,"NameByEN", "R-axis_negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục R Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22525, Source = "22525", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22525", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "R轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R-axis_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "R Axis_JOG Báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22526, Source = "22526", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22526", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "R轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "R-axis_PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "R-axis_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22527, Source = "22527", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22527", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "R轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "R-axis_hand automatic inconsistency",
		DataDefine.KeyValue,"NameByVI", "Trục R Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool R轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22528, Source = "22528", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22528", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "上料轴1_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_ not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Không cho phép nhắc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22529, Source = "22529", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22529", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "上料轴1_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_instruction error",
		DataDefine.KeyValue,"NameByVI", "Hướng dẫn sửa lỗi #1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22530, Source = "22530", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22530", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "上料轴1_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục nạp 1 Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22531, Source = "22531", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22531", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "上料轴1_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22532, Source = "22532", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22532", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "上料轴1_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1_JOG báo động điều kiện an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22533, Source = "22533", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22533", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "上料轴1_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22534, Source = "22534", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22534", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "上料轴1_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The feeding axis 1_manual and automatic are inconsistent",
		DataDefine.KeyValue,"NameByVI", "Trục nạp 1 Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22535, Source = "22535", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22535", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "上料轴2_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2h not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Không cho phép nhắc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22536, Source = "22536", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22536", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "上料轴2_指令报错",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2 instruction error",
		DataDefine.KeyValue,"NameByVI", "Hướng dẫn sửa lỗi #2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22537, Source = "22537", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22537", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "上料轴2_正极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2-positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục nạp 2 Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22538, Source = "22538", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22538", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "上料轴2_负极限",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2-negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Giới hạn âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22539, Source = "22539", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22539", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "上料轴2_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Feeding shaft 2-JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2_JOG báo động điều kiện an toàn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22540, Source = "22540", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22540", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "上料轴2_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Feeding axis 2-PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2_PTP báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22541, Source = "22541", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22541", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "上料轴2_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "The feeding axis is not consistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22542, Source = "22542", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22542", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_未使能提示",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis not enabled prompt",
		DataDefine.KeyValue,"NameByVI", "Trục bước điều chỉnh máy ảnh Không cho phép nhắc nhở",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_未使能提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22543, Source = "22543", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22543", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_指令报错",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-command error",
		DataDefine.KeyValue,"NameByVI", "Điều chỉnh trục bước của máy ảnh Lỗi hướng dẫn",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22544, Source = "22544", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22544", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_正极限",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-positive limit",
		DataDefine.KeyValue,"NameByVI", "Trục bước điều chỉnh máy ảnh Giới hạn tích cực",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_正极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22545, Source = "22545", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22545", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_负极限",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axial-negative limit",
		DataDefine.KeyValue,"NameByVI", "Trục bước điều chỉnh máy ảnh Negative Limit",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_负极限 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22546, Source = "22546", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22546", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_JOG安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment stepper shaft_JOG safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Máy ảnh điều chỉnh bước trục _JOGđiều kiện an ninh báo động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_JOG安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22547, Source = "22547", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22547", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_PTP安全条件报警",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis PTP safety condition alarm",
		DataDefine.KeyValue,"NameByVI", "Điều chỉnh máy ảnh Step Shaft_PTP Báo động điều kiện an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_PTP安全条件报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22548, Source = "22548", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22548", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "相机调节步进轴_手自动不一致",
		DataDefine.KeyValue,"NameByEN", "Camera adjustment step axis inconsistent between manual and automatic modes",
		DataDefine.KeyValue,"NameByVI", "Trục bước điều chỉnh máy ảnh Tay tự động không phù hợp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 相机调节步进轴_手自动不一致 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22549, Source = "22549", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22549", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 1 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22550, Source = "22550", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22550", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 1 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22551, Source = "22551", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22551", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Origin Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 1 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22552, Source = "22552", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22552", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 1 - Điều kiện an toàn vị trí làm việc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22553, Source = "22553", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22553", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸1-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 1-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 1 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸1_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22554, Source = "22554", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22554", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 2 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22555, Source = "22555", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22555", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 2 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22556, Source = "22556", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22556", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 2 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22557, Source = "22557", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22557", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Abnormal Safety Condition Triggered in Working Position",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 2 - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22558, Source = "22558", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22558", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸2-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 2-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 2 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸2_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22559, Source = "22559", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22559", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 3 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22560, Source = "22560", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22560", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 3 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22561, Source = "22561", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22561", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 3 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22562, Source = "22562", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22562", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 3 - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22563, Source = "22563", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22563", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "轴1_定位气缸3-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 1_Positioning Cylinder 3-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 1 Định vị xi lanh 3 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴1_定位气缸3_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22564, Source = "22564", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22564", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 1 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22565, Source = "22565", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22565", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 1 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22566, Source = "22566", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22566", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Origin Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 1 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22567, Source = "22567", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22567", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 1 - Điều kiện an toàn vị trí làm việc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22568, Source = "22568", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22568", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸1-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 1-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 1 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸1_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22569, Source = "22569", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22569", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 2 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22570, Source = "22570", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22570", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 2 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22571, Source = "22571", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22571", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 2 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22572, Source = "22572", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22572", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 2 - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22573, Source = "22573", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22573", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸2-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 2-Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 2 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸2_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22574, Source = "22574", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22574", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-原位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-In situ Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 3 - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22575, Source = "22575", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22575", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Working Position Alarm",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 3 - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22576, Source = "22576", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22576", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Origin Safety Condition Trigger Exception",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 3 - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22577, Source = "22577", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22577", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Working Position Safety Condition Triggered Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 3 - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22578, Source = "22578", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22578", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "轴2_定位气缸3-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Axis 2-Positioning Cylinder 3-Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Trục 2 Định vị xi lanh 3 - Tay tự động khóa vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 轴2_定位气缸3_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22579, Source = "22579", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22579", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "取标签伸出气缸-原位报警",
		DataDefine.KeyValue,"NameByEN", "Label extension cylinder - in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn xi lanh mở rộng - báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签伸出气缸_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22580, Source = "22580", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22580", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "81",
		DataDefine.KeyValue,"NameByCN", "取标签伸出气缸-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Label extension cylinder - working position alarm",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn xi lanh mở rộng - báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签伸出气缸_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22581, Source = "22581", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22581", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "82",
		DataDefine.KeyValue,"NameByCN", "取标签伸出气缸-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Tag extension cylinder - Origin safety condition triggered exception",
		DataDefine.KeyValue,"NameByVI", "Take-label Extension Cylinder - Origin Security Condition Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签伸出气缸_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22582, Source = "22582", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22582", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "83",
		DataDefine.KeyValue,"NameByCN", "取标签伸出气缸-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Tag extension cylinder - Work position safety condition triggers abnormality",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn xi lanh mở rộng - Điều kiện an toàn nơi làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签伸出气缸_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22583, Source = "22583", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22583", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "84",
		DataDefine.KeyValue,"NameByCN", "取标签伸出气缸-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Label extension cylinder - manual automatic interlock",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn xi lanh mở rộng - tay tự động khóa liên động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签伸出气缸_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22584, Source = "22584", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22584", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "85",
		DataDefine.KeyValue,"NameByCN", "取标签升降气缸-原位报警",
		DataDefine.KeyValue,"NameByEN", "Label lifting cylinder - in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn nâng xi lanh - báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签升降气缸_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22585, Source = "22585", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22585", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "86",
		DataDefine.KeyValue,"NameByCN", "取标签升降气缸-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Label lifting cylinder - working position alarm",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn nâng xi lanh - báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签升降气缸_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22586, Source = "22586", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22586", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "87",
		DataDefine.KeyValue,"NameByCN", "取标签升降气缸-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Tag lifting cylinder - Origin safety condition triggered exception",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn Lift Cylinder - Điều kiện an toàn gốc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签升降气缸_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22587, Source = "22587", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22587", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "88",
		DataDefine.KeyValue,"NameByCN", "取标签升降气缸-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Tag lifting cylinder - Work position safety condition triggered exception",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn nâng xi lanh - vị trí làm việc an toàn điều kiện kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签升降气缸_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22588, Source = "22588", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22588", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "89",
		DataDefine.KeyValue,"NameByCN", "取标签升降气缸-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Label lifting cylinder - manual automatic interlock",
		DataDefine.KeyValue,"NameByVI", "Lấy nhãn nâng xi lanh - tay tự động khóa liên động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取标签升降气缸_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22589, Source = "22589", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22589", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "90",
		DataDefine.KeyValue,"NameByCN", "贴膜定位气缸-原位报警",
		DataDefine.KeyValue,"NameByEN", "Film positioning cylinder - in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh định vị phim - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 贴膜定位气缸_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22590, Source = "22590", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22590", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "91",
		DataDefine.KeyValue,"NameByCN", "贴膜定位气缸-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Film positioning cylinder - working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh định vị màng - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 贴膜定位气缸_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22591, Source = "22591", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22591", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "92",
		DataDefine.KeyValue,"NameByCN", "贴膜定位气缸-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Film positioning cylinder - origin safety condition triggers abnormality",
		DataDefine.KeyValue,"NameByVI", "Xi lanh định vị màng - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 贴膜定位气缸_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22592, Source = "22592", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22592", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "93",
		DataDefine.KeyValue,"NameByCN", "贴膜定位气缸-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Film positioning cylinder - abnormal triggering of safety conditions at the working position",
		DataDefine.KeyValue,"NameByVI", "Xi lanh định vị màng - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 贴膜定位气缸_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22593, Source = "22593", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22593", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "94",
		DataDefine.KeyValue,"NameByCN", "贴膜定位气缸-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Film positioning cylinder - manual automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "Màng định vị xi lanh - Tay tự động khóa liên động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 贴膜定位气缸_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22594, Source = "22594", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22594", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "95",
		DataDefine.KeyValue,"NameByCN", "辊压膜气缸-原位报警",
		DataDefine.KeyValue,"NameByEN", "Roll pressure film cylinder - in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh màng cuộn - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 辊压膜气缸_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22595, Source = "22595", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22595", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "96",
		DataDefine.KeyValue,"NameByCN", "辊压膜气缸-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Roll pressure film cylinder - working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh màng cuộn - Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 辊压膜气缸_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22596, Source = "22596", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22596", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "97",
		DataDefine.KeyValue,"NameByCN", "辊压膜气缸-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Roller pressure film cylinder - origin safety condition triggered abnormal",
		DataDefine.KeyValue,"NameByVI", "Xi lanh màng cuộn - Điều kiện an toàn gốc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 辊压膜气缸_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22597, Source = "22597", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22597", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "98",
		DataDefine.KeyValue,"NameByCN", "辊压膜气缸-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Roller pressure film cylinder - abnormal triggering of working position safety conditions",
		DataDefine.KeyValue,"NameByVI", "Xi lanh màng cuộn - Điều kiện an toàn vị trí làm việc Kích hoạt bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 辊压膜气缸_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22598, Source = "22598", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22598", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "99",
		DataDefine.KeyValue,"NameByCN", "辊压膜气缸-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Roller pressing film cylinder - manual automatic interlocking",
		DataDefine.KeyValue,"NameByVI", "Xi lanh màng cuộn - Tay tự động khóa liên động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 辊压膜气缸_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22599, Source = "22599", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22599", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "100",
		DataDefine.KeyValue,"NameByCN", "打印机固定气缸-原位报警",
		DataDefine.KeyValue,"NameByEN", "Printer fixed cylinder - in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh cố định máy in - Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机固定气缸_原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22600, Source = "22600", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22600", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "101",
		DataDefine.KeyValue,"NameByCN", "打印机固定气缸-工作位报警",
		DataDefine.KeyValue,"NameByEN", "Printer fixed cylinder - working position alarm",
		DataDefine.KeyValue,"NameByVI", "Máy in cố định xi lanh - báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机固定气缸_工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22601, Source = "22601", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22601", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "102",
		DataDefine.KeyValue,"NameByCN", "打印机固定气缸-原点安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Printer fixed cylinder - origin safety condition triggered exception",
		DataDefine.KeyValue,"NameByVI", "Xi lanh cố định máy in - Điều kiện an toàn gốc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机固定气缸_原点安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22602, Source = "22602", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22602", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "103",
		DataDefine.KeyValue,"NameByCN", "打印机固定气缸-工作位安全条件触发异常",
		DataDefine.KeyValue,"NameByEN", "Printer fixed cylinder - Work position safety condition triggered exception",
		DataDefine.KeyValue,"NameByVI", "Xi lanh cố định máy in - Điều kiện an toàn nơi làm việc Kích hoạt ngoại lệ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机固定气缸_工作位安全条件触发异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22603, Source = "22603", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22603", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "104",
		DataDefine.KeyValue,"NameByCN", "打印机固定气缸-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Printer fixed cylinder - manual automatic interlock",
		DataDefine.KeyValue,"NameByVI", "Máy in cố định xi lanh - tay tự động khóa liên động",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机固定气缸_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22604, Source = "22604", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22604", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "105",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material detection 1_Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 1 Báo động áp suất âm chân không",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22605, Source = "22605", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22605", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "106",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material detection 1_Vacuum - No vacuum breaking alarm, prompt",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 1 Chân không - Không phá vỡ báo động chân không, Mẹo",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22606, Source = "22606", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22606", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "107",
		DataDefine.KeyValue,"NameByCN", "物料检测1_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material Testing 1_Vacuum Manual Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 1 Chân không - Tay tự động lồng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测1_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22607, Source = "22607", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22607", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "108",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material detection 2-Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 2 Báo động áp suất âm chân không",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22608, Source = "22608", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22608", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "109",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material detection 2-Vacuum - No vacuum breaking alarm, prompt",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 2 Chân không - Không phá vỡ báo động chân không, Mẹo",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22609, Source = "22609", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22609", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "110",
		DataDefine.KeyValue,"NameByCN", "物料检测2_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material Testing 2-Vacuum Hand Automatic Interlocking",
		DataDefine.KeyValue,"NameByVI", "Phát hiện vật liệu 2 Chân không - Tay tự động lồng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 物料检测2_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22610, Source = "22610", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22610", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "111",
		DataDefine.KeyValue,"NameByCN", "取料头_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material pick-up head_ vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Đầu lấy Chân không - Báo động áp suất âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料头_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22611, Source = "22611", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22611", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "112",
		DataDefine.KeyValue,"NameByCN", "取料头_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material pick-up head - Vacuum - No breaking vacuum alarm, prompt",
		DataDefine.KeyValue,"NameByVI", "Đầu lấy Chân không - Không phá vỡ báo động chân không, Mẹo",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料头_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22612, Source = "22612", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22612", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "113",
		DataDefine.KeyValue,"NameByCN", "取料头_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material pick-up head in vacuum manual automatic interlocking system",
		DataDefine.KeyValue,"NameByVI", "Đầu nạp Chân không - Tay tự động lồng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 取料头_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22613, Source = "22613", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22613", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "114",
		DataDefine.KeyValue,"NameByCN", "接料台_真空-负压报警",
		DataDefine.KeyValue,"NameByEN", "Material receiving table _ Vacuum negative pressure alarm",
		DataDefine.KeyValue,"NameByVI", "Bàn tiếp liệu Chân không - Báo động áp suất âm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 接料台_真空_负压报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22614, Source = "22614", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22614", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "115",
		DataDefine.KeyValue,"NameByCN", "接料台_真空-禁止破真空报警-提示",
		DataDefine.KeyValue,"NameByEN", "Material receiving table - Vacuum - No breaking vacuum alarm, prompt",
		DataDefine.KeyValue,"NameByVI", "Bàn tiếp liệu Chân không - Không phá vỡ báo động chân không, Mẹo",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 接料台_真空_禁止破真空报警_提示 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22615, Source = "22615", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22615", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "116",
		DataDefine.KeyValue,"NameByCN", "接料台_真空-手自动联锁中",
		DataDefine.KeyValue,"NameByEN", "Material receiving table in vacuum manual automatic interlocking system",
		DataDefine.KeyValue,"NameByVI", "Bàn tiếp liệu Chân không - Tay tự động lồng vào nhau",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 接料台_真空_手自动联锁中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22616, Source = "22616", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22616", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "117",
		DataDefine.KeyValue,"NameByCN", "急停中",
		DataDefine.KeyValue,"NameByEN", "Emergency stop in progress",
		DataDefine.KeyValue,"NameByVI", "Dừng khẩn cấp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 急停中 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22617, Source = "22617", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22617", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "118",
		DataDefine.KeyValue,"NameByCN", "打印机防撞报警",
		DataDefine.KeyValue,"NameByEN", "Printer collision alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động chống va chạm máy in",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 打印机防撞报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22618, Source = "22618", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22618", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "119",
		DataDefine.KeyValue,"NameByCN", "流线与放料工位防撞报警",
		DataDefine.KeyValue,"NameByEN", "Flow line and discharge station collision alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động chống va chạm cho dòng chảy và trạm xả",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 流线与放料工位防撞报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22619, Source = "22619", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22619", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "120",
		DataDefine.KeyValue,"NameByCN", "工位1-下视觉拍标签1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Visual label 1- NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 - Nhãn chụp trực quan dưới 1 - NG Bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_下视觉拍标签1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22620, Source = "22620", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22620", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "121",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍飞达-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera Feida NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 - Chụp ảnh trực quan lên - NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍飞达_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22621, Source = "22621", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22621", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "122",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Upper visual camera product 1-NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 - Sản phẩm chụp ảnh trực quan 1-NG Bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22622, Source = "22622", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22622", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "123",
		DataDefine.KeyValue,"NameByCN", "工位1-下视觉拍膜NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Abnormal visual film shooting NG",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 - Phim chụp tầm nhìn thấp NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_下视觉拍膜NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22623, Source = "22623", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22623", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "124",
		DataDefine.KeyValue,"NameByCN", "工位1-上视觉拍产品NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 1- Abnormal NG of the product captured by the upper visual camera",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 - Sản phẩm chụp trực quan NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1_上视觉拍产品NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22624, Source = "22624", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22624", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "125",
		DataDefine.KeyValue,"NameByCN", "工位2-下视觉拍标签-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Visual label shooting - NG abnormality",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 - Ghi nhãn trực quan dưới - NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_下视觉拍标签_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22625, Source = "22625", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22625", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "126",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍飞达-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper visual camera Feida NG abnormal",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 - Chụp ảnh trực quan lên - NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍飞达_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22626, Source = "22626", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22626", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "127",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品1-NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Upper Visual Photography Product 1-NG Abnormal",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 - Sản phẩm chụp ảnh trực quan 1-NG Bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品1_NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22627, Source = "22627", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22627", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "128",
		DataDefine.KeyValue,"NameByCN", "工位2-下视觉拍膜NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2- Abnormal visual film shooting NG",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 - Phim chụp tầm nhìn thấp NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_下视觉拍膜NG异常 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 22628, Source = "22628", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22628", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "129",
		DataDefine.KeyValue,"NameByCN", "工位2-上视觉拍产品2NG异常",
		DataDefine.KeyValue,"NameByEN", "Workstation 2-2NG abnormality in visual product shooting",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 - Sản phẩm chụp ảnh trực quan 2NG bất thường",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2_上视觉拍产品2NG异常 { get; set; }= new WordBool();

	#endregion

}