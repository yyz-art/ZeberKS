using NLog;
using NLog.Targets;

namespace OinetApp.Services.Internal.Log;

[Target(nameof(LogTarget))]
public class LogTarget : TargetWithLayout
{
	public static LogService? LogService { get; set; } = App.Current.IOC.Get<LogService>();

	protected override void Write(LogEventInfo logEvent)
	{
		LogService?.OnLog(logEvent);
	}
}