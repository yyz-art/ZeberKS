using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class TreeDataGridDemoViewModel : ObservableObject
{
	public SongsPageViewModel SongsContext { get; } = new();
	public FilesPageViewModel FilesContext { get; } = new();
}