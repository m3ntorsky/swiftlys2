using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_hintmessage"
/// </summary>
public interface EventPlayerHintmessage : ITypedGameEvent<EventPlayerHintmessage> {

  static EventPlayerHintmessage ITypedGameEvent<EventPlayerHintmessage>.Wrap(IGameEvent accessor) => new EventPlayerHintmessageImpl(accessor);

  static string ITypedGameEvent<EventPlayerHintmessage>.GetName() => "player_hintmessage";

  static uint ITypedGameEvent<EventPlayerHintmessage>.GetHash() => 0xD756F227u;
  /// <summary>
  /// localizable string of a hint
  /// <br/>
  /// type: string
  /// </summary>
  string HintMessage { get; set; }

}
