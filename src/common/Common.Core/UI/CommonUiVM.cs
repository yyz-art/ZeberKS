
using ZC.Mvvm;

namespace ZitApp.UI;

public partial class CommonUiVM : UiViewModel
{
	public I18n I18N =>I18n.D;
	public CommonAppVM GetAppVM() => (CommonAppVM)AvaloniaApplication.Current.AppVM;
	public override ICommandManager GetCommandManager() => GetAppVM();
}

public partial class CommonUiVM<T> : UiViewModel<T> where T : Control, IUiView
{
	public I18n I18N =>I18n.D;
	public CommonAppVM GetAppVM() => (CommonAppVM)AvaloniaApplication.Current.AppVM;
	public override ICommandManager GetCommandManager() => GetAppVM();
}