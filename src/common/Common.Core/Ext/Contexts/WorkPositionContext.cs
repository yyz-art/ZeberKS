using Avalonia.Media;
using ZC.Mvvm;
using ZitApp.Models;
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
	public partial string? LastError { get; set; }
	public partial WorkStep WorkStep { get; set; } = WorkStep.WORK_POSITION_IS_FREE;
	public partial ProductionState ProductionState { get; set; } = ProductionState.NA;
	public partial IImage Image { get; set; } = null!;
	public partial double AxisPercent { get; set; } = 0.5;
	public partial string? ImagePathRoot { get; set; }
	public partial DateTime ImagePathCollectInfoTime { get; set; }
	public partial ObservableList<ImageInfo> ImageInfos { get; set; } = [];
	public partial ImageInfo? SelectedImageInfo { get; set; }


	public WorkPositionContext()
	{
		ScrewInstallDataList =
			new ObservableList<ScrewInstallData>(Enumerable.Range(0, 12).Select(t => new ScrewInstallData()));
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

	public static void CreateList(ObservableList<WorkPositionContext> workPositionContexts, int i)
	{
		workPositionContexts.Clear();
		workPositionContexts.Add(new WorkPositionContext { Id = 1, Name = "WP-1" });
		workPositionContexts.Add(new WorkPositionContext { Id = 2, Name = "WP-2" });
	}
}