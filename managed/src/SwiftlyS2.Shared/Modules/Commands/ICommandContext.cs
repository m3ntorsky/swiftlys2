using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.Commands;

public interface ICommandContext {

  public bool IsSentByPlayer { get; }

  public int? SenderId { get; }

  public string Prefix { get; }

  public bool IsSlient { get; }

  public string[] Args { get; }

  public void Reply(string message);
  
}