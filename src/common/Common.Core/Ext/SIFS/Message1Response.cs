using ZC;
using ZC.Text;

namespace ZitApp.SIFS;

public struct Message1Response
{
	public bool IsOK { get; set; }
	public int Rework { get; set; }
	public string Retest { get; set; }
	public string? RawContent { get; set; }

	public static Result<Message1Response> Parse(MutString content)
	{
		var isOK1 = content.StartWith("OK1");
		var reworkValueRange = content.FindRange("REWORK=", " ");
		if (reworkValueRange is null)
			return Result.Err<Message1Response>("response error! REWORK not found");
		if (false == int.TryParse(content.Span[reworkValueRange.Value], out var rework))
			return Result.Err<Message1Response>("response error! REWORK format error");

		var retestValueRange = content.FindRange("RETEST=", "");
		if (retestValueRange is null)
			return Result.Err<Message1Response>("response error! RETEST not found");
		var retest = content.Span[retestValueRange.Value];
		var resp = new Message1Response();
		resp.IsOK = isOK1;
		if (isOK1 == false)
			resp.RawContent = content.ToString();
		resp.Retest = retest.ToString();
		resp.Rework = rework;
		return Result.Ok(resp);
	}
}