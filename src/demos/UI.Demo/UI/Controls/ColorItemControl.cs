using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media;
using CommunityToolkit.Mvvm.Messaging;
using Oinet.Mvvm;
using OinetApp.UI.Views.Demo;

namespace OinetApp.UI.Controls;

public class ColorItemControl : TemplatedControl
{
	public static readonly StyledProperty<string?> ColorNameProperty =
		AvaloniaProperty.Register<ColorItemControl, string?>(nameof(ColorName));

	public static readonly StyledProperty<string?> HexProperty = AvaloniaProperty.Register<ColorItemControl, string?>(
		nameof(Hex));

	public string? ColorName
	{
		get => GetValue(ColorNameProperty);
		set => SetValue(ColorNameProperty, value);
	}

	public string? Hex
	{
		get => GetValue(HexProperty);
		set => SetValue(HexProperty, value);
	}

	protected override void OnPointerPressed(PointerPressedEventArgs e)
	{
		base.OnPointerPressed(e);
		switch (this.DataContext)
		{
			case ColorItemViewModel colorItemViewModel:
				WeakReferenceMessenger.Default.Send(colorItemViewModel);
				break;
			case ColorResource colorResource:
				WeakReferenceMessenger.Default.Send(colorResource);
				break;
		}
	}
}

public partial class ColorResource : ObservableObject
{
	[ObservableProperty] private ISolidColorBrush? _brush;
	[ObservableProperty] private string? _description;
	[ObservableProperty] private string? _pairWith;
	[ObservableProperty] private string? _resourceKey;

	public string CopyText =>
		$"""
		 <StaticResource x:Key="" ResourceKey="{ResourceKey}" />
		 """;
}