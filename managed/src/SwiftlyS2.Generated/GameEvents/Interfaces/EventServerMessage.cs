using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "server_message"
/// a generic server message
/// </summary>
public interface EventServerMessage : ITypedGameEvent<EventServerMessage> {

  static EventServerMessage ITypedGameEvent<EventServerMessage>.Wrap(IGameEvent accessor) => new EventServerMessageImpl(accessor);

  static string ITypedGameEvent<EventServerMessage>.GetName() => "server_message";

  static uint ITypedGameEvent<EventServerMessage>.GetHash() => 0x29575F36u;
  /// <summary>
  /// the message text
  /// <br/>
  /// type: string
  /// </summary>
  string Text { get; set; }

}
