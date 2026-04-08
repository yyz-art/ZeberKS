namespace ZitApp.Models;

public class ProductRecipeBase
{
	public int Id { get; set; }
	public string Name { get; set; } = "ProductRecipe";


	public string 机种型号 { get; set; } = "";

	#region 上料

	public List<产品上料信息> 产品上料信息 { get; set; } = [];

	#endregion
}