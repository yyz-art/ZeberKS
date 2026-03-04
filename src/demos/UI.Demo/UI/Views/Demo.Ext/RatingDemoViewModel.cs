using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class RatingDemoViewModel : ViewModelBase
{
	[ObservableProperty] private bool _allowClear = true;
	[ObservableProperty] private bool _allowHalf = true;
	[ObservableProperty] private int _count = 5;
	[ObservableProperty] private double _defaultValue = 2.3;
	[ObservableProperty] private bool _isEnabled = true;
	[ObservableProperty] private double _value;
}