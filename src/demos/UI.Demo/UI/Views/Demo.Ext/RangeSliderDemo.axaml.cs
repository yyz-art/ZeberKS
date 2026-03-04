namespace OinetApp.UI.Views.Demo.Ext;

public partial class RangeSliderDemo : UserControl
{
	public RangeSliderDemo()
	{
		InitializeComponent();
		this.DataContext = new RangeSliderDemoViewModel();
	}
}