namespace ZitApp.UI.Controls;

public class ViewContainer : ContentControl
{
	public static readonly StyledProperty<object?> HeaderProperty =
		AvaloniaProperty.Register<ViewContainer, object?>(nameof(Header));

	public object? Header
	{
		get => GetValue(HeaderProperty);
		set => SetValue(HeaderProperty, value);
	}
}