namespace OinetApp.UI.Views.Demo.Ext;

public partial class NumericUpDownDemo : UserControl
{
	public NumericUpDownDemo()
	{
		InitializeComponent();
		DataContext = new NumericUpDownDemoViewModel();
		numd.ValueChanged += Numd_ValueChanged;
	}

	private void Numd_ValueChanged(object? sender, ValueChangedEventArgs<uint> e)
	{
		if (sender is NumericIntUpDown i)
		{
			Trace.WriteLine($"{i.Name} {e.OldValue} {e.NewValue}");
		}
	}
}