using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class PlcPointMonitorWindow : UiWindow
{
	public bool IsDisplayed { get; set; }
	public PlcPointMonitorWindow()
	{
		InitializeComponent();
	}

	protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
	{
		IsDisplayed = true;
		base.OnAttachedToVisualTree(e);
	}

	protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
	{
		IsDisplayed = false;
		base.OnDetachedFromVisualTree(e);
	}

	public override void Show()
	{
		IsDisplayed = true;
		base.Show();
	}

	public override void Hide()
	{
		IsDisplayed = false;
		base.Hide();
	}
}