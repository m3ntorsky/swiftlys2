using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class EngineServiceInjection
{
    public static IServiceCollection AddEngineService(this IServiceCollection self)
    {
        self.AddSingleton<EngineService>();
        return self;
    }
}