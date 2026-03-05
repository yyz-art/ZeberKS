
// GENERATE AT 2026/3/4 17:17:07
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "Part1", Source = "46100", Tags = "WordBool", Start = 46100, End = 46199, Points = ["*"])]
public partial class PlcAlarmStruct
{

	#region CSV INCLUDE POINTS: 报警

	[BinaryPoint(Offset = 46100, Source = "46100", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46100", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "1",
		DataDefine.KeyValue,"NameByCN", "Z1轴M1指令报错",
		DataDefine.KeyValue,"NameByEN", "Z1 axis M1 command error",
		DataDefine.KeyValue,"NameByVI", "Z1 tr?c M1 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴M1指令报错 { get; set; }

	[BinaryPoint(Offset = 46101, Source = "46101", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46101", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "2",
		DataDefine.KeyValue,"NameByCN", "Z2轴M2指令报错",
		DataDefine.KeyValue,"NameByEN", "Z2 axis M2 command error",
		DataDefine.KeyValue,"NameByVI", "Z2 tr?c M2 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴M2指令报错 { get; set; }

	[BinaryPoint(Offset = 46102, Source = "46102", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46102", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "3",
		DataDefine.KeyValue,"NameByCN", "X1轴M3指令报错",
		DataDefine.KeyValue,"NameByEN", "X1 axis M3 command error",
		DataDefine.KeyValue,"NameByVI", "X1 tr?c M3 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴M3指令报错 { get; set; }

	[BinaryPoint(Offset = 46103, Source = "46103", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46103", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "4",
		DataDefine.KeyValue,"NameByCN", "X2轴M4指令报错",
		DataDefine.KeyValue,"NameByEN", "X2 axis M4 command error",
		DataDefine.KeyValue,"NameByVI", "X2 tr?c M4 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴M4指令报错 { get; set; }

	[BinaryPoint(Offset = 46104, Source = "46104", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46104", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "5",
		DataDefine.KeyValue,"NameByCN", "Y1轴M5指令报错",
		DataDefine.KeyValue,"NameByEN", "Y1 axis M5 command error",
		DataDefine.KeyValue,"NameByVI", "Y1 tr?c M5 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴M5指令报错 { get; set; }

	[BinaryPoint(Offset = 46105, Source = "46105", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46105", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "6",
		DataDefine.KeyValue,"NameByCN", "Y2轴M6指令报错",
		DataDefine.KeyValue,"NameByEN", "Y2 axis M6 command error",
		DataDefine.KeyValue,"NameByVI", "Y2 tr?c M6 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴M6指令报错 { get; set; }

	[BinaryPoint(Offset = 46106, Source = "46106", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46106", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "7",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴M7指令报错",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis M7 command error",
		DataDefine.KeyValue,"NameByVI", "B??c Z1 tr?c M7 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴M7指令报错 { get; set; }

	[BinaryPoint(Offset = 46107, Source = "46107", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46107", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "8",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴M8指令报错",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis M8 command error",
		DataDefine.KeyValue,"NameByVI", "B??c Z2 tr?c M8 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴M8指令报错 { get; set; }

	[BinaryPoint(Offset = 46108, Source = "46108", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46108", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "9",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴M9指令报错",
		DataDefine.KeyValue,"NameByEN", "GuGao Y1 axis M9 command error",
		DataDefine.KeyValue,"NameByVI", "?? cao c? ??nh Y1 tr?c M9 l?nh báo l?i",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴M9指令报错 { get; set; }

	[BinaryPoint(Offset = 46109, Source = "46109", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46109", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "10",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴M10指令报错",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y2 axis M10 command error",
		DataDefine.KeyValue,"NameByVI", "?? cao c? ??nh Tr?c Y2 M10 L?i l?nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴M10指令报错 { get; set; }

	[BinaryPoint(Offset = 46110, Source = "46110", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46110", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "11",
		DataDefine.KeyValue,"NameByCN", "升降Z1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Lifting Z1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Thang máy tr?c Z1 kh?ng cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 升降Z1轴未使能 { get; set; }

	[BinaryPoint(Offset = 46111, Source = "46111", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46111", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "12",
		DataDefine.KeyValue,"NameByCN", "Z1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh tr?c Z1 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46112, Source = "46112", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46112", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "13",
		DataDefine.KeyValue,"NameByCN", "Z1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Z1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46113, Source = "46113", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46113", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "14",
		DataDefine.KeyValue,"NameByCN", "Z1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Z1 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Z1 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z1轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46114, Source = "46114", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46114", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "15",
		DataDefine.KeyValue,"NameByCN", "Z2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh Jog tr?c Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46115, Source = "46115", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46115", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "16",
		DataDefine.KeyValue,"NameByCN", "Z2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46116, Source = "46116", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46116", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "17",
		DataDefine.KeyValue,"NameByCN", "Z2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Z2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Z2 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Z2轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46117, Source = "46117", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46117", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "18",
		DataDefine.KeyValue,"NameByCN", "升降Z2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Lifting Z2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Nang tr?c Z2 kh?ng cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 升降Z2轴未使能 { get; set; }

	[BinaryPoint(Offset = 46118, Source = "46118", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46118", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "19",
		DataDefine.KeyValue,"NameByCN", "X1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh Jog tr?c X1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46119, Source = "46119", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46119", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "20",
		DataDefine.KeyValue,"NameByCN", "X1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c X1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46120, Source = "46120", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46120", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "21",
		DataDefine.KeyValue,"NameByCN", "X1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "X1 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46121, Source = "46121", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46121", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "22",
		DataDefine.KeyValue,"NameByCN", "X1轴未使能",
		DataDefine.KeyValue,"NameByEN", "X1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Tr?c X1 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X1轴未使能 { get; set; }

	[BinaryPoint(Offset = 46122, Source = "46122", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46122", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "23",
		DataDefine.KeyValue,"NameByCN", "X2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh Jog tr?c X2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46123, Source = "46123", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46123", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "24",
		DataDefine.KeyValue,"NameByCN", "X2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c X2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46124, Source = "46124", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46124", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "25",
		DataDefine.KeyValue,"NameByCN", "X2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "X2 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "X2 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46125, Source = "46125", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46125", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "26",
		DataDefine.KeyValue,"NameByCN", "X2轴未使能",
		DataDefine.KeyValue,"NameByEN", "X2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Tr?c X2 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool X2轴未使能 { get; set; }

	[BinaryPoint(Offset = 46126, Source = "46126", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46126", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "27",
		DataDefine.KeyValue,"NameByCN", "Y1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh tr?c Y1 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46127, Source = "46127", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46127", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "28",
		DataDefine.KeyValue,"NameByCN", "Y1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Y1 c? ??nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46128, Source = "46128", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46128", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "29",
		DataDefine.KeyValue,"NameByCN", "Y1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Y1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Y1 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46129, Source = "46129", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46129", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "30",
		DataDefine.KeyValue,"NameByCN", "Y1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y1 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y1轴未使能 { get; set; }

	[BinaryPoint(Offset = 46130, Source = "46130", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46130", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "31",
		DataDefine.KeyValue,"NameByCN", "Y2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh tr?c Y2 Jog",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46131, Source = "46131", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46131", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "32",
		DataDefine.KeyValue,"NameByCN", "Y2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Y2 c? ??nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46132, Source = "46132", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46132", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "33",
		DataDefine.KeyValue,"NameByCN", "Y2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Y2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "Y2 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46133, Source = "46133", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46133", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "34",
		DataDefine.KeyValue,"NameByCN", "Y2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Y2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Tr?c Y2 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool Y2轴未使能 { get; set; }

	[BinaryPoint(Offset = 46134, Source = "46134", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46134", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "35",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "B??c Z1 tr?c Jog báo ??ng an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46135, Source = "46135", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46135", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "36",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "B??c báo ??ng an ninh PTP tr?c Z1",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46136, Source = "46136", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46136", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "37",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "B??c Z1 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46137, Source = "46137", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46137", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "38",
		DataDefine.KeyValue,"NameByCN", "步进Z1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Step Z1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "B??c Z1 tr?c kh?ng cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z1轴未使能 { get; set; }

	[BinaryPoint(Offset = 46138, Source = "46138", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46138", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "39",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "B??c Z2 tr?c Jog báo ??ng an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46139, Source = "46139", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46139", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "40",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "B??c báo ??ng an ninh PTP tr?c Z2",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46140, Source = "46140", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46140", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "41",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "B??c Z2 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46141, Source = "46141", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46141", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "42",
		DataDefine.KeyValue,"NameByCN", "步进Z2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Step Z2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "B??c Z2 tr?c kh?ng cho phép",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 步进Z2轴未使能 { get; set; }

	[BinaryPoint(Offset = 46142, Source = "46142", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46142", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "43",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Gogao Y1 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Chi?u cao c? ??nh Y1 tr?c Jog báo ??ng an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46143, Source = "46143", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46143", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "44",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "GuGao Y1 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Y1 c? ??nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46144, Source = "46144", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46144", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "45",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y1 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "?? cao c? ??nh Y1 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46145, Source = "46145", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46145", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "46",
		DataDefine.KeyValue,"NameByCN", "固高Y1轴未使能",
		DataDefine.KeyValue,"NameByEN", "Fixed height Y1 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Chi?u cao c? ??nh tr?c Y1 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y1轴未使能 { get; set; }

	[BinaryPoint(Offset = 46146, Source = "46146", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46146", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "47",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴Jog安全报警",
		DataDefine.KeyValue,"NameByEN", "Gogao Y2 axis Jog safety alarm",
		DataDefine.KeyValue,"NameByVI", "Chi?u cao c? ??nh Y2 tr?c Jog báo ??ng an ninh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴Jog安全报警 { get; set; }

	[BinaryPoint(Offset = 46147, Source = "46147", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46147", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "48",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴PTP安全报警",
		DataDefine.KeyValue,"NameByEN", "GuGao Y2 axis PTP safety alarm",
		DataDefine.KeyValue,"NameByVI", "Báo ??ng an ninh PTP tr?c Y2 c? ??nh",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴PTP安全报警 { get; set; }

	[BinaryPoint(Offset = 46148, Source = "46148", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46148", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "49",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴手自动不一致报警",
		DataDefine.KeyValue,"NameByEN", "Gu Gao Y2 axis manual automatic inconsistency alarm",
		DataDefine.KeyValue,"NameByVI", "?? cao c? ??nh Y2 tay tr?c t? ??ng báo ??ng kh?ng nh?t quán",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴手自动不一致报警 { get; set; }

	[BinaryPoint(Offset = 46149, Source = "46149", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46149", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "50",
		DataDefine.KeyValue,"NameByCN", "固高Y2轴未使能",
		DataDefine.KeyValue,"NameByEN", "Fixed height Y2 axis not enabled",
		DataDefine.KeyValue,"NameByVI", "Chi?u cao c? ??nh tr?c Y2 kh?ng ???c kích ho?t",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 固高Y2轴未使能 { get; set; }

	[BinaryPoint(Offset = 46150, Source = "46150", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46150", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "51",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 ??nh v? xi lanh 1 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1原位报警 { get; set; }

	[BinaryPoint(Offset = 46151, Source = "46151", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46151", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "52",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1 ??nh v? xi lanh 1 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸1工作位报警 { get; set; }

	[BinaryPoint(Offset = 46152, Source = "46152", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46152", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "53",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 ??nh v? xi lanh 2 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2原位报警 { get; set; }

	[BinaryPoint(Offset = 46153, Source = "46153", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46153", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "54",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1 ??nh v? xi lanh 2 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸2工作位报警 { get; set; }

	[BinaryPoint(Offset = 46154, Source = "46154", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46154", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "55",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 3 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 ??nh v? xi lanh 3 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3原位报警 { get; set; }

	[BinaryPoint(Offset = 46155, Source = "46155", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46155", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "56",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 3 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1 ??nh v? xi lanh 3 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸3工作位报警 { get; set; }

	[BinaryPoint(Offset = 46156, Source = "46156", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46156", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "57",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 4 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 ??nh v? xi lanh 4 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4原位报警 { get; set; }

	[BinaryPoint(Offset = 46157, Source = "46157", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46157", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "58",
		DataDefine.KeyValue,"NameByCN", "上料轴1_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 1_positioning cylinder 4 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 1 ??nh v? xi lanh 4 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_定位气缸4工作位报警 { get; set; }

	[BinaryPoint(Offset = 46158, Source = "46158", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46158", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "59",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 ??nh v? xi lanh 1 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1原位报警 { get; set; }

	[BinaryPoint(Offset = 46159, Source = "46159", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46159", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "60",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2 ??nh v? xi lanh 1 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸1工作位报警 { get; set; }

	[BinaryPoint(Offset = 46160, Source = "46160", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46160", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "61",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 ??nh v? xi lanh 2 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2原位报警 { get; set; }

	[BinaryPoint(Offset = 46161, Source = "46161", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46161", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "62",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2 ??nh v? xi lanh 2 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸2工作位报警 { get; set; }

	[BinaryPoint(Offset = 46162, Source = "46162", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46162", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "63",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 3 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 ??nh v? xi lanh 3 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3原位报警 { get; set; }

	[BinaryPoint(Offset = 46163, Source = "46163", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46163", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "64",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸3工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 3 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2 ??nh v? xi lanh 3 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸3工作位报警 { get; set; }

	[BinaryPoint(Offset = 46164, Source = "46164", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46164", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "65",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 4 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 ??nh v? xi lanh 4 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4原位报警 { get; set; }

	[BinaryPoint(Offset = 46165, Source = "46165", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46165", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "66",
		DataDefine.KeyValue,"NameByCN", "上料轴2_定位气缸4工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading axis 2_positioning cylinder 4 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Cho ?n tr?c 2 ??nh v? xi lanh 4 báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_定位气缸4工作位报警 { get; set; }

	[BinaryPoint(Offset = 46166, Source = "46166", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46166", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "67",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nang hàng lo?t ?i?n 1 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1原位报警 { get; set; }

	[BinaryPoint(Offset = 46167, Source = "46167", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46167", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "68",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nang hàng lo?t ?i?n 1 Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸1工作位报警 { get; set; }

	[BinaryPoint(Offset = 46168, Source = "46168", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46168", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "69",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nang hàng lo?t ?i?n 2 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2原位报警 { get; set; }

	[BinaryPoint(Offset = 46169, Source = "46169", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46169", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "70",
		DataDefine.KeyValue,"NameByCN", "电批升降气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Electric lift cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Xi lanh nang hàng lo?t ?i?n 2 Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 电批升降气缸2工作位报警 { get; set; }

	[BinaryPoint(Offset = 46170, Source = "46170", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46170", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "71",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1原位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 1 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh ??nh v? ??a v?t li?u 1 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1原位报警 { get; set; }

	[BinaryPoint(Offset = 46171, Source = "46171", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46171", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "72",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸1工作位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 1 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh ??nh v? ??a v?t li?u 1 Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸1工作位报警 { get; set; }

	[BinaryPoint(Offset = 46172, Source = "46172", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46172", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "73",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2原位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 2 in situ alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh ??nh v? ??a v?t li?u 2 Báo ??ng t?i ch?",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2原位报警 { get; set; }

	[BinaryPoint(Offset = 46173, Source = "46173", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46173", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "74",
		DataDefine.KeyValue,"NameByCN", "螺丝机1_料盘定位气缸2工作位报警",
		DataDefine.KeyValue,"NameByEN", "Screw machine 1_material tray positioning cylinder 2 working position alarm",
		DataDefine.KeyValue,"NameByVI", "Máy vít 1 Xi lanh ??nh v? ??a v?t li?u 2 Báo ??ng v? trí làm vi?c",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 螺丝机1_料盘定位气缸2工作位报警 { get; set; }

	[BinaryPoint(Offset = 46174, Source = "46174", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46174", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "75",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Product pressure cylinder in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 Báo ??ng t?i ch? cho xi lanh áp su?t th?p c?a s?n ph?m",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸原位报警 { get; set; }

	[BinaryPoint(Offset = 46175, Source = "46175", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46175", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "76",
		DataDefine.KeyValue,"NameByCN", "上料轴1_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 1_Product pressure cylinder working position alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 1 S?n ph?m báo ??ng v? trí làm vi?c xi lanh áp su?t th?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴1_产品下压气缸工作位报警 { get; set; }

	[BinaryPoint(Offset = 46176, Source = "46176", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46176", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "77",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸原位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Product pressure cylinder in-situ alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 Báo ??ng t?i ch? cho xi lanh áp su?t th?p c?a s?n ph?m",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸原位报警 { get; set; }

	[BinaryPoint(Offset = 46177, Source = "46177", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46177", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "78",
		DataDefine.KeyValue,"NameByCN", "上料轴2_产品下压气缸工作位报警",
		DataDefine.KeyValue,"NameByEN", "Loading shaft 2_Product pressure cylinder working position alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?c cho ?n 2 S?n ph?m báo ??ng v? trí làm vi?c xi lanh áp su?t th?p",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 上料轴2_产品下压气缸工作位报警 { get; set; }

	[BinaryPoint(Offset = 46178, Source = "46178", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46178", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "79",
		DataDefine.KeyValue,"NameByCN", "工位1吸真空报警",
		DataDefine.KeyValue,"NameByEN", "Workstation 1 vacuum suction alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?m 1 báo ??ng hút chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位1吸真空报警 { get; set; }

	[BinaryPoint(Offset = 46179, Source = "46179", Tags = "WordBool", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:46179", Category = "Alarm", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"Id", "80",
		DataDefine.KeyValue,"NameByCN", "工位2吸真空报警",
		DataDefine.KeyValue,"NameByEN", "Workstation 2 vacuum suction alarm",
		DataDefine.KeyValue,"NameByVI", "Tr?m 2 báo ??ng hút chan kh?ng",
		DataDefine.KeyValue,"TipMessage", "", ])]
	public partial WordBool 工位2吸真空报警 { get; set; }

	#endregion

}