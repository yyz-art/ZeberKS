using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.Alarm;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class AlarmQueryVM : UiVM
{
	public required AlarmService AlarmService { get; init; }
	public partial List<AlarmRecord> Records { get; private set; } = [];

	public async Task @ReloadRecords()
	{
		
		var getRecordsResult = await AlarmService.GetLatestAlarmRecordAsync(500);
		if (getRecordsResult.IsError())
		{
			ShowNotification($"load alarm records failed! \n{getRecordsResult}", UiMessageType.Error);
			return;
		}

		Records = getRecordsResult.Value!;
	}

}