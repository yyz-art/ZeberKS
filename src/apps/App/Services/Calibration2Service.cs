#if ASM15_1
using ZC;
using ZC.Mvvm;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class Calibration2Service : CalibrationServiceBase
{
	public required AppConfig AppConfig { get; init; }
	protected override string CalibrationIp => AppConfig.Calibration2IpAddress;
	protected override int CalibrationPort => AppConfig.Calibration2Port;
}
#endif
