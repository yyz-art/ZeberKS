using System.Windows.Input;

namespace OinetApp.UI.Views;
[RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class ControlsMainView : UiView
{
	public ControlsMainView()
	{
		InitializeComponent();
	}
}

public class MenuItemViewModel
{
	public string? Header { get; set; }
	public ICommand? Command { get; set; }
	public object? CommandParameter { get; set; }
	public IList<MenuItemViewModel>? Items { get; set; }
}