namespace OinetApp.UI.Views.Demo.Ext
{
	public partial class SkeletonDemo : UserControl
	{
		public SkeletonDemo()
		{
			InitializeComponent();
			DataContext = new SkeletonDemoViewModel();
		}
	}
}