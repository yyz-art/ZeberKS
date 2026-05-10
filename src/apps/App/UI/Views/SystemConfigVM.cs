using System.Reflection;
using System.Globalization;
using System.Text.Json;
using Avalonia.Collections;
using Avalonia.Platform.Storage;
using ClosedXML.Excel;
using ZC;
using ZC.CFG;
using ZC.IFS.Objects;
using ZC.LOG;
using ZC.MetaInfo;
using ZC.MetaInfo.Utils;
using ZC.Mvvm;
using ZC.Shared.DefaultJson;
using ZC.UI.ControlLibs;
using ZitApp.Models;

namespace ZitApp.UI.Config;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class SystemConfigVM : CommonUiVM<SystemConfigView>, INamedObject
{
	public static string AppConfigBackupPath = $"{Environment.CurrentDirectory}/data/backup/app-configs/";
	public string GetObjectName() => "SYSTEM-CONFIG";
	public SystemConfigVM()
	{
		var nameLanguageKey = $"NameBy{App.Current.Language}";
		foreach (var propertyInstance in PropertyInstances)
		{
			if (propertyInstance.ValueInfo is ValueInfoAttribute valueInfo)
				valueInfo.DisplayName = valueInfo.GetAttachData(nameLanguageKey.AsMemory())
					.Value?.ToString() ?? propertyInstance.Define.Name;
		}

		// FilteredPropertyInstances = new ObservableList<IPropertyInstance>(PropertyInstances);
		ConfigGroupNames = PropertyInstances.Select(t => t.ValueInfo?.Category).Distinct().ToArray()!;
		GroupedPropertyInstances = new DataGridCollectionView(PropertyInstances);
		GroupedPropertyInstances.GroupDescriptions.Add(new DataGridPathGroupDescription("ValueInfo.Category"));
		EditConfig = new AppConfig
		{
			NozzleConfigs = new(Enumerable.Range(0, 10).Select(i => new NozzleConfig()
				{ Id = i + 1, Name = $"Nozzle{i + 1}", PressureMinValue = 0, PressureMaxValue = 4096 }))
		};
	}
	public partial ObservableList<string> ImportSheetNames { get; set; } = [];
	public partial string SelectedSheetName { get; set; }
	public List<IPropertyInstance> PropertyInstances { get; } =
		TypeMetaInfo<AppConfig>.Cache.Properties.Where(t => t.Attributes
				.Any(attr => attr is ValueInfoAttribute))
			.Select(t => PropertyInstance.Create(null, t)).ToList();

	public partial AppConfig EditConfig { get; set; }
	public required partial AppConfig CurrentConfig { get; set; }
	public required ILogger Logger { get; init; }
	public required IConfigManager ConfigManager { get; init; }
	public string[] ConfigGroupNames { get; set; } = ["连接配置", "提示信息配置"];
	public partial string SelectedConfigGroup { get; set; } = "";
	// public ObservableList<IPropertyInstance> FilteredPropertyInstances { get; }
	public DataGridCollectionView GroupedPropertyInstances { get; set; }


	protected override async Task OnInitialize(object? ctx, object? args)
	{
		using var memoryStream = new MemoryStream();
		JsonSerializer.Serialize(memoryStream, CurrentConfig, Global.Json.DefaultIndentOptions);
		memoryStream.Position = 0;
		EditConfig = JsonSerializer.Deserialize<AppConfig>(memoryStream, Global.Json.DefaultIndentOptions)!;
		await base.OnInitialize(ctx, args);
	}

	private void SetCurrentValueDisplay()
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			if (propertyInstance.Define.CanRead && propertyInstance.Define.CanWrite)
				propertyInstance.TempValue1 = propertyInstance.Define.Getter!.Invoke(CurrentConfig);
		}
	}

	protected override Task OnViewAttachedToVisualTree(object sender, object? args)
	{
		SetCurrentValueDisplay();
		return base.OnViewAttachedToVisualTree(sender, args);
	}

	public async Task @Save()
	{
		var option = await ShowMessageBox("Confirm save system config?", "Save system config",
			MessageBoxIcon.Question, MessageBoxButton.YesNo);
		if (option is not MessageBoxResult.Yes)
		{
			ShowToast("Cancel");
			return;
		}

		var typeMetaInfo = TypeMetaInfo<AppConfig>.Cache;
		typeMetaInfo.PropertyValuesCopy(EditConfig, typeMetaInfo, CurrentConfig, true);
		SetCurrentValueDisplay();


		var currentConfigText = JsonSerializer.Serialize(CurrentConfig, Global.Json.DefaultIndentOptions);
		var backupFileName = Path.Combine(AppConfigBackupPath, $"app-config_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json");

		if (false == Directory.Exists(AppConfigBackupPath))
			Directory.CreateDirectory(AppConfigBackupPath);

		Logger.Info("Backup system config at '{path}'", backupFileName);
		await File.WriteAllTextAsync(backupFileName, currentConfigText);

		ShowToast("saving ...");
		var currentConfigContext = CurrentConfig.AccessConfigContext() as JsonConfigContext;

		if (currentConfigContext?.SavePath == null)
		{
			ShowNotification("Save failed: Unable to get the config save path!", UiMessageType.Error);
			return;
		}

		var result = await ConfigManager.SaveConfigAsync(CurrentConfig, currentConfigContext.SavePath);
		if (result.IsError())
		{
			ShowNotification($"save system config error! \n{result}", UiMessageType.Error);
			return;
		}

		ShowToast("save system config success!", UiMessageType.Success);
	}

	public async Task @Export()
	{
		var file = await this.GetTopLevel()!.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions()
		{
			Title = $"Save System Config",
			DefaultExtension = ".json",
			SuggestedFileType = new FilePickerFileType(".json"),
			SuggestedFileName = $"SystemConfig-{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json"
		});
		if (file is null)
		{
			ShowToast("Cancel");
			return;
		}

		try
		{
			await using var fs = File.OpenWrite(file.Path.LocalPath);
			await JsonSerializer.SerializeAsync(fs, EditConfig, Global.Json.DefaultIndentOptions);
			ShowToast("Saved successfully!", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			ShowNotification($"Save failed! {ex}", UiMessageType.Success);
		}
	}

	public async Task @Import()
	{
		var files = await this.GetTopLevel()!.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
		{
			AllowMultiple = false,
			FileTypeFilter = [new FilePickerFileType(".json")],
			SuggestedFileType = new FilePickerFileType(".json")
		});

		if (files.Count <= 0)
		{
			ShowToast("Cancel");
			return;
		}

		var file = files[0];
		var loadConfigResult = await ConfigManager.LoadConfigAsync<AppConfig>(file.Path.LocalPath);
		if (loadConfigResult.IsError())
		{
			ShowToast($"load config error!\n{loadConfigResult}", UiMessageType.Error);
			return;
		}

		EditConfig = loadConfigResult.Value!;
		ShowToast("import success!", UiMessageType.Success);
	}

	public Task @Apply()
	{
		ShowToast("start apply ...");
		var typeMetaInfo = TypeMetaInfo<AppConfig>.Cache;
		typeMetaInfo.PropertyValuesCopy(EditConfig, typeMetaInfo, CurrentConfig, true);
		SetCurrentValueDisplay();
		ShowToast("apply success!", UiMessageType.Success);
		return Task.CompletedTask;
	}

	public async Task ApplySinglePropertyAsync(IPropertyInstance propertyInstance, string input)
	{
		try
		{
			var property = typeof(AppConfig).GetProperty(propertyInstance.Define.Name);
			if (property is null || property.CanWrite == false)
			{
				await ShowMessageBox("当前配置项不可修改。", "系统配置", MessageBoxIcon.Warning);
				return;
			}

			var value = ConvertConfigValue(input, property.PropertyType);
			property.SetValue(EditConfig, value);
			property.SetValue(CurrentConfig, value);
			propertyInstance.Value = value;
			propertyInstance.TempValue1 = value;

			var displayName = propertyInstance.ValueInfo?.DisplayName ?? propertyInstance.Define.Name;
			ShowToast($"{displayName} 修改成功", UiMessageType.Success);
		}
		catch (Exception ex)
		{
			await ShowMessageBox($"配置修改失败: {ex.Message}", "系统配置", MessageBoxIcon.Error);
		}
	}

	private static object? ConvertConfigValue(string input, Type targetType)
	{
		var actualType = Nullable.GetUnderlyingType(targetType) ?? targetType;
		if (actualType == typeof(string))
			return input;
		if (actualType == typeof(bool))
			return bool.Parse(input);
		if (actualType.IsEnum)
			return Enum.Parse(actualType, input, true);

		return Convert.ChangeType(input, actualType, CultureInfo.InvariantCulture);
	}

	// partial void OnSelectedConfigGroupChanged(string value)
	// {
	// 	FilteredPropertyInstances.Clear();
	// 	foreach (var propertyInstance in PropertyInstances)
	// 	{
	// 		propertyInstance.Flag = false;
	// 		if (propertyInstance.ValueInfo?.Category == value || value == "全部")
	// 			FilteredPropertyInstances.Add(propertyInstance);
	// 	}
	// }

	partial void OnEditConfigChanged(AppConfig oldValue, AppConfig newValue)
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Reset(newValue);
			propertyInstance.CanRead = true;
			propertyInstance.CanWrite = true;
		}

		if (ReferenceEquals(newValue,null) == false)
		{
			if (newValue.NozzleConfigs.Count == 0)
			{
				for (var i = 0; i < 10; i++)
				{
					newValue.NozzleConfigs.Add(new NozzleConfig()
						{ Id = i + 1, Name = $"Nozzle{i + 1}", PressureMinValue = 0, PressureMaxValue = 4096 });
				}
			}
		}

		OnSelectedConfigGroupChanged(SelectedConfigGroup);
	}

	public async Task @ImportNgDefineTable()
	{
		var files = await this.GetTopLevel()!.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
		{
			FileTypeFilter = [new FilePickerFileType(".xlsx")]
		});

		if (files.Count <= 0)
		{
			ShowToast("cancel");
			return;
		}
		using var workbook = new XLWorkbook(files[0].Path.LocalPath);
		ImportSheetNames.Clear();
		ImportSheetNames.AddRange(workbook.Worksheets.Select(t => t.Name));
		SelectedSheetName = "";
		await ShowModalDialog(View.ImportTableSheetSelectDialog);
		if (string.IsNullOrEmpty(SelectedSheetName))
		{
			await ShowMessageBoxOverlay("select sheet is null, cancel", "import ng define table", MessageBoxIcon.Error);
			return;
		}

		var worksheet = workbook.Worksheet(SelectedSheetName);
		var rows = worksheet.RangeUsed()!.RowsUsed().Skip(1); // 跳过表头
		var list = new List<NgDefine>();
		foreach (var row in rows)
		{
			var item = new NgDefine();
			item.Id = row.Cell(1).GetValue<int>();
			item.Sender = row.Cell(2).GetValue<string>();
			item.Name = row.Cell(3).GetValue<string>();
			item.Reason = row.Cell(4).GetValue<string>();
			item.Description = row.Cell(5).GetValue<string>();
			list.Add(item);
		}

		EditConfig.NgDefines = list;
		ShowToast("import ng define table success!", UiMessageType.Success);
		
	}


}