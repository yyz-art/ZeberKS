#if ASM15_1
using ZC;
using ZC.Mvvm;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class Calibration1Service : CalibrationServiceBase
{
	public required AppConfig AppConfig { get; init; }
	protected override string CalibrationIp => AppConfig.Calibration1IpAddress;
	protected override int CalibrationPort => AppConfig.Calibration1Port;
}
#endif
