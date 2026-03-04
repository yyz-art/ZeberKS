using Oinet;
using Oinet.DB;
using Oinet.Development;
using Oinet.EnhanceApp;
using Oinet.Net;
using Oinet.Utils;
using Oinet.Web.Server;
using OinetApp.Ext;
using SqlSugar;

DevUtils.DebugMode = DevDebugMode.LocalDebug;
EnhanceAppCore.InitializeEnvironment();
ObjectContainerOptions.Default.EnableCyclicDependencyCheck = true;

var config = new AppConfig
{
	TaskServiceHostOptions = TaskServiceHostOptions.CreateDefault(),
	Databases = [new DatabaseConnectionConfig(null, DatabaseType.Sqlite, @"Data Source=data/app.db")],
};
config = Debugger.IsAttached ? config : AppCore.LoadConfig<AppConfig>();
var app = new App(config).UseLogger().UseUi(UiApp.StartAsync)
	.AddToIOC(typeof(App).Assembly.GetTypes(), RegistrationMode.Override)
	.UseDatabase(config.Databases).UseDbKeyValueStorage().UseWebServer();

await app.Initialize().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
await app.Start().UnwarpAsync(errThrow: true, success: _ => { }, onError: r => { });
while (true) await Task.Delay(1000);

namespace OinetApp
{
	public sealed class App(AppConfig config) : EnhanceAppCore<App, AppConfig>(config)
	{
		protected override async Task<Result> OnInitialize(object? context = null, CancellationToken ctk = default)
		{
			await StartUi();
			// IOC.GetOrNull<IAppStartUpVM>()?.SetProgress(40, 500);
			using var dbClient = IOC.Get<ISqlSugarClient>();
			// dbClient.CodeFirst.InitTables<User>();
			return default;
		}

		protected override async Task<Result> OnStart(object? context = null, CancellationToken ctk = default)
		{
			// var splashVM = IOC.GetOrNull<IAppStartUpVM>();
			await StartTaskServices();
			var tcpServerSocket = new TcpStreamServerSocket("0.0.0.0", 80);
			var httpServer = IOC.Get<HttpServer>();
			tcpServerSocket.Acceptor = httpServer;
			await tcpServerSocket.StartAsync().UnwarpAsync();
			// splashVM?.SetProgress(100, 500);
			Task.Run(async () =>
			{
				await Task.Delay(3000);
				if (Debugger.IsAttached == false) ConsoleUtils.FreeConsole();
			});
			return default;
		}
	}

	
}
public static partial class Program
{
	public static AppBuilder BuildAvaloniaApp() => UiApp.Build();
}