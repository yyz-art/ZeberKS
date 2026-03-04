using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Metadata;

namespace OinetApp.UI.Converters;

public class FileIconConverter : IMultiValueConverter
{
	[Content] public IDictionary<string, object?> Items { get; } = new Dictionary<string, object?>();

	public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
	{
		if (values[0] is bool isDirectory && values[1] is bool isOpen)
		{
			if (!isDirectory)
			{
				return Items["file"];
			}

			return isOpen ? Items["folderOpen"] : Items["folderClosed"];
		}

		return AvaloniaProperty.UnsetValue;
	}
}