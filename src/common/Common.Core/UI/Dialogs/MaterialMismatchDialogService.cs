using Avalonia.Controls;
using Avalonia.Threading;
using ZitApp.Contexts;
using ZitApp.Models;
using ZitApp.UI;

namespace ZitApp.UI.Dialogs;

public static class MaterialMismatchDialogService
{
	static MaterialMismatchDialog? _current;

	/// <summary>
	/// 非模态显示，不阻塞调用线程与主界面（投递到 UI 线程后立即返回）。
	/// </summary>
	public static void Show(string message, string title = "物料校验失败")
	{
		if (Dispatcher.UIThread.CheckAccess())
			ShowCore(message, title);
		else
			Dispatcher.UIThread.Post(() => ShowCore(message, title));
	}

	public static void Show(MaterialSpaceContext failed, ProductRecipeBase? recipe, string title = "物料校验失败") =>
		Show(MaterialMismatchMessages.Build(failed, recipe), title);

	/// <summary>
	/// 弹出后立即返回，不等待用户点击确定。
	/// </summary>
	public static Task ShowAsync(string message, string title = "物料校验失败")
	{
		Show(message, title);
		return Task.CompletedTask;
	}

	static void ShowCore(string message, string title)
	{
		_current?.Close();
		var dialog = new MaterialMismatchDialog
		{
			Topmost = true,
		};
		dialog.SetContent(title, message);
		dialog.Closed += (_, _) =>
		{
			if (ReferenceEquals(_current, dialog))
				_current = null;
		};
		_current = dialog;
		dialog.Show(GetOwnerWindow());
	}

	static Window GetOwnerWindow()
	{
		if (AvaloniaApplication.Current?.AppVM is CommonAppVM appVm)
			return appVm.GetWindow()!;

		if (AvaloniaApplication.Current?.MainView is Window window)
			return window;

		throw new InvalidOperationException("无法找到主窗口，无法显示物料校验对话框。");
	}
}

public static class MaterialMismatchMessages
{
	public static string Build(MaterialSpaceContext failed, ProductRecipeBase? recipe)
	{
		var allowed = recipe?.GetAllowedMaterialCodes(failed.Id) ?? [];
		var allowedText = allowed.Count > 0 ? string.Join(", ", allowed) : "(无)";
		return failed.MaterialState switch
		{
			MaterialState.NotMatched =>
				$"料位 {failed.Id}（{failed.Config.PositionName}）料号与配方不一致。\n\n" +
				$"当前料号：{failed.MaterialCode}\n配方允许料号：{allowedText}",
			MaterialState.RemainAlarm =>
				$"料位 {failed.Id}（{failed.Config.PositionName}）剩余量不足。\n\n" +
				$"当前剩余：{failed.RemainCount}\n报警阈值：{failed.Config.AlarmRemainCount}",
			_ =>
				$"料位 {failed.Id}（{failed.Config.PositionName}）物料状态：{failed.MaterialState}"
		};
	}
}
