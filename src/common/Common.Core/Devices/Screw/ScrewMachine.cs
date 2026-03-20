// using ZC;
// using ZC.BinStructs.Ext;
//
// namespace ZitApp.Devices.Screw;
//
// public partial class ScrewMachine
// {
// 	public ScrewMachineData Data { get; private set; } = new();
//
// 	public required ScrewMachineConnection Connection
// 	{
// 		get;
// 		init
// 		{
// 			field = value;
// 			Data.Connection = value;
// 		}
// 	}
//
// 	public Result<IScrewRealPartData> ReadRealPartData()
// 	{
// 		var result = Data.ReadPointGroup(ScrewMachineDataStructInfo.ScrewRealPartData, Connection);
// 		if (result.IsError())
// 			return Result.Err<IScrewRealPartData>(result);
// 		return Result.Ok<IScrewRealPartData>(Data);
// 	}
//
// 	public Result SetControlCommand(ScrewMachineControlCommand cmd)
// 	{
// 		Data.电批动作控制 = cmd;
// 		var result = Data.WritePoint(nameof(ScrewMachineData.电批动作控制));
// 		return result;
// 	}
//
// 	public static int GetTaskOptionsChannelOffset(int channel)
// 	{
// 		return 4000 + channel * 150;
// 	}
// }