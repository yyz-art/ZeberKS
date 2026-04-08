using ZC.CFG;
using ZC.DP;

namespace ZitApp;

public abstract partial class CommonAppConfig : ConfigBase
{
	public const string NameByCN = "NameByCN";
	public const string NameByVI = "NameByVI";
	public const string NameByEN = "NameByEN";
	public string Language { get; set; } = "cn";


	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS ENABLE",
		DataDefine.KeyValue, NameByEN, "SIFS ENABLE",
		DataDefine.KeyValue, NameByVI, "SIFS ENABLE",
	], DefaultValue = "true", Description = "SIFS ENABLE")]
	public bool SifsEnable { get; set; } = true;

	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS HOST ADDRESS",
		DataDefine.KeyValue, NameByEN, "SIFS HOST ADDRESS",
		DataDefine.KeyValue, NameByVI, "SIFS HOST ADDRESS",
	], DefaultValue = "10.5.1.160", Description = "SIFS IP ADDRESS")]
	public string SifsHostIp { get; set; } = "10.5.1.160";

	[ValueInfo(Category = "SIFS", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "SIFS HOST PORT",
		DataDefine.KeyValue, NameByEN, "SIFS HOST PORT",
		DataDefine.KeyValue, NameByVI, "SIFS HOST PORT",
	], DefaultValue = "21347", Description = "SIFS HOST PORT")]
	public int SifsHostPort { get; set; } = 21347;


	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP ENABLE",
		DataDefine.KeyValue, NameByEN, "EAP ENABLE",
		DataDefine.KeyValue, NameByVI, "EAP ENABLE",
	], DefaultValue = "true", Description = "EAP ENABLE")]
	public bool EapEnable { get; set; } = true;

	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP HOST ADDRESS",
		DataDefine.KeyValue, NameByEN, "EAP HOST ADDRESS",
		DataDefine.KeyValue, NameByVI, "EAP HOST ADDRESS",
	], DefaultValue = "10.5.1.160", Description = "EAP IP ADDRESS")]
	public string EapHostIp { get; set; } = "10.5.1.160";

	[ValueInfo(Category = "EAP", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByEN, "EAP HOST PORT",
		DataDefine.KeyValue, NameByVI, "EAP HOST PORT",
	], DefaultValue = "21347", Description = "EAP HOST PORT")]
	public int EapHostPort { get; set; } = 21347;

	#region 生产配置

	[ValueInfo(Category = "生产配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "Line",
		DataDefine.KeyValue, NameByEN, "Line",
		DataDefine.KeyValue, NameByVI, "Line",
	], DefaultValue = 9600, Description = "Line")]
	public string Line { get; set; } = "TestLine";

	[ValueInfo(Category = "生产配置", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "StationName",
		DataDefine.KeyValue, NameByEN, "StationName",
		DataDefine.KeyValue, NameByVI, "StationName",
	], DefaultValue = 9600, Description = "StationName")]
	public string StationName { get; set; } = "TestStation";

	#endregion

	#region MyRegion

	
	[ValueInfo(Category = "备注", InitAttachData =
	[
		DataDefine.KeyValue, NameByCN, "联系方式",
		DataDefine.KeyValue, NameByEN, "联系方式",
		DataDefine.KeyValue, NameByVI, "联系方式",
	], DefaultValue = 9600, Description = "联系方式")]
	public string 联系方式 { get; set; } = "1234567890";
	#endregion
}