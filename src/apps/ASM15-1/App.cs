using System.IO.Ports;
using System.Text.Json;
using ZC;
using ZC.DB;
using ZC.Development;
using ZC.EnhanceApp;
using ZC.IO;
using ZC.KvStorage.DB;
using ZC.Net.Sockets;
using ZC.Shared.DefaultJson;
using SqlSugar;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;

CommonAppConfig.IsDevTestMode = Debugger.IsAttached;
DevUtils.DebugMode = Debugger.IsAttached ? DevDebugMode.LocalDebug : 0;
EnhanceAppCore.InitializeEnvironment();
ObjectContainerOptions.Default.EnableCyclicDependencyCheck = true;
var config = new AppConfig
{
	TaskServiceHostOptions = TaskServiceHostOptions.CreateDefault(),
	Databases = [new DatabaseConnectionConfig(null, DatabaseType.Sqlite, @"Data Source=data/app.db")],
};
config = AppCore.LoadConfig<AppConfig>();
if (DevUtils.IsLocalDebugMode && Debugger.IsAttached)
	config.Plc.IpAddress = "127.0.0.1";
Console.WriteLine($"Use Config: {JsonSerializer.Serialize(config, Global.Json.DefaultIndentOptions)}");
var app = new App(config).UseLogger().UseUi(UiApp.StartAsync)
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonUiAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.UseDatabase(config.Databases).UseDbKeyValueStorage().UseWebServer();
await app.Initialize();
await app.Start();
while (true) await Task.Delay(1000);

public sealed class App(AppConfig config) : CommonUiAppCore(config)
{
	public static string ApplicationName => "ASM15-1";
	public new static App DesignTimeApp = new App(new AppConfig());
	public new static App Current => Design.IsDesignMode ? DesignTimeApp : (App)AppCore.Current;
	public new AppConfig Config { get; set; } = config;

	protected override async Task OnInitialize(object? ctx, object? args)
	{
		// IOC.GetOrNull<IAppStartUpVM>()?.SetProgress(40, 500);
		using var dbClient = IOC.Get<ISqlSugarClient>();
		dbClient.CodeFirst.InitTables<DbKeyValueItem, AlarmRecord>();
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner工位1", creator: _ => new SerialPortSocket(Config.Scanner1)
		{
			Parity = Parity.None,
			DataBits = 8,
			StopBits = StopBits.One
		});
		IOC.AddSingleton<IDataSocket>(specialName: "Scanner工位2", creator: _ => new SerialPortSocket(Config.Scanner2)
		{
			Parity = Parity.None,
			DataBits = 8,
			StopBits = StopBits.One
		});
#if ASM15_1
		IOC.AddSingleton<ScrewMachineConnection>(specialName: "Screw工位1",
			creator: _ => new ScrewMachineConnection(Config.Screw1) { Name = "Screw工位1" });
		IOC.AddSingleton<ScrewMachineConnection>(specialName: "Screw工位2",
			creator: _ => new ScrewMachineConnection(Config.Screw2) { Name = "Screw工位2" });
		// IOC.AddSingleton<ScrewService>(specialName: "Screw工位1", oc => oc.Get<ScrewService>(null,
		// 	InjectArgument.Create(IOC.Get<ScrewMachineConnection>(specialName: "Screw工位1"))));
		// IOC.AddSingleton<ScrewService>(specialName: "Screw工位2", oc => oc.Get<ScrewService>(null,
		// 	InjectArgument.Create(IOC.Get<ScrewMachineConnection>(specialName: "Screw工位2"))));
		// TaskServiceManager.AddService(IOC.Get<ScrewService>(specialName: "Screw工位1"));
		// TaskServiceManager.AddService(IOC.Get<ScrewService>(specialName: "Screw工位2"));
#endif
		IOC.AddSingleton<XinJEPlcClient>(creator: oc => oc.Get<XinJEPlcClient>(
			InjectArgument.Create<INetworkSocketConfig>(Config.Plc)));
		await StartUi();
		await base.OnInitialize(ctx, args);
	}

	protected override async Task OnStart(object? ctx, object? args)
	{
#if ASM15_1

#endif
		await StartTaskServices();
		var recipeService = IOC.Get<RecipeService>();
		recipeService.LoadRecipes().Unwarp("Recipes load failed!");
		var connectionManageService = IOC.Get<ConnectionManageService>();
		connectionManageService.RegisterConnection("PLC", IOC.Get<XinJEPlcClient>());
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