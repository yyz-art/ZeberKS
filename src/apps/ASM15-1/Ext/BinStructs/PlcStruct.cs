using ZC;
using ZC.Annotations;
using ZC.BinStructs;
using ZC.DP;
using ZC.Mvvm;

namespace ZitApp.BinStructs;

public partial class PlcStruct : ObservableObject
{
	public IBinaryConnection? Connection { get; set; }
	public IBinaryWriter? GetOrSetDefaultWriter(IBinaryWriter? writer = null, bool isSet = false) => Connection;
	public IBinaryReader? GetOrSetDefaultReader(IBinaryReader? reader = null, bool isSet = false) => Connection;

	[BinaryPoint(Offset = 22414, Source = "22414", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22414", Category = "PLC/PLC->PC", Unit = "", MinValue = 0, MaxValue = 4096, Description = "1=配方ID切换成功,0=无请求", InitAttachData =
	[
		DataDefine.KeyValue, "NameByCN", "",
		DataDefine.KeyValue, "NameByEN", "",
		DataDefine.KeyValue, "NameByVI", "",
	])]
	public short PLC读取配方ID切换成功响应 { get; set; }

	[BinaryPoint(Offset = 22075, Source = "22075", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22075", Category = "PLC/PLC->PC", Unit = "", MinValue = 0, MaxValue = 16, Description = "工位1螺丝拧紧完成信号，1-16表示对应螺丝号，收到后PC复位为0", InitAttachData =
	[
		DataDefine.KeyValue, "NameByCN", "",
		DataDefine.KeyValue, "NameByEN", "",
		DataDefine.KeyValue, "NameByVI", "",
	])]
	public short 工位1螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 22076, Source = "22076", Tags = "交互信号PLC->PC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:22076", Category = "PLC/PLC->PC", Unit = "", MinValue = 0, MaxValue = 16, Description = "工位2螺丝拧紧完成信号，1-16表示对应螺丝号，收到后PC复位为0", InitAttachData =
	[
		DataDefine.KeyValue, "NameByCN", "",
		DataDefine.KeyValue, "NameByEN", "",
		DataDefine.KeyValue, "NameByVI", "",
	])]
	public short 工位2螺丝拧紧完成信号 { get; set; }

	[BinaryPoint(Offset = 21230, Source = "21230", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21230", Category = "PLC/PC->PLC", Unit = "", MinValue = 0, MaxValue = 4096, Description = "1=配方写入完成,0=无请求", InitAttachData =
	[
		DataDefine.KeyValue, "NameByCN", "",
		DataDefine.KeyValue, "NameByEN", "",
		DataDefine.KeyValue, "NameByVI", "",
	])]
	public short PC配方写入完成信号 { get; set; }
}
