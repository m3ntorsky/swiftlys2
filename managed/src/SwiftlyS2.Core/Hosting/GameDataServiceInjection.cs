using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class GameDataServiceInjection {

  public static void AddGameDataService(this IServiceCollection services) {
    services.AddSingleton<GameDataService>();
  }

}