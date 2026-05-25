using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Threading;
using ZitApp.Services;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton, AliasMapTo = [typeof(CommonMainWindow)])]
public partial class MainWindow : CommonMainWindow
{
	/// <summary>
	/// 允许关闭的最低权限等级（技术员=3, 管理员=5）
	/// </summary>
	private const int ClosePermissionLevel = 3;

	public MainWindow()
	{
		InitializeComponent();
		WindowTitleBarPanel.PointerPressed += (o, e) =>
		{
			if (ReferenceEquals(e.Source, WindowTitleBarPanel))
				BeginMoveDrag(e);
		};
		Loaded += OnLoaded;
		Closing += OnClosing;
	}

	private async void OnLoaded(object? sender, RoutedEventArgs e)
	{
		Loaded -= OnLoaded;
		if (DataContext is AppVM appVM)
			await appVM.RequireLoginOnStartup();
	}

	private void OnClosing(object? sender, WindowClosingEventArgs e)
	{
		// 启动登录未通过时允许关闭（退出程序）
		if (DataContext is AppVM { IsLoggedIn: false })
			return;

		var accountService = App.Current.IOC.Get<AccountService>();
		if (accountService.Account?.RoleFlags < ClosePermissionLevel)
		{
			e.Cancel = true;
			Dispatcher.UIThread.Post(() =>
			{
				var toast = AvaloniaApplication.Current.MainView?.Toast;
				toast?.Show("操作员无权关闭程序，请联系技术员或管理员", UiMessageType.Warning);
			});
		}
	}
}