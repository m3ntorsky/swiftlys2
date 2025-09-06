using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Shared.Plugins;

public abstract class BasePlugin : IPlugin {

  public abstract string PluginId { get; }

  public abstract string PluginName { get; }

  public abstract string PluginVersion { get; }


  public virtual void ConfigureSharedServices(IServiceCollection sharedServices) {}

  public virtual void InjectSharedServices(IServiceProvider sharedProvider) {}

  public abstract void Load(ISwiftlyCore core);

  public abstract void Unload();
}