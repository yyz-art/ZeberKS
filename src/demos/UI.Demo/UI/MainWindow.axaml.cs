using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace OinetApp.UI;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton, AliasMapTo = [typeof(ApplicationWindow)])]
public partial class MainWindow : UiTopLevelWindow
{
	public MainWindow()
	{
		InitializeComponent();
		WindowTitleBarPanel.PointerPressed += (o, e) =>
		{
			if (ReferenceEquals(e.Source, WindowTitleBarPanel))
				BeginMoveDrag(e);
		};
	}
}