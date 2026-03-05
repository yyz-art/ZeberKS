namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class RunLogView : UiView
{
	public RunLogView()
	{
		InitializeComponent();
	}
}