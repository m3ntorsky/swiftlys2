using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class TraceManagerServiceInjection
{
    public static void AddTraceManagerService(this IServiceCollection self)
    {
        self.AddSingleton<TraceManager>();
    }
}