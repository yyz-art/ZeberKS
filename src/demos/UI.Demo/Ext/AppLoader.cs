using System.Reflection;
using System.Runtime.CompilerServices;

namespace OinetApp.Ext;

public class AppLoader
{
	public static string AssemblyPath { get; set; } = Path.Combine(Environment.CurrentDirectory, "libs");
	// [ModuleInitializer]
	public static void Init()
	{

		AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
		Console.WriteLine("OINET.DOTNET FRAMEWORK LOADING ...");

		#region MyRegion

		Environment.SetEnvironmentVariable("PATH",
			Environment.GetEnvironmentVariable("PATH") + $@";{AssemblyPath}",
			EnvironmentVariableTarget.Process);
		// LoadAllAssemblies();

		#endregion
	}

	public static Assembly? OnAssemblyResolve(object? sender, ResolveEventArgs args)
	{
		try
		{
			var argsName = args.Name.Split(',')[0];
			var assemblyDllPath = Path.Combine(AssemblyPath, $"{argsName}.dll");
			var assemblyPdbPath = Path.Combine(AssemblyPath, $"{argsName}.pdb");
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			var exists = assemblies.FirstOrDefault(a => a.GetName().Name == argsName);
			if (exists != null) return exists;
			if (false == File.Exists(assemblyDllPath)) return null;
			byte[]? pdbBytes = null;
			var dllBytes = File.ReadAllBytes(assemblyDllPath);
			var assembly = pdbBytes != null ? Assembly.Load(dllBytes, pdbBytes) : Assembly.Load(dllBytes);
			Array.Clear(dllBytes, 0, dllBytes.Length);
			if (pdbBytes != null) Array.Clear(pdbBytes, 0, pdbBytes.Length);
			return assembly;
		}
		catch (Exception ex)
		{
			Console.WriteLine("OnAssemblyResolveEX " + ex);
			throw;
		}
	}

	public static void LoadAllAssemblies()
	{
		if (!Directory.Exists(AssemblyPath))
		{
			Console.WriteLine($"Assembly path not found: {AssemblyPath}");
			return;
		}

		foreach (var dllPath in Directory.GetFiles(AssemblyPath, "*.dll", SearchOption.TopDirectoryOnly))
		{
			try
			{
				var name = AssemblyName.GetAssemblyName(dllPath).Name;
				if (AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == name))
					continue;

				var pdbPath = Path.ChangeExtension(dllPath, ".pdb");
				var dllBytes = File.ReadAllBytes(dllPath);
				var pdbBytes = File.Exists(pdbPath) ? File.ReadAllBytes(pdbPath) : null;

				var assembly = pdbBytes != null
					? Assembly.Load(dllBytes, pdbBytes)
					: Assembly.Load(dllBytes);

				Console.WriteLine($"Loaded from memory: {Path.GetFileName(dllPath)}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Failed to load {dllPath}: {ex.Message}");
			}
		}
	}
}