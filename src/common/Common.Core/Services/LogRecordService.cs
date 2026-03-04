using System.Collections.Concurrent;
using Avalonia.Threading;
using NLog;
using NLog.Targets;
using ZC;
using ZC.Mvvm;
using ZC.UI.Tools;
using ZC.UI.Utils;
using ZC.Utils;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public class LogRecordService : MainTaskService
{
	private ConcurrentQueue<LogEventInfo> Queue { get; } = new();
	public ObservableList<LogEventInfo> LogRecords { get; } = [];
	private List<LogEventInfo> BatchList { get; } = [];

	public void OnLog(LogEventInfo logEvent)
	{
		Queue.Enqueue(logEvent);
	}

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;
	protected override async Task Main(CancellationToken ctk)
	{
		while (!ctk.IsCancellationRequested)
		{
			while (BatchList.Count < 20 && Queue.TryDequeue(out var logEvent))
				BatchList.Add(logEvent);

			if (BatchList.Count > 0)
			{
				await UiUtils.InvokeOnUiThreadAsync(() =>
				{
					if (LogRecords.Count > 1000)
						LogRecords.RemoveRange(0, 100);
					LogRecords.AddRange(BatchList);
					BatchList.Clear();
					return TaskUtils.ConstValues.TaskTrue;
				});
			}

			await Task.Delay(200, ctk);
		}
	}
}

[Target(nameof(LogTarget))]
public class LogTarget : TargetWithLayout
{
	public static LogRecordService? LogService { get; set; } = AppCore.Current.IOC.Get<LogRecordService>();

	protected override void Write(LogEventInfo logEvent)
	{
		LogService?.OnLog(logEvent);
	}
}