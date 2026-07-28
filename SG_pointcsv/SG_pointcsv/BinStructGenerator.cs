using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;

namespace SG_pointcsv;

[Generator]
public class BinStructGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var xmlFiles = context.AdditionalTextsProvider
            .Where(f => Path.GetFileName(f.Path).Equals("BinStructs.xml", StringComparison.OrdinalIgnoreCase))
            .Collect();

        var csvFiles = context.AdditionalTextsProvider
            .Where(f => Path.GetFileName(f.Path).EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            .Collect();

        var combined = xmlFiles.Combine(csvFiles);

        context.RegisterSourceOutput(combined, GenerateCode);
    }

    private void GenerateCode(SourceProductionContext context,
        (ImmutableArray<AdditionalText> XmlFiles, ImmutableArray<AdditionalText> CsvFiles) inputs)
    {
        var csvDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var csv in inputs.CsvFiles)
        {
            var content = csv.GetText(context.CancellationToken)?.ToString();
            if (content != null)
                csvDict[Path.GetFileName(csv.Path)] = content;
        }

        foreach (var xmlFile in inputs.XmlFiles)
        {
            var content = xmlFile.GetText(context.CancellationToken)?.ToString();
            if (string.IsNullOrEmpty(content)) continue;

            try
            {
                var doc = XDocument.Parse(content);
                if (doc.Root == null) continue;

                foreach (var structXml in doc.Root.Elements("Struct"))
                {
                    GenerateStruct(context, structXml, csvDict);
                }
            }
            catch (Exception ex)
            {
                context.ReportDiagnostic(Diagnostic.Create(
                    new DiagnosticDescriptor("BSG001", "XML Parse Error",
                        "Failed to parse BinStructs.xml: {0}", "BinStruct", DiagnosticSeverity.Error, true),
                    Location.None, ex.Message));
            }
        }
    }

    private void GenerateStruct(SourceProductionContext context,
        XElement structXml, Dictionary<string, string> csvDict)
    {
        var structName = GetRequiredAttribute(structXml, "Name");
        var namespaceName = GetRequiredAttribute(structXml, "Namespace");
        var usings = GetAttributeOrDefault(structXml, "Usings", "");
        var length = GetRequiredAttribute(structXml, "Length");
        var lengthUnit = GetRequiredAttribute(structXml, "LengthUnit");
        var byteFormat = GetRequiredAttribute(structXml, "ByteFormat");

        var code = new StringBuilder();
        code.AppendLine();
        code.AppendLine($"// Generated at {DateTime.Now:yyyy/M/d HH:mm:ss}");
        code.AppendLine("using ZC.Annotations;");
        code.AppendLine("using ZC.DP.Memory;");
        code.AppendLine("using ZC.DP;");

        if (!string.IsNullOrEmpty(usings))
        {
            foreach (var u in usings.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var trimmed = u.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                    code.AppendLine($"using {trimmed};");
            }
        }

        code.AppendLine();
        code.AppendLine($"namespace {namespaceName};");
        code.AppendLine($"[BinaryStruct(Length = {length}, LengthUnit = {lengthUnit}, ByteFormat = {byteFormat})]");

        foreach (var group in structXml.Elements("BinaryPointGroup"))
        {
            var name = GetRequiredAttribute(group, "Name").Replace('-', '_');
            var start = GetRequiredAttribute(group, "Start");
            var end = GetRequiredAttribute(group, "End");
            var source = GetAttributeOrDefault(group, "Source", start);
            var tags = GetAttributeOrDefault(group, "Tags", "");

            code.AppendLine($"[BinaryPointGroup(Name = \"{name}\", Source = \"{source}\", Tags = \"{tags}\", Start = {start}, End = {end}, Points = [\"*\"])]");
        }

        code.AppendLine($"public partial class {structName}");
        code.AppendLine("{");

        foreach (var csvInclude in structXml.Elements("CsvIncludePoints"))
        {
            GenerateCsvIncludePoints(code, csvInclude, csvDict);
        }

        code.AppendLine("}");

        context.AddSource($"{structName}.gen.cs", code.ToString());
    }

    private void GenerateCsvIncludePoints(StringBuilder code, XElement csvIncludeXml,
        Dictionary<string, string> csvDict)
    {
        var csvFileName = GetRequiredAttribute(csvIncludeXml, "FilePath");
        var regionName = GetAttributeOrDefault(csvIncludeXml, "Name", csvFileName);

        if (!csvDict.TryGetValue(csvFileName, out var csvContent))
        {
            code.AppendLine($"    // CSV file not found: {csvFileName}");
            return;
        }

        var setters = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var setter in csvIncludeXml.Elements("Setter"))
        {
            var prop = GetRequiredAttribute(setter, "Property");
            var value = setter.Attribute("Value")?.Value ?? setter.Value;
            setters[prop] = value;
        }

        var lines = csvContent.Split(new[] { '\n' });
        if (lines.Length < 2) return;

        var headers = ParseCsvLine(lines[0]);

        code.AppendLine();
        code.AppendLine($"\t#region CSV INCLUDE POINTS: {regionName}");
        code.AppendLine();

        for (int i = 1; i < lines.Length; i++)
        {
            var line = lines[i].Trim();
            if (string.IsNullOrEmpty(line) || line.StartsWith("//")) continue;

            var values = ParseCsvLine(line);
            var rowProps = new Dictionary<string, string>(setters, StringComparer.OrdinalIgnoreCase);

            for (int j = 0; j < headers.Length && j < values.Length; j++)
            {
                rowProps[headers[j]] = values[j];
            }

            var offset = GetPropValue(rowProps, "Offset", "0");
            var dataType = GetPropValue(rowProps, "DataType", "byte");
            var pointName = GetPropValue(rowProps, "Name", $"Point_{offset}");
            var source = GetPropValue(rowProps, "Source", offset);
            var readerData = GetPropValue(rowProps, "ReaderData", "");
            var writerData = GetPropValue(rowProps, "WriterData", "");
            var category = GetPropValue(rowProps, "Category", "");
            var unit = GetPropValue(rowProps, "Unit", "");
            var minValue = GetPropValue(rowProps, "MinValue", "0");
            var maxValue = GetPropValue(rowProps, "MaxValue", "4096");
            var description = GetPropValue(rowProps, "Description", "");
            var initExpress = GetPropValue(rowProps, "InitExpress", "");
            var beforeToken = GetPropValue(rowProps, "BeforeToken", "public");
            var customData = GetPropValue(rowProps, "CustomData", "null");
            var tags = GetPropValue(rowProps, "Tags", "");

            var attachDataNames = GetPropValue(rowProps, "AttachDataNames", "");
            var attachDataStr = "null";
            if (!string.IsNullOrEmpty(attachDataNames))
            {
                var attachBuilder = new StringBuilder(" [");
                foreach (var name in attachDataNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var nameTrimmed = name.Trim();
                    var val = GetPropValue(rowProps, nameTrimmed, "");
                    attachBuilder.Append($"\n\t\tDataDefine.KeyValue,\"{nameTrimmed}\", \"{val}\",");
                }
                if (attachBuilder.Length > 2)
                {
                    attachBuilder.Append(" ]");
                    attachDataStr = attachBuilder.ToString();
                }
            }

            code.AppendLine($"\t[BinaryPoint(Offset = {offset}, Source = \"{source}\", Tags = \"{tags}\", ReaderData = \"{readerData}\", WriterData = \"{writerData}\", CustomData = {customData})]");
            code.AppendLine($"\t[ValueInfo(Source = \"{readerData}:{source}\", Category = \"{category}\", Unit = \"{unit}\", MinValue = {minValue}, MaxValue = {maxValue}, Description = \"{EscapeString(description)}\", InitAttachData = {attachDataStr})]");
            var initStr = string.IsNullOrEmpty(initExpress) ? "" : $"= {initExpress}";
            code.AppendLine($"\t{beforeToken} {dataType} {pointName} {{ get; set; }}{initStr}");
            code.AppendLine();
        }

        code.AppendLine($"\t#endregion");
    }

    private static string GetPropValue(Dictionary<string, string> dict, string key, string defaultValue)
    {
        if (dict.TryGetValue(key, out var value))
            return value;
        return defaultValue;
    }

    private static string[] ParseCsvLine(string line)
    {
        var result = new List<string>();
        var current = new StringBuilder();
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (c == '"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    current.Append('"');
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(current.ToString().Trim());
                current.Clear();
            }
            else
            {
                current.Append(c);
            }
        }
        result.Add(current.ToString().Trim());
        return result.ToArray();
    }

    private static string EscapeString(string str)
    {
        if (string.IsNullOrEmpty(str)) return "";
        return str.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }

    private static string GetRequiredAttribute(XElement element, string name)
    {
        return element.Attribute(name)?.Value
            ?? throw new InvalidOperationException($"Missing required attribute '{name}' on <{element.Name.LocalName}>");
    }

    private static string GetAttributeOrDefault(XElement element, string name, string defaultValue)
    {
        return element.Attribute(name)?.Value ?? defaultValue;
    }
}
