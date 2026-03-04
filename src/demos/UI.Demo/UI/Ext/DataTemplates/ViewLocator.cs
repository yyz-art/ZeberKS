using Avalonia.Controls.Templates;

namespace OinetApp.UI.DataTemplates;

public class ViewLocator : IDataTemplate
{
	public Control? Build(object? param)
	{
		if (param is null) return null;
		var name = param.GetType().Name.Replace("ViewModel", "");
		var type = Type.GetType("OinetApp.UI.Views.Demo.Ext." + name);
		if (type != null)
		{
			return (Control)Activator.CreateInstance(type)!;
		}

		return new TextBlock { Text = "Not Found: " + name };
	}

	public bool Match(object? data)
	{
		return true;
	}
}