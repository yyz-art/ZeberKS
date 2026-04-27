using Avalonia.Controls;
using Avalonia.Input;

namespace ZitApp.UI.FeederMaterial; 

[RegisterToIOC(LifetimeType.Singleton)]
public partial class FeederMaterialView : UiView
{
	public FeederMaterialView()
	{
		InitializeComponent();
	}

	private async void FeederTextBox_OnKeyDown(object? sender, KeyEventArgs e)
	{
		if (e.Key != Key.Enter)
			return;

		if (sender is not TextBox textBox ||
		    textBox.DataContext is not FeederMaterialItem item ||
		    DataContext is not FeederMaterialVM vm)
			return;

		switch (textBox.Tag?.ToString())
		{
			case "FeederCode":
				item.FeederCode = textBox.Text ?? "";
				break;
			case "MaterialCode1":
				item.MaterialCode1 = textBox.Text ?? "";
				break;
			case "MaterialCode2":
				item.MaterialCode2 = textBox.Text ?? "";
				break;
			case "MaterialCode3":
				item.MaterialCode3 = textBox.Text ?? "";
				break;
			case "MaterialCode4":
				item.MaterialCode4 = textBox.Text ?? "";
				break;
			case "MaterialCode5":
				item.MaterialCode5 = textBox.Text ?? "";
				break;
		}

		await vm.ApplyFeederItemAsync(item);
		e.Handled = true;
	}
}
