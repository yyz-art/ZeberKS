using System.Text;
using System.Text.RegularExpressions;
using ZC;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.LOG;
using ZC.Mvvm;

namespace ZitApp.Services;

[ObservableObject]
public abstract partial class WorkServiceBase : MainTaskService
{
	public static readonly byte[] StartScanCommandBytes = HexUtils.Parse("04 E4 04 00 FF 14");
	public static readonly byte[] StartScanResponseBytes = HexUtils.Parse("04 D0 00 00 FF 2C");
	public static readonly byte[] StopScanCommandBytes = HexUtils.Parse("04 E5 04 00 FF 13");
	public const int CodeOfOK = 1;
	public const int CodeOfNG = 2;
	public const int CodeOfRecipeHold = 3;
	public const int ALLOW_PRODUCTION = 1;
	public const int NOT_ALLOW_PRODUCTION_BY_SCAN_CODE = 2;
	public const int NOT_ALLOW_PRODUCTION_BY_MES = 2;
	public const int NOT_ALLOW_PRODUCTION_BY_RECIPE = 3;
	public const int NOT_ALLOW_PRODUCTION_BY_MATERIAL = 4;

	public required ILogger Logger { get; init; }
	// public partial int DayProductionId { get; set; }

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected Result<string> DoScanCode(IDataSocket codeScanner)
	{
		codeScanner.ReadToDiscard();
		Span<byte> byteBuffer = stackalloc byte[1024];
		var writeResult = codeScanner.Write(StartScanCommandBytes);
		if (writeResult.IsError())
			return Result.Err<string>("send scanner command failed, connection error!");
		var readResult = codeScanner.ReadContinuous(byteBuffer, 2000, 200);
		if (readResult.IsError())
		{
			// Logger.Error("code scanner read timeout! {msg}", readResult.Message);
			return Result.Err<string>("code scanner read timeout!");
		}

		var readLength = readResult.Value;
		if (false == byteBuffer.StartsWith(StartScanResponseBytes))
		{
			var responseHex = HexUtils.ToString(byteBuffer[..readLength]);
			return Result.Err<string>($"code scanner response format error: '{responseHex}'");
		}

		Span<char> charBuffer = stackalloc char[1024];
		var codeBytes = byteBuffer.Slice(StartScanResponseBytes.Length,
			readLength - StartScanResponseBytes.Length);
		if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
		{
			var responseHex = HexUtils.ToString(byteBuffer.Slice(0, readLength));
			return Result.Err<string>($"code scanner response format error: '{responseHex}'");
		}

		var code = charBuffer.Slice(0, codeLength).Trim().ToString();
		return Result.Ok<string>(code);
	}

	protected string GenerateTopic(string msg, string staName)
	{
		/*
		 * var content = mesMsg7Result.Value!;
					var vars = content.Split(';');
					var idx1 = content.IndexOf("DCS=", StringComparison.Ordinal);
					var idx1End = content.IndexOf(',', idx1);
					var bu = content[(idx1 + "DCS=".Length)..idx1End];
					idx1 = content.IndexOf("TIMON=", StringComparison.Ordinal);
					idx1End = content.IndexOf(',', idx1);
					var productFamily = content[(idx1 + "TIMON=".Length)..idx1End];
					idx1 = content.IndexOf("SN_NOW_GROUP=", StringComparison.Ordinal);
					idx1End = content.IndexOf(',', idx1);
					var process = content[(idx1 + "SN_NOW_GROUP=".Length)..idx1End];

					var modelNameIdx = content.LastIndexOf("MODEL_NAME=", StringComparison.Ordinal);
					var buIdx = content.IndexOf(',', modelNameIdx);
		 */


		//OK7,GET_PN=1005-070110-2B ZEBRA_DTG=MODEL_NAME=1005-070110-2B,DCS=HH,TIMON=TC1X,GROUP_NAME=CCD1,CCD2,CCD3,CCD4; SN_NOW_GROUP=ASM10
		// "supplier$ site $  bu $product_family$process$station_id"
		//   USI    $  KS  $ EMC $   SRV        $ ASM1  $  ASM101
		// supplier$site$bu $product_family$process$station_id ($serial_number $uuid)


		string factory = "USI"; //supplier
		string site = "HPH"; //KS or HPH
		string station = staName; //station_id
		string input = msg;

		////PN获取,可用于自动调用配方
		Match PnMatch = Regex.Match(input, @"GET_PN\s*=\s*([^\s,;=]+)", RegexOptions.IgnoreCase);
		string PN = PnMatch.Success ? PnMatch.Groups[1].Value : "";
		if (PN == "")
		{
			return "";
		}


		//BU 提取 DCS 的值（只匹配 DCS=...）
		Match dcsMatch = Regex.Match(input, @"DCS\s*=\s*([^\s,;=]+)", RegexOptions.IgnoreCase);
		string DCS = dcsMatch.Success ? dcsMatch.Groups[1].Value : "";
		if (DCS == "")
		{
			return "";
		}

		//product_family 提取 TIMON 的值
		Match timonMatch = Regex.Match(input, @"TIMON\s*=\s*([^\s,;=]+)", RegexOptions.IgnoreCase);
		string TIMON = timonMatch.Success ? timonMatch.Groups[1].Value : "";
		if (TIMON == "")
		{
			return "";
		}

		//process 提取 SN_NOW_GROUP 的值（注意下划线和可能的 -）
		Match snGroupMatch = Regex.Match(input, @"SN_NOW_GROUP\s*=\s*([^\s;=]+)", RegexOptions.IgnoreCase);
		string SN_NOW_GROUP = snGroupMatch.Success ? snGroupMatch.Groups[1].Value : "";
		if (SN_NOW_GROUP == "")
		{
			return "";
		}

		string topic = $"{factory}${site}${DCS}${TIMON}${SN_NOW_GROUP}${station}";
		return topic;
	}


	public static void CreateImagePackageZip(string outputPath,
		string[] imageFiles, // 修改：支持文件数组
		string serialNumber,
		string topicTemplate,
		string uuid,
		Action<string>? log = null)
	{
		// "supplier$site$bu$product_family$process$station_id"
		//USI$KS$EMC$SRV$ASM1$ASM101
		//$USI$KS$DCS$RHINO$T3$CCD2-NOKP
		// string topicTemplate = Form_Setting.Topic;
		//查询出bu.product_family

		string[] topics = topicTemplate.Split('$');
		outputPath = Path.Combine(outputPath, DateTime.Now.ToString("yyyyMMdd"));
		if (!Directory.Exists(outputPath))
			Directory.CreateDirectory(outputPath);


		var validFiles = imageFiles.Where(f => !string.IsNullOrWhiteSpace(f) && File.Exists(f)).ToList();
		if (validFiles.Count == 0)
		{
			log?.Invoke("所有提供的文件路径均无效或不存在");
			return;
		}

		if (string.IsNullOrWhiteSpace(outputPath))
		{
			log?.Invoke("输出目录不能为空");
			return;
		}

		// ===== 设置输出目录 =====     
		if (!Directory.Exists(outputPath))
		{
			try
			{
				Directory.CreateDirectory(outputPath);
				log?.Invoke($"已创建输出目录: {outputPath}");
			}
			catch (Exception ex)
			{
				log?.Invoke($"创建输出目录失败: {ex.Message}");
				return;
			}
		}

		if (string.IsNullOrWhiteSpace(serialNumber))
		{
			log?.Invoke($"SN不能为空");
			return;
		}

		// ===== 开始压缩 =====
		CreateZipArchiveSync(serialNumber, topicTemplate, uuid, log, outputPath, validFiles);
	}

	public static void CreateZipArchiveSync(string serialNumber, string topicTemplate, string uuid, Action<string> log,
		string outputZipDirectory, List<string> validFiles)
	{
		string zipFileName = $"{uuid}_{serialNumber}.zip";
		string zipFilePath = Path.Combine(outputZipDirectory, zipFileName);

		// ===== 构建全局注释 =====
		string globalComment = $"{topicTemplate}${serialNumber}${uuid}";
		log?.Invoke($"ZIP Comment:\n{globalComment}");
		try
		{
			// ===== 生成唯一标识和ZIP文件名 =====
			// string uuid = Guid.NewGuid().ToString();
			using (FileStream fs = File.Create(zipFilePath))
			using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream =
			       new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fs))
			{
				zipStream.SetLevel(6); // 压缩等级：6（平衡速度与压缩率）
				zipStream.SetComment(globalComment); // 设置全局注释
				zipStream.IsStreamOwner = true; // 关闭流时自动关闭底层FileStream

				// 遍历所有有效文件
				foreach (string filePath in validFiles)
				{
					string entryName = Path.GetFileName(filePath); // 只保留文件名，不包含路径

					zipStream.PutNextEntry(new ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName)
					{
						DateTime = File.GetLastWriteTime(filePath),
						Size = new FileInfo(filePath).Length // 显式设置大小（可选）
					});

					using (FileStream fileStream = File.OpenRead(filePath))
					{
						fileStream.CopyTo(zipStream, 81920); // 80KB buffer
					}

					zipStream.CloseEntry();
					log?.Invoke($"已添加文件到ZIP: {entryName}");
				}

				zipStream.Finish(); // 完成压缩（非常重要！）
			}

			log?.Invoke($"ZIP 创建成功:\n{zipFilePath}");
		}
		catch (Exception ex)
		{
			log?.Invoke($"压缩失败: {ex.Message}");
			if (File.Exists(zipFilePath))
			{
				try
				{
					File.Delete(zipFilePath);
				}
				catch (Exception delEx)
				{
					log?.Invoke($"清理失败文件时出错: {delEx.Message}");
				}
			}
		}
	}
	
	protected static (string? WorkOrder, string? ModelName) ParseMesModelInfo(string? rawAscii)
	{
		if (string.IsNullOrEmpty(rawAscii))
			return (null, null);

		string? workOrder = null;
		string? modelName = null;
		var parts = rawAscii.Split([',', ' ', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
		foreach (var part in parts)
		{
			var cleanPart = part.Trim();
			var upper = cleanPart.ToUpperInvariant();
			var equalsIndex = cleanPart.IndexOf('=');
			if (equalsIndex < 0)
				continue;

			var value = cleanPart[(equalsIndex + 1)..].Trim();
			if (upper.StartsWith("MO_NUMBER="))
				workOrder = value;
			else if (upper.StartsWith("MODEL_NAME="))
				modelName = value;
		}

		return (workOrder, modelName);
	}
}