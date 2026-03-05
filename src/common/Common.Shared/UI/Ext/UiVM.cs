namespace ZitApp.UI;

public partial class UiVM : CommonUiVM
{
	public new AppVM GetAppVM() => (AppVM)AvaloniaApplication.Current.AppVM;
}

public partial class UiVM<T> : CommonUiVM<T> where T : UiView
{
	public new AppVM GetAppVM() => (AppVM)AvaloniaApplication.Current.AppVM;
}