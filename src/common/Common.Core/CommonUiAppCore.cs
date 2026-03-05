using ZC;
using ZC.DP.Route;
using ZC.Net;
using ZC.Utils;
using ZC.Web.Server;
using SqlSugar;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp;

public abstract class CommonUiAppCore : CommonAppCore
{
	public virtual ZitAccount Account { get; protected set; } = new() { IdentityName = "Test", RoleFlags = 0 };
	public string Language { get; protected set; } = "CN";

	public CommonUiAppCore()
	{
		CurrentGetter = () => this;
	}

	protected override async Task<Result> OnInitialize(object? context = null, CancellationToken ctk = default)
	{
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<ZitAccount>();
		var accountService = IOC.GetOrNull<AccountService>();
		accountService?.Initialize();
		return default;
	}

	protected override async Task<Result> OnStart(object? context = null, CancellationToken ctk = default)
	{
		return default;
	}
}