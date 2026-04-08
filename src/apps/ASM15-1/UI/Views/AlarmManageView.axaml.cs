using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Alarm;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class AlarmManageView : UiView
{
	public AlarmManageView()
	{
		InitializeComponent();
	}
}