namespace ZitApp.Ext.EapClient;

/// <summary>
/// 设备状态快照，由 PlcService / AlarmService 写入，EquipmentStatusProvider 读取。
/// </summary>
public class EquipmentStatusSnapshot
{
    private readonly object _lock = new();

    public int WorkPosition1Status { get; private set; }
    public int WorkPosition2Status { get; private set; }
    public bool HasActiveAlarm { get; private set; }
    public bool IsPlannedStop { get; private set; }

    public void UpdateWorkPosition(int pos1, int pos2)
    {
        lock (_lock)
        {
            WorkPosition1Status = pos1;
            WorkPosition2Status = pos2;
        }
    }

    public void SetAlarmState(bool hasActiveAlarm)
    {
        lock (_lock)
        {
            HasActiveAlarm = hasActiveAlarm;
        }
    }

    public void SetPlannedStop(bool isPlannedStop)
    {
        lock (_lock)
        {
            IsPlannedStop = isPlannedStop;
        }
    }
}
