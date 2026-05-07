using Avalonia.Media;
using ZC.Mvvm;
using ZitApp.Models;
using ScrewInstallData = ZitApp.Models.ScrewInstallData;

namespace ZitApp.Contexts;

public partial class WorkPositionContext : ObservableObject
{
	public partial int Id { get; set; }
	public partial string Name { get; set; } = "";
	public partial string SN { get; set; } = "";
	public partial string Message { get; set; } = "";
	public partial WorkStep WorkStep { get; set; }

	public partial OkNgState OkNgState { get; set; } = OkNgState.OK;
	public partial IImage Image { get; set; } = null!;
	public partial double AxisPercent { get; set; } = 0.5;

	public WorkPositionContext()
	{
		ScrewInstallDataList =
			new ObservableList<ScrewInstallData>(Enumerable.Range(0, 12).Select(t => new ScrewInstallData()));
	}

	public partial ObservableList<ScrewInstallData> ScrewInstallDataList { get; set; }
	public partial ObservableList<String> ImageNames { get; set; } = ["A_OK", "B_OK", "C_NG", "D_OK", "E_NG", "F_NG"];
	public partial bool IsUsedScrewInstallDataGrid { get; set; } = CommonAppConfig.IsUsedScrewInstallDataGrid;

	public static void CreateList(ObservableList<WorkPositionContext> workPositionContexts, int i)
	{
		workPositionContexts.Clear();
		workPositionContexts.Add(new WorkPositionContext { Id = 1, Name = "Left" });
		workPositionContexts.Add(new WorkPositionContext { Id = 2, Name = "Right" });
	}
}