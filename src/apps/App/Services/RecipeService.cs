using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.CFG;
using ZC.KvStorage;
using ZC.LOG;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
public class RecipeService
{
	public const string RecipesKvStorageName = "ProductRecipes";
	private List<ProductRecipe> Recipes { get; } = [];
	public required IKeyValueStorage KvStorage { get; init; }
	[Inject(Name = "RECIPE-SERVICE")] public required ILogger Logger { get; init; }
	public IEnumerable<ProductRecipe> GetRecipes() => Recipes;

	public Result LoadRecipes()
	{
		var getRecipeNamesResult = KvStorage.GetItemNames(RecipesKvStorageName);
		if (getRecipeNamesResult.IsError())
			return getRecipeNamesResult;
		Recipes.Clear();
		foreach (var recipeName in getRecipeNamesResult.Value!)
		{
			var getRecipeResult = KvStorage.GetValue<ProductRecipe>(RecipesKvStorageName, recipeName);
			if (getRecipeResult.IsError())
				return getRecipeResult;
			Recipes.Add(getRecipeResult.Value!);
		}

		return Result.OK;
	}

	public Result<ProductRecipe> GetRecipe(string name, bool newInstance = false)
	{
		ProductRecipe? recipe = null;
		if (newInstance)
		{
			var ret = KvStorage.GetValue<ProductRecipe>(RecipesKvStorageName, name);
			if (ret.IsOk())
				recipe = ret;
		}
		else
		{
			foreach (var item in Recipes)
			{
				if (item.Name == name)
				{
					recipe = item;
					break;
				}
			}
		}
		
		if (recipe is null)
			return Result.Err<ProductRecipe>("recipe not found!");
		if (recipe.IsFullRecipe == false)
			recipe.RefFullRecipe = GetRecipe(recipe.RefFullRecipeName!).Value;
		return Result.Ok(recipe);
	}

	public Result<ProductRecipe> GetRecipeByModelName(string name)
	{
		foreach (var recipe in Recipes)
		{
			if (recipe.Name == name)
				return Result.Ok(recipe);
			// if(recipe.ModelName == name)
			// 	return Result.Ok(recipe);
		}

		return Result.Err<ProductRecipe>("Recipe not found!");
	}

	public void RemoveLocalRecipeCache(string name) => Recipes.RemoveAll(t => t.Name == name);

	public Result UpdateRecipe(ProductRecipe recipe)
	{
		TryFixRecipe(recipe);
		return KvStorage.SetValue(RecipesKvStorageName, recipe.Name, recipe);
	}

	public void TryFixRecipe(ProductRecipe recipe)
	{
		if (recipe.IsFullRecipe)
			recipe.Points ??= new PointRecipeStruct();
		if (ReferenceEquals(recipe.MaterialConfigs, null))
		{
			var 产品上料信息 = recipe.MaterialConfigs ??= [];
			if (产品上料信息.Count >= 6) return;
			for (var i = 产品上料信息.Count; i <= 5; i++)
			{
				产品上料信息.Add(new MaterialConfig { Id = i + 1, PositionName = $"上料位置{i + 1}" });
			}

			recipe.MaterialConfigs = 产品上料信息;
		}

		foreach (var recipeMaterialConfig in recipe.MaterialConfigs)
		{
			for (var i = 0; i < recipeMaterialConfig.MaterialCodes.Length; i++)
			{
				var item = recipeMaterialConfig.MaterialCodes[i];
				recipeMaterialConfig.MaterialCodes[i] = item.Trim();
			}

			recipeMaterialConfig.PositionName = recipeMaterialConfig.PositionName.Trim();
		}
	}

	public Result CreateRecipe(ProductRecipe recipe)
	{
		if (recipe.Id == 0)
			recipe.Id = Recipes.Count > 0 ? Recipes.Max(t => t.Id) + 1 : 1;
		if (Recipes.Any(t => t.Id == recipe.Id))
			return Result.Err("Recipe with this id already exists.");
		TryFixRecipe(recipe);
		var setValueResult = KvStorage.SetValue(RecipesKvStorageName, recipe.Name, recipe);
		if (setValueResult.IsError())
			return setValueResult;
		Recipes.Add(recipe);
		return Result.OK;
	}

	public Result DeleteRecipe(string name)
	{
		var ret = KvStorage.Remove(RecipesKvStorageName, name);
		if (ret.IsOk())
		{
			Recipes.RemoveAll(t => t.Name == name);
		}

		return ret;
	}

	public Result<IEnumerable<string>> GetRecipeNames() => Result.Ok(Recipes.Select(t => t.Name));

	public ValueTask<Result<IEnumerable<string>>> GetRecipeNamesAsync() =>
		KvStorage.GetItemNamesAsync(RecipesKvStorageName);

	public Result<bool> ContainsRecipeName(string name)
	{
		foreach (var productRecipe in Recipes)
		{
			if (productRecipe.Name == name)
				return true;
		}

		return false;
	}

	public bool ContainsRecipeId(int id)
	{
		foreach (var productRecipe in Recipes)
		{
			if (productRecipe.Id == id)
				return true;
		}

		return false;
	}
}