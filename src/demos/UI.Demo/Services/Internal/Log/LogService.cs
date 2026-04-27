using System.Collections.Concurrent;
using NLog;
using Oinet.DB;

namespace OinetApp.Services.Internal.Log;

[ApiController("/logs")]
[RegisterToIOC(LifetimeType.Singleton), RegisterToTask(TaskStartMode.Automatic)]
public class LogService : MainTaskService
{
	public required ISqlDbClient DbClient { get; set; }

	public ConcurrentQueue<LogEventInfo> Queue { get; set; } = new();
	public List<LogRecord> BatchList { get; set; } = [];
	public string SavePropertiesTag { get; set; } = ";";

	protected override Task OnInitialize(object? ctx, object? args)
	{
		DbClient.CodeFirst.InitTables<LogRecord>();
		return base.OnInitialize(ctx, args);
	}

	protected override async Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			await Task.Delay(100, ctk);
			while (Queue.TryDequeue(out var logEvent))
			{
				var record = new LogRecord();
				record.Time = logEvent.TimeStamp;
				record.Logger = logEvent.LoggerName;
				record.Level = logEvent.Level.Name[0];
				record.FormattedMessage = logEvent.FormattedMessage;
				if (logEvent.Properties.Count > 0 && logEvent.Message.EndsWith(SavePropertiesTag))
				{
					record.Message = logEvent.Message;
					// Dictionary<string, object?> dict = new();
					// foreach (var item in logEvent.Properties)
					// {
					// 	dict[(item.Key as string)!] = item.Value!;
					// }
					// record.Properties = dict;
				}


				BatchList.Add(record);
				if (BatchList.Count > 100)
					break;
			}

			if (BatchList.Count <= 0) continue;

			for (var i = 0; i < BatchList.Count; i++)
			{
				await DbClient.Insertable(BatchList).ExecuteCommandAsync(ctk);
				BatchList.Clear();
			}
		}
	}

	public void OnLog(LogEventInfo logEvent)
	{
		Queue.Enqueue(logEvent);
	}

	[HttpGet]
	public Task<List<LogRecord>> GetLastestLogs([FromQuery] int count)
	{
		return DbClient.Queryable<LogRecord>().OrderByDescending(t => t.Time).Take(count).ToListAsync();
	}
}