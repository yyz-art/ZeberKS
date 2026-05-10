using System.Windows.Input;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ZC.Mvvm;
using ZitApp.Models;

namespace ZitApp.Contexts;

public enum MaterialState
{
	UnUsed,
	OK,
	RemainAlarm,
	NotMatched,
}

public partial class MaterialSpaceContext : ObservableObject
{
	public partial int Id { get; set; }
	public partial MaterialConfig Config { get; set; } = null!;
	public partial string MaterialCode { get; set; } = "";
	public partial string PositionCode { get; set; } = "";
	public partial double ScrapRate { get; set; } = 5.5;
	public partial int RemainCount { get; set; } = 0;
	public partial MaterialState MaterialState { get; set; }
	public partial bool IsUnlocked { get; set; }

	public partial ICommand? ToggleLockCommand { get; set; } = null!;
	public partial ICommand? MaterialReplaceCommand { get; set; } = null!;


	partial void OnConfigChanged(MaterialConfig value) => CheckMaterialState(value, null);
	partial void OnMaterialCodeChanged(string value) => CheckMaterialState(null, value);

	public void CheckMaterialState(MaterialConfig? config = null, string? code = null)
	{
		config ??= Config;
		code ??= MaterialCode;
		if (ReferenceEquals(config, null))
		{
			MaterialState = MaterialState.UnUsed;
			return;
		}
		if (config.IsUsed == false)
		{
			MaterialState = MaterialState.UnUsed;
			return;
		}
		var state = (config?.MaterialCodes.Contains(code) ?? false) && !string.IsNullOrWhiteSpace(code)
			? MaterialState.OK
			: MaterialState.NotMatched;
		if (state is MaterialState.OK && RemainCount <= Config?.AlarmRemainCount)
			state = MaterialState.RemainAlarm;
		MaterialState = state;
	}


	public static FuncValueConverter<MaterialState, IBrush> DefaultStateColorConverter { get; } = new((v) =>
	{
		return v switch
		{
			MaterialState.UnUsed => Brushes.Gray,
			MaterialState.OK => Brushes.Green,
			MaterialState.RemainAlarm => Brushes.Orange,
			MaterialState.NotMatched => Brushes.OrangeRed,
			_ => throw new ArgumentOutOfRangeException()
		};
	});

	public static FuncValueConverter<MaterialState, IBrush> StateColorConverter { get; set; } =
		DefaultStateColorConverter;

	public static void CreateList(ObservableList<MaterialSpaceContext> materialContexts, int materialSpaceCount)
	{
		for (var i = 0; i < materialSpaceCount; i++)
		{
			materialContexts.Add(new MaterialSpaceContext
			{
				Id = i + 1,
				Config = new MaterialConfig
					{ Id = i + 1, IsUsed = false, PositionName = $"Material{i + 1}" },
				MaterialCode = "",
			});
		}
	}
}