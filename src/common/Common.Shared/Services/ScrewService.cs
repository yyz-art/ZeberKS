using System.Text.Json;
using HslCommunication.ModBus;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Memory;
using ZC.LOG;
using ZC.Mvvm;
using ZC.Shared.DefaultJson;
using ZitApp.Devices.Screw;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
public partial class ScrewService : MainTaskService
{
	public override string ServiceName => field ??= $"{Connection.Name}-SERVICE";
	public ScrewMachineData Data { get; private set; } = new();


	public bool EnableWaveCollect { get; set; } = true;
	public List<double> WaveChannel1RealData { get; } = [];
	public List<double> WaveChannel2RealData { get; } = [];
	public partial ScrewMachineControlCommand ControlCommand { get; set; }
	public required ScrewMachineConnection Connection
	{
		get;
		init
		{
			field = value;
			Data.Connection = value;
		}
	}
	public required ILogger Logger { get; init; }
	public const int ChartDataBaseAddress = 10000; // 波形数据基准地址
	public const int WaveChannelPointCount = 2; // 通道数
	public const int WavePointTotalCount = 600; // 总点数
	public const int MaxReadBlock = 100; // 每次读取点数（避免超过 Modbus 限制）

	public Result SetControlCommand(ScrewMachineControlCommand cmd)
	{
		Data.电批动作控制 = cmd;
		var result = Data.WritePoint(nameof(ScrewMachineData.电批动作控制));
		return result;
	}

	public static int GetTaskOptionsChannelOffset(int channel)
	{
		return 4000 + channel * 150;
	}

	partial void OnControlCommandChanged(ScrewMachineControlCommand value)
	{
		Logger.Debug($"命令状态改变: {value}");
		// var data = JsonSerializer.Serialize(ScrewMachine.Data.AsIScrewRealPartData(),Global.Json.DefaultIndentOptions);
		// Logger.Debug(data);
	}

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected override Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{

			var readRealPartDataResult = Data.ReadPointGroup(ScrewMachineDataStructInfo.ScrewRealPartData, Connection);;
			if (readRealPartDataResult.IsError())
			{
				Logger.Error(readRealPartDataResult.Exception, "读取实时数据失败! {msg}",
					readRealPartDataResult.Message);
				goto TpsError;
			}

			// var data = JsonSerializer.Serialize(ScrewMachine.Data.AsIScrewRealPartData(),Global.Json.DefaultIndentOptions);
			// Logger.Debug(data);
			var read1Result = Data.ReadPoint(nameof(ScrewMachineData.电批动作控制));
			if (read1Result.IsOk())
			{
				ControlCommand = Data.电批动作控制;
			}


			var isBusy = BitUtils.GetBit(Data.输出状态, 16);
			if (EnableWaveCollect && isBusy)
			{
				var sampledPoints = Data.此次波形采集数量;
				var channelMaxTmpBufLen = WavePointTotalCount / WaveChannelPointCount;
				var ch1Base = ChartDataBaseAddress;
				var ch2Base = ch1Base + channelMaxTmpBufLen;
				WaveChannel1RealData.Clear();
				WaveChannel2RealData.Clear();
				ReadWaveChannel(Connection, ch1Base, channelMaxTmpBufLen,
					sampledPoints, WaveChannel1RealData);
				ReadWaveChannel(Connection, ch2Base, channelMaxTmpBufLen,
					sampledPoints, WaveChannel2RealData);
			}
			else
			{
				if (WaveChannel1RealData.Count > 0)
					OnWaveDataCollectCompleted(1, WaveChannel1RealData);
				if (WaveChannel2RealData.Count > 0)
					OnWaveDataCollectCompleted(2, WaveChannel2RealData);
				WaveChannel1RealData.Clear();
				WaveChannel2RealData.Clear();
			}

			CommonSleep:
			Thread.Sleep(500);
			continue;
			TpsError:
			Thread.Sleep(15000);
		}

		return Task.CompletedTask;
	}

	private void OnWaveDataCollectCompleted(int channel, List<double> data)
	{
		Logger.Debug("WaveData {channel}: {@data}", channel, data);
	}


	private Result ReadWaveChannel(
		ModbusRtuOverTcp connection,
		int baseAddr,
		int channelTmpBufLen,
		int pointCursor, // 全局采样点数
		List<double> wavePoints)
	{
		var collectedPointCount = wavePoints.Count;
		var toDoCollectCount = pointCursor - collectedPointCount;
		if (toDoCollectCount < 0)
			return Result.Err("已采集的波形数据数量错误");
		if (toDoCollectCount == 0)
			return Result.OK; // 没有新数据需要采集

		// 当前游标位置
		int cursor = pointCursor % channelTmpBufLen;

		// 第一段：从游标到缓冲区末尾，最多采集 toDoCollectCount
		int firstPartLen = Math.Min(channelTmpBufLen - cursor, toDoCollectCount);
		if (firstPartLen > 0)
		{
			int firstPartBaseAddr = baseAddr + cursor;
			for (int offset = 0; offset < firstPartLen; offset += MaxReadBlock)
			{
				int len = Math.Min(MaxReadBlock, firstPartLen - offset);
				var read = connection.ReadUInt16((firstPartBaseAddr + offset).ToString(), (ushort)len);
				if (!read.IsSuccess)
					return Result.Err($"读取失败: {read.Message}");
				wavePoints.AddRange(read.Content.Select(v => (double)v));
			}

			toDoCollectCount -= firstPartLen;
		}

		// 第二段：从缓冲区起始到游标前，采集剩余的 toDoCollectCount
		int secondPartLen = Math.Min(cursor, toDoCollectCount);
		if (secondPartLen > 0)
		{
			for (int offset = 0; offset < secondPartLen; offset += MaxReadBlock)
			{
				int len = Math.Min(MaxReadBlock, secondPartLen - offset);
				var read = connection.ReadUInt16((baseAddr + offset).ToString(), (ushort)len);
				if (!read.IsSuccess)
					return Result.Err($"读取失败: {read.Message}");
				wavePoints.AddRange(read.Content.Select(v => (double)v));
			}
		}

		return Result.OK;
	}
}