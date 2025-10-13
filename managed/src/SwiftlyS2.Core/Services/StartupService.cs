using Microsoft.Extensions.Hosting;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Misc;
using SwiftlyS2.Core.Modules.Engine;

namespace SwiftlyS2.Core.Services;

internal class StartupService : IHostedService
{

  private IServiceProvider _provider;
  private CommandTracked _commandTracked;

  public StartupService(IServiceProvider provider, CommandTracked commandTracked)
  {
    _provider = provider;
    _commandTracked = commandTracked;
    provider.UseCoreCommandService();
    provider.UseCoreHookService();
    provider.UsePermissionManager();
    provider.UsePluginManager();
    provider.UseMenuService();
    // provider.UseTestService();
  }

  public Task StartAsync(CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }

  public Task StopAsync(CancellationToken cancellationToken)
  {
    FileLogger.Dispose();
    return Task.CompletedTask;
  }
}