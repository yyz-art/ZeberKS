using System.Runtime.CompilerServices;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ZC;
using ReactiveUI.Avalonia;

namespace ZitApp.UI;

public class CommonUiApp : AvaloniaApplication
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static object? R(object key) => Current!.TryGetResource(key, out var value) ? value : null;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T? R<T>(object key) =>
		Current!.TryGetResource(key, out var value) ? value is T ? (T)value : default : default;

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