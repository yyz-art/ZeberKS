using ZC;
using ZC.Text;

namespace ZitApp.SIFS;

public ref struct SifsRequest
{
	public SifsRequest()
	{
	}

	public SifsRequest(ReadOnlySpan<char> stationName, ReadOnlySpan<char> sn, ReadOnlySpan<char> messageType,
		ReadOnlySpan<char> operatorID, ReadOnlySpan<char> line, ReadOnlySpan<char> result, ReadOnlySpan<char> errorCode,
		ReadOnlySpan<char> payload, ReadOnlySpan<char> workorderNumber)
	{
		StationName = stationName;
		SN = sn;
		MessageType = messageType;
		OperatorID = operatorID;
		Line = line;
		Result = result;
		ErrorCode = errorCode;
		Payload = payload;
		WorkorderNumber = workorderNumber;
	}

	public ReadOnlySpan<char> StationName;
	public ReadOnlySpan<char> SN;
	public ReadOnlySpan<char> MessageType;
	public ReadOnlySpan<char> OperatorID;
	public ReadOnlySpan<char> Line;
	public ReadOnlySpan<char> Result;
	public ReadOnlySpan<char> ErrorCode;
	public ReadOnlySpan<char> Payload;
	public ReadOnlySpan<char> WorkorderNumber;

	public Result<MutString> Build(MutString buffer)
	{
		buffer.Clear();
		buffer.Append(StationName).Append(',');
		buffer.Append(SN).Append(',');
		buffer.Append(MessageType).Append(',');
		buffer.Append(OperatorID).Append(',');
		buffer.Append(Line).Append(",,");
		buffer.Append(Result).Append(",,");
		buffer.Append(ErrorCode).Append(',');
		buffer.Append(Payload);
		// if (WorkorderNumber.IsEmpty == false)
		// 	buffer.Append(WorkorderNumber);
		return ZC.Result.Ok(buffer);
	}
}

public static class SifsUtils
{
}