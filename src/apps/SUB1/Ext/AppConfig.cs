using System.Net.Sockets;
using System.Text.Json.Serialization;
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
public partial class AppConfig : CommonAppConfig
{

    public AppConfig()
    {
        StationName = "SUB1-AUTO";
    }

    [ValueInfo(Category = "生产配置", InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "工号",
       DataDefine.KeyValue, NameByEN, "Work No",
       DataDefine.KeyValue, NameByVI, "Work No",
    ], DefaultValue = "M000086", Description = "工号")]
    public string WorkNo { get; set; } = "M000086";

    public List<DatabaseConnectionConfig> Databases { get; set; } = null!;
    public TaskServiceHostOptions TaskServiceHostOptions { get; set; } = null!;

    [JsonIgnore]
    public SerialPortSocketConfig Scanner1
    {
       // 确保初始化时拿到最新的值
       get => field ??= new SerialPortSocketConfig { Port = Scanner1ComPort, BaudRate = Scanner1BaudRate };
       set => SetField(ref field, value);
    }
    
    [JsonIgnore]
    public SerialPortSocketConfig Scanner2
    {
       get => field ??= new SerialPortSocketConfig { Port = Scanner2ComPort, BaudRate = Scanner2BaudRate };
       set => SetField(ref field, value);
    }
    
    [JsonIgnore]
    public PlcConfig Plc
    {
       get => field ??= new PlcConfig { IpAddress = PlcIpAddress, Port = PlcPort };
       set => SetField(ref field, value);
    }

    #region 连接配置

    [ValueInfo(Category = "连接配置", Link = nameof(Plc), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "Plc IP",
       DataDefine.KeyValue, NameByEN, "Plc IP",
       DataDefine.KeyValue, NameByVI, "Plc IP",
    ], DefaultValue = "192.168.1.50", Description = "Plc IPAddress")]
    public string PlcIpAddress 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Plc.IpAddress = value;
        }
    } = "192.168.1.50";

    [ValueInfo(Category = "连接配置", Link = nameof(Plc), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "Plc Port",
       DataDefine.KeyValue, NameByEN, "Plc Port",
       DataDefine.KeyValue, NameByVI, "Plc Port",
    ], DefaultValue = 502, Description = "Plc Port")]
    public int PlcPort 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Plc.Port = value;
        }
    } = 502;

    [ValueInfo(Category = "连接配置", Link = nameof(Scanner1), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "扫码枪1 串口",
       DataDefine.KeyValue, NameByEN, "Scanner1 COM",
       DataDefine.KeyValue, NameByVI, "Scanner1 COM",
    ], Description = "Scanner 1 COM", DefaultValue = "COM5")]
    public string Scanner1ComPort 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Scanner1.Port = value;
        }
    } = "COM5";

    [ValueInfo(Category = "连接配置", Link = nameof(Scanner1), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "扫码枪1 Port",
       DataDefine.KeyValue, NameByEN, "Scanner1 Port",
       DataDefine.KeyValue, NameByVI, "Scanner1 Port",
    ], DefaultValue = 9600, Description = "Scanner 1 Port")]
    public int Scanner1BaudRate 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Scanner1.BaudRate = value;
        }
    } = 9600;

    [ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "扫码枪2 串口",
       DataDefine.KeyValue, NameByEN, "Scanner2 COM",
       DataDefine.KeyValue, NameByVI, "Scanner2 COM",
    ], DefaultValue = "COM5", Description = "Scanner 2 COM")]
    public string Scanner2ComPort 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Scanner2.Port = value;
        }
    } = "COM5";

    [ValueInfo(Category = "连接配置", Link = nameof(Scanner2), InitAttachData =
    [
       DataDefine.KeyValue, NameByCN, "扫码枪2 Port",
       DataDefine.KeyValue, NameByEN, "Scanner2 Port",
       DataDefine.KeyValue, NameByVI, "Scanner2 Port",
    ], DefaultValue = 9600, Description = "Scanner 2 Port")]
    public int Scanner2BaudRate 
    { 
        get => field; 
        set 
        {
            if (SetField(ref field, value)) Scanner2.BaudRate = value;
        }
    } = 9600;

    #endregion
    
}
