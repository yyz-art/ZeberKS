using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ZitApp.Models;

namespace ZitApp.UI.Ext;

public class StateColorConverter : IValueConverter
{
	public IBrush TrueBrush { get; set; } = Brushes.Green;
	public IBrush FalseBrush { get; set; } = Brushes.Red;
	public IBrush DefaultBrush { get; set; } = Brushes.Orange;

	public IBrush NaBrush { get; set; } = Brushes.CornflowerBlue;

	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value is bool boolValue)
		{
			return boolValue ? TrueBrush : FalseBrush;
		}

		if (value is ProductionState okNgState)
		{
			return okNgState switch
			{
				ProductionState.NA => NaBrush,
				ProductionState.OK => TrueBrush,
				ProductionState.NG => FalseBrush,
				_ => throw new ArgumentOutOfRangeException()
			};
		}

		return DefaultBrush;
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}
}