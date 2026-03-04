namespace OinetApp.UI.Internal;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class PopVM : UiViewModel<PopWindow>
{
	public partial string Title { get; set; } = "PopWindow";
	public partial object? Content { get; set; }
}