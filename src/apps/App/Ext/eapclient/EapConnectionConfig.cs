namespace ZitApp.Ext.EapClient;

/// <summary>
/// EAP 设备通讯配置
/// </summary>
public class EapConnectionConfig
{
    public bool Enabled { get; set; } = true;
    public string Host { get; set; } = "127.0.0.1";
    public int Port { get; set; } = 5005;
    public int ReconnectDelay { get; set; } = 5000;
    public int BufferSize { get; set; } = 102400;
}
