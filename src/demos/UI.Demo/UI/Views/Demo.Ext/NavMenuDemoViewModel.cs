using System.Collections.ObjectModel;
using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class NavMenuDemoViewModel : ObservableObject
{
	private MenuItem? _selectedMenuItem;

	public NavMenuDemoViewModel()
	{
		RandomCommand = new RelayCommand(OnRandom);
	}

	public MenuItem? SelectedMenuItem
	{
		get => _selectedMenuItem;
		set => SetField(ref _selectedMenuItem, value);
	}

	public ObservableCollection<MenuItem> MenuItems { get; set; } = new ObservableCollection<MenuItem>
	{
		new MenuItem
		{
			Header = "Introduction", Children =
			{
				new MenuItem()
				{
					Header = "Getting Started", Children =
					{
						new MenuItem() { Header = "Code of Conduct" },
						new MenuItem() { Header = "How to Contribute" },
						new MenuItem() { Header = "Development Workflow" },
					}
				},
				new MenuItem() { Header = "Design Principles" },
				new MenuItem()
				{
					Header = "Contributing", Children =
					{
						new MenuItem() { Header = "Code of Conduct" },
						new MenuItem() { Header = "How to Contribute" },
						new MenuItem() { Header = "Development Workflow" },
					}
				},
			}
		},
		new MenuItem { Header = "Controls", IsSeparator = true },
		new MenuItem { Header = "Badge" },
		new MenuItem { Header = "Banner" },
		new MenuItem { Header = "ButtonGroup" },
		new MenuItem { Header = "Class Input" },
		new MenuItem { Header = "Dialog" },
		new MenuItem { Header = "Divider" },
		new MenuItem { Header = "Drawer" },
		new MenuItem { Header = "DualBadge" },
		new MenuItem { Header = "EnumSelector" },
		new MenuItem { Header = "ImageViewer" },
		new MenuItem { Header = "IPv4Box" },
		new MenuItem { Header = "IconButton" },
		new MenuItem { Header = "KeyGestureInput" },
		new MenuItem { Header = "Loading" },
		new MenuItem { Header = "MessageBox" },
		new MenuItem { Header = "Navigation" },
		new MenuItem { Header = "NavMenu" },
		new MenuItem { Header = "NumericUpDown" },
		new MenuItem { Header = "Pagination" },
		new MenuItem { Header = "RangeSlider" },
		new MenuItem { Header = "SelectionList" },
		new MenuItem { Header = "TagInput" },
		new MenuItem { Header = "Timeline" },
		new MenuItem { Header = "TwoTonePathIcon" },
		new MenuItem { Header = "ThemeToggler" }
	};

	public ICommand RandomCommand { get; set; }

	private void OnRandom()
	{
		var items = GetLeaves();
		var index = new Random().Next(items.Count);
		SelectedMenuItem = items[index];
	}

	private List<MenuItem> GetLeaves()
	{
		List<MenuItem> items = new();
		foreach (var item in MenuItems)
		{
			items.AddRange(item.GetLeaves());
		}

		return items;
	}
}

public class MenuItem
{
	static Random r = new Random();

	public MenuItem()
	{
		NavigationCommand = new AsyncRelayCommand(OnNavigate);
		IconIndex = r.Next(100);
	}

	public string? Header { get; set; }
	public int IconIndex { get; set; }
	public bool IsSeparator { get; set; }
	public ICommand NavigationCommand { get; set; }

	public ObservableCollection<MenuItem> Children { get; set; } = new ObservableCollection<MenuItem>();

	private async Task OnNavigate()
	{
		await MessageBox.ShowOverlay(Header ?? string.Empty, "Navigation Result");
	}

	public IEnumerable<MenuItem> GetLeaves()
	{
		if (this.Children.Count == 0)
		{
			yield return this;
			yield break;
		}

		foreach (var child in Children)
		{
			var items = child.GetLeaves();
			foreach (var item in items)
			{
				yield return item;
			}
		}
	}
}