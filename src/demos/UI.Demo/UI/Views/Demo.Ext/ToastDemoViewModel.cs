using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class ToastDemoViewModel : ObservableObject
{
	[ObservableProperty] private bool _showClose = true;

	[ObservableProperty] private bool _showIcon = true;
	public UiToastManager? ToastManager { get; set; }

	public string? Content { get; set; }

	[RelayCommand]
	public void ShowNormal(object obj)
	{
		if (obj is string s)
		{
			Enum.TryParse<UiMessageType>(s, out var notificationType);
			ToastManager?.Show(
				new Toast("This is message"),
				showIcon: ShowIcon,
				showClose: ShowClose,
				type: notificationType);
		}

		// ToastManager?.Show(new ToastDemoViewModel
		// {
		//     Content = "This is message",
		//     ToastManager = ToastManager
		// });
	}

	[RelayCommand]
	public void ShowLight(object obj)
	{
		if (obj is string s)
		{
			Enum.TryParse<UiMessageType>(s, out var notificationType);
			ToastManager?.Show(
				new Toast("This is message"),
				showIcon: ShowIcon,
				showClose: ShowClose,
				type: notificationType,
				classes: ["Light"]);
		}
	}

	[RelayCommand]
	public void YesCommand()
	{
		ToastManager?.Show(new Toast("Yes!"));
	}

	[RelayCommand]
	public void NoCommand()
	{
		ToastManager?.Show(new Toast("No!"));
	}
}