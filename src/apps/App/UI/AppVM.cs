using ZC;
using ZC.UI.ControlLibs;
using ZitApp.Services;
using ZitApp.UI.Account;
using ZitApp.UI.Alarm;
using ZitApp.UI.Config;
using ZitApp.UI.Dialogs;
using ZitApp.UI.Views.Account;
using RecipeVM = ZitApp.UI.Recipe.RecipeVM;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(CommonAppVM)])]
public partial class AppVM : CommonAppVM
{
	public new AvaloniaApplication Ui { get; set; } = AvaloniaApplication.Current;

	public partial DateTime SystemTime { get; private set; }

	public AppVM()
	{
		if (Design.IsDesignMode)
		{
			AccountService = new AccountService
			{
				DbClient = null!,
				Logger = null!
			};
		}
	}


	public override IEnumerable<INavigationInfo> CreateNavigations() => new NavigationInfo[]
	{
		new("/主页") { ViewModel = typeof(MainVM), AllowClose = false, CustomData = 0 },
		new("/账户管理") { ViewModel = typeof(AccountManageVM), AllowClose = false, CustomData = 5 },
		new("/报警") { ViewModel = typeof(AlarmManageVM), AllowClose = false, CustomData = 3 },
		new("/设置") { ViewModel = typeof(SystemConfigVM), AllowClose = false, CustomData = 5 },
		new("/配方") { ViewModel = typeof(RecipeVM), AllowClose = false, CustomData = 3 },
	};

	public partial int UiTickInterval { get; set; } = 200;

	/// <summary>
	/// 是否已通过启动登录
	/// </summary>
	public bool IsLoggedIn { get; set; }

	/// <summary>
	/// 启动时调用 — 模态登录，未登录则退出程序
	/// </summary>
	public async Task RequireLoginOnStartup()
	{
		var loginVM = IOC.Get<AccountLoginVM>();
		loginVM.IsLoggedIn = false;
		await loginVM.View.ShowDialog((Window)View!);
		IsLoggedIn = loginVM.IsLoggedIn;
		if (!IsLoggedIn)
			((Window)View!).Close();
	}

	/// <summary>
	/// 菜单调用 — 非模态登录
	/// </summary>
	public Task @SwitchAccount()
	{
		var mainWindow = View as MainWindow;
		return ShowModalDialog(mainWindow!.AccountLoginDialog);
	}

	public async Task<bool> ShowConfirmMessageBox(object message, string title)
	{
		var option = await ShowMessageBox(message, title, MessageBoxIcon.Question, MessageBoxButton.YesNo);
		return option is MessageBoxResult.Yes;
	}

	public partial string AccountLoginInputAccountName { get; set; } = "管理员";
	public partial string AccountLoginInputPassword { get; set; }
	public partial string AccountLoginInputWorkNo { get; set; }
	

	public Task @QuickCreateMaterialRecipe()
	{
		var createMaterialRecipeVM = App.Current.IOC.Get<CreateMaterialRecipeVM>();
		return createMaterialRecipeVM.Show();
	}

	public async Task @AccountLoginConfirm()
	{
		var loginResult = AccountService.Login(AccountLoginInputAccountName, AccountLoginInputPassword);
		if (loginResult.IsError())
		{
			await ShowMessageBox(
				string.Format(CommonUiApp.L("I18N.G.登录失败提示"), loginResult.Message, loginResult.Exception), CommonUiApp.L("I18N.G.登录失败"), MessageBoxIcon.Error);
			return;
		}

		var mainWindow = View as MainWindow;
		mainWindow!.AccountLoginDialog.Close();
		ShowToast(CommonUiApp.L("I18N.G.登录成功"), UiMessageType.Success);
	}

	public void @OnSelectedAccountChanged(string account) => AccountLoginInputAccountName = account;

	private void @UiTick()
	{
		SystemTime = DateTime.Now;
	}
}
