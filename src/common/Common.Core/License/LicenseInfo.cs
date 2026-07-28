namespace ZitApp.License;

/// <summary>
/// License validation result status.
/// </summary>
public enum LicenseStatus
{
    Valid,
    Expired,
    InvalidFormat,
    InvalidSignature,
    TimeRollbackDetected,
    NotActivated,
}

/// <summary>
/// Value object representing the parsed and validated license information.
/// </summary>
public sealed class LicenseInfo
{
    public DateOnly ExpiryDate { get; }
    public LicenseStatus Status { get; }
    public string? RawKey { get; }
    public string? Message { get; }

    public bool IsValid => Status == LicenseStatus.Valid;
    public bool IsExpired => Status == LicenseStatus.Expired;
    public bool IsBlocking => Status != LicenseStatus.Valid;

    private LicenseInfo(DateOnly expiryDate, LicenseStatus status, string? rawKey, string? message)
    {
        ExpiryDate = expiryDate;
        Status = status;
        RawKey = rawKey;
        Message = message;
    }

    public static LicenseInfo Valid(DateOnly expiryDate, string? rawKey) =>
        new(expiryDate, LicenseStatus.Valid, rawKey, null);

    public static LicenseInfo Error(LicenseStatus status, string message) =>
        new(default, status, null, message);
}
