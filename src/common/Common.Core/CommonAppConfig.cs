using ZC.CFG;
using ZC.DP;
using ZC.Mvvm;

namespace ZitApp;

public partial class NozzleConfig : ObservableObject
{
	public partial int Id { get; set; }
	public partial string Name { get; set; } = "";
	public partial bool IsEnabled { get; set; }
	public partial double PressureMaxValue { get; set; }
	public partial double PressureMinValue { get; set; }
	public partial string Comment { get; set; } = "";
}

[ObservableObject]
public abstract partial class CommonAppConfig : ConfigBase
{
	public string VisionImagePath { get; set; } = "D:/Vision Images";
	public static bool IsDevTestMode { get; set; }
	public const string NameByCN = "NameByCN";
	public const string NameByVI = "NameByVI";
	public const string NameByEN = "NameByEN";
	public int SnCodeMinLength { get; set; } = 20;
	public int KeyPartCodeMinLength { get; set; } = 10;

	public int RecipeSwitchWaitTimeout { get; set; } = 35000;

	public string Language { get; set; } = "cn";

	public string WorkPosition1ImageRootPath { get; set; } = "";
	public string WorkPosition2ImageRootPath { get; set; } = "";

	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS ENABLE",
		DataDefine.KeyValue, NameByEN, "SIFS ENABLE",
		DataDefine.KeyValue, NameByVI, "SIFS ENABLE",
	], DefaultValue = "true", Description = "SIFS ENABLE")]
	public bool SifsEnable { get; set; } = true;

	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS HOST ADDRESS",
		DataDefine.KeyValue, NameByEN, "SIFS HOST ADDRESS",
		DataDefine.KeyValue, NameByVI, "SIFS HOST ADDRESS",
	], DefaultValue = "10.5.1.160", Description = "SIFS IP ADDRESS")]
	public string SifsHostIp { get; set; } = "10.5.1.160";

	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS HOST PORT",
		DataDefine.KeyValue, NameByEN, "SIFS HOST PORT",
		DataDefine.KeyValue, NameByVI, "SIFS HOST PORT",
	], DefaultValue = "21347", Description = "SIFS HOST PORT")]
	public int SifsHostPort { get; set; } = 21347;


	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP ENABLE",
		DataDefine.KeyValue, NameByEN, "EAP ENABLE",
		DataDefine.KeyValue, NameByVI, "EAP ENABLE",
	], DefaultValue = "true", Description = "EAP ENABLE")]
	public bool EapEnable { get; set; } = true;

	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP HOST ADDRESS",
		DataDefine.KeyValue, NameByEN, "EAP HOST ADDRESS",
		DataDefine.KeyValue, NameByVI, "EAP HOST ADDRESS",
	], DefaultValue = "10.5.1.160", Description = "EAP IP ADDRESS")]
	public string EapHostIp { get; set; } = "10.5.1.160";

	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByEN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByVI, "EAP HOST PORT",
	], DefaultValue = "21347", Description = "EAP HOST PORT")]
	public int EapHostPort { get; set; } = 21347;

	#region 生产配置

	[ValueInfo(Category = "生产配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Line",
		DataDefine.KeyValue, NameByEN, "Line",
		DataDefine.KeyValue, NameByVI, "Line",
	], DefaultValue = 9600, Description = "Line")]
	public string Line { get; set; } = "TC2A";

	[ValueInfo(Category = "生产配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "StationName",
		DataDefine.KeyValue, NameByEN, "StationName",
		DataDefine.KeyValue, NameByVI, "StationName",
	], DefaultValue = 9600, Description = "StationName")]
	public string StationName { get; set; } = "MFG-AUTO";

	#endregion

	#region MyRegion

	[ValueInfo(Category = "备注", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "联系方式",
		DataDefine.KeyValue, NameByEN, "联系方式",
		DataDefine.KeyValue, NameByVI, "联系方式",
	], DefaultValue = 9600, Description = "联系方式")]
	public string 联系方式 { get; set; } = "1234567890";

	#endregion

	public partial ObservableList<NozzleConfig> NozzleConfigs { get; set; } = [];

	#region 上料配置

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码1",
		DataDefine.KeyValue, NameByEN, "Material position code 1",
		DataDefine.KeyValue, NameByVI, "Material position code 1",
	], DefaultValue = "", Description = "上料位置码1")]
	public partial string MaterialPositionCode1 { get; set; } = "Material-Position-1";

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码2",
		DataDefine.KeyValue, NameByEN, "Material position code 2",
		DataDefine.KeyValue, NameByVI, "Material position code 2",
	], DefaultValue = "", Description = "上料位置码2")]
	public partial string MaterialPositionCode2 { get; set; } = "Material-Position-2";

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码3",
		DataDefine.KeyValue, NameByEN, "Material position code 3",
		DataDefine.KeyValue, NameByVI, "Material position code 3",
	], DefaultValue = "", Description = "上料位置码3")]
	public partial string MaterialPositionCode3 { get; set; } = "Material-Position-3";

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码4",
		DataDefine.KeyValue, NameByEN, "Material position code 4",
		DataDefine.KeyValue, NameByVI, "Material position code 4",
	], DefaultValue = "", Description = "上料位置码4")]
	public partial string MaterialPositionCode4 { get; set; } = "Material-Position-4";

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码5",
		DataDefine.KeyValue, NameByEN, "Material position code 5",
		DataDefine.KeyValue, NameByVI, "Material position code 5",
	], DefaultValue = "", Description = "上料位置码5")]
	public partial string MaterialPositionCode5 { get; set; } = "Material-Position-5";

	[ValueInfo(Category = "Material position / 上料位置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "上料位置码6",
		DataDefine.KeyValue, NameByEN, "Material position code 6",
		DataDefine.KeyValue, NameByVI, "Material position code 6",
	], DefaultValue = "", Description = "上料位置码6")]
	public partial string MaterialPositionCode6 { get; set; } = "Material-Position-6";



	#endregion

	public static int MaterialSpaceCount { get; set; } = 5;
	public static int NozzleCount { get; set; } = 7;
	
	public static bool IsUsedScrewInstallDataGrid { get; set; }
}