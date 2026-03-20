using System.Runtime.CompilerServices;
using HslCommunication.ModBus;using ZC;
using ZC.Development;
using ZC.EnhanceApp;
using ZC.Web.Server;
using ZC.Net;
using ZC.Net.Sockets;
using SqlSugar;
using TestConsole;
using ZitApp.EAP;
using ZitApp.SIFS;
using ZitApp.Utils;

var modbusTcpNet = new ModbusTcpNet("127.0.0.1",502);
var operateResult = modbusTcpNet.Read("100",1);
DevUtils.DebugMode = DevDebugMode.LocalDebug;
EnhanceAppCore.InitializeEnvironment();
ObjectContainerOptions.Default.EnableCyclicDependencyCheck = true;
var config = new AppConfig
{
};
config = Debugger.IsAttached ? config : AppCore.LoadConfig<AppConfig>();
var app = new App(config).UseLogger()
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonAppCore).Assembly.GetTypes(), RegistrationMode.Override)
	.AddToIOC(typeof(CommonUiAppCore).Assembly.GetTypes(), RegistrationMode.Override);

await app.Initialize();
await app.Start();
 var eapService = app.IOC.AddSingleton<EapServiceBase>().Get<EapServiceBase>(
 	null,
 	arg: InjectArgument.Create(new TcpServerSocket("127.0.0.1", 23456)));
 eapService.RegisterHandlerMethods();
 await eapService.Start();
 while (true)
{
	// var client = new SifsClient(new NetworkSocketConfig("127.0.0.1", 502));
	// client.Test();
}

var generator = new BinStructSourceGenerator();
var projectNames = new String[] { "ASM-15"};
var templatePath = "E:\\XKJ-ZEBER\\src\\apps\\{0}\\Ext\\BinStructs\\BinStructs.xml";
generator.Generate( File.ReadAllText(string.Format(templatePath,"ASM15-1")));
generator.Generate( File.ReadAllText(string.Format(templatePath,"ASM15-2")));
generator.Generate( File.ReadAllText(string.Format(templatePath,"MFG-15")));
generator.Generate( File.ReadAllText(string.Format(templatePath,"ASM-4")));
generator.Generate( File.ReadAllText(string.Format(templatePath,"ASM-12")));
generator.Generate( File.ReadAllText(string.Format(templatePath,"SUB1")));
Environment.Exit(0);

var filesZipToLocalFs = ZipUtils.CreateFilesZipToLocalFS("/out-z.zip", [
	"E:\\XKJ-ZEBER\\build\\define\\DefBase.csproj",
	"E:\\XKJ-ZEBER\\build\\define\\DefCore.csproj",
]);
await filesZipToLocalFs.UnwarpAsync();
Console.WriteLine("Hello World!");

public sealed class App(AppConfig config) : CommonUiAppCore
{
	public new AppConfig Config { get; set; } = config;
	protected override async Task OnInitialize(object? ctx, object? args)
	{
		await base.OnInitialize(ctx, args);
	}



	protected override async Task OnStart(object? ctx, object? args)
	{
		await StartTaskServices();
	}
}

public static partial class Program
{
	// public static AppBuilder BuildAvaloniaApp() => UiApp.Build();
}

public static class AppLoader
{
#if RELEASE
	[ModuleInitializer]
#endif
	public static void Initialize() => CommonLibLoader.Initialize();
}