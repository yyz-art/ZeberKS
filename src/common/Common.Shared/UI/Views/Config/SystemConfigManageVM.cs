using System.Text.Json;
using Avalonia.Platform.Storage;
using ZC;
using ZC.CFG;
using ZC.IFS.Objects;
using ZC.LOG;
using ZC.MetaInfo;
using ZC.MetaInfo.Utils;
using ZC.Mvvm;
using ZC.Shared.DefaultJson;
using ZC.UI.ControlLibs;

namespace ZitApp.UI.Config;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class SystemConfigManageVM : UiVM<SystemConfigManageView>, INamedObject
{
	public static string AppConfigBackupPath = $"{Environment.CurrentDirectory}/data/backup/app-configs/";

	public SystemConfigManageVM()
	{
		var nameLanguageKey = $"NameBy{App.Current.Language}";
		foreach (var propertyInstance in PropertyInstances)
		{
			if (propertyInstance.ValueInfo is ValueInfoAttribute valueInfo)
				valueInfo.DisplayName = valueInfo.GetAttachData(nameLanguageKey.AsMemory())
					.Value?.ToString() ?? propertyInstance.Define.Name;
		}

		FilteredPropertyInstances = new ObservableList<IPropertyInstance>(PropertyInstances);
		EditConfig = new AppConfig();
		ConfigGroupNames = PropertyInstances.Select(t => t.ValueInfo?.Category).Distinct().ToArray()!;
	}

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
	public ObservableList<IPropertyInstance> FilteredPropertyInstances { get; }

	protected override async Task OnInitialize(object? ctx, object? args)
	{
		TypeMetaInfo<AppConfig>.Cache.PropertyValuesCopy(
			CurrentConfig, TypeMetaInfo<AppConfig>.Cache, EditConfig, false);
		await base.OnInitialize(ctx, args);
	}

	protected override Task OnViewAttachedToVisualTree(object sender, object? args)
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			if (propertyInstance.Define.CanRead && propertyInstance.Define.CanWrite)
				propertyInstance.TempValue1 = propertyInstance.Define.Getter!.Invoke(CurrentConfig);
		}

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

		var currentConfigText = JsonSerializer.Serialize(CurrentConfig, Global.Json.DefaultIndentOptions);
		var editConfigText = JsonSerializer.Serialize(EditConfig, Global.Json.DefaultIndentOptions);
		if (currentConfigText == editConfigText)
		{
			ShowToast("save success!", UiMessageType.Success);
			return;
		}

		var backupFileName = Path.Combine(AppConfigBackupPath, $"app-config_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json");
		if (false == Directory.Exists(AppConfigBackupPath))
			Directory.CreateDirectory(AppConfigBackupPath);
		Logger.Info("Backup system config at '{path}'", backupFileName);
		await File.WriteAllTextAsync(backupFileName, currentConfigText);

		ShowToast("saving ...");
		var currentConfigContext = CurrentConfig.AccessConfigContext() as JsonConfigContext;
		Debug.Assert(currentConfigContext?.SavePath != null);
		var result = await ConfigManager.SaveConfigAsync(EditConfig, currentConfigContext.SavePath);
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
		return Task.CompletedTask;
	}

	partial void OnSelectedConfigGroupChanged(string value)
	{
		FilteredPropertyInstances.Clear();
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Flag = false;
			if (propertyInstance.ValueInfo?.Category == value || value == "全部")
				FilteredPropertyInstances.Add(propertyInstance);
		}
	}

	partial void OnEditConfigChanged(AppConfig oldValue, AppConfig newValue)
	{
		foreach (var propertyInstance in PropertyInstances)
		{
			propertyInstance.Reset(newValue);
			propertyInstance.CanRead = true;
			propertyInstance.CanWrite = true;
		}

		OnSelectedConfigGroupChanged(SelectedConfigGroup);
	}

	public string GetObjectName() => "SYSTEM-CONFIG";
}