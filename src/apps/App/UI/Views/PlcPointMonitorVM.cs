using System.ComponentModel;
using ZC.BinStructs;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZitApp.BinStructs;

namespace ZitApp.UI;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class PlcPointMonitorVM : CommonUiVM<PlcPointMonitorWindow>
{
	public List<IPropertyInstance> ToPcPropertyInstances { get; } =
		TypeMetaInfo<PlcStruct>.Cache.Properties.Where(t => t.ValueInfo?.Category == "PLC/PLC->PC")
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public List<IPropertyInstance> ToPlcPropertyInstances { get; } =
		TypeMetaInfo<PlcStruct>.Cache.Properties.Where(t => t.ValueInfo?.Category == "PLC/PC->PLC")
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public PlcStruct? Read { get; set; } = null!;
	public PlcStruct? Write { get; set; } = null!;

	public void SetPlcStructs(PlcStruct read, PlcStruct write)
	{
		
		
		Read?.PropertyChanged -= OnPlcReadChanged;
		Read = read;
		Read?.PropertyChanged += OnPlcReadChanged;
		Write = write;

		foreach (var propertyInstance in ToPlcPropertyInstances)
		{
			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;
			propertyInstance.Reset(read);
		}

		foreach (var propertyInstance in ToPcPropertyInstances)
		{
			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;
			propertyInstance.Reset(read);
		}
	}
	public bool IsDisplayed { get; set; }
	
	private void OnPlcReadChanged(object? sender, PropertyChangedEventArgs e)
	{
		if(View.IsDisplayed == false)
			return;
		foreach (var propertyInstance in ToPcPropertyInstances)
		{
			if (propertyInstance.Define.Name == e.PropertyName)
			{
				// propertyInstance.Value = propertyInstance.Define.Getter!.Invoke(sender)!;
				propertyInstance.Reset(null);
				propertyInstance.Reset(sender);
			}
		}
		foreach (var propertyInstance in ToPlcPropertyInstances)
		{
			if (propertyInstance.Define.Name == e.PropertyName)
			{
				// propertyInstance.Value = propertyInstance.Define.Getter!.Invoke(sender)!;
				propertyInstance.Reset(null);
				propertyInstance.Reset(sender);
			}
		}
	}
	
	

	public void @Hide() => View.Hide();
}