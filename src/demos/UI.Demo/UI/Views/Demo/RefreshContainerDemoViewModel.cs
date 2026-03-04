using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class RefreshContainerDemoViewModel : ObservableObject
{
	public RefreshContainerDemoViewModel()
	{
		Items = new ObservableCollection<string>(Enumerable.Range(1, 200).Select(i => $"Item {i}"));
	}

	public ObservableCollection<string> Items { get; }

	public async Task AddToTop()
	{
		await Task.Delay(1000);
		Items.Insert(0, $"Item {200 - Items.Count}");
	}
}