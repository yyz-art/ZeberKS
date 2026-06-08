namespace ZitApp.Ext.EapClient;

/// <summary>
/// 设备状态提供者：从快照读取，不直接依赖 PlcService / AlarmService。
/// </summary>
public class EquipmentStatusProvider : IEquipmentStatusProvider
{
    private readonly EquipmentStatusSnapshot _snapshot;

    public EquipmentStatusProvider(EquipmentStatusSnapshot snapshot)
    {
        _snapshot = snapshot;
    }

    public EquipmentStatus GetCurrentStatus()
    {
        if (_snapshot.HasActiveAlarm)
            return EquipmentStatus.E4002;

        if (_snapshot.IsPlannedStop)
            return EquipmentStatus.E5001;

        if (_snapshot.WorkPosition1Status == 1 || _snapshot.WorkPosition2Status == 1)
            return EquipmentStatus.E0001;

        return EquipmentStatus.E4001;
    }
}
