using Avalonia.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class KeyGestureInputDemoViewModel : ObservableObject
{
	public List<Key> AcceptableKeys { get; set; } = new List<Key>()
	{
		Key.A, Key.B, Key.C,
	};
}