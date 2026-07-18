namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton, AliasMapTo = [typeof(ImageCleanupServiceBase)])]
public class ImageCleanupService : ImageCleanupServiceBase
{
}
