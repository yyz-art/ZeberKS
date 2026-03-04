using OinetApp.UI.Internal;
using Avalonia.Interactivity;

namespace OinetApp.UI.Internal;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class AboutUsPage : UserControl
{
	public AboutUsPage()
	{
		InitializeComponent();
	}

	protected override void OnLoaded(RoutedEventArgs e)
	{
		base.OnLoaded(e);
		if (DataContext is AboutUsVM vm)
		{
			var launcher = TopLevel.GetTopLevel(this)?.Launcher;
			vm.Launcher = launcher;
		}
	}
}