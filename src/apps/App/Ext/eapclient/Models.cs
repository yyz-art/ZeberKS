namespace ZitApp.Ext.EapClient;

public enum EquipmentStatus
{
    Run,
    Idle,
    Alarm
}

/// <summary>
/// EAP 数据报告变量 ID 定义（S1F4 / S1F12 / S6F11 共用）
/// </summary>
public static class EapReportIds
{
    // ===== 公共基础字段 =====
    /// <summary>1001 - 设备状态</summary>
    public const string EquipmentStatusId = "1001";
    /// <summary>1002 - 生产数量</summary>
    public const string ProductionCount = "1002";
    /// <summary>1003 - 良率</summary>
    public const string YieldRate = "1003";
    /// <summary>1004 - CT（节拍）</summary>
    public const string CycleTime = "1004";
    /// <summary>1005 - OK/NG</summary>
    public const string OkNg = "1005";

    // ===== 6002 产品过站扩展字段 =====
    /// <summary>1006 - 工单号</summary>
    public const string WorkOrderNo = "1006";
    /// <summary>1007 - SN码</summary>
    public const string SnCode = "1007";
    /// <summary>1008 - KeyPart码</summary>
    public const string KeyPartCode = "1008";
    /// <summary>1009 - 机种型号</summary>
    public const string ModelName = "1009";
    /// <summary>1010 - 工号</summary>
    public const string WorkerNo = "1010";
    /// <summary>1011 - 站点名</summary>
    public const string StationName = "1011";
    /// <summary>1012 - 线别</summary>
    public const string Line = "1012";
    /// <summary>1013 - 配方名</summary>
    public const string RecipeName = "1013";
    /// <summary>1014 - 错误信息</summary>
    public const string ErrorMessage = "1014";

    // ===== 螺丝数据（ASM15_1: 1015~1046）=====
    /// <summary>螺丝扭矩起始 ID（1015=螺丝1扭矩，1016=螺丝2扭矩...）</summary>
    public const int ScrewTorqueStart = 1015;
    /// <summary>螺丝圈数起始 ID（1031=螺丝1圈数，1032=螺丝2圈数...）</summary>
    public const int ScrewTurnsStart = 1031;

    /// <summary>获取螺丝扭矩 ID 字符串，如 "1015"</summary>
    public static string ScrewTorqueId(int screwIndex) => (ScrewTorqueStart + screwIndex).ToString();
    /// <summary>获取螺丝圈数 ID 字符串，如 "1031"</summary>
    public static string ScrewTurnsId(int screwIndex) => (ScrewTurnsStart + screwIndex).ToString();
}
