using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Plugin;
using SwiftlyS2.Shared.Plugins;


namespace SwiftlyS2.Core.Managers;

internal class PluginManager {
  private IServiceProvider _Provider { get; init; }

  private IServiceProvider _PluginScopedProvider { get; init; }

  private List<PluginContext> _Plugins { get; } = new();

  public PluginManager(
    IServiceProvider provider
  ) {
    _Provider = provider;
    ServiceCollection pluginScopedServices = new();

    // TODO: Add scoped service here

    _PluginScopedProvider = pluginScopedServices.BuildServiceProvider();
  }

  public void LoadPlugins()
  {
    // TODO: test only, needs optimize
    var pluginDir = Path.Join(AppContext.BaseDirectory, "plugins");
    var pluginPaths = Directory.GetFiles(pluginDir, "*.dll");

    ServiceCollection sharedServices = new();

    foreach (var pluginPath in pluginPaths) {
      var context = LoadPlugin(_Provider, _PluginScopedProvider.CreateScope(), pluginPath);
      context.Plugin.ConfigureSharedServices(sharedServices);
      _Plugins.Add(context);
    }

    var sharedProvider = sharedServices.BuildServiceProvider();

    _Plugins.ForEach(context => context.Plugin.InjectSharedServices(sharedProvider));
  }

  public PluginContext LoadPlugin(
    IServiceProvider coreProvider,
    IServiceScope pluginScope,
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

    plugin.Load(coreProvider);

    PluginContext context = new()
    {
      PluginScope = pluginScope,
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

    var newContext = LoadPlugin(_Provider, _PluginScopedProvider.CreateScope(), path);

    _Plugins.Add(newContext);
    _Plugins.ForEach(context => context.Plugin.ConfigureSharedServices(sharedServices));
    var sharedProvider = sharedServices.BuildServiceProvider();
    _Plugins.ForEach(context => context.Plugin.InjectSharedServices(sharedProvider));
  }
}