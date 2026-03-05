using System.Runtime.CompilerServices;
using System.Text.Json;
using ZC;
using ZC.DB;
using ZC.Development;
using ZC.DP.Number;
using ZC.EnhanceApp;
using ZC.IO;
using ZC.KvStorage.DB;
using ZC.Web.Server;
using ZC.Net;
using ZC.Net.Sockets;
using ZC.Shared.DefaultJson;
using ZC.Text;
using SqlSugar;
using ZC.BinStructs.Ext;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.SIFS;

// var xinJePlcClient = new XinJEPlcClient("127.0.0.1",502);
// var plcAlarmStruct = new PlcAlarmStruct();
// var readResult = plcAlarmStruct.ReadPoint(PlcAlarmStructInfo.Z1轴M1指令报错, xinJePlcClient);

Result.EnableCollectErrorStackTrace = Debugger.IsAttached;
DevUtils.DebugMode = DevDebugMode.LocalDebug;
EnhanceAppCore.InitializeEnvironment();
ObjectContainerOptions.Default.EnableCyclicDependencyCheck = true;
var config = new AppConfig
{
	TaskServiceHostOptions = TaskServiceHostOptions.CreateDefault(),
	Databases = [new DatabaseConnectionConfig(null, DatabaseType.Sqlite, @"Data Source=data/app.db")],
};
// config = Debugger.IsAttached ? config : AppCore.LoadConfig<AppConfig>();
config = AppCore.LoadConfig<AppConfig>();
if (DevUtils.IsLocalDebugMode && Debugger.IsAttached)
	config.Plc.IpAddress = "127.0.0.1";
Console.WriteLine($"Use Config: {JsonSerializer.Serialize(config, GlobalShared.Json.DefaultIndentOptions)}");
var app = new App(config).UseLogger().UseUi(UiApp.StartAsync)
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonUiAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.UseDatabase(config.Databases).UseDbKeyValueStorage().UseWebServer();
app.IOC.AddSingleton(app.Config);
await app.Initialize().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
await app.Start().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
while (true) await Task.Delay(1000);

public sealed class App(AppConfig config) : CommonUiAppCore
{
	public static string ApplicationName => "MFG-15";
	public new static App DesignTimeApp = new App(new AppConfig());
	public new static App Current => Design.IsDesignMode ? DesignTimeApp : (App)AppCore.Current;
	public new AppConfig Config { get; set; } = config;

	protected override async Task<Result> OnInitialize(object? context = null, CancellationToken ctk = default)
	{
		// IOC.GetOrNull<IAppStartUpVM>()?.SetProgress(40, 500);
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<DbKeyValueItem,AlarmRecord>();
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner-L", creator: _ => new SerialPortSocket(Config.Scanner1));
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner-R", creator: _ => new SerialPortSocket(Config.Scanner2));
		IOC.AddSingleton<XinJEPlcClient>(creator: oc => oc.Get<XinJEPlcClient>(
			InjectArgument.Create<INetworkSocketConfig>(Config.Plc)));
		await StartUi();
		return await base.OnInitialize(context, ctk);
	}

	protected override async Task<Result> OnStart(object? context = null, CancellationToken ctk = default)
	{
		await StartTaskServices();
		var recipeService = IOC.Get<RecipeService>();
		recipeService.LoadRecipes().Unwarp("Recipes load failed!");
		var connectionManageService = IOC.Get<ConnectionManageService>();
		connectionManageService.RegisterConnection("PLC", IOC.Get<XinJEPlcClient>());
		return await base.OnStart(context, ctk);
	}
}

public static partial class Program
{
	public static AppBuilder BuildAvaloniaApp() => UiApp.Build();
}

public static class AppLoader
{
#if RELEASE
	[ModuleInitializer]
#endif
	public static void Initialize() => CommonLibLoader.Initialize();
}