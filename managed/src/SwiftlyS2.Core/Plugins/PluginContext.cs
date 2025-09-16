using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;

namespace SwiftlyS2.Core.Services;

internal class PluginContext : IDisposable {

  public required SwiftlyCore Core { get; init; }

  public required string PluginPath { get; init; }
  public required BasePlugin Plugin { get; init; }

  public required PluginLoader Loader { get; init; }

  private FileSystemWatcher? _Watcher { get; set; }

  public void SetupWatcher(Action callback) {
    _Watcher = new FileSystemWatcher(Path.GetDirectoryName(PluginPath)!);

    _Watcher.Filters.Add("*.dll");

    _Watcher.Changed += (sender, e) => {
      callback();
    };

    _Watcher.EnableRaisingEvents = true;
  }

  public void Dispose() {
    Plugin.Unload();
    Loader.Dispose();
    Core.Dispose();
    _Watcher?.Dispose();
  }

}