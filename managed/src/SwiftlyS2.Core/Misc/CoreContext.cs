using SwiftlyS2.Core.Plugins;

namespace SwiftlyS2.Core.Services;

internal class CoreContext {
  public string Name { get; init; }

  public string BaseDirectory { get; init; }

  public PluginManifest? PluginManifest { get; init; }

  public CoreContext(string name, string baseDirectory, PluginManifest? pluginManifest) {
    Name = name;
    BaseDirectory = baseDirectory;
    PluginManifest = pluginManifest;
  }
}