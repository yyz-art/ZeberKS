using Avalonia.Controls.ApplicationLifetimes;
using Oinet.Mvvm;

namespace OinetApp.UI.Views;

public partial class ApplicationViewModel : ObservableObject
{
	[RelayCommand]
	private void Exit()
	{
		if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
		{
			desktop.Shutdown();
		}
	}
}