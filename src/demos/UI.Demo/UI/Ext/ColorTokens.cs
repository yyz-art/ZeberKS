namespace OinetApp.UI;

public static class ColorTokens
{
	public static IReadOnlyList<Tuple<string, string>> PrimaryTokens { get; } =
	[
		new("Brush-Primary", "Primary"),
		new("Brush-PrimaryPointerover", "Primary Pointerover"),
		new("Brush-PrimaryActive", "Primary Active"),
		new("Brush-PrimaryDisabled", "Primary Disabled"),
		new("Brush-PrimaryLight", "Primary Light"),
		new("Brush-PrimaryLightPointerover", "Primary Light Pointerover"),
		new("Brush-PrimaryLightActive", "Primary Light Active"),
	];

	public static IReadOnlyList<Tuple<string, string>> SecondaryTokens { get; } =
	[
		new("Brush-Secondary", "Secondary"),
		new("Brush-SecondaryPointerover", "Secondary Pointerover"),
		new("Brush-SecondaryActive", "Secondary Active"),
		new("Brush-SecondaryDisabled", "Secondary Disabled"),
		new("Brush-SecondaryLight", "Secondary Light"),
		new("Brush-SecondaryLightPointerover", "Secondary Light Pointerover"),
		new("Brush-SecondaryLightActive", "Secondary Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> TertiaryTokens { get; } =
	[
		new("Brush-Tertiary", "Tertiary"),
		new("Brush-TertiaryPointerover", "Tertiary Pointerover"),
		new("Brush-TertiaryActive", "Tertiary Active"),
		new("Brush-TertiaryLight", "Tertiary Light"),
		new("Brush-TertiaryLightPointerover", "Tertiary Light Pointerover"),
		new("Brush-TertiaryLightActive", "Tertiary Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> InformationTokens { get; } =
	[
		new("Brush-Information", "Information"),
		new("Brush-InformationPointerover", "Information Pointerover"),
		new("Brush-InformationActive", "Information Active"),
		new("Brush-InformationDisabled", "Information Disabled"),
		new("Brush-InformationLight", "Information Light"),
		new("Brush-InformationLightPointerover", "Information Light Pointerover"),
		new("Brush-InformationLightActive", "Information Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> SuccessTokens { get; } =
	[
		new("Brush-Success", "Success"),
		new("Brush-SuccessPointerover", "Success Pointerover"),
		new("Brush-SuccessActive", "Success Active"),
		new("Brush-SuccessDisabled", "Success Disabled"),
		new("Brush-SuccessLight", "Success Light"),
		new("Brush-SuccessLightPointerover", "Success Light Pointerover"),
		new("Brush-SuccessLightActive", "Success Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> WarningTokens { get; } =
	[
		new("Brush-Warning", "Warning"),
		new("Brush-WarningPointerover", "Warning Pointerover"),
		new("Brush-WarningActive", "Warning Active"),
		new("Brush-WarningLight", "Warning Light"),
		new("Brush-WarningLightPointerover", "Warning Light Pointerover"),
		new("Brush-WarningLightActive", "Warning Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> DangerTokens { get; } =
	[
		new("Brush-Danger", "Danger"),
		new("Brush-DangerPointerover", "Danger Pointerover"),
		new("Brush-DangerActive", "Danger Active"),
		new("Brush-DangerLight", "Danger Light"),
		new("Brush-DangerLightPointerover", "Danger Light Pointerover"),
		new("Brush-DangerLightActive", "Danger Light Active")
	];

	public static IReadOnlyList<Tuple<string, string>> TextTokens { get; } =
	[
		new("Brush-Text0", "Text 0"),
		new("Brush-Text1", "Text 1"),
		new("Brush-Text2", "Text 2"),
		new("Brush-Text3", "Text 3")
	];

	public static IReadOnlyList<Tuple<string, string>> LinkTokens { get; } =
	[
		new("Brush-Link", "Link"),
		new("Brush-LinkPointerover", "Link Pointerover"),
		new("Brush-LinkActive", "Link Active"),
		new("Brush-LinkVisited", "Link Visited")
	];

	public static IReadOnlyList<Tuple<string, string>> BackgroundTokens { get; } =
	[
		new("Brush-Background0", "Background 0"),
		new("Brush-Background1", "Background 1"),
		new("Brush-Background2", "Background 2"),
		new("Brush-Background3", "Background 3"),
		new("Brush-Background4", "Background 4")
	];

	public static IReadOnlyList<Tuple<string, string>> FillTokens { get; } =
	[
		new("Brush-Fill0", "Fill 0"),
		new("Brush-Fill1", "Fill 1"),
		new("Brush-Fill2", "Fill 2")
	];

	public static IReadOnlyList<Tuple<string, string>> BorderTokens { get; } =
	[
		new("Brush-Border", "Border"),
		new("Brush-FocusBorder", "Focus Border")
	];

	public static IReadOnlyList<Tuple<string, string>> DisabledTokens { get; } =
	[
		new("Brush-DisabledText", "Disabled Text"),
		new("Brush-DisabledBorder", "Disabled Border"),
		new("Brush-DisabledBackground", "Disabled Background"),
		new("Brush-DisabledFill", "Disabled Fill")
	];

	public static IReadOnlyList<Tuple<string, string>> OtherTokens { get; } =
	[
		new("Brush-White", "White"),
		new("Brush-Black", "Black"),
		new("Brush-NavBackground", "Navigation Background"),
		new("Brush-OverlayBackground", "Overlay Background"),
		new("Brush-HighlightBackground", "Highlight Background"),
		new("Brush-Highlight", "Highlight Text")
	];

	public static IReadOnlyList<Tuple<string, string>> ShadowTokens { get; } =
	[
		new("Brush-Shadow", "Shadow"),
		new("BoxShadow.Elevated", "Shadow Elevated")
	];
}