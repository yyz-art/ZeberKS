using ZC.Mvvm;

namespace ZitApp.Models;

public partial class ProductRecipeBase : ObservableObject
{
	public partial int Id { get; set; }
	public partial string Name { get; set; } = "";
	public partial string Description { get; set; } = "";
	public partial DateTime UpdateTime { get; set; }
	public partial DateTime CreateTime { get; set; }
	public partial bool IsFullRecipe { get; set; }
	public partial string? RefFullRecipeName { get; set; }
	public partial List<MaterialConfig> MaterialConfigs { get; set; } = [];
}