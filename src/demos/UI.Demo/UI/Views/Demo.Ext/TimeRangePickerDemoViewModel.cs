using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class TimeRangePickerDemoViewModel : ObservableObject
{
	[ObservableProperty] private TimeSpan? _endTime;
	[ObservableProperty] private TimeSpan? _startTime;

	public TimeRangePickerDemoViewModel()
	{
		StartTime = new TimeSpan(8, 21, 0);
		EndTime = new TimeSpan(18, 22, 0);
	}
}