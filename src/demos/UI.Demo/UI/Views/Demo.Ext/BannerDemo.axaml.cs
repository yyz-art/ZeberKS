namespace OinetApp.UI.Views.Demo.Ext;

public partial class BannerDemo : UserControl
{
	public BannerDemo()
	{
		InitializeComponent();
		this.DataContext = new BannerDemoViewModel();
	}
}