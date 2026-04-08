using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Config;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class SystemConfigView : UiView
{
	public SystemConfigView()
	{
		InitializeComponent();
	}
}