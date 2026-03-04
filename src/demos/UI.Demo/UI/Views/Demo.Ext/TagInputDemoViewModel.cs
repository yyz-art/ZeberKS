using System.Collections.ObjectModel;

namespace OinetApp.UI.Views.Demo.Ext;

public class TagInputDemoViewModel : ViewModelBase
{
	private ObservableCollection<string> _distinctTags = new();
	private ObservableCollection<string> _tags = new();

	public ObservableCollection<string> Tags
	{
		get => _tags;
		set => SetField(ref _tags, value);
	}

	public ObservableCollection<string> DistinctTags
	{
		get => _distinctTags;
		set => SetField(ref _distinctTags, value);
	}
}