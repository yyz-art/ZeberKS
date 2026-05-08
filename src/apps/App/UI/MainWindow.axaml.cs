using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton, AliasMapTo = [typeof(CommonMainWindow)])]
public partial class MainWindow : CommonMainWindow
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