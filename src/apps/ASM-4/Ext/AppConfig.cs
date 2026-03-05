using System.Net.Sockets;
using ZC.CFG;
using ZC.DB;
using ZC.DP;
using ZC.IO;
using ZC.Mvvm;
using ZC.Net.Sockets;

namespace ZitApp;

/*
 *1.4 +- 0.14 扭力
 */
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

[ObservableObject(RequiredGenerate = true)]
public partial class AppConfig : ConfigBase
{
	public const string NameByCN = "NameByCN";
	public const string NameByVI = "NameByVI";
	public const string NameByEN = "NameByEN";
	public List<DatabaseConnectionConfig> Databases { get; set; } = null!;
	public TaskServiceHostOptions TaskServiceHostOptions { get; set; } = null!;

	
	public SerialPortSocketConfig Scanner1
	{
		get => field ??= new SerialPortSocketConfig { Port = Scanner1ComPort, BaudRate = Scanner1BaudRate };
		set => SetField(ref field, value);
	}

	public SerialPortSocketConfig Scanner2
	{
		get => field ??= new SerialPortSocketConfig { Port = Scanner2ComPort, BaudRate = Scanner2BaudRate };
		set => SetField(ref field, value);
	}

	public PlcConfig Plc
	{
		get => field ??= new PlcConfig();
		set => SetField(ref field, value);
	}

	#region 连接配置

	[ValueInfo(Category = "连接配置", Link = nameof(Plc), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Plc IP",
		DataDefine.KeyValue, NameByEN, "Plc IP",
		DataDefine.KeyValue, NameByVI, "Plc IP",
	], DefaultValue = "192.168.1.10", Description = "Plc IPAddress")]
	public string PlcIpAddress { get; set; } = "192.168.1.10";

	[ValueInfo(Category = "连接配置", Link = nameof(Plc), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Plc Port",
		DataDefine.KeyValue, NameByEN, "Plc Port",
		DataDefine.KeyValue, NameByVI, "Plc Port",
	], DefaultValue = 502, Description = "Plc Port")]
	public int PlcPort { get; set; } = 502;


	[ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 IP",
		DataDefine.KeyValue, NameByEN, "Scanner1 IP",
		DataDefine.KeyValue, NameByVI, "Scanner1 Port",
	], Description = "Scanner 1 Port", DefaultValue = "COM5")]
	public string Scanner1ComPort { get; set; } = "COM5";

	[ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪1 Port",
		DataDefine.KeyValue, NameByEN, "Scanner1 Port",
		DataDefine.KeyValue, NameByVI, "Scanner1 Port",
	], DefaultValue = 9600, Description = "Scanner 1 Port")]
	public int Scanner1BaudRate { get; set; } = 9600;


	[ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 IP",
		DataDefine.KeyValue, NameByEN, "Scanner2 IP",
		DataDefine.KeyValue, NameByVI, "Scanner2 Port",
	], DefaultValue = "COM5", Description = "Scanner 2 Port")]
	public string Scanner2ComPort { get; set; } = "COM5";

	[ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "扫码枪2 Port",
		DataDefine.KeyValue, NameByEN, "Scanner2 Port",
		DataDefine.KeyValue, NameByVI, "Scanner2 Port",
	], DefaultValue = 9600, Description = "Scanner 2 Port")]
	public int Scanner2BaudRate { get; set; } = 9600;

	#endregion
}