using ZC;
using ZitApp.Services;
using ZitApp.UI.Views.Account;

namespace ZitApp.UI.Account;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class AccountLoginVM : CommonUiVM<AccountLoginWindow>
{
	public required AccountService AccountService { get; init; }
	public partial string Account { get; set; } = "管理员";
	public partial string Password { get; set; } = "";
	public bool IsLoggedIn { get; set; }

	public void @OnSelectedAccountChanged(string account) => Account = account;


	public async Task @Login()
	{
		var loginResult = AccountService.Login(Account, Password);
		if (loginResult.IsError())
		{
			await ShowMessageBox(
				$"登录失败！{loginResult.Message} {loginResult.Exception}","登录失败", MessageBoxIcon.Error);
			return;
		}
		IsLoggedIn = true;
		View.Hide();
		AvaloniaApplication.Current.MainView.Toast!.Show("登录成功！", UiMessageType.Success);
	}

	public void @CloseView()
	{
		View.Hide();
	}
}