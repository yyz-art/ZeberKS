using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class TimePickerDemoViewModel : ObservableObject
{
	[ObservableProperty] private TimeSpan? _time;

	public TimePickerDemoViewModel()
	{
		Time = new TimeSpan(12, 20, 0);
	}
}