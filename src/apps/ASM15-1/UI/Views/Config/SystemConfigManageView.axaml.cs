using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Config;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class SystemConfigManageView : UiView
{
	public SystemConfigManageView()
	{
		InitializeComponent();
	}
}