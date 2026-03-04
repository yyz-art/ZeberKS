using System.Windows.Input;
using Avalonia.Collections;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class PaginationDemoViewModel : ViewModelBase
{
	public PaginationDemoViewModel()
	{
		this.LoadPageCommand = new RelayCommand<int?>(LoadPage);
	}

	public AvaloniaList<int> PageSizes { get; set; } = new() { 10, 20, 50, 100 };

	public ICommand LoadPageCommand { get; }

	private void LoadPage(int? pageIndex)
	{
		Debug.WriteLine($"Loading page {pageIndex}");
	}
}