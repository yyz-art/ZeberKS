using ZC;
using ZC.BinStructs;
using ZC.DP.Memory;

namespace ZitApp.Devices.Screw;

[BinaryStruct(Length = 4096,
	DefaultReader = nameof(Connection),
	DefaultWriter = nameof(Connection), ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "ScrewRealPartData",
	Start = 60625, End = 60660, Points = ["*"],
	ExportInterface = "IScrewRealPartData")]
public partial class ScrewMachineData
{
	static ScrewMachineData()
	{
		var structInfo = ScrewMachineDataStructInfo.StructInfo;
		foreach (var (key, member) in structInfo.Members)
		{
			if (member is BinaryPointInfo pointInfo)
				pointInfo.Source = $"{pointInfo.Offset}";
			else if (member is BinaryPointGroupInfo groupInfo)
				groupInfo.Source = $"{groupInfo.Start}";
		}
	}

	public IBinaryConnection? Connection { get; set; }

	#region 关键操作

	[BinaryPoint(Offset = 61501, Description = "0x1AAA-----保存参数命令    等待3秒")]
	public ushort 保存参数 { get; set; }

	[BinaryPoint(Offset = 61502, Description = "0x2222-----恢复出厂命令    等待3秒")]
	public ushort 恢复出厂 { get; set; }

	[BinaryPoint(Offset = 61507, Description = "0~255   设置完后发送保存命令保存该设备号。")]
	public ushort 本机设备号 { get; set; }

	[BinaryPoint(Offset = 60640, Description = "检查bit 0/1/2 是否有信号")]
	public ushort IO口信号状态 { get; set; }

	/// 在IO口信号状态 (地址:60640) 为无信号状态下  ;
	/// 方可切换控制方式,有信号状态如需切换控制方式，得先撤消控制器IO端口的外部输入信号;
	/// 写入0x3AAA----IO端;
	/// 写入0x3BBB----PC端/触摸屏端;
	[BinaryPoint(Offset = 61506, Description = "")]
	public ScrewControlMode 切换控制电批动作的控制方式 { get; set; }

	[BinaryPoint(Offset = 61500, Description = "在 PC端/触摸屏端  控制模式下如下命令才有效。(IO端控制模式下如吓命令无效。)")]
	public ScrewMachineControlCommand 电批动作控制 { get; set; }

	[BinaryPoint(Offset = 3901, Description = "0--任务00，1--任务01,2--任务02…… ")]
	public ushort 当前执行任务号选择 { get; set; }

	#endregion

	#region 实时数据

	[BinaryPoint(Offset = 60625, Description = "任务00~任务15")]
	public ushort 任务号 { get; set; }

	[BinaryPoint(Offset = 60626, Description = "单位0.01r   返回100表示1r")]
	public ushort 总圈数 { get; set; }

	[BinaryPoint(Offset = 60628, Description = "nM.m")]
	public ushort 最大扭力值 { get; set; }

	[BinaryPoint(Offset = 60629, Description = "正转有效到OK的时间，单位是ms，用于测试结果")]
	public ushort 总拧紧时间 { get; set; }

	[BinaryPoint(Offset = 60630, Description = "0x4AAA--NG,0x4BBB--OK;0x4CCC--未完成")]
	public ushort 最终拧紧结果 { get; set; }

	[BinaryPoint(Offset = 60631, Description = "统计任务总次数(16bit)")]
	public int 统计螺丝总量 { get; set; }

	[BinaryPoint(Offset = 60634, Description = "暂时3ms，固定3ms")]
	public ushort 此次采样时间间隔 { get; set; }

	[BinaryPoint(Offset = 60635, Description = "当前帧的采集的数据长度")]
	public ushort 此次波形采集数量 { get; set; }

	[BinaryPoint(Offset = 60636, Description = "完成任务百分比")]
	public ushort 进程 { get; set; }

	[BinaryPoint(Offset = 60638, Description = "警报编码")]
	public ScrewMachineAlarmCode 警报 { get; set; }

	[BinaryPoint(Offset = 60639, Description = "")]
	public int 输入状态 { get; set; }

	[BinaryPoint(Offset = 60641, Description = "警报状态低16bit(急停/BUSY/OK/ERR)")]
	public int 输出状态 { get; set; }
	
	[BinaryPoint(Offset = 60643, Description = "0=无，1=急停")]
	public ushort 急停 { get; set; }

	[BinaryPoint(Offset = 60650, Description = "实时扭力(mNm)")]
	public ushort 实时扭力 { get; set; }

	[BinaryPoint(Offset = 60651, Description = "实时反馈速度(rpm)")]
	public ushort 实时反馈速度 { get; set; }

	[BinaryPoint(Offset = 60652, Description = "实时指令速度(rpm)")]
	public ushort 实时指令速度 { get; set; }

	[BinaryPoint(Offset = 60653, Description = "实时运行圈数(0.01r)")]
	public ushort 实时运行圈数 { get; set; }

	[BinaryPoint(Offset = 60654, Description = "")]
	public ushort 实时运行时间 { get; set; }

	[BinaryPoint(Offset = 60655, Description = "实时电压")]
	public ushort 实时供电电压 { get; set; }

	[BinaryPoint(Offset = 60656, Description = "工件上已完成的螺丝数量")]
	public ushort 工件上已完成的螺丝数量 { get; set; }

	#endregion

	#region 拧紧地址

	[BinaryPoint(Offset = 4060)] public ushort 拧紧圈数 { get; set; }

	#endregion
}