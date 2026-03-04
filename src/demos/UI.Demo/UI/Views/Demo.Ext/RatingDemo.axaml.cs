namespace OinetApp.UI.Views.Demo.Ext;

public partial class RatingDemo : UserControl
{
	public RatingDemo()
	{
		InitializeComponent();
		this.DataContext = new RatingDemoViewModel();
	}
}