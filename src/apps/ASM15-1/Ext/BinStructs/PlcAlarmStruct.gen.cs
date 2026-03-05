
// GENERATE AT 2026/3/5 17:59:26
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "Part1", Source = "6100", Tags = "WordBool", Start = 6100, End = 6200, Points = ["*"])]
public partial class PlcAlarmStruct
{

	#region CSV INCLUDE POINTS: 报警

	[BinaryPoint(Offset = 6100, Source = "6100", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6100", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "1",
		DataDefine.KeyValue,"NameByCN", "Z1轴M1指令报错",
		DataDefine.KeyValue,"NameByEN", "Z1 axis M1 command error",
		DataDefine.KeyValue,"NameByVI", "Z1 trục M1 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴M1指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6101, Source = "6101", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6101", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "Z2轴M2指令报错",
		DataDefine.KeyValue,"NameByEN", "Z2 axis M2 command error",
		DataDefine.KeyValue,"NameByVI", "Z2 trục M2 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴M2指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6102, Source = "6102", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6102", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "X1轴M3指令报错",
		DataDefine.KeyValue,"NameByEN", "X1 axis M3 command error",
		DataDefine.KeyValue,"NameByVI", "X1 trục M3 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴M3指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6103, Source = "6103", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6103", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "X2轴M4指令报错",
		DataDefine.KeyValue,"NameByEN", "X2 axis M4 command error",
		DataDefine.KeyValue,"NameByVI", "X2 trục M4 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴M4指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6104, Source = "6104", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6104", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "Y1轴M5指令报错",
		DataDefine.KeyValue,"NameByEN", "Y1 axis M5 command error",
		DataDefine.KeyValue,"NameByVI", "Y1 trục M5 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴M5指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6105, Source = "6105", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6105", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "Y2轴M6指令报错",
		DataDefine.KeyValue,"NameByEN", "Y2 axis M6 command error",
		DataDefine.KeyValue,"NameByVI", "Y2 trục M6 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴M6指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6106, Source = "6106", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6106", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴M7指令报错",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis M7 command error",
		DataDefine.KeyValue,"NameByVI", "Bước Z1 trục M7 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴M7指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6107, Source = "6107", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6107", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴M8指令报错",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis M8 command error",
		DataDefine.KeyValue,"NameByVI", "Bước Z2 trục M8 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴M8指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6108, Source = "6108", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6108", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴M9指令报错",
		DataDefine.KeyValue,"NameByEN", "GuGao Y1 axis M9 command error",
		DataDefine.KeyValue,"NameByVI", "Độ cao cố định Y1 trục M9 lệnh báo lỗi",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴M9指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6109, Source = "6109", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6109", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴M10指令报错",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y2 axis M10 command error",
		DataDefine.KeyValue,"NameByVI", "Độ cao cố định Trục Y2 M10 Lỗi lệnh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴M10指令报错 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6110, Source = "6110", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6110", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "升降Z1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Lifting Z1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Thang máy trục Z1 không cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 升降Z1轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6111, Source = "6111", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6111", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "Z1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh trục Z1 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6112, Source = "6112", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6112", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "Z1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Z1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6113, Source = "6113", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6113", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "Z1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Z1 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6114, Source = "6114", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6114", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "Z2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh Jog trục Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6115, Source = "6115", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6115", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "Z2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6116, Source = "6116", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6116", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "Z2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Z2 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6117, Source = "6117", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6117", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "升降Z2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Lifting Z2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Nâng trục Z2 không cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 升降Z2轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6118, Source = "6118", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6118", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "X1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh Jog trục X1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6119, Source = "6119", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6119", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "X1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục X1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6120, Source = "6120", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6120", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "X1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "X1 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6121, Source = "6121", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6121", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "X1轴未使能",
		DataDefine.KeyValue,"NameByEN", "X1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Trục X1 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6122, Source = "6122", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6122", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "X2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh Jog trục X2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6123, Source = "6123", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6123", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "X2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục X2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6124, Source = "6124", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6124", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "X2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "X2 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6125, Source = "6125", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6125", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "X2轴未使能",
		DataDefine.KeyValue,"NameByEN", "X2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Trục X2 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6126, Source = "6126", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6126", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "Y1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh trục Y1 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6127, Source = "6127", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6127", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "Y1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Y1 cố định",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6128, Source = "6128", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6128", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "Y1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Y1 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6129, Source = "6129", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6129", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "Y1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6130, Source = "6130", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6130", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "Y2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh trục Y2 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6131, Source = "6131", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6131", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "Y2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Y2 cố định",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6132, Source = "6132", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6132", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "Y2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Y2 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6133, Source = "6133", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6133", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "Y2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6134, Source = "6134", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6134", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Bước Z1 trục Jog báo động an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6135, Source = "6135", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6135", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Bước báo động an ninh PTP trục Z1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6136, Source = "6136", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6136", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Bước Z1 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6137, Source = "6137", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6137", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Bước Z1 trục không cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6138, Source = "6138", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6138", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Bước Z2 trục Jog báo động an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6139, Source = "6139", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6139", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Bước báo động an ninh PTP trục Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6140, Source = "6140", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6140", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Bước Z2 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6141, Source = "6141", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6141", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Bước Z2 trục không cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6142, Source = "6142", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6142", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Gogao Y1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Chiều cao cố định Y1 trục Jog báo động an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6143, Source = "6143", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6143", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "GuGao Y1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Y1 cố định",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6144, Source = "6144", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6144", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Độ cao cố định Y1 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6145, Source = "6145", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6145", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Fixed height Y1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Chiều cao cố định trục Y1 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6146, Source = "6146", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6146", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Gogao Y2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Chiều cao cố định Y2 trục Jog báo động an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴Jog安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6147, Source = "6147", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6147", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "GuGao Y2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo động an ninh PTP trục Y2 cố định",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴PTP安全报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6148, Source = "6148", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6148", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Độ cao cố định Y2 tay trục tự động báo động không nhất quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴手自动不一致报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6149, Source = "6149", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6149", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Fixed height Y2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Chiều cao cố định trục Y2 không được kích hoạt",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴未使能 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6150, Source = "6150", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6150", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Định vị xi lanh 1 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6151, Source = "6151", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6151", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1 Định vị xi lanh 1 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6152, Source = "6152", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6152", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Định vị xi lanh 2 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6153, Source = "6153", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6153", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1 Định vị xi lanh 2 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6154, Source = "6154", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6154", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 3 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Định vị xi lanh 3 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6155, Source = "6155", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6155", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 3 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1 Định vị xi lanh 3 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6156, Source = "6156", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6156", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 4 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Định vị xi lanh 4 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6157, Source = "6157", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6157", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 4 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 1 Định vị xi lanh 4 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6158, Source = "6158", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6158", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Định vị xi lanh 1 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6159, Source = "6159", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6159", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2 Định vị xi lanh 1 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6160, Source = "6160", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6160", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Định vị xi lanh 2 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6161, Source = "6161", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6161", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2 Định vị xi lanh 2 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6162, Source = "6162", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6162", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 3 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Định vị xi lanh 3 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6163, Source = "6163", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6163", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 3 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2 Định vị xi lanh 3 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6164, Source = "6164", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6164", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 4 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Định vị xi lanh 4 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6165, Source = "6165", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6165", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 4 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ăn trục 2 Định vị xi lanh 4 báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6166, Source = "6166", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6166", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nâng hàng loạt điện 1 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6167, Source = "6167", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6167", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nâng hàng loạt điện 1 Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6168, Source = "6168", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6168", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nâng hàng loạt điện 2 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6169, Source = "6169", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6169", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nâng hàng loạt điện 2 Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6170, Source = "6170", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6170", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh định vị đĩa vật liệu 1 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6171, Source = "6171", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6171", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh định vị đĩa vật liệu 1 Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6172, Source = "6172", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6172", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh định vị đĩa vật liệu 2 Báo động tại chỗ",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6173, Source = "6173", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6173", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh định vị đĩa vật liệu 2 Báo động vị trí làm việc",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6174, Source = "6174", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6174", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Product pressure cylinder in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Báo động tại chỗ cho xi lanh áp suất thấp của sản phẩm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6175, Source = "6175", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6175", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Product pressure cylinder working position alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 1 Sản phẩm báo động vị trí làm việc xi lanh áp suất thấp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6176, Source = "6176", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6176", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Product pressure cylinder in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Báo động tại chỗ cho xi lanh áp suất thấp của sản phẩm",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸原位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6177, Source = "6177", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6177", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Product pressure cylinder working position alarm",
		DataDefine.KeyValue,"NameByVI", "Trục cho ăn 2 Sản phẩm báo động vị trí làm việc xi lanh áp suất thấp",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸工作位报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6178, Source = "6178", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6178", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "工位1吸真空报警",
		DataDefine.KeyValue,"NameByEN", "Workstation 1 vacuum suction alarm",
		DataDefine.KeyValue,"NameByVI", "Trạm 1 báo động hút chân không",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1吸真空报警 { get; set; }= new WordBool();

	[BinaryPoint(Offset = 6179, Source = "6179", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:6179", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "工位2吸真空报警",
		DataDefine.KeyValue,"NameByEN", "Workstation 2 vacuum suction alarm",
		DataDefine.KeyValue,"NameByVI", "Trạm 2 báo động hút chân không",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2吸真空报警 { get; set; }= new WordBool();

	#endregion

}