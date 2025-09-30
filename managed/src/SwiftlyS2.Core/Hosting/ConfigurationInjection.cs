using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Core.Hosting;

public static class ConfigurationInjection {
  public static void AddConfiguration(this IServiceCollection services) {

    ConfigurationManager manager = new();
    manager
      .SetBasePath(Path.Combine(Environment.GetEnvironmentVariable("SWIFTLY_MANAGED_ROOT")!, "configs"))
      .AddJsonFile("permissions.jsonc", optional: false, reloadOnChange: true);

    services.AddSingleton<IConfiguration>(manager);


  }
}
