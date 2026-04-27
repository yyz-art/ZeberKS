using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Input;
using ZC;
using ZC.UI;
using Avalonia.Markup.Xaml;
using ZitApp.Models;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class IoMonitorView : Window, IUiView 
{
    public IoMonitorView()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    protected override void OnClosing(WindowClosingEventArgs e)
    {
        e.Cancel = true; // 取消底层销毁窗口的动作
        this.Hide();     // 仅仅把窗口隐藏起来
        base.OnClosing(e);
    }

    private async void WriteValueTextBox_OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter)
            return;

        e.Handled = true;
        if (sender is not TextBox { DataContext: IoItemModel item } textBox)
            return;

        item.WriteValue = textBox.Text ?? "";
        if (DataContext is IoMonitorVM vm)
            await vm.WriteIoItemAsync(item);
    }

    public object? BackgroundContent { get; set; }
    public object? ForegroundContent { get; set; }
    public int UiTickInterval { get; set; } = 100;
    public ICommand? InitializeCommand { get; set; }
    public ICommand? UiTickCommand { get; set; }
    public IUiTopLevelView? GetTopLevelView() => null;
}
