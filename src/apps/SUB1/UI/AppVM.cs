using ZC;
using ZC.UI.ControlLibs;
using ZitApp.Services;
using ZitApp.UI.Account;
using ZitApp.UI.Alarm;
using ZitApp.UI.Config;
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

	public Task @SwitchAccount()
	{
		var mainWindow = View as MainWindow;
		return ShowModalDialog(mainWindow!.AccountLoginDialog);
	}

	public partial string AccountLoginInputAccountName { get; set; }
	public partial string AccountLoginInputPassword { get; set; }
	public partial string AccountLoginInputWorkNo { get; set; }

	public async Task @AccountLoginConfirm()
	{
		var loginResult = AccountService.Login(AccountLoginInputAccountName, AccountLoginInputPassword);
		if (loginResult.IsError())
		{
			await ShowMessageBox(
				$"登录失败！{loginResult.Message} {loginResult.Exception}", "登录失败", MessageBoxIcon.Error);
			return;
		}

		var mainWindow = View as MainWindow;
		mainWindow!.AccountLoginDialog.Close();
		ShowToast("登录成功！", UiMessageType.Success);
	}

	public void @OnSelectedAccountChanged(string account) => AccountLoginInputAccountName = account;

	private void @UiTick()
	{
		SystemTime = DateTime.Now;
	}
}