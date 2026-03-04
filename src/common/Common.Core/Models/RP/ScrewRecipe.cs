using ZitApp.Devices.Screw;

namespace ZitApp.Models.RP;

public partial class ScrewRecipe
{
	public string Name { get; set; } = null!;

	public List<ScrewMachineRecipeProperties> TaskOptionsList
	{
		get => field ??= new List<ScrewMachineRecipeProperties>();
		set;
	} = null!;
}