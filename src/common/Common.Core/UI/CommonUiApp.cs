using System.Globalization;
using System.Runtime.CompilerServices;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ZC;
using ZC.UI;
using ReactiveUI.Avalonia;

namespace ZitApp.UI;

public class CommonUiApp : AvaloniaApplication
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static object? R(object key) => Current!.TryGetResource(key, out var value) ? value : null;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T? R<T>(object key) =>
		Current!.TryGetResource(key, out var value) ? value is T ? (T)value : default : default;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string L(string key) =>
		Current!.TryGetResource(key, out var value) && value is string s ? s : key;

	public static void ReloadI18N(string language)
	{
		// 1. Load app-level i18n resources
		var i18nAssetsPath = $"assets/I18N.{language}.axaml";
		using var i18nFs = File.OpenRead(i18nAssetsPath);
		var dict = AvaloniaRuntimeXamlLoader.Load(i18nFs);
		var resourceDictionary = Current!.Resources as ResourceDictionary;
		resourceDictionary!.SetItems((dict as ResourceDictionary)!);

		// 2. Switch framework-level locale
		var culture = language.ToLower() switch
		{
			"cn" => new CultureInfo("zh-CN"),
			"en" => new CultureInfo("en-US"),
			"vi" => new CultureInfo("vi-VN"),
			_ => new CultureInfo("zh-CN")
		};
		UiTheme.OverrideLocaleResources(Current, culture);
	}

	public override void Initialize()
	{
		AvaloniaXamlLoader.Load(this);
	}

	protected override void OnInitializationCompleted(
		out ApplicationViewModel appVM,
		out IUiTopLevelView mainView)
	{
		// WindowsWebView.SetToDefaultWebView();
		appVM = null!;
		mainView = null!;

		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
		{
			var app = AppCore.Current;
			var appConfig = app.Config as CommonAppConfig;
			var i18nAssetsPath = $"assets/I18N.{appConfig?.Language ?? "cn"}.axaml";
			using var i18nFs = File.OpenRead(i18nAssetsPath);
			var dict = AvaloniaRuntimeXamlLoader.Load(i18nFs);
			var resourceDictionary = Resources as ResourceDictionary;
			resourceDictionary!.SetItems((dict as ResourceDictionary)!);
			appVM = app.IOC.Get<CommonAppVM>();
			var mainWindow = app.IOC.Get<CommonMainWindow>();
			mainView = mainWindow;
			var mainUiIOC = app.IOC.CreateScope("MainUi");
			mainWindow.IOC = mainUiIOC;
			mainWindow.Dialog = mainUiIOC.Get<IUiDialogManager>();
			mainWindow.Notification = mainUiIOC.Get<IUiNotificationManager>();
			mainWindow.Toast = mainUiIOC.Get<IUiToastManager>();
			mainWindow.NavManager = mainUiIOC.Get<INavigationManager>();
			mainWindow.DataContext = appVM;
			desktop.MainWindow = mainWindow;
		}
	}
}