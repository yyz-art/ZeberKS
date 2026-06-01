namespace ZitApp.Ext.EapClient;

/// <summary>
/// 当前处于触发状态的 PLC 报警快照，供 S5F1 解除上报时携带开始时间。
/// </summary>
public sealed class EapActiveAlarmRegistry
{
    private readonly object _lock = new();
    private readonly Dictionary<int, EapActiveAlarmEntry> _byBitIndex = new();

    public void SetActive(int bitIndex, int alarmId, string alarmName, DateTime startTime)
    {
        lock (_lock)
        {
            _byBitIndex[bitIndex] = new EapActiveAlarmEntry(alarmId, alarmName, startTime);
        }
    }

    public bool TryClear(int bitIndex, out EapActiveAlarmEntry? entry)
    {
        lock (_lock)
        {
            if (_byBitIndex.Remove(bitIndex, out var removed))
            {
                entry = removed;
                return true;
            }

            entry = null;
            return false;
        }
    }
}

public sealed record EapActiveAlarmEntry(int AlarmId, string AlarmName, DateTime StartTime);
