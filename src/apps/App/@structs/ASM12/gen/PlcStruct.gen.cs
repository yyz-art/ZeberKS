
// GENERATE AT 2026/7/9 11:59:06
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;
using ZC.BinStructs1;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "PlcToPc", Source = "22000", Tags = "", Start = 22000, End = 22999, Points = ["*"])]
[BinaryPointGroup(Name = "PcToPlc", Source = "21000", Tags = "", Start = 21000, End = 21999, Points = ["*"])]
public partial class PlcStruct
{

	#region CSV INCLUDE POINTS: 交互信号PLC->PC

	[BinaryPoint(Offset = 22000, Source = "22000", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22000", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC心跳 { get; set; }

	[BinaryPoint(Offset = 22001, Source = "22001", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22001", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC状态 { get; set; }

	[BinaryPoint(Offset = 22002, Source = "22002", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22002", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC错误码 { get; set; }

	[BinaryPoint(Offset = 22003, Source = "22003", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22003", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1状态 { get; set; }

	[BinaryPoint(Offset = 22004, Source = "22004", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22004", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2状态 { get; set; }

	[BinaryPoint(Offset = 22010, Source = "22010", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22010", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC当前配方ID { get; set; }

	[BinaryPoint(Offset = 22011, Source = "22011", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22011", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 配方上报响应 { get; set; }

	[BinaryPoint(Offset = 22012, Source = "22012", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22012", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 配方下发响应 { get; set; }

	[BinaryPoint(Offset = 22015, Source = "22015", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22015", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1数据上报请求 { get; set; }

	[BinaryPoint(Offset = 22016, Source = "22016", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22016", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2数据上报请求 { get; set; }

	[BinaryPoint(Offset = 22017, Source = "22017", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22017", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1数据上报结果 { get; set; }

	[BinaryPoint(Offset = 22018, Source = "22018", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22018", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2数据上报结果 { get; set; }

	[BinaryPoint(Offset = 22020, Source = "22020", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22020", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 扫码枪1触发 { get; set; }

	[BinaryPoint(Offset = 22021, Source = "22021", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22021", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 扫码枪2触发 { get; set; }

	[BinaryPoint(Offset = 22025, Source = "22025", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22025", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1生产状态 { get; set; }

	[BinaryPoint(Offset = 22026, Source = "22026", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22026", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2生产状态 { get; set; }

	[BinaryPoint(Offset = 22027, Source = "22027", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22027", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1料座感应状态 { get; set; }

	[BinaryPoint(Offset = 22028, Source = "22028", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22028", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2料座感应状态 { get; set; }

	[BinaryPoint(Offset = 22027, Source = "22027", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22027", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 打印机1触发 { get; set; }

	[BinaryPoint(Offset = 22028, Source = "22028", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22028", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 打印机2触发 { get; set; }

	[BinaryPoint(Offset = 22050, Source = "22050", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22050", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int 已生产数量 { get; set; }

	[BinaryPoint(Offset = 22052, Source = "22052", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22052", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 良率 { get; set; }

	[BinaryPoint(Offset = 22054, Source = "22054", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22054", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float CT { get; set; }

	[BinaryPoint(Offset = 22060, Source = "22060", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22060", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 工位1轨道百分比位置 { get; set; }

	[BinaryPoint(Offset = 22062, Source = "22062", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22062", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 工位2轨道百分比位置 { get; set; }

	[BinaryPoint(Offset = 22075, Source = "22075", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22075", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 22076, Source = "22076", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22076", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 22000, Source = "22000", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22000", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位1NG原因 { get; set; }

	[BinaryPoint(Offset = 22200, Source = "22200", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22200", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工位2NG原因 { get; set; }

	[BinaryPoint(Offset = 22200, Source = "22200", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22200", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1料号 { get; set; }

	[BinaryPoint(Offset = 22202, Source = "22202", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22202", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22204, Source = "22204", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22204", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22206, Source = "22206", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22206", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder1抛料率 { get; set; }

	[BinaryPoint(Offset = 22208, Source = "22208", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22208", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder1解锁响应 { get; set; }

	[BinaryPoint(Offset = 22209, Source = "22209", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22209", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder1换料响应 { get; set; }

	[BinaryPoint(Offset = 22220, Source = "22220", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22220", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2料号 { get; set; }

	[BinaryPoint(Offset = 22222, Source = "22222", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22222", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22224, Source = "22224", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22224", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22226, Source = "22226", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22226", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder2抛料率 { get; set; }

	[BinaryPoint(Offset = 22228, Source = "22228", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22228", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder2解锁响应 { get; set; }

	[BinaryPoint(Offset = 22229, Source = "22229", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22229", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder2换料响应 { get; set; }

	[BinaryPoint(Offset = 22240, Source = "22240", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22240", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3料号 { get; set; }

	[BinaryPoint(Offset = 22242, Source = "22242", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22242", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22244, Source = "22244", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22244", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22246, Source = "22246", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22246", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder3抛料率 { get; set; }

	[BinaryPoint(Offset = 22248, Source = "22248", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22248", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder3解锁响应 { get; set; }

	[BinaryPoint(Offset = 22249, Source = "22249", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22249", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder3换料响应 { get; set; }

	[BinaryPoint(Offset = 22260, Source = "22260", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22260", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4料号 { get; set; }

	[BinaryPoint(Offset = 22262, Source = "22262", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22262", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22264, Source = "22264", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22264", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22266, Source = "22266", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22266", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder4抛料率 { get; set; }

	[BinaryPoint(Offset = 22268, Source = "22268", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22268", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder4解锁响应 { get; set; }

	[BinaryPoint(Offset = 22269, Source = "22269", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22269", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder4换料响应 { get; set; }

	[BinaryPoint(Offset = 22280, Source = "22280", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22280", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5料号 { get; set; }

	[BinaryPoint(Offset = 22282, Source = "22282", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22282", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22284, Source = "22284", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22284", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22286, Source = "22286", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22286", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder5抛料率 { get; set; }

	[BinaryPoint(Offset = 22288, Source = "22288", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22288", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder5解锁响应 { get; set; }

	[BinaryPoint(Offset = 22289, Source = "22289", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22289", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder5换料响应 { get; set; }

	[BinaryPoint(Offset = 22300, Source = "22300", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22300", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6料号 { get; set; }

	[BinaryPoint(Offset = 22302, Source = "22302", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22302", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6物料上料数量 { get; set; }

	[BinaryPoint(Offset = 22304, Source = "22304", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22304", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 22306, Source = "22306", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22306", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder6抛料率 { get; set; }

	[BinaryPoint(Offset = 22308, Source = "22308", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22308", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder6解锁响应 { get; set; }

	[BinaryPoint(Offset = 22309, Source = "22309", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22309", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short Feeder6换料响应 { get; set; }

	[BinaryPoint(Offset = 22800, Source = "22800", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22800", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头1压力 { get; set; }

	[BinaryPoint(Offset = 22810, Source = "22810", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22810", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头2压力 { get; set; }

	[BinaryPoint(Offset = 22820, Source = "22820", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22820", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头3压力 { get; set; }

	[BinaryPoint(Offset = 22830, Source = "22830", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22830", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头4压力 { get; set; }

	[BinaryPoint(Offset = 22840, Source = "22840", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22840", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头5压力 { get; set; }

	[BinaryPoint(Offset = 22850, Source = "22850", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22850", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头6压力 { get; set; }

	[BinaryPoint(Offset = 22860, Source = "22860", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22860", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头7压力 { get; set; }

	[BinaryPoint(Offset = 22870, Source = "22870", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22870", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头8压力 { get; set; }

	[BinaryPoint(Offset = 22880, Source = "22880", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22880", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头9压力 { get; set; }

	[BinaryPoint(Offset = 22890, Source = "22890", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22890", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头10压力 { get; set; }

	[BinaryPoint(Offset = 22900, Source = "22900", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22900", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头11压力 { get; set; }

	[BinaryPoint(Offset = 22910, Source = "22910", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22910", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头12压力 { get; set; }

	#endregion

	#region CSV INCLUDE POINTS: 交互信号PC->PLC

	[BinaryPoint(Offset = 21000, Source = "21000", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21000", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0-1跳变 1S间隔", InitAttachData = null)]
	public partial short 上位机心跳 { get; set; }

	[BinaryPoint(Offset = 21001, Source = "21001", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21001", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=就绪，2=故障", InitAttachData = null)]
	public partial short 上位机状态 { get; set; }

	[BinaryPoint(Offset = 21002, Source = "21002", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21002", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=扫码枪未连接,2=MES未连接 ,3=IOT未连接,4=EAP未连接,5=打印机未连接", InitAttachData = null)]
	public partial long 上位机错误码 { get; set; }

	[BinaryPoint(Offset = 21005, Source = "21005", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21005", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData = null)]
	public partial short 工位1允许生产 { get; set; }

	[BinaryPoint(Offset = 21006, Source = "21006", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21006", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData = null)]
	public partial short 工位2允许生产 { get; set; }

	[BinaryPoint(Offset = 21010, Source = "21010", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21010", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "上位机下发到PLC的配方ID", InitAttachData = null)]
	public partial short 上位机当前配方ID { get; set; }

	[BinaryPoint(Offset = 21011, Source = "21011", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21011", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=请求,0=无请求", InitAttachData = null)]
	public partial short 配方上报请求 { get; set; }

	[BinaryPoint(Offset = 21012, Source = "21012", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21012", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=请求,0=无请求", InitAttachData = null)]
	public partial short 配方下发请求 { get; set; }

	[BinaryPoint(Offset = 21015, Source = "21015", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21015", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 工位1数据上报响应 { get; set; }

	[BinaryPoint(Offset = 21016, Source = "21016", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21016", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 工位2数据上报响应 { get; set; }

	[BinaryPoint(Offset = 21020, Source = "21020", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21020", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData = null)]
	public partial short 扫码枪1触发结果 { get; set; }

	[BinaryPoint(Offset = 21021, Source = "21021", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21021", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData = null)]
	public partial short 扫码枪2触发结果 { get; set; }

	[BinaryPoint(Offset = 21024, Source = "21024", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21024", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC不用，视觉用", InitAttachData = null)]
	public partial int 工位1生产序号 { get; set; }

	[BinaryPoint(Offset = 21026, Source = "21026", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21026", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC不用，视觉用", InitAttachData = null)]
	public partial int 工位2生产序号 { get; set; }

	[BinaryPoint(Offset = 21027, Source = "21027", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21027", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发", InitAttachData = null)]
	public partial short 打印机1触发结果 { get; set; }

	[BinaryPoint(Offset = 21028, Source = "21028", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21028", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=触发", InitAttachData = null)]
	public partial short 打印机2触发结果 { get; set; }

	[BinaryPoint(Offset = 21030, Source = "21030", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21030", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC不用，PC记录用", InitAttachData = null)]
	public partial long 吸头点检完成时间 { get; set; }

	[BinaryPoint(Offset = 21040, Source = "21040", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21040", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料1启用状态 { get; set; }

	[BinaryPoint(Offset = 21041, Source = "21041", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21041", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料2启用状态 { get; set; }

	[BinaryPoint(Offset = 21042, Source = "21042", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21042", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料3启用状态 { get; set; }

	[BinaryPoint(Offset = 21043, Source = "21043", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21043", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料4启用状态 { get; set; }

	[BinaryPoint(Offset = 21044, Source = "21044", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21044", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料5启用状态 { get; set; }

	[BinaryPoint(Offset = 21045, Source = "21045", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21045", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0不用，1启用", InitAttachData = null)]
	public partial short 物料6启用状态 { get; set; }

	[BinaryPoint(Offset = 21100, Source = "21100", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21100", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工单号PC下发 { get; set; }

	[BinaryPoint(Offset = 21140, Source = "21140", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21140", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工号PC下发 { get; set; }

	[BinaryPoint(Offset = 21380, Source = "21380", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21380", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "40字 视觉用", InitAttachData = null)]
	public partial short 扫码枪1扫码内容 { get; set; }

	[BinaryPoint(Offset = 21340, Source = "21340", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21340", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "40字 视觉用", InitAttachData = null)]
	public partial short 扫码枪2扫码内容 { get; set; }

	[BinaryPoint(Offset = 23000, Source = "23000", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:23000", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "20字节 配方名称", InitAttachData = null)]
	public partial short PC当前配方名称 { get; set; }

	[BinaryPoint(Offset = 21200, Source = "21200", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21200", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21202, Source = "21202", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21202", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21208, Source = "21208", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21208", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder1解锁请求 { get; set; }

	[BinaryPoint(Offset = 21209, Source = "21209", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21209", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder1换料请求 { get; set; }

	[BinaryPoint(Offset = 21220, Source = "21220", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21220", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21222, Source = "21222", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21222", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21228, Source = "21228", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21228", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder2解锁请求 { get; set; }

	[BinaryPoint(Offset = 21229, Source = "21229", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21229", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder2换料请求 { get; set; }

	[BinaryPoint(Offset = 21240, Source = "21240", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21240", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21242, Source = "21242", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21242", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21248, Source = "21248", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21248", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder3解锁请求 { get; set; }

	[BinaryPoint(Offset = 21249, Source = "21249", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21249", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder3换料请求 { get; set; }

	[BinaryPoint(Offset = 21260, Source = "21260", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21260", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21262, Source = "21262", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21262", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21268, Source = "21268", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21268", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder4解锁请求 { get; set; }

	[BinaryPoint(Offset = 21269, Source = "21269", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21269", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder4换料请求 { get; set; }

	[BinaryPoint(Offset = 21280, Source = "21280", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21280", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21282, Source = "21282", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21282", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21288, Source = "21288", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21288", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder5解锁请求 { get; set; }

	[BinaryPoint(Offset = 21289, Source = "21289", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21289", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder5换料请求 { get; set; }

	[BinaryPoint(Offset = 21300, Source = "21300", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21300", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6PC下发料号 { get; set; }

	[BinaryPoint(Offset = 21302, Source = "21302", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21302", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 21308, Source = "21308", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21308", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder6解锁请求 { get; set; }

	[BinaryPoint(Offset = 21309, Source = "21309", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21309", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder6换料请求 { get; set; }

	[BinaryPoint(Offset = 21800, Source = "21800", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21800", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头1点检结果 { get; set; }

	[BinaryPoint(Offset = 21810, Source = "21810", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21810", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头2点检结果 { get; set; }

	[BinaryPoint(Offset = 21820, Source = "21820", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21820", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头3点检结果 { get; set; }

	[BinaryPoint(Offset = 21830, Source = "21830", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21830", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头4点检结果 { get; set; }

	[BinaryPoint(Offset = 21840, Source = "21840", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21840", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头5点检结果 { get; set; }

	[BinaryPoint(Offset = 21850, Source = "21850", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21850", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头6点检结果 { get; set; }

	[BinaryPoint(Offset = 21860, Source = "21860", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21860", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头7点检结果 { get; set; }

	[BinaryPoint(Offset = 21870, Source = "21870", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21870", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头8点检结果 { get; set; }

	[BinaryPoint(Offset = 21880, Source = "21880", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21880", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头9点检结果 { get; set; }

	[BinaryPoint(Offset = 21890, Source = "21890", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21890", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头10点检结果 { get; set; }

	#endregion

}