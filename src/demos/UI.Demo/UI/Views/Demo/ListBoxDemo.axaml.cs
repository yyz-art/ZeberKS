using System.Collections;

namespace OinetApp.UI.Views.Demo;

public partial class ListBoxDemo : UserControl
{
	public ListBoxDemo()
	{
		InitializeComponent();
	}

	public IEnumerable Items { get; set; } = new List<string> { "Ding", "Otter", "Husky", "Mr.17", "Cass", };
}