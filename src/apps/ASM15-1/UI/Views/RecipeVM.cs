using System.Text.Json;
using Avalonia.Platform.Storage;
using System.Globalization;
using System.IO.Compression;
using System.Text;
using System.Xml.Linq;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.DP;
using ZC.DP.Memory;
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
	private const string RecipeExportFolder = "data\\Recipe";
	private const string ExcelExtension = ".xlsx";
	private const string LastImportFolderFileName = ".last-import-folder.txt";
	private const string DefaultPointSourcesFileName = ".default-point-sources.json";
	private string? _lastRecipeImportFolder;
	private readonly Dictionary<string, string> _defaultPointSources = new(StringComparer.OrdinalIgnoreCase);

	public RecipeVM()
	{
		FilteredPropertyInstances = new ObservableList<IPropertyInstance>(PropertyInstances);
		EditRecipe = new ProductRecipe();
		PropertyCategories = TypeMetaInfo<ProductRecipe>.Cache.Properties
			.Select(t => t.GetAttribute<ValueInfoAttribute>()?.Category)
			.Where(t => t != null).Distinct().ToList()!;
		PropertyCategories.Insert(0, "全部");
		SetDefaultPointSources();
		LoadDefaultPointSources();
		EditRecipe.产品上料信息 = Enumerable.Range(0, 50)
			.Select(t => new 产品上料信息()
			{
				上料位置名 = $"测试上料{t}",
				上料位置识别码 = $"TEST_{DateTime.Now:yyyyMMddHHmmssfff}",
				上料码1 = Guid.NewGuid().ToString(),
				上料码2 = Guid.NewGuid().ToString(),
				上料码3 = Guid.NewGuid().ToString(),
			}).ToList();
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
			var reqResult = await CoreService.RequestDevicePrepareRecipeAsync();
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

		var plcAckResult = await CoreService.NotifyRecipeDistributedToPlcAsync();
		if (plcAckResult.IsError())
		{
			ShowNotification($"recipe distribute plc ack failed! {plcAckResult.Message}", UiMessageType.Error);
			return;
		}

		ShowToast("distribute selected recipe completed!", UiMessageType.Success);
	}

	public Task @ApplySelectedRecipe()
	{
		if (EditRecipe is null || string.IsNullOrWhiteSpace(EditRecipe.Name))
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return Task.CompletedTask;
		}

		CoreService.当前下发配方 = EditRecipe;
		CoreService.RecipeName = EditRecipe.Name;
		ShowToast($"当前配方已切换为 {EditRecipe.Name}", UiMessageType.Success);
		return Task.CompletedTask;
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

		try
		{
			var exportDir = GetRecipeExportDirectory();
			Directory.CreateDirectory(exportDir);
			var fileName = SanitizeFileName($"配方：{EditRecipe.Name}-配方id：{EditRecipe.Id}{ExcelExtension}");
			var filePath = Path.Combine(exportDir, fileName);
			ExportRecipeToExcel(EditRecipe, filePath);
			SetLastRecipeImportFolder(exportDir);
			ShowToast($"配方已导出: {filePath}", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			ShowNotification($"导出配方失败! {ex}", UiMessageType.Error);
		}
	}

	public async Task @ImportSelectedRecipe()
	{
		if (EditRecipe is null || EditRecipe.Name == "")
		{
			ShowToast("Please select a recipe!", UiMessageType.Error);
			return;
		}

		var storage = this.GetTopLevel()!.StorageProvider;
		var options = new FilePickerOpenOptions
		{
			AllowMultiple = false,
			FileTypeFilter = [CreateExcelFileType()],
			SuggestedFileType = CreateExcelFileType(),
		};

		var startFolder = await TryGetRecipeImportStartFolder(storage);
		if (startFolder is not null)
			options.SuggestedStartLocation = startFolder;

		var files = await storage.OpenFilePickerAsync(options);
		if (files.Count <= 0)
		{
			ShowToast("Cancel");
			return;
		}

		var filePath = files[0].Path.LocalPath;
		try
		{
			var importCount = ImportRecipeFromExcel(EditRecipe, filePath);
			SetLastRecipeImportFolder(Path.GetDirectoryName(filePath));
			RefreshPropertyInstances();
			ShowToast($"配方导入完成，共导入 {importCount} 个点位。", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			ShowNotification($"导入配方失败! {ex.Message}", UiMessageType.Error);
		}
	}

	public async Task @ImportAllRecipeSources()
	{
		var option = await ShowMessageBox("即将把 Excel 中的数据源地址应用到所有配方，保存值不会被修改。是否继续？",
			"批量导入地址", MessageBoxIcon.Question, MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("Cancel");
			return;
		}

		var storage = this.GetTopLevel()!.StorageProvider;
		var options = new FilePickerOpenOptions
		{
			AllowMultiple = false,
			FileTypeFilter = [CreateExcelFileType()],
			SuggestedFileType = CreateExcelFileType(),
		};

		var startFolder = await TryGetRecipeImportStartFolder(storage);
		if (startFolder is not null)
			options.SuggestedStartLocation = startFolder;

		var files = await storage.OpenFilePickerAsync(options);
		if (files.Count <= 0)
		{
			ShowToast("Cancel");
			return;
		}

		var filePath = files[0].Path.LocalPath;
		try
		{
			var pointSources = ReadRecipePointSourcesFromExcel(filePath);
			if (pointSources.Count <= 0)
			{
				ShowNotification("Excel 中没有可导入的数据源地址。", UiMessageType.Error);
				return;
			}

			var recipeNamesResult = RecipeService.GetRecipeNames();
			if (recipeNamesResult.IsError())
			{
				ShowNotification($"读取配方列表失败! {recipeNamesResult}", UiMessageType.Error);
				return;
			}

			var updateRecipeCount = 0;
			foreach (var recipeName in recipeNamesResult.Value!.Where(t => string.IsNullOrWhiteSpace(t) == false))
			{
				var recipeResult = RecipeService.GetRecipe(recipeName, true);
				if (recipeResult.IsError())
					throw new InvalidOperationException($"读取配方 {recipeName} 失败: {recipeResult.Message}");

				var recipe = recipeResult.Value!;
				foreach (var source in pointSources)
					recipe.点位数据源[source.Key] = source.Value;

				RecipeService.UpdateRecipe(recipe).Unwarp($"update recipe '{recipe.Name}' sources failed!");
				updateRecipeCount++;
			}

			SaveDefaultPointSources(pointSources);
			SetLastRecipeImportFolder(Path.GetDirectoryName(filePath));
			RefreshPropertyInstances();
			ShowToast($"批量导入地址完成，更新 {updateRecipeCount} 个配方、{pointSources.Count} 个点位。", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			ShowNotification($"批量导入地址失败! {ex.Message}", UiMessageType.Error);
		}
	}

	private static FilePickerFileType CreateExcelFileType() => new("Excel")
	{
		Patterns = ["*.xlsx"],
		MimeTypes = ["application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"],
	};

	private async Task<IStorageFolder?> TryGetRecipeImportStartFolder(IStorageProvider storage)
	{
		var startFolder = _lastRecipeImportFolder ?? ReadLastRecipeImportFolder();
		if (string.IsNullOrWhiteSpace(startFolder))
			startFolder = GetRecipeExportDirectory();

		if (Directory.Exists(startFolder) == false)
			Directory.CreateDirectory(startFolder);

		return await storage.TryGetFolderFromPathAsync(startFolder);
	}

	private static string? ReadLastRecipeImportFolder()
	{
		var filePath = Path.Combine(GetRecipeExportDirectory(), LastImportFolderFileName);
		return File.Exists(filePath) ? File.ReadAllText(filePath, Encoding.UTF8) : null;
	}

	private void LoadDefaultPointSources()
	{
		var filePath = Path.Combine(GetRecipeExportDirectory(), DefaultPointSourcesFileName);
		if (File.Exists(filePath) == false)
			return;

		try
		{
			var sources = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(filePath, Encoding.UTF8));
			if (sources is null)
				return;

			foreach (var source in sources)
			{
				if (string.IsNullOrWhiteSpace(source.Key) || string.IsNullOrWhiteSpace(source.Value))
					continue;

				_defaultPointSources[source.Key] = source.Value;
			}
		}
		catch
		{
			// Ignore damaged template files; generated point addresses remain available as fallback.
		}
	}

	private void SaveDefaultPointSources(Dictionary<string, string> pointSources)
	{
		Directory.CreateDirectory(GetRecipeExportDirectory());
		foreach (var source in pointSources)
			_defaultPointSources[source.Key] = source.Value;

		var json = JsonSerializer.Serialize(_defaultPointSources, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText(Path.Combine(GetRecipeExportDirectory(), DefaultPointSourcesFileName), json, Encoding.UTF8);
	}

	private void ApplyDefaultPointSources(ProductRecipe recipe)
	{
		foreach (var source in _defaultPointSources)
			recipe.点位数据源[source.Key] = source.Value;
	}

	private void SetLastRecipeImportFolder(string? folder)
	{
		if (string.IsNullOrWhiteSpace(folder))
			return;

		_lastRecipeImportFolder = folder;
		Directory.CreateDirectory(GetRecipeExportDirectory());
		File.WriteAllText(Path.Combine(GetRecipeExportDirectory(), LastImportFolderFileName), folder, Encoding.UTF8);
	}

	private static string GetRecipeExportDirectory() =>
		Path.Combine(Environment.CurrentDirectory, RecipeExportFolder);

	private static string SanitizeFileName(string fileName)
	{
		foreach (var invalidChar in Path.GetInvalidFileNameChars())
			fileName = fileName.Replace(invalidChar, '_');
		return fileName;
	}

	private void ExportRecipeToExcel(ProductRecipe recipe, string filePath)
	{
		var rows = new List<List<string>>
		{
			new() { "类别", "数据名称", "类型", "保存值", "数据源", "单位", "说明", "备注" },
		};

		foreach (var property in PropertyInstances)
		{
			if (property.Instance is not IBinaryStruct binaryStruct)
				continue;

			var pointInfo = GetPointInfo(binaryStruct, property);
			if (pointInfo is null)
				continue;

			rows.Add(new List<string>
			{
				property.ValueInfo?.Category ?? "",
				property.Define.Name,
				property.Define.PropertyType.Name,
				Convert.ToString(property.Value, CultureInfo.InvariantCulture) ?? "",
				GetPointSourceText(recipe, pointInfo),
				Convert.ToString(property.ValueInfo?.Unit, CultureInfo.InvariantCulture) ?? "",
				Convert.ToString(property.ValueInfo?.Description, CultureInfo.InvariantCulture) ?? "",
				Convert.ToString(property.ValueInfo?.Comment, CultureInfo.InvariantCulture) ?? "",
			});
		}

		WriteSimpleXlsx(filePath, rows);
	}

	private int ImportRecipeFromExcel(ProductRecipe recipe, string filePath)
	{
		if (Path.GetExtension(filePath).Equals(ExcelExtension, StringComparison.OrdinalIgnoreCase) == false)
			throw new InvalidOperationException("只能导入 .xlsx 格式的 Excel 文件。");

		var rows = ReadSimpleXlsx(filePath);
		if (rows.Count < 2)
			throw new InvalidOperationException("Excel 没有可导入的数据。");

		var headers = rows[0]
			.Select((name, index) => new { name, index })
			.ToDictionary(t => t.name.Trim(), t => t.index, StringComparer.OrdinalIgnoreCase);

		var categoryIndex = GetRequiredColumn(headers, "类别");
		var nameIndex = GetRequiredColumn(headers, "数据名称");
		var valueIndex = GetRequiredColumn(headers, "保存值");
		var sourceIndex = GetRequiredColumn(headers, "数据源");

		var properties = PropertyInstances.ToDictionary(GetImportKey, StringComparer.OrdinalIgnoreCase);
		var importCount = 0;

		for (var i = 1; i < rows.Count; i++)
		{
			var row = rows[i];
			var category = GetCell(row, categoryIndex);
			var propertyName = GetCell(row, nameIndex);
			if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(propertyName))
				continue;

			if (properties.TryGetValue(GetImportKey(category, propertyName), out var property) == false)
				continue;

			var saveValueText = GetCell(row, valueIndex);
			var targetType = property.Value?.GetType() ?? property.Define.Getter!.Invoke(recipe)?.GetType() ?? typeof(string);
			property.Value = ConvertCellValue(saveValueText, targetType);

			var sourceText = GetCell(row, sourceIndex);
			if (string.IsNullOrWhiteSpace(sourceText) == false)
			{
				if (ProductRecipe.TryParsePlcSource(sourceText, out var offset) == false)
					throw new InvalidOperationException($"点位 {propertyName} 的数据源不是有效 PLC 地址: {sourceText}");

				var normalizedSource = ProductRecipe.ToPlcSource(offset);
				recipe.点位数据源[propertyName] = normalizedSource;
				TrySetValueInfoSource(property, normalizedSource);
			}

			importCount++;
		}

		return importCount;
	}

	private Dictionary<string, string> ReadRecipePointSourcesFromExcel(string filePath)
	{
		if (Path.GetExtension(filePath).Equals(ExcelExtension, StringComparison.OrdinalIgnoreCase) == false)
			throw new InvalidOperationException("只能导入 .xlsx 格式的 Excel 文件。");

		var rows = ReadSimpleXlsx(filePath);
		if (rows.Count < 2)
			throw new InvalidOperationException("Excel 没有可导入的数据。");

		var headers = rows[0]
			.Select((name, index) => new { name, index })
			.ToDictionary(t => t.name.Trim(), t => t.index, StringComparer.OrdinalIgnoreCase);

		var categoryIndex = GetRequiredColumn(headers, "类别");
		var nameIndex = GetRequiredColumn(headers, "数据名称");
		var sourceIndex = GetRequiredColumn(headers, "数据源");
		var properties = PropertyInstances.ToDictionary(GetImportKey, StringComparer.OrdinalIgnoreCase);
		var pointSources = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		for (var i = 1; i < rows.Count; i++)
		{
			var row = rows[i];
			var category = GetCell(row, categoryIndex);
			var propertyName = GetCell(row, nameIndex);
			var sourceText = GetCell(row, sourceIndex);
			if (string.IsNullOrWhiteSpace(category) ||
			    string.IsNullOrWhiteSpace(propertyName) ||
			    string.IsNullOrWhiteSpace(sourceText))
				continue;

			if (properties.TryGetValue(GetImportKey(category, propertyName), out var property) == false)
				continue;

			if (ProductRecipe.TryParsePlcSource(sourceText, out var offset) == false)
				throw new InvalidOperationException($"点位 {propertyName} 的数据源不是有效 PLC 地址: {sourceText}");

			pointSources[property.Define.Name] = ProductRecipe.ToPlcSource(offset);
		}

		return pointSources;
	}

	private static string GetImportKey(IPropertyInstance property) =>
		GetImportKey(property.ValueInfo?.Category, property.Define.Name);

	private static string GetImportKey(string? category, string? propertyName) =>
		$"{category?.Trim()}|{propertyName?.Trim()}";

	private static int GetRequiredColumn(Dictionary<string, int> headers, string columnName)
	{
		if (headers.TryGetValue(columnName, out var index))
			return index;

		throw new InvalidOperationException($"Excel 缺少必要列: {columnName}");
	}

	private static string GetCell(List<string> row, int index) =>
		index >= 0 && index < row.Count ? row[index] : "";

	private static object? ConvertCellValue(string text, Type targetType)
	{
		if (targetType == typeof(string))
			return text;

		if (string.IsNullOrWhiteSpace(text))
			text = "0";

		var nullableType = Nullable.GetUnderlyingType(targetType);
		if (nullableType is not null)
			targetType = nullableType;

		if (targetType.IsEnum)
			return Enum.Parse(targetType, text, true);

		if (targetType == typeof(bool))
			return text is "1" || bool.Parse(text);

		return Convert.ChangeType(text, targetType, CultureInfo.InvariantCulture);
	}

	private string GetPointSourceText(ProductRecipe? recipe, IBinaryPointInfo pointInfo) =>
		ProductRecipe.GetPointSource(recipe, pointInfo);

	private static IBinaryPointInfo? GetPointInfo(IBinaryStruct binaryStruct, IPropertyInstance property)
	{
		var binaryStructInfo = binaryStruct.GetStructInfo();
		return binaryStructInfo.Members[property.Define.Name] as IBinaryPointInfo;
	}

	private static void TrySetValueInfoSource(IPropertyInstance property, string source)
	{
		var valueInfo = property.ValueInfo;
		if (valueInfo is null)
			return;

		var sourceProperty = valueInfo.GetType().GetProperty("Source");
		if (sourceProperty?.CanWrite == true)
			sourceProperty.SetValue(valueInfo, source);
	}

	private void RefreshPropertyInstances()
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Reset(EditRecipe);
			propertyInstance.CanWrite = true;
			propertyInstance.CanRead = true;

			if (EditRecipe?.点位数据源.TryGetValue(propertyInstance.Define.Name, out var source) == true)
				TrySetValueInfoSource(propertyInstance, source);
			else if (_defaultPointSources.TryGetValue(propertyInstance.Define.Name, out var defaultSource))
				TrySetValueInfoSource(propertyInstance, defaultSource);
		}

		var selectedCategory = SelectedPropertyCategory;
		if (string.IsNullOrWhiteSpace(selectedCategory) == false)
			OnSelectedPropertyCategoryChanged(selectedCategory);
		IsSelectedAll = false;
	}

	private void SetDefaultPointSources()
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			if (propertyInstance.Instance is not IBinaryStruct binaryStruct)
				continue;

			var pointInfo = GetPointInfo(binaryStruct, propertyInstance);
			if (pointInfo is not null)
				_defaultPointSources[propertyInstance.Define.Name] = ProductRecipe.GetPointSource(null, pointInfo);
		}
	}

	private static void WriteSimpleXlsx(string filePath, IReadOnlyList<List<string>> rows)
	{
		if (File.Exists(filePath))
			File.Delete(filePath);

		using var archive = ZipFile.Open(filePath, ZipArchiveMode.Create);
		AddZipText(archive, "[Content_Types].xml", """
			<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
			<Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
			  <Default Extension="rels" ContentType="application/vnd.openxmlformats-package.relationships+xml"/>
			  <Default Extension="xml" ContentType="application/xml"/>
			  <Override PartName="/xl/workbook.xml" ContentType="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml"/>
			  <Override PartName="/xl/worksheets/sheet1.xml" ContentType="application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml"/>
			</Types>
			""");
		AddZipText(archive, "_rels/.rels", """
			<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
			<Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
			  <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument" Target="xl/workbook.xml"/>
			</Relationships>
			""");
		AddZipText(archive, "xl/workbook.xml", """
			<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
			<workbook xmlns="http://schemas.openxmlformats.org/spreadsheetml/2006/main"
			          xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships">
			  <sheets>
			    <sheet name="配方" sheetId="1" r:id="rId1"/>
			  </sheets>
			</workbook>
			""");
		AddZipText(archive, "xl/_rels/workbook.xml.rels", """
			<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
			<Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
			  <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet" Target="worksheets/sheet1.xml"/>
			</Relationships>
			""");
		AddZipText(archive, "xl/worksheets/sheet1.xml", BuildWorksheetXml(rows));
	}

	private static string BuildWorksheetXml(IReadOnlyList<List<string>> rows)
	{
		XNamespace ns = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
		var sheetData = new XElement(ns + "sheetData");

		for (var rowIndex = 0; rowIndex < rows.Count; rowIndex++)
		{
			var row = new XElement(ns + "row", new XAttribute("r", rowIndex + 1));
			for (var columnIndex = 0; columnIndex < rows[rowIndex].Count; columnIndex++)
			{
				row.Add(new XElement(ns + "c",
					new XAttribute("r", GetCellReference(columnIndex, rowIndex)),
					new XAttribute("t", "inlineStr"),
					new XElement(ns + "is", new XElement(ns + "t", rows[rowIndex][columnIndex] ?? ""))));
			}

			sheetData.Add(row);
		}

		var doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
			new XElement(ns + "worksheet", sheetData));
		return doc.ToString(SaveOptions.DisableFormatting);
	}

	private static List<List<string>> ReadSimpleXlsx(string filePath)
	{
		using var archive = ZipFile.OpenRead(filePath);
		var sharedStrings = ReadSharedStrings(archive);
		var sheetEntry = archive.GetEntry("xl/worksheets/sheet1.xml")
		                 ?? throw new InvalidOperationException("Excel 文件缺少工作表 sheet1。");

		using var stream = sheetEntry.Open();
		var doc = XDocument.Load(stream);
		XNamespace ns = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
		var result = new List<List<string>>();

		foreach (var row in doc.Descendants(ns + "row"))
		{
			var values = new List<string>();
			foreach (var cell in row.Elements(ns + "c"))
			{
				var reference = cell.Attribute("r")?.Value ?? "";
				var columnIndex = GetColumnIndex(reference);
				while (values.Count <= columnIndex)
					values.Add("");

				values[columnIndex] = ReadCellText(cell, sharedStrings, ns);
			}

			result.Add(values);
		}

		return result;
	}

	private static List<string> ReadSharedStrings(ZipArchive archive)
	{
		var entry = archive.GetEntry("xl/sharedStrings.xml");
		if (entry is null)
			return [];

		using var stream = entry.Open();
		var doc = XDocument.Load(stream);
		XNamespace ns = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
		return doc.Descendants(ns + "si")
			.Select(si => string.Concat(si.Descendants(ns + "t").Select(t => t.Value)))
			.ToList();
	}

	private static string ReadCellText(XElement cell, List<string> sharedStrings, XNamespace ns)
	{
		var type = cell.Attribute("t")?.Value;
		if (type == "s")
		{
			var indexText = cell.Element(ns + "v")?.Value ?? "0";
			return int.TryParse(indexText, out var index) && index >= 0 && index < sharedStrings.Count
				? sharedStrings[index]
				: "";
		}

		if (type == "inlineStr")
			return string.Concat(cell.Descendants(ns + "t").Select(t => t.Value));

		return cell.Element(ns + "v")?.Value ?? "";
	}

	private static void AddZipText(ZipArchive archive, string entryName, string content)
	{
		var entry = archive.CreateEntry(entryName);
		using var writer = new StreamWriter(entry.Open(), new UTF8Encoding(false));
		writer.Write(content);
	}

	private static string GetCellReference(int columnIndex, int rowIndex) =>
		$"{GetColumnName(columnIndex)}{rowIndex + 1}";

	private static string GetColumnName(int columnIndex)
	{
		var name = "";
		columnIndex++;
		while (columnIndex > 0)
		{
			var modulo = (columnIndex - 1) % 26;
			name = (char)('A' + modulo) + name;
			columnIndex = (columnIndex - modulo) / 26;
		}

		return name;
	}

	private static int GetColumnIndex(string cellReference)
	{
		var index = 0;
		foreach (var c in cellReference)
		{
			if (char.IsLetter(c) == false)
				break;

			index = index * 26 + char.ToUpperInvariant(c) - 'A' + 1;
		}

		return Math.Max(index - 1, 0);
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
		var recipeName = CreateNewRecipeInputName?.Trim();
		if (string.IsNullOrWhiteSpace(recipeName))
		{
			ShowNotification("Recipe name can not be empty!", UiMessageType.Error);
			return;
		}

		if (RecipeService.ContainsRecipeName(recipeName).Unwarp("check new recipe error!"))
		{
			ShowNotification("Recipe name is already exists!", UiMessageType.Error);
			return;
		}

		var recipe = new ProductRecipe();
		if (EditRecipe is not null && CreateNewRecipeIsCopyCurrentRecipeValue)
			ProductRecipe.CopyPropertyValues(EditRecipe, recipe);
		ApplyDefaultPointSources(recipe);
		recipe.Name = recipeName;
		recipe.Id = CreateNewRecipeInputId > 0 ? CreateNewRecipeInputId : 0;
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
		CreateNewRecipeInputName = "";
		CreateNewRecipeInputId = RecipeService.GetRecipes().Any() ? RecipeService.GetRecipes().Max(t => t.Id) + 1 : 1;
		CreateNewRecipeIsCopyCurrentRecipeValue = false;
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
		RefreshPropertyInstances();
	}


	public async Task @ReadSelectedPoints()
	{
		ShowToast("Start read selected points");
		ReadPointCommand.CustomData = null;
		var groups = BuildSelectedPointGroups(p => p.ReaderData?.ToString());
		foreach (var group in groups)
		{
			var reader = ConnectionManageService.GetConnection(group.ConnectionName) as IBinaryReader;
			if (reader is null)
			{
				var errorMessage = $"Read selected points failed! Connection '{group.ConnectionName}' is not found!";
				ShowNotification(errorMessage, UiMessageType.Error);
				ReadPointCommand.CustomData = errorMessage;
				break;
			}

			var readPointResult = await Task.Run(() => TempRecipe.ReadPointGroup(group.PointGroup, reader));
			if (readPointResult.IsError())
			{
				var errorMessage = $"Read selected points failed! group='{group.PointGroup.Name}' {readPointResult}";
				ShowNotification(errorMessage, UiMessageType.Error);
				ReadPointCommand.CustomData = errorMessage;
				break;
			}

			foreach (var property in group.Properties)
			{
				var value = property.Define.Getter!.Invoke(TempRecipe);
				property.TempValue1 = value;
				property.Value = value;
			}
		}

		ShowToast("end read selected points");
	}

	public async Task @WriteSelectedPoints()
	{
		ShowToast("Start write selected points");
		WritePointCommand.CustomData = null;
		var groups = BuildSelectedPointGroups(p => p.WriterData?.ToString());
		foreach (var group in groups)
		{
			var writer = ConnectionManageService.GetConnection(group.ConnectionName) as IBinaryWriter;
			if (writer is null)
			{
				var errorMessage = $"Write selected points failed! Connection '{group.ConnectionName}' is not found!";
				ShowNotification(errorMessage, UiMessageType.Error);
				WritePointCommand.CustomData = errorMessage;
				break;
			}

			var binaryStruct = group.Properties.FirstOrDefault()?.Instance as IBinaryStruct;
			if (binaryStruct is null)
			{
				var errorMessage = "Write selected points failed! Property Instance is not BinaryStruct Member!";
				ShowNotification(errorMessage, UiMessageType.Error);
				WritePointCommand.CustomData = errorMessage;
				break;
			}

			var writePointResult = await Task.Run(() => binaryStruct.WritePointGroup(group.PointGroup, writer));
			if (writePointResult.IsError())
			{
				var errorMessage = $"Write selected points failed! group='{group.PointGroup.Name}' {writePointResult}";
				ShowNotification(errorMessage, UiMessageType.Error);
				WritePointCommand.CustomData = errorMessage;
				break;
			}
		}

		ShowToast("End write selected points");
	}

	private List<(string ConnectionName, IBinaryPointGroupInfo PointGroup, List<IPropertyInstance> Properties)> BuildSelectedPointGroups(
		Func<IBinaryPointInfo, string?> getConnectionName)
	{
		const int maxWordsPerGroup = 100;
		var points = FilteredPropertyInstances
			.Where(property => property.Flag)
			.Select(property =>
			{
				if (property.Instance is not IBinaryStruct binaryStruct)
					return null;

				var pointInfo = GetPointInfo(binaryStruct, property);
				if (pointInfo is null)
					return null;

				var effectivePointInfo = ProductRecipe.GetEffectivePointInfo(EditRecipe, pointInfo);
				var connectionName = getConnectionName(effectivePointInfo);
				if (string.IsNullOrWhiteSpace(connectionName))
					return null;

				var wordLength = Math.Max(1, (int)Math.Ceiling(effectivePointInfo.ByteLength / 2.0));
				return new
				{
					Property = property,
					Point = effectivePointInfo,
					ConnectionName = connectionName,
					WordLength = wordLength,
				};
			})
			.Where(t => t is not null)
			.Select(t => t!)
			.OrderBy(t => t.ConnectionName)
			.ThenBy(t => t.Point.Offset)
			.ToList();

		var groups = new List<(string ConnectionName, IBinaryPointGroupInfo PointGroup, List<IPropertyInstance> Properties)>();
		foreach (var connectionGroup in points.GroupBy(t => t.ConnectionName))
		{
			var currentPoints = new List<IBinaryPointInfo>();
			var currentProperties = new List<IPropertyInstance>();
			var currentStart = 0;
			var currentEndExclusive = 0;

			foreach (var item in connectionGroup)
			{
				var pointStart = item.Point.Offset;
				var pointEndExclusive = item.Point.Offset + item.WordLength;
				var wouldExceedGroup = currentPoints.Count > 0 && pointEndExclusive - currentStart > maxWordsPerGroup;
				if (wouldExceedGroup)
				{
					groups.Add((connectionGroup.Key, CreateSelectedPointGroup(connectionGroup.Key, currentStart, currentEndExclusive, currentPoints), currentProperties));
					currentPoints = [];
					currentProperties = [];
					currentStart = 0;
					currentEndExclusive = 0;
				}

				if (currentPoints.Count == 0)
				{
					currentStart = pointStart;
					currentEndExclusive = pointEndExclusive;
				}
				else
				{
					currentEndExclusive = Math.Max(currentEndExclusive, pointEndExclusive);
				}

				currentPoints.Add(item.Point);
				currentProperties.Add(item.Property);
			}

			if (currentPoints.Count > 0)
				groups.Add((connectionGroup.Key, CreateSelectedPointGroup(connectionGroup.Key, currentStart, currentEndExclusive, currentPoints), currentProperties));
		}

		return groups;
	}

	private static IBinaryPointGroupInfo CreateSelectedPointGroup(
		string connectionName,
		int start,
		int endExclusive,
		List<IBinaryPointInfo> points)
	{
		return new BinaryPointGroupInfo
		{
			Name = $"RecipeSelected_{connectionName}_{start}_{endExclusive}",
			Start = start,
			End = endExclusive,
			Source = start.ToString(CultureInfo.InvariantCulture),
			ByteLength = Math.Max(0, (endExclusive - start) * 2),
			ByteFormat = ByteFormat.CDAB,
			Points = points,
		};
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

		var effectivePointInfo = ProductRecipe.GetEffectivePointInfo(EditRecipe, pointInfo);
		var reader = ConnectionManageService.GetConnection(effectivePointInfo.ReaderData?.ToString() ?? "") as IBinaryReader;
		if (reader is null)
		{
			var errorMessage = $"Read Point Failed! Connection '{effectivePointInfo.ReaderData}' is not found!";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var readPointResult = await TempRecipe.ReadPointAsync(effectivePointInfo, reader);
		if (readPointResult.IsError())
		{
			var errorMessage = $"Read Point Failed! src:'{ProductRecipe.GetPointSource(EditRecipe, effectivePointInfo)}' {readPointResult}";
			ShowNotification(errorMessage, UiMessageType.Error);
			ReadPointCommand.CustomData = errorMessage;
			return;
		}

		var value = property.Define.Getter!.Invoke(TempRecipe);
		property.TempValue1 = value;
		property.Value = value;
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

		var effectivePointInfo = ProductRecipe.GetEffectivePointInfo(EditRecipe, pointInfo);
		var writer = ConnectionManageService.GetConnection(effectivePointInfo.WriterData?.ToString() ?? "") as IBinaryWriter;
		if (writer is null)
		{
			var errorMessage = $"Write Point Failed! Connection '{effectivePointInfo.WriterData}' is not found!";
			ShowNotification(errorMessage, UiMessageType.Error);
			WritePointCommand.CustomData = errorMessage;
			return;
		}

		var writePointResult = await Task.Run(() => binaryStruct.WritePointAsync(effectivePointInfo, writer));
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
