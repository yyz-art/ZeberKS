namespace OinetApp.UI.Views.Demo;

public partial class TabStripDemo : UserControl
{
	public TabStripDemo()
	{
		InitializeComponent();
		this.DataContext = new TabStripDemoViewModel();
	}
}