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

	[BinaryPoint(Offset = 21230, Source = "21230", Tags = "交互信号PC->PLC", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:21230", Category = "PLC/PC->PLC", Unit = "", MinValue = 0, MaxValue = 4096, Description = "1=配方写入完成,0=无请求", InitAttachData =
	[
		DataDefine.KeyValue, "NameByCN", "",
		DataDefine.KeyValue, "NameByEN", "",
		DataDefine.KeyValue, "NameByVI", "",
	])]
	public short PC配方写入完成信号 { get; set; }
}
