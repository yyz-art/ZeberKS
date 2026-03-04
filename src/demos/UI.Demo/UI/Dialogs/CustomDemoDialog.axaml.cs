using Avalonia.Controls.Primitives;
using Avalonia.VisualTree;

namespace OinetApp.UI.Dialogs;

public partial class CustomDemoDialog : UserControl
{
	private CustomDemoDialogViewModel? _viewModel;

	public CustomDemoDialog()
	{
		InitializeComponent();
	}

	protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
	{
		base.OnAttachedToVisualTree(e);
		_viewModel = this.DataContext as CustomDemoDialogViewModel;
		var visualLayerManager = this.FindAncestorOfType<VisualLayerManager>();
		if (_viewModel == null) return;
		_viewModel.NotificationManager =
			UiNotificationManager.TryGetNotificationManager(visualLayerManager, out var notificationManager)
				? notificationManager
				: new UiNotificationManager(visualLayerManager) { MaxItems = 3 };
		_viewModel.ToastManager = UiToastManager.TryGetToastManager(visualLayerManager, out var toastManager)
			? toastManager
			: new UiToastManager(visualLayerManager) { MaxItems = 3 };
		Debug.Assert(UiNotificationManager.TryGetNotificationManager(visualLayerManager, out _));
	}
}