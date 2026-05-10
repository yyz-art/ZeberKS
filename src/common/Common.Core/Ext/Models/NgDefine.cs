namespace ZitApp.Models;

public class NgDefine
{
	public int Id { get; set; }
	public string Sender { get; set; } = null!;
	public string Name { get; set; } = null!;
	public string Reason { get; set; } = null!;
	public string Description { get; set; } = null!;
}