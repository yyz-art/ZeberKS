namespace OinetApp.UI.Views.Demo;

public partial class ComboBoxDemo : UserControl
{
	public ComboBoxDemo()
	{
		InitializeComponent();
		this.DataContext = new ComboBoxDemoViewModel();
	}
}