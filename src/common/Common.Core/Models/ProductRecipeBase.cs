using ZC.Mvvm;

namespace ZitApp.Models;

public partial class ProductRecipeBase : ObservableObject
{
	public partial int Id { get; set; }
	public partial string Name { get; set; } = "ProductRecipe";
	public partial string ModelName { get; set; } = "";

	// public Dictionary<string, string> 点位数据源 { get; set; } = [];

	#region 上料

	public partial List<MaterialConfig> MaterialConfigs { get; set; } = [];

	#endregion
}
