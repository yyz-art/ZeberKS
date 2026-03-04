using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class NumberDisplayerDemoViewModel : ObservableObject
{
	[ObservableProperty] private DateTime _dateValue;
	[ObservableProperty] private double _doubleValue;
	[ObservableProperty] private int _value;

	public NumberDisplayerDemoViewModel()
	{
		IncreaseCommand = new RelayCommand(OnChange);
		Value = 0;
		DoubleValue = 0d;
		DateValue = DateTime.Now;
	}

	public ICommand IncreaseCommand { get; }

	private void OnChange()
	{
		Random r = new Random();
		Value = r.Next(int.MaxValue);
		DoubleValue = r.NextDouble() * 100000;
		DateValue = DateTime.Today.AddDays(r.Next(1000));
	}
}