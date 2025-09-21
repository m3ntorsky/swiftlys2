using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SwiftlyS2.Shared.Plugins;

public abstract class BasePlugin : IPlugin {

  protected ISwiftlyCore Core { get; private init; }

  public BasePlugin(ISwiftlyCore core) {

    Core = core;

    AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
    {
      Core.Logger.LogCritical(e.ExceptionObject as Exception, "CRITICAL: Unhandled exception in plugin.");
    };

    AppDomain.CurrentDomain.FirstChanceException += (sender, e) =>
    {
      Core.Logger.LogCritical(e.Exception, "CRITICAL: First chance exception in plugin.");
    };

    TaskScheduler.UnobservedTaskException += (sender, e) =>
    {
      Core.Logger.LogCritical(e.Exception, "CRITICAL: Unobserved task exception in plugin.");
    };
  }

  public virtual void ConfigureSharedServices(IServiceCollection sharedServices) {}

  public virtual void UseSharedServices(IServiceProvider sharedProvider) {}

  public abstract void Load();

  public abstract void Unload();
}