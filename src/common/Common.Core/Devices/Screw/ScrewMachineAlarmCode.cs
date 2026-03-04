namespace ZitApp.Devices.Screw;

public enum ScrewMachineAlarmCode : ushort
{
	无 = 0,
	ALLErrorFlag = 1,
	浮高 = 2,
	滑牙 = 3,

	// 断电重启
	过流 = 4,

	// 检查供电电压是否偏高
	过压 = 5,

	// 检查供电电压是否偏低
	欠压 = 6,
	飞车 = 7,

	//检查批头是否打滑，螺丝是否打滑
	I2T过热 = 8,
	反转不到位 = 9,

	// 检测电机线与encoder线接触是否良好
	位置偏差过大 = 10,
}