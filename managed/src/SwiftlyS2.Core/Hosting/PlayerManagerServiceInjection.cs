using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class PlayerManagerServiceInjection
{
    public static void AddPlayerManagerService(this IServiceCollection self)
    {
        self.AddSingleton<PlayerManagerService>();
    }
}