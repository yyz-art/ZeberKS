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

		if (value is OkNgState okNgState)
		{
			return okNgState switch
			{
				OkNgState.NA => NaBrush,
				OkNgState.OK => TrueBrush,
				OkNgState.NG => FalseBrush,
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