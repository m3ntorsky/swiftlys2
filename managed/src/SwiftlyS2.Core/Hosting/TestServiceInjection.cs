using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class TestServiceInjection
{
  public static void AddTestService(this IServiceCollection self)
  {
    self.AddSingleton<TestService>();
  }

  public static void UseTestService(this IServiceProvider self)
  {
    self.GetRequiredService<TestService>();
  }
}