using ZC.Mvvm;

namespace ZitApp.Models;

public partial class ScrewLimitConfig : ObservableObject
{
	public partial int ScrewNo { get; set; }
	public partial double TorqueLowLimit { get; set; }
	public partial double TorqueUpperLimit { get; set; }
	public partial double TurnsLowLimit { get; set; }
	public partial double TurnsUpperLimit { get; set; }
}
