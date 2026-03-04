using HslCommunication.ModBus;
using ZC;
using ZC.BinStructs;
using ZC.IFS;
using ZC.IO;
using ZC.Net.Sockets;

namespace ZitApp.Devices.Plc;

public interface IPlcClient : IBinaryReadWriteConnection
{
}

public class XinJEPlcClient : ModbusTcpNet, IPlcClient
{
	public XinJEPlcClient(string ipAddress, int port) : base(ipAddress, port)
	{
	}

	[Inject]
	public XinJEPlcClient(INetworkSocketConfig config) : base(config.IpAddress, config.Port)
	{
	}

	public XinJEPlcClient()
	{
	}

	public static string[] AddressMap = new string[10000];

	public string Name { get; set; } = "OmronPLC";
	public bool IsOpen => CommunicationPipe.IsConnectError() == false;
	public object? ConnectionError { get; private set; }
	public object? ConnectionConfig { get; private set; }
	public byte[][] WriteTempArrays = new byte[4096][];
	public IOContext DefaultContext => field ??= new IOContext();

	public IIOContext? GetDefaultContext()
	{
		return DefaultContext;
	}

	public IIOContext CreateContext(object? arguments = null)
	{
		return new IOContext();
	}

	Result IBinaryReader.Read(object address, Span<byte> buffer, IIOContext? context = null)
	{
		string? addr = null;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
			addr = pointInfo.Source?.ToString();
		if (addr == null)
			return Result.Err("address is null");
		var result = Read(addr, (ushort)(buffer.Length / 2));
		if (result.IsSuccess == false)
			return Result.Err(result.Message);
		result.Content.CopyTo(buffer);
		return Result.OK;
	}

	public ValueTask<Result> ReadAsync(object address, Memory<byte> buffer, IIOContext? context = null,
		CancellationToken ctk = default)
	{
		string? addr = null;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
			addr = pointInfo.Source?.ToString();
		if (addr == null)
			return ValueTask.FromResult(Result.Err("address is null"));
		return ReadAsyncCore(addr!, buffer, context, ctk);
	}

	private async ValueTask<Result> ReadAsyncCore(string address, Memory<byte> buffer,
		IIOContext? context = null,
		CancellationToken ctk = default)
	{
		var result = await ReadAsync(address, (ushort)(buffer.Length / 2));
		if (result.IsSuccess == false)
			return Result.Err(result.Message);
		result.Content.CopyTo(buffer);
		return Result.OK;
	}

	Result IBinaryWriter.Write(object address, Span<byte> data, IIOContext? context)
	{
		ref var tempArray = ref WriteTempArrays[data.Length];
		if (ReferenceEquals(tempArray, null))
			tempArray = new byte[data.Length];
		data.CopyTo(tempArray);
		string? addr = null;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
			addr = pointInfo.Source?.ToString();
		if (addr == null)
			return Result.Err("address is null");
		var ret = base.Write(addr, tempArray);
		if (ret.IsSuccess == false)
			return Result.Err(ret.Message);
		return Result.OK;
	}

	ValueTask<Result> IBinaryWriter.WriteAsync(object address, Span<byte> data,
		IIOContext? context,
		CancellationToken ctk)
	{
		string? addr = null;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
			addr = pointInfo.Source?.ToString();
		if (addr == null)
			return ValueTask.FromResult(Result.Err("address is null"));
		ref var tempArray = ref WriteTempArrays[data.Length];
		if (ReferenceEquals(tempArray, null))
			tempArray = new byte[data.Length];
		data.CopyTo(tempArray);
		return WriteAsyncCore(addr!, tempArray, context, ctk);
	}

	async ValueTask<Result> WriteAsyncCore(string address, byte[] data, IIOContext? context = null,
		CancellationToken ctk = default)
	{
		var ret = await base.WriteAsync(address, data);
		if (ret.IsSuccess == false)
			return Result.Err(ret.Message);
		return Result.OK;
	}
}