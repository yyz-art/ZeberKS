using ZitApp.Ext.EapClient;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(AlarmServiceBase)])]
public class AlarmService : AlarmServiceBase
{
    public required EapClientService EapClient { get; init; }
    public required EquipmentStatusSnapshot StatusSnapshot { get; init; }
    public required IEquipmentStatusProvider StatusProvider { get; init; }

    private int _activeAlarmCount;
    private EquipmentStatus _lastReportedStatus = EquipmentStatus.E4001;

    /// <summary>
    /// 隐藏基类 PushAlarm，在报警处理链路中增加 EAP 客户端上报 + 状态快照更新。
    /// PlcService 引用的是 AlarmService（具体类型），所以 new 生效。
    /// </summary>
    public new void PushAlarm(object? sender, object alarm, object? args)
    {
        base.PushAlarm(sender, alarm, args);

        if (alarm is not AlarmInfo alarmInfo)
            return;

        var isOn = alarmInfo.Value == 1;
        if (isOn)
            Interlocked.Increment(ref _activeAlarmCount);
        else
            Interlocked.Decrement(ref _activeAlarmCount);

        StatusSnapshot.SetAlarmState(_activeAlarmCount > 0);
    }

    protected override void OnAlarmReported(AlarmRecord record)
    {
        _ = EapClient.TrySendAlarmReportAsync(record);
    }

    protected override async Task Main(CancellationToken ctk)
    {
        // 并行执行：基类主循环（DB + 服务端 EAP）+ EAP 客户端上报
        var baseTask = base.Main(ctk);
        var eapTask = RunEapReportLoopAsync(ctk);

        await Task.WhenAll(baseTask, eapTask);
    }

    private async Task RunEapReportLoopAsync(CancellationToken ctk)
    {
        // 启动时同步当前状态，避免误报
        _lastReportedStatus = StatusProvider.GetCurrentStatus();

        while (!ctk.IsCancellationRequested)
        {
            // 检测设备状态变化，触发 S6F11/6001
            var currentStatus = StatusProvider.GetCurrentStatus();
            if (currentStatus != _lastReportedStatus)
            {
                _lastReportedStatus = currentStatus;
                _ = EapClient.TrySendStatusChangeReportAsync(currentStatus, cancellationToken: ctk);
            }

            await Task.Delay(200, ctk);
        }
    }
}
