using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class RootDirServiceInjection
{
  public static void AddRootDirService(this IServiceCollection self)
  {
    self.AddSingleton<RootDirService>();
  }
}