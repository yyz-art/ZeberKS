namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class DeviceStatusView : UiView
{
	public DeviceStatusView()
	{
		InitializeComponent();
	}
}