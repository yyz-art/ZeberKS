using ZC.Mvvm;

namespace ZitApp.UI.Main;

public enum PassState
{
	NA,
	OK,
	NG
}

[RegisterToIOC(LifetimeType.Singleton)]
public partial class CamerasVM : UiVM
{
	public partial string LeftBarcode { get; set; } = "XXXXXX-L";
	public partial PassState LeftPassState { get; set; } = PassState.OK;
	public partial string RightBarcode { get; set; } = "xxxxxx-L";
	public partial PassState RightPassState { get; set; } = PassState.NA;
	public partial ObservableList<string> LeftImageNames { get; set; } = ["A-png", "B-png", "C-png"];
	public partial ObservableList<string> RightImageNames { get; set; } = ["A-png", "B-png", "C-png"];
}