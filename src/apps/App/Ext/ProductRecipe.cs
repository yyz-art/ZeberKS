using System.Text.Json.Serialization;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Models;

namespace ZitApp;

public partial class ProductRecipe : ProductRecipeBase
{
	public partial PointRecipeStruct? Points { get; set; }

	// public bool IsPointRecipe => RecipeType == "点位配方" || RecipeType == "PointRecipe";
	[JsonIgnore] public partial ProductRecipe? RefFullRecipe { get; set; }
	
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
}