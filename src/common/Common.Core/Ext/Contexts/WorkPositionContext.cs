using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using ZC.Mvvm;
using ZC.UI.Utils;
using ZitApp.Models;
using ZitApp.UI.Dialogs;
using ScrewInstallData = ZitApp.Models.ScrewInstallData;

namespace ZitApp.Contexts;

public record ImageInfo(string Name, string Path);

public partial class WorkPositionContext : ObservableObject
{
	public partial int Id { get; set; }
	public partial string Name { get; set; } = "";
	public partial string ScanSnCode { get; set; } = "";
	public partial string ScanKeyPartCode { get; set; } = "";
	public partial string ModelName { get; set; } = "";
	public partial string? ErrorMessage { get; set; }
	public partial WorkStep WorkStep { get; set; } = WorkStep.FREE;
	public partial ProductionState ProductionState { get; set; } = ProductionState.NA;
	public partial IImage Image { get; set; } = null!;
	public partial double AxisPercent { get; set; } = 0.5;
	public partial string? ImagePathRoot { get; set; }
	public partial DateTime ImagePathCollectInfoTime { get; set; }

	public partial ObservableList<ImageInfo> ImageInfos { get; set; } =
		[new("TEST", "C:\\Users\\AINO\\Pictures\\d.png")];

	public partial ImageInfo? SelectedImageInfo { get; set; }

	partial void OnSelectedImageInfoChanged(ImageInfo? oldValue, ImageInfo? newValue)
	{
		if (newValue != null)
		{
			try
			{
				Image = new Bitmap(newValue.Path);
			}
			catch (IOException)
			{
				// File is locked by another process (e.g. camera writing), skip this frame
			}
		}
	}

	public NgDetailDialog? NgDetailDialog { get; set; }

	public WorkPositionContext()
	{
		ScrewInstallDataList =
			new ObservableList<ScrewInstallData>(Enumerable.Range(0, 16).Select(t => new ScrewInstallData()));
	}

	public Task ShowNgDetailDialog()
	{
		if (false == Dispatcher.UIThread.CheckAccess())
		{
			return Dispatcher.UIThread.InvokeAsync(ShowNgDetailDialog);
		}

		NgDetailDialog ??= new NgDetailDialog();
		NgDetailDialog.DataContext = this;
		NgDetailDialog.ShowInTaskbar = false;
		return NgDetailDialog.ShowDialog((Window)AvaloniaApplication.Current.MainView);
	}

	public Task HideNgDetailDialog()
	{
		if (false == Dispatcher.UIThread.CheckAccess())
		{
			return Dispatcher.UIThread.InvokeAsync(HideNgDetailDialog);
		}

		NgDetailDialog?.Hide();
		return Task.CompletedTask;
	}

	public void UpdateImageInfo()
	{
		if (Directory.Exists(ImagePathRoot) == false)
			return;
		var lastWriteTime = Directory.GetLastWriteTime(ImagePathRoot);
		if (lastWriteTime == ImagePathCollectInfoTime)
			return;
		if (ImageInfos.Count > 100)
			ImageInfos.RemoveRange(ImagePathRoot.Length - 10, 10);
		ImageInfo? latest = null;
		foreach (var file in Directory.GetFiles(ImagePathRoot))
		{
			if (ImageInfos.Any(t => t.Path == file))
				continue;
			latest = new ImageInfo($"{DayProductionId}:{ScanSnCode} {Path.GetFileNameWithoutExtension(file)}", file);
			ImageInfos.Insert(0, latest);
		}

		SelectedImageInfo = latest;
		ImagePathCollectInfoTime = lastWriteTime;
	}


	public partial ObservableList<ScrewInstallData> ScrewInstallDataList { get; set; }
	public partial ObservableList<String> ImageNames { get; set; } = ["A_OK", "B_OK", "C_NG", "D_OK", "E_NG", "F_NG"];
	public partial bool IsUsedScrewInstallDataGrid { get; set; } = CommonAppConfig.IsUsedScrewInstallDataGrid;
	public partial int DayProductionId { get; set; }
	public partial bool MaterialCheck { get; set; } = true;
	public partial bool RecipeCheck { get; set; } = true;
	public partial bool MesEnabled { get; set; } = true;
	public partial bool TestScanner { get; set; } 
	public partial ObservableList<NgDefine> NgItems { get; set; } = [];

	public void @OpenImageFileFolder()
	{
		if (SelectedImageInfo is not null)
		{
			Process.Start("explorer.exe", "/select," + SelectedImageInfo.Path!);
		}
	}

	public static void CreateList(ObservableList<WorkPositionContext> workPositionContexts, int i)
	{
		workPositionContexts.Clear();
		workPositionContexts.Add(new WorkPositionContext { Id = 1, Name = "WP-1" });
		workPositionContexts.Add(new WorkPositionContext { Id = 2, Name = "WP-2" });
	}
}