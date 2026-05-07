using ZC;
using ZC.DB;
using ZC.IFS.Objects;
using ZC.LOG;
using ZC.Mvvm;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton), ObservableObject]
public partial class AccountService : INamedObject
{
	public static ZitAccount DefaultAccount { get; set; } =
		Debugger.IsAttached
			? new ZitAccount { IdentityName = "调试中", DisplayName = "调试中", RoleFlags = 5 }
			: new ZitAccount { IdentityName = "未登录", DisplayName = "未登录" };

	public partial ZitAccount? Account { get; private set; } = DefaultAccount;
	public required ISqlDbClient DbClient { get; init; }
	public required ILogger Logger { get; init; }


	public void Initialize()
	{
		var count = DbClient.Queryable<ZitAccount>().Count();
		if (count == 0)
		{
			Logger.Info("添加初始账户中...");
			DbClient.Insertable(new ZitAccount[]
			{
				new() { IdentityName = "管理员", SecurityKey = "1", RoleFlags = 5 },
				new() { IdentityName = "技术员", SecurityKey = "1", RoleFlags = 3 },
				new() { IdentityName = "操作员", SecurityKey = "1", RoleFlags = 1 },
			}).ExecuteCommand();
		}
	}

	public Result<ZitAccount> Login(string account, string password)
	{
		try
		{
			Logger.Info($"账号登录 账号='{account}' 密码HASH='{password.GetHashCode()}'");
			var identityAccount = DbClient.Queryable<ZitAccount>()
				.First(t => t.IdentityName == account && t.SecurityKey == password);
			if (identityAccount is null)
			{
				Logger.Info($"账号登录失败 账号不存在或者密码错误! 账号='{account}' 密码HASH='{password.GetHashCode()}'");
				return Result.Err<ZitAccount>("Not Found!");
			}

			if (AvaloniaApplication.Current.TryGetResource($"I18N.G.{identityAccount.IdentityName}",
				    out var displayName))
				identityAccount.DisplayName = displayName?.ToString();
			identityAccount.DisplayName ??= identityAccount.IdentityName;
			Account = identityAccount;
			Logger.Info($"账号登录成功 账号='{account}' 密码HASH='{password.GetHashCode()}'");
			return Result.Ok(identityAccount);
		}
		catch (Exception ex)
		{
			Logger.Error(ex, $"账号登录异常! 账号='{account}' 密码HASH='{password.GetHashCode()}' 错误={ex.Message}");
			return Result.Err<ZitAccount>(ex);
		}
	}

	public string GetObjectName() => nameof(AccountService);

	public async Task<Result<List<ZitAccount>>> GetAllAccountsAsync()
	{
		try
		{
			var accounts = await DbClient.Queryable<ZitAccount>().ToListAsync();
			foreach (var account in accounts)
			{
				if (AvaloniaApplication.Current.TryGetResource($"I18N.G.{account.IdentityName}", out var displayName))
					account.DisplayName = displayName?.ToString();
				account.DisplayName ??= account.IdentityName;
			}

			return Result.Ok(accounts);
		}
		catch (Exception ex)
		{
			return Result.Err<List<ZitAccount>>(ex);
		}
	}

	public async Task<Result> UpdateAccountsAsync(List<ZitAccount> accounts)
	{
		try
		{
			await DbClient.Updateable(accounts).ExecuteCommandAsync();
			return Result.OK;
		}
		catch (Exception ex)
		{
			return Result.Err(ex);
		}
	}
}