namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(NgServiceBase)])]
public class NgService : NgServiceBase
{
}
