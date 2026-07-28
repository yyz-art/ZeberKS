using Avalonia.Controls;
using Avalonia.Interactivity;
using ZitApp;

namespace ZitApp.UI.Dialogs;

public partial class LicenseDialog : Window
{
    private bool _activated;

    public LicenseDialog()
    {
        InitializeComponent();
    }

    public void SetMessage(string message)
    {
        MessageBlock.Text = message;
    }

    void OnClosing(object? sender, WindowClosingEventArgs e)
    {
        if (!_activated)
            e.Cancel = true;
    }

    async void OnActivateClick(object? sender, RoutedEventArgs e)
    {
        var key = LicenseInput.Text?.Trim() ?? "";
        var err = LicenseHelper.TryActivate(key);
        if (err != null)
        {
            ErrorBlock.Text = err;
            ErrorBlock.IsVisible = true;
            return;
        }

        _activated = true;
        Close();
    }
}
