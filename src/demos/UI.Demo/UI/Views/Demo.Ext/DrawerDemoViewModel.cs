using System.Windows.Input;
using Oinet.Mvvm;
using Oinet.UI.ControlLibs.Options;
using Oinet.UI.Controls;
using Oinet.UI.Models;
using OinetApp.UI.Dialogs;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class DrawerDemoViewModel : ObservableObject
{
	[ObservableProperty] private DialogButton _buttons;

	[ObservableProperty] private bool _canLightDismiss;
	[ObservableProperty] private bool _canResize;

	[ObservableProperty] private bool _custom;
	[ObservableProperty] private bool? _isCloseButtonVisible;
	[ObservableProperty] private bool _isLocal;
	[ObservableProperty] private bool _isModal;

	[ObservableProperty] private ViewSide _position;
	[ObservableProperty] private string? _title;

	public DrawerDemoViewModel()
	{
		ShowDialogCommand = new AsyncRelayCommand(ShowDefaultDialog);
		Position = ViewSide.Right;
		IsModal = true;
		Title = "Add New";
	}

	public ICommand ShowDialogCommand { get; set; }

	private async Task ShowDefaultDialog()
	{
		var options = new DrawerOptions()
		{
			Position = Position,
			Buttons = Buttons,
			CanLightDismiss = CanLightDismiss,
			IsCloseButtonVisible = IsCloseButtonVisible,
			Title = Title,
			CanResize = CanResize,
		};
		var hostId = IsLocal ? "LocalHost" : null;
		if (Custom)
		{
			var vm = new CustomDemoDialogViewModel();
			if (IsModal)
			{
				await Drawer.ShowCustomModal<CustomDemoDialog, CustomDemoDialogViewModel, object?>(vm, hostId, options);
			}
			else
			{
				Drawer.ShowCustom<CustomDemoDialog, CustomDemoDialogViewModel>(vm, hostId, options);
			}
		}
		else
		{
			var vm = new DefaultDemoDialogViewModel();
			if (IsModal)
			{
				await Drawer.ShowModal<DefaultDemoDialog, DefaultDemoDialogViewModel>(vm, hostId, options);
			}
			else
			{
				Drawer.Show<DefaultDemoDialog, DefaultDemoDialogViewModel>(vm, hostId, options);
			}
		}
	}
}