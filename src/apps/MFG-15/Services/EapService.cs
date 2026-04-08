using ZitApp.EAP;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(EapServiceBase)])]
public class EapService : EapServiceBase
{
	
}