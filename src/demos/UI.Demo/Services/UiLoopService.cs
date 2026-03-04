using Oinet.UI.Tasks;

namespace OinetApp.Services;

[RegisterToTask(TaskStartMode.Automatic)]
[RegisterToIOC(LifetimeType.Singleton)]
public class UiLoopService : UiMainLoopTaskService
{
	public override string ServiceName => nameof(UiLoopService);
	public override TimeSpan GetLoopInterval() => TimeSpan.FromSeconds(1);

	protected override Task MainLoopInitialize(bool isFirstRun)
	{
		// Console.WriteLine($"Loop Initializing isFirstRun:{isFirstRun}");
		return Task.CompletedTask;
	}

	protected override Task MainLoop()
	{
		// Console.WriteLine($"Loop On Thread {Thread.CurrentThread.Name}");
		return Task.CompletedTask;
	}
}