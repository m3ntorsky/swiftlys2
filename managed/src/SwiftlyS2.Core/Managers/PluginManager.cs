using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Events;
using SwiftlyS2.Core.Plugins;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Plugins;


namespace SwiftlyS2.Core.Managers;

internal class PluginManager {
  private IServiceProvider _Provider { get; init; }

  private RootDirService _RootDirService { get; init; }

  private List<PluginContext> _Plugins { get; } = new();

  public PluginManager(
    IServiceProvider provider,
    RootDirService rootDirService
  ) {
    _Provider = provider;
    _RootDirService = rootDirService;
  }

  public void LoadPlugins()
  {
    // TODO: test only, needs optimize
    var pluginDir = _RootDirService.CombineRoot("plugins");
    var pluginPaths = Directory.GetFiles(pluginDir, "*.dll");

    ServiceCollection sharedServices = new();

    foreach (var pluginPath in pluginPaths) {
      var context = LoadPlugin(pluginPath);
      if (context == null) continue;
      context.Plugin.ConfigureSharedServices(sharedServices);
      _Plugins.Add(context);
    }

    var sharedProvider = sharedServices.BuildServiceProvider();

    _Plugins.ForEach(context => context.Plugin.UseSharedServices(sharedProvider));
  }

  public PluginContext? LoadPlugin(
    string dllPath) {

    var loader = PluginLoader.CreateFromAssemblyFile(
      assemblyFile: dllPath,
      sharedTypes: [ typeof(BasePlugin) ],
      config => {
        config.IsUnloadable = true;
        config.LoadInMemory = true;
      }
    );

    var assembly = loader.LoadDefaultAssembly();

    var pluginType = assembly.GetTypes().FirstOrDefault(t => t.IsSubclassOf(typeof(BasePlugin)))!;

    var plugin = (BasePlugin)Activator.CreateInstance(pluginType)!;

    var core = new SwiftlyCore(plugin.PluginId, Path.GetDirectoryName(dllPath)!, _Provider);
    
    try {
      plugin.Load(core);
    } catch (Exception e) {
      // TODO: properly log this
      // Console.WriteLine($"Error loading plugin {dllPath}: {e.Message}");
      return null;
    };

    PluginContext context = new()
    {
      Core = core,
      PluginPath = dllPath,
      Plugin = plugin,
      Loader = loader
    };
    
    context.SetupWatcher(() => ReloadPlugin(context));

    return context;
  }

  public void ReloadPlugin(PluginContext context) {
    var path = context.PluginPath;

    _Plugins.Remove(context);
    context.Dispose();

    ServiceCollection sharedServices = new();

    var newContext = LoadPlugin(path);

    if (newContext != null) {
      _Plugins.Add(newContext);
    };

    _Plugins.ForEach(context => context.Plugin.ConfigureSharedServices(sharedServices));
    var sharedProvider = sharedServices.BuildServiceProvider();
    _Plugins.ForEach(context => context.Plugin.UseSharedServices(sharedProvider));
  }
}