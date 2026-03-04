using ZC.IFS.Connection;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
public class ConnectionManageService
{
	private Dictionary<string, IConnection> Connections { get; } = new();

	public IConnection? GetConnection(string key)
	{
		if (false == Connections.TryGetValue(key, out var connection))
			return null;
		return connection;
	}

	public void RegisterConnection(string key, IConnection connection)
	{
		Connections[key] = connection;
	}
}