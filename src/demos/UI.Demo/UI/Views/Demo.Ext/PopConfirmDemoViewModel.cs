using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class PopConfirmDemoViewModel : ObservableObject
{
	public PopConfirmDemoViewModel()
	{
		AsyncConfirmCommand = new AsyncRelayCommand(OnConfirmAsync);
		AsyncCancelCommand = new RelayCommand(OnCancelAsync);
		ConfirmCommand = new RelayCommand(OnConfirm);
		CancelCommand = new RelayCommand(OnCancel);
	}

	internal UiToastManager? ToastManager { get; set; }

	public ICommand ConfirmCommand { get; }
	public ICommand CancelCommand { get; }

	public ICommand AsyncConfirmCommand { get; }
	public ICommand AsyncCancelCommand { get; }

	private void OnCancel()
	{
		ToastManager?.Show(new Toast("Canceled"), UiMessageType.Error, classes: ["Light"]);
	}

	private void OnConfirm()
	{
		ToastManager?.Show(new Toast("Confirmed"), UiMessageType.Success, classes: ["Light"]);
	}

	private async Task OnConfirmAsync()
	{
		await Task.Delay(3000);
		ToastManager?.Show(new Toast("Async Confirmed"), UiMessageType.Success, classes: ["Light"]);
	}

	private void OnCancelAsync()
	{
		ToastManager?.Show(new Toast("Async Canceled"), UiMessageType.Error, classes: ["Light"]);
	}
}