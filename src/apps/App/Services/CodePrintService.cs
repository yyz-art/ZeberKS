#if MFG15
using System.Runtime.InteropServices;
using System.Text;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;
using ZC;
using ZC.DP.Number;
using ZC.LOG;
using TextBox = Avalonia.Controls.TextBox;

namespace ZitApp.Services;

public class CodePrintService
{
	public static object? SendContentToMesPrintProgram(string content)
	{
		try
		{
			var processes = Process.GetProcesses().Where(t => t.ProcessName.Contains("WORK_STATION_INPUT")).ToArray();
			if (processes.Length == 0)
				return "mes print program not found!";
			var process = processes[0];
			using var app = FlaUI.Core.Application.Attach(process);
			using var automation = new UIA3Automation();
			var mainWindow = app.GetMainWindow(automation)!;
			var edits = mainWindow.FindAllDescendants(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Edit));
			var barcodeEdit = edits[0];
			var textBox = barcodeEdit.AsTextBox();
			// textBox.Text = content;
			var config = App.Current.Config;
			// content = content + (config.PrintEndWithMode switch { 1 => "\r\n", 2 => "\r", 3 => "\n", _ => "\r\n" });
			Log.Debug($"SEND PROG HEX: '{HexUtils.ToString(Encoding.UTF8.GetBytes(content)).Value}'");
			if (config.PrintInputMode == 1)
				Enter2(textBox, content, config.PrintDelay);
			else if (config.PrintInputMode == 2)
				textBox.Enter(content);
			else
				textBox.Text = content;
			return null;
		}
		catch (Exception e)
		{
			return e.Message;
		}
	}

	public static void Enter2(FlaUI.Core.AutomationElements.TextBox textBox, string value, int delay)
	{
		var config = App.Current.Config;
		textBox.Focus();
		textBox.Text = "";
		Wait.UntilInputIsProcessed();
		Thread.Sleep(config.PrintClearDelay);
		textBox.Patterns.Value.PatternOrDefault?.SetValue(string.Empty);
		Keyboard.Type(value);
		Wait.UntilInputIsProcessed();
		Thread.Sleep(delay);
		var end =  (config.PrintEndWithMode switch { 1 => "\r\n", 2 => "\r", 3 => "\n", _ => "\r\n" });
		Keyboard.Type(end);
		Wait.UntilInputIsProcessed();
	}
}
#endif