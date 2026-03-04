namespace OinetApp.UI.Internal;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ErrorVM : UiVM<ErrorView>
{
	public partial object? Sender { get; set; }
	public partial object? From { get; set; }
	public partial object? Args { get; set; }
	public partial object? Error { get; set; }

	void @Close()
	{
		View.GetTopLevelView()?.GetWindow()?.Hide();
	}
}