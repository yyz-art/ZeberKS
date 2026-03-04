using System.Collections.ObjectModel;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class ComboBoxDemoViewModel : ObservableObject
{
	public ObservableCollection<string> Items { get; set; } = ["Ding", "Otter", "Husky", "Mr.17", "Cass"];
}