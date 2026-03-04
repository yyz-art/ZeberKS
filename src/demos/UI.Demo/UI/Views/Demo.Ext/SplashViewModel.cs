using Avalonia.Threading;
using Oinet.Mvvm;
using Oinet.UI.Contracts;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class SplashViewModel : ObservableObject, IDialogContext
{
	[ObservableProperty] private double _progress;
	private Random _r = new();

	public SplashViewModel()
	{
		DispatcherTimer.Run(OnUpdate, TimeSpan.FromMilliseconds(20), DispatcherPriority.Default);
	}

	public void Close()
	{
		RequestClose?.Invoke(this, false);
	}

	public event EventHandler<object?>? RequestClose;

	private bool OnUpdate()
	{
		Progress += 10 * _r.NextDouble();
		if (Progress <= 100)
		{
			return true;
		}
		else
		{
			RequestClose?.Invoke(this, true);
			return false;
		}
	}
}