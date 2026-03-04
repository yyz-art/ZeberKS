namespace OinetApp.UI.Views.Demo.Ext;

public partial class NavMenuDemo : UserControl
{
	public NavMenuDemo()
	{
		InitializeComponent();
		DataContext = new NavMenuDemoViewModel();
	}
}