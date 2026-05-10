using System.Text;
using ZC;
using ZC.BinStructs.Ext;
using ZC.DP.Number;
using ZC.EasyIO;
using ZC.IO;
using ZC.Mvvm;
using ZC.Text;
using ZC.UI.Utils;
using ZC.Utils;
using ZitApp.BinStructs;
using ZitApp.Contexts;
using ZitApp.Devices.Screw;
using ZitApp.Models;
using ZitApp.UI.Dialogs;

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

	public override string ServiceName => $"WP-{GetType().Name[^1]}";
	public required PlcService Plc { get; init; }
	public required CoreService Core { get; init; }
	public required MesService Mes { get; init; }
	public required AppConfig AppConfig { get; init; }
	public required CreateMaterialRecipeVM CreateMaterialRecipeVM { get; init; }
	public IDataSocket CodeScanner { get; set; } = null!;
	public WorkPositionContext Context { get; set; } = null!;

	protected override Task OnInitialize(object? ctx, object? args)
	{
		Context = Core.WorkPositionContexts.First(t => t.Name == ServiceName);
		CodeScanner = App.Current.IOC.Get<IDataSocket>("Scanner工位1");
		Task.Run(() => CodeScanner.Open());
		return base.OnInitialize(ctx, args);
	}

	protected override Task Main(CancellationToken ctk)
	{
		Thread.Sleep(5000);

		while (ctk.IsCancellationRequested == false)
		{
			Plc.WaitNextCycle();
			Context.AxisPercent = Plc.Read.工位1轨道百分比位置;

			#region 入站

#if ASM15_1
			if (Plc.Read is { 扫码枪1触发: 2, 扫码枪1触发结果: 0 }) // SCAN KEY PART AND TRY-DO
#else
			if (Plc.Read is { 扫码枪1触发: 1, 扫码枪1触发结果: 0 }) // SCAN SN AND TRY-DO
#endif
			{
#if ASM15_1
				Context.ScanKeyPartCode = "";
#else
				Context.ScanSnCode = "";
#endif
				Context.LastError = null;
				Context.ProductionState = ProductionState.NA;
				Context.WorkStep = WorkStep.SCAN_SN_CODE_DOING;
				Context.ModelName = "";
				string scanCode;

				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [DOING] ...");
				if (CommonAppConfig.IsDevTestMode == false)
				{
					var scanCodeResult = DoScanCode(CodeScanner);
					if (scanCodeResult.IsError())
					{
						Logger.Error($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [ERROR] {scanCodeResult.Message}");
						Context.LastError = "scan code failed, code scanner connection error!";
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
						goto SendResult;
					}

					scanCode = scanCodeResult.Value!;
					int codeMinLength;
#if ASM15_1
					Context.ScanKeyPartCode = scanCode;
					codeMinLength = AppConfig.KeyPartCodeMinLength;
#else
					Context.ScanSnCode = scanCode;
					codeMinLength = AppConfig.SnCodeMinLength;
#endif
					if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength)
					{
						Logger.Error(
							$"[SCAN CODE-{Plc.Read.扫码枪1触发}] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
						Context.LastError = "scan code check failed, length out of range!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_SCAN_CODE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}
				}
				else
				{
					scanCode = $"DEBUG-TEST-{DateTime.Now:yyyyMMdd-HHmmss}";
				}


				Context.WorkStep = WorkStep.SCAN_SN_CODE_COMPLETED;
				Logger.Info($"[SCAN-CODE-{Plc.Read.扫码枪1触发}] [OK] CONTENT='{scanCode}'");

				MesQueryPoint:
				if (Core.MesSkipEnabled == false)
				{
					#region MES-QUERY

					Context.WorkStep = WorkStep.MES_QUERY_DOING;
					var mes7 = $"ASM_QUERY,{Context.ScanSnCode},7,,SMD,,OK,MO_NUMBER=??? MODEL_NAME=???";
					Logger.Info($"[MES QUERY] [DOING] MES << '{mes7}'");
					var mesMsg7Result = Mes.SendAndReadString(mes7);
					// var mesMsg7Result = Mes.SendRawAsciiMessage7(扫码);
					if (mesMsg7Result.IsError() || mesMsg7Result.Value!.StartsWith("OK") is false)
					{
						Logger.Error(
							mesMsg7Result.IsError()
								? $"[MES QUERY] [ERROR] MES connection error! {mesMsg7Result.Message}"
								: $"[MES QUERY] [ERROR] MES << '{mesMsg7Result.Value}'");

						Context.LastError = mesMsg7Result.IsError()
							? "mes query failed, mes connection error!"
							: $"mes query failed, mes return >> '{mesMsg7Result.Value}'";
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var rawAscii = mesMsg7Result.Value;
					var parseResult = ParseMesModelInfo(rawAscii);
					if (parseResult.WorkOrder is null || parseResult.ModelName is null)
					{
						Logger.Error(
							$"[MES QUERY] [ERROR] (MO_NUMBER='{parseResult.WorkOrder}',MODEL_NAME='{parseResult.ModelName}')] has empty value!");
						Context.LastError =
							$"mes query error (MO_NUMBER='{parseResult.WorkOrder}',MODEL_NAME='{parseResult.ModelName}') has empty value!";
						Plc.Write.工位1允许生产 = 2;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}


					Core.WorkOrderNo = parseResult.WorkOrder;
					Context.ModelName = parseResult.ModelName;
					Logger.Info($"[MES QUERY] [OK] MO_NUMBER='{Core.WorkOrderNo}' MODEL_NAME='{Context.ModelName}'");

					#endregion
				}
				else
				{
					Logger.Info($"[MES IN-STA] [OK:Skip] SN='{Context.ScanSnCode}' KEY-PART='{Context.ScanKeyPartCode}'");
					Plc.Write.扫码枪1触发结果 = CodeOfOK;
					Plc.Write.工位1允许生产 = ALLOW_PRODUCTION;
					goto SendResult;
				}


				RecipeCheckPoint:
				if (Core.RecipeCheck)
				{
					Context.WorkStep = WorkStep.RECIPE_CHECK;
					// Logger.Info($"[RECIPE CHECK] [DOING] SN='{ScanCode}' MODEL_NAME='{Context.ModelName}'");
					var recipeResult = Core.RecipeService.GetRecipe(Context.ModelName);
					if (recipeResult.IsError())
					{
						var wait = Core.TryCreateMaterialRecipe(Context.ModelName);
						wait.Wait(TimeSpan.FromSeconds(60));
						recipeResult = Core.RecipeService.GetRecipe(Context.ModelName);
					}
					if (recipeResult.IsError())
					{
						Logger.Error(
							$"[RECIPE CHECK] [ERROR] recipe not found! SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						Context.LastError = "recipe check failed, recipe not found!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					var recipe = recipeResult.Value!;
					if (recipe.RefFullRecipe is not { Points: not null })
					{
						Logger.Error(
							$"[RECIPE CHECK] [ERROR] recipe ref tcx recipe not found! (recipe='{recipe.Name}', ref tcx ='{recipe.RefFullRecipeName}')");
						Context.LastError = "recipe check failed, recipe ref tcx recipe not found!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					if (Plc.Read.上位机当前配方ID == Plc.Read.PLC当前配方ID &&
					    Core.WorkRecipe?.Id == recipe.Id ||
					    Core.WorkRecipe?.RefFullRecipe?.Id == Plc.Read.上位机当前配方ID)
					{
						Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						goto MaterialCheckPoint;
					}

					Logger.Info($"[RECIPE CHANGE] [DOING]" +
					            $" Old(PLC-ID={Plc.Read.PLC当前配方ID}', PC-ID={Plc.Read.上位机当前配方ID}) =>" +
					            $" New(Id={recipe.Id}, Name={recipe.Name}')");

					if (false == Core.RecipeSwitchLock.Wait(TimeSpan.FromSeconds(AppConfig.RecipeSwitchWaitTimeout)))
					{
						Logger.Error("[RECIPE CHANGE] [ERROR] Wait lock timeout! ");
						Context.LastError = "recipe change failed, wait lock timeout!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						goto SendResult;
					}

					try
					{
						if (Plc.Read.上位机当前配方ID == Plc.Read.PLC当前配方ID &&
						    Core.WorkRecipe?.Id == recipe.Id ||
						    Core.WorkRecipe?.RefFullRecipe?.Id == Plc.Read.上位机当前配方ID)
						{
							Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
							goto MaterialCheckPoint;
						}
						
						if (Core.IsWorkPositionFree() == false)
						{
							Logger.Warn($"[RECIPE CHANGE] [FAILL] work position is doing ,can't change recipe!");
							Context.LastError = "recipe change failed, work position is doing!";
							Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
							Plc.Write.扫码枪1触发结果 = CodeOfNG;
							goto SendResult;
						}

						if (recipe.RefFullRecipe!.Id != Plc.Read.上位机当前配方ID)
						{
							Context.WorkStep = WorkStep.RECIPE_SEND;
							Logger.Info("[RECIPE CHANGE] recipe data sending ...! ");
							var distributeRecipeTask = Core.DistributeRecipeAsync(recipeResult.Value!);
							distributeRecipeTask.Wait();
							if (distributeRecipeTask.Result.IsError())
							{
								Logger.Error(
									$"[RECIPE CHANGE] [ERROR] Recipe data send failed! {distributeRecipeTask.Exception?.Message ?? distributeRecipeTask.Result.Message} ");
								Context.LastError = "recipe change failed, recipe data send failed!";
								Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
								Plc.Write.扫码枪1触发结果 = CodeOfNG;
								goto SendResult;
							}

							Logger.Info("[RECIPE CHANGE] Recipe data sended.");
							Context.WorkStep = WorkStep.RECIPE_WAIT;
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
								Context.LastError = "recipe change failed, wait plc change recipe timeout!";
								Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_RECIPE;
								Plc.Write.扫码枪1触发结果 = CodeOfNG;
								goto SendResult;
							}
						}
						Core.WorkRecipe = recipe;
						Logger.Info("[RECIPE CHANGE] [OK] Recipe changed successfully!.");
					}
					finally
					{
						Core.RecipeSwitchLock.Release();
					}

					Logger.Info($"[RECIPE CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
				}
				else
					Logger.Warn($"[RECIPE CHECK] [OK:UnCheck] SN='{Context.ScanSnCode}'  MODEL_NAME='{Context.ModelName}'");


				MaterialCheckPoint:
				if (Core.MaterialCheck)
				{
					var isMaterialStateOk = true;
					MaterialSpaceContext? material = null;
					foreach (var item in Core.MaterialContexts)
					{
						if (item.Config.IsUsed == false) continue;
						item.CheckMaterialState();
						if (item.MaterialState is MaterialState.OK or MaterialState.UnUsed)
							continue;
						isMaterialStateOk = false;
						material = item;
						break;
					}

					if (isMaterialStateOk)
						Logger.Info($"[MATERIAL CHECK] [OK] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
					else
					{
						Logger.Error(
							$"[MATERIAL CHECK] [ERROR] at material {material?.Id} state is '{material?.MaterialState}' SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");
						Context.LastError = $"material {material?.Id} check failed!";
						Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MATERIAL;
						Plc.Write.扫码枪1触发结果 = CodeOfNG;
						Context.LastError = "MATERIAL CHECK FAILED!";
						goto SendResult;
					}
				}
				else
					Logger.Warn($"[MATERIAL CHECK] [OK:UnCheck] SN='{Context.ScanSnCode}' MODEL_NAME='{Context.ModelName}'");


				#region MES-IN-STA

				InStationExecutePoint:
				var msg1 =
					$"{AppConfig.StationName.Trim()},{Context.ScanSnCode.Trim()},1,{Core.WorkerNo.Trim()},{AppConfig.Line.Trim()},,OK,,,";
				Context.WorkStep = WorkStep.MES_IN_STATION_DOING;
				Logger.Info($"[MES IN-STA] [DOING] MES1 << '{msg1}'");
				var mesMsg1Result = Mes.SendAndReadString(msg1);
				Context.WorkStep = WorkStep.MES_IN_STATION_COMPLETED;
				if (mesMsg1Result.IsError() || mesMsg1Result.Value!.StartsWith("OK") is false)
				{
					Logger.Error(Context.LastError = mesMsg1Result.IsError()
						? $"[MES IN-STA] [ERROR] MES1 connection error!"
						: $"[MES IN-STA] [ERROR] MES1 >> '{mesMsg1Result.Value}'");
					Context.LastError = $"in-station failed, mes return >> '{mesMsg1Result.Value}'";
					Plc.Write.工位1允许生产 = NOT_ALLOW_PRODUCTION_BY_MES;
					Plc.Write.扫码枪1触发结果 = CodeOfNG;
					goto SendResult;
				}

				Logger.Info($"[MES IN-STA] [OK] MES1 >> '{mesMsg1Result.Value}'");
#if ASM15_1
				var msg3 =
					$"{AppConfig.StationName},{Context.ScanSnCode},3,{Core.WorkerNo},{AppConfig.Line},,OK,{Context.ScanKeyPartCode},,";
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

				SendResult:
				if (Context.DayProductionId == 0)
					Context.DayProductionId = Core.GetDayProductionId();
				var now = DateTime.Now;
				Context.ImagePathRoot = Path.Combine(AppConfig.VisionImagePath,
					now.ToString("yyyy-MM"), now.ToString("dd"), $"{Context.DayProductionId}_{Context.ScanSnCode}");
				// Logger.Info($"[VISION FILE] image path is '{ImagePathRoot}'");
				Plc.Write.扫码枪1触发 = 0;
				Logger.Info(
					$"[MES IN-STA] [DONE] SCAN=({Plc.Write.扫码枪1触发结果},'{Context.ScanSnCode}') EN={Plc.Write.工位1允许生产}");
				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1允许生产), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES IN-STA] [ERROR] write plc allow production result failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});
				Plc.Write.工位1生产序号 = Context.DayProductionId;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1生产序号));
				Plc.Plc.Write($"{PlcStructInfo.扫码枪1扫码内容.Offset}", Context.ScanSnCode, 80);
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

				Context.WorkStep = WorkStep.MES_OUT_STATION_WAITING;
				continue;
			}

			#endregion

			#region 过站

			if (Plc.Read is { 工位1数据上报请求: 1, 工位1数据上报响应: 0 })
			{
				Context.LastError = null;
				Context.WorkStep = WorkStep.MES_OUT_STATION_DOING;
				if (string.IsNullOrEmpty(Context.ScanSnCode))
				{
					Context.LastError = "out-station failed, sn code is null!";
					Logger.Error("[MES OUT-STA] [ERROR] plc call out-station, but sn code is null!");
					Plc.Write.工位1数据上报响应 = 2;
					goto SendOutStationResult;
				}

				if (Core.MesSkipEnabled)
				{
					Logger.Info("[MES OUT-STA] [OK:Skip] SN='{sn}'", Context.ScanSnCode);
					Plc.Write.工位1数据上报响应 = 2;
					goto SendOutStationResult;
				}

				DataBuilder.Clear();
#if ASM15_1
				for (var i = 0; i < ScrewCount; i++)
				{
					var screwNo = i + 1;
					DataBuilder.Append(
						$"\"[VR]SCREW{screwNo}(KGF-CM)={ScrewMaxTorque[i]:F2};{AppConfig.ScrewTorqueLowLimit};{AppConfig.ScrewTorqueUpperLimit}\"");
					DataBuilder.Append(
						$"\"[VR]TURN{screwNo}(Lap)={ScrewTurns[i]:F2};{AppConfig.ScrewTurnsLowLimit};{AppConfig.ScrewTurnsUpperLimit}\"");
				}
#elif ASM12
				var uuid = Guid.NewGuid().ToString().ToUpper();
				DataBuilder.Append($"[VR]UUID='{uuid}'\"");
#endif
#if !MFG_15
				var msg2 =
					$"{AppConfig.StationName},{Context.ScanSnCode},2,{Core.WorkerNo},{AppConfig.Line},,OK,,,{DataBuilder}";
				Logger.Info($"[MES OUT-STA] [DOING] MES << '{msg2}'");
				var respMsg2Result = Mes.SendAndReadString(msg2);
				if (respMsg2Result.IsError() || respMsg2Result.Value!.StartsWith("OK") is false)
				{
					Context.LastError = respMsg2Result.IsError()
						? "out-station failed, mes connection error!"
						: $"out-station failed, mes return error '{respMsg2Result.Value}'";
					Logger.Error(respMsg2Result.IsError()
						? $"[MES OUT-STA] [ERROR] {respMsg2Result.Message}"
						: $"[MES OUT-STA] [ERROR] MES >> '{respMsg2Result.Value}'");
					Plc.Write.工位1数据上报响应 = 2;
					goto SendOutStationResult;
				}

				Logger.Info($"[MES OUT-STA] [OK] MES >> '{respMsg2Result.Value}'");
#endif
#if ASM12
				var mes7 = $"SMD_QUERY,{Context.ScanSnCode},7,,SMD,,OK,GET_PN=??? ZEBRA_DTG=??? SN_NOW_GROUP=???";
				Logger.Info($"[MES OUT-STA] [DOING] MES7 << '{mes7}'");
				var mesMsg7Result = Mes.SendAndReadString(mes7);
				if (mesMsg7Result.IsError() || mesMsg7Result.Value?.StartsWith("OK") == false)
				{
			
					Logger.Error(mesMsg7Result.IsError()
						? $"[MES OUT-STA] [ERROR] {mesMsg7Result.Message}"
						: $"[MES OUT-STA] [ERROR] MES >> '{mesMsg7Result.Value}'");
					Plc.Write.工位1数据上报响应 = 2;
					goto SendOutStationResult;
				}

				Logger.Info($"[MES OUT-STA] [OK] MES7 >> '{mesMsg7Result.Value}'");
				var topic = GenerateTopic(mesMsg7Result.Value!, AppConfig.StationName);
				Logger.Info($"TOPIC = {topic}");
				try
				{
					Debug.Assert(string.IsNullOrEmpty(ImagePathRoot) == false);
					var images = Directory.Exists(ImagePathRoot) ? 
						Directory.GetFiles(ImagePathRoot).Where(t=>t.Contains("_NG") ==false).ToArray()
						: [];
					CreateImagePackageZip("D:/Vision Files", images, Context.ScanSnCode, topic, uuid,
						t => Logger.Debug(t));
				}
				catch (Exception e)
				{
					Logger.Error(e);
				}
#endif
				Plc.Write.工位1数据上报响应 = 1;
				SendOutStationResult:

				Plc.Write.TryWritePoint(nameof(PlcStruct.工位1数据上报响应), this, static ctx =>
				{
					ctx.Context.Logger.Error(
						$"[MES OUT-STA] [ERROR] write plc upload response failed by plc connection error! {ctx.Result.Message}");
					Thread.Sleep(5000);
					return true;
				});

				if (CommonAppConfig.IsDevTestMode)
				{
					Plc.Write.工位1数据上报请求 = 0;
					Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报请求));
				}

				Context.ProductionState = ProductionState.OK;
				Context.WorkStep = WorkStep.WORK_POSITION_IS_FREE;
				Context.DayProductionId = 0;
				// ScanCode = null!;
			}

			#endregion

			#region 信号复位

			if (Plc.Read.扫码枪1触发 == 0 && Plc.Read.扫码枪1触发结果 != 0)
			{
				Plc.Write.扫码枪1触发结果 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.扫码枪1触发结果)).Unwarp("clear code scanner signal failed!");
				continue;
			}

			if (Plc.Read.工位1数据上报请求 is 0 && Plc.Read.工位1数据上报响应 is not 0)
			{
				Plc.Write.工位1数据上报响应 = 0;
				Plc.Write.WritePoint(nameof(PlcStruct.工位1数据上报响应)).Unwarp("clear work left upload result!");
				continue;
			}

			#endregion

			#region 工站本地代码

#if MFG15
			if (Plc.Read.打印机1触发 is 1 && Plc.Read.打印机1触发结果 is 0)
			{
				if (string.IsNullOrEmpty(Context.ScanSnCode))
				{
					Logger.Error("[CODE-PRINT] [ERROR] SN code is null or empty!");
					Plc.Write.打印机1触发结果 = 2;
					goto SendResult;
				}

				

				Logger.Info($"[CODE-PRINT] [DOING] SN='{Context.ScanSnCode}'");
				Core.PrinterLock.Wait();
				try
				{
					if (Plc.Read.工位1允许生产 != 1)
					{
						Logger.Error($"[CODE-PRINT] [ERROR] SN='{Context.ScanSnCode}' is not allow production!");
						Plc.Write.打印机1触发结果 = 2;
						goto SendResult;
					}
					var error = CodePrintService.SendContentToMesPrintProgram(Context.ScanSnCode);
					if (error is not null)
					{
						Logger.Error($"[CODE-PRINT] [ERROR] SN='{Context.ScanSnCode}' {error}");
						Plc.Write.打印机1触发结果 = 2;
						goto SendResult;
					}
					Thread.Sleep(5000);
				}
				finally
				{
					Core.PrinterLock.Release();
				}
				Logger.Info($"[CODE-PRINT] [OK] SN='{Context.ScanSnCode}'");
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

				var scanCode = Context.ScanSnCode = scanCodeResult.Value!;
				var codeMinLength = AppConfig.SnCodeMinLength;
				if (string.IsNullOrWhiteSpace(scanCode) || scanCode.Length < codeMinLength)
				{
					Logger.Error(
						$"[SCAN CODE-1] [ERROR] CONTENT =  '{scanCode}' code length check failed, length = {scanCode.Length}，not allow production.");
					Context.LastError = "code length check failed!";
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

			#endregion
		}

		return Task.CompletedTask;
	}

	protected override Task<bool> OnMainException(Exception exception)
	{
		Logger.Fatal(exception, "work position is error, will retry.");
		Thread.Sleep(5000);
		return TaskUtils.ConstValues.TaskTrue;
	}
}