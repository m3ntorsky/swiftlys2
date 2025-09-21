using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Plugins;

namespace SwiftlyS2.Core.Hosting;

internal static class PluginManagerInjection
{
  public static void AddPluginManager(this IServiceCollection self)
  {
    self.AddSingleton<PluginManager>();
  }

  public static void UsePluginManager(this IServiceProvider self)
  {
    self.GetRequiredService<PluginManager>().LoadPlugins();
  }
}