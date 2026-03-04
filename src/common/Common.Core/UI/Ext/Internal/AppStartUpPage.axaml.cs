namespace ZitApp.UI.Internal;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class AppStartUpPage : UserControl
{
	public AppStartUpPage()
	{
		InitializeComponent();
	}
}