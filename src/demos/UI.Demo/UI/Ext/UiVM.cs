namespace OinetApp.UI;

public partial class UiVM : UiViewModel
{
	public new AppVM GetAppVM() => (AppVM)AvaloniaApplication.Current.AppVM;
}

public partial class UiVM<T> : UiViewModel<T> where T : UiView
{
	public new AppVM GetAppVM() =>  (AppVM)AvaloniaApplication.Current.AppVM;
}