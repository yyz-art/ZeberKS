namespace ZitApp.Devices.Screw;
/// 注:在  PC端/触摸屏端  控制模式下如下命令才有效。(IO端控制模式下如吓命令无效。);
public enum ScrewMachineControlCommand : ushort
{
	已停止 = 0,
	开始拧紧 = 0x2AAA,
	停止拧紧 = 0x2BBB,
	开始拧松 = 0x2CCC,
	停止拧松 = 0x2DDD,
	开始自由转 = 0x2EEE,
	停止自由转 = 0x2FFF,
}