using Oinet.Mvvm;

namespace OinetApp.Services;

[ObservableObject, RegisterToIOC(LifetimeType.Singleton), RegisterToTask(TaskStartMode.Automatic)]
public partial class TestLoopService : MainLoopTaskService
{
	public override ITaskServiceOptions ServiceOptions => DefaultAsyncTaskServiceOptions;
	public override TimeSpan GetLoopInterval() => TimeSpan.FromSeconds(1);
	public partial int Counter { get; set; }

	protected override Task MainLoop()
	{
		Counter += 1;
		return Task.CompletedTask;
	}
}