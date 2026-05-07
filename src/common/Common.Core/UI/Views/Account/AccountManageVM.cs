using ZC.Identity;
using ZC.Mvvm;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.Account;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class AccountManageVM : CommonUiVM<AccountManageView>
{
	public ObservableList<ZitAccount> Accounts { get; } = [];
	public required AccountService AccountService { get; init; }

	public async Task @ReloadAccounts()
	{
		ShowToast("reload accounts ...");
		var accountsResult = await AccountService.GetAllAccountsAsync();
		foreach (var account in accountsResult.Value!)
		{
			if (AvaloniaApplication.Current.TryGetResource($"I18N.G.{account.IdentityName}", out var displayName))
				account.DisplayName = displayName?.ToString();
			account.DisplayName ??= account.IdentityName;
		}

		Accounts.Clear();
		Accounts.AddRange(accountsResult.Value!);
		ShowToast("reload accounts successfully", UiMessageType.Success);
	}

	public async Task @SaveAccountsChanges()
	{
		ShowToast("save changes ...");
		await AccountService.UpdateAccountsAsync(Accounts.ToList());
		ShowToast("save changes successfully..", UiMessageType.Success);
	}

	public AccountManageVM()
	{
		if (Design.IsDesignMode)
		{
			Accounts.AddRange([
				new ZitAccount { IdentityName = "管理员", SecurityKey = "12345", RoleFlags = 5 },
				new ZitAccount { IdentityName = "技术员", SecurityKey = "12345", RoleFlags = 3 },
				new ZitAccount { IdentityName = "操作员", SecurityKey = "12345", RoleFlags = 1 },
			]);
		}
	}

	protected override async Task OnViewAttachedToVisualTree(object sender, object? args)
	{
		if (Design.IsDesignMode) return;
		await ReloadAccounts();
		await base.OnViewAttachedToVisualTree(sender, args);
	}
}