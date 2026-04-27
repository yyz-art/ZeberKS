using System.Globalization;
using ZC.BinStructs;
using ZC.CFG;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZitApp.Attributes;
using ZitApp.Models;

namespace ZitApp.BinStructs;

public partial class ProductRecipe : ProductRecipeBase
{
	public static void CopyPropertyValues(ProductRecipe src, ProductRecipe dst)
	{
		var properties = TypeMetaInfo<ProductRecipe>.Cache.Properties;
		foreach (var propertyMetaInfo in properties)
		{
			if (propertyMetaInfo.CanRead && propertyMetaInfo.CanWrite)
			{
				var value = propertyMetaInfo.Getter!.Invoke(src);
				propertyMetaInfo.Setter!.Invoke(dst, value);
			}
		}
	}

	public static string ToPlcSource(int offset) => $"PLC:{offset}";

	public static string GetPointSource(ProductRecipe? recipe, IBinaryPointInfo pointInfo)
	{
		if (recipe?.点位数据源.TryGetValue(pointInfo.Name, out var source) == true &&
		    TryParsePlcSource(source, out var offset))
		{
			return ToPlcSource(offset);
		}

		return ToPlcSource(pointInfo.Offset);
	}

	public static bool TryParsePlcSource(string? source, out int offset)
	{
		offset = 0;
		if (string.IsNullOrWhiteSpace(source))
			return false;

		var text = source.Trim();
		var colonIndex = text.IndexOf(':');
		if (colonIndex >= 0)
			text = text[(colonIndex + 1)..].Trim();

		return int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out offset);
	}

	public static IBinaryPointInfo GetEffectivePointInfo(ProductRecipe? recipe, IBinaryPointInfo pointInfo)
	{
		if (recipe?.点位数据源.TryGetValue(pointInfo.Name, out var source) != true ||
		    TryParsePlcSource(source, out var offset) == false ||
		    offset == pointInfo.Offset)
		{
			return pointInfo;
		}

		return new BinaryPointInfo()
		{
			Offset = offset,
			Name = pointInfo.Name,
			Type = pointInfo.Type,
			ByteLength = pointInfo.ByteLength,
			ByteFormat = pointInfo.ByteFormat,
			Description = pointInfo.Description,
			Id = pointInfo.Id,
			RawType = pointInfo.RawType,
			Source = offset.ToString(CultureInfo.InvariantCulture),
			ToRaw = pointInfo.ToRaw,
			RawTo = pointInfo.RawTo,
			ReaderData = pointInfo.ReaderData,
			WriterData = pointInfo.WriterData,
			Tags = pointInfo.Tags,
			CustomData = pointInfo.CustomData,
		};
	}
}
