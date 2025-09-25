using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Commands;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Commands;

internal class CommandContext : ICommandContext {

  public bool IsSentByPlayer { get; }

  public IPlayer? Sender { get; }

  public string Prefix { get; }

  public bool IsSlient { get; }

  public string[] Args { get; }

  public void Reply(string message) {
    if (IsSentByPlayer) {
      Sender?.SendMessage(MessageType.Chat, message);
    } else {
      Console.WriteLine(message);
    }
   }

  public CommandContext(int playerId, string[] args, string commandName, string prefix, bool slient)
  {
    IsSentByPlayer = playerId != -1;
    Sender = playerId != -1 ? new Player(playerId) : null;
    Prefix = prefix;
    IsSlient = slient;
    Args = args;
  }
}