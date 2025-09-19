using SwiftlyS2.Shared.Commands;

namespace SwiftlyS2.Core.Commands;

internal class CommandContext : ICommandContext {

  public bool IsSentByPlayer { get; }

  public int? SenderId { get; }

  public string Prefix { get; }

  public bool IsSlient { get; }

  public string[] Args { get; }

  public void Reply(string message) {
    // TODO: implement this
   }

  public CommandContext(int playerId, string[] args, string commandName, string prefix, bool slient)
  {
    IsSentByPlayer = playerId != -1;
    SenderId = playerId;
    Prefix = prefix;
    IsSlient = slient;
    Args = args;
  }
}