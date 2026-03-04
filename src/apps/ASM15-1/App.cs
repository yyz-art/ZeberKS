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
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Services;
using ZitApp.SIFS;

var variableMemoryEnumerator = new SifsVariableMemoryEnumerator(
	"GET_PN=??? ZEBRA_DTG=??? SN_NOW_GROUP=???".AsMemory(),
	"GET_PN=1005-031111-00 ZEBRA_DTG=MODEL_NAME=1005-031111,DCS=HH,TIMON=ASTEROID,GROUP_NAME=T1,T2,T3,T4-1,T4-2,T5,T6,T7,T8,T9,T10,T11,T12-1,T12-2,T14;MODEL_NAME=1005-031111-00,DCS=HH,TIMON=ASTEROID,GROUP_NAME=CCD1,CCD2,CCD3; SN_NOW_GROUP=CCD2"
		.AsMemory());
while (variableMemoryEnumerator.MoveNext(out var name, out var value))
{
	Console.WriteLine($"{name}={value}");
}

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
Console.WriteLine($"Use Config: {JsonSerializer.Serialize(config, GlobalShared.Json.DefaultIndentOptions)}");
var app = new App(config).UseLogger().UseUi(UiApp.StartAsync)
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonUiAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.UseDatabase(config.Databases).UseDbKeyValueStorage().UseWebServer();
await app.Initialize().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
await app.Start().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
while (true) await Task.Delay(1000);

public sealed class App(AppConfig config) : CommonUiAppCore
{
	public new AppConfig Config { get; set; } = config;

	protected override async Task<Result> OnInitialize(object? context = null, CancellationToken ctk = default)
	{
		// IOC.GetOrNull<IAppStartUpVM>()?.SetProgress(40, 500);
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<DbKeyValueItem>();
		IOC.AddTransient<ScrewMachine>();
		IOC.AddSingleton<ScrewMachine>(specialName: "L", creator: oc => oc.Get<ScrewMachine>(
			InjectArgument.Create(new ScrewMachineConnection(Config.Screw1))));
		IOC.AddSingleton<ScrewMachine>(specialName: "R", creator: oc => oc.Get<ScrewMachine>(
			InjectArgument.Create(new ScrewMachineConnection(Config.Screw2))));
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
		var lScrewService = IOC.Get<ScrewService>(InjectArgument.Create(IOC.Get<ScrewMachine>(specialName: "L")));
		var rScrewService = IOC.Get<ScrewService>(InjectArgument.Create(IOC.Get<ScrewMachine>(specialName: "R")));
		TaskServiceManager.AddService(lScrewService);
		// TaskServiceManager.AddService(rScrewService);
		var connectionManageService = IOC.Get<ConnectionManageService>();
		connectionManageService.RegisterConnection("PLC", IOC.Get<XinJEPlcClient>());
		connectionManageService.RegisterConnection("SCREW-L", IOC.Get<ScrewMachine>(specialName: "L").Connection);
		connectionManageService.RegisterConnection("SCREW-R", IOC.Get<ScrewMachine>(specialName: "R").Connection);
		var rp = new ProductRecipe();
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