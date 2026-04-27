using ZC;
using ZC.Text;

namespace ZitApp.SIFS;

public struct Message7Response
{
	public bool IsOK { get; set; }
	public string? ErrorMessage { get; set; }
	public string RequestVariablePayload { get; set; }
	public string ResponseVariablePayload { get; set; }
	public string? RawContent { get; set; }

	// public
	public static Result<Message7Response> Parse(string requestPayload, MutString response)
	{
		var isOK7 = response.StartWith("OK7");
		var resp = new Message7Response();
		resp.RequestVariablePayload = requestPayload;
		if (isOK7 == false)
		{
			resp.IsOK = false;
			resp.ErrorMessage = response.ToString();
			return Result.Ok(resp);
		}

		resp.IsOK = true;
		resp.ResponseVariablePayload = response.Span[4..].ToString();
		return Result.Ok(resp);
	}

	public SifsVariableMemoryEnumerator GetVariableMemoryEnumerator()
	{
		return new SifsVariableMemoryEnumerator(
			RequestVariablePayload.AsMemory(),
			ResponseVariablePayload.AsMemory()
			);
	}

	public bool TryGetVariableMemory(ReadOnlySpan<char> name, out ReadOnlyMemory<char> value)
	{
		var enumerator = GetVariableMemoryEnumerator();
		if (enumerator.MoveNext(out var varName, out var varValue))
		{
			if (varName.Span == name)
			{
				value = varValue;
				return true;
			}
		}

		value = default;
		return false;
	}

	public bool TryGetVariable<T>(ReadOnlySpan<char> name, out T value)
		where T : ISpanParsable<T>
	{
		if (false == TryGetVariableMemory(name, out var varValue))
		{
			value = default!;
			return false;
		}

		if (false == T.TryParse(varValue.Span, null, out value!))
		{
			return false;
		}

		return true;
	}
}

// public ref struct SifsVariableMemoryEnumerator
// {
// 	// GET_PN=??? ZEBRA_DTG=??? SN_NOW_GROUP=???
// 	public ReadOnlyMemory<char> RequestVariablePayload { get; set; }
// 	// GET_PN=1005-031111-00 ZEBRA_DTG=MODEL_NAME=1005-031111,DCS=HH,TIMON=ASTEROID,GROUP_NAME=T1,T2,T3,T4-1,T4-2,T5,T6,T7,T8,T9,T10,T11,T12-1,T12-2,T14;MODEL_NAME=1005-031111-00,DCS=HH,TIMON=ASTEROID,GROUP_NAME=CCD1,CCD2,CCD3; SN_NOW_GROUP=CCD2
// 	public ReadOnlyMemory<char> ResponseVariablePayload { get; set; }
// 	public int Index { get; private set; }
// 	// RET1 = (GET_PN,1005-031111-00)
// 	// RET2 = (ZEBRA_DTG,MODEL_NAME=1005-031111,DCS=HH,TIMON=ASTEROID,GROUP_NAME=T1,T2,T3,T4-1,T4-2,T5,T6,T7,T8,T9,T10,T11,T12-1,T12-2,T14;MODEL_NAME=1005-031111-00,DCS=HH,TIMON=ASTEROID,GROUP_NAME=CCD1,CCD2,CCD3;)
// 	// RET3 = (SN_NOW_GROUP=CCD2)
// 	public bool MoveNext(out ReadOnlyMemory<char> name, out ReadOnlyMemory<char> value)
// 	{
// 	}
// }

public ref struct SifsVariableMemoryEnumerator
{
	public SifsVariableMemoryEnumerator(
		ReadOnlyMemory<char> requestVariablePayload,
		ReadOnlyMemory<char> responseVariablePayload)
	{
		RequestVariablePayload = requestVariablePayload;
		ResponseVariablePayload = responseVariablePayload;
	}

	public ReadOnlyMemory<char> RequestVariablePayload { get; set; }
	public ReadOnlyMemory<char> ResponseVariablePayload { get; set; }
	public int Index { get; private set; }

	public void Reset() => Index = 0;

	public bool MoveNext(out ReadOnlyMemory<char> name, out ReadOnlyMemory<char> value)
	{
		// 初始化输出
		name = default;
		value = default;

		if (ResponseVariablePayload.IsEmpty)
			return false;

		var span = ResponseVariablePayload.Span;

		// 如果已经到末尾，返回 false
		if (Index >= span.Length)
			return false;

		// 找下一个分隔符（空格）
		int start = Index;
		int sep = span.Slice(start).IndexOf(' ');
		int end = sep == -1 ? span.Length : start + sep;

		// 当前片段
		var segment = ResponseVariablePayload.Slice(start, end - start);

		// 更新 Index
		Index = end + 1; // 跳过空格

		// 找 '='
		var segSpan = segment.Span;
		int eq = segSpan.IndexOf('=');
		if (eq == -1)
		{
			// 没有等号，整个片段作为 name
			name = segment;
			value = ReadOnlyMemory<char>.Empty;
			return true;
		}

		name = segment.Slice(0, eq);
		value = segment.Slice(eq + 1);
		return true;
	}
}