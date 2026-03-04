using System.Collections.ObjectModel;
using Avalonia.Media;
using Oinet.Mvvm;
using Oinet.UI.RES.Icons;

namespace OinetApp.UI.Views.Demo;

public partial class IconDemoViewModel : ObservableObject
{
	private readonly Dictionary<string, IconItem> _filledIcons = new();
	private readonly IResourceDictionary? _resources = new Icons();
	private readonly Dictionary<string, IconItem> _strokedIcons = new();

	[ObservableProperty] private string? _searchText;

	public ObservableCollection<IconItem> FilteredFilledIcons { get; set; } = [];
	public ObservableCollection<IconItem> FilteredStrokedIcons { get; set; } = [];

	public void InitializeResources()
	{
		if (_resources is null) return;

		foreach (var provider in _resources.MergedDictionaries)
		{
			if (provider is not ResourceDictionary dic) continue;

			foreach (var key in dic.Keys)
			{
				if (dic[key] is not Geometry geometry) continue;
				var icon = new IconItem
				{
					ResourceKey = key.ToString(),
					Geometry = geometry
				};

				if (key.ToString()!.EndsWith("Stroked"))
					_strokedIcons[key.ToString()!.ToLowerInvariant()] = icon;
				else
					_filledIcons[key.ToString()!.ToLowerInvariant()] = icon;
			}
		}

		OnSearchTextChanged(string.Empty);
	}

	partial void OnSearchTextChanged(string? value)
	{
		var search = value?.ToLowerInvariant() ?? string.Empty;

		FilteredFilledIcons.Clear();
		foreach (var pair in _filledIcons.Where(i => i.Key.Contains(search)))
		{
			FilteredFilledIcons.Add(pair.Value);
		}

		FilteredStrokedIcons.Clear();
		foreach (var pair in _strokedIcons.Where(i => i.Key.Contains(search)))
		{
			FilteredStrokedIcons.Add(pair.Value);
		}
	}
}

public class IconItem
{
	public string? ResourceKey { get; set; }
	public Geometry? Geometry { get; set; }
}