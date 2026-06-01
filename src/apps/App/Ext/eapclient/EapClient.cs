using System.Buffers;
using System.Net.Sockets;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using ZC.IOC;
using ZC.LOG;
using ZitApp.Models;

namespace ZitApp.Ext.EapClient;

/// <summary>
/// EAP TCP 客户端：独立读线程持续收包；写操作单独加锁；主动上报与被动应答互不阻塞。
/// 【重构版】移除框架基类，独立化运行，保留全部原有业务功能
/// </summary>
public class EapClientService : IDisposable
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private readonly EapConnectionConfig _config;
    private readonly IEquipmentStatusProvider _equipmentStatusProvider;
    private readonly PlcAlarmTextCatalog _alarmTextCatalog;
    
    private TcpClient? _client;
    private NetworkStream? _stream;
    private bool _disposed;
    private readonly SemaphoreSlim _writeLock = new(1, 1);
    private readonly object _pendingResponseLock = new();
    private CancellationTokenSource? _readerCts;
    private Task? _readerTask;
    private CancellationToken _serviceToken;
    private TaskCompletionSource<JsonObject>? _pendingResponse;
    private (int Stream, int Function)? _expectedAck;

    public Dictionary<int, Func<JsonObject, Task<JsonObject>>> Handlers { get; } = new();

    public bool IsConnected => _client?.Connected ?? false;
    public bool Enabled => _config.Enabled;
    public EquipmentStatus EquipmentStatus { get; set; } = EquipmentStatus.Idle;
    public string CarrierId { get; set; } = "";
    public string SubstrateId { get; set; } = "";
    public string EventName { get; set; } = "";

    /// <summary>
    /// 日志：特性注入（新版结构）
    /// </summary>
    [Inject(Name = "@EAP")]
    public ILogger Logger { get; init; } = null!;

    public EapClientService(
        EapConnectionConfig config,
        IEquipmentStatusProvider equipmentStatusProvider,
        PlcAlarmTextCatalog alarmTextCatalog)
    {
        _config = config;
        _equipmentStatusProvider = equipmentStatusProvider;
        _alarmTextCatalog = alarmTextCatalog;
    }

    #region 旧版完整业务 Handler（无修改）
    public void RegisterDeviceStatusHandlers()
    {
        RegisterHandler(1, 3, async request =>
        {
            await Task.CompletedTask;
            EquipmentStatus = _equipmentStatusProvider.GetCurrentStatus();

            return new JsonObject
            {
                ["Stream"] = "1",
                ["Function"] = "4",
                ["List"] = new JsonObject
                {
                    [EapReportIds.EquipmentStatusId] = EquipmentStatus.ToString()
                }
            };
        });

        RegisterHandler(1, 11, async request =>
        {
            await Task.CompletedTask;
            var list = new JsonObject
            {
                [EapReportIds.EquipmentStatusId] = "设备状态",
                [EapReportIds.ProductionCount] = "生产数量",
                [EapReportIds.YieldRate] = "良率",
                [EapReportIds.CycleTime] = "CT",
                [EapReportIds.OkNg] = "OK/NG",
                [EapReportIds.WorkOrderNo] = "工单号",
                [EapReportIds.SnCode] = "SN码",
                [EapReportIds.KeyPartCode] = "KeyPart码",
                [EapReportIds.ModelName] = "机种型号",
                [EapReportIds.WorkerNo] = "工号",
                [EapReportIds.StationName] = "站点名",
                [EapReportIds.Line] = "线别",
                [EapReportIds.RecipeName] = "配方名",
                [EapReportIds.ErrorMessage] = "错误信息"
            };
            for (var i = 0; i < 16; i++)
            {
                list[EapReportIds.ScrewTorqueId(i)] = $"螺丝{i + 1}扭矩";
                list[EapReportIds.ScrewTurnsId(i)] = $"螺丝{i + 1}圈数";
            }
            return new JsonObject
            {
                ["Stream"] = "1",
                ["Function"] = "12",
                ["List"] = list
            };
        });
    }

    public void RegisterAlarmHandlers()
    {
        RegisterHandler(5, 5, async request =>
        {
            await Task.CompletedTask;
            return new JsonObject
            {
                ["Stream"] = "5",
                ["Function"] = "6",
                ["List"] = _alarmTextCatalog.BuildEapDefinitionList()
            };
        });
    }

    public void RegisterHandler(int stream, int function, Func<JsonObject, Task<JsonObject>> handler)
    {
        var key = stream * 1000 + function;
        Handlers[key] = handler;
    }

    /// <summary>从设备状态监视服务内存快照刷新（不再单独读 D600）。</summary>
    public Task RefreshEquipmentStatusFromRuntimeAsync()
    {
        EquipmentStatus = _equipmentStatusProvider.GetCurrentStatus();
        return Task.CompletedTask;
    }
    #endregion

    #region 连接管理（无修改）
    public async Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        if (_client != null && _client.Connected)
        {
            Logger.Debug("Already connected");
            return;
        }

        CleanupConnection();
        _client = new TcpClient();

        await _client.ConnectAsync(_config.Host, _config.Port, cancellationToken);
        _stream = _client.GetStream();
        _stream.ReadTimeout = 60000;
        _stream.WriteTimeout = 15000;
        Logger.Info("Connected to {Host}:{Port}", _config.Host, _config.Port);
    }

    public void Disconnect()
    {
        StopReader();
        CleanupConnection();
        Logger.Info("Disconnected");
    }

    private void CleanupConnection()
    {
        FailPendingResponse(new IOException("EAP connection closed"));
        _stream?.Close();
        _client?.Close();
        _stream = null;
        _client = null;
    }

    private void StopReader()
    {
        if (_readerCts != null)
        {
            _readerCts.Cancel();
            _readerCts.Dispose();
            _readerCts = null;
        }
    }
    #endregion

    #region 请求应答核心逻辑（无修改）
    public async Task<JsonObject> SendRequestAsync(JsonObject request, CancellationToken cancellationToken = default)
    {
        if (_client == null || !_client.Connected || _stream == null)
            throw new InvalidOperationException("Not connected to server");

        if (!TryParseStreamFunction(request, out var reqStream, out var reqFunction))
            throw new ArgumentException("EAP request missing Stream/Function");

        var tcs = RegisterPendingResponse(reqStream, reqFunction + 1);

        try
        {
            await WriteMessageAsync(request, cancellationToken);

            using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            timeoutCts.CancelAfter(TimeSpan.FromSeconds(15));
            return await tcs.Task.WaitAsync(timeoutCts.Token);
        }
        catch (Exception ex)
        {
            FailPendingResponse(ex);
            throw;
        }
    }

    private async Task WriteMessageAsync(JsonObject message, CancellationToken cancellationToken)
    {
        if (_stream == null)
            throw new InvalidOperationException("Not connected to server");

        await _writeLock.WaitAsync(cancellationToken);
        try
        {
            var json = message.ToJsonString(JsonOptions);
            Logger.Info("EAP 发送 >> {Request}", json);
            var bytes = Encoding.UTF8.GetBytes(json);
            await _stream.WriteAsync(bytes, cancellationToken);
            await _stream.FlushAsync(cancellationToken);
        }
        finally
        {
            _writeLock.Release();
        }
    }

    private TaskCompletionSource<JsonObject> RegisterPendingResponse(int ackStream, int ackFunction)
    {
        lock (_pendingResponseLock)
        {
            if (_pendingResponse != null)
                throw new InvalidOperationException("Another proactive EAP request is in progress");

            _expectedAck = (ackStream, ackFunction);
            _pendingResponse = new TaskCompletionSource<JsonObject>(TaskCreationOptions.RunContinuationsAsynchronously);
            return _pendingResponse;
        }
    }

    private bool TryCompletePendingResponse(JsonObject message)
    {
        lock (_pendingResponseLock)
        {
            if (_pendingResponse == null || _expectedAck == null)
                return false;

            if (!TryParseStreamFunction(message, out var stream, out var function))
                return false;

            var (expectedStream, expectedFunction) = _expectedAck.Value;
            if (stream != expectedStream || function != expectedFunction)
                return false;

            _pendingResponse.TrySetResult(message);
            _pendingResponse = null;
            _expectedAck = null;
            return true;
        }
    }

    private void FailPendingResponse(Exception ex)
    {
        lock (_pendingResponseLock)
        {
            if (_pendingResponse == null)
                return;

            _pendingResponse.TrySetException(ex);
            _pendingResponse = null;
            _expectedAck = null;
        }
    }

    private void EnsureBackgroundReader()
    {
        if (_readerTask is { IsCompleted: false })
            return;

        if (_client == null || !_client.Connected || _stream == null)
            return;

        _readerCts?.Dispose();
        _readerCts = CancellationTokenSource.CreateLinkedTokenSource(_serviceToken);
        _readerTask = ReadLoopAsync(_readerCts.Token);
    }

    public async Task<JsonObject?> HandleRequestAsync(JsonObject request)
    {
        var streamStr = request["Stream"]?.ToString();
        var functionStr = request["Function"]?.ToString();

        if (!int.TryParse(streamStr, out int streamValue))
        {
            Logger.Warn("Invalid Stream: {Stream}", streamStr);
            return null;
        }

        if (!int.TryParse(functionStr, out int functionValue))
        {
            Logger.Warn("Invalid Function: {Function}", functionStr);
            return null;
        }

        var handlerKey = streamValue * 1000 + functionValue;
        if (!Handlers.TryGetValue(handlerKey, out var handler))
        {
            Logger.Warn("Handler not found for S{Stream}F{Function}", streamValue, functionValue);
            return new JsonObject
            {
                ["Result"] = "Handler not Found"
            };
        }

        return await handler(request);
    }

    private async Task ReadLoopAsync(CancellationToken cancellationToken)
    {
        if (_client == null || !_client.Connected || _stream == null)
            return;

        var buffer = ArrayPool<byte>.Shared.Rent(_config.BufferSize);
        try
        {
            while (!cancellationToken.IsCancellationRequested && _client.Connected && _stream != null)
            {
                int bytesRead;
                try
                {
                    bytesRead = await _stream.ReadAsync(buffer, cancellationToken);
                }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    Logger.Warn("EAP connection closed by server");
                    FailPendingResponse(new IOException("Connection closed by server"));
                    break;
                }

                var json = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim('\r', '\n', '\0');
                Logger.Info("EAP 接收 << {Response}", json);

                try
                {
                    if (JsonNode.Parse(json) is not JsonObject message)
                    {
                        Logger.Warn("Invalid JSON from EAP: {Json}", json);
                        continue;
                    }

                    if (TryCompletePendingResponse(message))
                        continue;

                    var response = await HandleRequestAsync(message);
                    if (response != null)
                        await WriteMessageAsync(response, cancellationToken);
                }
                catch (JsonException ex)
                {
                    Logger.Warn(ex, "JSON解析失败: {Json}", json);
                }
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }
    #endregion

    #region 上报业务逻辑（旧版完整保留）
    public async Task SendAlarmReportAsync(AlarmRecord alarm, CancellationToken cancellationToken = default)
    {
        var request = new JsonObject
        {
            ["Stream"] = "5",
            ["Function"] = "1",
            ["AlarmSet"] = alarm.Status == AlarmStatus.ON ? "Y" : "N",
            ["AlarmID"] = (alarm.AlarmId + 5000).ToString(),
            ["AlarmText"] = alarm.Name
        };

        var response = await SendRequestAsync(request, cancellationToken);
        if (!IsAlarmReportAck(response))
        {
            throw new InvalidOperationException(
                $"EAP S5F1 未收到标准 S5F2 应答: {response.ToJsonString(JsonOptions)}");
        }
    }

    private static bool IsAlarmReportAck(JsonObject response) =>
        TryParseStreamFunction(response, out var stream, out var function)
        && stream == 5
        && function == 2;

    private static bool IsStatusChangeReportAck(JsonObject response) =>
        TryParseStreamFunction(response, out var stream, out var function)
        && stream == 6
        && function == 12;

    private static bool IsEventReportAck(JsonObject response) => IsStatusChangeReportAck(response);

    /// <summary>产品过站 S6F11 EventID=6002，fire-and-forget，不等响应。</summary>
    public async Task SendProductFinishReportAsync(
        Dictionary<string, string> data,
        CancellationToken cancellationToken = default)
    {
        var reports = new JsonObject();
        foreach (var (key, value) in data)
        {
            reports[key] = value;
        }

        var request = new JsonObject
        {
            ["Stream"] = "6",
            ["Function"] = "11",
            ["EventID"] = "6002",
            ["Reports"] = reports
        };

        await WriteMessageAsync(request, cancellationToken);
    }

    public async Task<bool> TrySendProductFinishReportAsync(
        Dictionary<string, string> data,
        CancellationToken cancellationToken = default)
    {
        if (!_config.Enabled)
            return false;

        if (!IsConnected || _stream == null)
        {
            Logger.Warn("EAP 未连接，产品过站上报失败 SN={Sn}", data.GetValueOrDefault(EapReportIds.SnCode, ""));
            return false;
        }

        try
        {
            await SendProductFinishReportAsync(data, cancellationToken);
            Logger.Info("EAP 产品过站已上报(6002) SN={Sn} Result={Result}",
                data.GetValueOrDefault(EapReportIds.SnCode, ""),
                data.GetValueOrDefault(EapReportIds.OkNg, ""));
            return true;
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "EAP 产品过站上报失败 SN={Sn}", data.GetValueOrDefault(EapReportIds.SnCode, ""));
            return false;
        }
    }

    public async Task SendStatusChangeReportAsync(
        EquipmentStatus status,
        string productionCount = "0",
        string yieldRate = "0",
        string cycleTime = "0",
        string okNg = "0",
        CancellationToken cancellationToken = default)
    {
        var request = new JsonObject
        {
            ["Stream"] = "6",
            ["Function"] = "11",
            ["EventID"] = "6001",
            ["Reports"] = new JsonObject
            {
                [EapReportIds.CycleTime] = cycleTime,
                [EapReportIds.EquipmentStatusId] = status.ToString().ToLowerInvariant(),
                [EapReportIds.ProductionCount] = productionCount,
                [EapReportIds.YieldRate] = yieldRate,
                [EapReportIds.OkNg] = okNg
            }
        };

        // S6F11/6001 不等响应，fire-and-forget
        await WriteMessageAsync(request, cancellationToken);
    }

    public async Task<bool> TrySendStatusChangeReportAsync(
        EquipmentStatus status,
        string productionCount = "0",
        string yieldRate = "0",
        string cycleTime = "0",
        string okNg = "0",
        CancellationToken cancellationToken = default)
    {
        if (!_config.Enabled)
        {
            Logger.Debug("EAP 未启用(Enabled=false)，跳过设备状态变更上报 Status={Status}",
                status.ToString().ToLowerInvariant());
            return false;
        }

        if (!IsConnected || _stream == null)
        {
            Logger.Warn("EAP 未连接，设备状态变更上报失败 Status={Status}",
                status.ToString().ToLowerInvariant());
            return false;
        }

        try
        {
            await SendStatusChangeReportAsync(status, productionCount, yieldRate, cycleTime, okNg, cancellationToken);
            Logger.Info("EAP 设备状态变更已上报(6001): Status={Status}", status.ToString().ToLowerInvariant());
            return true;
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "EAP 设备状态变更上报失败: Status={Status}", status);
            return false;
        }
    }

    private static bool TryParseStreamFunction(JsonObject message, out int stream, out int function)
    {
        stream = 0;
        function = 0;
        var streamNode = message["Stream"];
        var functionNode = message["Function"];
        if (streamNode == null || functionNode == null)
            return false;

        return int.TryParse(streamNode.ToString(), out stream)
            && int.TryParse(functionNode.ToString(), out function);
    }

    public async Task<bool> TrySendAlarmReportAsync(AlarmRecord alarm, CancellationToken cancellationToken = default)
    {
        if (!_config.Enabled)
            return false;

        if (!IsConnected || _stream == null)
        {
            Logger.Warn("EAP 未连接，跳过报警上报 AlarmId={Id} AlarmSet={Set}",
                alarm.AlarmId, alarm.Status == AlarmStatus.ON ? "Y" : "N");
            return false;
        }

        try
        {
            await SendAlarmReportAsync(alarm, cancellationToken);
            Logger.Info("EAP 报警已上报: Id={Id} AlarmSet={Set} Text={Text}",
                alarm.AlarmId, alarm.Status == AlarmStatus.ON ? "Y" : "N", alarm.Name);
            return true;
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "EAP 报警上报失败: Id={Id} Name={Name}", alarm.AlarmId, alarm.Name);
            return false;
        }
    }
    #endregion

    #region 新版核心：独立服务启动/停止/主循环
    /// <summary>
    /// 启动服务（替代旧版框架初始化+主循环）
    /// </summary>
    public Task StartAsync(CancellationToken cancellationToken = default)
    {
        if (!_config.Enabled)
        {
            Logger.Info("EAP service disabled by config");
            return Task.CompletedTask;
        }

        _alarmTextCatalog.LoadFromPlcAlarmStruct(Logger);
        RegisterDeviceStatusHandlers();
        RegisterAlarmHandlers();
        Logger.Info("EAP handlers registered, service enabled");

        _serviceToken = cancellationToken;
        _ = RunLoopAsync(cancellationToken);
        return Task.CompletedTask;
    }

    /// <summary>
    /// 停止服务
    /// </summary>
    public void StopAsync()
    {
        Disconnect();
        Logger.Info("EAP client service stopped");
    }

    /// <summary>
    /// 主循环（替代旧版框架 Main 方法）
    /// </summary>
    private async Task RunLoopAsync(CancellationToken cancellationToken)
    {
        Logger.Info("EAP service started, target {Host}:{Port}", _config.Host, _config.Port);

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                if (!IsConnected)
                {
                    Logger.Warn("EAP not connected, attempting connect...");
                    await ConnectAsync(cancellationToken);
                }

                EnsureBackgroundReader();

                if (_readerTask is { IsCompleted: true })
                {
                    var finishedTask = _readerTask;
                    _readerTask = null;
                    try
                    {
                        await finishedTask;
                    }
                    catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                    catch (OperationCanceledException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(ex, "EAP 读线程异常退出");
                        CleanupConnection();
                    }

                    continue;
                }

                await Task.Delay(1000, cancellationToken);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                break;
            }
            catch (OperationCanceledException)
            {
                Logger.Warn("EAP connect cancelled, retrying...");
                await Task.Delay(_config.ReconnectDelay, cancellationToken);
            }
            catch (SocketException ex)
            {
                Logger.Error(ex, "EAP connect failed: {Error}, retry in {Delay}ms",
                    ex.Message, _config.ReconnectDelay);
                CleanupConnection();
                await Task.Delay(_config.ReconnectDelay, cancellationToken);
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "EAP connection lost: {Error}, retry in {Delay}ms",
                    ex.Message, _config.ReconnectDelay);
                CleanupConnection();
                await Task.Delay(_config.ReconnectDelay, cancellationToken);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "EAP unexpected error, retry in {Delay}ms", _config.ReconnectDelay);
                CleanupConnection();
                await Task.Delay(_config.ReconnectDelay, cancellationToken);
            }
        }

        Logger.Info("EAP service loop exited");
    }
    #endregion

    #region 释放资源
    public void Dispose()
    {
        if (!_disposed)
        {
            Disconnect();
            _writeLock.Dispose();
            _disposed = true;
        }

        GC.SuppressFinalize(this);
    }
    #endregion
}