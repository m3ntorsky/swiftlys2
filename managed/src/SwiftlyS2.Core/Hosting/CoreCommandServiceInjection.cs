using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class CoreCommandServiceInjection {
  public static void AddCoreCommandService(this IServiceCollection services) {
    services.AddSingleton<CoreCommandService>();
  }

  public static void UseCoreCommandService(this IServiceProvider provider) {
    provider.GetRequiredService<CoreCommandService>();
  }
}