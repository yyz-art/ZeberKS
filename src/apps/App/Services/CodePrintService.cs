#if MFG_15
using System.Runtime.InteropServices;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using ZC;

namespace ZitApp.Services;

public class CodePrintService
{
	public static object? SendContentToMesPrintProgram(string content)
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
		textBox.Enter(content + "\r\n");
		return null;
	}
}
#endif