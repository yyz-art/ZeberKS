// using System.ComponentModel;
// using HslCommunication.ModBus;
// using ZC;
// using ZC.BinStructs;
// using ZC.BinStructs.Ext;
// using ZC.LOG;
// using ZC.MetaInfo;
// using ZC.Mvvm;
// using ZC.Utils;
// using ZitApp.BinStructs;
// using ZitApp.Devices.Plc;
// using ZitApp.Models;
//
// namespace ZitApp.Services;
//
// [RegisterToIOC(LifetimeType.Singleton)]
// [RegisterToTaskService(TaskStartMode.Automatic)]
// [ObservableObject]
// public partial class PlcService : PlcServiceBase
// {
// 	public required AlarmService AlarmService { get; init; }
// 	public PlcStruct Read { get; } = new();
// 	public PlcAlarmStruct ReadAlarm { get; } = new();
// 	public PlcStruct Write { get; } = new();
//
// 	protected override Task OnInitialize(object? ctx, object? args)
// 	{
// 		Read.Connection = Plc;
// 		Write.Connection = Plc;
// 		ReadAlarm.PropertyChanged += OnPlcAlarmChanged;
// 		return base.OnInitialize(ctx, args);
// 	}
//
// 	private void OnPlcAlarmChanged(object? sender, PropertyChangedEventArgs e)
// 	{
// 		if (e.PropertyName is null || false ==
// 		                           PlcAlarmStructInfo.StructInfo.Members.TryGetValue(e.PropertyName.AsMemory(),
// 			                           out var memberInfo)
// 		                           || memberInfo is not IBinaryPointInfo pointInfo)
// 			return;
// 		var property = TypeMetaInfo<PlcAlarmStruct>.Cache.GetProperty(e.PropertyName);
// 		if (property?.ValueInfo is null || property.CanRead == false)
// 			return;
// 		int.TryParse(property.ValueInfo?.GetAttachData("Id".AsMemory()).Value?.ToString() ?? "0", out var id);
// 		Debug.Assert(id != 0);
// 		var value = property.Getter!.Invoke(sender) is WordBool t ? t : default;
// 		var alarmInfo = new AlarmInfo { Id = id, Name = e.PropertyName, Value = value == WordBool.True ? 1 : 0 };
// 		AlarmService.PushAlarm(this, alarmInfo, sender);
// 	}
//
// 	protected override Task Main(CancellationToken ctk)
// 	{
// 		while (ctk.IsCancellationRequested == false)
// 		{
// 			if (EnableCollect == false)
// 			{
// 				Thread.Sleep(50);
// 				continue;
// 			}
//
// 			var now = DateTime.Now;
// 			if (now - HeartbeatTime > TimeSpan.FromSeconds(1))
// 			{
// 				Write.上位机心跳 = (short)(Write.上位机心跳 == 1 ? 0 : 1);
// 				var write心跳Result = Write.WritePoint(nameof(PlcStruct.上位机心跳));
// 				if (write心跳Result.IsError())
// 				{
// 					Status = "连接异常";
// 					IsConnected = false;
// 					Logger.Error(write心跳Result.Exception, "Heartbeat write falied! {}", write心跳Result.Message);
// 					// if (Debugger.IsAttached == false)
// 					Thread.Sleep(10000);
// 					continue;
// 				}
//
// 				HeartbeatTime = DateTime.Now;
// 			}
//
// 			Read.ReadPointGroup(PlcStructInfo.交互toPC_Part1).Unwarp("Read to pc part1 failed!");
// 			Read.ReadPointGroup(PlcStructInfo.交互toPLC_Part1).Unwarp("Read to plc part1 failed!");
// 			ReadAlarm.ReadPointGroup(PlcAlarmStructInfo.Part1, Plc).Unwarp("Read alarm failed!");
//
// 			InternalCycleTaskCompletionSource?.TrySetResult();
// 			unchecked
// 			{
// 				IsConnected = true;
// 				CycleId++;
// 				Status = "连接正常";
// 			}
//
// 			Thread.Sleep(50);
// 		}
//
// 		return Task.CompletedTask;
// 	}
// }