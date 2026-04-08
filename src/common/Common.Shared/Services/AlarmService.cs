// using System.Collections.Concurrent;
// using ZC;
// using ZC.DB;
// using ZC.IFS.Objects;
// using ZC.LOG;
// using ZitApp.EAP;
// using ZitApp.Models;
//
// namespace ZitApp.Services;
//
// [RegisterToIOC(LifetimeType.Singleton)]
// [RegisterToTaskService(TaskStartMode.Automatic)]
// public class AlarmService : AsyncMainTaskService, INamedObject
// {
// 	public required ISqlDbClient DbClient { get; init; }
// 	public required ILogger Logger { get; init; }
// 	public required EapServiceBase EapServiceBase { get; init; }
//
// 	private ConcurrentQueue<object> AlarmQueue { get; init; } = new();
//
// 	public void PushAlarm(object? sender, object alarm, object? args)
// 	{
// 		AlarmQueue.Enqueue(alarm);
// 	}
//
// 	public async Task<Result<List<AlarmRecord>>> GetLatestAlarmRecordAsync(int count)
// 	{
// 		try
// 		{
// 			var latestRecords = await DbClient.Queryable<AlarmRecord>()
// 				.OrderByDescending(t => t.Id).Take(count)
// 				.ToListAsync();
// 			return Result.Ok(latestRecords);
// 		}
// 		catch (Exception ex)
// 		{
// 			return Result.Err<List<AlarmRecord>>(ex);
// 		}
// 	}
//
// 	public string GetObjectName() => "ALARM-SERVICE";
//
// 	protected override async Task Main(CancellationToken ctk)
// 	{
// 		while (ctk.IsCancellationRequested == false)
// 		{
// 			if (false == AlarmQueue.TryDequeue(out var alarmData))
// 				await Task.Delay(100, ctk);
// 			var alarmInfo = alarmData as AlarmInfo;
// 			if (alarmInfo is null) continue;
// 			Logger.Info("ALARM {name} : {status}", alarmInfo.Name, alarmInfo.Value);
// 			var lastRecord = await DbClient.Queryable<AlarmRecord>().OrderByDescending(t => t.Id)
// 				.FirstAsync(t => t.AlarmId == alarmInfo.Id);
// 			if (alarmInfo.Value == 1)
// 			{
// 				if (lastRecord != null && lastRecord.Status != AlarmStatus.OFF) continue;
// 				var record = new AlarmRecord
// 					{ AlarmId = alarmInfo.Id, Name = alarmInfo.Name, StartTime = DateTime.Now, Status = AlarmStatus.ON };
// 				Debug.Assert(alarmInfo.Name != null);
// 				await DbClient.Insertable(record).ExecuteCommandAsync(ctk);
// 				EapServiceBase.ReportAlarm(record);
// 			}
// 			else if (lastRecord != null)
// 			{
// 				if (lastRecord.Status != AlarmStatus.ON) continue;
// 				lastRecord.EndTime = DateTime.Now;
// 				lastRecord.Status = AlarmStatus.OFF;
// 				await DbClient.Updateable(lastRecord).ExecuteCommandAsync(ctk);
// 				EapServiceBase.ReportAlarm(lastRecord);
// 			}
// 		}
// 	}
// }