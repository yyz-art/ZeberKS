using ZC;
using ZC.Net.Sockets;
using ZitApp.SIFS;

namespace ZitApp.Services;

public class MesServiceBase<T> where T : CommonAppConfig
{
	public required T Config { get; set; }
	private SemaphoreSlim _lock = new(1, 1);


	public SifsClient Client
	{
		get
		{
			field ??= new SifsClient(new NetworkSocketConfig(
				Config.SifsHostIp, Config.SifsHostPort));
			return field;
		}
	}

	public Result<Message1Response> SendMessage1(
		string operatorID, string sn)
	{
		if (Client.Socket is not { IsOpen: true })
		{
			var openResult = Client.Socket!.Open();
			if (openResult.IsError())
				return Result.Err<Message1Response>(openResult);
		}

		var request = new SifsRequest();
		request.Line = Config.Line;
		request.OperatorID = operatorID;
		request.MessageType = "1";
		request.Result = "OK";
		request.SN = sn;
		request.StationName = Config.StationName;
		var responseResult = Client.SendMessage1(request);
		return responseResult;
	}

	private SifsPayloadBuilder _reqMsg7Payload = new SifsPayloadBuilder()
		.AddGetVariable("MO_NUMBER").AddGetVariable("MODEL_NAME");

	public Result<Message7Response> SendMessage7(string operatorID, string sn)
	{
		if (Client.Socket is not { IsOpen: true })
		{
			var openResult = Client.Socket!.Open();
			if (openResult.IsError())
				return Result.Err<Message7Response>(openResult);
		}

		var request = new SifsRequest();
		request.Line = Config.Line;
		request.OperatorID = operatorID;
		request.MessageType = "7";
		request.Result = "OK";
		request.SN = sn;
		request.StationName = Config.StationName;
		var responseResult = Client.SendMessage7(request, _reqMsg7Payload);
		return responseResult;
	}

	public Result<Message2Response> SendMessage2(
		string operatorID, string sn, SifsPayloadBuilder? payload)
	{
		if (Client.Socket is not { IsOpen: true })
		{
			var openResult = Client.Socket!.Open();
			if (openResult.IsError())
				return Result.Err<Message2Response>(openResult);
		}

		var request = new SifsRequest();
		request.Line = Config.Line;
		request.OperatorID = operatorID;
		request.MessageType = "2";
		request.Result = "OK";
		request.SN = sn;
		request.StationName = Config.StationName;
		var responseResult = Client.SendMessage2(request, payload);
		return responseResult;
	}
}