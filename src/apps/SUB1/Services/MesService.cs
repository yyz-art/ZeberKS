using ZC.Mvvm;

namespace ZitApp.Services; 

[RegisterToIOC(LifetimeType.Singleton)]
public partial class MesService : MesServiceBase<AppConfig>
{
   
}