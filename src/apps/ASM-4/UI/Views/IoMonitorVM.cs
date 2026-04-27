using System.Threading.Tasks;
using System.Globalization;
using ZC;
using ZC.Mvvm;
using ZC.UI.ControlLibs;
using ZitApp.Models;
using ZitApp.Services;

namespace ZitApp.UI;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class IoMonitorVM : CommonUiVM<IoMonitorView> 
{
    public required PlcService PlcService { get; init; }
    
    public partial ObservableList<IoItemModel> IoItems { get; set; } = new();
    

    public override Task Initialize(object? ctx, object? args)
    {
        InitIoTable();
        StartPollingTask();
        return base.Initialize(ctx, args);
    }

    private void StartPollingTask()
    {
        _ = Task.Run(async () =>
        {
            while (true)
            {
                await Task.Delay(300); // 300ms 刷新率

                if (PlcService == null || !PlcService.IsConnected)
                {
                    continue; 
                }

                foreach (var item in IoItems)
                {
                    if (string.IsNullOrWhiteSpace(item.Address)) continue;

                    try
                    {
                        dynamic connection = PlcService.Plc; 
                        string newValue = "0";

                        if (item.DataType == "short")
                        {
                            var res = connection.ReadInt16(item.Address);
                            newValue = res.IsSuccess ? res.Content.ToString() : "Fail";
                        }
                        else if (item.DataType == "int")
                        {
                            var res = connection.ReadInt32(item.Address);
                            newValue = res.IsSuccess ? res.Content.ToString() : "Fail";
                        }
                        else if (item.DataType == "float")
                        {
                            var res = connection.ReadFloat(item.Address);
                            newValue = res.IsSuccess ? res.Content.ToString("F2") : "Fail";
                        }
                        else if (item.DataType == "string")
                        {
                            var res = connection.ReadString(item.Address, 40);
                            newValue = res.IsSuccess ? res.Content.Trim('\0', ' ') : "Fail";
                        }

                        Avalonia.Threading.Dispatcher.UIThread.Post(() => 
                        {
                            item.Value = newValue;
                        });
                    }
                    catch 
                    {
                        Avalonia.Threading.Dispatcher.UIThread.Post(() => 
                        {
                            item.Value = "Err";
                        });
                    }
                }
            }
        });
    }

    private void InitIoTable()
    {
        IoItems = new ObservableList<IoItemModel>
        {
            // ================= PLC -> PC ================= 
            new() { Name = "PLC心跳", Direction = "PLC->PC", Address = "22000", Remark = "", DataType = "short" },
            new() { Name = "PLC状态", Direction = "PLC->PC", Address = "22001", Remark = "1=启动, 2=停止, 3=初始化中, 4=报警中", DataType = "short" },
            new() { Name = "PLC错误码", Direction = "PLC->PC", Address = "22002", Remark = "", DataType = "short" },
            new() { Name = "设备1状态", Direction = "PLC->PC", Address = "22003", Remark = "1=启动, 2=停止, 3=初始化中, 4=报警中", DataType = "short" },
            new() { Name = "设备2状态", Direction = "PLC->PC", Address = "22004", Remark = "1=启动, 2=停止, 3=初始化中, 4=报警中", DataType = "short" },
           
            new() { Name = "设备3状态", Direction = "PLC->PC", Address = "22205", Remark = "1=启动, 2=停止, 3=初始化中, 4=报警中", DataType = "short" },
            
            new() { Name = "设备4状态", Direction = "PLC->PC", Address = "22206", Remark = "1=启动, 2=停止, 3=初始化中, 4=报警中", DataType = "short" },
            
            new() { Name = "PLC当前配方ID", Direction = "PLC->PC", Address = "22010", Remark = "PLC初始化使用的配方ID", DataType = "short" },
            new() { Name = "PLC配方写入PC地址响应", Direction = "PLC->PC", Address = "22011", Remark = "1=已完成, 0=无请求", DataType = "short" },
            new() { Name = "工位1数据上报请求", Direction = "PLC->PC", Address = "22015", Remark = "0=未上报, 1=OK, 2=NG, 收到响应后复位", DataType = "short" },
            new() { Name = "工位2数据上报请求", Direction = "PLC->PC", Address = "22016", Remark = "0=未上报, 1=OK, 2=NG, 收到响应后复位", DataType = "short" },
            
            new() { Name = "扫码枪1触发", Direction = "PLC->PC", Address = "22020", Remark = "1=触发, 收到响应后复位", DataType = "short" },
            new() { Name = "扫码枪2触发", Direction = "PLC->PC", Address = "22021", Remark = "1=触发, 收到响应后复位", DataType = "short" },
            
            
            new() { Name = "上相机连接状态", Direction = "PLC->PC", Address = "22030", Remark = "1=正常, 2=断开", DataType = "short" },
            new() { Name = "下相机1连接状态", Direction = "PLC->PC", Address = "22031", Remark = "1=正常, 2=断开", DataType = "short" },
            new() { Name = "下相机2连接状态", Direction = "PLC->PC", Address = "22032", Remark = "1=正常, 2=断开", DataType = "short" },
            
            new() { Name = "已生产数量", Direction = "PLC->PC", Address = "22050", Remark = "", DataType = "int" },
            new() { Name = "良率", Direction = "PLC->PC", Address = "22052", Remark = "", DataType = "float" },
            new() { Name = "CT", Direction = "PLC->PC", Address = "22054", Remark = "单位ms", DataType = "float" },

            // ================= PC -> PLC =================
            new() { Name = "上位机心跳", Direction = "PC->PLC", Address = "21000", Remark = "0-1跳变 1S间隔", DataType = "short" },
            new() { Name = "上位机状态", Direction = "PC->PLC", Address = "21001", Remark = "1=就绪, 2=故障", DataType = "short" },
	            new() { Name = "上位机错误码", Direction = "PC->PLC", Address = "21002", Remark = "1=扫码枪未连接, 2=MES未连接 , 3=IOT未连接, 4=EAP未连接, 5=打印机未连接", DataType = "long" },
            new() { Name = "工位1允许生产", Direction = "PC->PLC", Address = "21005", Remark = "1=允许生产, 2=扫码未通过, 3=配方未响应, 4=物料需更换", DataType = "short" },
            new() { Name = "工位2允许生产", Direction = "PC->PLC", Address = "21006", Remark = "1=允许生产, 2=扫码未通过, 3=配方未响应, 4=物料需更换", DataType = "short" },
            
            new() { Name = "上位机当前配方ID", Direction = "PC->PLC", Address = "21010", Remark = "上位机下发到PLC的配方ID", DataType = "short" },
            new() { Name = "PLC配方写入PC地址", Direction = "PC->PLC", Address = "21011", Remark = "1=请求, 0=无请求", DataType = "short" },
            new() { Name = "工位1数据上报响应", Direction = "PC->PLC", Address = "21015", Remark = "1=OK, 2=NG", DataType = "short" },
            new() { Name = "工位2数据上报响应", Direction = "PC->PLC", Address = "21016", Remark = "1=OK, 2=NG", DataType = "short" },
            
            new() { Name = "扫码枪1触发结果", Direction = "PC->PLC", Address = "21020", Remark = "1=OK, 2=扫码枪连接错误, 3=MES返回错误", DataType = "short" },
            new() { Name = "扫码枪2触发结果", Direction = "PC->PLC", Address = "21021", Remark = "1=OK, 2=扫码枪连接错误, 3=MES返回错误", DataType = "short" },
            
           
	            new() { Name = "工单号PC下发", Direction = "PC->PLC", Address = "21100", Remark = "", DataType = "byte[80]" },
	            new() { Name = "工号PC下发", Direction = "PC->PLC", Address = "21140", Remark = "", DataType = "byte[80]" }
        };
    }
    
    public void Show()
    {
        if (IoItems == null || IoItems.Count == 0)
        {
            InitIoTable();
            StartPollingTask();
        }

        View.DataContext = this;

        View.Hide();
        View.Show();
    }

    public void @CloseView()
    {
       View.Hide();
    }

    public async Task WriteIoItemAsync(IoItemModel item)
    {
        var input = item.WriteValue?.Trim() ?? "";
        if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) == false)
        {
            await ShowMessageBox("写入值只能为 int 整型，请重新输入。", "PLC 写入", MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(item.Address))
        {
            await ShowMessageBox("PLC 地址不能为空，请先填写地址。", "PLC 写入", MessageBoxIcon.Warning);
            return;
        }

        if (PlcService == null || !PlcService.IsConnected)
        {
            await ShowMessageBox("PLC 未连接，不能写入。", "PLC 写入", MessageBoxIcon.Error);
            return;
        }

        var option = await ShowMessageBox(
            $"确认将 {value} 写入 [{item.Name}] 地址 {item.Address} 吗？",
            "确认写入 PLC",
            MessageBoxIcon.Question,
            MessageBoxButton.YesNo);
        if (option is not MessageBoxResult.Yes)
            return;

        try
        {
            var writeResult = await Task.Run(() => WriteValueToPlc(item, value));
            if (writeResult.IsError())
            {
                await ShowMessageBox($"PLC 写入失败: {writeResult.Message}", "PLC 写入", MessageBoxIcon.Error);
                return;
            }

            item.Value = value.ToString(CultureInfo.InvariantCulture);
            ShowToast($"已写入 [{item.Name}] = {value}", UiMessageType.Success);
        }
        catch (Exception ex)
        {
            await ShowMessageBox($"PLC 写入异常: {ex.Message}", "PLC 写入", MessageBoxIcon.Error);
        }
    }

    private Result WriteValueToPlc(IoItemModel item, int value)
    {
        dynamic connection = PlcService.Plc;
        dynamic result;

        switch (item.DataType)
        {
            case "short":
                if (value is < short.MinValue or > short.MaxValue)
                    return Result.Err($"数值 {value} 超出 short 范围: {short.MinValue} ~ {short.MaxValue}");
                result = connection.Write(item.Address, (short)value);
                break;
            case "int":
                result = connection.Write(item.Address, value);
                break;
            case "float":
                result = connection.Write(item.Address, (float)value);
                break;
            case "string":
                result = connection.Write(item.Address, value.ToString(CultureInfo.InvariantCulture));
                break;
            default:
                result = connection.Write(item.Address, value);
                break;
        }

        return result.IsSuccess ? Result.OK : Result.Err(result.Message);
    }
}
