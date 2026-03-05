
// GENERATE AT 2026/3/5 17:59:26
using ZC.Annotations;
using ZC.DP.Memory;
using ZC.DP;
using ZC.BinStructs;

namespace ZitApp.BinStructs;
[BinaryStruct(Length = 20, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
[BinaryPointGroup(Name = "信捷Z1轴", Source = "3000", Tags = "", Start = 3000, End = 3199, Points = ["*"])]
[BinaryPointGroup(Name = "信捷Z2轴", Source = "3200", Tags = "", Start = 3200, End = 3399, Points = ["*"])]
[BinaryPointGroup(Name = "信捷X1轴", Source = "3400", Tags = "", Start = 3400, End = 3599, Points = ["*"])]
[BinaryPointGroup(Name = "信捷X2轴", Source = "3600", Tags = "", Start = 3600, End = 3799, Points = ["*"])]
[BinaryPointGroup(Name = "信捷Y1轴", Source = "3800", Tags = "", Start = 3800, End = 3999, Points = ["*"])]
[BinaryPointGroup(Name = "信捷Y2轴", Source = "4000", Tags = "", Start = 4000, End = 4199, Points = ["*"])]
[BinaryPointGroup(Name = "雷赛步进Z1轴", Source = "4200", Tags = "", Start = 4200, End = 4399, Points = ["*"])]
[BinaryPointGroup(Name = "雷赛步进Z2轴", Source = "4400", Tags = "", Start = 4400, End = 4599, Points = ["*"])]
[BinaryPointGroup(Name = "固高直线Y1轴", Source = "4600", Tags = "", Start = 4600, End = 4799, Points = ["*"])]
[BinaryPointGroup(Name = "固高直线Y2轴", Source = "4800", Tags = "", Start = 4800, End = 4999, Points = ["*"])]
public partial class ProductRecipe
{

	#region CSV INCLUDE POINTS: 模板

	#endregion

	#region CSV INCLUDE POINTS: SCREW-L

	[BinaryPoint(Offset = 4000, Source = "4000", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4000", Category = "SCREW-L/TASK1", Unit = "",MinValue = 0, MaxValue = 9, Description = "0--精度优先，2--速度优先(自攻牙螺丝)", InitAttachData = null)]
	public ushort LeftScrew_拧紧的模式 { get; set; }

	[BinaryPoint(Offset = 4001, Source = "4001", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4001", Category = "SCREW-L/TASK1", Unit = "",MinValue = 0, MaxValue = 1, Description = "0--CW，1--CCW", InitAttachData = null)]
	public ushort LeftScrew_拧紧旋转方向 { get; set; }

	[BinaryPoint(Offset = 4002, Source = "4002", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4002", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0.001, MaxValue = 32.764, Description = "", InitAttachData = null)]
	public ushort LeftScrew_目标扭力 { get; set; }

	[BinaryPoint(Offset = 4008, Source = "4008", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4008", Category = "SCREW-L/TASK1", Unit = "ms",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_扭力保持时间 { get; set; }

	[BinaryPoint(Offset = 4014, Source = "4014", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4014", Category = "SCREW-L/TASK1", Unit = "0.01A",MinValue = -1000, MaxValue = 1000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_扭力补偿值 { get; set; }

	[BinaryPoint(Offset = 4016, Source = "4016", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4016", Category = "SCREW-L/TASK1", Unit = "",MinValue = 0, MaxValue = 1, Description = "0--不开启，1--开启", InitAttachData = null)]
	public ushort LeftScrew_开启浮高滑牙检测 { get; set; }

	[BinaryPoint(Offset = 4022, Source = "4022", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4022", Category = "SCREW-L/TASK1", Unit = "ms",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_待机调整时间 { get; set; }

	[BinaryPoint(Offset = 4060, Source = "4060", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4060", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step0_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4061, Source = "4061", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4061", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step0_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4062, Source = "4062", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4062", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step0_扭力 { get; set; }

	[BinaryPoint(Offset = 4065, Source = "4065", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4065", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step1_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4066, Source = "4066", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4066", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step1_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4067, Source = "4067", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4067", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step1_扭力 { get; set; }

	[BinaryPoint(Offset = 4070, Source = "4070", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4070", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step2_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4071, Source = "4071", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4071", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step2_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4072, Source = "4072", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4072", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step2_扭力 { get; set; }

	[BinaryPoint(Offset = 4075, Source = "4075", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4075", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step3_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4076, Source = "4076", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4076", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step3_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4077, Source = "4077", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4077", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step3_扭力 { get; set; }

	[BinaryPoint(Offset = 4080, Source = "4080", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4080", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step4_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4081, Source = "4081", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4081", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step4_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4082, Source = "4082", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4082", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step4_扭力 { get; set; }

	[BinaryPoint(Offset = 4085, Source = "4085", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4085", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step5_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4086, Source = "4086", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4086", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step5_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4087, Source = "4087", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4087", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step5_扭力 { get; set; }

	[BinaryPoint(Offset = 4090, Source = "4090", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4090", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step6_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4091, Source = "4091", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4091", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step6_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4092, Source = "4092", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4092", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step6_扭力 { get; set; }

	[BinaryPoint(Offset = 4095, Source = "4095", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4095", Category = "SCREW-L/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step7_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4096, Source = "4096", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4096", Category = "SCREW-L/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step7_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4097, Source = "4097", Tags = "SCREW", ReaderData = "SCREW-L", WriterData = "SCREW-L", CustomData = null)]
	[ValueInfo(Source = "SCREW-L:4097", Category = "SCREW-L/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort LeftScrew_Step7_扭力 { get; set; }

	#endregion

	#region CSV INCLUDE POINTS: SCREW-R

	[BinaryPoint(Offset = 4000, Source = "4000", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4000", Category = "SCREW-R/TASK1", Unit = "",MinValue = 0, MaxValue = 9, Description = "0--精度优先，2--速度优先(自攻牙螺丝)", InitAttachData = null)]
	public ushort RightScrew_拧紧的模式 { get; set; }

	[BinaryPoint(Offset = 4001, Source = "4001", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4001", Category = "SCREW-R/TASK1", Unit = "",MinValue = 0, MaxValue = 1, Description = "0--CW，1--CCW", InitAttachData = null)]
	public ushort RightScrew_拧紧旋转方向 { get; set; }

	[BinaryPoint(Offset = 4002, Source = "4002", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4002", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0.001, MaxValue = 32.764, Description = "", InitAttachData = null)]
	public ushort RightScrew_目标扭力 { get; set; }

	[BinaryPoint(Offset = 4008, Source = "4008", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4008", Category = "SCREW-R/TASK1", Unit = "ms",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_扭力保持时间 { get; set; }

	[BinaryPoint(Offset = 4014, Source = "4014", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4014", Category = "SCREW-R/TASK1", Unit = "0.01A",MinValue = -1000, MaxValue = 1000, Description = "", InitAttachData = null)]
	public ushort RightScrew_扭力补偿值 { get; set; }

	[BinaryPoint(Offset = 4016, Source = "4016", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4016", Category = "SCREW-R/TASK1", Unit = "",MinValue = 0, MaxValue = 1, Description = "0--不开启，1--开启", InitAttachData = null)]
	public ushort RightScrew_开启浮高滑牙检测 { get; set; }

	[BinaryPoint(Offset = 4022, Source = "4022", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4022", Category = "SCREW-R/TASK1", Unit = "ms",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_待机调整时间 { get; set; }

	[BinaryPoint(Offset = 4060, Source = "4060", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4060", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step0_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4061, Source = "4061", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4061", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step0_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4062, Source = "4062", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4062", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step0_扭力 { get; set; }

	[BinaryPoint(Offset = 4065, Source = "4065", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4065", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step1_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4066, Source = "4066", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4066", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step1_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4067, Source = "4067", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4067", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step1_扭力 { get; set; }

	[BinaryPoint(Offset = 4070, Source = "4070", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4070", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step2_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4071, Source = "4071", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4071", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step2_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4072, Source = "4072", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4072", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step2_扭力 { get; set; }

	[BinaryPoint(Offset = 4075, Source = "4075", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4075", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step3_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4076, Source = "4076", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4076", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step3_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4077, Source = "4077", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4077", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step3_扭力 { get; set; }

	[BinaryPoint(Offset = 4080, Source = "4080", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4080", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step4_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4081, Source = "4081", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4081", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step4_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4082, Source = "4082", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4082", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step4_扭力 { get; set; }

	[BinaryPoint(Offset = 4085, Source = "4085", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4085", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step5_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4086, Source = "4086", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4086", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step5_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4087, Source = "4087", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4087", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step5_扭力 { get; set; }

	[BinaryPoint(Offset = 4090, Source = "4090", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4090", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step6_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4091, Source = "4091", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4091", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step6_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4092, Source = "4092", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4092", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step6_扭力 { get; set; }

	[BinaryPoint(Offset = 4095, Source = "4095", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4095", Category = "SCREW-R/TASK1", Unit = "r",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step7_拧紧圈数 { get; set; }

	[BinaryPoint(Offset = 4096, Source = "4096", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4096", Category = "SCREW-R/TASK1", Unit = "rpm",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step7_拧紧速度 { get; set; }

	[BinaryPoint(Offset = 4097, Source = "4097", Tags = "SCREW", ReaderData = "SCREW-R", WriterData = "SCREW-R", CustomData = null)]
	[ValueInfo(Source = "SCREW-R:4097", Category = "SCREW-R/TASK1", Unit = "N.m",MinValue = 0, MaxValue = 4000, Description = "", InitAttachData = null)]
	public ushort RightScrew_Step7_扭力 { get; set; }

	#endregion

	#region CSV INCLUDE POINTS: PLC

	[BinaryPoint(Offset = 3000, Source = "3000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3000", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_0", ])]
	public float 信捷Z1轴位置_0 { get; set; }

	[BinaryPoint(Offset = 3002, Source = "3002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3002", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_1", ])]
	public float 信捷Z1轴位置_1 { get; set; }

	[BinaryPoint(Offset = 3004, Source = "3004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3004", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_2", ])]
	public float 信捷Z1轴位置_2 { get; set; }

	[BinaryPoint(Offset = 3006, Source = "3006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3006", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_3", ])]
	public float 信捷Z1轴位置_3 { get; set; }

	[BinaryPoint(Offset = 3008, Source = "3008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3008", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_4", ])]
	public float 信捷Z1轴位置_4 { get; set; }

	[BinaryPoint(Offset = 3010, Source = "3010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3010", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_5", ])]
	public float 信捷Z1轴位置_5 { get; set; }

	[BinaryPoint(Offset = 3012, Source = "3012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3012", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_6", ])]
	public float 信捷Z1轴位置_6 { get; set; }

	[BinaryPoint(Offset = 3014, Source = "3014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3014", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_7", ])]
	public float 信捷Z1轴位置_7 { get; set; }

	[BinaryPoint(Offset = 3016, Source = "3016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3016", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_8", ])]
	public float 信捷Z1轴位置_8 { get; set; }

	[BinaryPoint(Offset = 3018, Source = "3018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3018", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_9", ])]
	public float 信捷Z1轴位置_9 { get; set; }

	[BinaryPoint(Offset = 3020, Source = "3020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3020", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_10", ])]
	public float 信捷Z1轴位置_10 { get; set; }

	[BinaryPoint(Offset = 3022, Source = "3022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3022", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_11", ])]
	public float 信捷Z1轴位置_11 { get; set; }

	[BinaryPoint(Offset = 3024, Source = "3024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3024", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_12", ])]
	public float 信捷Z1轴位置_12 { get; set; }

	[BinaryPoint(Offset = 3026, Source = "3026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3026", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_13", ])]
	public float 信捷Z1轴位置_13 { get; set; }

	[BinaryPoint(Offset = 3028, Source = "3028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3028", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_14", ])]
	public float 信捷Z1轴位置_14 { get; set; }

	[BinaryPoint(Offset = 3030, Source = "3030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3030", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_15", ])]
	public float 信捷Z1轴位置_15 { get; set; }

	[BinaryPoint(Offset = 3032, Source = "3032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3032", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_16", ])]
	public float 信捷Z1轴位置_16 { get; set; }

	[BinaryPoint(Offset = 3034, Source = "3034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3034", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_17", ])]
	public float 信捷Z1轴位置_17 { get; set; }

	[BinaryPoint(Offset = 3036, Source = "3036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3036", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_18", ])]
	public float 信捷Z1轴位置_18 { get; set; }

	[BinaryPoint(Offset = 3038, Source = "3038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3038", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_19", ])]
	public float 信捷Z1轴位置_19 { get; set; }

	[BinaryPoint(Offset = 3040, Source = "3040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3040", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_20", ])]
	public float 信捷Z1轴位置_20 { get; set; }

	[BinaryPoint(Offset = 3042, Source = "3042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3042", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_21", ])]
	public float 信捷Z1轴位置_21 { get; set; }

	[BinaryPoint(Offset = 3044, Source = "3044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3044", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_22", ])]
	public float 信捷Z1轴位置_22 { get; set; }

	[BinaryPoint(Offset = 3046, Source = "3046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3046", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_23", ])]
	public float 信捷Z1轴位置_23 { get; set; }

	[BinaryPoint(Offset = 3048, Source = "3048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3048", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_24", ])]
	public float 信捷Z1轴位置_24 { get; set; }

	[BinaryPoint(Offset = 3050, Source = "3050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3050", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_25", ])]
	public float 信捷Z1轴位置_25 { get; set; }

	[BinaryPoint(Offset = 3052, Source = "3052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3052", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_26", ])]
	public float 信捷Z1轴位置_26 { get; set; }

	[BinaryPoint(Offset = 3054, Source = "3054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3054", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_27", ])]
	public float 信捷Z1轴位置_27 { get; set; }

	[BinaryPoint(Offset = 3056, Source = "3056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3056", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_28", ])]
	public float 信捷Z1轴位置_28 { get; set; }

	[BinaryPoint(Offset = 3058, Source = "3058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3058", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_29", ])]
	public float 信捷Z1轴位置_29 { get; set; }

	[BinaryPoint(Offset = 3060, Source = "3060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3060", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_30", ])]
	public float 信捷Z1轴位置_30 { get; set; }

	[BinaryPoint(Offset = 3062, Source = "3062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3062", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_31", ])]
	public float 信捷Z1轴位置_31 { get; set; }

	[BinaryPoint(Offset = 3064, Source = "3064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3064", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_32", ])]
	public float 信捷Z1轴位置_32 { get; set; }

	[BinaryPoint(Offset = 3066, Source = "3066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3066", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_33", ])]
	public float 信捷Z1轴位置_33 { get; set; }

	[BinaryPoint(Offset = 3068, Source = "3068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3068", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_34", ])]
	public float 信捷Z1轴位置_34 { get; set; }

	[BinaryPoint(Offset = 3070, Source = "3070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3070", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_35", ])]
	public float 信捷Z1轴位置_35 { get; set; }

	[BinaryPoint(Offset = 3072, Source = "3072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3072", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_36", ])]
	public float 信捷Z1轴位置_36 { get; set; }

	[BinaryPoint(Offset = 3074, Source = "3074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3074", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_37", ])]
	public float 信捷Z1轴位置_37 { get; set; }

	[BinaryPoint(Offset = 3076, Source = "3076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3076", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_38", ])]
	public float 信捷Z1轴位置_38 { get; set; }

	[BinaryPoint(Offset = 3078, Source = "3078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3078", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_39", ])]
	public float 信捷Z1轴位置_39 { get; set; }

	[BinaryPoint(Offset = 3080, Source = "3080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3080", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_40", ])]
	public float 信捷Z1轴位置_40 { get; set; }

	[BinaryPoint(Offset = 3082, Source = "3082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3082", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_41", ])]
	public float 信捷Z1轴位置_41 { get; set; }

	[BinaryPoint(Offset = 3084, Source = "3084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3084", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_42", ])]
	public float 信捷Z1轴位置_42 { get; set; }

	[BinaryPoint(Offset = 3086, Source = "3086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3086", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_43", ])]
	public float 信捷Z1轴位置_43 { get; set; }

	[BinaryPoint(Offset = 3088, Source = "3088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3088", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_44", ])]
	public float 信捷Z1轴位置_44 { get; set; }

	[BinaryPoint(Offset = 3090, Source = "3090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3090", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_45", ])]
	public float 信捷Z1轴位置_45 { get; set; }

	[BinaryPoint(Offset = 3092, Source = "3092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3092", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_46", ])]
	public float 信捷Z1轴位置_46 { get; set; }

	[BinaryPoint(Offset = 3094, Source = "3094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3094", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_47", ])]
	public float 信捷Z1轴位置_47 { get; set; }

	[BinaryPoint(Offset = 3096, Source = "3096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3096", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_48", ])]
	public float 信捷Z1轴位置_48 { get; set; }

	[BinaryPoint(Offset = 3098, Source = "3098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3098", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_49", ])]
	public float 信捷Z1轴位置_49 { get; set; }

	[BinaryPoint(Offset = 3100, Source = "3100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3100", Category = "PLC/信捷Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z1轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Z1 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 XINJE_Vị trí_50", ])]
	public float 信捷Z1轴位置_50 { get; set; }

	[BinaryPoint(Offset = 3200, Source = "3200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3200", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_0", ])]
	public float 信捷Z2轴位置_0 { get; set; }

	[BinaryPoint(Offset = 3202, Source = "3202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3202", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_1", ])]
	public float 信捷Z2轴位置_1 { get; set; }

	[BinaryPoint(Offset = 3204, Source = "3204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3204", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_2", ])]
	public float 信捷Z2轴位置_2 { get; set; }

	[BinaryPoint(Offset = 3206, Source = "3206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3206", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_3", ])]
	public float 信捷Z2轴位置_3 { get; set; }

	[BinaryPoint(Offset = 3208, Source = "3208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3208", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_4", ])]
	public float 信捷Z2轴位置_4 { get; set; }

	[BinaryPoint(Offset = 3210, Source = "3210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3210", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_5", ])]
	public float 信捷Z2轴位置_5 { get; set; }

	[BinaryPoint(Offset = 3212, Source = "3212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3212", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_6", ])]
	public float 信捷Z2轴位置_6 { get; set; }

	[BinaryPoint(Offset = 3214, Source = "3214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3214", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_7", ])]
	public float 信捷Z2轴位置_7 { get; set; }

	[BinaryPoint(Offset = 3216, Source = "3216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3216", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_8", ])]
	public float 信捷Z2轴位置_8 { get; set; }

	[BinaryPoint(Offset = 3218, Source = "3218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3218", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_9", ])]
	public float 信捷Z2轴位置_9 { get; set; }

	[BinaryPoint(Offset = 3220, Source = "3220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3220", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_10", ])]
	public float 信捷Z2轴位置_10 { get; set; }

	[BinaryPoint(Offset = 3222, Source = "3222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3222", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_11", ])]
	public float 信捷Z2轴位置_11 { get; set; }

	[BinaryPoint(Offset = 3224, Source = "3224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3224", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_12", ])]
	public float 信捷Z2轴位置_12 { get; set; }

	[BinaryPoint(Offset = 3226, Source = "3226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3226", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_13", ])]
	public float 信捷Z2轴位置_13 { get; set; }

	[BinaryPoint(Offset = 3228, Source = "3228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3228", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_14", ])]
	public float 信捷Z2轴位置_14 { get; set; }

	[BinaryPoint(Offset = 3230, Source = "3230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3230", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_15", ])]
	public float 信捷Z2轴位置_15 { get; set; }

	[BinaryPoint(Offset = 3232, Source = "3232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3232", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_16", ])]
	public float 信捷Z2轴位置_16 { get; set; }

	[BinaryPoint(Offset = 3234, Source = "3234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3234", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_17", ])]
	public float 信捷Z2轴位置_17 { get; set; }

	[BinaryPoint(Offset = 3236, Source = "3236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3236", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_18", ])]
	public float 信捷Z2轴位置_18 { get; set; }

	[BinaryPoint(Offset = 3238, Source = "3238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3238", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_19", ])]
	public float 信捷Z2轴位置_19 { get; set; }

	[BinaryPoint(Offset = 3240, Source = "3240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3240", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_20", ])]
	public float 信捷Z2轴位置_20 { get; set; }

	[BinaryPoint(Offset = 3242, Source = "3242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3242", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_21", ])]
	public float 信捷Z2轴位置_21 { get; set; }

	[BinaryPoint(Offset = 3244, Source = "3244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3244", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_22", ])]
	public float 信捷Z2轴位置_22 { get; set; }

	[BinaryPoint(Offset = 3246, Source = "3246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3246", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_23", ])]
	public float 信捷Z2轴位置_23 { get; set; }

	[BinaryPoint(Offset = 3248, Source = "3248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3248", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_24", ])]
	public float 信捷Z2轴位置_24 { get; set; }

	[BinaryPoint(Offset = 3250, Source = "3250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3250", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_25", ])]
	public float 信捷Z2轴位置_25 { get; set; }

	[BinaryPoint(Offset = 3252, Source = "3252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3252", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_26", ])]
	public float 信捷Z2轴位置_26 { get; set; }

	[BinaryPoint(Offset = 3254, Source = "3254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3254", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_27", ])]
	public float 信捷Z2轴位置_27 { get; set; }

	[BinaryPoint(Offset = 3256, Source = "3256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3256", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_28", ])]
	public float 信捷Z2轴位置_28 { get; set; }

	[BinaryPoint(Offset = 3258, Source = "3258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3258", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_29", ])]
	public float 信捷Z2轴位置_29 { get; set; }

	[BinaryPoint(Offset = 3260, Source = "3260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3260", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_30", ])]
	public float 信捷Z2轴位置_30 { get; set; }

	[BinaryPoint(Offset = 3262, Source = "3262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3262", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_31", ])]
	public float 信捷Z2轴位置_31 { get; set; }

	[BinaryPoint(Offset = 3264, Source = "3264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3264", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_32", ])]
	public float 信捷Z2轴位置_32 { get; set; }

	[BinaryPoint(Offset = 3266, Source = "3266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3266", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_33", ])]
	public float 信捷Z2轴位置_33 { get; set; }

	[BinaryPoint(Offset = 3268, Source = "3268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3268", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_34", ])]
	public float 信捷Z2轴位置_34 { get; set; }

	[BinaryPoint(Offset = 3270, Source = "3270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3270", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_35", ])]
	public float 信捷Z2轴位置_35 { get; set; }

	[BinaryPoint(Offset = 3272, Source = "3272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3272", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_36", ])]
	public float 信捷Z2轴位置_36 { get; set; }

	[BinaryPoint(Offset = 3274, Source = "3274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3274", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_37", ])]
	public float 信捷Z2轴位置_37 { get; set; }

	[BinaryPoint(Offset = 3276, Source = "3276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3276", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_38", ])]
	public float 信捷Z2轴位置_38 { get; set; }

	[BinaryPoint(Offset = 3278, Source = "3278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3278", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_39", ])]
	public float 信捷Z2轴位置_39 { get; set; }

	[BinaryPoint(Offset = 3280, Source = "3280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3280", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_40", ])]
	public float 信捷Z2轴位置_40 { get; set; }

	[BinaryPoint(Offset = 3282, Source = "3282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3282", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_41", ])]
	public float 信捷Z2轴位置_41 { get; set; }

	[BinaryPoint(Offset = 3284, Source = "3284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3284", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_42", ])]
	public float 信捷Z2轴位置_42 { get; set; }

	[BinaryPoint(Offset = 3286, Source = "3286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3286", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_43", ])]
	public float 信捷Z2轴位置_43 { get; set; }

	[BinaryPoint(Offset = 3288, Source = "3288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3288", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_44", ])]
	public float 信捷Z2轴位置_44 { get; set; }

	[BinaryPoint(Offset = 3290, Source = "3290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3290", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_45", ])]
	public float 信捷Z2轴位置_45 { get; set; }

	[BinaryPoint(Offset = 3292, Source = "3292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3292", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_46", ])]
	public float 信捷Z2轴位置_46 { get; set; }

	[BinaryPoint(Offset = 3294, Source = "3294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3294", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_47", ])]
	public float 信捷Z2轴位置_47 { get; set; }

	[BinaryPoint(Offset = 3296, Source = "3296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3296", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_48", ])]
	public float 信捷Z2轴位置_48 { get; set; }

	[BinaryPoint(Offset = 3298, Source = "3298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3298", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_49", ])]
	public float 信捷Z2轴位置_49 { get; set; }

	[BinaryPoint(Offset = 3300, Source = "3300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3300", Category = "PLC/信捷Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Z2轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Z2 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 XINJE_Vị trí_50", ])]
	public float 信捷Z2轴位置_50 { get; set; }

	[BinaryPoint(Offset = 3400, Source = "3400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3400", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_0", ])]
	public float 信捷X1轴位置_0 { get; set; }

	[BinaryPoint(Offset = 3402, Source = "3402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3402", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_1", ])]
	public float 信捷X1轴位置_1 { get; set; }

	[BinaryPoint(Offset = 3404, Source = "3404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3404", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_2", ])]
	public float 信捷X1轴位置_2 { get; set; }

	[BinaryPoint(Offset = 3406, Source = "3406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3406", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_3", ])]
	public float 信捷X1轴位置_3 { get; set; }

	[BinaryPoint(Offset = 3408, Source = "3408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3408", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_4", ])]
	public float 信捷X1轴位置_4 { get; set; }

	[BinaryPoint(Offset = 3410, Source = "3410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3410", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_5", ])]
	public float 信捷X1轴位置_5 { get; set; }

	[BinaryPoint(Offset = 3412, Source = "3412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3412", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_6", ])]
	public float 信捷X1轴位置_6 { get; set; }

	[BinaryPoint(Offset = 3414, Source = "3414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3414", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_7", ])]
	public float 信捷X1轴位置_7 { get; set; }

	[BinaryPoint(Offset = 3416, Source = "3416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3416", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_8", ])]
	public float 信捷X1轴位置_8 { get; set; }

	[BinaryPoint(Offset = 3418, Source = "3418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3418", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_9", ])]
	public float 信捷X1轴位置_9 { get; set; }

	[BinaryPoint(Offset = 3420, Source = "3420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3420", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_10", ])]
	public float 信捷X1轴位置_10 { get; set; }

	[BinaryPoint(Offset = 3422, Source = "3422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3422", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_11", ])]
	public float 信捷X1轴位置_11 { get; set; }

	[BinaryPoint(Offset = 3424, Source = "3424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3424", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_12", ])]
	public float 信捷X1轴位置_12 { get; set; }

	[BinaryPoint(Offset = 3426, Source = "3426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3426", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_13", ])]
	public float 信捷X1轴位置_13 { get; set; }

	[BinaryPoint(Offset = 3428, Source = "3428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3428", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_14", ])]
	public float 信捷X1轴位置_14 { get; set; }

	[BinaryPoint(Offset = 3430, Source = "3430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3430", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_15", ])]
	public float 信捷X1轴位置_15 { get; set; }

	[BinaryPoint(Offset = 3432, Source = "3432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3432", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_16", ])]
	public float 信捷X1轴位置_16 { get; set; }

	[BinaryPoint(Offset = 3434, Source = "3434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3434", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_17", ])]
	public float 信捷X1轴位置_17 { get; set; }

	[BinaryPoint(Offset = 3436, Source = "3436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3436", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_18", ])]
	public float 信捷X1轴位置_18 { get; set; }

	[BinaryPoint(Offset = 3438, Source = "3438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3438", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_19", ])]
	public float 信捷X1轴位置_19 { get; set; }

	[BinaryPoint(Offset = 3440, Source = "3440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3440", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_20", ])]
	public float 信捷X1轴位置_20 { get; set; }

	[BinaryPoint(Offset = 3442, Source = "3442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3442", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_21", ])]
	public float 信捷X1轴位置_21 { get; set; }

	[BinaryPoint(Offset = 3444, Source = "3444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3444", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_22", ])]
	public float 信捷X1轴位置_22 { get; set; }

	[BinaryPoint(Offset = 3446, Source = "3446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3446", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_23", ])]
	public float 信捷X1轴位置_23 { get; set; }

	[BinaryPoint(Offset = 3448, Source = "3448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3448", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_24", ])]
	public float 信捷X1轴位置_24 { get; set; }

	[BinaryPoint(Offset = 3450, Source = "3450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3450", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_25", ])]
	public float 信捷X1轴位置_25 { get; set; }

	[BinaryPoint(Offset = 3452, Source = "3452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3452", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_26", ])]
	public float 信捷X1轴位置_26 { get; set; }

	[BinaryPoint(Offset = 3454, Source = "3454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3454", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_27", ])]
	public float 信捷X1轴位置_27 { get; set; }

	[BinaryPoint(Offset = 3456, Source = "3456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3456", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_28", ])]
	public float 信捷X1轴位置_28 { get; set; }

	[BinaryPoint(Offset = 3458, Source = "3458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3458", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_29", ])]
	public float 信捷X1轴位置_29 { get; set; }

	[BinaryPoint(Offset = 3460, Source = "3460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3460", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_30", ])]
	public float 信捷X1轴位置_30 { get; set; }

	[BinaryPoint(Offset = 3462, Source = "3462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3462", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_31", ])]
	public float 信捷X1轴位置_31 { get; set; }

	[BinaryPoint(Offset = 3464, Source = "3464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3464", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_32", ])]
	public float 信捷X1轴位置_32 { get; set; }

	[BinaryPoint(Offset = 3466, Source = "3466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3466", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_33", ])]
	public float 信捷X1轴位置_33 { get; set; }

	[BinaryPoint(Offset = 3468, Source = "3468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3468", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_34", ])]
	public float 信捷X1轴位置_34 { get; set; }

	[BinaryPoint(Offset = 3470, Source = "3470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3470", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_35", ])]
	public float 信捷X1轴位置_35 { get; set; }

	[BinaryPoint(Offset = 3472, Source = "3472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3472", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_36", ])]
	public float 信捷X1轴位置_36 { get; set; }

	[BinaryPoint(Offset = 3474, Source = "3474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3474", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_37", ])]
	public float 信捷X1轴位置_37 { get; set; }

	[BinaryPoint(Offset = 3476, Source = "3476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3476", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_38", ])]
	public float 信捷X1轴位置_38 { get; set; }

	[BinaryPoint(Offset = 3478, Source = "3478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3478", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_39", ])]
	public float 信捷X1轴位置_39 { get; set; }

	[BinaryPoint(Offset = 3480, Source = "3480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3480", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_40", ])]
	public float 信捷X1轴位置_40 { get; set; }

	[BinaryPoint(Offset = 3482, Source = "3482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3482", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_41", ])]
	public float 信捷X1轴位置_41 { get; set; }

	[BinaryPoint(Offset = 3484, Source = "3484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3484", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_42", ])]
	public float 信捷X1轴位置_42 { get; set; }

	[BinaryPoint(Offset = 3486, Source = "3486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3486", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_43", ])]
	public float 信捷X1轴位置_43 { get; set; }

	[BinaryPoint(Offset = 3488, Source = "3488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3488", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_44", ])]
	public float 信捷X1轴位置_44 { get; set; }

	[BinaryPoint(Offset = 3490, Source = "3490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3490", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_45", ])]
	public float 信捷X1轴位置_45 { get; set; }

	[BinaryPoint(Offset = 3492, Source = "3492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3492", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_46", ])]
	public float 信捷X1轴位置_46 { get; set; }

	[BinaryPoint(Offset = 3494, Source = "3494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3494", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_47", ])]
	public float 信捷X1轴位置_47 { get; set; }

	[BinaryPoint(Offset = 3496, Source = "3496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3496", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_48", ])]
	public float 信捷X1轴位置_48 { get; set; }

	[BinaryPoint(Offset = 3498, Source = "3498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3498", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_49", ])]
	public float 信捷X1轴位置_49 { get; set; }

	[BinaryPoint(Offset = 3500, Source = "3500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3500", Category = "PLC/信捷X1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X1轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE X1 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục X1 XINJE_Vị trí_50", ])]
	public float 信捷X1轴位置_50 { get; set; }

	[BinaryPoint(Offset = 3600, Source = "3600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3600", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_0", ])]
	public float 信捷X2轴位置_0 { get; set; }

	[BinaryPoint(Offset = 3602, Source = "3602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3602", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_1", ])]
	public float 信捷X2轴位置_1 { get; set; }

	[BinaryPoint(Offset = 3604, Source = "3604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3604", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_2", ])]
	public float 信捷X2轴位置_2 { get; set; }

	[BinaryPoint(Offset = 3606, Source = "3606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3606", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_3", ])]
	public float 信捷X2轴位置_3 { get; set; }

	[BinaryPoint(Offset = 3608, Source = "3608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3608", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_4", ])]
	public float 信捷X2轴位置_4 { get; set; }

	[BinaryPoint(Offset = 3610, Source = "3610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3610", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_5", ])]
	public float 信捷X2轴位置_5 { get; set; }

	[BinaryPoint(Offset = 3612, Source = "3612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3612", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_6", ])]
	public float 信捷X2轴位置_6 { get; set; }

	[BinaryPoint(Offset = 3614, Source = "3614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3614", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_7", ])]
	public float 信捷X2轴位置_7 { get; set; }

	[BinaryPoint(Offset = 3616, Source = "3616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3616", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_8", ])]
	public float 信捷X2轴位置_8 { get; set; }

	[BinaryPoint(Offset = 3618, Source = "3618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3618", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_9", ])]
	public float 信捷X2轴位置_9 { get; set; }

	[BinaryPoint(Offset = 3620, Source = "3620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3620", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_10", ])]
	public float 信捷X2轴位置_10 { get; set; }

	[BinaryPoint(Offset = 3622, Source = "3622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3622", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_11", ])]
	public float 信捷X2轴位置_11 { get; set; }

	[BinaryPoint(Offset = 3624, Source = "3624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3624", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_12", ])]
	public float 信捷X2轴位置_12 { get; set; }

	[BinaryPoint(Offset = 3626, Source = "3626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3626", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_13", ])]
	public float 信捷X2轴位置_13 { get; set; }

	[BinaryPoint(Offset = 3628, Source = "3628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3628", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_14", ])]
	public float 信捷X2轴位置_14 { get; set; }

	[BinaryPoint(Offset = 3630, Source = "3630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3630", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_15", ])]
	public float 信捷X2轴位置_15 { get; set; }

	[BinaryPoint(Offset = 3632, Source = "3632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3632", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_16", ])]
	public float 信捷X2轴位置_16 { get; set; }

	[BinaryPoint(Offset = 3634, Source = "3634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3634", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_17", ])]
	public float 信捷X2轴位置_17 { get; set; }

	[BinaryPoint(Offset = 3636, Source = "3636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3636", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_18", ])]
	public float 信捷X2轴位置_18 { get; set; }

	[BinaryPoint(Offset = 3638, Source = "3638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3638", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_19", ])]
	public float 信捷X2轴位置_19 { get; set; }

	[BinaryPoint(Offset = 3640, Source = "3640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3640", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_20", ])]
	public float 信捷X2轴位置_20 { get; set; }

	[BinaryPoint(Offset = 3642, Source = "3642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3642", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_21", ])]
	public float 信捷X2轴位置_21 { get; set; }

	[BinaryPoint(Offset = 3644, Source = "3644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3644", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_22", ])]
	public float 信捷X2轴位置_22 { get; set; }

	[BinaryPoint(Offset = 3646, Source = "3646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3646", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_23", ])]
	public float 信捷X2轴位置_23 { get; set; }

	[BinaryPoint(Offset = 3648, Source = "3648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3648", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_24", ])]
	public float 信捷X2轴位置_24 { get; set; }

	[BinaryPoint(Offset = 3650, Source = "3650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3650", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_25", ])]
	public float 信捷X2轴位置_25 { get; set; }

	[BinaryPoint(Offset = 3652, Source = "3652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3652", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_26", ])]
	public float 信捷X2轴位置_26 { get; set; }

	[BinaryPoint(Offset = 3654, Source = "3654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3654", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_27", ])]
	public float 信捷X2轴位置_27 { get; set; }

	[BinaryPoint(Offset = 3656, Source = "3656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3656", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_28", ])]
	public float 信捷X2轴位置_28 { get; set; }

	[BinaryPoint(Offset = 3658, Source = "3658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3658", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_29", ])]
	public float 信捷X2轴位置_29 { get; set; }

	[BinaryPoint(Offset = 3660, Source = "3660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3660", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_30", ])]
	public float 信捷X2轴位置_30 { get; set; }

	[BinaryPoint(Offset = 3662, Source = "3662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3662", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_31", ])]
	public float 信捷X2轴位置_31 { get; set; }

	[BinaryPoint(Offset = 3664, Source = "3664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3664", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_32", ])]
	public float 信捷X2轴位置_32 { get; set; }

	[BinaryPoint(Offset = 3666, Source = "3666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3666", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_33", ])]
	public float 信捷X2轴位置_33 { get; set; }

	[BinaryPoint(Offset = 3668, Source = "3668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3668", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_34", ])]
	public float 信捷X2轴位置_34 { get; set; }

	[BinaryPoint(Offset = 3670, Source = "3670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3670", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_35", ])]
	public float 信捷X2轴位置_35 { get; set; }

	[BinaryPoint(Offset = 3672, Source = "3672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3672", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_36", ])]
	public float 信捷X2轴位置_36 { get; set; }

	[BinaryPoint(Offset = 3674, Source = "3674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3674", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_37", ])]
	public float 信捷X2轴位置_37 { get; set; }

	[BinaryPoint(Offset = 3676, Source = "3676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3676", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_38", ])]
	public float 信捷X2轴位置_38 { get; set; }

	[BinaryPoint(Offset = 3678, Source = "3678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3678", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_39", ])]
	public float 信捷X2轴位置_39 { get; set; }

	[BinaryPoint(Offset = 3680, Source = "3680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3680", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_40", ])]
	public float 信捷X2轴位置_40 { get; set; }

	[BinaryPoint(Offset = 3682, Source = "3682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3682", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_41", ])]
	public float 信捷X2轴位置_41 { get; set; }

	[BinaryPoint(Offset = 3684, Source = "3684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3684", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_42", ])]
	public float 信捷X2轴位置_42 { get; set; }

	[BinaryPoint(Offset = 3686, Source = "3686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3686", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_43", ])]
	public float 信捷X2轴位置_43 { get; set; }

	[BinaryPoint(Offset = 3688, Source = "3688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3688", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_44", ])]
	public float 信捷X2轴位置_44 { get; set; }

	[BinaryPoint(Offset = 3690, Source = "3690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3690", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_45", ])]
	public float 信捷X2轴位置_45 { get; set; }

	[BinaryPoint(Offset = 3692, Source = "3692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3692", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_46", ])]
	public float 信捷X2轴位置_46 { get; set; }

	[BinaryPoint(Offset = 3694, Source = "3694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3694", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_47", ])]
	public float 信捷X2轴位置_47 { get; set; }

	[BinaryPoint(Offset = 3696, Source = "3696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3696", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_48", ])]
	public float 信捷X2轴位置_48 { get; set; }

	[BinaryPoint(Offset = 3698, Source = "3698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3698", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_49", ])]
	public float 信捷X2轴位置_49 { get; set; }

	[BinaryPoint(Offset = 3700, Source = "3700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3700", Category = "PLC/信捷X2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷X2轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE X2 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục X2 XINJE_Vị trí_50", ])]
	public float 信捷X2轴位置_50 { get; set; }

	[BinaryPoint(Offset = 3800, Source = "3800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3800", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_0", ])]
	public float 信捷Y1轴位置_0 { get; set; }

	[BinaryPoint(Offset = 3802, Source = "3802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3802", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_1", ])]
	public float 信捷Y1轴位置_1 { get; set; }

	[BinaryPoint(Offset = 3804, Source = "3804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3804", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_2", ])]
	public float 信捷Y1轴位置_2 { get; set; }

	[BinaryPoint(Offset = 3806, Source = "3806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3806", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_3", ])]
	public float 信捷Y1轴位置_3 { get; set; }

	[BinaryPoint(Offset = 3808, Source = "3808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3808", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_4", ])]
	public float 信捷Y1轴位置_4 { get; set; }

	[BinaryPoint(Offset = 3810, Source = "3810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3810", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_5", ])]
	public float 信捷Y1轴位置_5 { get; set; }

	[BinaryPoint(Offset = 3812, Source = "3812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3812", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_6", ])]
	public float 信捷Y1轴位置_6 { get; set; }

	[BinaryPoint(Offset = 3814, Source = "3814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3814", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_7", ])]
	public float 信捷Y1轴位置_7 { get; set; }

	[BinaryPoint(Offset = 3816, Source = "3816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3816", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_8", ])]
	public float 信捷Y1轴位置_8 { get; set; }

	[BinaryPoint(Offset = 3818, Source = "3818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3818", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_9", ])]
	public float 信捷Y1轴位置_9 { get; set; }

	[BinaryPoint(Offset = 3820, Source = "3820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3820", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_10", ])]
	public float 信捷Y1轴位置_10 { get; set; }

	[BinaryPoint(Offset = 3822, Source = "3822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3822", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_11", ])]
	public float 信捷Y1轴位置_11 { get; set; }

	[BinaryPoint(Offset = 3824, Source = "3824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3824", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_12", ])]
	public float 信捷Y1轴位置_12 { get; set; }

	[BinaryPoint(Offset = 3826, Source = "3826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3826", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_13", ])]
	public float 信捷Y1轴位置_13 { get; set; }

	[BinaryPoint(Offset = 3828, Source = "3828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3828", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_14", ])]
	public float 信捷Y1轴位置_14 { get; set; }

	[BinaryPoint(Offset = 3830, Source = "3830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3830", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_15", ])]
	public float 信捷Y1轴位置_15 { get; set; }

	[BinaryPoint(Offset = 3832, Source = "3832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3832", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_16", ])]
	public float 信捷Y1轴位置_16 { get; set; }

	[BinaryPoint(Offset = 3834, Source = "3834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3834", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_17", ])]
	public float 信捷Y1轴位置_17 { get; set; }

	[BinaryPoint(Offset = 3836, Source = "3836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3836", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_18", ])]
	public float 信捷Y1轴位置_18 { get; set; }

	[BinaryPoint(Offset = 3838, Source = "3838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3838", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_19", ])]
	public float 信捷Y1轴位置_19 { get; set; }

	[BinaryPoint(Offset = 3840, Source = "3840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3840", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_20", ])]
	public float 信捷Y1轴位置_20 { get; set; }

	[BinaryPoint(Offset = 3842, Source = "3842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3842", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_21", ])]
	public float 信捷Y1轴位置_21 { get; set; }

	[BinaryPoint(Offset = 3844, Source = "3844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3844", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_22", ])]
	public float 信捷Y1轴位置_22 { get; set; }

	[BinaryPoint(Offset = 3846, Source = "3846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3846", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_23", ])]
	public float 信捷Y1轴位置_23 { get; set; }

	[BinaryPoint(Offset = 3848, Source = "3848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3848", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_24", ])]
	public float 信捷Y1轴位置_24 { get; set; }

	[BinaryPoint(Offset = 3850, Source = "3850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3850", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_25", ])]
	public float 信捷Y1轴位置_25 { get; set; }

	[BinaryPoint(Offset = 3852, Source = "3852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3852", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_26", ])]
	public float 信捷Y1轴位置_26 { get; set; }

	[BinaryPoint(Offset = 3854, Source = "3854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3854", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_27", ])]
	public float 信捷Y1轴位置_27 { get; set; }

	[BinaryPoint(Offset = 3856, Source = "3856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3856", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_28", ])]
	public float 信捷Y1轴位置_28 { get; set; }

	[BinaryPoint(Offset = 3858, Source = "3858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3858", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_29", ])]
	public float 信捷Y1轴位置_29 { get; set; }

	[BinaryPoint(Offset = 3860, Source = "3860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3860", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_30", ])]
	public float 信捷Y1轴位置_30 { get; set; }

	[BinaryPoint(Offset = 3862, Source = "3862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3862", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_31", ])]
	public float 信捷Y1轴位置_31 { get; set; }

	[BinaryPoint(Offset = 3864, Source = "3864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3864", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_32", ])]
	public float 信捷Y1轴位置_32 { get; set; }

	[BinaryPoint(Offset = 3866, Source = "3866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3866", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_33", ])]
	public float 信捷Y1轴位置_33 { get; set; }

	[BinaryPoint(Offset = 3868, Source = "3868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3868", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_34", ])]
	public float 信捷Y1轴位置_34 { get; set; }

	[BinaryPoint(Offset = 3870, Source = "3870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3870", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_35", ])]
	public float 信捷Y1轴位置_35 { get; set; }

	[BinaryPoint(Offset = 3872, Source = "3872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3872", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_36", ])]
	public float 信捷Y1轴位置_36 { get; set; }

	[BinaryPoint(Offset = 3874, Source = "3874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3874", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_37", ])]
	public float 信捷Y1轴位置_37 { get; set; }

	[BinaryPoint(Offset = 3876, Source = "3876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3876", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_38", ])]
	public float 信捷Y1轴位置_38 { get; set; }

	[BinaryPoint(Offset = 3878, Source = "3878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3878", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_39", ])]
	public float 信捷Y1轴位置_39 { get; set; }

	[BinaryPoint(Offset = 3880, Source = "3880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3880", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_40", ])]
	public float 信捷Y1轴位置_40 { get; set; }

	[BinaryPoint(Offset = 3882, Source = "3882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3882", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_41", ])]
	public float 信捷Y1轴位置_41 { get; set; }

	[BinaryPoint(Offset = 3884, Source = "3884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3884", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_42", ])]
	public float 信捷Y1轴位置_42 { get; set; }

	[BinaryPoint(Offset = 3886, Source = "3886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3886", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_43", ])]
	public float 信捷Y1轴位置_43 { get; set; }

	[BinaryPoint(Offset = 3888, Source = "3888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3888", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_44", ])]
	public float 信捷Y1轴位置_44 { get; set; }

	[BinaryPoint(Offset = 3890, Source = "3890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3890", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_45", ])]
	public float 信捷Y1轴位置_45 { get; set; }

	[BinaryPoint(Offset = 3892, Source = "3892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3892", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_46", ])]
	public float 信捷Y1轴位置_46 { get; set; }

	[BinaryPoint(Offset = 3894, Source = "3894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3894", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_47", ])]
	public float 信捷Y1轴位置_47 { get; set; }

	[BinaryPoint(Offset = 3896, Source = "3896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3896", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_48", ])]
	public float 信捷Y1轴位置_48 { get; set; }

	[BinaryPoint(Offset = 3898, Source = "3898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3898", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_49", ])]
	public float 信捷Y1轴位置_49 { get; set; }

	[BinaryPoint(Offset = 3900, Source = "3900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:3900", Category = "PLC/信捷Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y1轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Y1 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 XINJE_Vị trí_50", ])]
	public float 信捷Y1轴位置_50 { get; set; }

	[BinaryPoint(Offset = 4000, Source = "4000", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4000", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_0",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_0", ])]
	public float 信捷Y2轴位置_0 { get; set; }

	[BinaryPoint(Offset = 4002, Source = "4002", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4002", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_1",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_1", ])]
	public float 信捷Y2轴位置_1 { get; set; }

	[BinaryPoint(Offset = 4004, Source = "4004", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4004", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_2",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_2", ])]
	public float 信捷Y2轴位置_2 { get; set; }

	[BinaryPoint(Offset = 4006, Source = "4006", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4006", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_3",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_3", ])]
	public float 信捷Y2轴位置_3 { get; set; }

	[BinaryPoint(Offset = 4008, Source = "4008", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4008", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_4",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_4", ])]
	public float 信捷Y2轴位置_4 { get; set; }

	[BinaryPoint(Offset = 4010, Source = "4010", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4010", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_5",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_5", ])]
	public float 信捷Y2轴位置_5 { get; set; }

	[BinaryPoint(Offset = 4012, Source = "4012", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4012", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_6",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_6", ])]
	public float 信捷Y2轴位置_6 { get; set; }

	[BinaryPoint(Offset = 4014, Source = "4014", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4014", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_7",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_7", ])]
	public float 信捷Y2轴位置_7 { get; set; }

	[BinaryPoint(Offset = 4016, Source = "4016", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4016", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_8",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_8", ])]
	public float 信捷Y2轴位置_8 { get; set; }

	[BinaryPoint(Offset = 4018, Source = "4018", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4018", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_9",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_9", ])]
	public float 信捷Y2轴位置_9 { get; set; }

	[BinaryPoint(Offset = 4020, Source = "4020", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4020", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_10",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_10", ])]
	public float 信捷Y2轴位置_10 { get; set; }

	[BinaryPoint(Offset = 4022, Source = "4022", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4022", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_11",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_11", ])]
	public float 信捷Y2轴位置_11 { get; set; }

	[BinaryPoint(Offset = 4024, Source = "4024", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4024", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_12",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_12", ])]
	public float 信捷Y2轴位置_12 { get; set; }

	[BinaryPoint(Offset = 4026, Source = "4026", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4026", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_13",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_13", ])]
	public float 信捷Y2轴位置_13 { get; set; }

	[BinaryPoint(Offset = 4028, Source = "4028", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4028", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_14",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_14", ])]
	public float 信捷Y2轴位置_14 { get; set; }

	[BinaryPoint(Offset = 4030, Source = "4030", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4030", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_15",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_15", ])]
	public float 信捷Y2轴位置_15 { get; set; }

	[BinaryPoint(Offset = 4032, Source = "4032", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4032", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_16",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_16", ])]
	public float 信捷Y2轴位置_16 { get; set; }

	[BinaryPoint(Offset = 4034, Source = "4034", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4034", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_17",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_17", ])]
	public float 信捷Y2轴位置_17 { get; set; }

	[BinaryPoint(Offset = 4036, Source = "4036", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4036", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_18",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_18", ])]
	public float 信捷Y2轴位置_18 { get; set; }

	[BinaryPoint(Offset = 4038, Source = "4038", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4038", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_19",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_19", ])]
	public float 信捷Y2轴位置_19 { get; set; }

	[BinaryPoint(Offset = 4040, Source = "4040", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4040", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_20",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_20", ])]
	public float 信捷Y2轴位置_20 { get; set; }

	[BinaryPoint(Offset = 4042, Source = "4042", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4042", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_21",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_21", ])]
	public float 信捷Y2轴位置_21 { get; set; }

	[BinaryPoint(Offset = 4044, Source = "4044", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4044", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_22",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_22", ])]
	public float 信捷Y2轴位置_22 { get; set; }

	[BinaryPoint(Offset = 4046, Source = "4046", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4046", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_23",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_23", ])]
	public float 信捷Y2轴位置_23 { get; set; }

	[BinaryPoint(Offset = 4048, Source = "4048", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4048", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_24",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_24", ])]
	public float 信捷Y2轴位置_24 { get; set; }

	[BinaryPoint(Offset = 4050, Source = "4050", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4050", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_25",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_25", ])]
	public float 信捷Y2轴位置_25 { get; set; }

	[BinaryPoint(Offset = 4052, Source = "4052", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4052", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_26",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_26", ])]
	public float 信捷Y2轴位置_26 { get; set; }

	[BinaryPoint(Offset = 4054, Source = "4054", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4054", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_27",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_27", ])]
	public float 信捷Y2轴位置_27 { get; set; }

	[BinaryPoint(Offset = 4056, Source = "4056", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4056", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_28",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_28", ])]
	public float 信捷Y2轴位置_28 { get; set; }

	[BinaryPoint(Offset = 4058, Source = "4058", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4058", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_29",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_29", ])]
	public float 信捷Y2轴位置_29 { get; set; }

	[BinaryPoint(Offset = 4060, Source = "4060", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4060", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_30",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_30", ])]
	public float 信捷Y2轴位置_30 { get; set; }

	[BinaryPoint(Offset = 4062, Source = "4062", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4062", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_31",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_31", ])]
	public float 信捷Y2轴位置_31 { get; set; }

	[BinaryPoint(Offset = 4064, Source = "4064", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4064", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_32",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_32", ])]
	public float 信捷Y2轴位置_32 { get; set; }

	[BinaryPoint(Offset = 4066, Source = "4066", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4066", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_33",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_33", ])]
	public float 信捷Y2轴位置_33 { get; set; }

	[BinaryPoint(Offset = 4068, Source = "4068", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4068", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_34",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_34", ])]
	public float 信捷Y2轴位置_34 { get; set; }

	[BinaryPoint(Offset = 4070, Source = "4070", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4070", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_35",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_35", ])]
	public float 信捷Y2轴位置_35 { get; set; }

	[BinaryPoint(Offset = 4072, Source = "4072", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4072", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_36",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_36", ])]
	public float 信捷Y2轴位置_36 { get; set; }

	[BinaryPoint(Offset = 4074, Source = "4074", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4074", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_37",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_37", ])]
	public float 信捷Y2轴位置_37 { get; set; }

	[BinaryPoint(Offset = 4076, Source = "4076", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4076", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_38",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_38", ])]
	public float 信捷Y2轴位置_38 { get; set; }

	[BinaryPoint(Offset = 4078, Source = "4078", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4078", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_39",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_39", ])]
	public float 信捷Y2轴位置_39 { get; set; }

	[BinaryPoint(Offset = 4080, Source = "4080", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4080", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_40",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_40", ])]
	public float 信捷Y2轴位置_40 { get; set; }

	[BinaryPoint(Offset = 4082, Source = "4082", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4082", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_41",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_41", ])]
	public float 信捷Y2轴位置_41 { get; set; }

	[BinaryPoint(Offset = 4084, Source = "4084", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4084", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_42",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_42", ])]
	public float 信捷Y2轴位置_42 { get; set; }

	[BinaryPoint(Offset = 4086, Source = "4086", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4086", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_43",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_43", ])]
	public float 信捷Y2轴位置_43 { get; set; }

	[BinaryPoint(Offset = 4088, Source = "4088", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4088", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_44",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_44", ])]
	public float 信捷Y2轴位置_44 { get; set; }

	[BinaryPoint(Offset = 4090, Source = "4090", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4090", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_45",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_45", ])]
	public float 信捷Y2轴位置_45 { get; set; }

	[BinaryPoint(Offset = 4092, Source = "4092", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4092", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_46",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_46", ])]
	public float 信捷Y2轴位置_46 { get; set; }

	[BinaryPoint(Offset = 4094, Source = "4094", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4094", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_47",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_47", ])]
	public float 信捷Y2轴位置_47 { get; set; }

	[BinaryPoint(Offset = 4096, Source = "4096", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4096", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_48",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_48", ])]
	public float 信捷Y2轴位置_48 { get; set; }

	[BinaryPoint(Offset = 4098, Source = "4098", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4098", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_49",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_49", ])]
	public float 信捷Y2轴位置_49 { get; set; }

	[BinaryPoint(Offset = 4100, Source = "4100", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4100", Category = "PLC/信捷Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "信捷Y2轴位置_50",
		DataDefine.KeyValue,"NameByEN", "XINJE Y2 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 XINJE_Vị trí_50", ])]
	public float 信捷Y2轴位置_50 { get; set; }

	[BinaryPoint(Offset = 4200, Source = "4200", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4200", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_0",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_0", ])]
	public float 雷赛步进Z1轴位置_0 { get; set; }

	[BinaryPoint(Offset = 4202, Source = "4202", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4202", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_1",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_1", ])]
	public float 雷赛步进Z1轴位置_1 { get; set; }

	[BinaryPoint(Offset = 4204, Source = "4204", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4204", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_2",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_2", ])]
	public float 雷赛步进Z1轴位置_2 { get; set; }

	[BinaryPoint(Offset = 4206, Source = "4206", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4206", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_3",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_3", ])]
	public float 雷赛步进Z1轴位置_3 { get; set; }

	[BinaryPoint(Offset = 4208, Source = "4208", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4208", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_4",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_4", ])]
	public float 雷赛步进Z1轴位置_4 { get; set; }

	[BinaryPoint(Offset = 4210, Source = "4210", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4210", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_5",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_5", ])]
	public float 雷赛步进Z1轴位置_5 { get; set; }

	[BinaryPoint(Offset = 4212, Source = "4212", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4212", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_6",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_6", ])]
	public float 雷赛步进Z1轴位置_6 { get; set; }

	[BinaryPoint(Offset = 4214, Source = "4214", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4214", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_7",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_7", ])]
	public float 雷赛步进Z1轴位置_7 { get; set; }

	[BinaryPoint(Offset = 4216, Source = "4216", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4216", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_8",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_8", ])]
	public float 雷赛步进Z1轴位置_8 { get; set; }

	[BinaryPoint(Offset = 4218, Source = "4218", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4218", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_9",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_9", ])]
	public float 雷赛步进Z1轴位置_9 { get; set; }

	[BinaryPoint(Offset = 4220, Source = "4220", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4220", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_10",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_10", ])]
	public float 雷赛步进Z1轴位置_10 { get; set; }

	[BinaryPoint(Offset = 4222, Source = "4222", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4222", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_11",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_11", ])]
	public float 雷赛步进Z1轴位置_11 { get; set; }

	[BinaryPoint(Offset = 4224, Source = "4224", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4224", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_12",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_12", ])]
	public float 雷赛步进Z1轴位置_12 { get; set; }

	[BinaryPoint(Offset = 4226, Source = "4226", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4226", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_13",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_13", ])]
	public float 雷赛步进Z1轴位置_13 { get; set; }

	[BinaryPoint(Offset = 4228, Source = "4228", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4228", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_14",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_14", ])]
	public float 雷赛步进Z1轴位置_14 { get; set; }

	[BinaryPoint(Offset = 4230, Source = "4230", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4230", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_15",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_15", ])]
	public float 雷赛步进Z1轴位置_15 { get; set; }

	[BinaryPoint(Offset = 4232, Source = "4232", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4232", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_16",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_16", ])]
	public float 雷赛步进Z1轴位置_16 { get; set; }

	[BinaryPoint(Offset = 4234, Source = "4234", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4234", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_17",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_17", ])]
	public float 雷赛步进Z1轴位置_17 { get; set; }

	[BinaryPoint(Offset = 4236, Source = "4236", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4236", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_18",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_18", ])]
	public float 雷赛步进Z1轴位置_18 { get; set; }

	[BinaryPoint(Offset = 4238, Source = "4238", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4238", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_19",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_19", ])]
	public float 雷赛步进Z1轴位置_19 { get; set; }

	[BinaryPoint(Offset = 4240, Source = "4240", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4240", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_20",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_20", ])]
	public float 雷赛步进Z1轴位置_20 { get; set; }

	[BinaryPoint(Offset = 4242, Source = "4242", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4242", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_21",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_21", ])]
	public float 雷赛步进Z1轴位置_21 { get; set; }

	[BinaryPoint(Offset = 4244, Source = "4244", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4244", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_22",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_22", ])]
	public float 雷赛步进Z1轴位置_22 { get; set; }

	[BinaryPoint(Offset = 4246, Source = "4246", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4246", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_23",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_23", ])]
	public float 雷赛步进Z1轴位置_23 { get; set; }

	[BinaryPoint(Offset = 4248, Source = "4248", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4248", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_24",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_24", ])]
	public float 雷赛步进Z1轴位置_24 { get; set; }

	[BinaryPoint(Offset = 4250, Source = "4250", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4250", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_25",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_25", ])]
	public float 雷赛步进Z1轴位置_25 { get; set; }

	[BinaryPoint(Offset = 4252, Source = "4252", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4252", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_26",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_26", ])]
	public float 雷赛步进Z1轴位置_26 { get; set; }

	[BinaryPoint(Offset = 4254, Source = "4254", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4254", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_27",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_27", ])]
	public float 雷赛步进Z1轴位置_27 { get; set; }

	[BinaryPoint(Offset = 4256, Source = "4256", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4256", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_28",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_28", ])]
	public float 雷赛步进Z1轴位置_28 { get; set; }

	[BinaryPoint(Offset = 4258, Source = "4258", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4258", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_29",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_29", ])]
	public float 雷赛步进Z1轴位置_29 { get; set; }

	[BinaryPoint(Offset = 4260, Source = "4260", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4260", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_30",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_30", ])]
	public float 雷赛步进Z1轴位置_30 { get; set; }

	[BinaryPoint(Offset = 4262, Source = "4262", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4262", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_31",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_31", ])]
	public float 雷赛步进Z1轴位置_31 { get; set; }

	[BinaryPoint(Offset = 4264, Source = "4264", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4264", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_32",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_32", ])]
	public float 雷赛步进Z1轴位置_32 { get; set; }

	[BinaryPoint(Offset = 4266, Source = "4266", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4266", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_33",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_33", ])]
	public float 雷赛步进Z1轴位置_33 { get; set; }

	[BinaryPoint(Offset = 4268, Source = "4268", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4268", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_34",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_34", ])]
	public float 雷赛步进Z1轴位置_34 { get; set; }

	[BinaryPoint(Offset = 4270, Source = "4270", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4270", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_35",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_35", ])]
	public float 雷赛步进Z1轴位置_35 { get; set; }

	[BinaryPoint(Offset = 4272, Source = "4272", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4272", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_36",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_36", ])]
	public float 雷赛步进Z1轴位置_36 { get; set; }

	[BinaryPoint(Offset = 4274, Source = "4274", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4274", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_37",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_37", ])]
	public float 雷赛步进Z1轴位置_37 { get; set; }

	[BinaryPoint(Offset = 4276, Source = "4276", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4276", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_38",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_38", ])]
	public float 雷赛步进Z1轴位置_38 { get; set; }

	[BinaryPoint(Offset = 4278, Source = "4278", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4278", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_39",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_39", ])]
	public float 雷赛步进Z1轴位置_39 { get; set; }

	[BinaryPoint(Offset = 4280, Source = "4280", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4280", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_40",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_40", ])]
	public float 雷赛步进Z1轴位置_40 { get; set; }

	[BinaryPoint(Offset = 4282, Source = "4282", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4282", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_41",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_41", ])]
	public float 雷赛步进Z1轴位置_41 { get; set; }

	[BinaryPoint(Offset = 4284, Source = "4284", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4284", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_42",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_42", ])]
	public float 雷赛步进Z1轴位置_42 { get; set; }

	[BinaryPoint(Offset = 4286, Source = "4286", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4286", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_43",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_43", ])]
	public float 雷赛步进Z1轴位置_43 { get; set; }

	[BinaryPoint(Offset = 4288, Source = "4288", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4288", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_44",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_44", ])]
	public float 雷赛步进Z1轴位置_44 { get; set; }

	[BinaryPoint(Offset = 4290, Source = "4290", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4290", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_45",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_45", ])]
	public float 雷赛步进Z1轴位置_45 { get; set; }

	[BinaryPoint(Offset = 4292, Source = "4292", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4292", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_46",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_46", ])]
	public float 雷赛步进Z1轴位置_46 { get; set; }

	[BinaryPoint(Offset = 4294, Source = "4294", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4294", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_47",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_47", ])]
	public float 雷赛步进Z1轴位置_47 { get; set; }

	[BinaryPoint(Offset = 4296, Source = "4296", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4296", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_48",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_48", ])]
	public float 雷赛步进Z1轴位置_48 { get; set; }

	[BinaryPoint(Offset = 4298, Source = "4298", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4298", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_49",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_49", ])]
	public float 雷赛步进Z1轴位置_49 { get; set; }

	[BinaryPoint(Offset = 4300, Source = "4300", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4300", Category = "PLC/雷赛步进Z1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z1轴位置_50",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z1 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Z1 LEADSHINE Stepper_Vị trí_50", ])]
	public float 雷赛步进Z1轴位置_50 { get; set; }

	[BinaryPoint(Offset = 4400, Source = "4400", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4400", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_0",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_0", ])]
	public float 雷赛步进Z2轴位置_0 { get; set; }

	[BinaryPoint(Offset = 4402, Source = "4402", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4402", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_1",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_1", ])]
	public float 雷赛步进Z2轴位置_1 { get; set; }

	[BinaryPoint(Offset = 4404, Source = "4404", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4404", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_2",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_2", ])]
	public float 雷赛步进Z2轴位置_2 { get; set; }

	[BinaryPoint(Offset = 4406, Source = "4406", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4406", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_3",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_3", ])]
	public float 雷赛步进Z2轴位置_3 { get; set; }

	[BinaryPoint(Offset = 4408, Source = "4408", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4408", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_4",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_4", ])]
	public float 雷赛步进Z2轴位置_4 { get; set; }

	[BinaryPoint(Offset = 4410, Source = "4410", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4410", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_5",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_5", ])]
	public float 雷赛步进Z2轴位置_5 { get; set; }

	[BinaryPoint(Offset = 4412, Source = "4412", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4412", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_6",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_6", ])]
	public float 雷赛步进Z2轴位置_6 { get; set; }

	[BinaryPoint(Offset = 4414, Source = "4414", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4414", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_7",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_7", ])]
	public float 雷赛步进Z2轴位置_7 { get; set; }

	[BinaryPoint(Offset = 4416, Source = "4416", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4416", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_8",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_8", ])]
	public float 雷赛步进Z2轴位置_8 { get; set; }

	[BinaryPoint(Offset = 4418, Source = "4418", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4418", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_9",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_9", ])]
	public float 雷赛步进Z2轴位置_9 { get; set; }

	[BinaryPoint(Offset = 4420, Source = "4420", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4420", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_10",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_10", ])]
	public float 雷赛步进Z2轴位置_10 { get; set; }

	[BinaryPoint(Offset = 4422, Source = "4422", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4422", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_11",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_11", ])]
	public float 雷赛步进Z2轴位置_11 { get; set; }

	[BinaryPoint(Offset = 4424, Source = "4424", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4424", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_12",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_12", ])]
	public float 雷赛步进Z2轴位置_12 { get; set; }

	[BinaryPoint(Offset = 4426, Source = "4426", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4426", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_13",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_13", ])]
	public float 雷赛步进Z2轴位置_13 { get; set; }

	[BinaryPoint(Offset = 4428, Source = "4428", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4428", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_14",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_14", ])]
	public float 雷赛步进Z2轴位置_14 { get; set; }

	[BinaryPoint(Offset = 4430, Source = "4430", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4430", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_15",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_15", ])]
	public float 雷赛步进Z2轴位置_15 { get; set; }

	[BinaryPoint(Offset = 4432, Source = "4432", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4432", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_16",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_16", ])]
	public float 雷赛步进Z2轴位置_16 { get; set; }

	[BinaryPoint(Offset = 4434, Source = "4434", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4434", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_17",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_17", ])]
	public float 雷赛步进Z2轴位置_17 { get; set; }

	[BinaryPoint(Offset = 4436, Source = "4436", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4436", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_18",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_18", ])]
	public float 雷赛步进Z2轴位置_18 { get; set; }

	[BinaryPoint(Offset = 4438, Source = "4438", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4438", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_19",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_19", ])]
	public float 雷赛步进Z2轴位置_19 { get; set; }

	[BinaryPoint(Offset = 4440, Source = "4440", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4440", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_20",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_20", ])]
	public float 雷赛步进Z2轴位置_20 { get; set; }

	[BinaryPoint(Offset = 4442, Source = "4442", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4442", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_21",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_21", ])]
	public float 雷赛步进Z2轴位置_21 { get; set; }

	[BinaryPoint(Offset = 4444, Source = "4444", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4444", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_22",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_22", ])]
	public float 雷赛步进Z2轴位置_22 { get; set; }

	[BinaryPoint(Offset = 4446, Source = "4446", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4446", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_23",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_23", ])]
	public float 雷赛步进Z2轴位置_23 { get; set; }

	[BinaryPoint(Offset = 4448, Source = "4448", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4448", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_24",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_24", ])]
	public float 雷赛步进Z2轴位置_24 { get; set; }

	[BinaryPoint(Offset = 4450, Source = "4450", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4450", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_25",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_25", ])]
	public float 雷赛步进Z2轴位置_25 { get; set; }

	[BinaryPoint(Offset = 4452, Source = "4452", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4452", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_26",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_26", ])]
	public float 雷赛步进Z2轴位置_26 { get; set; }

	[BinaryPoint(Offset = 4454, Source = "4454", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4454", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_27",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_27", ])]
	public float 雷赛步进Z2轴位置_27 { get; set; }

	[BinaryPoint(Offset = 4456, Source = "4456", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4456", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_28",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_28", ])]
	public float 雷赛步进Z2轴位置_28 { get; set; }

	[BinaryPoint(Offset = 4458, Source = "4458", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4458", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_29",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_29", ])]
	public float 雷赛步进Z2轴位置_29 { get; set; }

	[BinaryPoint(Offset = 4460, Source = "4460", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4460", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_30",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_30", ])]
	public float 雷赛步进Z2轴位置_30 { get; set; }

	[BinaryPoint(Offset = 4462, Source = "4462", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4462", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_31",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_31", ])]
	public float 雷赛步进Z2轴位置_31 { get; set; }

	[BinaryPoint(Offset = 4464, Source = "4464", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4464", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_32",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_32", ])]
	public float 雷赛步进Z2轴位置_32 { get; set; }

	[BinaryPoint(Offset = 4466, Source = "4466", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4466", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_33",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_33", ])]
	public float 雷赛步进Z2轴位置_33 { get; set; }

	[BinaryPoint(Offset = 4468, Source = "4468", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4468", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_34",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_34", ])]
	public float 雷赛步进Z2轴位置_34 { get; set; }

	[BinaryPoint(Offset = 4470, Source = "4470", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4470", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_35",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_35", ])]
	public float 雷赛步进Z2轴位置_35 { get; set; }

	[BinaryPoint(Offset = 4472, Source = "4472", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4472", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_36",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_36", ])]
	public float 雷赛步进Z2轴位置_36 { get; set; }

	[BinaryPoint(Offset = 4474, Source = "4474", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4474", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_37",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_37", ])]
	public float 雷赛步进Z2轴位置_37 { get; set; }

	[BinaryPoint(Offset = 4476, Source = "4476", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4476", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_38",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_38", ])]
	public float 雷赛步进Z2轴位置_38 { get; set; }

	[BinaryPoint(Offset = 4478, Source = "4478", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4478", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_39",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_39", ])]
	public float 雷赛步进Z2轴位置_39 { get; set; }

	[BinaryPoint(Offset = 4480, Source = "4480", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4480", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_40",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_40", ])]
	public float 雷赛步进Z2轴位置_40 { get; set; }

	[BinaryPoint(Offset = 4482, Source = "4482", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4482", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_41",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_41", ])]
	public float 雷赛步进Z2轴位置_41 { get; set; }

	[BinaryPoint(Offset = 4484, Source = "4484", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4484", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_42",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_42", ])]
	public float 雷赛步进Z2轴位置_42 { get; set; }

	[BinaryPoint(Offset = 4486, Source = "4486", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4486", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_43",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_43", ])]
	public float 雷赛步进Z2轴位置_43 { get; set; }

	[BinaryPoint(Offset = 4488, Source = "4488", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4488", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_44",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_44", ])]
	public float 雷赛步进Z2轴位置_44 { get; set; }

	[BinaryPoint(Offset = 4490, Source = "4490", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4490", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_45",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_45", ])]
	public float 雷赛步进Z2轴位置_45 { get; set; }

	[BinaryPoint(Offset = 4492, Source = "4492", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4492", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_46",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_46", ])]
	public float 雷赛步进Z2轴位置_46 { get; set; }

	[BinaryPoint(Offset = 4494, Source = "4494", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4494", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_47",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_47", ])]
	public float 雷赛步进Z2轴位置_47 { get; set; }

	[BinaryPoint(Offset = 4496, Source = "4496", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4496", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_48",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_48", ])]
	public float 雷赛步进Z2轴位置_48 { get; set; }

	[BinaryPoint(Offset = 4498, Source = "4498", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4498", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_49",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_49", ])]
	public float 雷赛步进Z2轴位置_49 { get; set; }

	[BinaryPoint(Offset = 4500, Source = "4500", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4500", Category = "PLC/雷赛步进Z2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "雷赛步进Z2轴位置_50",
		DataDefine.KeyValue,"NameByEN", "LEADSHINE Stepper Z2 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Z2 LEADSHINE Stepper_Vị trí_50", ])]
	public float 雷赛步进Z2轴位置_50 { get; set; }

	[BinaryPoint(Offset = 4600, Source = "4600", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4600", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_0",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_0", ])]
	public float 固高直线Y1轴位置_0 { get; set; }

	[BinaryPoint(Offset = 4602, Source = "4602", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4602", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_1",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_1", ])]
	public float 固高直线Y1轴位置_1 { get; set; }

	[BinaryPoint(Offset = 4604, Source = "4604", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4604", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_2",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_2", ])]
	public float 固高直线Y1轴位置_2 { get; set; }

	[BinaryPoint(Offset = 4606, Source = "4606", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4606", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_3",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_3", ])]
	public float 固高直线Y1轴位置_3 { get; set; }

	[BinaryPoint(Offset = 4608, Source = "4608", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4608", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_4",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_4", ])]
	public float 固高直线Y1轴位置_4 { get; set; }

	[BinaryPoint(Offset = 4610, Source = "4610", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4610", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_5",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_5", ])]
	public float 固高直线Y1轴位置_5 { get; set; }

	[BinaryPoint(Offset = 4612, Source = "4612", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4612", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_6",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_6", ])]
	public float 固高直线Y1轴位置_6 { get; set; }

	[BinaryPoint(Offset = 4614, Source = "4614", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4614", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_7",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_7", ])]
	public float 固高直线Y1轴位置_7 { get; set; }

	[BinaryPoint(Offset = 4616, Source = "4616", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4616", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_8",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_8", ])]
	public float 固高直线Y1轴位置_8 { get; set; }

	[BinaryPoint(Offset = 4618, Source = "4618", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4618", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_9",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_9", ])]
	public float 固高直线Y1轴位置_9 { get; set; }

	[BinaryPoint(Offset = 4620, Source = "4620", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4620", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_10",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_10", ])]
	public float 固高直线Y1轴位置_10 { get; set; }

	[BinaryPoint(Offset = 4622, Source = "4622", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4622", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_11",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_11", ])]
	public float 固高直线Y1轴位置_11 { get; set; }

	[BinaryPoint(Offset = 4624, Source = "4624", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4624", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_12",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_12", ])]
	public float 固高直线Y1轴位置_12 { get; set; }

	[BinaryPoint(Offset = 4626, Source = "4626", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4626", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_13",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_13", ])]
	public float 固高直线Y1轴位置_13 { get; set; }

	[BinaryPoint(Offset = 4628, Source = "4628", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4628", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_14",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_14", ])]
	public float 固高直线Y1轴位置_14 { get; set; }

	[BinaryPoint(Offset = 4630, Source = "4630", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4630", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_15",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_15", ])]
	public float 固高直线Y1轴位置_15 { get; set; }

	[BinaryPoint(Offset = 4632, Source = "4632", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4632", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_16",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_16", ])]
	public float 固高直线Y1轴位置_16 { get; set; }

	[BinaryPoint(Offset = 4634, Source = "4634", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4634", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_17",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_17", ])]
	public float 固高直线Y1轴位置_17 { get; set; }

	[BinaryPoint(Offset = 4636, Source = "4636", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4636", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_18",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_18", ])]
	public float 固高直线Y1轴位置_18 { get; set; }

	[BinaryPoint(Offset = 4638, Source = "4638", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4638", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_19",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_19", ])]
	public float 固高直线Y1轴位置_19 { get; set; }

	[BinaryPoint(Offset = 4640, Source = "4640", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4640", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_20",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_20", ])]
	public float 固高直线Y1轴位置_20 { get; set; }

	[BinaryPoint(Offset = 4642, Source = "4642", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4642", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_21",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_21", ])]
	public float 固高直线Y1轴位置_21 { get; set; }

	[BinaryPoint(Offset = 4644, Source = "4644", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4644", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_22",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_22", ])]
	public float 固高直线Y1轴位置_22 { get; set; }

	[BinaryPoint(Offset = 4646, Source = "4646", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4646", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_23",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_23", ])]
	public float 固高直线Y1轴位置_23 { get; set; }

	[BinaryPoint(Offset = 4648, Source = "4648", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4648", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_24",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_24", ])]
	public float 固高直线Y1轴位置_24 { get; set; }

	[BinaryPoint(Offset = 4650, Source = "4650", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4650", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_25",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_25", ])]
	public float 固高直线Y1轴位置_25 { get; set; }

	[BinaryPoint(Offset = 4652, Source = "4652", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4652", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_26",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_26", ])]
	public float 固高直线Y1轴位置_26 { get; set; }

	[BinaryPoint(Offset = 4654, Source = "4654", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4654", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_27",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_27", ])]
	public float 固高直线Y1轴位置_27 { get; set; }

	[BinaryPoint(Offset = 4656, Source = "4656", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4656", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_28",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_28", ])]
	public float 固高直线Y1轴位置_28 { get; set; }

	[BinaryPoint(Offset = 4658, Source = "4658", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4658", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_29",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_29", ])]
	public float 固高直线Y1轴位置_29 { get; set; }

	[BinaryPoint(Offset = 4660, Source = "4660", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4660", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_30",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_30", ])]
	public float 固高直线Y1轴位置_30 { get; set; }

	[BinaryPoint(Offset = 4662, Source = "4662", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4662", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_31",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_31", ])]
	public float 固高直线Y1轴位置_31 { get; set; }

	[BinaryPoint(Offset = 4664, Source = "4664", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4664", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_32",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_32", ])]
	public float 固高直线Y1轴位置_32 { get; set; }

	[BinaryPoint(Offset = 4666, Source = "4666", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4666", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_33",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_33", ])]
	public float 固高直线Y1轴位置_33 { get; set; }

	[BinaryPoint(Offset = 4668, Source = "4668", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4668", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_34",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_34", ])]
	public float 固高直线Y1轴位置_34 { get; set; }

	[BinaryPoint(Offset = 4670, Source = "4670", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4670", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_35",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_35", ])]
	public float 固高直线Y1轴位置_35 { get; set; }

	[BinaryPoint(Offset = 4672, Source = "4672", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4672", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_36",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_36", ])]
	public float 固高直线Y1轴位置_36 { get; set; }

	[BinaryPoint(Offset = 4674, Source = "4674", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4674", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_37",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_37", ])]
	public float 固高直线Y1轴位置_37 { get; set; }

	[BinaryPoint(Offset = 4676, Source = "4676", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4676", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_38",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_38", ])]
	public float 固高直线Y1轴位置_38 { get; set; }

	[BinaryPoint(Offset = 4678, Source = "4678", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4678", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_39",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_39", ])]
	public float 固高直线Y1轴位置_39 { get; set; }

	[BinaryPoint(Offset = 4680, Source = "4680", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4680", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_40",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_40", ])]
	public float 固高直线Y1轴位置_40 { get; set; }

	[BinaryPoint(Offset = 4682, Source = "4682", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4682", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_41",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_41", ])]
	public float 固高直线Y1轴位置_41 { get; set; }

	[BinaryPoint(Offset = 4684, Source = "4684", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4684", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_42",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_42", ])]
	public float 固高直线Y1轴位置_42 { get; set; }

	[BinaryPoint(Offset = 4686, Source = "4686", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4686", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_43",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_43", ])]
	public float 固高直线Y1轴位置_43 { get; set; }

	[BinaryPoint(Offset = 4688, Source = "4688", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4688", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_44",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_44", ])]
	public float 固高直线Y1轴位置_44 { get; set; }

	[BinaryPoint(Offset = 4690, Source = "4690", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4690", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_45",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_45", ])]
	public float 固高直线Y1轴位置_45 { get; set; }

	[BinaryPoint(Offset = 4692, Source = "4692", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4692", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_46",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_46", ])]
	public float 固高直线Y1轴位置_46 { get; set; }

	[BinaryPoint(Offset = 4694, Source = "4694", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4694", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_47",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_47", ])]
	public float 固高直线Y1轴位置_47 { get; set; }

	[BinaryPoint(Offset = 4696, Source = "4696", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4696", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_48",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_48", ])]
	public float 固高直线Y1轴位置_48 { get; set; }

	[BinaryPoint(Offset = 4698, Source = "4698", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4698", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_49",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_49", ])]
	public float 固高直线Y1轴位置_49 { get; set; }

	[BinaryPoint(Offset = 4700, Source = "4700", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4700", Category = "PLC/固高直线Y1轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y1轴位置_50",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y1 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Y1 GUGAO Linear_Vị trí_50", ])]
	public float 固高直线Y1轴位置_50 { get; set; }

	[BinaryPoint(Offset = 4800, Source = "4800", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4800", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_0",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 0",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_0", ])]
	public float 固高直线Y2轴位置_0 { get; set; }

	[BinaryPoint(Offset = 4802, Source = "4802", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4802", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_1",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 1",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_1", ])]
	public float 固高直线Y2轴位置_1 { get; set; }

	[BinaryPoint(Offset = 4804, Source = "4804", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4804", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_2",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 2",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_2", ])]
	public float 固高直线Y2轴位置_2 { get; set; }

	[BinaryPoint(Offset = 4806, Source = "4806", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4806", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_3",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 3",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_3", ])]
	public float 固高直线Y2轴位置_3 { get; set; }

	[BinaryPoint(Offset = 4808, Source = "4808", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4808", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_4",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 4",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_4", ])]
	public float 固高直线Y2轴位置_4 { get; set; }

	[BinaryPoint(Offset = 4810, Source = "4810", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4810", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_5",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 5",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_5", ])]
	public float 固高直线Y2轴位置_5 { get; set; }

	[BinaryPoint(Offset = 4812, Source = "4812", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4812", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_6",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 6",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_6", ])]
	public float 固高直线Y2轴位置_6 { get; set; }

	[BinaryPoint(Offset = 4814, Source = "4814", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4814", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_7",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 7",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_7", ])]
	public float 固高直线Y2轴位置_7 { get; set; }

	[BinaryPoint(Offset = 4816, Source = "4816", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4816", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_8",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 8",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_8", ])]
	public float 固高直线Y2轴位置_8 { get; set; }

	[BinaryPoint(Offset = 4818, Source = "4818", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4818", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_9",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 9",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_9", ])]
	public float 固高直线Y2轴位置_9 { get; set; }

	[BinaryPoint(Offset = 4820, Source = "4820", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4820", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_10",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 10",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_10", ])]
	public float 固高直线Y2轴位置_10 { get; set; }

	[BinaryPoint(Offset = 4822, Source = "4822", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4822", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_11",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 11",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_11", ])]
	public float 固高直线Y2轴位置_11 { get; set; }

	[BinaryPoint(Offset = 4824, Source = "4824", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4824", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_12",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 12",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_12", ])]
	public float 固高直线Y2轴位置_12 { get; set; }

	[BinaryPoint(Offset = 4826, Source = "4826", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4826", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_13",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 13",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_13", ])]
	public float 固高直线Y2轴位置_13 { get; set; }

	[BinaryPoint(Offset = 4828, Source = "4828", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4828", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_14",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 14",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_14", ])]
	public float 固高直线Y2轴位置_14 { get; set; }

	[BinaryPoint(Offset = 4830, Source = "4830", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4830", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_15",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 15",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_15", ])]
	public float 固高直线Y2轴位置_15 { get; set; }

	[BinaryPoint(Offset = 4832, Source = "4832", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4832", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_16",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 16",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_16", ])]
	public float 固高直线Y2轴位置_16 { get; set; }

	[BinaryPoint(Offset = 4834, Source = "4834", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4834", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_17",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 17",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_17", ])]
	public float 固高直线Y2轴位置_17 { get; set; }

	[BinaryPoint(Offset = 4836, Source = "4836", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4836", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_18",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 18",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_18", ])]
	public float 固高直线Y2轴位置_18 { get; set; }

	[BinaryPoint(Offset = 4838, Source = "4838", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4838", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_19",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 19",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_19", ])]
	public float 固高直线Y2轴位置_19 { get; set; }

	[BinaryPoint(Offset = 4840, Source = "4840", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4840", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_20",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 20",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_20", ])]
	public float 固高直线Y2轴位置_20 { get; set; }

	[BinaryPoint(Offset = 4842, Source = "4842", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4842", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_21",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 21",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_21", ])]
	public float 固高直线Y2轴位置_21 { get; set; }

	[BinaryPoint(Offset = 4844, Source = "4844", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4844", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_22",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 22",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_22", ])]
	public float 固高直线Y2轴位置_22 { get; set; }

	[BinaryPoint(Offset = 4846, Source = "4846", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4846", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_23",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 23",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_23", ])]
	public float 固高直线Y2轴位置_23 { get; set; }

	[BinaryPoint(Offset = 4848, Source = "4848", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4848", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_24",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 24",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_24", ])]
	public float 固高直线Y2轴位置_24 { get; set; }

	[BinaryPoint(Offset = 4850, Source = "4850", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4850", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_25",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 25",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_25", ])]
	public float 固高直线Y2轴位置_25 { get; set; }

	[BinaryPoint(Offset = 4852, Source = "4852", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4852", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_26",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 26",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_26", ])]
	public float 固高直线Y2轴位置_26 { get; set; }

	[BinaryPoint(Offset = 4854, Source = "4854", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4854", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_27",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 27",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_27", ])]
	public float 固高直线Y2轴位置_27 { get; set; }

	[BinaryPoint(Offset = 4856, Source = "4856", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4856", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_28",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 28",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_28", ])]
	public float 固高直线Y2轴位置_28 { get; set; }

	[BinaryPoint(Offset = 4858, Source = "4858", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4858", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_29",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 29",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_29", ])]
	public float 固高直线Y2轴位置_29 { get; set; }

	[BinaryPoint(Offset = 4860, Source = "4860", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4860", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_30",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 30",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_30", ])]
	public float 固高直线Y2轴位置_30 { get; set; }

	[BinaryPoint(Offset = 4862, Source = "4862", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4862", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_31",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 31",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_31", ])]
	public float 固高直线Y2轴位置_31 { get; set; }

	[BinaryPoint(Offset = 4864, Source = "4864", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4864", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_32",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 32",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_32", ])]
	public float 固高直线Y2轴位置_32 { get; set; }

	[BinaryPoint(Offset = 4866, Source = "4866", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4866", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_33",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 33",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_33", ])]
	public float 固高直线Y2轴位置_33 { get; set; }

	[BinaryPoint(Offset = 4868, Source = "4868", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4868", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_34",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 34",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_34", ])]
	public float 固高直线Y2轴位置_34 { get; set; }

	[BinaryPoint(Offset = 4870, Source = "4870", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4870", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_35",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 35",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_35", ])]
	public float 固高直线Y2轴位置_35 { get; set; }

	[BinaryPoint(Offset = 4872, Source = "4872", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4872", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_36",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 36",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_36", ])]
	public float 固高直线Y2轴位置_36 { get; set; }

	[BinaryPoint(Offset = 4874, Source = "4874", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4874", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_37",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 37",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_37", ])]
	public float 固高直线Y2轴位置_37 { get; set; }

	[BinaryPoint(Offset = 4876, Source = "4876", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4876", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_38",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 38",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_38", ])]
	public float 固高直线Y2轴位置_38 { get; set; }

	[BinaryPoint(Offset = 4878, Source = "4878", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4878", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_39",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 39",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_39", ])]
	public float 固高直线Y2轴位置_39 { get; set; }

	[BinaryPoint(Offset = 4880, Source = "4880", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4880", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_40",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 40",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_40", ])]
	public float 固高直线Y2轴位置_40 { get; set; }

	[BinaryPoint(Offset = 4882, Source = "4882", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4882", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_41",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 41",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_41", ])]
	public float 固高直线Y2轴位置_41 { get; set; }

	[BinaryPoint(Offset = 4884, Source = "4884", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4884", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_42",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 42",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_42", ])]
	public float 固高直线Y2轴位置_42 { get; set; }

	[BinaryPoint(Offset = 4886, Source = "4886", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4886", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_43",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 43",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_43", ])]
	public float 固高直线Y2轴位置_43 { get; set; }

	[BinaryPoint(Offset = 4888, Source = "4888", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4888", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_44",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 44",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_44", ])]
	public float 固高直线Y2轴位置_44 { get; set; }

	[BinaryPoint(Offset = 4890, Source = "4890", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4890", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_45",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 45",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_45", ])]
	public float 固高直线Y2轴位置_45 { get; set; }

	[BinaryPoint(Offset = 4892, Source = "4892", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4892", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_46",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 46",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_46", ])]
	public float 固高直线Y2轴位置_46 { get; set; }

	[BinaryPoint(Offset = 4894, Source = "4894", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4894", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_47",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 47",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_47", ])]
	public float 固高直线Y2轴位置_47 { get; set; }

	[BinaryPoint(Offset = 4896, Source = "4896", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4896", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_48",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 48",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_48", ])]
	public float 固高直线Y2轴位置_48 { get; set; }

	[BinaryPoint(Offset = 4898, Source = "4898", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4898", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_49",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 49",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_49", ])]
	public float 固高直线Y2轴位置_49 { get; set; }

	[BinaryPoint(Offset = 4900, Source = "4900", Tags = "轴位置", ReaderData = "PLC", WriterData = "PLC", CustomData = null)]
	[ValueInfo(Source = "PLC:4900", Category = "PLC/固高直线Y2轴位置", Unit = "",MinValue = 0, MaxValue = 4096, Description = "", InitAttachData =  [
		DataDefine.KeyValue,"NameByCN", "固高直线Y2轴位置_50",
		DataDefine.KeyValue,"NameByEN", "GUGAO Linear Y2 Axis Position 50",
		DataDefine.KeyValue,"NameByVI", "Trục Y2 GUGAO Linear_Vị trí_50", ])]
	public float 固高直线Y2轴位置_50 { get; set; }

	#endregion

}