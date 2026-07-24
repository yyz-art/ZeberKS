using System.Net.Sockets;
using ZC.CFG;
using ZC.DB;
using ZC.DP;
using ZC.Mvvm;
using ZC.Net.Sockets;

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

public partial class ScrewMachineConfig : ObservableObject, INetworkSocketConfig
{
	public partial string IpAddress { get; set; } = "127.0.0.1";
	public partial int Port { get; set; } = 502;
	ProtocolType INetworkSocketConfig.Protocol => ProtocolType.Tcp;
}

public partial class PlcConfig : ObservableObject, INetworkSocketConfig
{
	public partial string IpAddress { get; set; } = "127.0.0.1";
	public partial int Port { get; set; } = 502;
	ProtocolType INetworkSocketConfig.Protocol => ProtocolType.Tcp;
}

[ObservableObject]
public abstract partial class CommonAppConfig : ConfigBase
{
	public static string ApplicationName { get; set; } = "APP";
	public List<DatabaseConnectionConfig> Databases { get; set; } = null!;
	public TaskServiceHostOptions TaskServiceHostOptions { get; set; } = null!;
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

	[ValueInfo(Category = "IMAGE SAVE", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "IMAGE SAVE",
		DataDefine.KeyValue, NameByEN, "IMAGE SAVE",
		DataDefine.KeyValue, NameByVI, "IMAGE SAVE",
	], DefaultValue = "true", Description = "IMAGE SAVE")]
	public string VisionImagePath { get; set; } = "D:\\图像保存";

	[ValueInfo(Category = "IMAGE SAVE", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "ZIP输出路径",
		DataDefine.KeyValue, NameByEN, "Image Zip Output Path",
		DataDefine.KeyValue, NameByVI, "Image Zip Output Path",
	], DefaultValue = "D:/Vision Files", Description = "Image zip package output directory")]
	public string ImageZipOutputPath { get; set; } = "D:/Vision Files";


	[ValueInfo(Category = "生产配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "工号",
		DataDefine.KeyValue, NameByEN, "Work No",
		DataDefine.KeyValue, NameByVI, "Work No",
	], DefaultValue = "M000086", Description = "工号")]
	public string WorkerNo { get; set; } = "M000086";

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
	public string EapHostIp { get; set; } = "127.0.0.1";

	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByEN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByVI, "EAP HOST PORT",
	], DefaultValue = "21347", Description = "EAP HOST PORT")]
	public int EapHostPort { get; set; } = 5000;

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

	public partial ObservableList<NozzleConfig> NozzleConfigs { get; set; } = null!;

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

	#region 连接配置

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Plc IP",
		DataDefine.KeyValue, NameByEN, "Plc IP",
		DataDefine.KeyValue, NameByVI, "Plc IP",
	], DefaultValue = "192.168.1.20", Description = "Plc IPAddress")]
	public string PlcIpAddress { get; set; } = "192.168.1.20";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Plc Port",
		DataDefine.KeyValue, NameByEN, "Plc Port",
		DataDefine.KeyValue, NameByVI, "Plc Port",
	], DefaultValue = 502, Description = "Plc Port")]
	public int PlcPort { get; set; } = 502;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 串口",
		DataDefine.KeyValue, NameByEN, "Scanner1 COM",
		DataDefine.KeyValue, NameByVI, "Scanner1 COM",
	], Description = "Scanner 1 COM", DefaultValue = "COM5")]
	public string Scanner1ComPort { get; set; } = "COM5";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 Port",
		DataDefine.KeyValue, NameByEN, "Scanner1 Port",
		DataDefine.KeyValue, NameByVI, "Scanner1 Port",
	], DefaultValue = 9600, Description = "Scanner 1 Port")]
	public int Scanner1BaudRate { get; set; } = 9600;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 串口",
		DataDefine.KeyValue, NameByEN, "Scanner2 COM",
		DataDefine.KeyValue, NameByVI, "Scanner2 COM",
	], DefaultValue = "COM5", Description = "Scanner 2 COM")]
	public string Scanner2ComPort { get; set; } = "COM5";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 Port",
		DataDefine.KeyValue, NameByEN, "Scanner2 Port",
		DataDefine.KeyValue, NameByVI, "Scanner2 Port",
	], DefaultValue = 9600, Description = "Scanner 2 Port")]
	public int Scanner2BaudRate { get; set; } = 9600;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "使用TCP扫码枪",
		DataDefine.KeyValue, NameByEN, "Use TCP Scanner",
		DataDefine.KeyValue, NameByVI, "Use TCP Scanner",
	], DefaultValue = "false", Description = "Use TCP Scanner (true) or Serial (false)")]
	public bool UseTcpScanner { get; set; } = false;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 TCP IP",
		DataDefine.KeyValue, NameByEN, "Scanner1 TCP IP",
		DataDefine.KeyValue, NameByVI, "Scanner1 TCP IP",
	], DefaultValue = "192.168.1.100", Description = "Scanner 1 TCP IP")]
	public string Scanner1TcpIp { get; set; } = "192.168.1.100";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 TCP Port",
		DataDefine.KeyValue, NameByEN, "Scanner1 TCP Port",
		DataDefine.KeyValue, NameByVI, "Scanner1 TCP Port",
	], DefaultValue = 5000, Description = "Scanner 1 TCP Port")]
	public int Scanner1TcpPort { get; set; } = 5000;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 TCP IP",
		DataDefine.KeyValue, NameByEN, "Scanner2 TCP IP",
		DataDefine.KeyValue, NameByVI, "Scanner2 TCP IP",
	], DefaultValue = "192.168.1.101", Description = "Scanner 2 TCP IP")]
	public string Scanner2TcpIp { get; set; } = "192.168.1.101";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 TCP Port",
		DataDefine.KeyValue, NameByEN, "Scanner2 TCP Port",
		DataDefine.KeyValue, NameByVI, "Scanner2 TCP Port",
	], DefaultValue = 5000, Description = "Scanner 2 TCP Port")]
	public int Scanner2TcpPort { get; set; } = 5000;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1_2 串口",
		DataDefine.KeyValue, NameByEN, "Scanner1_2 COM",
	], DefaultValue = "COM6", Description = "Scanner 1_2 COM (KeyPart)")]
	public string Scanner1_2ComPort { get; set; } = "COM6";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1_2 波特率",
		DataDefine.KeyValue, NameByEN, "Scanner1_2 BaudRate",
	], DefaultValue = 9600, Description = "Scanner 1_2 BaudRate")]
	public int Scanner1_2BaudRate { get; set; } = 9600;

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2_2 串口",
		DataDefine.KeyValue, NameByEN, "Scanner2_2 COM",
	], DefaultValue = "COM7", Description = "Scanner 2_2 COM (KeyPart)")]
	public string Scanner2_2ComPort { get; set; } = "COM7";

	[ValueInfo(Category = "连接配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2_2 波特率",
		DataDefine.KeyValue, NameByEN, "Scanner2_2 BaudRate",
	], DefaultValue = 9600, Description = "Scanner 2_2 BaudRate")]
	public int Scanner2_2BaudRate { get; set; } = 9600;

	#endregion

	[ValueInfo(Category = "点检配置 / SPOT CHECK", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "校准超时时间(小时)",
		DataDefine.KeyValue, NameByEN, "calibration timeout hours",
		DataDefine.KeyValue, NameByVI, "calibration timeout hours",
	], DefaultValue = 12, Description = "calibration timeout hours")]
	public double CalibrationTimeoutHours { get; set; } = 12;

	public static int MaterialSpaceCount { get; set; } = 5;
	public static int NozzleCount { get; set; } = 7;

	public static bool IsUsedScrewInstallDataGrid { get; set; }
	public static bool IsScrewLimitTabVisible { get; set; }
}