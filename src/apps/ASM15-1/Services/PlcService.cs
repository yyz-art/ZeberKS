using HslCommunication.ModBus;
using ZC;
using ZC.BinStructs.Ext;
using ZC.LOG;
using ZC.Mvvm;
using ZC.Utils;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
[ObservableObject]
public partial class PlcService : PlcServiceBase
{
	public PlcStruct Read { get; } = new();
	public PlcStruct Write { get; } = new();
	protected override Task OnInitialize(object? ctx, object? args)
	{
		Read.Connection = Plc;
		Write.Connection = Plc;
		return base.OnInitialize(ctx, args);
	}
	
	protected override Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			if (EnableCollect == false)
			{
				Thread.Sleep(50);
				continue;
			}

			var now = DateTime.Now;
			if (now - HeartbeatTime > TimeSpan.FromSeconds(1))
			{
				Write.上位机心跳 = (short)(Write.上位机心跳 == 1 ? 0 : 1);
				var write心跳Result = Write.WritePoint(nameof(PlcStruct.上位机心跳));
				if (write心跳Result.IsError())
				{
					Status = "连接异常";
					IsConnected = false;
					Logger.Error(write心跳Result.Exception, "Heartbeat write falied! {}", write心跳Result.Message);
					// if (Debugger.IsAttached == false)
					Thread.Sleep(10000);
					continue;
				}

				HeartbeatTime = DateTime.Now;
			}

			Read.ReadPointGroup(PlcStructStructInfo.交互toPC_Part1).Unwarp("Read to pc part1 failed!");
			Read.ReadPointGroup(PlcStructStructInfo.交互toPLC_Part1).Unwarp("Read to plc part1 failed!");
			InternalCycleTaskCompletionSource?.TrySetResult();
			unchecked
			{
				IsConnected = true;
				CycleId++;
				Status = "连接正常";
			}

			Thread.Sleep(50);
		}

		return Task.CompletedTask;
	}
}