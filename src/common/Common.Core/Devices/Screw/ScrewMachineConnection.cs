using HslCommunication.Core;
using HslCommunication.ModBus;
using ZC;
using ZC.BinStructs;
using ZC.DP.Memory;
using ZC.IFS;
using ZC.IO;
using ZC.Net.Sockets;
using ZitApp.Devices.Plc;

namespace ZitApp.Devices.Screw;

public class ScrewMachineConnection : ModbusRtuOverTcp, IBinaryConnection
{
	public ScrewMachineConnection(string ipAddress, int port) : base(ipAddress, port)
	{
	}

	public ScrewMachineConnection()
	{
		DataFormat = DataFormat.CDAB;
	}

	public ScrewMachineConnection(INetworkSocketConfig socketConfig) : this(socketConfig.IpAddress, socketConfig.Port)
	{
		DataFormat = DataFormat.CDAB;
	}

	public static string[] AddressMap = new string[65535];

	public string Name { get; set; } = "SC1";
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

	Result IBinaryReader.Read(object address, Span<byte> buffer, IIOContext? context)
	{
		string? addr = null;
		var isReadBool = false;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
		{
			addr = pointInfo.Source?.ToString();
			if (pointInfo.Type == typeof(WordBool) || pointInfo.Type == typeof(WordBool[]))
				isReadBool = true;
		}
		else if (address is IBinaryPointGroupInfo pointGroupInfo)
		{
			if (pointGroupInfo.Tags?.Contains("WordBool") ?? false)
				isReadBool = true;
			addr = pointGroupInfo.Source?.ToString();
		}

		if (addr == null)
			return Result.Err("address is null");
		if (isReadBool)
		{
			var count = buffer.Length / 2;
			if (count == 1)
			{
				var readBoolResult = ReadBool(addr);
				if (readBoolResult.IsSuccess == false)
					return Result.Err(readBoolResult.Message);
				if (readBoolResult.Content)
					WordBoolExtensions.TrueBytes.CopyTo(buffer);
				else
					WordBoolExtensions.FalseBytes.CopyTo(buffer);
			}
			else
			{
				var readBoolResult = ReadBool(addr, (ushort)count);
				if (readBoolResult.IsSuccess == false)
					return Result.Err(readBoolResult.Message);
				var builder = new SpanBuffer<byte>(buffer);
				foreach (var b in readBoolResult.Content)
				{
					builder.Append(b ? WordBoolExtensions.TrueBytes : WordBoolExtensions.FalseBytes);
				}
			}

			return Result.OK;
		}

		var result = Read(addr, (ushort)(buffer.Length / 2));
		if (result.IsSuccess == false)
			return Result.Err(result.Message);
		result.Content.CopyTo(buffer);
		return Result.OK;
	}

	public async ValueTask<Result> ReadAsync(object address, Memory<byte> buffer, IIOContext? context = null,
		CancellationToken ctk = default)
	{
		string? addr = null;
		var isReadBool = false;
		if (address is string str)
			addr = str;
		else if (address is IBinaryPointInfo pointInfo)
		{
			addr = pointInfo.Source?.ToString();
			if (pointInfo.Type == typeof(WordBool) || pointInfo.Type == typeof(WordBool[]))
				isReadBool = true;
		}
		else if (address is IBinaryPointGroupInfo pointGroupInfo)
		{
			if (pointGroupInfo.Tags?.Contains("WordBool") ?? false)
				isReadBool = true;
			addr = pointGroupInfo.Source?.ToString();
		}

		if (addr == null)
			return Result.Err("address is null");
		if (isReadBool)
		{
			var count = buffer.Length / 2;
			if (count == 1)
			{
				var readBoolResult = await ReadBoolAsync(addr);
				if (readBoolResult.IsSuccess == false)
					return Result.Err(readBoolResult.Message);
				if (readBoolResult.Content)
					WordBoolExtensions.TrueBytes.CopyTo(buffer);
				else
					WordBoolExtensions.FalseBytes.CopyTo(buffer);
			}
			else
			{
				var readBoolResult = await ReadBoolAsync(addr, (ushort)count);
				if (readBoolResult.IsSuccess == false)
					return Result.Err(readBoolResult.Message);
				var builder = new SpanBuffer<byte>(buffer.Span);
				foreach (var b in readBoolResult.Content)
				{
					builder.Append(b ? WordBoolExtensions.TrueBytes : WordBoolExtensions.FalseBytes);
				}
			}

			return Result.OK;
		}

		var result = await ReadAsync(addr, (ushort)(buffer.Length / 2));
		if (result.IsSuccess == false)
			return Result.Err(result.Message);
		result.Content.CopyTo(buffer);
		return Result.OK;
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