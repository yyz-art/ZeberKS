using Oinet.Mvvm;
using Oinet.UI.Models;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class NotificationDemoViewModel : ObservableObject
{
	[ObservableProperty] private bool _showClose = true;

	[ObservableProperty] private bool _showIcon = true;
	public UiNotificationManager? NotificationManager { get; set; }

	[RelayCommand]
	public void ChangePosition(object obj)
	{
		if (obj is string s && NotificationManager is not null)
		{
			Enum.TryParse<UiMessagePosition>(s, out var notificationPosition);
			NotificationManager.Position = notificationPosition;
		}
	}

	[RelayCommand]
	public void ShowNormal(object obj)
	{
		if (obj is not string s) return;
		Enum.TryParse<UiMessageType>(s, out var notificationType);
		NotificationManager?.Show(
			new UiNotification("Welcome", "This is message"),
			showIcon: ShowIcon,
			showClose: ShowClose,
			type: notificationType);
	}

	[RelayCommand]
	public void ShowLight(object obj)
	{
		if (obj is not string s) return;
		Enum.TryParse<UiMessageType>(s, out var notificationType);
		NotificationManager?.Show(
			new UiNotification("Welcome", "This is message"),
			showIcon: ShowIcon,
			showClose: ShowClose,
			type: notificationType,
			classes: ["Light"]);
	}
}