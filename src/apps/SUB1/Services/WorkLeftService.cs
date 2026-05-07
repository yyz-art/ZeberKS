using System.Text;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.Mvvm;
using ZC.Utils;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class WorkLeftService : WorkServiceBase
{
	private readonly byte[] _buffer = new byte[1024];
	public partial WorkStep WorkStep { get; private set; } = WorkStep.COMPLETED;
	public override string ServiceName => "WP-1";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public required AppConfig AppConfig { get; init; }
	public IDataSocket CodeScanner { get; set; } = null!;
	public partial string ModelName { get; set; } = "";
	public partial string ScanCode { get; set; } = "";
	public partial string? LastError { get; private set; }
	public partial string? ImagePathRoot { get; set; }
	public partial OkNgState OkNgState { get; set; }
	public partial int InStationStatusCode { get; set; }
	public partial OutStationStatusCode OutStationStatusCode { get; set; }

	protected override Task OnInitialize(object? ctx, object? args)
	{
		CodeScanner = App.Current.IOC.Get<IDataSocket>("Scanner工位1");
		Task.Run(() => CodeScanner.Open());
		return base.OnInitialize(ctx, args);
	}

	protected override Task Main(CancellationToken ctk)
	{
		Thread.Sleep(2000);
		var charBuffer = new char[1024];
		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();

			if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
			{
				Plc.Write.扫码枪1触发结果 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.扫码枪1触发结果)).Unwarp("clear code scanner signal failed!");
				continue;
			}

			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 })
			{
				OkNgState = OkNgState.NA;
				WorkStep = WorkStep.SCAN_CODE_DOING;
				ScanCode = "";
				ModelName = "";
				try
				{
					Logger.Info("[SCAN-CODE] [DOING] ...");
					if (CommonAppConfig.IsDevTestMode == false && CodeScanner is not { IsOpen: true })
					{
						var openResult = CodeScanner.Open();
						if (openResult.IsError())
						{
							Logger.Error("Code scanner open failed: {msg}", openResult.Message);
							LastError = "Code scanner open failed";
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}
					}

					if (CommonAppConfig.IsDevTestMode == false)
					{
						CodeScanner.ReadToDiscard();

						var writeResult = CodeScanner.Write(StartScanCommandBytes);
						if (writeResult.IsError())
						{
							Logger.Error("Code scanner send command failed: {msg}", writeResult.Message);
							LastError = "Code scanner send command failed";
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						var readResult = CodeScanner.ReadContinuous(_buffer, 2000, 200);
						if (readResult.IsError())
						{
							Logger.Error("Code scanner read failed: {msg}", readResult.Message);
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						var readLength = readResult.Value;
						if (false == _buffer.StartsWith(StartScanResponseBytes))
						{
							var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
							Logger.Error("Code scanner response format error: {hex}", responseHex);
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						var codeBytes = _buffer.AsSpan(StartScanResponseBytes.Length,
							readLength - StartScanResponseBytes.Length);
						if (false == Encoding.UTF8.TryGetChars(codeBytes, charBuffer, out var codeLength))
						{
							var responseHex = HexUtils.ToString(_buffer.AsSpan(0, readLength));
							Logger.Error("Code scanner response format error, raw data is '{hex}'", responseHex);
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						ScanCode = new string(charBuffer, 0, codeLength).Trim();
						if (string.IsNullOrWhiteSpace(ScanCode) || ScanCode.Length < AppConfig.SnCodeMinLength)
						{
							Logger.Error("Code length check failed, code = '{code}'，length = {length}，not allow production.",
								ScanCode,
								ScanCode.Length);
							Plc.Write.工位1允许生产 = 2;
							LastError = "code length check failed!";
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}
					}
					else
					{
						ScanCode = $"DEBUG-TEST-{DateTime.Now:yyyyMMdd-HHmmss}";
					}


					WorkStep = WorkStep.SCAN_CODE_COMPLETED;
					Logger.Info("[SCAN-CODE] [OK] CONTENT='{code}'", ScanCode);


					if (Core.MesSkipEnabled)
					{
						Logger.Info("[MES IN-STA] [OK:Skip] SN={sn}", ScanCode);
						Plc.Write.扫码枪1触发结果 = CodeOfOK;
						Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;
						goto SendResult;
					}

					#region MES-QUERY

					WorkStep = WorkStep.MES_QUERY_DOING;
					var mes7 = $"ASM_QUERY,{ScanCode},7,,SMD,,OK,MO_NUMBER=??? MODEL_NAME=???";
					Logger.Info($"[MES QUERY] [DOING] MES << '{mes7}'");
					var mesMsg7Result = Mes.SendAndReadString(mes7);
					// var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码);
					if (mesMsg7Result.IsError())
					{
						Logger.Error(LastError = $"[MES QUERY] [ERROR] MES connection error! {mesMsg7Result.Message}");
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					if (mesMsg7Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error(LastError = $"[MES QUERY] [ERROR] MES << '{mesMsg7Result.Value}'");
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var rawAscii = mesMsg7Result.Value;
					var parseResult = ParseMesModelInfo(rawAscii);
					if (parseResult.WorkOrder is null || parseResult.ModelName is null)
					{
						Logger.Error(LastError =
							$"[MES QUERY] [ERROR] (MO_NUMBER='{parseResult.WorkOrder}',MODEL_NAME='{parseResult.ModelName}')] has empty value!");
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}


					Core.WorkOrderNo = parseResult.WorkOrder;
					ModelName = parseResult.ModelName;
					Logger.Info($"[MES QUERY] [OK] MO_NUMBER='{Core.WorkOrderNo}' MODEL_NAME='{ModelName}'");

					#endregion

					#region RECIPE-CHECK

					WorkStep = WorkStep.RECIPE_CHECK;
					// Logger.Info($"[RECIPE CHECK] [DOING] SN='{ScanCode}' MODEL_NAME='{ModelName}'");
					var recipeResult = Core.Recipe.GetRecipeByModelName(ModelName);
					if (recipeResult.IsError())
					{
						Logger.Error($"[RECIPE CHECK] [ERROR] Recipe not found! SN='{ScanCode}' MODEL_NAME='{ModelName}'");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var recipe = recipeResult.Value!;
					if (Core.RecipeCheck == false)
						Logger.Info($"[RECIPE CHECK] [OK:UnCheck] SN='{ScanCode}' MODEL_NAME='{ModelName}'");
					else if (Plc.Read.上位机当前配方ID != Plc.Read.PLC当前配方ID || Plc.Read.PLC当前配方ID != recipeResult.Value!.Id)
					{
						Logger.Info($"[RECIPE CHANGE] [DOING]" +
						            $" Old(PLC-ID={Plc.Read.PLC当前配方ID}', PC-ID={Plc.Read.上位机当前配方ID}) =>" +
						            $" New(Id={recipe.Id}, Name={recipe.Name}, ModelName='{recipe.ModelName}')");
						
						if (false == Core.RecipeSwitchLock.Wait(TimeSpan.FromSeconds(AppConfig.RecipeSwitchWaitTimeout)))
						{
							Logger.Error("[RECIPE CHANGE] [ERROR] Wait lock timeout! ");
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						try
						{
							if (Plc.Read.上位机当前配方ID != Plc.Read.PLC当前配方ID || Plc.Read.PLC当前配方ID != recipeResult.Value!.Id)
							{
								if (Core.IsWorkPositionFree() == false)
								{
									Logger.Warn($"[RECIPE CHANGE] [FAILL] work position is doing ,can't change recipe!");
									Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
									Plc.Write.扫码枪1触发结果 = CodeOfNG;
									goto SendResult;
								}
								WorkStep = WorkStep.RECIPE_SEND;
								Logger.Info("[RECIPE CHANGE] Recipe data sending ...! ");
								var distributeRecipeTask = Core.DistributeRecipeAsync(recipeResult.Value!);
								distributeRecipeTask.Wait();
								if (distributeRecipeTask.Result.IsError())
								{
									Logger.Error(
										$"[RECIPE CHANGE] [ERROR] Recipe data send failed! {distributeRecipeTask.Exception?.Message ?? distributeRecipeTask.Result.Message} ");
									Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
									Plc.Write.扫码枪1触发结果 = CodeOfNG;
									goto SendResult;
								}

								Logger.Info("[RECIPE CHANGE] Recipe data sended.");
								WorkStep = WorkStep.RECIPE_WAIT;
								var startWaitTime = DateTime.Now;
								var endWaitTime = startWaitTime.AddMilliseconds(AppConfig.RecipeSwitchWaitTimeout);
								if (CommonAppConfig.IsDevTestMode)
								{
									Plc.Write.PLC当前配方ID = (short)recipe.Id;
									Plc.Write.WritePoint(nameof(PlcStruct.PLC当前配方ID));
									Plc.Write.PLC读取配方ID切换成功响应 = 1;
									Plc.Write.WritePoint(nameof(PlcStruct.PLC读取配方ID切换成功响应));
								}

								while (Plc.Read.PLC读取配方ID切换成功响应 != 1 &&
								       DateTime.Now < endWaitTime)
									Thread.Sleep(100);
								if (Plc.Read.PLC读取配方ID切换成功响应 != 1)
								{
									Logger.Error("[RECIPE CHANGE] [ERROR] Wait plc change recipe timeout.");
									Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
									Plc.Write.扫码枪1触发结果 = CodeOfNG;
									goto SendResult;
								}

								Core.WorkRecipe = recipe;
								Logger.Info("[RECIPE CHANGE] [OK] Recipe changed successfully!.");
							}
						}
						finally
						{
							Core.RecipeSwitchLock.Release();
						}
					}
					else
						Logger.Info($"[RECIPE CHECK] [OK] SN='{ScanCode}' MODEL_NAME='{ModelName}'");

					#endregion

					#region MATERIAL-CHECK

					if (Core.MaterialCheck)
					{
						var isMaterialStateOk = true;
						MaterialSpaceContext? material = null;
						foreach (var item in Core.MaterialContexts)
						{
							if (item.Config.IsUsed == false) continue;
							item.CheckMaterialState();
							if (item.MaterialState == MaterialState.OK)
								continue;
							isMaterialStateOk = false;
							material = item;
							break;
						}

						if (isMaterialStateOk)
							Logger.Info($"[MATERIAL CHECK] [OK] SN='{ScanCode}' MODEL_NAME='{ModelName}'");
						else
						{
							Logger.Error(
								$"[MATERIAL CHECK] [ERROR] at material {material?.Id} state is '{material?.MaterialState}' SN='{ScanCode}' MODEL_NAME='{ModelName}'");
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							LastError = "MATERIAL CHECK FAILED!";
							goto SendResult;
						}
					}
					else Logger.Info($"[MATERIAL CHECK] [OK:UnCheck] SN='{ScanCode}' MODEL_NAME='{ModelName}'");

					#endregion

					#region MES-IN-STA

					var msg1 =
						$"{AppConfig.StationName.Trim()},{ScanCode.Trim()},1,{Core.WorkerNo.Trim()},{AppConfig.Line.Trim()},,OK,,,";
					WorkStep = WorkStep.MES_IN_STATION_DOING;
					Logger.Info($"[MES IN-STA] [DOING] MES << '{msg1}'");
					var mesMsg1Result = Mes.SendAndReadString(msg1);
					WorkStep = WorkStep.MES_IN_STATION_COMPLETED;
					if (mesMsg1Result.IsError())
					{
						Logger.Error(LastError = $"[MES IN-STA] [ERROR] MES connection error!");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					if (mesMsg1Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error($"[MES IN-STA] [ERROR] MES >> '{mesMsg1Result.Value}'");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					Logger.Info($"[MES IN-STA] [OK] MES >> '{mesMsg1Result.Value}'");

					#endregion

					Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;
					Plc.Write.扫码枪1触发结果 = CodeOfOK;
				}
				catch (Exception ex)
				{
					Logger.Error(ex, "入站扫码工作站发生致命异常: {msg}", ex.Message);
					Plc.Write.工位1允许生产 = 2;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}

				SendResult:
				if (DayProductionId == 0)
					DayProductionId = Core.GetDayProductionId();
				var now = DateTime.Now;
				ImagePathRoot = Path.Combine(AppConfig.VisionImagePath,
					now.ToString("yyyy-MM"), now.ToString("dd"), $"{DayProductionId}_{ScanCode}");
				// Logger.Info($"[VISION FILE] image path is '{ImagePathRoot}'");
				Plc.Write.扫码枪1触发 = 0;
				Logger.Info(
					$"[MES IN-STA] [DONE] SCAN=({Plc.Write.扫码枪1触发结果},'{ScanCode}') EN={Plc.Write.工位1允许生产}");
				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1允许生产), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc allow production result failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
				Plc.Write.工位1生产序号 = (short)DayProductionId;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1生产序号));
				Plc.Plc.Write($"{PlcStructInfo.扫码枪1扫码内容.Offset}", ScanCode, 80);
				Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发结果), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc code scan signal failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});

				if (CommonAppConfig.IsDevTestMode)
				{
					Plc.Write.扫码枪1触发 = 0;
					Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发), this, static ctx =>
					{
						ctx.Context.Logger.Error(
							$"[MES IN-STA] [ERROR] write plc code scan result failed by plc connection error! {ctx.Result.Message}");
						Thread.Sleep(5000);
						return true;
					});
				}

				WorkStep = WorkStep.MES_OUT_STATION_WAITING;
				continue;
			}


			if (Plc.Read.工位1数据上报请求 is 0 && Plc.Read.工位1数据上报响应 is not 0)
			{
				Plc.Write.工位1数据上报响应 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报响应)).Unwarp("clear work left upload result!");
				continue;
			}

			if (Plc.Read is { 工位1数据上报请求: 1, 工位1数据上报响应: 0 })
			{
				WorkStep = WorkStep.MES_OUT_STATION_DOING;
				if (string.IsNullOrEmpty(ScanCode))
				{
					OutStationStatusCode = OutStationStatusCode.SN_IS_EMPTY;
					Logger.Error("[MES OUT-STA] [ERROR] Plc upload result must scan code, current code is null!");
					goto SendOutStationResult;
				}

				if (Core.MesSkipEnabled)
				{
					OutStationStatusCode = OutStationStatusCode.Success;
					Logger.Info("[MES OUT-STA] [OK:Skip] SN='{sn}'", ScanCode);
					goto SendOutStationResult;
				}

				var msg2 = $"{AppConfig.StationName},{ScanCode},2,{Core.WorkerNo},{AppConfig.Line},,OK,,,";
				Logger.Info($"[MES OUT-STA] [DOING] MES << '{msg2}'");
				var respMsg2Result = Mes.SendAndReadString(msg2);
				if (respMsg2Result.IsError())
				{
					OutStationStatusCode = OutStationStatusCode.MES_RESPONSE_ERROR;
					Logger.Error(respMsg2Result.Exception, $"[MES OUT-STA] [ERROR] {respMsg2Result.Message}");
					goto SendOutStationResult;
				}

				if (respMsg2Result.Value!.StartsWith("OK") is false)
				{
					OutStationStatusCode = OutStationStatusCode.MES_RESPONSE_ERROR;
					Logger.Error($"[MES OUT-STA] [ERROR] MES >> '{respMsg2Result.Value}'");
					goto SendOutStationResult;
				}

				OutStationStatusCode = OutStationStatusCode.Success;
				Logger.Info($"[MES OUT-STA] [OK] MES >> '{respMsg2Result.Value}'");

				SendOutStationResult:
				if (CommonAppConfig.IsDevTestMode)
				{
					Plc.Write.工位1数据上报请求 = 0;
					Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报请求));
				}

				Plc.Write.工位1数据上报响应 = (short)OutStationStatusCode;
				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1数据上报响应), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES OUT-STA] [ERROR] write plc upload response failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
				OkNgState = OkNgState.OK;
				WorkStep = WorkStep.COMPLETED;
				DayProductionId = 0;
				// ScanCode = null!;
			}
		}

		return Task.CompletedTask;
	}

	protected override Task<bool> OnMainException(Exception exception)
	{
		Logger.Error("Left work position is error, will retry.");
		Thread.Sleep(5000);
		return TaskUtils.ConstValues.TaskTrue;
	}

	private static (string? WorkOrder, string? ModelName) ParseMesModelInfo(string? rawAscii)
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