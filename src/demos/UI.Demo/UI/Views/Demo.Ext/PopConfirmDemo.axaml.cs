namespace OinetApp.UI.Views.Demo.Ext;

public partial class PopConfirmDemo : UserControl
{
	public PopConfirmDemo()
	{
		InitializeComponent();
	}

	protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
	{
		base.OnAttachedToVisualTree(e);
		if (this.DataContext is not PopConfirmDemoViewModel vm) return;
		var manager = UiToastManager.TryGetToastManager(TopLevel.GetTopLevel(this), out var m)
			? m
			: new UiToastManager(TopLevel.GetTopLevel(this));
		vm.ToastManager = manager;
	}
}