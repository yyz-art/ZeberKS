using ZitApp.BinStructs;
using ZitApp.Services;

namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class SuctionHeadVM : UiVM<SuctionHeadView>
{
	public partial PlcStruct PlcRead { get; set; } = new();
	public required PlcService Plc { get; init; }

	public override Task Initialize(object? ctx, object? args)
	{
		PlcRead = Plc.Read;
		return base.Initialize(ctx, args);
	}
}