using ZC;
using ZC.LOG;
using ZC.IFS.Objects;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[RegisterToTaskService(TaskStartMode.Automatic)]
public class ImageCleanupServiceBase : AsyncMainTaskService, INamedObject
{
    private const string VisionFilesPath = "D:/Vision Files";
    private const int RetentionDays = 7;
    private static readonly TimeSpan CleanupInterval = TimeSpan.FromHours(1);

    public required ILogger Logger { get; init; }

    public string GetObjectName() => "IMAGE-CLEANUP";

    protected override async Task Main(CancellationToken ctk)
    {
        Logger.Info("Image cleanup service started, retention={Days} days, path={Path}", RetentionDays, VisionFilesPath);

        while (ctk.IsCancellationRequested == false)
        {
            try
            {
                CleanupExpiredFiles();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Image cleanup failed");
            }

            await Task.Delay(CleanupInterval, ctk);
        }

        Logger.Info("Image cleanup service stopped");
    }

    private void CleanupExpiredFiles()
    {
        if (!Directory.Exists(VisionFilesPath))
        {
            Logger.Debug("Vision files directory not found: {Path}", VisionFilesPath);
            return;
        }

        var cutoffDate = DateTime.Now.AddDays(-RetentionDays);
        var directories = Directory.GetDirectories(VisionFilesPath);
        var deletedCount = 0;
        var freedBytes = 0L;

        foreach (var dir in directories)
        {
            if (!TryParseDirectoryDate(dir, out var dirDate))
                continue;

            if (dirDate >= cutoffDate)
                continue;

            try
            {
                var dirInfo = new DirectoryInfo(dir);
                var dirSize = GetDirectorySize(dirInfo);
                DeleteDirectoryWithRetry(dirInfo);

                deletedCount++;
                freedBytes += dirSize;
                Logger.Debug("Deleted expired image directory: {Dir} (size={Size}KB)", dir, dirSize / 1024);
            }
            catch (Exception ex)
            {
                Logger.Warn(ex, "Failed to delete directory: {Dir}, error={Error}", dir, ex.Message);
            }
        }

        if (deletedCount > 0)
        {
            Logger.Info("Image cleanup completed: deleted {Count} directories, freed {Size}MB",
                deletedCount, freedBytes / (1024 * 1024));
        }
        else
        {
            Logger.Debug("Image cleanup: no expired directories found");
        }
    }

    private static bool TryParseDirectoryDate(string dirPath, out DateTime date)
    {
        date = default;
        var dirName = Path.GetFileName(dirPath);

        if (dirName.Length != 8)
            return false;

        if (!int.TryParse(dirName.AsSpan(0, 4), out var year))
            return false;
        if (!int.TryParse(dirName.AsSpan(4, 2), out var month))
            return false;
        if (!int.TryParse(dirName.AsSpan(6, 2), out var day))
            return false;

        return DateTime.TryParse($"{year}-{month:D2}-{day:D2}", out date);
    }

    private static long GetDirectorySize(DirectoryInfo dir)
    {
        long size = 0;
        try
        {
            foreach (var file in dir.GetFiles())
                size += file.Length;

            foreach (var subDir in dir.GetDirectories())
                size += GetDirectorySize(subDir);
        }
        catch
        {
            // Ignore access errors
        }
        return size;
    }

    private static void DeleteDirectoryWithRetry(DirectoryInfo dir, int maxRetries = 3, int delayMs = 1000)
    {
        for (var attempt = 1; attempt <= maxRetries; attempt++)
        {
            try
            {
                dir.Delete(true);
                return;
            }
            catch (IOException) when (attempt < maxRetries)
            {
                Thread.Sleep(delayMs);
            }
            catch (UnauthorizedAccessException) when (attempt < maxRetries)
            {
                Thread.Sleep(delayMs);
            }
        }
    }
}
