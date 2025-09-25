namespace SwiftlyS2.Core.Plugins;

internal record PluginManifest(
  string Id,
  string Name,
  string Version,
  string Author,
  string Description,
  string Website,
  string EntrypointDLL,
  List<string> DatabaseConnections
);