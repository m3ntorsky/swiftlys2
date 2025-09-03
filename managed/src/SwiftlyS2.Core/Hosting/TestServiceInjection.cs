using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Managers;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class TestServiceInjection
{
  public static void AddTestService(this IServiceCollection self)
  {
    self.AddSingleton<TestService>();
    self.AddSingleton<PluginManager>();
  }

  public static void UseTestService(this IServiceProvider self)
  {
    try
    {
      self.GetRequiredService<TestService>();
      self.GetRequiredService<PluginManager>().LoadPlugins();

    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }
}