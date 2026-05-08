namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(AlarmServiceBase)])]
public class AlarmService : AlarmServiceBase
{
}