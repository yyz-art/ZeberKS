using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ZitApp.UI.Dialogs;

public partial class MaterialMismatchDialog : Window
{
	public MaterialMismatchDialog()
	{
		InitializeComponent();
	}

	public void SetContent(string title, string message)
	{
		Title = title;
		TitleTextBlock.Text = title;
		MessageTextBlock.Text = message;
	}

	void ConfirmClick(object? sender, RoutedEventArgs e) => Close();
}
