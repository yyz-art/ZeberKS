using System.Collections.ObjectModel;
using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class BreadcrumbDemoViewModel : ObservableObject
{
	public ObservableCollection<BreadcrumbDemoItem> Items1 { get; set; } =
	[
		new BreadcrumbDemoItem { Section = "Home", Icon = "Home" },
		new BreadcrumbDemoItem { Section = "Page 1", Icon = "Page" },
		new BreadcrumbDemoItem { Section = "Page 2", Icon = "Page" },
		new BreadcrumbDemoItem { Section = "Page 3", Icon = "Page" },
		new BreadcrumbDemoItem { Section = "Page 4", Icon = "Page", IsReadOnly = true }
	];
}

public partial class BreadcrumbDemoItem : ObservableObject
{
	[ObservableProperty] private bool _isReadOnly;

	public BreadcrumbDemoItem()
	{
		Command = new AsyncRelayCommand(async () => { await MessageBox.ShowOverlay(Section ?? string.Empty); });
	}

	public string? Section { get; set; }
	public string? Icon { get; set; }

	public ICommand Command { get; set; }
}