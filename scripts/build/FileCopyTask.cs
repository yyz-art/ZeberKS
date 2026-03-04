using Microsoft.Build.Framework;
using Task = Microsoft.Build.Utilities.Task;

namespace ZC.Sln.Tasks;

public class FileCopyTask : Task
{
	[Required] public ITaskItem[] SourceFiles { get; set; } = Array.Empty<ITaskItem>();

	[Required] public string DestRoot { get; set; } = "";

	[Required] public string Mode { get; set; } = "incremental";

	public override bool Execute()
	{
		try
		{
			DestRoot = Path.GetFullPath(DestRoot);
			Log.LogMessage(MessageImportance.High, $"拷贝 {SourceFiles.Length} 个文件 -> {DestRoot} (模式: {Mode})");

			foreach (var item in SourceFiles)
			{
				var src = item.ItemSpec;

				// 保持目录结构
				var relativePath = Path.Combine(
					item.GetMetadata("RecursiveDir"),
					item.GetMetadata("Filename") + item.GetMetadata("Extension")
				);

				var destPath = Path.Combine(DestRoot, relativePath);
				Directory.CreateDirectory(Path.GetDirectoryName(destPath)!);

				bool needCopy = Mode switch
				{
					"full" => true,
					"skip" => !File.Exists(destPath),
					"incremental" => !File.Exists(destPath) ||
					                 File.GetLastWriteTimeUtc(src) > File.GetLastWriteTimeUtc(destPath),
					_ => throw new ArgumentException("模式必须是 full / incremental / skip")
				};

				if (needCopy)
				{
					File.Copy(src, destPath, true);
					Log.LogMessage(MessageImportance.Low, $"拷贝: {relativePath}");
				}
				else
				{
					Log.LogMessage(MessageImportance.Low, $"跳过: {relativePath}");
				}
			}

			return true;
		}
		catch (Exception ex)
		{
			Log.LogErrorFromException(ex);
			return false;
		}
	}
}