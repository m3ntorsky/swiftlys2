using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Shared.Plugins;

public interface IPlugin {

  public void ConfigureSharedServices(IServiceCollection sharedServices);

  public void UseSharedServices(IServiceProvider sharedProvider);

  public void Load(ISwiftlyCore core);

  public void Unload();

}