using System.Collections.ObjectModel;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Messaging;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public partial class HighContrastDemoViewModel : ObservableObject
{
	[ObservableProperty] private ColorResource _selectedColorResource = null!;
	[ObservableProperty] private ThemeVariant? _selectedThemeVariant;

	public HighContrastDemoViewModel()
	{
		ThemeVariants =
		[
			UiTheme.Aquatic,
			UiTheme.Desert,
			UiTheme.Dusk,
			UiTheme.NightSky,
		];
		ColorResources =
		[
			new ColorResource
			{
				ResourceKey = "Color.Window",
				Brush = new SolidColorBrush(Color.Parse("#202020")),
				Description = "Background of pages, panes, popups, and windows.",
				PairWith = "WindowTextColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.WindowText",
				Brush = new SolidColorBrush(Color.Parse("#FFFFFF")),
				Description = "Headings, body copy, lists, placeholder text, app and window borders.",
				PairWith = "WindowColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.Hotlight",
				Brush = new SolidColorBrush(Color.Parse("#75E9FC")),
				Description = "Hyperlinks.",
				PairWith = "WindowColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.GrayText",
				Brush = new SolidColorBrush(Color.Parse("#A6A6A6")),
				Description = "Inactive (disabled) UI.",
				PairWith = "WindowColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.HighlightText",
				Brush = new SolidColorBrush(Color.Parse("#263B50")),
				Description =
					"Foreground color for text or UI that is in selected, interacted with (hover, pressed), or in progress.",
				PairWith = "HighlightColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.Highlight",
				Brush = new SolidColorBrush(Color.Parse("#8EE3F0")),
				Description =
					"Background or accent color for UI that is in selected, interacted with (hover, pressed), or in progress.",
				PairWith = "HighlightTextColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.ButtonText",
				Brush = new SolidColorBrush(Color.Parse("#FFFFFF")),
				Description = "Foreground color for buttons and any UI that can be interacted with.",
				PairWith = "ButtonFaceColor"
			},
			new ColorResource
			{
				ResourceKey = "Color.ButtonFace",
				Brush = new SolidColorBrush(Color.Parse("#202020")),
				Description = "Background color for buttons and any UI that can be interacted with.",
				PairWith = "ButtonTextColor"
			},
		];
		WeakReferenceMessenger.Default.Register<HighContrastDemoViewModel, ColorResource>
			(this, (_, item) => SelectedColorResource = item);
		SelectedThemeVariant = UiTheme.Aquatic;
	}

	public IEnumerable<ThemeVariant> ThemeVariants { get; }
	public ObservableCollection<ColorResource> ColorResources { get; set; }

	partial void OnSelectedThemeVariantChanged(ThemeVariant? value)
	{
		var topLevel = ResolveDefaultTopLevel();
		if (value is null) return;
		foreach (var colorResource in ColorResources)
		{
			if (colorResource.ResourceKey is null) continue;
			if (topLevel?.TryFindResource(colorResource.ResourceKey, value, out var o) == true
			    && o is ISolidColorBrush color)
			{
				colorResource.Brush = color;
			}
		}
	}

	private static TopLevel? ResolveDefaultTopLevel()
	{
		return Avalonia.Application.Current?.ApplicationLifetime switch
		{
			IClassicDesktopStyleApplicationLifetime desktopLifetime => desktopLifetime.MainWindow,
			ISingleViewApplicationLifetime singleView => TopLevel.GetTopLevel(singleView.MainView),
			_ => null
		};
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