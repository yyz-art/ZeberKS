using System.Text.Json;
using Avalonia.Platform.Storage;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZC.Shared.DefaultJson;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Services;

namespace ZitApp.UI.Recipe;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class RecipeVM : UiVM<RecipeView>
{
	public RecipeVM()
	{
		FilteredPropertyInstances = new ObservableList<IPropertyInstance>(PropertyInstances);
		EditRecipe = new ProductRecipe();
		PropertyCategories = TypeMetaInfo<ProductRecipe>.Cache.Properties
			.Select(t => t.GetAttribute<ValueInfoAttribute>()?.Category)
			.Where(t => t != null).Distinct().ToList()!;
		PropertyCategories.Insert(0, "全部");
		SelectedPropertyCategory = PropertyCategories.First();
	}

	public required CoreService CoreService { get; init; }
	public required RecipeService RecipeService { get; init; }
	public required ConnectionManageService ConnectionManageService { get; init; }

	public List<IPropertyInstance> PropertyInstances { get; } =
		TypeMetaInfo<ProductRecipe>.Cache.Properties.Where(t => t.Attributes
				.Any(attr => attr is ValueInfoAttribute))
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public ObservableList<string> RecipeNames { get; } = ["Test1", "Test2"];
	public partial string? SelectedRecipeName { get; set; }
	public partial string SelectedPropertyCategory { get; set; }
	public List<string> PropertyCategories { get; set; }
	public ObservableList<IPropertyInstance> FilteredPropertyInstances { get; }
	public ProductRecipe TempRecipe { get; } = new();
	public partial ProductRecipe? EditRecipe { get; set; }
	public partial bool IsSelectedAll { get; set; }
	public partial string CreateNewRecipeInputName { get; set; }
	public partial int CreateNewRecipeInputId { get; set; }
	public partial bool CreateNewRecipeIsCopyCurrentRecipeValue { get; set; }

	public async Task @MoveSelectedPoints()
	{
		ShowToast("start move selected points...");
		foreach (var propertyInstance in FilteredPropertyInstances)
		{
			if (propertyInstance.Flag is false)
				continue;
			propertyInstance.Value = propertyInstance.TempValue1;
		}
		ShowToast("move selected points completed!", UiMessageType.Success);
	}

	public async Task @RequestDevicePrepareRecipe()
	{
		ShowToast("start request device prepare recipe...");
		try
		{
			var reqResult = await CoreService.RequestPlcWriteRecipeAsync();
			if (reqResult.IsError())
			{
				ShowNotification($"request device prepare recipe failed! {reqResult.Message}", UiMessageType.Error);
				return;
			}
		}
		finally
		{
			ShowToast("end request device prepare recipe");
		}
	}

	public async Task @DistributeSelectedRecipe()
	{
		if (EditRecipe is null)
		{
			ShowToast("please select a recipe!", UiMessageType.Error);
			return;
		}

		var option = await ShowMessageBox($"Distribute recipe '{EditRecipe.Name}'?", "Distribute recipe",
			MessageBoxIcon.Question, MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("cancel");
			return;
		}

		ShowToast("start distribute selected recipe...");
		var distributeRecipeResult = await CoreService.DistributeRecipeAsync(EditRecipe);
		if (distributeRecipeResult.IsError())
		{
			ShowNotification($"distribute selected recipe failed! {distributeRecipeResult.Message}", UiMessageType.Error);
			return;
		}

		ShowToast("distribute selected recipe completed!", UiMessageType.Success);
	}

	public async Task @ReloadSelectedRecipe()
	{
		if (EditRecipe is null)
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var option = await ShowMessageBox("Reload current recipe?", "Recipe reload", MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("Cancel");
			return;
		}

		RecipeService.RemoveLocalRecipeCache(EditRecipe.Name);
		EditRecipe = RecipeService.GetRecipe(EditRecipe.Name, true);
		ShowToast("Recipe reload success!", UiMessageType.Success);
	}


	partial void OnSelectedRecipeNameChanged(string? oldValue, string? newValue)
	{
		if (string.IsNullOrWhiteSpace(newValue))
		{
			EditRecipe = TempRecipe;
			return;
		}

		var getRecipeResult = RecipeService.GetRecipe(newValue, true);
		if (getRecipeResult.IsError())
		{
			ShowNotification($"Recipe switch failed! {getRecipeResult}", UiMessageType.Error);
			return;
		}

		EditRecipe = getRecipeResult.Value;
		ShowToast("Recipe switch succeeded!", UiMessageType.Success);
	}

	public async Task @SaveSelectedRecipe()
	{
		if (EditRecipe is null || EditRecipe.Name == "")
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var option = await ShowMessageBox("Save selected recipe?", "Save recipe", MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("cancel");
			return;
		}

		RecipeService.UpdateRecipe(EditRecipe).Unwarp("save recipe error!");
		ShowToast("recipe saved!", UiMessageType.Success);
	}

	public async Task @ExportSelectedRecipe()
	{
		if (EditRecipe is null || EditRecipe.Name == "")
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var file = await this.GetTopLevel()!.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions()
		{
			Title = $"Save recipe '{EditRecipe.Name}'",
			DefaultExtension = ".json",
			SuggestedFileType = new FilePickerFileType(".json"),
			SuggestedFileName = $"{EditRecipe.Name}-RID{EditRecipe.Id}.json"
		});
		if (file is null)
		{
			ShowToast("Cancel");
			return;
		}

		try
		{
			await using var fs = File.OpenWrite(file.Path.LocalPath);
			await JsonSerializer.SerializeAsync(fs, EditRecipe, Global.Json.DefaultIndentOptions);
			ShowToast("Saved successfully!", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			ShowNotification($"Save failed! {ex}", UiMessageType.Success);
		}
	}

	public async Task @DeleteSelectedRecipe()
	{
		if (EditRecipe is null)
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var option = await ShowMessageBox($"Delete recipe '{EditRecipe.Name}' ?", "Delete recipe",
			MessageBoxIcon.Question, MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("Cannot delete recipe!");
			return;
		}

		RecipeService.DeleteRecipe(EditRecipe.Name).Unwarp("Recipe delete failed!");
		ShowToast("Recipe deleted!", UiMessageType.Success);
		LoadRecipeNames();
	}

	public void @CreateNewRecipeCancel()
	{
		ShowToast("Cancel new recipe!");
		View.CreateNewRecipeDialog.Close();
	}

	public void @CreateNewRecipeConfirm()
	{
		var recipeName = CreateNewRecipeInputName;
		if (RecipeService.ContainsRecipeName(recipeName).Unwarp("check new recipe error!"))
		{
			ShowNotification("Recipe name is already exists!", UiMessageType.Error);
			return;
		}

		var recipe = new ProductRecipe();
		if (EditRecipe is not null && CreateNewRecipeIsCopyCurrentRecipeValue)
			ProductRecipe.CopyPropertyValues(EditRecipe, recipe);
		recipe.Name = recipeName;
		var result = RecipeService.CreateRecipe(recipe);
		if (result.IsError())
		{
			ShowNotification($"recipe create error! \n{result}", UiMessageType.Error);
			return;
		}

		ShowToast("recipe created!", UiMessageType.Success);
		View.CreateNewRecipeDialog.Close();
		LoadRecipeNames();
	}

	public Task @CreateNewRecipe()
	{
		return ShowModalDialog(View.CreateNewRecipeDialog);
	}


	private void LoadRecipeNames()
	{
		var recipeNamesResult = RecipeService.GetRecipeNames();
		if (recipeNamesResult.IsOk())
		{
			RecipeNames.Clear();
			RecipeNames.Add("");
			RecipeNames.AddRange(recipeNamesResult.Value!);
		}
	}

	public override Task Initialize(object? ctx, object? args)
	{
		if (Design.IsDesignMode) return Task.CompletedTask;
		LoadRecipeNames();

		return base.Initialize(ctx, args);
	}

	partial void OnSelectedPropertyCategoryChanged(string value)
	{
		FilteredPropertyInstances.Clear();
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Flag = false;
			if (propertyInstance.ValueInfo?.Category == value || value == "全部")
				FilteredPropertyInstances.Add(propertyInstance);
		}
	}

	partial void OnIsSelectedAllChanged(bool value)
	{
		foreach (var propertyInstance in FilteredPropertyInstances)
			propertyInstance.Flag = value;
	}


	partial void OnEditRecipeChanged(ProductRecipe? oldValue, ProductRecipe? newValue)
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Reset(newValue);
			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;
		}

		IsSelectedAll = false;
	}


	public async Task @ReadSelectedPoints()
	{
		ShowToast("Start read selected points");
		foreach (var propertyInstance in FilteredPropertyInstances)
		{
			if (propertyInstance.Flag == false)
				continue;

			await ReadPoint(propertyInstance);
			if (ReadPointCommand.CustomData != null)
				break;
		}

		ShowToast("end read selected points");
	}

	public async Task @WriteSelectedPoints()
	{
		ShowToast("Start write selected points");
		foreach (var propertyInstance in FilteredPropertyInstances)
		{
			if (propertyInstance.Flag == false)
				continue;

			await WritePoint(propertyInstance);
			if (WritePointCommand.CustomData != null)
				break;
		}

		ShowToast("End write selected points");
	}

	public async Task @ReadPoint(IPropertyInstance property)
	{
		var binaryStruct = property.Instance as IBinaryStruct;
		if (binaryStruct is null)
		{
			var errorMessage = "Read Point Failed! Property Instance is not BinaryStruct Member!";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var binaryStructInfo = binaryStruct.GetStructInfo();
		var pointInfo = binaryStructInfo.Members[property.Define.Name] as IBinaryPointInfo;
		if (pointInfo is null)
		{
			var errorMessage = "Read Point Failed! Property is not BinaryPoint";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var reader = ConnectionManageService.GetConnection(pointInfo.ReaderData?.ToString() ?? "") as IBinaryReader;
		if (reader is null)
		{
			var errorMessage = $"Read Point Failed! Connection '{pointInfo.ReaderData}' is not found!";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var readPointResult = await TempRecipe.ReadPointAsync(pointInfo, reader);
		if (readPointResult.IsError())
		{
			var errorMessage = $"Read Point Failed! src:'{pointInfo.Source}' {readPointResult}";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var value = property.Define.Getter!.Invoke(TempRecipe);
		property.TempValue1 = value;
		if (ReadSelectedPointsCommand.IsRunning == false)
			ShowToast("Read Success!", UiMessageType.Success);
		ReadPointCommand.CustomData = null;
	}

	public async Task @WritePoint(IPropertyInstance property)
	{
		var binaryStruct = property.Instance as IBinaryStruct;
		if (binaryStruct is null)
		{
			var errorMessage = "Write Point Failed! Property Instance is not BinaryStruct Member!";
			ShowNotification(errorMessage, UiMessageType.Error);
			WritePointCommand.CustomData = errorMessage;
			return;
		}

		var binaryStructInfo = binaryStruct.GetStructInfo();
		var pointInfo = binaryStructInfo.Members[property.Define.Name] as IBinaryPointInfo;
		if (pointInfo is null)
		{
			var errorMessage = "Write Point Failed! Property is not BinaryPoint";
			ShowNotification(errorMessage, UiMessageType.Error);
			WritePointCommand.CustomData = errorMessage;
			return;
		}

		var writer = ConnectionManageService.GetConnection(pointInfo.WriterData?.ToString() ?? "") as IBinaryWriter;
		if (writer is null)
		{
			var errorMessage = $"Write Point Failed! Connection '{pointInfo.WriterData}' is not found!";
			ShowNotification(errorMessage, UiMessageType.Error);
			WritePointCommand.CustomData = errorMessage;
			return;
		}

		var writePointResult = await Task.Run(() => binaryStruct.WritePointAsync(pointInfo, writer));
		if (writePointResult.IsError())
		{
			var errorMessage = $"Write Point Failed! {writePointResult}";
			WritePointCommand.CustomData = errorMessage;
			ShowNotification(errorMessage, UiMessageType.Error);
			return;
		}

		if (WriteSelectedPointsCommand.IsRunning == false)
			ShowToast("Write Success!", UiMessageType.Success);
		WritePointCommand.CustomData = null;
	}
}