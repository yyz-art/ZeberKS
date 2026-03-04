using System.Collections.ObjectModel;
using System.Windows.Input;
using Oinet.Mvvm;

namespace OinetApp.UI.Views.Demo.Ext;

public class MessageBoxDemoViewModel : ObservableObject
{
	private readonly string _longMessage =
		"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

	private readonly string _shortMessage = "Welcome to Oinet.UI Avalonia!";
	private string _message;

	private MessageBoxResult _result;

	private MessageBoxIcon _selectedIcon;
	private string? _title;

	private bool _useLong;

	private bool _useOverlay;

	private bool _useTitle;


	public MessageBoxDemoViewModel()
	{
		DefaultMessageBoxCommand = new AsyncRelayCommand(OnDefaultMessageAsync);
		OkCommand = new AsyncRelayCommand(OnOkAsync);
		YesNoCommand = new AsyncRelayCommand(OnYesNoAsync);
		YesNoCancelCommand = new AsyncRelayCommand(OnYesNoCancelAsync);
		OkCancelCommand = new AsyncRelayCommand(OnOkCancelAsync);
		Icons = new ObservableCollection<MessageBoxIcon>(
			Enum.GetValues<MessageBoxIcon>());
		SelectedIcon = MessageBoxIcon.None;
		_message = _shortMessage;
	}

	public ICommand DefaultMessageBoxCommand { get; set; }
	public ICommand OkCommand { get; set; }
	public ICommand YesNoCommand { get; set; }
	public ICommand YesNoCancelCommand { get; set; }
	public ICommand OkCancelCommand { get; set; }

	public ObservableCollection<MessageBoxIcon> Icons { get; set; }

	public MessageBoxIcon SelectedIcon
	{
		get => _selectedIcon;
		set => SetField(ref _selectedIcon, value);
	}

	public MessageBoxResult Result
	{
		get => _result;
		set => SetField(ref _result, value);
	}

	public bool UseLong
	{
		get => _useLong;
		set
		{
			SetField(ref _useLong, value);
			_message = value ? _longMessage : _shortMessage;
		}
	}

	public bool UseTitle
	{
		get => _useTitle;
		set
		{
			SetField(ref _useTitle, value);
			_title = value ? "Oinet.UI MessageBox" : string.Empty;
		}
	}

	public bool UseOverlay
	{
		get => _useOverlay;
		set => SetField(ref _useOverlay, value);
	}

	private async Task OnDefaultMessageAsync()
	{
		if (UseOverlay)
		{
			Result = await MessageBox.ShowOverlay(_message, _title, icon: SelectedIcon);
		}
		else
		{
			Result = await MessageBox.Show(_message, _title, icon: SelectedIcon);
		}
	}

	private async Task OnOkAsync()
	{
		await Show(MessageBoxButton.OK);
	}

	private async Task OnYesNoAsync()
	{
		await Show(MessageBoxButton.YesNo);
	}

	private async Task OnYesNoCancelAsync()
	{
		await Show(MessageBoxButton.YesNoCancel);
	}

	private async Task OnOkCancelAsync()
	{
		await Show(MessageBoxButton.OKCancel);
	}

	private async Task Show(MessageBoxButton button)
	{
		if (UseOverlay)
		{
			Result = await MessageBox.ShowOverlay(_message, _title, icon: SelectedIcon, button: button);
		}
		else
		{
			Result = await MessageBox.Show(_message, _title, icon: SelectedIcon, button: button);
		}
	}
}