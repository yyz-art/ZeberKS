using System.Collections;
using Avalonia.Controls.Primitives;

namespace OinetApp.UI.Controls;

public class FunctionalColorGroupControl : TemplatedControl
{
	public static readonly StyledProperty<string?> TitleProperty =
		AvaloniaProperty.Register<FunctionalColorGroupControl, string?>(nameof(Title));

	public static readonly DirectProperty<FunctionalColorGroupControl, IEnumerable?> LightColorsProperty =
		AvaloniaProperty.RegisterDirect<FunctionalColorGroupControl, IEnumerable?>(nameof(LightColors),
			o => o.LightColors, (o, v) => o.LightColors = v);

	public static readonly DirectProperty<FunctionalColorGroupControl, IEnumerable?> DarkColorsProperty =
		AvaloniaProperty.RegisterDirect<FunctionalColorGroupControl, IEnumerable?>(nameof(DarkColors),
			o => o.DarkColors, (o, v) => o.DarkColors = v);

	private IEnumerable? _darkColors;

	private IEnumerable? _lightColors;

	public string? Title
	{
		get => GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}

	public IEnumerable? LightColors
	{
		get => _lightColors;
		set => SetAndRaise(LightColorsProperty, ref _lightColors, value);
	}

	public IEnumerable? DarkColors
	{
		get => _darkColors;
		set => SetAndRaise(DarkColorsProperty, ref _darkColors, value);
	}
}