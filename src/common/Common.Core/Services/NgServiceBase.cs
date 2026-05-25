using System.Collections.Concurrent;
using ZC;
using ZC.DB;
using ZC.IFS.Objects;
using ZC.LOG;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public class NgServiceBase : AsyncMainTaskService, INamedObject
{
	public required ISqlDbClient DbClient { get; init; }
	public required ILogger Logger { get; init; }

	private ConcurrentQueue<NgRecord> NgQueue { get; init; } = new();

	public void PushNg(NgRecord record)
	{
		NgQueue.Enqueue(record);
	}

	public async Task<Result<List<NgRecord>>> QueryAsync(DateTime? start, DateTime? end, int? stationId, string? snCode, int count = 200)
	{
		try
		{
			var query = DbClient.Queryable<NgRecord>();

			if (start.HasValue)
				query = query.Where(t => t.CreateTime >= start.Value);
			if (end.HasValue)
				query = query.Where(t => t.CreateTime < end.Value.AddDays(1));
			if (stationId.HasValue)
				query = query.Where(t => t.StationId == stationId.Value);
			if (string.IsNullOrEmpty(snCode) is false)
				query = query.Where(t => t.SnCode.Contains(snCode));

			var records = await query.OrderByDescending(t => t.Id).Take(count).ToListAsync();
			return Result.Ok(records);
		}
		catch (Exception ex)
		{
			return Result.Err<List<NgRecord>>(ex);
		}
	}

	public string GetObjectName() => "NG-SERVICE";

	protected override async Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			if (false == NgQueue.TryDequeue(out var record))
			{
				await Task.Delay(100, ctk);
				continue;
			}

			try
			{
				await DbClient.Insertable(record).ExecuteCommandAsync(ctk);
				Logger.Info("NG record saved: SN={sn}, Station={station}", record.SnCode, record.StationName);
			}
			catch (Exception ex)
			{
				Logger.Error(ex, "save ng record failed!");
			}
		}
	}
}
