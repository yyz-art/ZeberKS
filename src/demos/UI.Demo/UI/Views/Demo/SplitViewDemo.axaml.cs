namespace OinetApp.UI.Views.Demo;

public partial class SplitViewDemo : UserControl
{
	public SplitViewDemo()
	{
		InitializeComponent();
		this.DataContext = new SplitViewDemoViewModel();
	}
}