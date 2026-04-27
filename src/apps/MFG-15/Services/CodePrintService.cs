using System.Runtime.InteropServices;
using ZC;

namespace ZitApp.Services;

public class CodePrintService
{
	private const string PrintProgramPath = @"D:\AppZC\test.exe";
	private const int PrintProgramStartupTimeoutMs = 15000;

	private static readonly string[] PrintProgramNames =
	[
		"WORK_STATION_INPUT",
		"test"
	];

	private const int StdInputHandle = -10;
	private const short KeyEvent = 0x0001;
	private const short VkReturn = 0x0D;
	private const uint InputKeyboard = 1;
	private const uint KeyEventFKeyUp = 0x0002; 
	private const uint KeyEventFUnicode = 0x0004;
	private const int SwRestore = 9;

	public static object? SendContentToMesPrintProgram(string content)
	{
		content = content.Trim();
		if (string.IsNullOrWhiteSpace(content))
			return "print content is empty!";

		var (process, startError) = EnsurePrintProgramRunning();
		if (process is null)
			return startError ?? $"mes print program not found! names=[{string.Join(", ", PrintProgramNames)}]";

		var consoleResult = TryWriteConsoleInput(process, content);
		if (consoleResult is null)
			return null;

		var windowInputResult = TryWriteByWindowInput(process, content);
		if (windowInputResult is null)
			return null;

		return $"console input failed: {consoleResult}; window input failed: {windowInputResult}";
	}

	private static (Process? Process, string? Error) EnsurePrintProgramRunning()
	{
		var process = WaitForPrintProgramReady(FindPrintProgram(), 1000);
		if (process is not null)
			return (process, null);

		if (File.Exists(PrintProgramPath) == false)
			return (null, $"mes print program not found and file does not exist: {PrintProgramPath}");

		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = PrintProgramPath,
				WorkingDirectory = Path.GetDirectoryName(PrintProgramPath) ?? "",
				UseShellExecute = true,
				Verb = "runas"
			});
		}
		catch (Exception ex)
		{
			return (null, $"start mes print program as admin failed: {ex.Message}");
		}

		process = WaitForPrintProgramReady(null, PrintProgramStartupTimeoutMs);
		return process is null
			? (null, $"start mes print program timeout: {PrintProgramPath}")
			: (process, null);
	}

	private static Process? WaitForPrintProgramReady(Process? process, int timeoutMs)
	{
		var deadline = DateTime.UtcNow.AddMilliseconds(timeoutMs);
		while (DateTime.UtcNow < deadline)
		{
			process = RefreshProcess(process) ?? FindPrintProgram();
			if (process is not null && process.MainWindowHandle != IntPtr.Zero)
				return process;

			Thread.Sleep(200);
		}

		return null;
	}

	private static Process? RefreshProcess(Process? process)
	{
		if (process is null)
			return null;

		try
		{
			if (process.HasExited)
				return null;

			process.Refresh();
			return process;
		}
		catch
		{
			return null;
		}
	}

	private static Process? FindPrintProgram()
	{
		return Process.GetProcesses()
			.Where(IsPrintProgram)
			.OrderByDescending(t => t.MainWindowHandle != IntPtr.Zero)
			.FirstOrDefault();
	}

	private static bool IsPrintProgram(Process process)
	{
		try
		{
			return PrintProgramNames.Any(name =>
				process.ProcessName.Equals(name, StringComparison.OrdinalIgnoreCase)
				|| process.ProcessName.Contains(name, StringComparison.OrdinalIgnoreCase)
				|| process.MainWindowTitle.Contains(name, StringComparison.OrdinalIgnoreCase)
				|| (process.MainModule?.FileName.Contains(name, StringComparison.OrdinalIgnoreCase) ?? false));
		}
		catch
		{
			return PrintProgramNames.Any(name =>
				process.ProcessName.Equals(name, StringComparison.OrdinalIgnoreCase)
				|| process.ProcessName.Contains(name, StringComparison.OrdinalIgnoreCase)
				|| process.MainWindowTitle.Contains(name, StringComparison.OrdinalIgnoreCase));
		}
	}

	private static string? TryWriteConsoleInput(Process process, string content)
	{
		try
		{
			FreeConsole();
			if (AttachConsole((uint)process.Id) == false)
				return $"AttachConsole failed, win32={Marshal.GetLastWin32Error()}";

			var inputHandle = GetStdHandle(StdInputHandle);
			if (inputHandle == IntPtr.Zero || inputHandle == new IntPtr(-1))
				return $"GetStdHandle(STDIN) failed, win32={Marshal.GetLastWin32Error()}";

			var records = CreateInputRecords(content + "\r");
			if (WriteConsoleInput(inputHandle, records, (uint)records.Length, out var written) == false)
				return $"WriteConsoleInput failed, win32={Marshal.GetLastWin32Error()}";

			return written == records.Length ? null : $"only wrote {written}/{records.Length} input records";
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		finally
		{
			FreeConsole();
		}
	}

	private static INPUT_RECORD[] CreateInputRecords(string text)
	{
		var records = new INPUT_RECORD[text.Length * 2];
		var index = 0;
		foreach (var ch in text)
		{
			var virtualKey = ch is '\r' or '\n' ? VkReturn : (short)0;
			records[index++] = INPUT_RECORD.Key(ch, virtualKey, true);
			records[index++] = INPUT_RECORD.Key(ch, virtualKey, false);
		}

		return records;
	}

	private static string? TryWriteByWindowInput(Process process, string content)
	{
		try
		{
			var windowHandle = process.MainWindowHandle;
			if (windowHandle == IntPtr.Zero)
				return "main window handle not found";

			ShowWindow(windowHandle, SwRestore);
			if (SetForegroundWindow(windowHandle) == false)
				return $"SetForegroundWindow failed, win32={Marshal.GetLastWin32Error()}";

			Thread.Sleep(100);
			return SendText(content + "\r");
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	private static string? SendText(string text)
	{
		var inputs = new INPUT[text.Length * 2];
		var index = 0;
		foreach (var ch in text)
		{
			if (ch is '\r' or '\n')
			{
				inputs[index++] = INPUT.VirtualKey(VkReturn, false);
				inputs[index++] = INPUT.VirtualKey(VkReturn, true);
				continue;
			}

			inputs[index++] = INPUT.Unicode(ch, false);
			inputs[index++] = INPUT.Unicode(ch, true);
		}

		var sent = SendInput((uint)inputs.Length, inputs, Marshal.SizeOf<INPUT>());
		return sent == inputs.Length ? null : $"SendInput wrote {sent}/{inputs.Length}, win32={Marshal.GetLastWin32Error()}";
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool AttachConsole(uint dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeConsole();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetStdHandle(int nStdHandle);

	[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
	private static extern bool WriteConsoleInput(
		IntPtr hConsoleInput,
		INPUT_RECORD[] lpBuffer,
		uint nLength,
		out uint lpNumberOfEventsWritten);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

	[StructLayout(LayoutKind.Sequential)]
	private struct INPUT_RECORD
	{
		public short EventType;
		public KEY_EVENT_RECORD KeyEvent;

		public static INPUT_RECORD Key(char ch, short virtualKeyCode, bool keyDown) => new()
		{
			EventType = CodePrintService.KeyEvent,
			KeyEvent = new KEY_EVENT_RECORD
			{
				KeyDown = keyDown,
				RepeatCount = 1,
				VirtualKeyCode = virtualKeyCode,
				VirtualScanCode = 0,
				UnicodeChar = ch,
				ControlKeyState = 0
			}
		};
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct KEY_EVENT_RECORD
	{
		[MarshalAs(UnmanagedType.Bool)]
		public bool KeyDown;
		public short RepeatCount;
		public short VirtualKeyCode;
		public short VirtualScanCode;
		public char UnicodeChar;
		public int ControlKeyState;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct INPUT
	{
		public uint Type;
		public INPUT_UNION InputUnion;

		public static INPUT Unicode(char ch, bool keyUp) => new()
		{
			Type = InputKeyboard,
			InputUnion = new INPUT_UNION
			{
				KeyboardInput = new KEYBDINPUT
				{
					VirtualKey = 0,
					ScanCode = ch,
					Flags = KeyEventFUnicode | (keyUp ? KeyEventFKeyUp : 0),
					Time = 0,
					ExtraInfo = UIntPtr.Zero
				}
			}
		};

		public static INPUT VirtualKey(short virtualKey, bool keyUp) => new()
		{
			Type = InputKeyboard,
			InputUnion = new INPUT_UNION
			{
				KeyboardInput = new KEYBDINPUT
				{
					VirtualKey = (ushort)virtualKey,
					ScanCode = 0,
					Flags = keyUp ? KeyEventFKeyUp : 0,
					Time = 0,
					ExtraInfo = UIntPtr.Zero
				}
			}
		};
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct INPUT_UNION
	{
		[FieldOffset(0)]
		public MOUSEINPUT MouseInput;

		[FieldOffset(0)]
		public KEYBDINPUT KeyboardInput;

		[FieldOffset(0)]
		public HARDWAREINPUT HardwareInput;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct MOUSEINPUT
	{
		public int Dx;
		public int Dy;
		public uint MouseData;
		public uint Flags;
		public uint Time;
		public UIntPtr ExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct KEYBDINPUT
	{
		public ushort VirtualKey;
		public ushort ScanCode;
		public uint Flags;
		public uint Time;
		public UIntPtr ExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct HARDWAREINPUT
	{
		public uint Msg;
		public ushort ParamL;
		public ushort ParamH;
	}
}
