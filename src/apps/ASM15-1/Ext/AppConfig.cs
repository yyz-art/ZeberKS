using System.Net.Sockets;
using ZC.CFG;
using ZC.DB;
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
	public List<DatabaseConnectionConfig> Databases { get; set; } = null!;
	public TaskServiceHostOptions TaskServiceHostOptions { get; set; } = null!;

	public ScrewMachineConfig Screw1
	{
		get => field ??= new ScrewMachineConfig();
		set => SetField(ref field, value);
	}

	public ScrewMachineConfig Screw2
	{
		get => field ??= new ScrewMachineConfig();
		set => SetField(ref field, value);
	}

	public SerialPortSocketConfig Scanner1
	{
		get => field ??= new SerialPortSocketConfig();
		set;
	}

	public SerialPortSocketConfig Scanner2
	{
		get => field ??= new SerialPortSocketConfig();
		set;
	}

	public PlcConfig Plc
	{
		get => field ??= new PlcConfig();
		set => SetField(ref field, value);
	}
}