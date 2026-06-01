using System.Net.Sockets;
using System.Text;

const string DefaultIp = "10.5.1.160";
const int DefaultPort = 21347;
const int ReadTimeout = 3000;
const int BufferSize = 4096;

Console.WriteLine("=== SIFS 消息发送工具 ===\n");

Console.Write($"请输入 IP [{DefaultIp}]: ");
var ipInput = Console.ReadLine()?.Trim();
var ip = string.IsNullOrEmpty(ipInput) ? DefaultIp : ipInput;

Console.Write($"请输入端口 [{DefaultPort}]: ");
var portInput = Console.ReadLine()?.Trim();
var port = string.IsNullOrEmpty(portInput) ? DefaultPort : int.Parse(portInput);

Console.WriteLine($"\n目标: {ip}:{port}");
Console.WriteLine("输入消息发送，输入 quit 退出\n");

while (true)
{
    Console.Write("> ");
    var msg = Console.ReadLine();
    if (msg == null || msg.Equals("quit", StringComparison.OrdinalIgnoreCase))
        break;

    if (string.IsNullOrWhiteSpace(msg))
        continue;

    try
    {
        using var client = new TcpClient();
        client.Connect(ip, port);
        using var stream = client.GetStream();
        stream.ReadTimeout = ReadTimeout;

        var data = Encoding.UTF8.GetBytes(msg);
        stream.Write(data, 0, data.Length);

        Thread.Sleep(300);

        var buffer = new byte[BufferSize];
        var totalRead = 0;

        try
        {
            while (true)
            {
                var read = stream.Read(buffer, totalRead, BufferSize - totalRead);
                if (read <= 0) break;
                totalRead += read;
                if (!stream.DataAvailable) break;
            }
        }
        catch (IOException)
        {
            // 超时，读取结束
        }

        if (totalRead > 0)
        {
            var response = Encoding.UTF8.GetString(buffer, 0, totalRead);
            Console.WriteLine($"<<< {response}\n");
        }
        else
        {
            Console.WriteLine("<<< (无响应/超时)\n");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"<<< [错误] {ex.Message}\n");
    }
}

Console.WriteLine("已退出。");
