namespace ZitApp.Services;

public abstract class CoreServiceBase : MainTaskService
{
	public override string ServiceName => "CORE";
	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;


}