namespace SwiftlyS2.Core.Plugins;

internal class PluginId {
  public string Name { get; init; }

  public string BaseDirectory { get; init; }

  public PluginId(string name, string baseDirectory) {
    Name = name;
    BaseDirectory = baseDirectory;
  }
}