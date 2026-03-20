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
{
	config.Plc.IpAddress = "127.0.0.1";
}
Console.WriteLine($"Use Config: {JsonSerializer.Serialize(config, Global.Json.DefaultIndentOptions)}");
var app = new App(config).UseLogger().UseUi(UiApp.StartAsync)
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonUiAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.UseDatabase(config.Databases).UseDbKeyValueStorage().UseWebServer();
app.IOC.AddSingleton(app.Config);
await app.Initialize();
await app.Start();
while (true) await Task.Delay(1000);

public sealed class App(AppConfig config) : CommonUiAppCore
{
	public static string ApplicationName => "ASM15-1";
	public new static App DesignTimeApp = new App(new AppConfig());
	public new static App Current => Design.IsDesignMode ? DesignTimeApp : (App)AppCore.Current;
	public new AppConfig Config { get; set; } = config;

	protected override async Task OnInitialize(object? ctx, object? args)
	{
		// IOC.GetOrNull<IAppStartUpVM>()?.SetProgress(40, 500);
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<DbKeyValueItem,AlarmRecord>();
		IOC.AddSingleton(specialName: "L",instance: new ScrewMachineConnection(Config.Screw1));
		IOC.AddSingleton(specialName: "R",instance: new ScrewMachineConnection(Config.Screw2));
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner-L", creator: _ => new SerialPortSocket(Config.Scanner1));
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner-R", creator: _ => new SerialPortSocket(Config.Scanner2));
		IOC.AddSingleton<XinJEPlcClient>(creator: oc => oc.Get<XinJEPlcClient>(
			InjectArgument.Create<INetworkSocketConfig>(Config.Plc)));
		await StartUi();
		await base.OnInitialize(ctx, args);
	}

	protected override async Task OnStart(object? ctx, object? args)
	{
		await StartTaskServices();
		var recipeService = IOC.Get<RecipeService>();
		recipeService.LoadRecipes().Unwarp("Recipes load failed!");
		var lScrewService = IOC.Get<ScrewService>(InjectArgument.Create(IOC.Get<ScrewMachineConnection>(specialName: "L")));
		var rScrewService = IOC.Get<ScrewService>(InjectArgument.Create(IOC.Get<ScrewMachineConnection>(specialName: "R")));
		TaskServiceManager.AddService(lScrewService);
		// TaskServiceManager.AddService(rScrewService);
		var connectionManageService = IOC.Get<ConnectionManageService>();
		connectionManageService.RegisterConnection("PLC", IOC.Get<XinJEPlcClient>());
		connectionManageService.RegisterConnection("SCREW-L", IOC.Get<ScrewMachineConnection>(specialName: "L"));
		connectionManageService.RegisterConnection("SCREW-R", IOC.Get<ScrewMachineConnection>(specialName: "R"));
		var rp = new ProductRecipe();
		await base.OnStart(ctx, args);
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