using ZC;
using ZC.BinStructs;
using ZC.Mvvm;

namespace ZitApp.BinStructs;

public partial class PlcStruct : ObservableObject
{
	public IBinaryReadWriteConnection? Connection { get; set; }
	public IBinaryWriter? GetOrSetDefaultWriter(IBinaryWriter? writer = null, bool isSet = false) => Connection;
	public IBinaryReader? GetOrSetDefaultReader(IBinaryReader? reader = null, bool isSet = false) => Connection;
}