using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public enum ControlStatus
{
	New,
	Beta,
	Stable,
}

public class MenuItemViewModel : ViewModelBase
{
	public MenuItemViewModel()
	{
		ActivateCommand = new RelayCommand(OnActivate);
	}

	public string? MenuHeader { get; set; }
	public string? MenuIconName { get; set; }
	public string? Key { get; set; }
	public string? Status { get; set; }

	public bool IsSeparator { get; set; }
	public ObservableCollection<MenuItemViewModel> Children { get; set; } = new();

	public ICommand ActivateCommand { get; set; }

	private void OnActivate()
	{
		if (IsSeparator || Key is null) return;
		WeakReferenceMessenger.Default.Send(Key);
	}
}