namespace OinetApp.UI.Views.Demo.Ext;

public partial class TimelineDemo : UserControl
{
	public TimelineDemo()
	{
		InitializeComponent();
		this.DataContext = new TimelineDemoViewModel();
	}
}