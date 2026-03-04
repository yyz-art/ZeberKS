using Avalonia.Styling;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public partial class ThemeVariantDemo : UserControl
{
	public ThemeVariantDemo()
	{
		InitializeComponent();
		this.DataContext = new ThemeVariantDemoViewModel();
	}
}

public partial class ThemeVariantDemoViewModel : ObservableObject
{
	[ObservableProperty] private ThemeVariant? _selectedThemeVariant;

	public IEnumerable<ThemeVariant> ThemeVariants =>
	[
		ThemeVariant.Default,
		ThemeVariant.Light,
		ThemeVariant.Dark,
		UiTheme.Aquatic,
		UiTheme.Desert,
		UiTheme.Dusk,
		UiTheme.NightSky,
	];
}