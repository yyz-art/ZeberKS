using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class BadgeDemoViewModel : ViewModelBase
{
	[ObservableProperty] private string? _text = null;

	public BadgeDemoViewModel()
	{
	}

	[RelayCommand]
	public void ChangeText()
	{
		if (Text == null)
		{
			Text = DateTime.Now.ToShortDateString();
		}
		else
		{
			Text = null;
		}
	}
}