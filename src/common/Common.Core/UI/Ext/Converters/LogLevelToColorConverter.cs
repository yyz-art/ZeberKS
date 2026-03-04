using System.Globalization;
using Avalonia.Data.Converters;

namespace ZitApp.UI.Converters;

public class LogLevelToConverter : KeyValueMapConverter
{
	public object? Info { get; set; }
	public object? Error { get; set; }
	public object? Warning { get; set; }
	public object? Debug { get; set; }
	public object? Trace { get; set; }
	public object? Fatal { get; set; }

	public LogLevelToConverter()
	{
		OnInitialize();
	}

	protected object? GetInfoValue(object? parameter) => Info;
	protected object? GetErrorValue(object? parameter) => Error;
	protected object? GetWarningValue(object? parameter) => Warning;
	protected object? GetDebugValue(object? parameter) => Debug;
	protected object? GetTraceValue(object? parameter) => Trace;
	protected object? GetFatalValue(object? parameter) => Fatal;

	void OnInitialize()
	{
		// Info
		this["Information"] = this["information"] =
			this["INFO"] = this["Info"] = this["info"] =
				this["I"] = this["i"] = (Func<object?, object?>)GetInfoValue;

		// Error
		this["Error"] = this["error"] =
			this["ERR"] = this["Err"] = this["err"] =
				this["E"] = this["e"] = (Func<object?, object?>)GetErrorValue;

		// Warning
		this["Warning"] = this["warning"] =
			this["WARN"] = this["Warn"] = this["warn"] =
				this["W"] = this["w"] = (Func<object?, object?>)GetWarningValue;

		// Debug
		this["Debug"] = this["debug"] =
			this["DBG"] = this["Dbg"] = this["dbg"] =
				this["D"] = this["d"] = (Func<object?, object?>)GetDebugValue;

		// Trace
		this["Trace"] = this["trace"] =
			this["TRC"] = this["Trc"] = this["trc"] =
				this["T"] = this["t"] = (Func<object?, object?>)GetTraceValue;

		// Fatal
		this["Fatal"] = this["fatal"] =
			this["FATAL"] = this["FatalError"] = this["fatalerror"] =
				this["F"] = this["f"] = (Func<object?, object?>)GetFatalValue;
	}
}

public class KeyValueMapConverter : Dictionary<string, object?>, IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		var level = value?.ToString() ?? "default";
		TryGetValue(level, out var result);
		if (result is Func<object?, object?> func)
		{
			return func(parameter);
		}

		return result;
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}
}