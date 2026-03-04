using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.DP.Memory;
using ZC.LOG;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZitApp.Devices.Screw;
using ZitApp.Models.RP;

namespace ZitApp.UI.Views.Devices;

public partial class TaskOptionEditContext : ObservableObject
{
	public partial string? Unit { get; set; }
	public partial string? Description { get; set; }
	public object? MinValue { get; set; }
	public object? MaxValue { get; set; }
}

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ScrewVM : UiViewModel<ScrewView>
{
	[Inject(Name = "SCREW-VM")] public required ILogger Logger { get; init; }
	[Inject(SpecialName = "L")] public required ScrewMachine ScrewMachine { get; set; }
	public partial int EditRecipePropertiesChannel { get; set; }
	public partial ScrewMachineRecipeProperties? EditRecipeProperties { get; set; }
	public ObservableList<IPropertyInstance> EditRecipePropertyInstances { get; } = [];
	public partial TimeSpan UiTickInterval { get; set; } = TimeSpan.FromSeconds(1);
	private ScrewMachineRecipeProperties TempReadTaskOptions { get; } = new();

	#region 实时数据

	public partial ScrewMachineControlCommand 实时控制指令 { get; private set; }
	public partial double 实时扭力 { get; set; }
	public partial int 实时任务 { get; set; }
	public partial int 实时圈数 { get; set; }
	public partial int 实时耗时 { get; set; }
	public partial ScrewMachineAlarmCode 实时报警 { get; set; }
	public double[] Values1 { get; set; } =
		[2, 1, 3, 5, 3, 4, 6];

	public int[] Values2 { get; set; } =
		[4, 2, 5, 2, 4, 5, 3];

	#endregion


	partial void OnEditRecipePropertiesChanged(ScrewMachineRecipeProperties? value)
	{
		foreach (var property in EditRecipePropertyInstances)
		{
			property.Reset(value, property.Define);
			property.TempValue1 = null;
			property.TempValue2 = null;
			property.TempValue3 = null;
		}
	}


	public ScrewVM()
	{
		foreach (var property in TypeMetaInfo<ScrewMachineRecipeProperties>.Cache.Properties)
		{
			var propertyInstance = PropertyInstance.Create(null, property);
			var dataContext = new TaskOptionEditContext();
			var valueInfo = property.Attributes.OfType<ValueInfoAttribute>().FirstOrDefault();
			propertyInstance.DataContext = dataContext;
			dataContext.MinValue = valueInfo?.MinValue;
			dataContext.MaxValue = valueInfo?.MaxValue;
			dataContext.Description = valueInfo?.Description;
			dataContext.Unit = valueInfo?.Unit?.ToString();
			EditRecipePropertyInstances.Add(propertyInstance);
		}

		EditRecipeProperties = new ScrewMachineRecipeProperties();
		EditRecipePropertiesChannel = 0;
	}

	private async Task @UiTick()
	{
		var readRealDataResult =
			await ScrewMachine.Data.ReadPointGroupAsync(ScrewMachineDataStructInfo.ScrewRealPartData);
		if (readRealDataResult.IsOk())
		{
			实时任务 = ScrewMachine.Data.任务号;
			实时圈数 = ScrewMachine.Data.实时运行圈数;
			实时扭力 = ScrewMachine.Data.实时扭力;
			实时耗时 = ScrewMachine.Data.实时运行时间;
			实时报警 = ScrewMachine.Data.警报;
		}

		var read1Result = await ScrewMachine.Data.ReadPointAsync(nameof(ScrewMachineData.电批动作控制));
		if (read1Result.IsOk())
		{
			实时控制指令 = ScrewMachine.Data.电批动作控制;
		}
	}

	public async Task @SaveAllPoint()
	{
		foreach (var property in EditRecipePropertyInstances)
		{
			var context = (TaskOptionEditContext)property.DataContext!;
			property.Value = property.TempValue1;
		}

		ShowToast("保存成功!");
	}

	public void @SavePoint(IPropertyInstance property)
	{
		var context = (TaskOptionEditContext)property.DataContext!;
		property.Value = property.TempValue1;
		ShowToast("保存成功!");
	}

	public async Task @ReadPoint(IPropertyInstance property)
	{
		if (EditRecipeProperties is null)
		{
			ShowToast("编辑的螺丝枪配方为空!", UiMessageType.Error);
			return;
		}


		var name = property.Define.Name;
		var structInfo = EditRecipeProperties.GetStructInfo();
		var pointDefineInfo = structInfo.Members[name] as IBinaryPointInfo;
		if (pointDefineInfo is null)
		{
			ShowToast($"点位 '{name}' 定义为空!", UiMessageType.Error);
			return;
		}

		var address = pointDefineInfo.Offset +
		              ScrewMachine.GetTaskOptionsChannelOffset(EditRecipePropertiesChannel);
		if (ReadAllPointCommand.IsRunning == false)
			ShowToast($"读取 '{name}':{address} 中");
		var readResult = await ScrewMachine.Connection.ReadAsync($"{address}", (ushort)pointDefineInfo.ByteLength);
		if (readResult.IsSuccess == false)
		{
			ShowNotification($"读取 '{name}':{address} 失败! {readResult.Message}", UiMessageType.Error);
			return;
		}

		var deserializePointResult = TempReadTaskOptions.DeserializePoint(pointDefineInfo, readResult.Content);
		if (deserializePointResult.IsError())
		{
			ShowNotification($"点位 '{name}':{address} 值解析失败!", UiMessageType.Error);
			return;
		}

		var value = property.Define.Getter!.Invoke(TempReadTaskOptions);
		property.TempValue1 = value;
		if (ReadAllPointCommand.IsRunning == false)
			ShowToast("点位读取成功！", UiMessageType.Success);
	}


	public async Task @WritePoint(IPropertyInstance property)
	{
		if (EditRecipeProperties is null)
		{
			ShowToast("编辑的螺丝枪配方为空!", UiMessageType.Error);
			return;
		}

		var structInfo = EditRecipeProperties.GetStructInfo();
		var pointDefineInfo = structInfo.Members[property.Define.Name] as IBinaryPointInfo;
		if (pointDefineInfo is null)
		{
			ShowToast($"点位 '{property.Define.Name}' 定义为空!");
			return;
		}


		var address = pointDefineInfo.Offset +
		              ScrewMachine.GetTaskOptionsChannelOffset(EditRecipePropertiesChannel!);
		if (WriteAllPointCommand.IsRunning == false)
			ShowToast($"写入 '{property.Define.Name}':{address} 中");
		SpanBuffer<byte> buf = stackalloc byte[128];
		buf.SetLength(buf.Source.Length);
		var deserializePointResult = EditRecipeProperties.SerializePoint(property.Define.Name, buf);
		if (deserializePointResult.IsError())
		{
			ShowNotification($"点位 '{property.Define.Name}':{address} 值解析失败!", UiMessageType.Error);
			return;
		}

		buf.SetLength(deserializePointResult.Value);
		var valueBytes = buf.ToArray();
		var writeResult = await ScrewMachine.Connection.WriteAsync($"{address}", valueBytes);
		if (writeResult.IsSuccess == false)
		{
			ShowNotification($"点位 '{property.Define.Name}':{address} 写入失败! {writeResult.Message}", UiMessageType.Error);
			return;
		}

		if (WriteAllPointCommand.IsRunning == false)
			ShowToast("点位写入成功！", UiMessageType.Success);
	}

	public async Task @ReadAllPoint()
	{
		if (EditRecipeProperties is null)
		{
			ShowToast("编辑的任务为空!", UiMessageType.Error);
			return;
		}

		ShowToast("读取全部点位中...");
		foreach (var propertyInstance in EditRecipePropertyInstances)
		{
			await ReadPoint(propertyInstance);
		}

		ShowToast("读取全部结束");
	}

	public async Task @WriteAllPoint()
	{
		if (EditRecipeProperties is null)
		{
			ShowToast("编辑的任务为空!", UiMessageType.Error);
			return;
		}

		ShowToast("开始写入全部点位中...");

		foreach (var propertyInstance in EditRecipePropertyInstances)
		{
			await WritePoint(propertyInstance);
		}

		ShowToast("写入全部点位完成");
	}

	public async Task @SendControlCommand(ScrewMachineControlCommand cmd)
	{
		ShowToast("发送命令中...");
		ScrewMachine.Data.电批动作控制 = cmd;
		var writeResult =
			await ScrewMachine.Data.WritePointAsync(nameof(ScrewMachineData.电批动作控制), ScrewMachine.Connection);
		if (writeResult.IsError())
		{
			ShowNotification($"命令写入失败！{writeResult.Message}", UiMessageType.Error);
			return;
		}

		ShowToast("命令写入成功", UiMessageType.Success);
	}
}