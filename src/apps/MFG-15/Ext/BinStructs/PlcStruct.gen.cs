
// GENERATE AT 2026/4/8 9:56:05
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "交互toPC_Part1", Source = "22000", Tags = "", Start = 22000, End = 22099, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPC_Part2", Source = "22100", Tags = "", Start = 22100, End = 22199, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPC_Part3", Source = "22200", Tags = "", Start = 22200, End = 22299, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPC_Part4", Source = "22300", Tags = "", Start = 22300, End = 22399, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPC_Part5", Source = "22400", Tags = "", Start = 22400, End = 22499, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPLC_Part1", Source = "21000", Tags = "", Start = 21000, End = 21099, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPLC_Part2", Source = "21100", Tags = "", Start = 21100, End = 21199, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPLC_Part3", Source = "21200", Tags = "", Start = 21200, End = 21299, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPLC_Part4", Source = "21300", Tags = "", Start = 21300, End = 21399, Points = ["*"])]
[BinaryPointGroup(Name = "交互toPLC_Part5", Source = "21400", Tags = "", Start = 21400, End = 21499, Points = ["*"])]
public partial class PlcStruct
{

	#region CSV INCLUDE POINTS: 交互信号PLC->PC

	[BinaryPoint(Offset = 22000, Source = "22000", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22000", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC心跳 { get; set; }

	[BinaryPoint(Offset = 22001, Source = "22001", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22001", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC状态 { get; set; }

	[BinaryPoint(Offset = 22002, Source = "22002", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22002", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC错误码 { get; set; }

	[BinaryPoint(Offset = 22003, Source = "22003", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22003", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 设备1状态 { get; set; }

	[BinaryPoint(Offset = 22004, Source = "22004", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22004", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 设备2状态 { get; set; }

	[BinaryPoint(Offset = 22205, Source = "22205", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22205", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 设备3状态 { get; set; }

	[BinaryPoint(Offset = 22010, Source = "22010", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22010", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC初始化使用的配方ID", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC当前配方ID { get; set; }

	[BinaryPoint(Offset = 22011, Source = "22011", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22011", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=已完成,0=无请求", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC配方写入PC地址响应 { get; set; }

	[BinaryPoint(Offset = 22015, Source = "22015", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22015", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=未上报,1=OK,2=NG,收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位1数据上报请求 { get; set; }

	[BinaryPoint(Offset = 22016, Source = "22016", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22016", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=未上报,1=OK,2=NG,收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位2数据上报请求 { get; set; }

	[BinaryPoint(Offset = 22020, Source = "22020", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22020", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发，收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 扫码枪1触发 { get; set; }

	[BinaryPoint(Offset = 22021, Source = "22021", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22021", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发，收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 扫码枪2触发 { get; set; }

	[BinaryPoint(Offset = 22025, Source = "22025", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22025", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发，收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 打印机1触发 { get; set; }

	[BinaryPoint(Offset = 22026, Source = "22026", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22026", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发，收到响应后复位", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 打印机2触发 { get; set; }

	[BinaryPoint(Offset = 22030, Source = "22030", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22030", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 相机1连接状态 { get; set; }

	[BinaryPoint(Offset = 22031, Source = "22031", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22031", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 相机2连接状态 { get; set; }

	[BinaryPoint(Offset = 22032, Source = "22032", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22032", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 相机3连接状态 { get; set; }

	[BinaryPoint(Offset = 22033, Source = "22033", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22033", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 相机4连接状态 { get; set; }

	[BinaryPoint(Offset = 22050, Source = "22050", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22050", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 已生产数量 { get; set; }

	[BinaryPoint(Offset = 22052, Source = "22052", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22052", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 良率 { get; set; }

	[BinaryPoint(Offset = 22054, Source = "22054", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22054", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "单位ms", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float CT { get; set; }

	[BinaryPoint(Offset = 22500, Source = "22500", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22500", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public bool[] 报警列表 { get; set; }

	[BinaryPoint(Offset = 22200, Source = "22200", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22200", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder1料号 { get; set; }

	[BinaryPoint(Offset = 22202, Source = "22202", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22202", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder1物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22204, Source = "22204", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22204", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder1物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22206, Source = "22206", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22206", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder1抛料率 { get; set; }

	[BinaryPoint(Offset = 22208, Source = "22208", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22208", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder1解锁响应 { get; set; }

	[BinaryPoint(Offset = 22209, Source = "22209", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22209", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder1换料响应 { get; set; }

	[BinaryPoint(Offset = 22220, Source = "22220", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22220", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder2料号 { get; set; }

	[BinaryPoint(Offset = 22222, Source = "22222", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22222", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder2物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22224, Source = "22224", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22224", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder2物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22226, Source = "22226", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22226", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder2抛料率 { get; set; }

	[BinaryPoint(Offset = 22228, Source = "22228", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22228", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder2解锁响应 { get; set; }

	[BinaryPoint(Offset = 22229, Source = "22229", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22229", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder2换料响应 { get; set; }

	[BinaryPoint(Offset = 22240, Source = "22240", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22240", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder3料号 { get; set; }

	[BinaryPoint(Offset = 22242, Source = "22242", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22242", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder3物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22244, Source = "22244", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22244", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder3物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22246, Source = "22246", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22246", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder3抛料率 { get; set; }

	[BinaryPoint(Offset = 22248, Source = "22248", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22248", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder3解锁响应 { get; set; }

	[BinaryPoint(Offset = 22249, Source = "22249", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22249", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder3换料响应 { get; set; }

	[BinaryPoint(Offset = 22260, Source = "22260", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22260", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder4料号 { get; set; }

	[BinaryPoint(Offset = 22262, Source = "22262", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22262", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder4物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22264, Source = "22264", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22264", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder4物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22266, Source = "22266", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22266", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder4抛料率 { get; set; }

	[BinaryPoint(Offset = 22268, Source = "22268", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22268", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder4解锁响应 { get; set; }

	[BinaryPoint(Offset = 22269, Source = "22269", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22269", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder4换料响应 { get; set; }

	[BinaryPoint(Offset = 22280, Source = "22280", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22280", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder5料号 { get; set; }

	[BinaryPoint(Offset = 22282, Source = "22282", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22282", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder5物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22284, Source = "22284", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22284", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder5物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22286, Source = "22286", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22286", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder5抛料率 { get; set; }

	[BinaryPoint(Offset = 22288, Source = "22288", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22288", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder5解锁响应 { get; set; }

	[BinaryPoint(Offset = 22289, Source = "22289", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22289", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder5换料响应 { get; set; }

	[BinaryPoint(Offset = 22300, Source = "22300", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22300", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder6料号 { get; set; }

	[BinaryPoint(Offset = 22302, Source = "22302", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22302", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder6物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22304, Source = "22304", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22304", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder6物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22306, Source = "22306", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22306", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float Feeder6抛料率 { get; set; }

	[BinaryPoint(Offset = 22308, Source = "22308", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22308", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder6解锁响应 { get; set; }

	[BinaryPoint(Offset = 22309, Source = "22309", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22309", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder6换料响应 { get; set; }

	[BinaryPoint(Offset = 22400, Source = "22400", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22400", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头1料号 { get; set; }

	[BinaryPoint(Offset = 22402, Source = "22402", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22402", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头1良率 { get; set; }

	[BinaryPoint(Offset = 22410, Source = "22410", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22410", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头2料号 { get; set; }

	[BinaryPoint(Offset = 22412, Source = "22412", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22412", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头2良率 { get; set; }

	[BinaryPoint(Offset = 22414, Source = "22414", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22414", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=配方ID切换成功,0=无请求", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC读取配方ID切换成功响应 { get; set; }

	[BinaryPoint(Offset = 22420, Source = "22420", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22420", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头3料号 { get; set; }

	[BinaryPoint(Offset = 22422, Source = "22422", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22422", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头3良率 { get; set; }

	[BinaryPoint(Offset = 22430, Source = "22430", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22430", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头4料号 { get; set; }

	[BinaryPoint(Offset = 22432, Source = "22432", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22432", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头4良率 { get; set; }

	[BinaryPoint(Offset = 22440, Source = "22440", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22440", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头5料号 { get; set; }

	[BinaryPoint(Offset = 22442, Source = "22442", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22442", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头5良率 { get; set; }

	[BinaryPoint(Offset = 22450, Source = "22450", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22450", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头6料号 { get; set; }

	[BinaryPoint(Offset = 22452, Source = "22452", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22452", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头6良率 { get; set; }

	[BinaryPoint(Offset = 22460, Source = "22460", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22460", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头7料号 { get; set; }

	[BinaryPoint(Offset = 22462, Source = "22462", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22462", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头7良率 { get; set; }

	[BinaryPoint(Offset = 22470, Source = "22470", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22470", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头8料号 { get; set; }

	[BinaryPoint(Offset = 22472, Source = "22472", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22472", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头8良率 { get; set; }

	[BinaryPoint(Offset = 22480, Source = "22480", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22480", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头9料号 { get; set; }

	[BinaryPoint(Offset = 22482, Source = "22482", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22482", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头9良率 { get; set; }

	[BinaryPoint(Offset = 22490, Source = "22490", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22490", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头10料号 { get; set; }

	[BinaryPoint(Offset = 22492, Source = "22492", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22492", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public float 吸头10良率 { get; set; }

	#endregion

	#region CSV INCLUDE POINTS: 交互信号PC->PLC

	[BinaryPoint(Offset = 21000, Source = "21000", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21000", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0-1跳变 1S间隔", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 上位机心跳 { get; set; }

	[BinaryPoint(Offset = 21001, Source = "21001", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21001", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=就绪，2=故障", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 上位机状态 { get; set; }

	[BinaryPoint(Offset = 21002, Source = "21002", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21002", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=扫码枪未连接,2=MES未连接 ,3=IOT未连接,4=EAP未连接,5=打印机未连接", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public long 上位机错误码 { get; set; }

	[BinaryPoint(Offset = 21005, Source = "21005", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21005", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位1允许生产 { get; set; }

	[BinaryPoint(Offset = 21006, Source = "21006", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21006", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位2允许生产 { get; set; }

	[BinaryPoint(Offset = 21010, Source = "21010", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21010", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "上位机下发到PLC的配方ID", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 上位机当前配方ID { get; set; }

	[BinaryPoint(Offset = 21011, Source = "21011", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21011", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=请求,0=无请求", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PLC配方写入PC地址请求 { get; set; }

	[BinaryPoint(Offset = 21015, Source = "21015", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21015", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位1数据上报响应 { get; set; }

	[BinaryPoint(Offset = 21016, Source = "21016", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21016", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 工位2数据上报响应 { get; set; }

	[BinaryPoint(Offset = 21020, Source = "21020", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21020", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 扫码枪1触发结果 { get; set; }

	[BinaryPoint(Offset = 21021, Source = "21021", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21021", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 扫码枪2触发结果 { get; set; }

	[BinaryPoint(Offset = 21025, Source = "21025", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21025", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 打印机1触发结果 { get; set; }

	[BinaryPoint(Offset = 21026, Source = "21026", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21026", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short 打印机2触发结果 { get; set; }

	[BinaryPoint(Offset = 21100, Source = "21100", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21100", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public byte[] 工单号PC下发 { get; set; }

	[BinaryPoint(Offset = 21140, Source = "21140", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21140", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public byte[] 工号PC下发 { get; set; }

	[BinaryPoint(Offset = 21200, Source = "21200", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21200", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder1PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21202, Source = "21202", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21202", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder1PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21208, Source = "21208", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21208", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder1解锁请求 { get; set; }

	[BinaryPoint(Offset = 21209, Source = "21209", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21209", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder1换料请求 { get; set; }

	[BinaryPoint(Offset = 21220, Source = "21220", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21220", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder2PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21222, Source = "21222", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21222", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder2PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21228, Source = "21228", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21228", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder2解锁请求 { get; set; }

	[BinaryPoint(Offset = 21229, Source = "21229", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21229", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder2换料请求 { get; set; }

	[BinaryPoint(Offset = 21230, Source = "21230", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21230", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=配方写入完成,0=无请求", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short PC配方写入完成信号 { get; set; }

	[BinaryPoint(Offset = 21240, Source = "21240", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21240", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder3PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21242, Source = "21242", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21242", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder3PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21248, Source = "21248", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21248", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder3解锁请求 { get; set; }

	[BinaryPoint(Offset = 21249, Source = "21249", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21249", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder3换料请求 { get; set; }

	[BinaryPoint(Offset = 21260, Source = "21260", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21260", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder4PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21262, Source = "21262", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21262", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder4PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21268, Source = "21268", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21268", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder4解锁请求 { get; set; }

	[BinaryPoint(Offset = 21269, Source = "21269", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21269", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder4换料请求 { get; set; }

	[BinaryPoint(Offset = 21280, Source = "21280", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21280", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder5PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21282, Source = "21282", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21282", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder5PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21288, Source = "21288", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21288", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder5解锁请求 { get; set; }

	[BinaryPoint(Offset = 21289, Source = "21289", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21289", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder5换料请求 { get; set; }

	[BinaryPoint(Offset = 21300, Source = "21300", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21300", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder6PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21302, Source = "21302", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21302", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int Feeder6PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21308, Source = "21308", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21308", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder6解锁请求 { get; set; }

	[BinaryPoint(Offset = 21309, Source = "21309", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21309", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public short Feeder6换料请求 { get; set; }

	[BinaryPoint(Offset = 21400, Source = "21400", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21400", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头1PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21410, Source = "21410", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21410", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头2PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21420, Source = "21420", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21420", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头3PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21430, Source = "21430", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21430", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头4PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21440, Source = "21440", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21440", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头5PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21450, Source = "21450", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21450", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头6PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21460, Source = "21460", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21460", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头7PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21470, Source = "21470", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21470", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头8PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21480, Source = "21480", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21480", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头9PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21490, Source = "21490", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21490", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "",
		DataDefine.KeyValue,"NameByEN", "",
		DataDefine.KeyValue,"NameByVI", "", ])]
	public int 吸头10PC下发料号 { get; set; }

	#endregion

}
