namespace OinetApp.UI.Views;
[RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class ControlLibsMainView : UiView
{
	private ControlLibsMainViewViewModel? _viewModel;

	public ControlLibsMainView()
	{
		InitializeComponent();
	}

	protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
	{
		base.OnAttachedToVisualTree(e);
		_viewModel = DataContext as ControlLibsMainViewViewModel;
		var topLevel = TopLevel.GetTopLevel(this);
		if (topLevel is null || _viewModel is null)
			return;
		_viewModel.NotificationManager = UiNotificationManager.TryGetNotificationManager(topLevel, out var manager)
			? manager
			: new UiNotificationManager(topLevel);
	}
}