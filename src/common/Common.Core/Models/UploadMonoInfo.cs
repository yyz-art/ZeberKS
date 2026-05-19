namespace ZitApp.Models;

public class MaterialConfig
{
	public int Id { get; set; }
	public bool IsUsed { get; set; } = true;
	public string PositionName { get; set; } = null!;
	public string PositionCode { get; set; } = null!;

	public string[] MaterialCodes { get; set; } = new string[4];
	public string Description { get; set; } = "";
	public int AlarmRemainCount { get; set; }
	public int DefaultReplaceCount { get; set; }

	public IEnumerable<string> EnumerateAllowedMaterialCodes() =>
		MaterialCodes.Where(c => !string.IsNullOrWhiteSpace(c)).Select(c => c.Trim());

	public bool AllowsMaterialCode(string? code)
	{
		if (string.IsNullOrWhiteSpace(code)) return false;
		var trimmed = code.Trim();
		return EnumerateAllowedMaterialCodes().Contains(trimmed, StringComparer.Ordinal);
	}
}