namespace OinetApp.UI.Views.Demo.Ext;

public partial class NotificationDemo : UserControl
{
	private NotificationDemoViewModel _viewModel;

	public NotificationDemo()
	{
		InitializeComponent();
		_viewModel = new NotificationDemoViewModel();
		DataContext = _viewModel;
	}

	protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
	{
		base.OnAttachedToVisualTree(e);
		var topLevel = TopLevel.GetTopLevel(this);
		if (topLevel is null)
			return;
		_viewModel.NotificationManager = UiNotificationManager.TryGetNotificationManager(topLevel, out var manager)
			? manager
			: new UiNotificationManager(topLevel);
	}
}