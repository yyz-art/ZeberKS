using System.Windows.Input;
using Avalonia.Platform.Storage;
using Oinet.Mvvm;

namespace OinetApp.UI.Views;

public partial class AboutUsViewModel : ObservableObject
{
	private static readonly IReadOnlyDictionary<string, string> _keyToUrlMapping = new Dictionary<string, string>()
	{
		["semi"] = "https://github.com/irihitech/Semi.Avalonia",
		["Oinet.UI"] = "https://github.com/irihitech/Oinet.UI",
		["mantra"] = "https://www.bilibili.com/video/BV15pfKYbEEQ",
		["huska"] = "https://www.bilibili.com/video/BV1knj1zWE4A",
	};

	public AboutUsViewModel()
	{
		NavigateCommand = new AsyncRelayCommand<string>(OnNavigateAsync);
	}

	public ICommand NavigateCommand { get; set; }

	internal ILauncher? Launcher { get; set; }

	private async Task OnNavigateAsync(string? arg)
	{
		if (Launcher is not null && arg is not null && _keyToUrlMapping.TryGetValue(arg.ToLower(), out var uri))
		{
			await Launcher.LaunchUriAsync(new Uri(uri));
		}
	}
}