using ZC.LOG;
using ZC.Text;
using ZitApp.SIFS;

namespace ZitApp.Services.MES;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public class MesService : MainTaskService
{
	public required ILogger Logger { get; init; }


	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected override Task Main(CancellationToken ctk)
	{
		Test();
		while (ctk.IsCancellationRequested == false)
		{
		}

		return Task.CompletedTask;
	}

	private void Test()
	{
		var mutStr = new MutString();
		// ASM10-1-NOKP,WAC58663440-25268K0003,2,M052229,MC34,,OK,,,"[VR]UUID='123456789'"  //含有uuid
		var request = new SifsRequest()
		{
			StationName = "ASM10-1-NOKP",
			SN = "WAC58663440-25268K0003",
			MessageType = "2",
			OperatorID = "M052229",
			Line = "MC34",
			Result = "OK",
			ErrorCode = default,
			Payload = "[VR]UUID='123456789'",
			WorkorderNumber = default
		};
		var result = request.Build(mutStr);


		Console.WriteLine($"{result.Code} : {result.Value}");
	}
}