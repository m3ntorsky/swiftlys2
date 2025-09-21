using System.Text.Json;
using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Events;
using SwiftlyS2.Core.Plugins;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Plugins;


namespace SwiftlyS2.Core.Plugins;

internal class PluginManager {
  private IServiceProvider _Provider { get; init; }
  private RootDirService _RootDirService { get; init; }
  private ILogger _Logger { get; init; }
  private List<PluginContext> _Plugins { get; } = new();
  private FileSystemWatcher? _Watcher { get; set; }
  private ServiceProvider? _SharedServiceProvider { get; set; }

  private DateTime lastRead = DateTime.MinValue;

  public PluginManager(
    IServiceProvider provider,
    ILoggerFactory loggerFactory,
    RootDirService rootDirService
  ) {
    _Provider = provider;
    _RootDirService = rootDirService;
    _Logger = loggerFactory.CreateLogger<PluginManager>();
    _Watcher = new FileSystemWatcher {
      Path = rootDirService.GetPluginsRoot(),
      Filter = "*.dll",
      IncludeSubdirectories = true,
      NotifyFilter = NotifyFilters.LastWrite,
    };

    _Watcher.Changed += HandlePluginChange;

    _Watcher.EnableRaisingEvents = true;
  }

  public void HandlePluginChange(object sender, FileSystemEventArgs e) {
    // why i have to make a debounce here?
    if (DateTime.Now - lastRead < TimeSpan.FromSeconds(1)) {
      return;
    }
    lastRead = DateTime.Now;

    var directory = Path.GetDirectoryName(e.FullPath);
    if (directory == null) {
      return;
    }
    if (File.Exists(Path.Combine(directory, "manifest.json"))) {
      var manifest = JsonSerializer.Deserialize<PluginManifest>(File.ReadAllText(Path.Combine(directory, "manifest.json")));
      if (manifest != null) {
        var id = manifest.Id;
        ReloadPlugin(id);
        return;
      }
    }
  }

  public void LoadPlugins()
  {
    // TODO: test only, needs optimize
    var pluginDirs = Directory.GetDirectories(_RootDirService.GetPluginsRoot());

    foreach (var pluginDir in pluginDirs) {


      try {
        var context = LoadPlugin(pluginDir);
        if (context != null && context.Status == PluginStatus.Loaded) {
          _Logger.LogInformation("Loaded plugin " + context.Plugin!.PluginId);
        }
      } catch (Exception e) {
        _Logger.LogWarning(e, "Error loading plugin: " + pluginDir);
        continue;
      }

    }

    RebuildSharedServices();
  }  

  private void RebuildSharedServices() {

    if (_SharedServiceProvider != null) {
      _SharedServiceProvider.Dispose();
    }

    ServiceCollection sharedServices = new();
    _Plugins
      .Where(p => p.Status == PluginStatus.Loaded)
      .ToList()
      .ForEach(p => p.Plugin!.ConfigureSharedServices(sharedServices));


    _SharedServiceProvider = sharedServices.BuildServiceProvider();

    _Plugins
      .Where(p => p.Status == PluginStatus.Loaded)
      .ToList()
      .ForEach(p => p.Plugin!.UseSharedServices(_SharedServiceProvider));
  }


  public PluginContext? LoadPlugin(string dir)
  {
    if (!File.Exists(Path.Combine(dir, "manifest.json")))
    {
      _Logger.LogWarning("Plugin manifest not found: " + dir);
      return null;
    }
    var manifest = JsonSerializer.Deserialize<PluginManifest>(File.ReadAllText(Path.Combine(dir, "manifest.json")));

    if (manifest == null)
    {
      _Logger.LogWarning("Plugin manifest is invalid: " + dir);
      return null;
    }

    PluginContext context = new()
    {
      Manifest = manifest,
      PluginDirectory = dir,
      Status = PluginStatus.Loading,
    };
    _Plugins.Add(context);

    var entrypointDll = Path.Combine(dir, manifest.EntrypointDLL);

    if (!File.Exists(entrypointDll))
    {
      _Logger.LogWarning("Plugin entrypoint DLL not found: " + entrypointDll);
      context.Status = PluginStatus.Error;
      return null;
    }

    var loader = PluginLoader.CreateFromAssemblyFile(
      assemblyFile: entrypointDll,
      sharedTypes: [ typeof(BasePlugin) ],
      config => {
        config.IsUnloadable = true;
        config.LoadInMemory = true;
      }
    );

    var assembly = loader.LoadDefaultAssembly();

    var pluginType = assembly.GetTypes().FirstOrDefault(t => t.IsSubclassOf(typeof(BasePlugin)))!;
    
    if (pluginType == null) {
      _Logger.LogWarning("Plugin type not found: " + entrypointDll);
      context.Status = PluginStatus.Error;
      return null;
    }

    var plugin = (BasePlugin)Activator.CreateInstance(pluginType)!;

    var core = new SwiftlyCore(plugin.PluginId, Path.GetDirectoryName(entrypointDll)!, pluginType, _Provider);

    core.Initialize(plugin, pluginType);
    
    try {
      plugin.Load(core);
    } catch (Exception e) {
      _Logger.LogWarning(e, $"Error loading plugin {entrypointDll}");
      context.Status = PluginStatus.Error;
      return null;
    };

    context.Status = PluginStatus.Loaded;
    context.Core = core;
    context.Plugin = plugin;
    context.Loader = loader;

    return context;
  }

  public void UnloadPlugin(string id) {
    var context = _Plugins
      .Where(p => p.Status == PluginStatus.Loaded)
      .FirstOrDefault(p => p.Plugin!.PluginId == id);
    if (context == null) {
      _Logger.LogWarning("Plugin not found or not loaded: " + id);
      return;
    }

    context.Dispose();
    context.Status = PluginStatus.Unloaded;
  }

  public void LoadPluginById(string id) {
    var context = _Plugins
      .Where(p => p.Status == PluginStatus.Unloaded)
      .FirstOrDefault(p => p.Manifest.Id == id);
    if (context == null) {
      // try to find new plugins
      var root = _RootDirService.GetPluginsRoot();
      var pluginDirs = Directory.GetDirectories(root);
      foreach (var pluginDir in pluginDirs) {
        if (File.Exists(Path.Combine(pluginDir, "manifest.json"))) {
          var manifest = JsonSerializer.Deserialize<PluginManifest>(File.ReadAllText(Path.Combine(pluginDir, "manifest.json")));
          if (manifest != null && manifest.Id == id) {
            context = LoadPlugin(pluginDir);
            break;
          }
        }
      }
      if (context == null) {
        _Logger.LogWarning("Plugin not found: " + id);
        return;
      }
    } else {
      var directory = context.PluginDirectory!;
      _Plugins.Remove(context);
      LoadPlugin(directory);
    }

    RebuildSharedServices();
  }

  public void ReloadPlugin(string id) {
    _Logger.LogInformation("Reloading plugin " + id);
    UnloadPlugin(id);
    LoadPluginById(id);

    RebuildSharedServices();

    _Logger.LogInformation("Reloaded plugin " + id);
  }
}