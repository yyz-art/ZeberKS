using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class AvatarDemoViewModel : ViewModelBase
{
	[ObservableProperty] private bool _canClick = true;
	[ObservableProperty] private string _content = "AS";

	[RelayCommand(CanExecute = nameof(OinetApp.UI.Views.Demo.Ext.AvatarDemoViewModel.CanClick))]
	private void Click()
	{
		Content = "BM";
	}
}