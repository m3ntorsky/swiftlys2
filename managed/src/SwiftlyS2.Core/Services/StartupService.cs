using Microsoft.Extensions.Hosting;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Misc;

namespace SwiftlyS2.Core.Services;

internal class StartupService : IHostedService {

  private IServiceProvider _provider;

  public StartupService(IServiceProvider provider) {
    _provider = provider;
    provider.UseCoreCommandService();
    provider.UsePermissionManager();
    provider.UsePluginManager();
  }

  public Task StartAsync(CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }

  public Task StopAsync(CancellationToken cancellationToken) {
    FileLogger.Dispose();
    return Task.CompletedTask;
  }
}