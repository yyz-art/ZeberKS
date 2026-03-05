namespace ZitApp.UI.Alarm;

[RegisterToIOC(LifetimeType.Singleton)]
public class AlarmManageVM : UiVM<AlarmManageView>
{
	public required AlarmRealWatchVM AlarmRealWatchVM { get; init; }
	public required AlarmQueryVM AlarmQueryVM { get; init; }
}