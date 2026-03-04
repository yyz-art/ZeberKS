using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Account;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class AccountManageView : UiView
{
	public AccountManageView()
	{
		InitializeComponent();
	}
}