using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class PathPickerDemoViewModel : ViewModelBase
{
	[ObservableProperty] private int _commandTriggerCount = 0;
	[ObservableProperty] private string? _path;
	[ObservableProperty] private IReadOnlyList<string>? _paths;

	[RelayCommand]
	private void Selected(IReadOnlyList<string> paths)
	{
		CommandTriggerCount++;
	}
}