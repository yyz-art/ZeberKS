using ZC;
using ZC.Text;

namespace ZitApp.SIFS;

public struct Message2Response
{
	public bool IsOK { get; set; }
	public string? ErrorMessage { get; set; }

	public static Result<Message2Response> Parse(MutString content)
	{
		var isOK2 = content.StartWith("OK2");
		var resp = new Message2Response();
		if (isOK2 == false)
		{
			resp.IsOK = false;
			resp.ErrorMessage = content.ToString();
			return Result.Ok(resp);
		}

		resp.IsOK = true;

		return Result.Ok(resp);
	}
}