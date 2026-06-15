using ZC.Mvvm;

namespace ZitApp.Contexts;

public partial class DeviceStatusContext : ObservableObject
{
	public partial string Name { get; set; } = "";
	public partial object? Status { get; set; }
	public partial string Message { get; set; } = "";

	public static void CreateList(ObservableList<DeviceStatusContext> deviceStatusContexts)
	{
		deviceStatusContexts.Add(new DeviceStatusContext { Name = "PLC" });
		deviceStatusContexts.Add(new DeviceStatusContext { Name = "Scanner1" });
		deviceStatusContexts.Add(new DeviceStatusContext { Name = "Scanner2" });
		deviceStatusContexts.Add(new DeviceStatusContext { Name = "NozzlePress" });
	}
}