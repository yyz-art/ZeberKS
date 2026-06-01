using System.Text.Json.Nodes;
using ZC.LOG;
using ZC.MetaInfo;
using ZitApp.BinStructs;

namespace ZitApp.Ext.EapClient;

/// <summary>
/// PLC 报警文本目录，维护 AlarmId → AlarmName 映射，供 S5F5 定义上报使用。
/// </summary>
public class PlcAlarmTextCatalog
{
    private readonly Dictionary<int, string> _alarmTexts = new();

    public void Register(int alarmId, string alarmName)
    {
        _alarmTexts[alarmId] = alarmName;
    }

    public void Load(IEnumerable<(int AlarmId, string AlarmName)> alarms, ILogger logger)
    {
        _alarmTexts.Clear();
        foreach (var (alarmId, alarmName) in alarms)
        {
            _alarmTexts[alarmId] = alarmName;
        }

        logger.Info("PlcAlarmTextCatalog loaded {Count} alarm definitions", _alarmTexts.Count);
    }

    /// <summary>
    /// 从 PlcAlarmStruct 的 [ValueInfo] 元数据反射加载报警定义。
    /// AlarmID = InitAttachData["Id"]，AlarmText = InitAttachData["NameByCN"]。
    /// </summary>
    public void LoadFromPlcAlarmStruct(ILogger logger)
    {
        _alarmTexts.Clear();
        var properties = TypeMetaInfo<PlcAlarmStruct>.Cache.Properties;
        foreach (var prop in properties)
        {
            var valueInfo = prop.Attributes.FirstOrDefault(a => a is ValueInfoAttribute) as ValueInfoAttribute;
            if (valueInfo is null) continue;

            var idStr = valueInfo.GetAttachData("Id".AsMemory()).Value?.ToString();
            var name = valueInfo.GetAttachData("NameByCN".AsMemory()).Value?.ToString();

            if (int.TryParse(idStr, out var alarmId) && !string.IsNullOrEmpty(name))
            {
                _alarmTexts[alarmId] = name;
            }
        }

        logger.Info("PlcAlarmTextCatalog loaded {Count} alarm definitions from PlcAlarmStruct", _alarmTexts.Count);
    }

    /// <summary>
    /// 构建 EAP S5F5 报警定义列表：{"AlarmId": "AlarmName", ...}
    /// </summary>
    public JsonArray BuildEapDefinitionList()
    {
        var array = new JsonArray();
        foreach (var (id, name) in _alarmTexts.OrderBy(k => k.Key))
        {
            array.Add(new JsonObject
            {
                ["AlarmID"] = (id + 5000).ToString(),
                ["AlarmText"] = name
            });
        }

        return array;
    }
}
