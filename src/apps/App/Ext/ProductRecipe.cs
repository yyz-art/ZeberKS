using System.Text.Json.Serialization;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Models;

namespace ZitApp;

public partial class ProductRecipe : ProductRecipeBase
{
	public partial PointRecipeStruct? Points { get; set; }

	public bool IsPointRecipe => RecipeType == "点位配方" || RecipeType == "PointRecipe";
	[JsonIgnore] public partial ProductRecipe? RefPointRecipe { get; set; }
}