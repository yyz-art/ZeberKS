namespace OinetApp.UI.Views.Demo.Ext;

public partial class PinCodeDemo : UserControl
{
	public PinCodeDemo()
	{
		InitializeComponent();
	}

	private async void VerificationCode_OnComplete(object? _, PinCodeCompleteEventArgs e)
	{
		var text = string.Join(string.Empty, e.Code);
		await MessageBox.ShowOverlay(text);
	}
}