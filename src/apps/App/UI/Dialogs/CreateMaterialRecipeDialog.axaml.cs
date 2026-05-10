using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ZitApp.UI.Dialogs;
[RegisterToIOC(LifetimeType.Singleton)]
public partial class CreateMaterialRecipeDialog : UiWindow
{
	public CreateMaterialRecipeDialog()
	{
		InitializeComponent();
	}
}