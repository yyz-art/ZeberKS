using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class ScrollToButtonDemoViewModel : ObservableObject
{
	public ScrollToButtonDemoViewModel()
	{
		Items = new ObservableCollection<string>(Enumerable.Range(0, 1000).Select(a => "Item " + a));
	}

	public ObservableCollection<string> Items { get; set; }
}