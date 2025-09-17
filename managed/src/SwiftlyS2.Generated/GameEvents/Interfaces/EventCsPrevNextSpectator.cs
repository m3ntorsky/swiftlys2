using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_prev_next_spectator"
/// </summary>
public interface EventCsPrevNextSpectator : ITypedGameEvent<EventCsPrevNextSpectator> {

  static EventCsPrevNextSpectator ITypedGameEvent<EventCsPrevNextSpectator>.Create() => new EventCsPrevNextSpectatorImpl();

  static string ITypedGameEvent<EventCsPrevNextSpectator>.GetName() => "cs_prev_next_spectator";

  static uint ITypedGameEvent<EventCsPrevNextSpectator>.GetHash() => 0x532CC8E5u;
  /// <summary>
  /// type: bool
  /// </summary>
  bool Next { get; set; }

}
