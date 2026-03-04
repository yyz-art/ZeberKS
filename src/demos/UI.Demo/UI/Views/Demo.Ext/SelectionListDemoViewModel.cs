using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class SelectionListDemoViewModel : ObservableObject
{
	[ObservableProperty] private string? _selectedItem;

	public SelectionListDemoViewModel()
	{
		Items = new ObservableCollection<string>()
		{
			"Ding", "Otter", "Husky", "Mr. 17", "Cass"
		};
		SelectedItem = Items[0];
	}

	public ObservableCollection<string> Items { get; set; }

	public void Clear()
	{
		SelectedItem = null;
	}
}