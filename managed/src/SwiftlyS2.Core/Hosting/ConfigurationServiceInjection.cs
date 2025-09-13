using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class ConfigurationServiceInjection
{
  public static void AddConfigurationService(this IServiceCollection self)
  {
    self.AddSingleton<ConfigurationService>();
  }
}