using System.Globalization;
using Avalonia.Collections;
using Avalonia.Media;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo;

public class VariablesDemoViewModel : ObservableObject
{
	public VariablesDemoViewModel()
	{
		IResourceDictionary dictionary = new UiThemeResource();
		foreach (var dict in dictionary.MergedDictionaries)
		{
			foreach (var token in Tokens)
			{
				if (token.ResourceKey != null && dict.TryGetResource(token.ResourceKey, null, out var value))
				{
					token.Type = value?.GetType();
					token.Value = GetValueString(value);
				}
			}
		}

		foreach (var token in Tokens)
		{
			if (token.ResourceKey is not null && dictionary.TryGetValue(token.ResourceKey, out var value))
			{
				token.Type = value?.GetType();
				token.Value = GetValueString(value);
			}
		}

		GridData = new DataGridCollectionView(Tokens);
		GridData.GroupDescriptions.Add(new DataGridPathGroupDescription(nameof(VariableItem.Category)));
	}

	public DataGridCollectionView GridData { get; set; }

	private static List<VariableItem> Tokens { get; set; } =
	[
		new("Height", "Height-ControlSmall"),
		new("Height", "Height-ControlDefault"),
		new("Height", "Height-ControlLarge"),
		new("Icon Size", "Width-IconExtraSmall"),
		new("Icon Size", "Width-IconSmall"),
		new("Icon Size", "Width-IconMedium"),
		new("Icon Size", "Width-IconLarge"),
		new("Icon Size", "Width-IconExtraLarge"),
		new("Border CornerRadius", "Border-RadiusExtraSmall"),
		new("Border CornerRadius", "Border-RadiusSmall"),
		new("Border CornerRadius", "Border-RadiusMedium"),
		new("Border CornerRadius", "Border-RadiusLarge"),
		new("Border CornerRadius", "Border-RadiusFull"),
		new("Border Spacing", "Border-Spacing"),
		new("Border Spacing", "Border-SpacingControl"),
		new("Border Spacing", "Border-SpacingControlFocus"),
		new("Border Thickness", "Border-Thickness"),
		new("Border Thickness", "Border-ThicknessControl"),
		new("Border Thickness", "Border-ThicknessControlFocus"),
		new("Spacing", "Spacing-None"),
		new("Spacing", "Spacing-SuperTight"),
		new("Spacing", "Spacing-ExtraTight"),
		new("Spacing", "Spacing-Tight"),
		new("Spacing", "Spacing-BaseTight"),
		new("Spacing", "Spacing-Base"),
		new("Spacing", "Spacing-BaseLoose"),
		new("Spacing", "Spacing-Loose"),
		new("Spacing", "Spacing-ExtraLoose"),
		new("Spacing", "Spacing-SuperLoose"),
		new("Thickness", "Thickness-None"),
		new("Thickness", "Thickness-SuperTight"),
		new("Thickness", "Thickness-ExtraTight"),
		new("Thickness", "Thickness-Tight"),
		new("Thickness", "Thickness-BaseTight"),
		new("Thickness", "Thickness-Base"),
		new("Thickness", "Thickness-BaseLoose"),
		new("Thickness", "Thickness-Loose"),
		new("Thickness", "Thickness-ExtraLoose"),
		new("Thickness", "Thickness-SuperLoose"),
		new("FontSize", "FontSize-Small"),
		new("FontSize", "FontSize-Normal"),
		new("FontSize", "FontSize-H6"),
		new("FontSize", "FontSize-H5"),
		new("FontSize", "FontSize-H4"),
		new("FontSize", "FontSize-H3"),
		new("FontSize", "FontSize-H2"),
		new("FontSize", "FontSize-H1"),
		new("FontWeight", "FontWeight-Light"),
		new("FontWeight", "FontWeight-Regular"),
		new("FontWeight", "FontWeight-Bold"),
		new("FontFamily", "FontFamily-Regular"),
	];

	private static string GetValueString(object? value)
	{
		if (value is null) return string.Empty;

		return (value switch
		{
			double d => d.ToString(CultureInfo.InvariantCulture),
			CornerRadius c => c.IsUniform ? $"{c.TopLeft}" : c.ToString(),
			Thickness t => t.IsUniform ? $"{t.Left}" : t.ToString(),
			FontWeight fontWeight => Convert.ToInt32(fontWeight).ToString(),
			FontFamily fontFamily => fontFamily.FamilyNames.ToString(),
			_ => value.ToString()
		})!;
	}
}

public class VariableItem()
{
	public VariableItem(string category, string resourceKey, string description = "") : this()
	{
		Category = category;
		ResourceKey = resourceKey;
		Description = description;
	}

	public string? Category { get; set; }
	public string? ResourceKey { get; set; }
	public Type? Type { get; set; }
	public string? Value { get; set; }
	public string? Description { get; set; }

	public string CopyText =>
		$"""
		 <StaticResource x:Key="" ResourceKey="{ResourceKey}" />
		 """;
}