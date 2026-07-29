using System.Net.Sockets;
using System.Text.Json.Serialization;
using ZC.CFG;
using ZC.DB;
using ZC.DP;
using ZC.IO;
using ZC.Mvvm;
using ZC.Net.Sockets;
using ZitApp.Models;

namespace ZitApp;

[ObservableObject(RequiredGenerate = true)]
public partial class AppConfig : CommonAppConfig
{
	public int PrintClearDelay { get; set; } = 3000;
	public int PrintEndWithMode { get; set; } = 1;
	public int PrintDelay { get; set; } = 1000;
	public int PrintInputMode { get; set; } = 1;
	public AppConfig()
	{
#if ASM4
		ApplicationName = StationName = "ASM3-AUTO";
		MaterialSpaceCount = 4;
		NozzleCount = 8;
#elif SUB1
		ApplicationName = StationName = "SUB1-AUTO";
		MaterialSpaceCount = 4;
		NozzleCount = 4;
#elif ASM12
		ApplicationName = StationName = "ASM12-AUTO";
		MaterialSpaceCount = 6;
		NozzleCount = 12;
#elif ASM15_1
		ApplicationName = StationName = "ASM15-1-AUTO";
		MaterialSpaceCount = 2;
		NozzleCount = 0;
		IsUsedScrewInstallDataGrid = true;
		IsScrewLimitTabVisible = true;
		ScrewLimitConfigs = new List<ScrewLimitConfig>();
		for (int i = 1; i <= 16; i++)
		{
			ScrewLimitConfigs.Add(new ScrewLimitConfig { ScrewNo = i });
		}
#elif ASM15_2
   	ApplicationName = StationName = "ASM15-2-AUTO";
   	MaterialSpaceCount = 3;
   	NozzleCount = 4;
#elif MFG15
		ApplicationName = StationName = "MFG-AUTO";
		MaterialSpaceCount = 2;
		NozzleCount = 1;
#endif
	}

	public partial List<NgDefine> NgDefines { get; set; }

#if ASM15_1
	public partial List<ScrewLimitConfig> ScrewLimitConfigs { get; set; }
#endif


#if ASM15_1
	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "螺丝枪1 IP",
		DataDefine.KeyValue, NameByEN, "Screw1 IP",
		DataDefine.KeyValue, NameByVI, "Screw1 IP",
	], DefaultValue = "192.168.1.65", Description = "SCREW 1 IPAddress")]
	public string Screw1IpAddress { get; set; } = "192.168.1.65";

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "螺丝枪1 Port",
		DataDefine.KeyValue, NameByEN, "Screw1 Port",
		DataDefine.KeyValue, NameByVI, "Screw1 Port",
	], DefaultValue = 502, Description = "SCREW 1 Port")]
	public int Screw1Port { get; set; } = 502;

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "螺丝枪2 IP",
		DataDefine.KeyValue, NameByEN, "Screw2 IP",
		DataDefine.KeyValue, NameByVI, "Screw2 IP",
	], DefaultValue = "192.168.1.66", Description = "SCREW 2 IPAddress")]
	public string Screw2IpAddress { get; set; } = "192.168.1.66";

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "螺丝枪2 Port",
		DataDefine.KeyValue, NameByEN, "Screw2 Port",
		DataDefine.KeyValue, NameByVI, "Screw2 Port",
	], DefaultValue = 502, Description = "SCREW 2 Port")]
	public int Screw2Port { get; set; } = 502;

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "校准仪1 IP",
		DataDefine.KeyValue, NameByEN, "Calibration1 IP",
	], DefaultValue = "192.168.1.210", Description = "Calibration1 Device IP")]
	public string Calibration1IpAddress { get; set; } = "192.168.1.210";

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "校准仪1 Port",
		DataDefine.KeyValue, NameByEN, "Calibration1 Port",
	], DefaultValue = 502, Description = "Calibration1 Device Port")]
	public int Calibration1Port { get; set; } = 502;
	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "校准仪2 IP",
		DataDefine.KeyValue, NameByEN, "Calibration2 IP",
	], DefaultValue = "192.168.1.211", Description = "Calibration2 Device IP")]
	public string Calibration2IpAddress { get; set; } = "192.168.1.211";

	[ValueInfo(Category = "连接配置/Connection Configuration", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "校准仪2 Port",
		DataDefine.KeyValue, NameByEN, "Calibration2 Port",
	], DefaultValue = 502, Description = "Calibration2 Device Port")]
	public int Calibration2Port { get; set; } = 502;


	[ValueInfo(Category = "UPPER/LOW LIMIT", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "ScrewTorqueLowLimit",
		DataDefine.KeyValue, NameByEN, "ScrewTorqueLowLimit",
		DataDefine.KeyValue, NameByVI, "ScrewTorqueLowLimit",
	], DefaultValue = 502, Description = "ScrewTorqueLowLimit")]
	public double ScrewTorqueLowLimit { get; set; }
	
	
	[ValueInfo(Category = "UPPER/LOW LIMIT", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "ScrewTorqueUpperLimit",
		DataDefine.KeyValue, NameByEN, "ScrewTorqueUpperLimit",
		DataDefine.KeyValue, NameByVI, "ScrewTorqueUpperLimit",
	], DefaultValue = 502, Description = "ScrewTorqueUpperLimit")]
	public double ScrewTorqueUpperLimit { get; set; }
	
	[ValueInfo(Category = "UPPER/LOW LIMIT", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "ScrewTurnsLowLimit",
		DataDefine.KeyValue, NameByEN, "ScrewTurnsLowLimit",
		DataDefine.KeyValue, NameByVI, "ScrewTurnsLowLimit",
	], DefaultValue = 502, Description = "ScrewTurnsLowLimit")]
	public double ScrewTurnsLowLimit { get; set; }
	
	
	[ValueInfo(Category = "UPPER/LOW LIMIT",  InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "ScrewTurnsUpperLimit",
		DataDefine.KeyValue, NameByEN, "ScrewTurnsUpperLimit",
		DataDefine.KeyValue, NameByVI, "ScrewTurnsUpperLimit",
	], DefaultValue = 502, Description = "ScrewTurnsUpperLimit")]
	public double ScrewTurnsUpperLimit { get; set; }
#endif
}