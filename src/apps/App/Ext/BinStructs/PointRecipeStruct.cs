using ZC.BinStructs;
using ZC.BinStructs.Ext;
using ZC.MetaInfo;
using ZitApp.Models;

namespace ZitApp.BinStructs;

public partial class PointRecipeStruct
{
	public static PointRecipeStruct Default { get; } = new PointRecipeStruct();
	private static bool _isGroupInit;
	public PointRecipeStruct()
	{
		if (_isGroupInit == false)
			InitGroupDefine();
	}
	static void InitGroupDefine()
	{
		lock (nameof(PointRecipeStruct))
		{
			if(_isGroupInit) return;
			foreach (var grouping in PointRecipeStructInfo.StructInfo.Members.Values.OfType<IBinaryPointInfo>()
				         .Select(t =>
					         (t, TypeMetaInfo<PointRecipeStruct>.Cache.Properties.FirstOrDefault(prop => prop.Name == t.Name)))
				         .GroupBy(t => t.Item2.ValueInfo.Category))
			{
				var list = grouping.ToList();
				var minPoint = list.MinBy(t => t.t.Offset);
				var maxPoint = list.MaxBy(t => t.t.Offset);
				var group = new BinaryPointGroupInfo
				{
					Name = grouping.Key!,
					Start = minPoint.t.Offset,
					End = maxPoint.t.Offset + (maxPoint.t.Length == 0 ? 2 : maxPoint.t.Length),
				};
				group.ByteLength = (group.End - group.Start) * 2;
				group.Points = [];
				group.Source = group.Start.ToString();
				foreach (var item in list)
				{
					item.t.CustomData = group;
					group.Points.Add(item.t);
					// group.PointNames.Add(item.t.Name);
				}

				PointRecipeStructInfo.StructInfo.Members.Add(group.Name, group);
			}

			_isGroupInit = true;
		}

	}

	public static void CopyPropertyValues(PointRecipeStruct src, PointRecipeStruct dst)
	{
		var properties = TypeMetaInfo<PointRecipeStruct>.Cache.Properties;
		foreach (var propertyMetaInfo in properties)
		{
			if (propertyMetaInfo.CanRead && propertyMetaInfo.CanWrite)
			{
				var value = propertyMetaInfo.Getter!.Invoke(src);
				propertyMetaInfo.Setter!.Invoke(dst, value);
			}
		}
	}
}