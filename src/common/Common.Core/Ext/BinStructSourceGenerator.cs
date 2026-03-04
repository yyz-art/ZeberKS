using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using ZC.DP.Memory;
using ZC.DP.Text.CSV;
using ZC.Text;

namespace ZitApp;

public class SourceCodeBuilder : MutString
{
	public MutString BeginCode { get; set; } = new();
	public MutString EndCode { get; set; } = new();

	public string BuildFinalCode()
	{
		return $"{BeginCode.Span}{this.Span}{EndCode.Span}";
	}
}

public class BinStructSourceGenerator
{
	public void Generate(string xml)
	{
		var doc = XDocument.Parse(xml, LoadOptions.SetLineInfo);
		Debug.Assert(doc.Root?.Name.LocalName is "BinStructProject");

		foreach (var structXml in doc.Root.Elements("Struct"))
		{
			GenerateStruct(structXml);
		}
	}

	private void GenerateStruct(XElement structXml)
	{
		var code = new SourceCodeBuilder();
		var structName = structXml.GetAttribute("Name").Value;
		var usings = structXml.GetAttribute("Usings").Value.Split(';').Where(t => string.IsNullOrWhiteSpace(t) == false)
			.Select(t => $"using {t};\n");

		var @namespace = structXml.GetAttribute("Namespace").Value;
		var outputFile = structXml.GetAttribute("OutputFile").Value;
		var structLength = structXml.GetAttribute("Length").Value;
		var structLengthUnit = structXml.GetAttribute("LengthUnit").Value;
		var structByteFormat = structXml.GetAttribute("ByteFormat").Value;
		code.BeginCode.Append($@"
// GENERATE AT {DateTime.Now}
using ZC.Annotations;
using ZC.DP.Memory;
{string.Concat(usings)}
namespace {@namespace};
[BinaryStruct(Length = {structXml.GetAttribute("Length").Value}, LengthUnit = {structLengthUnit}, ByteFormat = {structByteFormat})]");
		foreach (var pointGroupXml in structXml.Elements("BinaryPointGroup"))
		{
			var name = pointGroupXml.GetAttribute("Name").Value;
			var start = pointGroupXml.GetAttribute("Start").Value;
			var source = pointGroupXml.GetAttributeOrDefault("Source")?.Value ?? start;
			var end = pointGroupXml.GetAttribute("End").Value;
			code.BeginCode.Append($@"
[BinaryPointGroup(Name = ""{name}"", Source = ""{source}"", Start = {start}, End = {end}, Points = [""*""])]");
		}

		code.Append($@"
public partial class {structName}
{{
");
		foreach (var csvIncludePointsXml in structXml.Elements("CsvIncludePoints"))
		{
			GenerateCsvIncludePoints(code, csvIncludePointsXml);
		}

		code.Append($@"
}}");
		if (false == string.IsNullOrEmpty(outputFile))
		{
			var finalCode = code.BuildFinalCode();
			File.WriteAllText(outputFile, finalCode);
		}
	}

	private void GenerateCsvIncludePoints(SourceCodeBuilder code, XElement xml)
	{
		var properties = new Dictionary<string, ReadOnlyMemory<char>>();
		code.Append($@"
	#region CSV INCLUDE POINTS: {xml.GetAttribute("Name").Value}
");
		foreach (var setter in xml.Elements("Setter"))
		{
			var name = setter.GetAttribute("Property").Value;
			var valueAttr = setter.GetAttributeOrDefault("Value");
			if (valueAttr is not null)
				properties[name] = valueAttr.Value.AsMemory();
			else
				properties[name] = setter.Value.AsMemory();
		}

		var csvHeaders = xml.GetAttribute("CsvHeaders").Value.Split(',');
		var csvContent = string.Concat(xml.Nodes().Where(n => n is XText || n is XCData).Select(n =>
			n switch { XCData cdata => cdata.Value.Trim(), XText text => text.Value.Trim(), _ => string.Empty }));
		
		var lineEnumerator = new MemorySplitEnumerator<char>(csvContent.AsMemory(), "\n".AsMemory());
		while (lineEnumerator.MoveNext())
		{
			for (var i = 0; i < csvHeaders.Length; i++)
				properties[csvHeaders[i]] = default;
			var line = lineEnumerator.Current.Trim();
			var lineSpan = line.Span;
			if (line.IsEmpty || lineSpan.StartsWith("//")) continue;
			var valuesEnumerator = new CsvValueMemoryEnumerator(line);
			var csvValueI = 0;
			while (valuesEnumerator.ReadNext(out var value) && csvValueI < csvHeaders.Length)
			{
				properties[csvHeaders[csvValueI]] = value;
				csvValueI++;
			}

			var offset = properties["Offset"];

			var dataType = properties["DataType"];
			var pointName = properties["Name"];

			var beforeToken = properties.GetValueOrDefault("BeforeToken");
			if (beforeToken.IsEmpty) beforeToken = "public".AsMemory();
			var tags = properties.GetValueOrDefault("Tags");
			var category = properties.GetValueOrDefault("Category");
			var description = properties.GetValueOrDefault("Description");
			var readerData = properties.GetValueOrDefault("ReaderData");
			var writerData = properties.GetValueOrDefault("WriterData");
			var customData = properties.GetValueOrDefault("CustomData", "null".AsMemory());
			var source = properties.GetValueOrDefault("Source", offset);
			code.Append($@"
	[BinaryPoint(Offset = {offset}, Source = ""{source}"", Tags = ""{tags}"", ReaderData = ""{readerData}"", WriterData = ""{writerData}"", CustomData = {customData})]
	[ValueInfo(Source = ""{readerData}:{source}"", Category = ""{category}"", Unit = ""{properties.GetValueOrDefault("Unit")}"",MinValue = {properties.GetValueOrDefault("MinValue", "0".AsMemory())}, MaxValue = {properties.GetValueOrDefault("MaxValue", "4096".AsMemory())}, Description = ""{description}"")]
	{beforeToken} {dataType} {pointName} {{ get; set; }}");
		}

		code.Append($@"
	#endregion
");
	}
}

public static class XmlUtils
{
	public static XAttribute GetAttribute(this XElement self, string name, string? errMessage = null)
	{
		var attribute = self.Attribute(name);
		if (attribute is not null)
			return attribute;

		var xmlLineInfo = attribute as IXmlLineInfo;
		if (xmlLineInfo != null)
			errMessage += $"at line {xmlLineInfo.LineNumber}:{xmlLineInfo.LinePosition}";
		throw new XmlException(errMessage);
	}

	public static XAttribute? GetAttributeOrDefault(this XElement self, string name)
	{
		var attribute = self.Attribute(name);
		if (attribute is not null)
			return attribute;

		return null;
	}
}