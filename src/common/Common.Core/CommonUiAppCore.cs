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

	protected override Task OnInitialize(object? ctx, object? args)
	{
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<ZitAccount>();
		var accountService = IOC.GetOrNull<AccountService>();
		accountService?.Initialize();
		return Task.CompletedTask;
	}


}