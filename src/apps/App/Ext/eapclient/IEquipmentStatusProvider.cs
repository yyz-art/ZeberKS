namespace ZitApp.Ext.EapClient;

/// <summary>
/// 设备状态查询接口，供 EAP 上报时获取当前设备状态。
/// </summary>
public interface IEquipmentStatusProvider
{
    EquipmentStatus GetCurrentStatus();
}
