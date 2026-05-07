using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ZitApp.UI.Account;

namespace ZitApp.UI;
[RegisterToIOC]
public partial class ReplaceMaterialWindow : UiTopLevelWindow
{
	public ReplaceMaterialWindow()
	{
		InitializeComponent();
	}

	private async void ScanTextBox_OnKeyDown(object? sender, KeyEventArgs e)
	{
		if (e.Key != Key.Enter)
			return;

		if (DataContext is not ReplaceMaterialVM vm)
			return;

		vm.MonoCode = In物料位置码.Text?.Trim() ?? "";
		vm.MonoSpaceCode = In物料码.Text?.Trim() ?? "";

		if (sender == In物料位置码)
		{
			In物料码.Focus();
			e.Handled = true;
			return;
		}

		if (sender == In物料码)
		{
			// await vm.Confirm();
			e.Handled = true;
		}
	}
}
