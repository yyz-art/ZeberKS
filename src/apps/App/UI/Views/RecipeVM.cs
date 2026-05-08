using System.Text.Json;
using Avalonia.Platform.Storage;
using ClosedXML.Excel;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.DP.Memory;
using ZC.DP.Text;
using ZC.DP.Text.CSV;
using ZC.MetaInfo;
using ZC.Mvvm;
using ZC.Shared.DefaultJson;
using ZC.UI.ControlLibs;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI.Recipe;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class RecipeVM : UiVM<RecipeView>
{
	public RecipeVM()
	{
		FilteredPropertyInstances = new ObservableList<IPropertyInstance>(PropertyInstances);
		EditRecipe = new ProductRecipe();
		PropertyCategories = TypeMetaInfo<PointRecipeStruct>.Cache.Properties
			.Select(t => t.GetAttribute<ValueInfoAttribute>()?.Category)
			.Where(t => t != null).Distinct().ToList()!;
		PropertyCategories.Insert(0, "全部");
		if (Design.IsDesignMode)
		{
			EditRecipe.MaterialConfigs = Enumerable.Range(0, 5)
				.Select(t => new MaterialConfig()
				{
					Id = t,
					PositionName = $"测试上料{t}",
					MaterialCodes = ["A", "B", "C", "D"]
				}).ToList();
		}

		SelectedPropertyCategory = PropertyCategories.First();
	}

	public partial string RecipeNameInput { get; set; }
	public required CoreService CoreService { get; init; }
	public required RecipeService RecipeService { get; init; }
	public required AppConfig AppConfig { get; init; }
	public required ConnectionManageService ConnectionManageService { get; init; }

	public List<IPropertyInstance> PropertyInstances { get; } =
		TypeMetaInfo<PointRecipeStruct>.Cache.Properties.Where(t => t.Attributes
				.Any(attr => attr is ValueInfoAttribute))
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public ObservableList<string> RecipeNames { get; } = ["Test1", "Test2"];
	public partial string? SelectedRecipeName { get; set; }
	public partial string SelectedPropertyCategory { get; set; }
	public List<string> PropertyCategories { get; set; }
	public ObservableList<IPropertyInstance> FilteredPropertyInstances { get; }
	public ProductRecipe TempRecipe { get; } = new() { Points = new PointRecipeStruct(), IsFullRecipe = true };
	public partial ProductRecipe? EditRecipe { get; set; }
	public partial bool IsSelectedAll { get; set; }
	public partial string CreateNewRecipeInputName { get; set; }
	public partial int CreateNewRecipeInputId { get; set; }
	public partial bool CreateNewRecipeIsCopyCurrentRecipeValue { get; set; }
	public partial string RecipeNameFilterInput { get; set; } = "";
	public partial string[] RecipeTypeOptions { get; set; } = ["物料配方", "点位配方"];
	public partial string SelectedRecipeType { get; set; } = "";
	public partial ObservableList<string> PointRecipeNames { get; set; } = [];
	public partial ObservableList<string> ImportMaterialMapTableSheetNames { get; set; } = [];
	public partial string SelectedImportMaterialMapTableSheetName { get; set; }

	partial void OnSelectedRecipeTypeChanged(string oldValue, string newValue)
	{
		LoadRecipeNames();
	}


	public async Task @ChangeRecipeName(string newName)
	{
		if (EditRecipe is null)
		{
			ShowToast("please select a recipe!", UiMessageType.Error);
			return;
		}

		if (EditRecipe.Name == newName)
		{
			ShowToast("new name no changed!");
			return;
		}

		if (RecipeNames.Contains(newName))
		{
			await ShowMessageBoxOverlay("recipe name is exist!", "recipe name change", MessageBoxIcon.Error);
			return;
		}

		var oldName = EditRecipe.Name;
		EditRecipe.Name = newName;
		RecipeService.UpdateRecipe(EditRecipe).Unwarp("save recipe error!");
		RecipeService.DeleteRecipe(oldName);
		LoadRecipeNames();
		SelectedRecipeName = RecipeNames.FirstOrDefault(t => t == newName);
		ShowToast("change recipe name success!", UiMessageType.Success);
	}

	public async Task @MoveSelectedPoints()
	{
		var option = await ShowMessageBoxOverlay("confirm move selected read value to save value?",
			"move selected point value",
			MessageBoxIcon.Question, MessageBoxButton.OKCancel);
		if (option is not MessageBoxResult.OK)
		{
			ShowToast("cancel");
			return;
		}

		foreach (var propertyInstance in FilteredPropertyInstances)
		{
			if (propertyInstance.Flag is false)
				continue;
			var instance = propertyInstance.Instance;

			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;
			propertyInstance.Value = propertyInstance.TempValue1;
			propertyInstance.Reset(null);
			propertyInstance.Reset(instance);
		}

		await ShowMessageBoxOverlay("move selected points completed",
			"move selected point value",
			MessageBoxIcon.Success);
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

			await ShowMessageBoxOverlay("request device prepare recipe success!", "request device prepare recipe",
				MessageBoxIcon.Success);
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
		EditRecipe = RecipeService.GetRecipe(EditRecipe.Name);
		ShowToast("Recipe reload success!", UiMessageType.Success);
	}


	async partial void OnSelectedRecipeNameChanged(string? oldValue, string? newValue)
	{
		RecipeNameInput = "";
		if (string.IsNullOrWhiteSpace(newValue))
		{
			EditRecipe = TempRecipe;
			return;
		}

		var getRecipeResult = RecipeService.GetRecipe(newValue);
		if (getRecipeResult.IsError())
		{
			await ShowMessageBoxOverlay($"Recipe switch failed! {getRecipeResult.Message}", "recipe switch",
				MessageBoxIcon.Error);
			SelectedRecipeName = RecipeNames.First();
			return;
		}

		EditRecipe = getRecipeResult.Value;
		RecipeNameInput = EditRecipe?.Name!;
		ShowToast("Recipe switch succeeded!", UiMessageType.Success);
	}

	public async Task @SaveSelectedRecipe()
	{
		var editRecipe = EditRecipe;
		if (editRecipe is null || editRecipe.Name == "" || editRecipe == TempRecipe)
		{
			await ShowMessageBoxOverlay("please select a recipe to save!", "save recipe", MessageBoxIcon.Error);
			return;
		}

		var option = await ShowMessageBox("Save selected recipe?", "Save recipe", MessageBoxIcon.Question,
			MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("cancel");
			return;
		}

		var errIds = editRecipe.MaterialConfigs.GroupBy(t => t.Id)
			.Select(t => (t.Count(t => t.IsUsed), t.Key))
			.Where(t => t.Item1 > 1).Select(t => t.Key).ToArray();
		if (errIds.Length > 0)
		{
			await ShowMessageBoxOverlay($"please check material configs, this ids{ArrayUtils.ToString(errIds)} is error ",
				"save recipe", MessageBoxIcon.Error);
			return;
		}

		RecipeService.UpdateRecipe(editRecipe).Unwarp("save recipe error!");
		LoadRecipeNames();
		await ShowMessageBoxOverlay("recipe save success!", "save recipe", MessageBoxIcon.Success);
		SelectedRecipeName = RecipeNames.FirstOrDefault(t => t == editRecipe.Name);
	}

	public async Task @ImportRecipe()
	{
		if (EditRecipe is null || EditRecipe.Name == "")
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var files = await this.GetTopLevel()!.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
		{
			AllowMultiple = false,
			FileTypeFilter = [new FilePickerFileType("json")]
		});
		if (files.Count <= 0)
		{
			ShowToast("cancel");
			return;
		}

		await using var fs = await files[0].OpenReadAsync();
		var recipe = JsonSerializer.Deserialize<ProductRecipe>(fs);
		if (recipe is null)
		{
			await ShowMessageBoxOverlay("recipe is null", "recipe import", MessageBoxIcon.Error);
			return;
		}

		recipe.Name += $"_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}";
		recipe.Id = 0;
		RecipeService.CreateRecipe(recipe);
		LoadRecipeNames();
		SelectedRecipeName = recipe.Name;
		ShowToast("recipe import success!", UiMessageType.Success);
	}

	public async Task @ImportMaterialMapTable()
	{
		if (EditRecipe is null)
		{
			ShowToast("please select a recipe!", UiMessageType.Error);
			return;
		}
		var files = await this.GetTopLevel()!.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
		{
			SuggestedFileType = new FilePickerFileType("xlsx"),
			Title = "select material map table",
		});
		if (files.Count <= 0)
		{
			ShowToast("cancel");
			return;
		}

		using var workbook = new XLWorkbook(files[0].Path.LocalPath);
		ImportMaterialMapTableSheetNames.Clear();
		ImportMaterialMapTableSheetNames.AddRange(workbook.Worksheets.Select(t=>t.Name));
		SelectedImportMaterialMapTableSheetName = "";
		await ShowModalDialog(View.ImportMaterialMapTableSheetSelectDialog);
		if (string.IsNullOrEmpty(SelectedImportMaterialMapTableSheetName))
		{
			await ShowMessageBoxOverlay("select sheet is null, cancel", "import material map table", MessageBoxIcon.Error );
			return;
		}
		
		var worksheet = workbook.Worksheet(SelectedImportMaterialMapTableSheetName);
		var rows = worksheet.RangeUsed()!.RowsUsed().Skip(1); // 跳过表头
		var list = new List<MaterialConfig>();
		foreach (var row in rows)
		{
			var material = new MaterialConfig();
			material.Id = row.Cell(1).GetValue<int>();
			material.IsUsed = row.Cell(2).GetValue<bool>();
			material.PositionCode = row.Cell(3).GetValue<string>();
			material.PositionName = row.Cell(4).GetValue<string>();
			material.DefaultReplaceCount = row.Cell(5).GetValue<int>();
			material.AlarmRemainCount = row.Cell(6).GetValue<int>();
			material.MaterialCodes[0] = row.Cell(7).GetValue<string>();
			material.MaterialCodes[1] = row.Cell(8).GetValue<string>();
			material.MaterialCodes[2] = row.Cell(9).GetValue<string>();
			material.MaterialCodes[3] = row.Cell(10).GetValue<string>();
			material.Description = row.Cell(11).GetValue<string>();
			list.Add(material);
		}
		EditRecipe.MaterialConfigs = list;
		ShowToast("import material map table success!", UiMessageType.Success);
		// await using var fs = await files[0].OpenReadAsync();
		// using var reader = new StreamReader(fs);
		// var headerLine = await reader.ReadLineAsync();
		// if (headerLine?.StartsWith(
		// 	    "Id,IsUsed,PositionCode,PositionName,DefaultReplaceCount,AlarmRemainCount,MaterialCode1,MaterialCode2,MaterialCode3,MaterialCode4,Description") ==
		//     false)
		// {
		// 	await ShowMessageBoxOverlay("material map table header line format error!", "import material map table",
		// 		MessageBoxIcon.Error);
		// 	return;
		// }
		//
		
		// string? line;
		// while (null != (line =await reader.ReadLineAsync()))
		// {
		// 	list.Add(Parse(line));
		// }
		//
		// EditRecipe.MaterialConfigs = list;
		//
		//
		//
		// static MaterialConfig Parse(string line)
		// {
		// 	var config = new MaterialConfig();
		// 	var enumerator = new CsvValueSpanEnumerator(line);
		// 	var i = 0;
		// 	while (enumerator.ReadNext(out var value))
		// 	{
		// 		if (i == 0) config.Id = int.Parse(value);
		// 		if (i == 1) config.IsUsed = bool.Parse(value);
		// 		if (i == 2) config.PositionCode = value.ToString();
		// 		if (i == 3) config.PositionName = value.ToString();
		// 		if (i == 4) config.DefaultReplaceCount = int.Parse(value);
		// 		if (i == 5) config.AlarmRemainCount = int.Parse(value);
		// 		if (i == 6) config.MaterialCodes[0] = value.ToString();
		// 		if (i == 7) config.MaterialCodes[1] = value.ToString();
		// 		if (i == 8) config.MaterialCodes[2] = value.ToString();
		// 		if (i == 9) config.MaterialCodes[3] = value.ToString();
		// 		if (i == 10) config.Description = value.ToString();
		// 		i++;
		// 	}
		// 	return config;
		// }
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
			PointRecipeStruct.CopyPropertyValues(EditRecipe.Points, recipe.Points);
		recipe.Name = recipeName;
		recipe.RecipeType = SelectedRecipeType;
		if (recipe.RecipeType == "点位配方")
		{
			recipe.Points = new PointRecipeStruct();
		}

		Debug.Assert(SelectedRecipeType != null);
		recipe.Id = 0;
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
		var names = RecipeService.GetRecipes().Where(t => t.RecipeType == SelectedRecipeType).Select(t => t.Name);
		RecipeNames.Clear();
		RecipeNames.Add("");
		RecipeNames.AddRange(names);

		PointRecipeNames.Clear();
		PointRecipeNames.AddRange(RecipeService.GetRecipes().Where(t => t.RecipeType == "点位配方").Select(t => t.Name));
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
			propertyInstance.Reset(newValue?.Points);
			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;
		}

		if (newValue is not null)
		{
			foreach (var materialConfig in newValue.MaterialConfigs)
			{
				materialConfig.PositionCode = materialConfig.Id switch
				{
					1 => AppConfig.MaterialPositionCode1,
					2 => AppConfig.MaterialPositionCode2,
					3 => AppConfig.MaterialPositionCode3,
					4 => AppConfig.MaterialPositionCode4,
					5 => AppConfig.MaterialPositionCode5,
					6 => AppConfig.MaterialPositionCode6,
					_ => "UNDEFINED"
				};
			}
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

	public async Task @ReadAllPoints()
	{
		foreach (var groupInfo in TempRecipe.Points!.GetStructInfo().Members.Values.OfType<IBinaryPointGroupInfo>())
		{
			var pointInfo = groupInfo.Points.FirstOrDefault();
			if (pointInfo is null) continue;
			var reader = ConnectionManageService.GetConnection(pointInfo.ReaderData?.ToString() ?? "") as IBinaryReader;
			if (reader is null)
			{
				var errorMessage = $"read all point failed! connection '{pointInfo.ReaderData}' is not found!";
				await ShowMessageBoxOverlay(errorMessage, "read all points", MessageBoxIcon.Error);
				return;
			}

			var readResult = await TempRecipe.Points.ReadPointGroupAsync(groupInfo, reader);
			if (readResult.IsError())
			{
				var errorMessage = $"read all point failed! {readResult.Message}";
				await ShowMessageBoxOverlay(errorMessage, "read all points", MessageBoxIcon.Error);
				return;
			}

			foreach (var point in groupInfo.Points)
			{
				var propInstance = PropertyInstances.FirstOrDefault(t => t.Define.Name == point.Name);
				if (propInstance is null)
					continue;
				propInstance.TempValue1 = propInstance.Define.Getter!.Invoke(TempRecipe);
			}
		}

		await ShowMessageBoxOverlay("read all points success!", "read all points", MessageBoxIcon.Success);
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

		var readPointResult = await TempRecipe.Points!.ReadPointAsync(pointInfo, reader);
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