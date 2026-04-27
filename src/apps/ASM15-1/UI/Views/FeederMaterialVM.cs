using ZC;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.FeederMaterial;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class FeederMaterialVM : UiVM<FeederMaterialView>
{
	private const int FeederCount = 6;

	public required RecipeService RecipeService { get; init; }

	public ObservableList<string> RecipeNames { get; } = [];
	public ObservableList<FeederMaterialItem> FeederItems { get; } = [];
	public partial string? SelectedRecipeName { get; set; }
	public partial int CurrentRecipeId { get; set; }
	public partial ProductRecipe? CurrentRecipe { get; set; }

	protected override async Task OnInitialize(object? ctx, object? args)
	{
		RefreshRecipeNames();
		await base.OnInitialize(ctx, args);
	}

	protected override Task OnViewAttachedToVisualTree(object sender, object? args)
	{
		RefreshRecipeNames();
		return base.OnViewAttachedToVisualTree(sender, args);
	}

	partial void OnSelectedRecipeNameChanged(string? value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			CurrentRecipe = null;
			CurrentRecipeId = 0;
			FeederItems.Clear();
			return;
		}

		var getResult = RecipeService.GetRecipe(value, true);
		if (getResult.IsError())
		{
			ShowNotification("读取飞达物料失败", getResult.Message, UiMessageType.Error);
			return;
		}

		var recipe = getResult.Value!;
		CurrentRecipe = recipe;
		CurrentRecipeId = recipe.Id;
		LoadFeederItems();
	}

	public Task @Apply()
	{
		if (CurrentRecipe is null)
		{
			ShowToast("请先选择配方", UiMessageType.Warning);
			return Task.CompletedTask;
		}

		ApplyToCurrentRecipe();
		ShowToast("飞达物料已应用", UiMessageType.Success);
		return Task.CompletedTask;
	}

	public async Task @Save()
	{
		if (CurrentRecipe is null)
		{
			ShowToast("请先选择配方", UiMessageType.Warning);
			return;
		}

		ApplyToCurrentRecipe();
		var updateResult = RecipeService.UpdateRecipe(CurrentRecipe);
		if (updateResult.IsError())
		{
			await ShowMessageBox($"保存飞达物料失败！{updateResult.Message}", "保存失败", MessageBoxIcon.Error);
			return;
		}

		ShowToast("飞达物料已保存", UiMessageType.Success);
	}

	public Task ApplyFeederItemAsync(FeederMaterialItem item)
	{
		if (CurrentRecipe is null)
		{
			ShowToast("请先选择配方", UiMessageType.Warning);
			return Task.CompletedTask;
		}

		ApplyToCurrentRecipe();
		ShowToast($"{item.FeederName}已应用", UiMessageType.Success);
		return Task.CompletedTask;
	}

	private void RefreshRecipeNames()
	{
		var recipes = RecipeService.GetRecipes().ToList();
		if (recipes.Count == 0)
		{
			var loadResult = RecipeService.LoadRecipes();
			if (loadResult.IsError())
			{
				ShowNotification("读取配方列表失败", loadResult.Message, UiMessageType.Error);
				return;
			}

			recipes = RecipeService.GetRecipes().ToList();
		}

		var selectedName = SelectedRecipeName;
		RecipeNames.Clear();
		foreach (var recipeName in recipes.Select(t => t.Name).Where(t => !string.IsNullOrWhiteSpace(t)).Distinct())
			RecipeNames.Add(recipeName);

		if (RecipeNames.Count == 0)
		{
			SelectedRecipeName = null;
			return;
		}

		SelectedRecipeName = selectedName is not null && RecipeNames.Contains(selectedName)
			? selectedName
			: RecipeNames[0];
	}

	private void LoadFeederItems()
	{
		if (CurrentRecipe is null)
			return;

		EnsureFeederRows(CurrentRecipe);
		FeederItems.Clear();
		for (var i = 0; i < FeederCount; i++)
		{
			var feederInfo = CurrentRecipe.产品上料信息[i];
			FeederItems.Add(new FeederMaterialItem
			{
				Index = i + 1,
				IsUsed = feederInfo.是否使用,
				FeederCode = feederInfo.上料位置识别码 ?? "",
				MaterialCode1 = feederInfo.上料码1 ?? "",
				MaterialCode2 = feederInfo.上料码2 ?? "",
				MaterialCode3 = feederInfo.上料码3 ?? "",
				MaterialCode4 = feederInfo.上料码4 ?? "",
				MaterialCode5 = feederInfo.上料码5 ?? "",
			});
		}
	}

	private void ApplyToCurrentRecipe()
	{
		if (CurrentRecipe is null)
			return;

		EnsureFeederRows(CurrentRecipe);
		foreach (var item in FeederItems)
		{
			var feederInfo = CurrentRecipe.产品上料信息[item.Index - 1];
			feederInfo.是否使用 = item.IsUsed;
			feederInfo.上料位置名 = item.FeederName;
			feederInfo.上料位置识别码 = item.FeederCode?.Trim() ?? "";
			feederInfo.上料码1 = item.MaterialCode1?.Trim();
			feederInfo.上料码2 = item.MaterialCode2?.Trim();
			feederInfo.上料码3 = item.MaterialCode3?.Trim();
			feederInfo.上料码4 = item.MaterialCode4?.Trim();
			feederInfo.上料码5 = item.MaterialCode5?.Trim();
		}
	}

	private static void EnsureFeederRows(ProductRecipe recipe)
	{
		recipe.产品上料信息 ??= [];
		for (var i = recipe.产品上料信息.Count; i < FeederCount; i++)
		{
			recipe.产品上料信息.Add(new 产品上料信息
			{
				是否使用 = true,
				上料位置名 = $"飞达{i + 1}",
				上料位置识别码 = "",
				上料码1 = "",
			});
		}

		for (var i = 0; i < FeederCount; i++)
		{
			var feederInfo = recipe.产品上料信息[i];
			if (string.IsNullOrWhiteSpace(feederInfo.上料位置名))
				feederInfo.上料位置名 = $"飞达{i + 1}";
			feederInfo.上料位置识别码 ??= "";
			feederInfo.上料码1 ??= "";
			feederInfo.上料码2 ??= "";
			feederInfo.上料码3 ??= "";
			feederInfo.上料码4 ??= "";
			feederInfo.上料码5 ??= "";
		}
	}
}

[ObservableObject(RequiredGenerate = true)]
public partial class FeederMaterialItem
{
	public int Index { get; init; }
	public string FeederName => $"飞达{Index}";
	public string FeederLabel => $"飞达{Index}码:";
	public partial bool IsUsed { get; set; } = true;
	public partial string FeederCode { get; set; } = "";
	public partial string MaterialCode1 { get; set; } = "";
	public partial string MaterialCode2 { get; set; } = "";
	public partial string MaterialCode3 { get; set; } = "";
	public partial string MaterialCode4 { get; set; } = "";
	public partial string MaterialCode5 { get; set; } = "";
}
