using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Managers;
using SwiftlyS2.Core.Plugins;
using SwiftlyS2.Shared.Plugins;

namespace SwiftlyS2.Core.Services;

internal class PluginContext : IDisposable {

  public SwiftlyCore? Core { get; set; }

  public required PluginManifest Manifest { get; set; }

  public string? PluginDirectory { get; set; }

  public PluginStatus? Status { get; set; }
  public BasePlugin? Plugin { get; set; }

  public PluginLoader? Loader { get; set; }

  public void Dispose() {
    Plugin?.Unload();
    Loader?.Dispose();
    Core?.Dispose();
  }

}