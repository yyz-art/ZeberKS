using Oinet.Mvvm;
using Oinet.UI.Models;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class IconButtonDemoViewModel : ObservableObject
{
	[ObservableProperty] private bool _isLoading;
	[ObservableProperty] private bool _isLoading2;
	[ObservableProperty] private ViewSide _selectedPosition;
}