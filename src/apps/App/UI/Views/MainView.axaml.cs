namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainView : UiView
{
	public MainView()
	{
		InitializeComponent();
	}
}