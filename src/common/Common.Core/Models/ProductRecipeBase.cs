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

	/// <summary>
	/// 同一 Id 可有多行互斥料号；仅返回 <see cref="MaterialConfig.IsUsed"/> 为 true 的行，无则 null（视为未启用）。
	/// </summary>
	public MaterialConfig? GetActiveMaterialConfig(int feederId) =>
		MaterialConfigs.FirstOrDefault(t => t.Id == feederId && t.IsUsed);

	public bool HasEnabledMaterialConfig(int feederId) =>
		MaterialConfigs.Any(t => t.Id == feederId && t.IsUsed);

	public IReadOnlyList<string> GetAllowedMaterialCodes(int feederId) =>
		GetActiveMaterialConfig(feederId)?.EnumerateAllowedMaterialCodes().ToArray() ?? [];

	public bool IsAllowedMaterialCode(int feederId, string? code) =>
		GetActiveMaterialConfig(feederId)?.AllowsMaterialCode(code) ?? false;
}