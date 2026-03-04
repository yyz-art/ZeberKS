using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class TabControlDemoViewModel : ObservableObject
{
	public ObservableCollection<string> Items => new(Enumerable.Range(1, 200).Select(a => "Tab " + a));
}