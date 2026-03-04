using System.Globalization;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using Oinet.Mvvm;

namespace OinetApp.UI.Views;

[ViewModel, RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class ControlsMainViewModel : UiVM<ControlsMainView>
{
	public ControlsMainViewModel()
	{
		MenuItems =
		[
			new MenuItemViewModel
			{
				Header = "Theme",
				Items =
				[
					new MenuItemViewModel
					{
						Header = "Auto",
						Command = FollowSystemThemeCommand
					},
					new MenuItemViewModel
					{
						Header = "Aquatic",
						Command = SelectThemeCommand,
						CommandParameter = UiTheme.Aquatic
					},
					new MenuItemViewModel
					{
						Header = "Desert",
						Command = SelectThemeCommand,
						CommandParameter = UiTheme.Desert
					},
					new MenuItemViewModel
					{
						Header = "Dusk",
						Command = SelectThemeCommand,
						CommandParameter = UiTheme.Dusk
					},
					new MenuItemViewModel
					{
						Header = "NightSky",
						Command = SelectThemeCommand,
						CommandParameter = UiTheme.NightSky
					},
				]
			},
			new MenuItemViewModel
			{
				Header = "Locale",
				Items =
				[
					new MenuItemViewModel
					{
						Header = "简体中文",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("zh-cn")
					},
					new MenuItemViewModel
					{
						Header = "English",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("en-us")
					},
					new MenuItemViewModel
					{
						Header = "日本語",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("ja-jp")
					},
					new MenuItemViewModel
					{
						Header = "Українська",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("uk-ua")
					},
					new MenuItemViewModel
					{
						Header = "Русский",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("ru-ru")
					},
					new MenuItemViewModel
					{
						Header = "繁體中文",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("zh-tw")
					},
					new MenuItemViewModel
					{
						Header = "Deutsch",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("de-de")
					},
					new MenuItemViewModel
					{
						Header = "Español",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("es-es")
					},
					new MenuItemViewModel
					{
						Header = "Polski",
						Command = SelectLocaleCommand,
						CommandParameter = new CultureInfo("pl-pl")
					},
				]
			}
		];
	}

	public string DocumentationUrl => "https://Oinet.com";
	public string RepoUrl => "https://Oinet.com";
	public IReadOnlyList<MenuItemViewModel> MenuItems { get; }

	[RelayCommand]
	private void FollowSystemTheme()
	{
		Avalonia.Application.Current?.RegisterFollowSystemTheme();
	}

	[RelayCommand]
	private void ToggleTheme()
	{
		var app = Avalonia.Application.Current;
		if (app is null) return;
		var theme = app.ActualThemeVariant;
		app.RequestedThemeVariant = theme == ThemeVariant.Dark ? ThemeVariant.Light : ThemeVariant.Dark;
		app.UnregisterFollowSystemTheme();
	}

	[RelayCommand]
	private void SelectTheme(object? obj)
	{
		var app = Avalonia.Application.Current;
		if (app is null) return;
		app.RequestedThemeVariant = obj as ThemeVariant;
		app.UnregisterFollowSystemTheme();
	}

	[RelayCommand]
	private void SelectLocale(object? obj)
	{
		var app = Avalonia.Application.Current;
		if (app is null) return;
		UiTheme.OverrideLocaleResources(app, obj as CultureInfo);
	}

	[RelayCommand]
	private static async Task OpenUrl(string url)
	{
		var launcher = ResolveDefaultTopLevel()?.Launcher;
		if (launcher is not null)
		{
			await launcher.LaunchUriAsync(new Uri(url));
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