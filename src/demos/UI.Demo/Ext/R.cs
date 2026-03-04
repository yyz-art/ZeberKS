using Oinet;

namespace OinetApp.Ext;

public static class R
{
	public static Assets.Data.I18N.I18N I18N => field ??= AppCore.Current.IOC.Get<Assets.Data.I18N.I18N>();
}