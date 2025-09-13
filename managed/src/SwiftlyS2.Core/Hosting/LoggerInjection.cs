using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class LoggerInjection
{
  public static void AddLoggerFactory(this IServiceCollection self)
  {
    var factory = LoggerFactory.Create(builder => {
      builder
      .AddConsole(options => {
        options.FormatterName = "swiftly";
      })
      .AddConsoleFormatter<SwiftlyLoggerFormatter, ConsoleFormatterOptions>();
    });

    self.AddSingleton(factory);
  }
}