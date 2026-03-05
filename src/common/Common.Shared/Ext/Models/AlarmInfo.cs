namespace ZitApp.Models;

public class AlarmInfo
{
	public DateTime Time { get; set; }
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public int Value { get; set; }
}