using Avalonia.Markup.Xaml;
//using HotAvalonia;
using LiveChartsCore;
using ZC;
using ReactiveUI.Avalonia;
using ZitApp.UI.LiveChart;

namespace ZitApp.UI;

public class UiApp : CommonUiApp
{
	public int ResourceVersion { get; set; }

	public override void Initialize()
	{
		AvaloniaXamlLoader.Load(this);
		// LiveCharts configuration section: // mark
		LiveCharts.Configure(c => c // mark
			.AddLiveChartsAppSettings()); // mark
#if DEBUG
		// 启用HotAvalonia热重载功能
		// if (Debugger.IsAttached)
		// 	HotAvalonia.AvaloniaHotReload.Enable(this);
#endif
	}


	public static AppBuilder Build()
	{
		var app = AppBuilder.Configure<UiApp>().UseSkia().UsePlatformDetect().LogToTrace().UseReactiveUI();
// #if DEBUG
// 		if (Debugger.IsAttached)
// 			app.UseHotReload();
// #endif
		return app;
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
			AppCore.Current.Destroy().GetAwaiter().GetResult();
			Environment.Exit(0);
		}
	}
}