using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class PinCodeDemoViewModel : ObservableObject
{
	[ObservableProperty] private List<Exception>? _error;

	public PinCodeDemoViewModel()
	{
		CompleteCommand = new AsyncRelayCommand<IList<string>>(OnComplete);
		Error = [new Exception("Invalid verification code")];
	}

	public ICommand CompleteCommand { get; set; }

	private async Task OnComplete(IList<string>? obj)
	{
		if (obj is null) return;
		var code = string.Join("", obj);
		await MessageBox.ShowOverlay(code);
	}
}