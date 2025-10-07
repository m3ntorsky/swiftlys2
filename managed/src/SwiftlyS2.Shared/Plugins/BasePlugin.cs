using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SwiftlyS2.Shared.Plugins;

public abstract class BasePlugin : IPlugin {

  protected ISwiftlyCore Core { get; private init; }

  public BasePlugin(ISwiftlyCore core) {

    Core = core;

    AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
    {
      Core.Logger.LogCritical(e.ExceptionObject as Exception, "CRITICAL: Unhandled exception in plugin. Aborting.");
    };

    TaskScheduler.UnobservedTaskException += (sender, e) =>
    {
      Core.Logger.LogCritical(e.Exception, "CRITICAL: Unobserved task exception in plugin. Aborting.");
      e.SetObserved();
    };
  }

  public virtual void ConfigureSharedInterface(IInterfaceManager interfaceManager) {}

  public virtual void UseSharedInterface(IInterfaceManager interfaceManager) {}

  public abstract void Load(bool hotReload);

  public abstract void Unload();
}