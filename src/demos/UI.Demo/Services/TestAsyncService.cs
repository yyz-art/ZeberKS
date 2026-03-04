using Oinet;
using Oinet.LOG;
using Oinet.Mvvm;

namespace OinetApp.Services;

[ObservableObject, RegisterToIOC(LifetimeType.Singleton), RegisterToTask(TaskStartMode.Automatic)]
public partial class TestAsyncService : MainTaskService
{
	public override ITaskServiceOptions ServiceOptions => DefaultAsyncTaskServiceOptions;
	public partial int Counter { get; set; }
	public required ILogger Logger { get; set; }

	protected override async Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			Counter += 1;
			// Logger.Debug("Hello World! {counter}", Counter);
			await Task.Delay(1000, ctk);
		}
	}
}