using ZC.Annotations;
using ZC.BinStructs;
using ZC.DP.Memory;
using ZC.Mvvm;

namespace ZitApp.Devices.Screw;

[BinaryStruct(Length = 150, LengthUnit = 2, ByteFormat = ByteFormat.CDAB)]
public partial class ScrewMachineRecipeProperties : ObservableObject
{
	[ValueInfo(Description = "0--精度优先，2--速度优先(自攻牙螺丝)", MinValue = 0, MaxValue = 9)]
	[BinaryPoint(Offset = 0)]
	public partial ushort 拧紧的模式 { get; set; }

	[ValueInfo(Description = "0--CW，1--CCW", MinValue = 0, MaxValue = 1)]
	[BinaryPoint(Offset = 1)]
	public partial ushort 拧紧旋转方向 { get; set; }

	[ValueInfo(Description = "", Unit = "N.m", MinValue = 0.001, MaxValue = 32.764)]
	[BinaryPoint(Offset = 2)]
	public partial ushort 目标扭力 { get; set; }

	// [BinaryPoint(Offset = 3, Description = "(保留参数)")]
	// public partial ushort 是否开启入牙功能 { get; set; }
	// [BinaryPoint(Offset = 4, Description = "(保留参数)")]
	// public partial ushort 初始检出量 { get; set; }

	// [BinaryPoint(Offset = 5, Description = "")]
	// public partial ushort 是否开启攻丝功能 { get; set; }

	// [BinaryPoint(Offset = 6, Description = "(保留参数)")]
	// public partial ushort 初始攻丝扭矩 { get; set; }

	// [BinaryPoint(Offset = 7, Description = "")]
	// public partial ushort 攻丝免检扭矩圈数 { get; set; }
	[ValueInfo(Description = "", Unit = "ms", MinValue = 0, MaxValue = 4000)]
	[BinaryPoint(Offset = 8)]
	public partial ushort 扭力保持时间 { get; set; }

	// [BinaryPoint(Offset = 9, Description = "")]
	// public partial ushort 浮高界定圈数 { get; set; }
	// [BinaryPoint(Offset = 10, Description = "")]
	// public partial ushort 滑牙界定圈数 { get; set; }

	// [BinaryPoint(Offset = 11, Description = "(保留参数)")]
	// public partial ushort 浮高后拧紧角度 { get; set; }
	// [BinaryPoint(Offset = 12, Description = "")]
	// public partial ushort 触发速度切换的扭力比值 { get; set; }

	// [BinaryPoint(Offset = 13, Description = "(保留参数)")]
	// public partial ushort 切换后速度 { get; set; }
	[ValueInfo(MinValue = -1000, MaxValue = 1000, Unit = "0.01A")]
	[BinaryPoint(Offset = 14, Description = "")]
	public partial ushort 扭力补偿值 { get; set; }

	// [BinaryPoint(Offset = 15, Description = "")]
	// public partial ushort 正转的Step的实际数量 { get; set; }
	[ValueInfo(Description = "0--不开启，1--开启", MinValue = 0, MaxValue = 1)]
	[BinaryPoint(Offset = 16, Description = "")]
	public partial ushort 开启浮高滑牙检测 { get; set; }
	// [BinaryPoint(Offset = 17, Description = "(保留参数)")]
	// public partial ushort 拧紧后保护电批的回退角度 { get; set; }

	// [BinaryPoint(Offset = 18, Description = "(保留参数)")]
	// public partial ushort 是否开启IO方式的分段扭力功能 { get; set; }
	// [BinaryPoint(Offset = 19, Description = "")]
	// public partial ushort IO方式的第一段扭力 { get; set; }
	// [BinaryPoint(Offset = 20, Description = "")]
	// public partial ushort 触发速度切换的扭力 { get; set; }
	// [BinaryPoint(Offset = 21, Description = "")]
	// public partial ushort 触发速度切换的速度比值 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "ms")]
	[BinaryPoint(Offset = 22, Description = "")]
	public partial ushort 待机调整时间 { get; set; }

	// [BinaryPoint(Offset = 23, Description = "")]
	// public partial ushort 工件螺丝数量 { get; set; }
	// [BinaryPoint(Offset = 24, Description = "")]
	// public partial ushort 是否开启IO触发圈数计数 { get; set; }
	// [BinaryPoint(Offset = 25, Description = "")]
	// public partial ushort IO触发的目标圈数 { get; set; }

	// [BinaryPoint(Offset = 26, Description = "(手持式上用)")]
	// public partial ushort 扭力偏差上限 { get; set; }
	// [BinaryPoint(Offset = 27, Description = "(手持式上用)")]
	// public partial ushort 扭力偏差下限 { get; set; }
	// [BinaryPoint(Offset = 28, Description = "")]
	// public partial ushort 扭力免检圈数 { get; set; }
	// [BinaryPoint(Offset = 50, Description = "")]
	// public partial ushort 自由旋转方向 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	[BinaryPoint(Offset = 60)]
	public partial ushort 拧紧圈数Step0 { get; set; }

	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 61)]
	public partial ushort 拧紧速度Step0 { get; set; }

	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 62)]
	public partial ushort 扭力Step0 { get; set; }
	
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	
	[BinaryPoint(Offset = 65)]
	public partial ushort 拧紧圈数Step1 { get; set; }

	[BinaryPoint(Offset = 66, Description = "")]
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	public partial ushort 拧紧速度Step1 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 67, Description = "")]
	public partial ushort 扭力Step1 { get; set; }

	[BinaryPoint(Offset = 70, Description = "")]
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	public partial ushort 拧紧圈数Step2 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 71, Description = "")]
	public partial ushort 拧紧速度Step2 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 72, Description = "")]
	public partial ushort 扭力Step2 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]

	[BinaryPoint(Offset = 75, Description = "")]
	public partial ushort 拧紧圈数Step3 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 76, Description = "")]
	public partial ushort 拧紧速度Step3 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 77, Description = "")]
	public partial ushort 扭力Step3 { get; set; }

	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	[BinaryPoint(Offset = 80, Description = "")]
	public partial ushort 拧紧圈数Step4 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 81, Description = "")]
	public partial ushort 拧紧速度Step4 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 82, Description = "")]
	public partial ushort 扭力Step4 { get; set; }

	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	[BinaryPoint(Offset = 85, Description = "")]
	public partial ushort 拧紧圈数Step5 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 86, Description = "")]
	public partial ushort 拧紧速度Step5 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 87, Description = "")]
	public partial ushort 扭力Step5 { get; set; }

	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	[BinaryPoint(Offset = 90, Description = "")]
	public partial ushort 拧紧圈数Step6 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 91, Description = "")]
	public partial ushort 拧紧速度Step6 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 92, Description = "")]
	public partial ushort 扭力Step6 { get; set; }
	
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "r")]
	[BinaryPoint(Offset = 95, Description = "")]
	public partial ushort 拧紧圈数Step7 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 5000, Unit = "rpm")]
	[BinaryPoint(Offset = 96, Description = "")]
	public partial ushort 拧紧速度Step7 { get; set; }
	[ValueInfo(MinValue = 0, MaxValue = 4000, Unit = "N.m")]
	[BinaryPoint(Offset = 97, Description = "")]
	public partial ushort 扭力Step7 { get; set; }
}