using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class DateRangePickerDemoViewModel : ObservableObject
{
	[ObservableProperty] private DateTime? _endDate;
	[ObservableProperty] private DateTime? _startDate;

	public DateRangePickerDemoViewModel()
	{
		StartDate = DateTime.Today;
		EndDate = DateTime.Today.AddDays(7);
	}
}