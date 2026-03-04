using Oinet.MetaInfo;

namespace OinetApp.Assets.Data.I18N;

[RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class I18N : Oinet.RES.ResourceDictionary
{
	public override TypeMetaInfo TypeInfo => field ??= typeof(I18N);
	public partial string AppName { get; set; } = "App";
}