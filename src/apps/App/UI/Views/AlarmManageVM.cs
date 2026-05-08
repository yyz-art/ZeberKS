using ZC.MetaInfo;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.Alarm;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
public partial class AlarmManageVM : CommonUiVM<AlarmManageView>
{
	public List<IPropertyInstance> PropertyInstances { get; } =
		TypeMetaInfo<PlcAlarmStruct>.Cache.Properties.Where(t => t.Attributes
				.Any(attr => attr is ValueInfoAttribute))
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public required PlcService Plc { get; init; }

	public AlarmManageVM()
	{
		var nameByLanguageKey = $"NameBy{App.Current.Language}";
		foreach (var propertyInstance in PropertyInstances)
		{
			var valueInfo = propertyInstance.ValueInfo as ValueInfoAttribute;
			if (valueInfo is null) continue;
			propertyInstance.TempData1 = valueInfo.GetAttachData("Id".AsMemory()).Value;
			valueInfo.Description ??= valueInfo.GetAttachData("TipMessage".AsMemory()).Value?.ToString();
			valueInfo.DisplayName = valueInfo.GetAttachData(nameByLanguageKey.AsMemory()).Value?.ToString();
		}
	}

	protected override Task OnInitialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Reset(Plc.ReadAlarm);
			propertyInstance.CanRead = true;
		}

		return base.OnInitialize(ctx, args);
	}

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