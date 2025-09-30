namespace SwiftlyS2.Core.Models;

public class PermissionConfig {
  public Dictionary<string, List<string>> Players { get; set; } = new();
  public Dictionary<string, List<string>> PermissionGroups { get; set; } = new();
}