using System.ComponentModel;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.DP.Memory;
using ZC.Mvvm;

namespace ZitApp.BinStructs;

public partial class PlcStruct : ObservableObject
{
	public IBinaryConnection? Connection { get; set; }
	public IBinaryWriter? GetOrSetDefaultWriter(IBinaryWriter? writer = null, bool isSet = false) => Connection;
	public IBinaryReader? GetOrSetDefaultReader(IBinaryReader? reader = null, bool isSet = false) => Connection;

	public  bool IsRealWriteMode { get; set; }


	protected override void OnDataChanged(object? args)
	{
		if (IsRealWriteMode)
			PriWritePoint(args!);
		base.OnDataChanged(args);
	}
	


	private void PriWritePoint(object args)
	{
		if (args is PropertyChangedEventArgs eventArgs)
		{
			var structInfo = this.GetStructInfo();
			var binaryPoint = structInfo.Members.GetValueOrDefault(eventArgs.PropertyName.AsMemory()) as IBinaryPoint;
			if (binaryPoint != null)
				this.WritePoint(binaryPoint).Unwarp();
		}
	}
}