namespace ZitApp.Ext.EapClient;

public enum EquipmentStatus
{
    /// <summary>E0001 - 机台运行（工位在生产）</summary>
    E0001,
    /// <summary>E4001 - 等待物料（两个工位空闲）</summary>
    E4001,
    /// <summary>E4002 - 机台停止（报警触发）</summary>
    E4002,
    /// <summary>E5001 - 机台排停</summary>
    E5001,
}

/// <summary>
/// EAP 数据报告变量 ID 定义（S1F4 / S1F12 / S6F11 共用）
/// </summary>
public static class EapReportIds
{
    /// <summary>1001 - 设备状态</summary>
    public const string EquipmentStatus = "1001";
    /// <summary>1002 - 输入</summary>
    public const string Input = "1002";
    /// <summary>1003 - 输出</summary>
    public const string Output = "1003";
    /// <summary>1004 - CT（节拍）</summary>
    public const string CT = "1004";
    /// <summary>1005 - 工单号</summary>
    public const string WorkOrder = "1005";
    /// <summary>1006 - 机种型号</summary>
    public const string ModelName = "1006";
    /// <summary>1007 - 产品SN</summary>
    public const string ProductSN = "1007";
    /// <summary>1008 - 轨道编号</summary>
    public const string LaneNo = "1008";
    /// <summary>1009 - 良率</summary>
    public const string Yield = "1009";
}
