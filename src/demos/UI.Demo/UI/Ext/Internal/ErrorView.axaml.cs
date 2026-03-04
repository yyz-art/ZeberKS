namespace OinetApp.UI.Internal;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ErrorView : UiView
{
	public ErrorView()
	{
		InitializeComponent();
	}
}