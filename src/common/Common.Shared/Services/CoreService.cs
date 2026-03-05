using NLog;
using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.Mvvm;
using ZitApp.BinStructs;
using ZitApp.Devices.Plc;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
public partial class CoreService : CoreServiceBase
{
	public required ConnectionManageService ConnectionManageService { get; init; }
	public required ILogger Logger { get; init; }
	public required PlcService Plc { get; init; }
	public partial string WorkNo { get; private set; } = "TestWorkNo0001";
	public partial int ProductCount { get; private set; } = 1234;
	public partial double OkPrecent { get; private set; } = 55.69;
	public partial int CT { get; private set; } = 10;
	public partial string WorkerNo { get; set; } = "00001";

	public override IMainTaskServiceOptions GetServiceOptions() => DefaultThreadMainTaskServiceOptions;

	protected override Task Main(CancellationToken ctk)
	{
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
		}

		return Task.CompletedTask;
	}

	public async Task<Result> RequestPlcWriteRecipeAsync()
	{
		Result result;
		Logger.Info("Requesting plc write recipe...");
		do
		{
			Plc.Write.PLC配方写入PC地址请求 = 0;
			result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
			if (result.IsError()) break;
			// wait plc reset signal
			await Task.Delay(200);
			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
			if (result.IsError()) break;
			if (Plc.Read.PLC配方写入PC地址响应 != 0)
			{
				result = Result.Err("plc is not reset response signal!");
				break;
			}

			Plc.Write.PLC配方写入PC地址请求 = 1;
			result = await Plc.Write.WritePointAsync(PlcStructInfo.PLC配方写入PC地址请求);
			if (result.IsError())
				break;
			// waiting plc write recipe
			await Task.Delay(500);
			result = await Plc.Read.ReadPointAsync(PlcStructInfo.PLC配方写入PC地址响应);
			if (result.IsError()) break;
			if (Plc.Read.PLC配方写入PC地址响应 != 1)
			{
				result = Result.Err("plc write recipe response signal timeout!");
				break;
			}
		} while (false);

		Logger.Info("Request Plc write recipe end.");
		return result;
	}

	public async Task<Result> DistributeRecipeAsync(ProductRecipe recipe)
	{
		var structInfo = recipe.GetStructInfo();
		Logger.Info("Start distribute recipe '{recipeName}'", recipe.Name);
		try
		{
			foreach (var pointInfo in structInfo.Members.Values.OfType<IBinaryPointInfo>())
			{
				var writerName = pointInfo.WriterData?.ToString();
				if (writerName == null)
					continue;
				var connection = ConnectionManageService.GetConnection(writerName) as IBinaryWriter;
				var writePointResult = await recipe.WritePointAsync(pointInfo, connection);
				if (writePointResult.IsError())
				{
					Logger.Error(writePointResult.Exception,
						"Distribute recipe write point error! writer='{writer}' {msg}", writerName,
						writePointResult.Message);
					return writePointResult;
				}
			}
		}
		finally
		{
			Logger.Info("End distribute recipe '{recipeName}'", recipe.Name);
		}

		return Result.OK;
	}

	public async Task<Result> CollectRecipeAsync(ProductRecipe recipe)
	{
		var reqResult = await RequestPlcWriteRecipeAsync();
		if (reqResult.IsError())
			return reqResult;
		var structInfo = recipe.GetStructInfo();
		foreach (var pointInfo in structInfo.Members.Values.OfType<IBinaryPointInfo>())
		{
			var readerName = pointInfo.ReaderData?.ToString();
			if (readerName == null)
				continue;
			var connection = ConnectionManageService.GetConnection(readerName) as IBinaryReader;
			var readPointResult = await recipe.ReadPointAsync(pointInfo, connection);
			Logger.Error(readPointResult.Exception,
				"collect recipe read point error! {msg}",
				readPointResult.Message);
			return Result.Err(readPointResult);
		}

		return Result.OK;
	}
}