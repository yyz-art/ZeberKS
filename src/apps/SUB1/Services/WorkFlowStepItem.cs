using Avalonia.Media;
using ZC.Mvvm;

namespace ZitApp.Services;

[ObservableObject]
public partial class WorkFlowStepItem
{
	public partial string Name { get; set; } = "";
	public partial IBrush Background { get; set; } = Brushes.DimGray;
	public partial IBrush Foreground { get; set; } = Brushes.White;
}
