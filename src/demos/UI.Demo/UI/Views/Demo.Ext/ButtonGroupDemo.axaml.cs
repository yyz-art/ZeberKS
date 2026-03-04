namespace OinetApp.UI.Views.Demo.Ext;

public partial class ButtonGroupDemo : UserControl
{
	public ButtonGroupDemo()
	{
		InitializeComponent();
		DataContext = new ButtonGroupDemoViewModel();
	}
}