using ZC.Identity;

namespace ZitApp.Models;

using System.ComponentModel.DataAnnotations;
using SqlSugar;

[SugarTable("identity_account", "identity account | 认证的账户")]
public class ZitAccount : IIdentityAccount
{
	[SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "integer")]
	public long Id { get; set; }

	[SugarColumn(ColumnName = "group_id", IsNullable = false)]
	public int GroupId { get; set; }

	[Display(Name = "用户名1", Description = "用户名称", Order = 1, AutoGenerateField = false)]
	[SugarColumn(ColumnName = "identity_name", IsNullable = false)]
	public string IdentityName { get; set; } = null!;

	[Display(Name = "用户名", Description = "用户名称", Order = 1)]
	[SugarColumn(ColumnName = "name", IsNullable = false)]
	public string Name { get; set; } = "";

	[SugarColumn(ColumnName = "status_code", IsNullable = false)]
	public int StatusCode { get; set; }

	[SugarColumn(ColumnName = "security_key", IsNullable = false)]
	public string SecurityKey { get; set; } = null!;

	[SugarColumn(ColumnName = "role_flags", IsNullable = false)]
	public long RoleFlags { get; set; }

	[SugarColumn(ColumnName = "comment", IsNullable = true)]
	public string? Comment { get; set; }

	[SugarColumn(IsIgnore = true)] public string? DisplayName { get; set; }

	[SugarColumn(IsIgnore = true, IsNullable = true)]
	public object? Context { get; set; }
}