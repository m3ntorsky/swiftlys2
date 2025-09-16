namespace SwiftlyS2.Core.Services;

internal class CoreContext {
  public string Name { get; init; }

  public string BaseDirectory { get; init; }

  public CoreContext(string name, string baseDirectory) {
    Name = name;
    BaseDirectory = baseDirectory;
  }
}