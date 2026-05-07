using System.Text;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.Mvvm;
using ZC.Text;
using ZC.Utils;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Devices.Screw;
using ZitApp.Models;

namespace ZitApp.Services;

[RegisterToIOC(LifetimeType.Singleton)]
[ObservableObject]
[RegisterToTaskService(TaskStartMode.Automatic)]
public partial class WorkService1 : WorkServiceBase
{
#if ASM15_1
	[Inject(SpecialName = "Screw工位1")] public required ScrewMachineConnection Screw { get; init; }
	public ScrewMachineData ScrewData { get; private set; } = new();
	public const int ScrewCount = 16;
	public double[] ScrewTurns { get; private set; } = new double[ScrewCount];
	public double[] ScrewMaxTorque { get; private set; } = new double[ScrewCount];

	public int 螺丝拧紧完成信号 { get; private set; } = 0;
#endif
	public StringBuilder DataBuilder { get; private set; } = new();

	// private readonly byte[] _buffer = new byte[1024];
	public partial WorkStep WorkStep { get; private set; } = WorkStep.COMPLETED;
	public override string ServiceName => "WP-1";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public required AppConfig AppConfig { get; init; }
	public IDataSocket CodeScanner { get; set; } = null!;
	public partial string ModelName { get; set; } = "";
	public partial string ScanSnCode { get; set; } = "";
	public partial string ScanKeyPartCode { get; set; } = "";
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

#if ASM15_1
			while (Plc.Read.工位1螺丝拧紧完成信号 != 螺丝拧紧完成信号 && Plc.Read.工位1螺丝拧紧完成信号 <= ScrewCount)
			{
				螺丝拧紧完成信号 = Plc.Read.工位1螺丝拧紧完成信号;
				if (螺丝拧紧完成信号 == 0)
					break;
				var readResult1 = Screw.ReadInt16("60626");
				var readResult2 = Screw.ReadInt16("60628");
				if (readResult1.IsSuccess == false || readResult2.IsSuccess == false)
				{
					Logger.Error(
						$"[SCREW COMPLETE] at [{螺丝拧紧完成信号}], but read data failed! {readResult1.Message ?? readResult2.Message}");
					break;
				}

				var turns = readResult1.Content / 100.0;
				var maxTorque = readResult2.Content / 100.0;
				Logger.Info($"[SCREW COMPLETE] AT [{螺丝拧紧完成信号}] Turns:{turns}  MaxTorque:{maxTorque}");
				ScrewTurns[螺丝拧紧完成信号 - 1] = turns;
				ScrewMaxTorque[螺丝拧紧完成信号 - 1] = maxTorque;
				break;
			}
#endif

			if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
			{
				Plc.Write.扫码枪1触发结果 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.扫码枪1触发结果)).Unwarp("clear code scanner signal failed!");
				continue;
			}
#if ASM15_1
			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 }) // SCAN SN
			{
				Logger.Info($"[SCAN-CODE-1] [DOING] ...");
				var scanCodeResult = DoScanCode(CodeScanner);
				if (scanCodeResult.IsError())
				{
					Logger.Error($"[SCAN-CODE-1] [ERROR] {scanCodeResult.Message}");
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
				}

				var scanCode = ScanSnCode = scanCodeResult.Value!;
				var codeMinLength = AppConfig.SnCodeMinLength;
				if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength)
				{
					Logger.Error(
						$"[SCAN CODE-1] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
					LastError = "code length check failed!";
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}

				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [OK] CONTENT='{scanCode}'");
				Plc.Write.扫码枪1触发结果 = CodeOfOK;
				SendResult:
				Plc.Write.TryWritePoint(nameof(PlcStruct.扫码枪1触发结果), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc code scan signal failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
			}
#endif

#if ASM15_1
			if (Plc.Read is { 扫码枪1触发: 2, 扫码枪1触发结果: 0 }) // SCAN KEY PART 
#else
			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 }) // SCAN SN 
#endif
			{
				OkNgState = OkNgState.NA;
				WorkStep = WorkStep.SCAN_SN_CODE_DOING;
				string scanCode;
#if ASM15_1
				ScanKeyPartCode = "";
#else
				ScanSnCode = "";
#endif

				ModelName = "";
				try
				{
					Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [DOING] ...");
					if (CommonAppConfig.IsDevTestMode == false)
					{
						var scanCodeResult = DoScanCode(CodeScanner);
						if (scanCodeResult.IsError())
						{
							Logger.Error($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [ERROR] {scanCodeResult.Message}");
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							goto SendResult;
						}

						scanCode = scanCodeResult.Value!;
						int codeMinLength;
#if ASM15_1
						ScanKeyPartCode = scanCode;
						codeMinLength = AppConfig.KeyPartCodeMinLength;
#else
						ScanSnCode = scanCode;
						codeMinLength = AppConfig.SnCodeMinLength;
#endif
						if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength)
						{
							Logger.Error(
								$"[SCAN CODE-{Plc.Read.扫码枪1触发}] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
							LastError = "code length check failed!";
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}
					}
					else
					{
						scanCode = $"DEBUG-TEST-{DateTime.Now:yyyyMMdd-HHmmss}";
					}


					WorkStep = WorkStep.SCAN_SN_CODE_COMPLETED;
					Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [OK] CONTENT='{scanCode}'");

					if (Core.MesSkipEnabled)
					{
						Logger.Info($"[MES IN-STA] [OK:Skip] SN='{ScanSnCode}' KEY-PART='{ScanKeyPartCode}'");
						Plc.Write.扫码枪1触发结果 = CodeOfOK;
						Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;
						goto SendResult;
					}

					#region MES-QUERY

					WorkStep = WorkStep.MES_QUERY_DOING;

					var mes7 = $"ASM_QUERY,{ScanSnCode},7,,SMD,,OK,MO_NUMBER=??? MODEL_NAME=???";
					Logger.Info($"[MES QUERY] [DOING] MES << '{mes7}'");
					var mesMsg7Result = Mes.SendAndReadString(mes7);
					// var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码);
					if (mesMsg7Result.IsError() || mesMsg7Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error(LastError =
							mesMsg7Result.IsError()
								? $"[MES QUERY] [ERROR] MES connection error! {mesMsg7Result.Message}"
								: $"[MES QUERY] [ERROR] MES << '{mesMsg7Result.Value}'");
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
						Logger.Error($"[RECIPE CHECK] [ERROR] Recipe not found! SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var recipe = recipeResult.Value!;
					if (Core.RecipeCheck == false)
						Logger.Info($"[RECIPE CHECK] [OK:UnCheck] SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");
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
						Logger.Info($"[RECIPE CHECK] [OK] SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");

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
							Logger.Info($"[MATERIAL CHECK] [OK] SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");
						else
						{
							Logger.Error(
								$"[MATERIAL CHECK] [ERROR] at material {material?.Id} state is '{material?.MaterialState}' SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							LastError = "MATERIAL CHECK FAILED!";
							goto SendResult;
						}
					}
					else Logger.Info($"[MATERIAL CHECK] [OK:UnCheck] SN='{ScanSnCode}' MODEL_NAME='{ModelName}'");

					#endregion

					#region MES-IN-STA

					var msg1 =
						$"{AppConfig.StationName.Trim()},{ScanSnCode.Trim()},1,{Core.WorkerNo.Trim()},{AppConfig.Line.Trim()},,OK,,,";
					WorkStep = WorkStep.MES_IN_STATION_DOING;
					Logger.Info($"[MES IN-STA] [DOING] MES1 << '{msg1}'");
					var mesMsg1Result = Mes.SendAndReadString(msg1);
					WorkStep = WorkStep.MES_IN_STATION_COMPLETED;
					if (mesMsg1Result.IsError() || mesMsg1Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error(LastError = mesMsg1Result.IsError()
							? $"[MES IN-STA] [ERROR] MES1 connection error!"
							: $"[MES IN-STA] [ERROR] MES1 >> '{mesMsg1Result.Value}'");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					Logger.Info($"[MES IN-STA] [OK] MES1 >> '{mesMsg1Result.Value}'");
#if ASM15_1
					var msg3 =
						$"{AppConfig.StationName},{ScanSnCode},3,{Core.WorkerNo},{AppConfig.Line},,OK,{ScanKeyPartCode},,";
					var respMsg3Result = Mes.SendAndReadString(msg3);
					Logger.Info($"[MES IN-STA] [DOING] MES3 << '{msg3}'");
					if (respMsg3Result.IsError() || respMsg3Result.Value?.StartsWith("OK") == false)
					{
						Logger.Error(respMsg3Result.IsError()
							? $"[MES IN-STA] [ERROR] {respMsg3Result.Message}"
							: $"[MES IN-STA] [ERROR]  MES3 >> '{respMsg3Result.Value}");
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}
					Logger.Info($"[MES IN-STA] [OK] MES3 >> '{respMsg3Result.Value}'");
#endif

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
					now.ToString("yyyy-MM"), now.ToString("dd"), $"{DayProductionId}_{ScanSnCode}");
				// Logger.Info($"[VISION FILE] image path is '{ImagePathRoot}'");
				Plc.Write.扫码枪1触发 = 0;
				Logger.Info(
					$"[MES IN-STA] [DONE] SCAN=({Plc.Write.扫码枪1触发结果},'{ScanSnCode}') EN={Plc.Write.工位1允许生产}");
				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1允许生产), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc allow production result failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
				Plc.Write.工位1生产序号 = (short)DayProductionId;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1生产序号));
				Plc.Plc.Write($"{PlcStructInfo.扫码枪1扫码内容.Offset}", ScanSnCode, 80);
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
				if (string.IsNullOrEmpty(ScanSnCode))
				{
					OutStationStatusCode = OutStationStatusCode.SN_IS_EMPTY;
					Logger.Error("[MES OUT-STA] [ERROR] Plc upload result must scan code, current code is null!");
					goto SendOutStationResult;
				}

				if (Core.MesSkipEnabled)
				{
					OutStationStatusCode = OutStationStatusCode.Success;
					Logger.Info("[MES OUT-STA] [OK:Skip] SN='{sn}'", ScanSnCode);
					goto SendOutStationResult;
				}

				DataBuilder.Clear();
#if ASM15_1S
				for (var i = 0; i < ScrewCount; i++)
				{
					var screwNo = i + 1;
					DataBuilder.Append($"\"[VR]SCREW{screwNo}(KGF-CM)={ScrewMaxTorque[i]:F2}\"");
					DataBuilder.Append($"\"[VR]TURN{screwNo}(Lap)={ScrewTurns[i]:F2}\"");
				}
#elif ASM_12
				var uuid = Guid.NewGuid().ToString().ToUpper();
				DataBuilder.Append($"[VR]UUID='{uuid}'\"");
#endif
#if !MFG_15
				var msg2 = $"{AppConfig.StationName},{ScanSnCode},2,{Core.WorkerNo},{AppConfig.Line},,OK,,,{DataBuilder}";
				Logger.Info($"[MES OUT-STA] [DOING] MES << '{msg2}'");
				var respMsg2Result = Mes.SendAndReadString(msg2);
				if (respMsg2Result.IsError() || respMsg2Result.Value!.StartsWith("OK") is false)
				{
					OutStationStatusCode = OutStationStatusCode.MES_RESPONSE_ERROR;
					Logger.Error(respMsg2Result.IsError()
						? $"[MES OUT-STA] [ERROR] {respMsg2Result.Message}"
						: $"[MES OUT-STA] [ERROR] MES >> '{respMsg2Result.Value}'");
					goto SendOutStationResult;
				}

				OutStationStatusCode = OutStationStatusCode.Success;
				Logger.Info($"[MES OUT-STA] [OK] MES >> '{respMsg2Result.Value}'");
#endif
#if ASM_12
				var mes7 = $"SMD_QUERY,{ScanSnCode},7,,SMD,,OK,GET_PN=??? ZEBRA_DTG=??? SN_NOW_GROUP=???";
				Logger.Info($"[MES OUT-STA] [DOING] MES7 << '{mes7}'");
				var mesMsg7Result = Mes.SendAndReadString(mes7);
				if (mesMsg7Result.IsError() || mesMsg7Result.Value?.StartsWith("OK") == false)
				{
					OutStationStatusCode = OutStationStatusCode.MES_RESPONSE_ERROR;
					Logger.Error(mesMsg7Result.IsError()
						? $"[MES OUT-STA] [ERROR] {mesMsg7Result.Message}"
						: $"[MES OUT-STA] [ERROR] MES >> '{mesMsg7Result.Value}'");
					goto SendOutStationResult;
				}

				Logger.Info($"[MES OUT-STA] [OK] MES7 >> '{mesMsg7Result.Value}'");
				var topic = GenerateTopic(mesMsg7Result.Value!, AppConfig.StationName);
				Logger.Info($"TOPIC = {topic}");
				try
				{
					CreateImagePackageZip("D:/Vision Files", ["data/NLog.config"], ScanSnCode, topic, uuid,
						t => Logger.Debug(t));
				}
				catch (Exception e)
				{
					Logger.Error(e);
				}
#endif

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

#if MFG_15
			if (Plc.Read.打印机1触发 is 1 && Plc.Read.打印机1触发结果 is 0)
			{
				if (string.IsNullOrEmpty(ScanSnCode))
				{
					Logger.Error("[CODE-PRINT] [ERROR] SN code is null or empty!");
					Plc.Write.打印机1触发结果 = 2;
					goto SendResult;
				}

				if (Plc.Read.工位1允许生产 == 1)
				{
					Logger.Error($"[CODE-PRINT] [ERROR] SN='{ScanSnCode}' is not allow production!");
					Plc.Write.打印机1触发结果 = 2;
					goto SendResult;
				}

				Logger.Info($"[CODE-PRINT] [DOING] SN='{ScanSnCode}'");
				var error = CodePrintService.SendContentToMesPrintProgram(ScanSnCode);
				if (error is not null)
				{
					Logger.Error($"[CODE-PRINT] [ERROR] SN='{ScanSnCode}' {error}");
					Plc.Write.打印机1触发结果 = 2;
					goto SendResult;
				}
				Thread.Sleep(5000);
				Logger.Info($"[CODE-PRINT] [OK] SN='{ScanSnCode}'");
				Plc.Write.打印机1触发结果 = 1;
				SendResult:
				Plc.Write.TryWritePoint(nameof(PlcStruct.打印机1触发结果), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[CODE-PRINT] [ERROR] write plc code print result failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
			}

			if (Plc.Read.打印机1触发 is 0 && Plc.Read.打印机1触发结果 is not 0)
			{
				Plc.Write.打印机1触发结果 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.打印机1触发结果));
			}
#endif
		}

		return Task.CompletedTask;
	}


	protected override Task<bool> OnMainException(Exception exception)
	{
		Logger.Fatal(exception, "work position is error, will retry.");
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