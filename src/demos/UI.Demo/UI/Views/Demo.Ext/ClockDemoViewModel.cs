using System.Timers;
using Oinet.Mvvm;
using Timer = System.Timers.Timer;

namespace OinetApp.UI.Views.Demo.Ext;

public partial class ClockDemoViewModel : ObservableObject, IDisposable
{
	[ObservableProperty] private DateTime _time;
	private Timer _timer;

	public ClockDemoViewModel()
	{
		Time = DateTime.Now;
		_timer = new Timer(1000);
		_timer.Elapsed += TimerOnElapsed;
		_timer.Start();
	}

	public void Dispose()
	{
		_timer.Stop();
		_timer.Elapsed -= TimerOnElapsed;
		_timer.Dispose();
	}

	private void TimerOnElapsed(object? sender, ElapsedEventArgs e)
	{
		Time = DateTime.Now;
	}
}