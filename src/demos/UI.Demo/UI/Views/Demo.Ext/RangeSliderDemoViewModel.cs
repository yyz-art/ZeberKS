using System.Collections.ObjectModel;
using Avalonia.Layout;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class RangeSliderDemoViewModel : ObservableObject
{
	[ObservableProperty] private Orientation _orientation;

	public ObservableCollection<Orientation> Orientations { get; set; } = new ObservableCollection<Orientation>()
	{
		Orientation.Horizontal,
		Orientation.Vertical
	};
}