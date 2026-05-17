using Avalonia.Platform.Storage;
using Avalonia.Threading;
using ClosedXML.Excel;
using ZC;
using ZC.DP.Memory;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.Dialogs;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class CreateMaterialRecipeVM : UiVM<CreateMaterialRecipeDialog>
{
	public partial ProductRecipe? EditRecipe { get; set; }
	public partial ObservableList<string> FullRecipeNames { get; set; } = [];
	public partial string? SelectedPointRecipeName { get; set; }
	public required RecipeService RecipeService { get; init; }
	public partial string InputRecipeName { get; set; } = "";


	public Task Show()
	{
		if (Dispatcher.UIThread.CheckAccess() == false)
		{
			return Dispatcher.UIThread.Invoke(Show);
		}
		View.Hide();
		EditRecipe = new ProductRecipe();
		SelectedPointRecipeName = null;
		FullRecipeNames.Clear();
		FullRecipeNames.AddRange(
			RecipeService.GetRecipes().Where(t => t.IsFullRecipe).Select(t => t.Name));
		
		var mainWindow = (Window)App.Current.IOC.Get<AppVM>().View!;
		return View.ShowDialog(mainWindow);
	}

	partial void OnSelectedPointRecipeNameChanged(string? value)
	{
		EditRecipe?.MaterialConfigs = RecipeService.GetRecipe(value ?? "",true).Value?.MaterialConfigs ?? [];
		EditRecipe?.RefFullRecipeName = value;
	}


	public async Task @Save()
	{
		var appVM = AvaloniaApplication.Current.AppVM;
		var editRecipe = EditRecipe!;
		editRecipe.Name = InputRecipeName;
		var option = await ShowMessageBox("save recipe?", "save recipe", MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			appVM.GetToastManager()!.Show("cancel");
			return;
		}
		if (RecipeService.GetRecipe(InputRecipeName).Value != null)
		{
			await MessageBox.ShowOverlay("recipe name exists!", "save recipe", MessageBoxIcon.Error, host: appVM.View);
			return;
		}

		var errIds = editRecipe.MaterialConfigs.GroupBy(t => t.Id)
			.Select(t => (t.Count(t => t.IsUsed), t.Key))
			.Where(t => t.Item1 > 1).Select(t => t.Key).ToArray();
		if (errIds.Length > 0)
		{
			await MessageBox.ShowOverlay($"please check material configs, this ids{ArrayUtils.ToString(errIds)} is error ",
				"save recipe", MessageBoxIcon.Error, host: appVM.View);
			return;
		}

		RecipeService.CreateRecipe(editRecipe).Unwarp("save recipe error!");
		await MessageBox.ShowOverlay("recipe save success!", "save recipe", MessageBoxIcon.Success, host: appVM.View);
		View.Hide();
	}

	public Task @Cancel()
	{
		View.Hide();
		return Task.CompletedTask;
	}
}