namespace OinetApp.UI.Views.Demo;

public partial class HighContrastDemo : UserControl
{
	public HighContrastDemo()
	{
		InitializeComponent();
		this.DataContext = new HighContrastDemoViewModel();
	}

	public async Task Copy(object? o)
	{
		if (o is null) return;
		var toplevel = TopLevel.GetTopLevel(this);
		if (toplevel?.Clipboard is { } c)
		{
			await c.SetTextAsync(o.ToString());
		}
	}
}