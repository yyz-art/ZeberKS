using ZC.Text;

namespace ZitApp.SIFS;

public class SifsPayloadBuilder
{
	public MutString Content => field ??= new MutString();

	public SifsPayloadBuilder AddVariable<T>(ReadOnlySpan<char> name, T value, T minValue, T maxValue)
		where T : ISpanFormattable
	{
		if (Content.Length != 0)
			Content.Append(" ");
		Content.Append("\"[VR]")
			.Append(name).Append("='").Append(value).Append("';")
			.Append(minValue).Append(';').Append(maxValue).Append('"');
		return this;
	}

	public SifsPayloadBuilder AddVariable<T>(ReadOnlySpan<char> name, T value)
		where T : ISpanFormattable
	{
		if (Content.Length != 0)
			Content.Append(" ");
		Content.Append("\"[VR]")
			.Append(name).Append("='").Append(value).Append("'");
		return this;
	}

	public SifsPayloadBuilder AddVariable(ReadOnlySpan<char> name, ReadOnlySpan<char> value)
	{
		if (Content.Length != 0)
			Content.Append(" ");
		Content.Append("\"[VR]")
			.Append(name).Append("='").Append(value).Append("'");
		return this;
	}

	public SifsPayloadBuilder AddVariable(ReadOnlySpan<char> name, ReadOnlySpan<char> value,
		ReadOnlySpan<char> minValue,
		ReadOnlySpan<char> maxValue)
	{
		if (Content.Length != 0)
			Content.Append(" ");
		Content.Append("\"[VR]")
			.Append(name).Append("='").Append(value).Append("';")
			.Append(minValue).Append(';').Append(maxValue).Append('"');
		return this;
	}

	public SifsPayloadBuilder AddGetVariable(ReadOnlySpan<char> name)
	{
		if (Content.Length != 0)
			Content.Append(" ");
		Content.Append(name).Append("=???");
		return this;
	}
}