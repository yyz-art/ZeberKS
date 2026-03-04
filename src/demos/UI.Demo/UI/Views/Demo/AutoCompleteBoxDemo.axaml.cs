namespace OinetApp.UI.Views.Demo;

public partial class AutoCompleteBoxDemo : UserControl
{
	public AutoCompleteBoxDemo()
	{
		InitializeComponent();
		this.DataContext = new AutoCompleteBoxDemoViewModel();
	}
}