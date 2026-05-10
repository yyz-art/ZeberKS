
// GENERATE AT 2026/5/9 14:26:55
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;
using ZitApp.Devices.Plc;
using ZC.BinStructs1;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "PlcToPc", Source = "4000", Tags = "", Start = 4000, End = 4999, Points = ["*"])]
[BinaryPointGroup(Name = "PcToPlc", Source = "5000", Tags = "", Start = 5000, End = 5999, Points = ["*"])]
public partial class PlcStruct
{

	#region CSV INCLUDE POINTS: 交互信号PLC->PC

	[BinaryPoint(Offset = 5000, Source = "5000", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5000", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC心跳 { get; set; }

	[BinaryPoint(Offset = 5001, Source = "5001", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5001", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData = null)]
	public partial short PLC状态 { get; set; }

	[BinaryPoint(Offset = 5002, Source = "5002", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5002", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short PLC错误码 { get; set; }

	[BinaryPoint(Offset = 5003, Source = "5003", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5003", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData = null)]
	public partial short 工位1状态 { get; set; }

	[BinaryPoint(Offset = 5004, Source = "5004", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5004", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=启动,2=停止,3=初始化中,4=报警中", InitAttachData = null)]
	public partial short 工位2状态 { get; set; }

	[BinaryPoint(Offset = 5010, Source = "5010", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5010", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC初始化使用的配方ID", InitAttachData = null)]
	public partial short PLC当前配方ID { get; set; }

	[BinaryPoint(Offset = 5011, Source = "5011", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5011", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=已完成,0=无请求 ", InitAttachData = null)]
	public partial short PLC配方写入PC地址响应 { get; set; }

	[BinaryPoint(Offset = 5012, Source = "5012", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5012", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=已完成,0=无请求 ", InitAttachData = null)]
	public partial short PLC读取配方ID切换成功响应 { get; set; }

	[BinaryPoint(Offset = 5015, Source = "5015", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5015", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=未上报,1=OK,2=NG,收到响应后复位", InitAttachData = null)]
	public partial short 工位1数据上报请求 { get; set; }

	[BinaryPoint(Offset = 5016, Source = "5016", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5016", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=未上报,1=OK,2=NG,收到响应后复位", InitAttachData = null)]
	public partial short 工位2数据上报请求 { get; set; }

	[BinaryPoint(Offset = 5020, Source = "5020", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5020", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "大于等于1触发，收到响应后复位", InitAttachData = null)]
	public partial short 扫码枪1触发 { get; set; }

	[BinaryPoint(Offset = 5021, Source = "5021", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5021", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "大于等于1触发，收到响应后复位", InitAttachData = null)]
	public partial short 扫码枪2触发 { get; set; }

	[BinaryPoint(Offset = 5025, Source = "5025", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5025", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=生产中", InitAttachData = null)]
	public partial short 工位1生产状态 { get; set; }

	[BinaryPoint(Offset = 5026, Source = "5026", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5026", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=生产中", InitAttachData = null)]
	public partial short 工位2生产状态 { get; set; }

	[BinaryPoint(Offset = 5030, Source = "5030", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5030", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData = null)]
	public partial short 上相机连接状态 { get; set; }

	[BinaryPoint(Offset = 5031, Source = "5031", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5031", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData = null)]
	public partial short 下相机1连接状态 { get; set; }

	[BinaryPoint(Offset = 5032, Source = "5032", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5032", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=正常，2断开", InitAttachData = null)]
	public partial short 下相机2连接状态 { get; set; }

	[BinaryPoint(Offset = 5050, Source = "5050", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5050", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int 已生产数量 { get; set; }

	[BinaryPoint(Offset = 5052, Source = "5052", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5052", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 良率 { get; set; }

	[BinaryPoint(Offset = 5054, Source = "5054", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5054", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "单位ms", InitAttachData = null)]
	public partial float CT { get; set; }

	[BinaryPoint(Offset = 5060, Source = "5060", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5060", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0.5 = 50%", InitAttachData = null)]
	public partial float 工位1轨道百分比位置 { get; set; }

	[BinaryPoint(Offset = 5062, Source = "5062", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5062", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0.5 = 50%", InitAttachData = null)]
	public partial float 工位2轨道百分比位置 { get; set; }

	[BinaryPoint(Offset = 5075, Source = "5075", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5075", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "[1-n] n最大螺丝颗数 0=无", InitAttachData = null)]
	public partial short 工位1螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 5076, Source = "5076", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5076", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "[1-n] n最大螺丝颗数 0=无", InitAttachData = null)]
	public partial short 工位2螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 5200, Source = "5200", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5200", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1料号 { get; set; }

	[BinaryPoint(Offset = 5202, Source = "5202", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5202", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5204, Source = "5204", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5204", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5206, Source = "5206", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5206", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder1抛料率 { get; set; }

	[BinaryPoint(Offset = 5208, Source = "5208", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5208", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder1解锁响应 { get; set; }

	[BinaryPoint(Offset = 5209, Source = "5209", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5209", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder1换料响应 { get; set; }

	[BinaryPoint(Offset = 5220, Source = "5220", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5220", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2料号 { get; set; }

	[BinaryPoint(Offset = 5222, Source = "5222", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5222", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5224, Source = "5224", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5224", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5226, Source = "5226", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5226", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder2抛料率 { get; set; }

	[BinaryPoint(Offset = 5228, Source = "5228", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5228", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder2解锁响应 { get; set; }

	[BinaryPoint(Offset = 5229, Source = "5229", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5229", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder2换料响应 { get; set; }

	[BinaryPoint(Offset = 5240, Source = "5240", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5240", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3料号 { get; set; }

	[BinaryPoint(Offset = 5242, Source = "5242", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5242", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5244, Source = "5244", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5244", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5246, Source = "5246", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5246", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder3抛料率 { get; set; }

	[BinaryPoint(Offset = 5248, Source = "5248", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5248", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder3解锁响应 { get; set; }

	[BinaryPoint(Offset = 5249, Source = "5249", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5249", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder3换料响应 { get; set; }

	[BinaryPoint(Offset = 5260, Source = "5260", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5260", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4料号 { get; set; }

	[BinaryPoint(Offset = 5262, Source = "5262", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5262", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5264, Source = "5264", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5264", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5266, Source = "5266", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5266", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder4抛料率 { get; set; }

	[BinaryPoint(Offset = 5268, Source = "5268", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5268", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder4解锁响应 { get; set; }

	[BinaryPoint(Offset = 5269, Source = "5269", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5269", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder4换料响应 { get; set; }

	[BinaryPoint(Offset = 5280, Source = "5280", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5280", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5料号 { get; set; }

	[BinaryPoint(Offset = 5282, Source = "5282", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5282", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5284, Source = "5284", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5284", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5286, Source = "5286", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5286", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder5抛料率 { get; set; }

	[BinaryPoint(Offset = 5288, Source = "5288", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5288", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder5解锁响应 { get; set; }

	[BinaryPoint(Offset = 5289, Source = "5289", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5289", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder5换料响应 { get; set; }

	[BinaryPoint(Offset = 5300, Source = "5300", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5300", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6料号 { get; set; }

	[BinaryPoint(Offset = 5302, Source = "5302", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5302", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6物料上料数量 { get; set; }

	[BinaryPoint(Offset = 5304, Source = "5304", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5304", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6物料剩余数量 { get; set; }

	[BinaryPoint(Offset = 5306, Source = "5306", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5306", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float Feeder6抛料率 { get; set; }

	[BinaryPoint(Offset = 5308, Source = "5308", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5308", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder6解锁响应 { get; set; }

	[BinaryPoint(Offset = 5309, Source = "5309", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5309", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0=不允许换料，1=允许换料,2=收到换料中,3=收到换料完成", InitAttachData = null)]
	public partial short Feeder6换料响应 { get; set; }

	[BinaryPoint(Offset = 5800, Source = "5800", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5800", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头1压力 { get; set; }

	[BinaryPoint(Offset = 5810, Source = "5810", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5810", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头2压力 { get; set; }

	[BinaryPoint(Offset = 5820, Source = "5820", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5820", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头3压力 { get; set; }

	[BinaryPoint(Offset = 5830, Source = "5830", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5830", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头4压力 { get; set; }

	[BinaryPoint(Offset = 5840, Source = "5840", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5840", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头5压力 { get; set; }

	[BinaryPoint(Offset = 5850, Source = "5850", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5850", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头6压力 { get; set; }

	[BinaryPoint(Offset = 5860, Source = "5860", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5860", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头7压力 { get; set; }

	[BinaryPoint(Offset = 5870, Source = "5870", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5870", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头8压力 { get; set; }

	[BinaryPoint(Offset = 5880, Source = "5880", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5880", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头9压力 { get; set; }

	[BinaryPoint(Offset = 5890, Source = "5890", Tags = "PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:5890", Category = "PLC/PLC->PC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial float 吸头10压力 { get; set; }

	#endregion

	#region CSV INCLUDE POINTS: 交互信号PC->PLC

	[BinaryPoint(Offset = 4000, Source = "4000", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4000", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "0-1跳变 1S间隔", InitAttachData = null)]
	public partial short 上位机心跳 { get; set; }

	[BinaryPoint(Offset = 4001, Source = "4001", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4001", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=就绪，2=故障", InitAttachData = null)]
	public partial short 上位机状态 { get; set; }

	[BinaryPoint(Offset = 4002, Source = "4002", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4002", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=扫码枪未连接,2=MES未连接 ,3=IOT未连接,4=EAP未连接,5=打印机未连接", InitAttachData = null)]
	public partial long 上位机错误码 { get; set; }

	[BinaryPoint(Offset = 4005, Source = "4005", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4005", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData = null)]
	public partial short 工位1允许生产 { get; set; }

	[BinaryPoint(Offset = 4006, Source = "4006", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4006", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=允许生产,2=扫码未通过,3=配方未响应,4=物料需更换", InitAttachData = null)]
	public partial short 工位2允许生产 { get; set; }

	[BinaryPoint(Offset = 4010, Source = "4010", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4010", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "上位机下发到PLC的配方ID", InitAttachData = null)]
	public partial short 上位机当前配方ID { get; set; }

	[BinaryPoint(Offset = 4011, Source = "4011", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4011", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=请求,0=无请求", InitAttachData = null)]
	public partial short PLC配方写入PC地址请求 { get; set; }

	[BinaryPoint(Offset = 4012, Source = "4012", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4012", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=请求,0=无请求", InitAttachData = null)]
	public partial short PC配方写入完成信号 { get; set; }

	[BinaryPoint(Offset = 4015, Source = "4015", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4015", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 工位1数据上报响应 { get; set; }

	[BinaryPoint(Offset = 4016, Source = "4016", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4016", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 工位2数据上报响应 { get; set; }

	[BinaryPoint(Offset = 4020, Source = "4020", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4020", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData = null)]
	public partial short 扫码枪1触发结果 { get; set; }

	[BinaryPoint(Offset = 4021, Source = "4021", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4021", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=扫码枪连接错误,3=MES返回错误", InitAttachData = null)]
	public partial short 扫码枪2触发结果 { get; set; }

	[BinaryPoint(Offset = 4024, Source = "4024", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4024", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC不用，视觉用", InitAttachData = null)]
	public partial int 工位1生产序号 { get; set; }

	[BinaryPoint(Offset = 4026, Source = "4026", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4026", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "PLC不用，视觉用", InitAttachData = null)]
	public partial int 工位2生产序号 { get; set; }

	[BinaryPoint(Offset = 4100, Source = "4100", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4100", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工单号PC下发 { get; set; }

	[BinaryPoint(Offset = 4140, Source = "4140", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4140", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial short 工号PC下发 { get; set; }

	[BinaryPoint(Offset = 4300, Source = "4300", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4300", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "40字 视觉用", InitAttachData = null)]
	public partial short 扫码枪1扫码内容 { get; set; }

	[BinaryPoint(Offset = 4340, Source = "4340", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4340", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "40字 视觉用", InitAttachData = null)]
	public partial short 扫码枪2扫码内容 { get; set; }

	[BinaryPoint(Offset = 4200, Source = "4200", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4200", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4202, Source = "4202", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4202", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder1PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4208, Source = "4208", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4208", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder1解锁请求 { get; set; }

	[BinaryPoint(Offset = 4209, Source = "4209", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4209", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder1换料请求 { get; set; }

	[BinaryPoint(Offset = 4220, Source = "4220", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4220", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4222, Source = "4222", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4222", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder2PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4228, Source = "4228", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4228", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder2解锁请求 { get; set; }

	[BinaryPoint(Offset = 4229, Source = "4229", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4229", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder2换料请求 { get; set; }

	[BinaryPoint(Offset = 4240, Source = "4240", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4240", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4242, Source = "4242", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4242", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder3PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4248, Source = "4248", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4248", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder3解锁请求 { get; set; }

	[BinaryPoint(Offset = 4249, Source = "4249", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4249", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder3换料请求 { get; set; }

	[BinaryPoint(Offset = 4260, Source = "4260", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4260", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4262, Source = "4262", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4262", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder4PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4268, Source = "4268", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4268", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder4解锁请求 { get; set; }

	[BinaryPoint(Offset = 4269, Source = "4269", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4269", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder4换料请求 { get; set; }

	[BinaryPoint(Offset = 4280, Source = "4280", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4280", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4282, Source = "4282", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4282", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder5PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4288, Source = "4288", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4288", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder5解锁请求 { get; set; }

	[BinaryPoint(Offset = 4289, Source = "4289", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4289", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder5换料请求 { get; set; }

	[BinaryPoint(Offset = 4300, Source = "4300", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4300", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6PC下发料号 { get; set; }

	[BinaryPoint(Offset = 4302, Source = "4302", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4302", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData = null)]
	public partial int Feeder6PC下发物料上料数量 { get; set; }

	[BinaryPoint(Offset = 4308, Source = "4308", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4308", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "预留", InitAttachData = null)]
	public partial short Feeder6解锁请求 { get; set; }

	[BinaryPoint(Offset = 4309, Source = "4309", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4309", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=查询是否允许换料,2=换料中,3=换料完成", InitAttachData = null)]
	public partial short Feeder6换料请求 { get; set; }

	[BinaryPoint(Offset = 4800, Source = "4800", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4800", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头1点检结果 { get; set; }

	[BinaryPoint(Offset = 4810, Source = "4810", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4810", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头2点检结果 { get; set; }

	[BinaryPoint(Offset = 4820, Source = "4820", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4820", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头3点检结果 { get; set; }

	[BinaryPoint(Offset = 4830, Source = "4830", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4830", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头4点检结果 { get; set; }

	[BinaryPoint(Offset = 4840, Source = "4840", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4840", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头5点检结果 { get; set; }

	[BinaryPoint(Offset = 4850, Source = "4850", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4850", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头6点检结果 { get; set; }

	[BinaryPoint(Offset = 4860, Source = "4860", Tags = "PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4860", Category = "PLC/PC->PLC", Unit = "",MinValue = 0, MaxValue = 4096, Description = "1=OK,2=NG", InitAttachData = null)]
	public partial short 吸头7点检结果 { get; set; }

	#endregion

}