using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class TabStripDemoViewModel : ObservableObject
{
	public ObservableCollection<string> Items => new(Enumerable.Range(1, 10).Select(a => "Tab " + a));
}