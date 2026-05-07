using ZC.Mvvm;

namespace ZitApp.Models;

public partial class ScrewInstallData : ObservableObject
{
	public partial int Id { get; set; }
	public partial int ScrewNo { get; set; }
	public partial double MaxTorque { get; set; }
	public partial double Turns { get; set; }
	public partial string Sn1 { get; set; } = "";
	public partial string Sn2 { get; set; } = "";
	public partial DateTime CollectedAt { get; set; }
	public partial bool HasValue { get; set; }
	public partial string StateText { get; set; } = "";
}