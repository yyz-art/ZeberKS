using ZitApp.BinStructs;
using ZitApp.Services;

namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class FeederVM : CommonUiVM<FeederView>
{
	public partial PlcStruct PlcRead { get; private set; } = new PlcStruct();
	public required PlcService Plc { get; init; }
	public override Task Initialize(object? ctx, object? args)
	{
		PlcRead = Plc.Read;
		return base.Initialize(ctx, args);
	}

	public Task @Unlock()
	{
		return Task.CompletedTask;
	}
	
	public Task @Lock()
	{
		return Task.CompletedTask;
	}
}