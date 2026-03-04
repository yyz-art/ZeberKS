namespace OinetApp.UI.Views.Demo.Ext;

public partial class PaginationDemo : UserControl
{
	public PaginationDemo()
	{
		InitializeComponent();
		this.DataContext = new PaginationDemoViewModel();
	}
}