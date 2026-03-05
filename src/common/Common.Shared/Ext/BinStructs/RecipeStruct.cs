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


}