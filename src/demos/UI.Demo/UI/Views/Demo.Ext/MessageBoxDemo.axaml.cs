namespace OinetApp.UI.Views.Demo.Ext;

public partial class MessageBoxDemo : UserControl
{
	public MessageBoxDemo()
	{
		InitializeComponent();
		this.DataContext = new MessageBoxDemoViewModel();
	}
}