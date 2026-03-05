using ZC;
using ZitApp.Services;
using ZitApp.UI.Main;
using ZitApp.UI.Views;
using ZitApp.UI.Views.Main;
using RunLogVM = ZitApp.UI.Main.RunLogVM;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
	public required RunLogVM RunLogVM { get; init; }
	public required FeederVM FeederVM { get; init; }
	public required SuctionHeadVM SuctionHeadVM { get; init; }
	public required CoreService CoreService { get; init; }
	public required AxisTrackVM AxisTrackVM { get; init; }
}