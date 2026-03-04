using System.IO;
using System.IO.Compression;
using ZC;

namespace ZitApp.Utils;

public static class ZipUtils
{
	/// <summary>
	/// 将多个文件打包成 ZIP 压缩包并写入到指定 Stream
	/// </summary>
	/// <param name="stream">目标输出流（例如 MemoryStream 或 Response.Body）</param>
	/// <param name="filePaths">要打包的文件路径列表</param>
	/// <returns>返回结果对象，包含成功与否和提示信息</returns>
	public static async Task<Result> WriteFilesZipToStream(Stream stream, List<string> filePaths)
	{
		Debug.Assert(filePaths != null);
		try
		{
			if (stream.CanWrite == false)
				return Result.Err("输出流不可用");
			if (filePaths.Count == 0)
				return Result.Err("文件列表为空");

			await using var archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true);
			foreach (var file in filePaths)
			{
				if (File.Exists(file))
				{
					var entryName = Path.GetFileName(file);
					await archive.CreateEntryFromFileAsync(file, entryName, CompressionLevel.Optimal);
				}
			}

			return Result.OK;
		}
		catch (Exception ex)
		{
			return Result.Err(ex);
		}
	}

	public static async Task<Result> CreateFilesZipToLocalFS(string outputPath, List<string> filePaths)
	{
		await using var fs = new FileStream(outputPath, FileMode.OpenOrCreate);
		fs.Seek(0, SeekOrigin.Begin);
		fs.SetLength(0);
		var result = await WriteFilesZipToStream(fs, filePaths);
		return result;
	}
}