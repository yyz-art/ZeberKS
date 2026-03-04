namespace OinetApp.UI.Views.Demo.Ext;

public partial class ElasticWrapPanelDemo : UserControl
{
	public ElasticWrapPanelDemo()
	{
		InitializeComponent();
		DataContext = new ElasticWrapPanelDemoViewModel();
	}
}