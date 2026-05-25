using SqlSugar;

namespace ZitApp.Models;

[SugarTable("ng_record")]
public class NgRecord
{
	[SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "station_id", IsNullable = false)]
	public int StationId { get; set; }

	[SugarColumn(ColumnName = "station_name", IsNullable = false)]
	public string StationName { get; set; } = "";

	[SugarColumn(ColumnName = "sn_code", IsNullable = false)]
	public string SnCode { get; set; } = "";

	[SugarColumn(ColumnName = "key_part_code", IsNullable = true)]
	public string KeyPartCode { get; set; } = "";

	[SugarColumn(ColumnName = "model_name", IsNullable = true)]
	public string ModelName { get; set; } = "";

	[SugarColumn(ColumnName = "error_message", IsNullable = true, ColumnDataType = "text")]
	public string? ErrorMessage { get; set; }

	[SugarColumn(ColumnName = "ng_items", IsNullable = true, ColumnDataType = "text")]
	public string NgItems { get; set; } = "";

	[SugarColumn(ColumnName = "create_time", IsNullable = false)]
	public DateTime CreateTime { get; set; }
}
