using System.Collections.Specialized;
using Avalonia.Threading;
using NLog;
using ZC.Mvvm;
using ZitApp.Services;

namespace ZitApp.UI.Main;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class RunLogVM : CommonUiVM
{
	public required LogRecordService LogRecordService { get; init; }

	public partial ObservableList<LogEventInfo> Logs { get; set; } = [new(), new()];

	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		Logs = LogRecordService.LogRecords;
		Logs.CollectionChanged += OnLogsCollectionChanged;


		return base.Initialize(ctx, args);
	}

	private void OnLogsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		Dispatcher.UIThread.Post(() =>
		{
			if (View is RunLogView runLogView)
			{
				if (runLogView.LogsDataGrid.IsPointerOver == false)
				{
					runLogView.LogsDataGrid.SelectedItem = Logs.LastOrDefault();
					runLogView.LogsDataGrid.ScrollIntoView(runLogView.LogsDataGrid.SelectedItem, null);
				}
			}
		});
	}
}