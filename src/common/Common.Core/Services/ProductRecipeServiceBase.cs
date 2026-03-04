using ZC;
using ZC.KvStorage;
using ZC.LOG;
using ZitApp.Models;

namespace ZitApp.Services;

public class RecipeService<T> where T : ProductRecipeBase
{
	public const string RecipesKvStorageName = "Recipes";
	private List<T> Recipes { get; } = [];
	public required IKeyValueStorage KvStorage { get; init; }
	[Inject(Name = "RECIPE-SERVICE")] public required ILogger Logger { get; init; }


	public Result LoadRecipes()
	{
		var getRecipeNamesResult = GetRecipeNames();
		if (getRecipeNamesResult.IsError())
			return getRecipeNamesResult;
		Recipes.Clear();
		foreach (var recipeName in getRecipeNamesResult.Value!)
		{
			var getRecipeResult = KvStorage.GetValue<T>(RecipesKvStorageName, recipeName);
			if (getRecipeResult.IsError())
				return getRecipeResult;
			Recipes.Add(getRecipeResult.Value!);
		}

		return Result.OK;
	}

	public Result<T> GetRecipe(string name, bool useLocalCache)
	{
		if (Recipes.Count == 0)
		{
			var loadRecipesResult = LoadRecipes();
			if (loadRecipesResult.IsError())
				return Result.Err<T>(loadRecipesResult);
		}

		if (useLocalCache)
		{
			foreach (var recipe in Recipes)
			{
				if (recipe.Name == name)
					return Result.Ok(recipe);
			}
		}

		var getResult = KvStorage.GetValue<T>(RecipesKvStorageName, name);
		if (getResult.IsOk() && useLocalCache)
		{
			Recipes.Add(getResult.Value!);
		}

		return getResult;
	}

	public void RemoveLocalRecipeCache(string name) => Recipes.RemoveAll(t => t.Name == name);

	public Result UpdateRecipe(T recipe)
	{
		return KvStorage.SetValue(RecipesKvStorageName, recipe.Name, recipe);
	}

	public Result CreateRecipe(T recipe)
	{
		if (recipe.Id == 0)
			recipe.Id = Recipes.Count > 0 ? Recipes.Max(t => t.Id) + 1 : 1;
		if (Recipes.Any(t => t.Id == recipe.Id))
			return Result.Err("Recipe with this id already exists.");
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

	public Result<IEnumerable<string>> GetRecipeNames() =>
		KvStorage.GetItemNames(RecipesKvStorageName);

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