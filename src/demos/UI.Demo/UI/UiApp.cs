using System.Runtime.CompilerServices;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Oinet;
using Oinet.UI.Controls;
using ReactiveUI.Avalonia;

namespace OinetApp.UI;

public class UiApp : AvaloniaApplication
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
			var app = App.Current;
			appVM = app.IOC.Get<AppVM>();
			var mainWindow = app.IOC.Get<MainWindow>();
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

	public static Task StartAsync()
	{
		UiThread = new Thread(AvaloniaMain, 1024 * 1024 * 10) { Name = "AppUI", IsBackground = false };
		UiThread.TrySetApartmentState(ApartmentState.STA);
		UiUtils.Implement.IsUiThreadImplement = thread => thread == UiThread;
		UiThread.Start();
		return AvaloniaInitializedCompletionSource.Task;
	}

	private static void AvaloniaMain()
	{
		AppCore app;
		try
		{
			try
			{
				app = AppCore.Current;
			}
			catch (Exception)
			{
				// Ignore
			}

			Build().StartWithClassicDesktopLifetime(Environment.GetCommandLineArgs());
		}
		catch (Exception ex)
		{
			if (Debugger.IsAttached)
				Debugger.Break();
			Console.Error.WriteLine(ex);
		}
		finally
		{
			App.Current.Destroy().GetAwaiter().GetResult();
			Environment.Exit(0);
		}
	}

	public static AppBuilder Build() =>
		AppBuilder.Configure<UiApp>().UseSkia().UsePlatformDetect().LogToTrace().UseReactiveUI();
}