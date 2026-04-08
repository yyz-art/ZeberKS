using System.Text;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.Mvvm;
using ZitApp.BinStructs;
namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
// [RegisterToTaskService(TaskStartMode.Automatic)]
public partial class WorkRightService : WorkServiceBase
{
	private readonly byte[] _buffer = new byte[1024];
	public override string ServiceName => "WorkRight";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public partial string 机种型号 { get; set; } = "";
	public partial string 扫码 { get; set; } = "";

	protected override Task Main(CancellationToken ctk)
	{
		Span<char> charBuffer = stackalloc char[1024];
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
			// 扫码信号清空
			if (Plc.Read.扫码枪2触发 == 0 && Plc.Read.扫码枪2触发结果 != 0)
			{
				Plc.Write.扫码枪2触发结果 = 0;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp(
					"Clear left scanner result failed!");
				continue;
			}

			// 入站扫码
			if (Plc.Read.扫码枪2触发 is 1)
			{
				Socket.ReadToDiscard().Unwarp("Clear left scanner cache failed!");
				Socket.Write(StartScanCommandBytes).Unwarp("Send left scanner scan command failed!");
				var readLength = Socket.ReadContinuous(_buffer, 2000, 200).Unwarp("Read scan result");
				// OK: start with "04 D0 00 00 FF 2C{code}"
				if (false == _buffer.StartsWith(StartScanResponseBytes))
				{
					var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
					Logger.Error("Start scan command response data is error! {}", responseHex);
					goto SendCodeNG;
				}

				var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length, readLength - StartScanResponseBytes.Length);
				if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
				{
					var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
					Logger.Error("Start scan command response code is error! {}", responseHex);
					goto SendCodeNG;
				}

				扫码 = charBuffer.Slice(0, codeLength).ToString();
				Logger.Info("Scanned code is '{code}'", 扫码);
				// MES 入站请求
				var mesMsg1Result = Mes.SendMessage1(Core.工号, 扫码);
				Logger.Info("request sifi msg 1 with code: '{}'", 扫码);
				if (mesMsg1Result.IsError())
				{
					Logger.Error(mesMsg1Result.Exception, "request mes msg 1 error: {}", mesMsg1Result.Message);
					Plc.Write.工位2允许生产 = 2;
					goto SendCodeNG;
				}

				Logger.Info("request sifi msg 7 with code: '{}'", 扫码);
				// MES 查询工单号和机种型号
				var mesMsg7Result = Mes.SendMessage7(Core.工号, 扫码);
				if (mesMsg7Result.IsError())
				{
					Logger.Error(mesMsg7Result.Exception, "request mes msg 7 error: {}", mesMsg7Result.Message);
					Plc.Write.工位2允许生产 = 2;
					goto SendCodeNG;
				}

				var response = mesMsg7Result.Value;
				var variableMemoryEnumerator = response.GetVariableMemoryEnumerator();
				string? 工单号 = null;
				string? 机种名 = null;
				while (variableMemoryEnumerator.MoveNext(out var varName, out var varValue))
				{
					if (varName.Span is "MO_NUMBER")
						工单号 = varValue.ToString();
					else if (varName.Span is "MODEL_NAME")
						机种名 = varValue.ToString();
				}

				if (string.IsNullOrEmpty(工单号) || string.IsNullOrEmpty(机种名))
				{
					Logger.Error("request mes msg 7 get 'MO_NUMBER & MODEL_NAME' is null with code: '{}'", 扫码);
					Plc.Write.工位2允许生产 = 2;
					goto SendCodeNG;
				}

				// 验证配方是否是当前工作配方 false 不允许生产
				if (false == Core.CheckRecipe(机种名))
				{
					Logger.Warn("recipe not matched, please with switch!");
					var requestStartSwitchRecipeResult = Core.RequestStartSwitchRecipe(机种名);
					if (requestStartSwitchRecipeResult.IsError())
					{
						Logger.Error(requestStartSwitchRecipeResult.Exception, "recipe start switch failed! {}",
							requestStartSwitchRecipeResult.Message);
					}

					Plc.Write.工位2允许生产 = 3;
					goto SendCodeOK;
				}

				// 验证配方物料是否一致  false 不允许生产
				if (false == Core.CheckRecipeMono(机种名))
				{
					Logger.Warn("recipe mono not matched, please with switch!");
					Plc.Write.工位2允许生产 = 4;
					goto SendCodeOK;
				}

				Plc.Write.工位2允许生产 = 1;

				SendCodeOK:
				Plc.Write.WritePoint(PlcStructInfo.工位2允许生产);
				Plc.Write.扫码枪2触发结果 = CodeOfOK;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp("write left scanner scan result failed!");
				continue;
				SendCodeNG:
				Plc.Write.WritePoint(PlcStructInfo.工位2允许生产);
				Plc.Write.扫码枪2触发结果 = CodeOfNG;
				Plc.Write.WritePoint(PlcStructInfo.扫码枪2触发结果).Unwarp("write left scanner scan result failed!");
				continue;
			}

			// 数据上报请求信号清空
			if (Plc.Read.工位2数据上报请求 is 0 && Plc.Read.工位2数据上报响应 is not 0)
			{
				Plc.Write.工位2数据上报响应 = 0;
				Plc.Write.WritePoint(PlcStructInfo.工位2数据上报响应).Unwarp(
					"clear work left upload result!");
				continue;
			}

			// 数据上报
			if (Plc.Read.工位2数据上报请求 is 1 or 2)
			{
				if (string.IsNullOrEmpty(扫码))
				{
					Logger.Error("plc upload result must scan code, current code is null!");
					goto SendNG;
				}

				// 可以添加上传的数据
				// var payloadBuilder = new SifsPayloadBuilder();
				// payloadBuilder.AddVariable("扭力", 1.3f);
				// var respMsg2Result = Mes.SendMessage2(Core.OperatorId, Code, payloadBuilder);
				var respMsg2Result = Mes.SendMessage2(Core.工号, 扫码, null);
				if (respMsg2Result.IsError())
				{
					Logger.Error(respMsg2Result.Exception, "request mes msg 2 error: {}", respMsg2Result.Message);
					goto SendNG;
				}

				SendOK:
				Plc.Write.工位2数据上报响应 = 1;
				Plc.Write.WritePoint(PlcStructInfo.工位2数据上报响应).Unwarp();
				continue;
				SendNG:
				Plc.Write.工位2数据上报响应 = 2;
				Plc.Write.WritePoint(PlcStructInfo.工位2数据上报响应).Unwarp();
			}

			// 检查允许生产信号，尝试检查
			if (Plc.Read.工位2允许生产 != 1 && false == string.IsNullOrEmpty(机种型号))
			{
				// 下发的配方对比, PLC已经使用的配方对比
				if (Core.当前下发配方?.机种型号 != 机种型号 || Core.当前下发配方.Id != Plc.Read.PLC当前配方ID)
				{
					Plc.Write.工位2允许生产 = 3;
					Plc.Write.WritePoint(PlcStructInfo.工位2允许生产).Unwarp();
					continue;
				}

				var isMatched = Core.CheckRecipeMono(机种型号);
				if (isMatched == false)
				{
					Plc.Write.工位2允许生产 = 4;
					Plc.Write.WritePoint(PlcStructInfo.工位2允许生产).Unwarp();
					continue;
				}

				Plc.Write.工位2允许生产 = 1;
				Plc.Write.WritePoint(PlcStructInfo.工位2允许生产).Unwarp();
				continue;
			}
		}

		return Task.CompletedTask;
	}
}