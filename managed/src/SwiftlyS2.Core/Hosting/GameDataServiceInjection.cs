using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class GameDataServiceInjection
{
  public static void AddGameDataService(this IServiceCollection self)
  {
    self.AddSingleton<GameDataService>();
  }
}