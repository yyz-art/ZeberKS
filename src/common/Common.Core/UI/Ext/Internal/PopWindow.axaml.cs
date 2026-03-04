using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Internal;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class PopWindow : UiTopLevelWindow
{
	public PopWindow()
	{
		InitializeComponent();
	}
}