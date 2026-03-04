using ZC.LOG;
using ZC.Mvvm;
using ZC.Utils;
using ZitApp.Devices.Plc;

namespace ZitApp.Services;

[ObservableObject]
public abstract partial class PlcServiceBase : MainTaskService
{
	public required ILogger Logger { get; init; }
	public required XinJEPlcClient Plc { get; init; }
	public partial string Status { get; protected set; } = "未连接";
	public partial bool IsConnected { get; protected set; } = false;
	public DateTime HeartbeatTime { get; protected set; }
	public int CycleId { get; protected set; }
	public volatile bool EnableCollect = true;


	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;


	protected override Task<bool> OnMainException(Exception exception)
	{
		Status = "连接异常";
		IsConnected = false;
		Logger.Error(exception, "MAIN EXCEPTION: {msg}", exception.Message);
		Logger.Info("ERROR SLEEPING 15S");
		Thread.Sleep(15000);
		return TaskUtils.ConstValues.TaskTrue;
	}

	public async Task WaitNextCycleAsync(int waitCount = 2, int checkInterval = 50)
	{
		var startCycleId = CycleId;
		while (Math.Abs(CycleId - startCycleId) < waitCount)
			if (checkInterval <= 0)
			{
				var waitTask = CycleTaskCompletionSource.Task;
				await waitTask;
			}
			else
			{
				await Task.Delay(checkInterval);
			}
	}

	public void WaitNextCycle(int waitCount = 2, int checkInterval = 50)
	{
		var startCycleId = CycleId;
		while (Math.Abs(CycleId - startCycleId) < waitCount)
			if (checkInterval <= 0)
			{
				CycleTaskCompletionSource.Task.Wait();
			}
			else
			{
				Thread.Sleep(checkInterval);
			}
	}

	protected TaskCompletionSource? InternalCycleTaskCompletionSource;

	public TaskCompletionSource CycleTaskCompletionSource
	{
		get
		{
			if (InternalCycleTaskCompletionSource is { Task.IsCompleted: false })
				return InternalCycleTaskCompletionSource;
			InternalCycleTaskCompletionSource = null;
			lock (this)
			{
				InternalCycleTaskCompletionSource ??=
					new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
			}

			return InternalCycleTaskCompletionSource;
		}
	}
}