using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class DatePickerDemoViewModel : ObservableObject
{
	[ObservableProperty] private DateTime? _selectedDate;

	public DatePickerDemoViewModel()
	{
		SelectedDate = DateTime.Today;
	}
}