namespace SwiftlyS2.Shared.Commands;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class Command : Attribute {
  public string Name { get; set; }

  public bool RegisterRaw { get; set; } = false;

  public Command(string name, bool registerRaw = false) {
    Name = name;
    RegisterRaw = registerRaw;
  }
}