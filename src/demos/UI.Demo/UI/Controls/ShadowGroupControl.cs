using System.Collections;
using Avalonia.Controls.Primitives;

namespace OinetApp.UI.Controls;

public class ShadowGroupControl : TemplatedControl
{
	public static readonly StyledProperty<string?> TitleProperty =
		AvaloniaProperty.Register<ShadowGroupControl, string?>(nameof(Title));

	public static readonly DirectProperty<ShadowGroupControl, IEnumerable?> LightShadowsProperty =
		AvaloniaProperty.RegisterDirect<ShadowGroupControl, IEnumerable?>(nameof(LightShadows),
			o => o.LightShadows, (o, v) => o.LightShadows = v);

	public static readonly DirectProperty<ShadowGroupControl, IEnumerable?> DarkShadowsProperty =
		AvaloniaProperty.RegisterDirect<ShadowGroupControl, IEnumerable?>(nameof(DarkShadows),
			o => o.DarkShadows, (o, v) => o.DarkShadows = v);

	private IEnumerable? _darkShadows;

	private IEnumerable? _lightShadows;

	public string? Title
	{
		get => GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}

	public IEnumerable? LightShadows
	{
		get => _lightShadows;
		set => SetAndRaise(LightShadowsProperty, ref _lightShadows, value);
	}

	public IEnumerable? DarkShadows
	{
		get => _darkShadows;
		set => SetAndRaise(DarkShadowsProperty, ref _darkShadows, value);
	}
}