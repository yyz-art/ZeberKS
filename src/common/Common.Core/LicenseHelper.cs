using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ZitApp;

/// <summary>
/// 授权校验工具。格式: ZC-{yyyyMMdd}-{HMAC12}
/// 校验: HMAC-SHA256(date + secret) 截取前12位hex
/// </summary>
public static partial class LicenseHelper
{
    const string LicenseFile = "data/license.key";
    const string TsFile = "data/.license_check";
    const string Prefix = "ZC";
    static readonly byte[] SecretKey = "XKJ-HX-ZEBER@2024!SECRET#KEY"u8.ToArray();

    [GeneratedRegex(@"^ZC-(\d{8})-([0-9A-Fa-f]{12})$")]
    private static partial Regex LicensePattern();

    public static bool IsDevMode => Debugger.IsAttached;

    /// <summary>校验当前授权，失败返回原因文本，成功返回 null。</summary>
    public static string? Validate()
    {
        if (IsDevMode) return null; // 调试模式跳过

        // 1. 读取 license 文件
        if (!File.Exists(LicenseFile))
            return "未激活：请提供授权码。";

        var key = File.ReadAllText(LicenseFile).Trim();
        var match = LicensePattern().Match(key);
        if (!match.Success)
            return "授权码格式无效。";

        // 2. 解析日期
        var dateStr = match.Groups[1].Value;
        if (!DateOnly.TryParseExact(dateStr, "yyyyMMdd", out var expiry))
            return "授权码日期无效。";

        // 3. 校验 HMAC
        var expectedHmac = match.Groups[2].Value;
        var actualHmac = ComputeHmac(dateStr);
        if (!string.Equals(expectedHmac, actualHmac, StringComparison.OrdinalIgnoreCase))
            return "授权码已被篡改，请联系供应商。";

        // 4. 校验是否过期
        if (DateOnly.FromDateTime(DateTime.Today) > expiry)
            return $"授权已过期（{expiry:yyyy-MM-dd}），请联系续期。";

        // 5. 防时间回退检测
        var rollbackMsg = DetectTimeRollback();
        if (rollbackMsg != null) return rollbackMsg;

        // 通过：更新时间戳
        SaveTimestamp();
        return null;
    }

    /// <summary>尝试验证并保存授权码。</summary>
    public static string? TryActivate(string licenseKey)
    {
        var key = licenseKey.Trim();
        var match = LicensePattern().Match(key);
        if (!match.Success) return "格式错误，正确格式：ZC-日期(8位)-校验码(12位)";

        var dateStr = match.Groups[1].Value;
        if (!DateOnly.TryParseExact(dateStr, "yyyyMMdd", out _))
            return "日期无效。";

        var expectedHmac = match.Groups[2].Value;
        var actualHmac = ComputeHmac(dateStr);
        if (!string.Equals(expectedHmac, actualHmac, StringComparison.OrdinalIgnoreCase))
            return "授权码无效。";

        // 保存
        Directory.CreateDirectory(Path.GetDirectoryName(LicenseFile)!);
        File.WriteAllText(LicenseFile, key);
        SaveTimestamp();
        return null; // 成功
    }

    static string ComputeHmac(string dateStr)
    {
        using var hmac = new HMACSHA256(SecretKey);
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dateStr));
        return Convert.ToHexString(hash)[..12];
    }

    static string? DetectTimeRollback()
    {
        if (!File.Exists(TsFile)) return null;

        var content = File.ReadAllText(TsFile).Trim();
        var storedBytes = Convert.FromHexString(content);
        // 解密：与固定值 XOR
        var key = "ZK"u8;
        for (int i = 0; i < storedBytes.Length; i++)
            storedBytes[i] ^= key[i % key.Length];

        var storedStr = Encoding.UTF8.GetString(storedBytes);
        if (!long.TryParse(storedStr, out var lastTicks)) return null;

        var lastCheck = new DateTime(lastTicks, DateTimeKind.Utc);
        var now = DateTime.UtcNow;

        if (now < lastCheck)
            return "检测到系统时间异常回退，请联系供应商。";

        return null;
    }

    static void SaveTimestamp()
    {
        var now = DateTime.UtcNow;
        var raw = Encoding.UTF8.GetBytes(now.Ticks.ToString());
        // 简单 XOR 混淆
        var key = "ZK"u8;
        for (int i = 0; i < raw.Length; i++)
            raw[i] ^= key[i % key.Length];

        Directory.CreateDirectory(Path.GetDirectoryName(TsFile)!);
        File.WriteAllText(TsFile, Convert.ToHexString(raw));
    }
}
