using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using Spectre.Console;

namespace SwiftlyS2.Core.Services;

internal class SwiftlyLoggerFormatter : ConsoleFormatter
{
  public SwiftlyLoggerFormatter() : base("swiftly")
  {
  }

  public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider? scopeProvider, TextWriter textWriter)
  {
    var timestamp = DateTime.Now.ToString("MM/dd HH:mm:ss");
    var logLevel = GetLogLevelString(logEntry.LogLevel);
    var category = logEntry.Category;

    var logLevelColor = logEntry.LogLevel switch
    {
      LogLevel.Trace => "grey42",
      LogLevel.Debug => "grey42",
      LogLevel.Information => "green",
      LogLevel.Warning => "yellow",
      LogLevel.Error => "red",
      LogLevel.Critical => "red",
      _ => "grey42"
    };

    AnsiConsole.MarkupLineInterpolated($"[aquamarine1]SwiftlyS2[/] | [grey42]{timestamp}[/] | [{logLevelColor}]{logLevel}[/] | [aquamarine1]{category}[/]");

    if (logEntry.State != null)
    {
      AnsiConsole.MarkupLineInterpolated($"\t[grey85]{logEntry.State}[/]\n");
    }

    if (logEntry.Exception != null)
    {
      AnsiConsole.WriteException(logEntry.Exception);
    }

  }

  private static string GetLogLevelString(LogLevel logLevel)
  {
    return logLevel switch
    {
      LogLevel.Trace =>           "Trace      ",
      LogLevel.Debug =>           "Debug      ",
      LogLevel.Information =>     "Information",
      LogLevel.Warning =>         "Warning    ",
      LogLevel.Error =>           "Error      ",
      LogLevel.Critical =>        "Critical   ",
      _ =>                        "Unknown    "
    };
  }
}