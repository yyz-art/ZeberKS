using System.Collections.Specialized;
using Avalonia.Threading;
using NLog;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.UI.Account;


namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MainVM : UiVM<MainView>
{
#if ASM15_1
	public required ScrewService ScrewService { get; init; }
	public ScrewMachineData ScrewData => field ??= (Design.IsDesignMode ? new ScrewMachineData() : ScrewService.Data)!;
#endif
	public required CoreService CoreService { get; init; }
	public partial PlcStruct PlcRead { get; set; } = new();
	public required PlcService Plc { get; init; }
	public required AppConfig AppConfig { get; init; } = new();


	private void @UiTick()
	{
		Axis1Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
		Axis2Percent = 0.1 + Random.Shared.NextDouble() * 0.8;
	}

	#region LOG

	public required LogRecordService LogRecordService { get; init; }

	public partial ObservableList<LogEventInfo> Logs { get; set; } = [new(), new()];

	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		Logs = LogRecordService.LogRecords;
		Logs.CollectionChanged += OnLogsCollectionChanged;

		PlcRead = Plc.Read;
		return base.Initialize(ctx, args);
	}

	private void OnLogsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		Dispatcher.UIThread.Post(() =>
		{
			if (View.LogsDataGrid.IsPointerOver == false)
			{
				View.LogsDataGrid.SelectedItem = Logs.LastOrDefault();
				View.LogsDataGrid.ScrollIntoView(View.LogsDataGrid.SelectedItem, null);
			}
		});
	}

	#endregion

	#region WorkPosition

	public partial string LeftBarcode { get; set; } = "XXXXXX-L";
	public partial PassState LeftPassState { get; set; } = PassState.OK;
	public partial string RightBarcode { get; set; } = "xxxxxx-L";
	public partial PassState RightPassState { get; set; } = PassState.NA;
	public partial ObservableList<string> LeftImageNames { get; set; } = ["A-png", "B-png", "C-png"];
	public partial ObservableList<string> RightImageNames { get; set; } = ["A-png", "B-png", "C-png"];

	#endregion

	#region Axis

	public partial double Axis1Percent { get; set; } = 0.5;
	public partial double Axis2Percent { get; set; }

	#endregion


	#region Feeder

	public Task @FeederUnlock()
	{
		return Task.CompletedTask;
	}

	public required ReplaceMonoVM ReplaceMonoVM { get; init; }


	public Task @StartReplaceMono()
	{
		ReplaceMonoVM.Show();
		return Task.CompletedTask;
	}

	#endregion
}