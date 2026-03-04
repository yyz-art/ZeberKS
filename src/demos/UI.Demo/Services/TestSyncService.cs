using Oinet;
using Oinet.LOG;
using Oinet.Mvvm;

namespace OinetApp.Services;

[ObservableObject, RegisterToIOC(LifetimeType.Singleton), RegisterToTask(TaskStartMode.Automatic)]
public partial class TestSyncService : MainTaskService
{
	public override ITaskServiceOptions ServiceOptions => DefaultLongRunningTaskServiceOptions;
	public partial int Counter { get; private set; }
	public required ILogger Logger { get; init; }

	protected override Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			Counter += 1;
			// Logger.Debug("Hello World! {counter};", Counter);
			Thread.Sleep(1000);
		}

		return Task.CompletedTask;
	}
}