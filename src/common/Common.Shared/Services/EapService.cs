// using ZC.Net.Sockets;
// using ZitApp.EAP;
//
// namespace ZitApp.Services;
//
// [RegisterToIOC(LifetimeType.Singleton)]
// public class EapServiceBase : EapServiceBase
// {
// 	public NetworkSocket Socket { get; private set; }
//
// 	[Inject]
// 	public void Initialize(AppConfig config)
// 	{
// 		Socket = new NetworkSocket(config.EapHostIp, config.EapHostPort);
// 	}
// }