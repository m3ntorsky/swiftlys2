using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Shared.Plugins;

public interface IPlugin {

  public string PluginId { get; }

  public string PluginName { get; }

  public string PluginVersion { get; }

  public void ConfigureSharedServices(IServiceCollection sharedServices);

  public void InjectSharedServices(IServiceProvider sharedProvider);

  public void Load(ISwiftlyCore core);

  public void Unload();

}