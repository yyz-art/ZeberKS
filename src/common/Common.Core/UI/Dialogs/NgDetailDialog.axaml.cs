using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Dialogs;

public partial class NgDetailDialog : Window
{
	public NgDetailDialog()
	{
		InitializeComponent();
	}

	private void HideClick(object? sender, RoutedEventArgs e)
	{
		Hide();
	}
}