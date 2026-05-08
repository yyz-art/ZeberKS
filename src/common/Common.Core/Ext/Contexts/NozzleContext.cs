using ZC.Mvvm;
using ZitApp.Models;

namespace ZitApp.Contexts;

public partial class NozzleContext : ObservableObject
{
	public NozzleConfig Config { get; set; } = null!;
	public partial double Value { get; set; }
	public partial ProductionState ProductionState { get; set; } = ProductionState.NA;

	public static void CreateList(ObservableList<NozzleContext> list,int count)
	{
		for (var i = 0; i < count; i++)
		{
			list.Add(new NozzleContext
			{
				Config = new NozzleConfig
					{ Id = i + 1, Name = $"Nozzle {i + 1}", PressureMinValue = 0, PressureMaxValue = 4096 }
			});
		}
	}
}