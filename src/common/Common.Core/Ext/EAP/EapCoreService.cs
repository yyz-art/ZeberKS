using System.Buffers;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Nodes;
using ZC;
using ZC.EasyIO;
using ZC.IFS;
using ZC.IFS.Objects;
using ZC.LOG;
using ZC.MetaInfo;
using ZC.Net;
using ZC.Net.Sockets;
using ZC.Utils;
using ZitApp.Models;

namespace ZitApp.EAP;

public class EapServiceBase : IPassiveAcceptor<Socket>, INamedObject
{
    public virtual string GetObjectName() => "EAP-SERVICE";
    PassiveAcceptHandler<Socket> IPassiveAcceptor<Socket>.AcceptHandler => field ??= OnClientAccept;

    public required ILogger Logger { get; init; }
    public Dictionary<int, object> Handlers { get; } = [];
    public TcpServerSocket ServerSocket { get; private set; } = null!;

    public Task<Result> Start(TcpServerSocket serverSocket)
    {
       ServerSocket = serverSocket;
       ServerSocket.Acceptor = this;
       return ServerSocket.Start();
    }

    public virtual void ReportAlarm(AlarmRecord record)
    {
    }

    public void RegisterHandlerMethods()
    {
       var typeMetaInfo = TypeMetaInfo.Get(GetType());
       foreach (var methodMetaInfo in typeMetaInfo.Methods.Where(t =>
                   t.Name.StartsWith("OnS") && t.Name.EndsWith("Request")))
       {
          var key = methodMetaInfo.Name[3..^7];
          var mid = key.IndexOf("F", StringComparison.Ordinal);
          if (false == int.TryParse(key[..mid], out var stream))
             continue;
          if (false == int.TryParse(key[(mid + 1)..], out var function))
             continue;
          var keyId = stream * 1000 + function;
          Handlers[keyId] = methodMetaInfo;
       }
    }

    private Task<Result<object?>> OnClientAccept(IActiveProvider<Socket> provider, Socket provide, object? args)
    {
       var socket = new NetworkSocket(provide);
       _ = RunClientMain();
       Task RunClientMain() => ClientMain(socket);
       return TaskUtils.ConstValues.TaskResultOkEmpty;
    }

    private async Task ClientMain(NetworkSocket socket)
    {
       var errorCount = 0;
       using var soc = socket;
       var socketKey = soc.ToString();
       Logger.Info($"Client IN: {socketKey}");
       
       var clientBuffer = ArrayPool<byte>.Shared.Rent(102400); 
       
       try
       {
          while (socket.IsOpen)
          {
             var readResult = await socket.ReadContinuousAsync(clientBuffer, 500, 100);
             if (readResult.IsError())
             {
                Logger.Error($"Client Receive Error: {readResult}");
                break;
             }

             var readLength = readResult.Value;
             if (readLength <= 0) continue;

             JsonObject? request = null;
             try
             {
                 request = JsonNode.Parse(clientBuffer.AsSpan(0, readLength)) as JsonObject;
             }
             catch (JsonException jex)
             {
                 Logger.Warn($"Client JSON Parse Error (可能收到半包): {jex.Message}");
                 continue; // 解析失败忽略本次循环，等待完整包（生产环境需考虑粘包拼接缓冲）
             }

             if (request is null)
             {
                Logger.Error($"Client Receive Error: json parse is null");
                break;
             }

             var streamStr = request["Stream"]?.ToString();
             var functionStr = request["Function"]?.ToString();

             if (!int.TryParse(streamStr, out int streamValue))
             {
                Logger.Error($"Client Receive Error: json.Stream is invalid ({streamStr})");
                break;
             }
             if (!int.TryParse(functionStr, out int functionValue))
             {
                Logger.Error($"Client Receive Error: json.Function is invalid ({functionStr})");
                break;
             }

             Logger.Info("CLIENT '{}' REQ: S{stream}F{function}", socketKey, streamValue, functionValue);
             
             var handlerKey = (streamValue * 1000) + functionValue;
             if (false == Handlers.TryGetValue(handlerKey, out var handler))
             {
                errorCount++;
                await socket.WriteAsync(HandlerNotFoundBytes);
             }
             else if (handler is IMethodMetaInfo metaInfo)
             {
                var ret = metaInfo.Delegate!.Invoke(this, [socket, request]);
                if (ret is Task retTask)
                   await retTask;
             }

             if (errorCount > 5)
             {
                Logger.Error($"Client Error times > 5:");
                break;
             }
          }
       }
       catch (Exception ex)
       {
          Logger.Error(ex, $"Client Error: {ex.Message}");
       }
       finally
       {
          ArrayPool<byte>.Shared.Return(clientBuffer);
          Logger.Info($"Client EXIT: {socketKey}");
       }
    }

    public static byte[] HandlerNotFoundBytes { get; set; } = "{ \"Result\": \"Handler not Found\" }"u8.ToArray();

    public virtual async Task OnS1F3Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""1"",
  ""Function"": ""4"",
  ""List"": {{
    ""1001"": ""10.1234"",
    ""1002"": ""5.323"",
    ""1003"": ""TC-0211016-4528""
  }}
}}
");
    }

    public virtual async Task OnS1F11Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
    ""Stream"": ""1"",
    ""Function"": ""12"",
    ""List"": {{
      ""1001"": ""Pressure"",
      ""1002"": ""Temperature"",
      ""1003"": ""ReelID"",
      ""1004"": ""EmpID""
    }}
}}");
    }


    public virtual async Task OnS2F13Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""14"",
  ""List"": {{
    ""2001"": ""10.12"",
    ""2002"": ""Off"",
    ""2003"": ""On""
  }}
}}");
    }

    public virtual async Task OnS2F15Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""16"",
  ""Result"": ""Success""
}}");
    }

    public virtual async Task OnS2F17Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""18"",
  ""Datetime"": ""{DateTime.Now:yyyy-MM-dd HH:mm:ss}""
}}");
    }

    public virtual async Task OnS2F29Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""30"",
  ""List"": {{
    ""2001"": ""Config1"",
    ""2002"": ""Config2"",
    ""2003"": ""Config3"",
    ""2004"": ""Config4""
  }}
}}");
    }

    public virtual async Task OnS2F31Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""32"",
  ""Result"": ""Success""
}}");
    }

    public virtual async Task OnS2F41Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""2"",
  ""Function"": ""42"",
  ""Result"": ""Success""
}}");
    }

    public virtual async Task OnS5F1Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""5"",
  ""Function"": ""2""
}}");
    }

    public virtual async Task OnS5F5Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""5"",
  ""Function"": ""6"",
  ""List"": {{
    ""5001"": ""Alarm desc of 5001"",
    ""5002"": ""Alarm desc of 5002"",
    ""5003"": ""Alarm desc of 5003"",
    ""5004"": ""Alarm desc of 5004""
  }}
}}");
    }

    public virtual async Task OnS5F11Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""6"",    
  ""Function"": ""12""
}}");
    }// 5

    public virtual async Task OnS7F3Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""7"",
  ""Function"": ""4"",
  ""Result"": ""Success""
}}");
    }

    public virtual async Task OnS7F5Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""7"",
  ""Function"": ""6"",
  ""RecipeBody"": ""xxxxxxxxxxxxxxxxxxxxxxxxxxxxx""
}}");
    }

    public virtual async Task OnS7F17Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""7"",
  ""Function"": ""18"",
  ""Result"": ""Success""
}}");
    }

    public virtual async Task OnS7F19Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""7"",
  ""Function"": ""20"",
  ""List"": [ ""Recipe1"", ""Recipe2"", ""Recipe3"" ]
}}");
    }

    public virtual async Task OnS10F3Request(NetworkSocket socket, JsonObject request)
    {
       await socket.WriteUtf8Async($@"{{
  ""Stream"": ""10"",
  ""Function"": ""4"",
  ""Result"": ""Success""
}}");
    }
}