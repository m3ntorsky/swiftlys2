namespace SwiftlyS2.Core.Plugins;

public record PluginManifest(
  string Id,
  string Name,
  string Version,
  string Author,
  string Description,
  string Website,
  string EntrypointDLL
);