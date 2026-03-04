using System.Windows.Input;
using ZitApp.UI.Internal;
using Avalonia.Styling;
using ZC;
using ZC.Collections;
using ZC.DP;
using ZC.IFS.Objects;
using ZC.LOG;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZC.UI.Models;
using ZitApp.Services;
using ZitApp.UI.Views.Account;
using AccountLoginVM = ZitApp.UI.Account.AccountLoginVM;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(ApplicationViewModel)])]
public abstract partial class CommonAppVM : ApplicationViewModel, INamedObject
{
	public I18n I18n => I18n.D;
	public string GetObjectName() => "AppVM";
	public CommonUiApp Ui { get; set; } = (AvaloniaApplication.Current as CommonUiApp)!;
	public required ILogger Logger { get; init; }
	public required IObjectContainer IOC { get; init; }
	public required AccountService AccountService { get; init; }
	public abstract IEnumerable<INavigationInfo> CreateNavigations();

	protected override Task OnInitialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		var navManager = Ui.MainView.NavManager!;
		Ui.MainView.Toast?.Position = UiMessagePosition.BottomCenter;
		Ui.MainView.Notification?.Position = UiMessagePosition.BottomRight;
		var navigationInfos = CreateNavigations().ToArray();
		navManager.AddNavigationInfos(navigationInfos);
		navManager.Enabled = true;
		navManager.Navigate(navigationInfos.First());
		return base.OnInitialize(ctx, args);
	}

	public partial object? SelectedNavData { get; set; }

	public async Task @NavigateTo(object? data)
	{
		var navManager = Ui.MainView.NavManager!;
		var navInstance = navManager.ActiveNavInstance;
		if (navInstance?.ViewModel is UiViewModel uiVM)
		{
			navManager.NavigateRequestResult = Result.OK;
			await uiVM.OnNavigateRequesting(navManager, data, null);
			if (navManager.NavigateRequestResult != Result.OK)
				return;
		}


		object? finalNavData = null;
		if (data is MenuItem menuItem)
			finalNavData = menuItem.DataContext as INavigationInfo ?? menuItem.Tag ?? menuItem.Header;

		var uri = (finalNavData as INavigationInfo)?.Uri ?? finalNavData?.ToString();
		var navigationInfo = navManager.Root.GetChild(uri.AsSpan());
		if (navigationInfo?.CustomData is int roleLevel && AccountService.Account?.RoleFlags < roleLevel)
		{
			await ShowMessageBox("No Access", "Navigate Tip", MessageBoxIcon.Error);
			return;
		}
		navManager.Navigate(finalNavData).Unwarp();
		(SelectedNavData as MenuItem)?.Classes.Remove("NavActive");
		SelectedNavData = data;
		(SelectedNavData as MenuItem)?.Classes.Add("NavActive");
	}

	public override Task ShowError(object? sender, object? from, object? args, object? error, object? options = null)
	{
		if (error is Exception exception)
		{
			Logger.Error(exception, "Sender:{sender}; From:{from}; Args:{args}; Error:{error};", sender, from, args,
				exception.Message);
		}
		else
		{
			Logger.Error("Sender:{sender}; From:{from}; Args:{args}; Error:{error};", sender, from, args, error);
		}

		var popVM = AppCore.Current.IOC.Get<PopVM>();
		var errorVM = AppCore.Current.IOC.Get<ErrorVM>();
		popVM.Title = "应用程序错误";
		popVM.Content = errorVM.View;
		errorVM.Sender = sender;
		errorVM.From = from;
		errorVM.Args = args;
		errorVM.Error = error;
		popVM.View.Height = 600;
		popVM.View.Width = 800;
		var uiVM = sender as UiViewModel;
		if (uiVM?.View is Window senderTopLevelWindow)
			return popVM.GetWindow()!.ShowDialog(senderTopLevelWindow);
		return Task.CompletedTask;
	}

	protected override Task OnCommandExecuteException(object? sender, ICommand command, object? parameter,
		Exception exception)
	{
		return ShowError(sender, command, parameter, exception);
	}

	#region Basic

	public void @ToggleViewGround()
	{
		if (Debugger.IsAttached == false)
			return;
		// if (NavManager.ActiveContent is UiView uiView) uiView.ShowBackgroundContent = !uiView.ShowBackgroundContent;
	}

	public partial ObservableList<ThemeInfo> Themes { get; set; } = new()
	{
		new ThemeInfo("默认", ThemeVariant.Default),
		new ThemeInfo("亮色", ThemeVariant.Light),
		new ThemeInfo("暗色", ThemeVariant.Dark),
		new ThemeInfo("Aquatic", UiTheme.Aquatic),
		new ThemeInfo("Desert", UiTheme.Desert),
		new ThemeInfo("Dusk", UiTheme.Dusk),
		new ThemeInfo("NightSky", UiTheme.NightSky)
	};

	public override partial object? ThemeData { get; set; }


	partial void OnThemeDataChanged(object? value)
	{
		var themeInfo = value as IThemeInfo;
		if (value is null) return;
		var app = Application.Current;
		if (app is null) return;
		app.RequestedThemeVariant = themeInfo!.Theme;
		Ui.MainView.Notification?.Show(new UiNotification(
			"主题已切换",
			$"主题切换到 {themeInfo.Name}",
			UiMessageType.Success));
	}

	#endregion

	#region Account

	public async Task @RequestLogin()
	{
		ShowToast("发起登录请求中...");
		var accountLoginVM = IOC.Get<AccountLoginVM>();
		await accountLoginVM.View.ShowDialog(this.GetWindow()!);
	}

	#endregion
}