using Avalonia.Markup.Xaml;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class DividerDemo : UserControl
{
	public DividerDemo()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}