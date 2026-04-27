using ZC;
using ZC.UI.ControlLibs;
using ZitApp.Models;
using ZitApp.Services;
using ZitApp.UI.Views.Account;

namespace ZitApp.UI.Account;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class ReplaceMonoVM : CommonUiVM<ReplaceMonoWindow>
{
	private int _feederIndex = 1;
	private ProductRecipeBase? _currentRecipe;

	public partial string MonoSpaceName { get; set; } = "飞达1";
	public partial string MonoCodeLabel { get; set; } = "飞达1码";
	public partial string MonoCode { get; set; } = "";
	public partial string MonoSpaceCode { get; set; } = "";

	public void @CloseView()
	{
		View.Hide();
	}

	public void Show(ProductRecipeBase? currentRecipe = null, int feederIndex = 1)
	{
		_feederIndex = Math.Clamp(feederIndex, 1, 6);
		_currentRecipe = currentRecipe;
		View.Hide();
		ResetInput();
		MonoSpaceName = $"飞达{_feederIndex}";
		MonoCodeLabel = $"飞达{_feederIndex}码";
		View.Show();
		FocusFirstInput();
	}

	public async Task @Confirm()
	{
		MonoCode = MonoCode.Trim();
		MonoSpaceCode = MonoSpaceCode.Trim();

		if (string.IsNullOrWhiteSpace(MonoCode) || string.IsNullOrWhiteSpace(MonoSpaceCode))
		{
			await RetryAsync("飞达码或物料码不能为空，请重试。");
			return;
		}

		var feederInfo = _currentRecipe?.产品上料信息?.ElementAtOrDefault(_feederIndex - 1);
		if (feederInfo is null)
		{
			await RetryAsync($"当前配方没有飞达{_feederIndex}绑定信息，请重试。");
			return;
		}

		var savedFeederCode = feederInfo.上料位置识别码?.Trim() ?? "";
		if (string.Equals(savedFeederCode, MonoCode, StringComparison.Ordinal) == false)
		{
			await RetryAsync("飞达号不一致，请重试。");
			return;
		}

		if (IsMaterialMatched(feederInfo, MonoSpaceCode) == false)
		{
			await RetryAsync("物料码与飞达码不一致，请重试。");
			return;
		}

		ShowToast("换料确认成功。", UiMessageType.Success);
		View.Hide();
	}

	private async Task RetryAsync(string message)
	{
		await ShowMessageBox(message, "换料报警", MessageBoxIcon.Warning);
		ResetInput();
		FocusFirstInput();
	}

	private void ResetInput()
	{
		MonoCode = "";
		MonoSpaceCode = "";
	}

	private void FocusFirstInput()
	{
		View.In物料位置码.Focus();
	}

	private static bool IsMaterialMatched(产品上料信息 feederInfo, string materialCode)
	{
		return string.Equals(feederInfo.上料码1?.Trim(), materialCode, StringComparison.Ordinal) ||
		       string.Equals(feederInfo.上料码2?.Trim(), materialCode, StringComparison.Ordinal) ||
		       string.Equals(feederInfo.上料码3?.Trim(), materialCode, StringComparison.Ordinal) ||
		       string.Equals(feederInfo.上料码4?.Trim(), materialCode, StringComparison.Ordinal) ||
		       string.Equals(feederInfo.上料码5?.Trim(), materialCode, StringComparison.Ordinal);
	}
}
