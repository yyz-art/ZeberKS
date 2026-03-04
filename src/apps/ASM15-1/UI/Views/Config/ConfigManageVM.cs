namespace ZitApp.UI.Config;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ConfigManageVM : UiVM<ConfigManageView>
{
	public partial AppConfig AppConfig { get; set; } = new AppConfig();
}