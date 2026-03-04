namespace OinetApp.UI.Views.Demo;

public partial class DataGridDemo : UserControl
{
	public DataGridDemo()
	{
		InitializeComponent();
		DataContext = new DataGridDemoViewModel();
	}
}