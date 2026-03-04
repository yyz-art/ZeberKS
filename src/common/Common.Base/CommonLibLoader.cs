using System.Reflection;
using System.Runtime.CompilerServices;

namespace ZitApp;

public class CommonLibLoader
{
	public static string LibsPath { get; set; } = Path.Combine(Environment.CurrentDirectory, "libs");

	public static void Initialize()
	{
		Environment.SetEnvironmentVariable("PATH",
			Environment.GetEnvironmentVariable("PATH") + $@";{LibsPath};{LibsPath}/native;{LibsPath}/common;{LibsPath}/framework",
			EnvironmentVariableTarget.Process);
		var appLoader = new CommonLibLoader();
		AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
		Console.WriteLine($"ZIT.DOTNET FRAMEWORK LOADING ...");
	}

	public static Assembly? OnAssemblyResolve(object? sender, ResolveEventArgs args)
	{
		try
		{
			var appLoader = new CommonLibLoader();
			var argsName = args.Name.Split(',')[0];
			var assemblyDllPath = Directory.GetFiles(LibsPath, $"{argsName}.dll", SearchOption.AllDirectories)
				.FirstOrDefault();
			var assemblyPdbPath = Directory.GetFiles(LibsPath, $"{argsName}.pdb", SearchOption.AllDirectories)
				.FirstOrDefault();
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			var exists = assemblies.FirstOrDefault(a => a.GetName().Name == argsName);
			if (exists != null)
				return exists;
			if (false == File.Exists(assemblyDllPath))
			{
				// Console.WriteLine($"Assembly not found: {args.Name}");
				return null;
			}
			byte[]? pdbBytes = null;
			var dllBytes = File.ReadAllBytes(assemblyDllPath);
			var assembly = pdbBytes != null ? Assembly.Load(dllBytes, pdbBytes) : Assembly.Load(dllBytes);
			Array.Clear(dllBytes, 0, dllBytes.Length);
			if (pdbBytes != null) Array.Clear(pdbBytes, 0, pdbBytes.Length);
			Console.WriteLine($"Load Assembly: {args.Name}");
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
		if (!Directory.Exists(LibsPath))
		{
			Console.WriteLine($"Assembly path not found: {LibsPath}");
			return;
		}

		foreach (var dllPath in Directory.GetFiles(LibsPath, "*.dll", SearchOption.TopDirectoryOnly))
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