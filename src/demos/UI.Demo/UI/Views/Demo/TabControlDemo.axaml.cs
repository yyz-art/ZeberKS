namespace OinetApp.UI.Views.Demo;

public partial class TabControlDemo : UserControl
{
	public TabControlDemo()
	{
		InitializeComponent();
		this.DataContext = new TabControlDemoViewModel();
	}
}