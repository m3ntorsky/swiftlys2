using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Modules.Engine;

namespace SwiftlyS2.Core.Hosting;

internal static class CommandTrackedServiceInjection
{
  public static IServiceCollection AddCommandTrackedService(this IServiceCollection self)
  {
    return self.AddSingleton<CommandTrackedService>();
  }

  public static void UseCommandTrackedService(this IServiceProvider self)
  {
    self.GetRequiredService<CommandTrackedService>();
  }
}