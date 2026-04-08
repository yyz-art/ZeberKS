using SqlSugar;

namespace ZitApp.Models;

public enum AlarmStatus
{
	ON, OFF
}
[SugarTable("alarm_rd1")]
public class AlarmRecord
{
	[SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "alarm_id", IsNullable = false)]
	public int AlarmId { get; set; }
	[SugarColumn(ColumnName = "name", IsNullable = false)]
	public string Name { get; set; } = string.Empty;

	[SugarColumn(ColumnName = "start_time", IsNullable = false)]
	public DateTime StartTime { get; set; }

	[SugarColumn(ColumnName = "end_time", IsNullable = false)]
	public DateTime EndTime { get; set; }

	[SugarColumn(ColumnName = "status", IsNullable = false)]
	public AlarmStatus Status { get; set; }
	
	[SugarColumn(ColumnName = "operator", IsNullable = true)]
	public string? Operator { get; set; }
}