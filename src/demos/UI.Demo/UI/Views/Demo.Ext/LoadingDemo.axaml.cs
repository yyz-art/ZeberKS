using Avalonia.Markup.Xaml;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class LoadingDemo : UserControl
{
	public LoadingDemo()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}