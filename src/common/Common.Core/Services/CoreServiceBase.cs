namespace ZitApp.Services;

public abstract class CoreServiceBase : MainTaskService
{
	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;


}