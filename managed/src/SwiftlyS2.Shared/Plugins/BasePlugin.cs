using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Shared.Plugins;

public abstract class BasePlugin : IPlugin {

  public virtual void ConfigureSharedServices(IServiceCollection sharedServices) {}

  public virtual void UseSharedServices(IServiceProvider sharedProvider) {}

  public abstract void Load(ISwiftlyCore core);

  public abstract void Unload();
}