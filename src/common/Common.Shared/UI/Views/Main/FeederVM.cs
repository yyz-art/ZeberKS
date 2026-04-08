using ZitApp.BinStructs;
using ZitApp.Services;
using ZitApp.UI.Account;

namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class FeederVM : CommonUiVM<FeederView>
{
	public partial PlcStruct PlcRead { get; private set; } = new PlcStruct();
	public required CoreService CoreService { get; init; } = new CoreService
	{
		ConnectionManageService = null,
		Logger = null,
		Plc = null,
		Recipe = null
	};
	public required PlcService Plc { get; init; }

	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
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

	public required ReplaceMonoVM ReplaceMonoVM { get; init; }

	public Task @StartReplaceMono()
	{

		ReplaceMonoVM.Show();
		return Task.CompletedTask;
	}
}