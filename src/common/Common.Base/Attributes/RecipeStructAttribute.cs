namespace ZitApp.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ProductRecipeDefineAttribute : Attribute
{
	public required string ConfigFile { get; set; }
	public required string OutputFile { get; set; }
}