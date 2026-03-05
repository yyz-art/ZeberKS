namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class AxisTrackVM : UiVM<AxisTrackView>
{
	public partial double Axis1Percent { get; set; }
	public partial double Axis2Percent { get; set; }

	public void @UiTick()
	{
		// Axis1Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
		// Axis2Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
	}
}