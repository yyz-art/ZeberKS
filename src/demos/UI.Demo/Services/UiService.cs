using Oinet.UI.Tasks;

namespace OinetApp.Services;

[RegisterToTask(TaskStartMode.Automatic)]
[RegisterToIOC(LifetimeType.Singleton)]
public class UiService : UiAsyncMainTaskService
{

	protected override async Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			await Task.Delay(1000, ctk);
		}
	}
}