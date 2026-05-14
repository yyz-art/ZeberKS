// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

Console.WriteLine("select mode [rn/r/n/empty/test]");
var mode = Console.ReadLine();
switch (mode)
{
	case "rn":
	{
		while (true)
		{
			Console.Write("input:");
			var readLine = Console.ReadLine();
			SendContentToMesPrintProgram(readLine+"\r\n" ?? "");
		}
	}
	case "r":
	{
		while (true)
		{
			Console.Write("input:");
			var readLine = Console.ReadLine();
			SendContentToMesPrintProgram(readLine+"\r" ?? "");
		}
	}
	case "n":
	{
		while (true)
		{
			Console.Write("input:");
			var readLine = Console.ReadLine();
			SendContentToMesPrintProgram(readLine+"\n" ?? "");
		}
	}
	case "empty":
	{
		while (true)
		{
			Console.Write("input:");
			var readLine = Console.ReadLine();
			SendContentToMesPrintProgram(readLine ?? "");
		}
	}
	case "test":
	{
		while (true)
		{
			Console.Write("input:");
			var readLine = Console.ReadLine();
			Console.Write("bytes: ");
			foreach (var c in readLine ?? "")
			{
				Console.Write((int)c);
				Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}

 static object? SendContentToMesPrintProgram(string content)
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
	
	textBox.Enter(content );
	return null;
}