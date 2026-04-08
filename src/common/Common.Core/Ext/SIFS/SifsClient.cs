using System.Text;
using ZC;
using ZC.EasyIO;
using ZC.IFS.Connection;
using ZC.IO;
using ZC.Net.Sockets;
using ZC.Text;
using ZitApp.Utils;

namespace ZitApp.SIFS;

public class SifsClient
{
	private MutString _buffer;
	public INetworkSocketConfig? ConnectionConfig { get; set; }

	public SifsClient(INetworkSocketConfig connectionConfig)
	{
		ConnectionConfig = connectionConfig;
		_buffer = new MutString();
		Socket = new NetworkSocket(ConnectionConfig);
	}

	public IDataSocket? Socket { get; private set; }

	public Result Open()
	{
		if (Socket is null)
		{
			if (ConnectionConfig is null)
				return Result.Err("Connection config is null");
			Socket ??= new NetworkSocket(ConnectionConfig);
		}

		var openResult = Socket.Open();
		Socket = null;
		return openResult;
	}

	public Result Close()
	{
		if (Socket is null || Socket is { IsOpen: false })
			return Result.OK;
		Socket?.Close();
		Socket = null;
		return Result.OK;
	}

	public Result<Message7Response> SendMessage7(SifsRequest request, SifsPayloadBuilder payload)
	{
		request.MessageType = "7";
		var sendResult = SendRequest(request, payload);
		if (sendResult.IsError())
			return Result.Err<Message7Response>(sendResult);
		return Message7Response.Parse(payload!.Content.ToString(), _buffer);
	}

	public Result<Message2Response> SendMessage2(SifsRequest request, SifsPayloadBuilder? payload)
	{
		request.MessageType = "2";
		var sendResult = SendRequest(request, payload);
		if (sendResult.IsError())
			return Result.Err<Message2Response>(sendResult);
		return Message2Response.Parse(_buffer);
	}

	public Result<Message1Response> SendMessage1(SifsRequest request)
	{
		request.MessageType = "1";
		var sendResult = SendRequest(request);
		if (sendResult.IsError())
			return Result.Err<Message1Response>(sendResult);
		return Message1Response.Parse(_buffer);
	}

	public Result SendRequest(SifsRequest request, SifsPayloadBuilder? payload = null, MutString? buffer = null)
	{
		buffer ??= _buffer;
		var socket = Socket!;
		// if (socket is null)
		// 	return Result.Err("Socket is null");
		// if (socket.IsOpen == false)
		// {
		// 	var openResult = socket.Open();
		// 	if (openResult.IsError())
		// 		return Result.Err(openResult);
		// }
		if (payload != null)
			request.Payload = payload.Content;
		var buildResult = request.Build(buffer);
		if (buildResult.IsError())
			return Result.Err(buildResult);
		if (payload != null)
			buffer.Append(payload.Content);
		var writeResult = socket!.WriteUtf8(buffer.Span);
		if (writeResult.IsError())
			return Result.Err(writeResult);
		buffer.SetBufferSize(4096, false);
		Span<byte> readByteBuffer = stackalloc byte[8192];
		var readResult = socket.ReadContinuous(readByteBuffer, Debugger.IsAttached ? 50000 : 1000, 200);
		if (readResult.IsError())
			return Result.Err(readResult);
		buffer.Length = buffer.Buffer.Length;
		if (false == Encoding.UTF8.TryGetChars(
			    readByteBuffer.Slice(0, readResult.Value!), buffer.Buffer, out var charCount))
			return Result.Err("Response data is not char!");
		buffer.Length = charCount;
		return Result.OK;
	}

	public static void Test()
	{
		/*
		 * MO_NUMBER
		 * GROUP_NEXT
		 * MODEL_NAME
		 */


		// var sifsRequest = new SifsRequest()
		// {
		// 	MessageType = "2",
		// 	StationName = "ASM3-AUTO",
		// 	SN = "J5Z042301Z0-26086V0001",
		// 	OperatorID = "M000086",
		// 	Line = "TC2A",
		// 	Result = "OK"
		// };
		// var result = sifsRequest.Build(new MutString()).Value.ToString();
		// var createZipToLocalFSResult = ZipUtils.CreateFilesZipToLocalFS("E:/test/img.zip", [
		// 	"assets/temp1.png", "assets/temp2.png"
		// ]).Result;
		var client = new SifsClient(new NetworkSocketConfig("10.1.5.160", 21347));
		var sendMsg7RespResult = client.SendMessage7(new SifsRequest()
		{
			StationName = "BACK IO PRESS",
			SN = "A4A03111100-26028V0001",
			OperatorID = "M002231",
			Line = "TC2A",
			Result = "OK",
		}, new SifsPayloadBuilder()
			.AddGetVariable("GET_PN")
			.AddGetVariable("ZEBRA_DTG")
			.AddGetVariable("SN_NOW_GROUP"));

		if (sendMsg7RespResult.IsOk())
		{
			var resp = sendMsg7RespResult.Value;
			var variableMemoryEnumerator = resp.GetVariableMemoryEnumerator();
			while (variableMemoryEnumerator.MoveNext(out var varName, out var varValue))
			{
				Console.WriteLine($"MSG7 RESP VAR: {varName}={varValue}");
			}
		}

		var msg1RespResult = client.SendMessage1(new SifsRequest()
		{
			StationName = "BACK IO PRESS",
			SN = "A4A03111100-26028V0001",
			OperatorID = "M002231",
			Line = "TC2A",
			Result = "OK"
		});
		Console.WriteLine($"Msg1 Resp: isOK? {msg1RespResult.Value.Rework}");

		var sendMsg2RespResult = client.SendMessage2(new SifsRequest()
		{
			StationName = "BACK IO PRESS",
			SN = "A4A03111100-26028V0001",
			OperatorID = "M002231",
			Line = "TC2A",
			Result = "OK",
		}, new SifsPayloadBuilder()
			.AddVariable("Test1", 1.13, 0.0f, 10.9f)
			.AddVariable("Second", "52s"));
		if (sendMsg2RespResult.IsOk())
		{
			Console.WriteLine("Send MSG2 OK");
		}
	}
}