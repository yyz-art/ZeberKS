using System.Collections.ObjectModel;
using System.Windows.Input;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Messaging;
using Oinet.Mvvm;
using OinetApp.UI.Views.Demo.Ext;

namespace OinetApp.UI.Views;

[ViewModel, RegisterToIOC(LifetimeType = LifetimeType.Singleton)]
public partial class ControlLibsMainViewViewModel : UiVM<ControlLibsMainView>
{
	private object? _content;

	[ObservableProperty] private string? _footerText = "Settings";

	[ObservableProperty] private bool _isCollapsed;

	[ObservableProperty] private ThemeItem? _selectedTheme;

	public ControlLibsMainViewViewModel()
	{
		WeakReferenceMessenger.Default.Register<ControlLibsMainViewViewModel, string>(this, OnNavigation);
	}

	public UiNotificationManager? NotificationManager { get; set; }
	public MenuViewModel Menus { get; set; } = new MenuViewModel();
	public static readonly ObservablePropertyChangedEventArgs ContentPropertyPropertyChangedEventArgs = new(nameof(Content));

	public object? Content
	{
		get => _content;
		set => SetField(ref _content, value, ContentPropertyPropertyChangedEventArgs);
	}

	public ObservableCollection<ThemeItem> Themes { get; } =
	[
		new("Default", ThemeVariant.Default),
		new("Light", ThemeVariant.Light),
		new("Dark", ThemeVariant.Dark),
		new("Aquatic", UiTheme.Aquatic),
		new("Desert", UiTheme.Desert),
		new("Dusk", UiTheme.Dusk),
		new("NightSky", UiTheme.NightSky)
	];


	private void OnNavigation(ControlLibsMainViewViewModel vm, string s)
	{
		Content = s switch
		{
			MenuKeys.MenuKeyIntroduction => new IntroductionDemoViewModel(),
			// MenuKeys.MenuKeyAboutUs => new AboutUsDemoViewModel(),
			MenuKeys.MenuKeyAutoCompleteBox => new AutoCompleteBoxDemoViewModel(),
			MenuKeys.MenuKeyAvatar => new AvatarDemoViewModel(),
			MenuKeys.MenuKeyBadge => new BadgeDemoViewModel(),
			MenuKeys.MenuKeyBanner => new BannerDemoViewModel(),
			MenuKeys.MenuKeyBreadcrumb => new BreadcrumbDemoViewModel(),
			MenuKeys.MenuKeyButtonGroup => new ButtonGroupDemoViewModel(),
			MenuKeys.MenuKeyClassInput => new ClassInputDemoViewModel(),
			MenuKeys.MenuKeyClock => new ClockDemoViewModel(),
			MenuKeys.MenuKeyDatePicker => new DatePickerDemoViewModel(),
			MenuKeys.MenuKeyDateRangePicker => new DateRangePickerDemoViewModel(),
			MenuKeys.MenuKeyDateTimePicker => new DateTimePickerDemoViewModel(),
			MenuKeys.MenuKeyDialog => new DialogDemoViewModel(),
			MenuKeys.MenuKeyDisableContainer => new DisableContainerDemoViewModel(),
			MenuKeys.MenuKeyDivider => new DividerDemoViewModel(),
			MenuKeys.MenuKeyDrawer => new DrawerDemoViewModel(),
			MenuKeys.MenuKeyDualBadge => new DualBadgeDemoViewModel(),
			MenuKeys.MenuKeyElasticWrapPanel => new ElasticWrapPanelDemoViewModel(),
			MenuKeys.MenuKeyEnumSelector => new EnumSelectorDemoViewModel(),
			MenuKeys.MenuKeyForm => new FormDemoViewModel(),
			MenuKeys.MenuKeyIconButton => new IconButtonDemoViewModel(),
			MenuKeys.MenuKeyImageViewer => new ImageViewerDemoViewModel(),
			MenuKeys.MenuKeyIpBox => new IPv4BoxDemoViewModel(),
			MenuKeys.MenuKeyKeyGestureInput => new KeyGestureInputDemoViewModel(),
			MenuKeys.MenuKeyLoading => new LoadingDemoViewModel(),
			MenuKeys.MenuKeyMarquee => new MarqueeDemoViewModel(),
			MenuKeys.MenuKeyMessageBox => new MessageBoxDemoViewModel(),
			MenuKeys.MenuKeyMultiComboBox => new MultiComboBoxDemoViewModel(),
			MenuKeys.MenuKeyNavMenu => new NavMenuDemoViewModel(),
			MenuKeys.MenuKeyNotification => new NotificationDemoViewModel(),
			MenuKeys.MenuKeyNumberDisplayer => new NumberDisplayerDemoViewModel(),
			MenuKeys.MenuKeyNumericUpDown => new NumericUpDownDemoViewModel(),
			MenuKeys.MenuKeyNumPad => new NumPadDemoViewModel(),
			MenuKeys.MenuKeyPagination => new PaginationDemoViewModel(),
			MenuKeys.MenuKeyPinCode => new PinCodeDemoViewModel(),
			MenuKeys.MenuKeyPopConfirm => new PopConfirmDemoViewModel(),
			MenuKeys.MenuKeyRangeSlider => new RangeSliderDemoViewModel(),
			MenuKeys.MenuKeyRating => new RatingDemoViewModel(),
			MenuKeys.MenuKeyScrollToButton => new ScrollToButtonDemoViewModel(),
			MenuKeys.MenuKeySelectionList => new SelectionListDemoViewModel(),
			MenuKeys.MenuKeySkeleton => new SkeletonDemoViewModel(),
			MenuKeys.MenuKeyTagInput => new TagInputDemoViewModel(),
			MenuKeys.MenuKeyThemeToggler => new ThemeTogglerDemoViewModel(),
			MenuKeys.MenuKeyTimeBox => new TimeBoxDemoViewModel(),
			MenuKeys.MenuKeyTimeline => new TimelineDemoViewModel(),
			MenuKeys.MenuKeyTimePicker => new TimePickerDemoViewModel(),
			MenuKeys.MenuKeyTimeRangePicker => new TimeRangePickerDemoViewModel(),
			MenuKeys.MenuKeyToast => new ToastDemoViewModel(),
			MenuKeys.MenuKeyToolBar => new ToolBarDemoViewModel(),
			MenuKeys.MenuKeyTreeComboBox => new TreeComboBoxDemoViewModel(),
			MenuKeys.MenuKeyTwoTonePathIcon => new TwoTonePathIconDemoViewModel(),
			MenuKeys.AspectRatioLayout => new AspectRatioLayoutDemoViewModel(),
			MenuKeys.PathPicker => new PathPickerDemoViewModel(),
			_ => throw new ArgumentOutOfRangeException(nameof(s), s, null)
		};
	}

	partial void OnSelectedThemeChanged(ThemeItem? oldValue, ThemeItem? newValue)
	{
		if (newValue is null) return;
		var app = Application.Current;
		if (app is not null)
		{
			app.RequestedThemeVariant = newValue.Theme;
			NotificationManager?.Show(
				new UiNotification("Theme changed", $"Theme changed to {newValue.Name}"),
				type: UiMessageType.Success,
				classes: ["Light"]);
		}
	}

	partial void OnIsCollapsedChanged(bool newValue)
	{
		FooterText = newValue ? null : "Settings";
	}
}

public class MenuItemViewModel2 : ViewModel
{
	public MenuItemViewModel2()
	{
		ActivateCommand = new RelayCommand(OnActivate);
	}

	public string? MenuHeader { get; set; }
	public string? MenuIconName { get; set; }
	public string? Key { get; set; }
	public string? Status { get; set; }

	public bool IsSeparator { get; set; }
	public ObservableCollection<MenuItemViewModel2> Children { get; set; } = new();

	public ICommand ActivateCommand { get; set; }

	private void OnActivate()
	{
		if (IsSeparator || Key is null) return;
		WeakReferenceMessenger.Default.Send(Key);
	}
}

public class ThemeItem(string name, ThemeVariant theme)
{
	public string Name { get; set; } = name;
	public ThemeVariant Theme { get; set; } = theme;
}