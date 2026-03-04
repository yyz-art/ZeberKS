using Oinet.CFG;
using Oinet.DB;

namespace OinetApp.Ext;

public class AppConfig : ConfigBase
{
	public List<DatabaseConnectionConfig> Databases { get; set; } = null!;
	public TaskServiceHostOptions TaskServiceHostOptions { get; set; } = null!;
}