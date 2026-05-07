using ZC;
using ZC.BinStructs;
using ZC.BinStructs.Ext;

namespace ZitApp.BinStructs;

public static class BinStructExtensions
{
	public static Result WritePointTryTimes(
		this IBinaryStruct self, IBinaryPointInfo pointInfo,
		int maxTimes = -1,
		int reTrydelayMs = 500)
	{
		var cnt = maxTimes;
		Result result;
		while (cnt > 0 || cnt == -1)
		{
			result = self.WritePoint(pointInfo);
			if (result.IsOk())
				break;
			if (cnt > 0)
				cnt--;
			if (cnt == 0)
				break;
			if (reTrydelayMs > 0)
				Thread.Sleep(reTrydelayMs);
		}

		return result;
	}

	public struct ReTryWritePointContext<TContext>
	{
		public TContext Context;
		public IBinaryPointInfo PointInfo;
		public IBinaryStruct Struct;
		public Result Result;
	}

	public static Result TryWritePoint<TContext>(
		this IBinaryStruct self, IBinaryPointInfo pointInfo, TContext context,
		Func<ReTryWritePointContext<TContext>, bool> canRetry)
	{
		var retry = false;
		Result result;
		do
		{
			result = self.WritePoint(pointInfo);
			if (result.IsOk()) break;
			var ctx = new ReTryWritePointContext<TContext>
				{ Context = context, PointInfo = pointInfo, Struct = self, Result = result };
			retry = canRetry(ctx);
		} while (retry);

		return result;
	}
	
	public static Result TryWritePoint<TContext>(
		this IBinaryStruct self, string pointName, TContext context,
		Func<ReTryWritePointContext<TContext>, bool> canRetry)
	{
		var binaryStructInfo = self.GetStructInfo();
		var pointInfo = binaryStructInfo.Members.GetValueOrDefault(pointName.AsMemory()) as IBinaryPointInfo;
		var retry = false;
		Result result;
		do
		{
			result = self.WritePoint(pointInfo!);
			if (result.IsOk()) break;
			var ctx = new ReTryWritePointContext<TContext>
				{ Context = context, PointInfo = pointInfo!, Struct = self, Result = result };
			retry = canRetry(ctx);
		} while (retry);

		return result;
	}
}