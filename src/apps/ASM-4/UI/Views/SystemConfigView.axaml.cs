using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ZC.Mvvm;

namespace ZitApp.UI.Config;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class SystemConfigView : UiView
{
	public SystemConfigView()
	{
		InitializeComponent();
	}

	private async void SettingValueTextBox_OnKeyDown(object? sender, KeyEventArgs e)
	{
		if (e.Key != Key.Enter)
			return;

		e.Handled = true;
		if (sender is not TextBox { DataContext: IPropertyInstance propertyInstance } textBox)
			return;

		if (DataContext is SystemConfigVM vm)
			await vm.ApplySinglePropertyAsync(propertyInstance, textBox.Text ?? "");
	}
}
