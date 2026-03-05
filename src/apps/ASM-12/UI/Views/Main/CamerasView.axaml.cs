namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class CamerasView : UiView
{
	public CamerasView()
	{
		InitializeComponent();
	}
}