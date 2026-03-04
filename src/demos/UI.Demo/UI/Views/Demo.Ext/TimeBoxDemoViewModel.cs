using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class TimeBoxDemoViewModel : ObservableObject
{
	[ObservableProperty] private TimeSpan? _timeSpan;

	public TimeBoxDemoViewModel()
	{
		TimeSpan = new TimeSpan(0, 21, 11, 36, 54);
	}

	[RelayCommand]
	private void ChangeRandomTime()
	{
		TimeSpan = new TimeSpan(Random.Shared.NextInt64(0x00000000FFFFFFFF));
	}
}