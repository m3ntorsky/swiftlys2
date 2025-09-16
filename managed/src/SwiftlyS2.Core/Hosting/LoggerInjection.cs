using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Misc;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class LoggerInjection
{
  public static void AddLogger(this IServiceCollection self)
  {
    self.AddLogging(builder => {
      builder.AddProvider(new SwiftlyLoggerProvider("SwiftlyS2"));
    });
  }
}