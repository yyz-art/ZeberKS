using System.Text.Json.Nodes;
using Newtonsoft.Json;
using SqlSugar;

namespace OinetApp.Services.Internal.Log;

[SugarTable("logs")]
[SugarIndex("idx_log_time", nameof(Time), OrderByType.Asc)]
[SugarIndex("idx_log_level", nameof(Level), OrderByType.Asc)]
[SugarIndex("idx_log_logger", nameof(Logger), OrderByType.Asc)]
public class LogRecord
{
	[SugarColumn(ColumnName = "time", ColumnDescription = "时间", IsNullable = false)]
	public DateTime Time { get; set; }

	[SugarColumn(ColumnName = "level", ColumnDescription = "等级", IsNullable = false)]
	public char Level { get; set; }

	[SugarColumn(ColumnName = "logger", ColumnDescription = "记录器", IsNullable = false)]
	public string Logger { get; set; } = null!;
	[SugarColumn(ColumnName = "fmt_msg", ColumnDescription = "格式化消息", IsNullable = true)]
	public string? FormattedMessage { get; set; }

	[SugarColumn(ColumnName = "err", ColumnDescription = "异常", IsNullable = true)]
	public string? Error { get; set; }
	
	[SugarColumn(ColumnName = "msg", ColumnDescription = "消息", IsNullable = true)]
	public string? Message { get; set; }

	[SugarColumn(ColumnName = "props", IsJson = true, ColumnDescription = "属性", IsNullable = true)]
	public Dictionary<string, object?>? Properties { get; set; }
}