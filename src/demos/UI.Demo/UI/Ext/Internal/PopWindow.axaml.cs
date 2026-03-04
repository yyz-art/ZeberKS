using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace OinetApp.UI.Internal;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class PopWindow : UiTopLevelWindow
{
	public PopWindow()
	{
		InitializeComponent();
	}
}