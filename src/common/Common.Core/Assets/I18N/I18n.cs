using ZC.MetaInfo;

namespace ZitApp;
// [GenerateAvaloniaResource]
public partial class I18n : ZC.RES.ResourceDictionary
{
	public static I18n D { get; } = new I18n();
	public override TypeMetaInfo TypeInfo => field ??= typeof(I18n);

	public partial string 程序名称 { get; set; } = "ASM15-1";
	public partial string 生产信息 { get; set; } = "生产信息";

	#region Main

	public string Main_工单号_ { get; set; } = "工单号:";
	public string Main_已生产数量_ { get; set; } = "已生产数量:";
	public string Main_良率_ { get; set; } = "良率:";
	public string Main_CT_ { get; set; } = "CT:";
	public string Main_工号_ { get; set; } = "工号:";
	public string Main_日志栏 { get; set; } = "日志栏";
	public string Main_数据栏 { get; set; } = "数据栏";
	public string Main_设备状态 { get; set; } = "设备状态";
	public string Main_NG区域 { get; set; } = "NG区域";
	public string Main_测试 { get; set; } = "测试";
	public string Main_机器人吸头 { get; set; } = "机器人吸头";
	public string Main_主页 { get; set; } = "主页";
	public string Main_配方 { get; set; } = "配方";
	public string Main_账户 { get; set; } = "账户";
	public string Main_登录 { get; set; } = "登录";
	public string Main_视图 { get; set; } = "视图";
	public string Main_全部 { get; set; } = "全部";
	public string Recipe_配方_ { get; set; } = "配方:";
	public string Recipe_复制 { get; set; } = "复制";
	public string Recipe_保存 { get; set; } = "保存";
	public string Recipe_导出 { get; set; } = "导出";
	public string Recipe_基础参数 { get; set; } = "基础参数";
	public string Recipe_列表筛选_ { get; set; } = "列表筛选:";
	public string Recipe_全选 { get; set; } = "全选";
	public string Recipe_保存选中 { get; set; } = "保存选中";
	public string Recipe_写入选中 { get; set; } = "写入选中";
	public string Recipe_读取选中 { get; set; } = "读取选中";
	public string Recipe_类别 { get; set; } = "类别";
	public string Recipe_数据名称 { get; set; } = "数据名称";
	public string Recipe_类型 { get; set; } = "类型";
	public string Recipe_保存值 { get; set; } = "保存值";
	public string Recipe_读取值 { get; set; } = "读取值";
	public string Recipe_操作 { get; set; } = "操作";
	public string Recipe_读取 { get; set; } = "读取";
	public string Recipe_写入 { get; set; } = "写入";

	#endregion
}