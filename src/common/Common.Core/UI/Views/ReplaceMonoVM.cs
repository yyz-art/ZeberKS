using ZC;
using ZitApp.Services;
using ZitApp.UI.Views.Account;

namespace ZitApp.UI.Account;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ReplaceMonoVM : CommonUiVM<ReplaceMonoWindow>
{
	public partial string MonoSpaceName { get; set; } = "位置1";
	public partial string MonoCode { get; set; } = "TestCode123456789";
	public partial string MonoSpaceCode { get; set; } = "区域1";
	public partial int MonoCount { get; set; } = 12345;

	public void @CloseView()
	{
		View.Hide();
	}

	public void Show()
	{
		View.Hide();
		MonoCode = "";
		View.Show();
		View.In物料码.Focus();
	}
}