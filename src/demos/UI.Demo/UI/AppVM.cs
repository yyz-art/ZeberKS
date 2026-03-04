using System.Windows.Input;
using OinetApp.UI.Internal;
using Avalonia.Styling;
using Oinet;
using Oinet.DP;
using Oinet.IFS.Objects;
using Oinet.LOG;
using Oinet.Mvvm;
using Oinet.UI.Models;
using OinetApp.UI.Views;
using ApplicationViewModel = Oinet.UI.ApplicationViewModel;
using ControlsMainViewModel = OinetApp.UI.Views.ControlsMainViewModel;

namespace OinetApp.UI;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(ApplicationViewModel)])]
public partial class AppVM : ApplicationViewModel, INamedObject
{
	public string GetObjectName() => "AppVM";
	public AvaloniaApplication Ui { get; set; } = AvaloniaApplication.Current;
	public required ILogger Logger { get; init; }


	public IEnumerable<INavigationInfo> CreateNavigations() => new NavigationInfo[]
	{
		new("/BasicControls") { ViewModel = typeof(ControlsMainViewModel) },
		new("/CustomControls") { ViewModel = typeof(ControlLibsMainViewViewModel) }
	};

	public required Assets.Data.I18N.I18N I18N { get; init; }

	protected override Task OnInitialize(object? ctx, object? args)
	{
		var navManager = Ui.MainView.NavManager!;
		navManager.AddNavigationInfos(CreateNavigations());
		navManager.Enabled = true;
		navManager.Navigate("/BasicControls");
		return base.OnInitialize(ctx, args);
	}

	public partial object? SelectedNavData { get; set; }

	[AttachData(
		DataDefine.Variable, "AllowIds:i32[]=[1,2,3,4,5,6,78,8]",
		DataDefine.KeyValue, "role-level", 25)]
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

		(SelectedNavData as MenuItem)?.Classes.Remove("NavActive");
		SelectedNavData = data;
		(SelectedNavData as MenuItem)?.Classes.Add("NavActive");
		if (data is MenuItem menuItem)
		{
			var navData = menuItem.DataContext as INavigationInfo ?? menuItem.Tag ?? menuItem.Header;
			navManager.Navigate(navData).Unwarp();
		}
		else
		{
			navManager.Navigate(data).Unwarp();
		}
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

		var popVM = App.Current.IOC.Get<PopVM>();
		var errorVM = App.Current.IOC.Get<ErrorVM>();
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
}