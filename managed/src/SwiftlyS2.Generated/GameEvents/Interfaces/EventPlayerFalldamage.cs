using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_falldamage"
/// </summary>
public interface EventPlayerFalldamage : IGameEvent<EventPlayerFalldamage> {

  static EventPlayerFalldamage IGameEvent<EventPlayerFalldamage>.FromAllocated(nint ptr) => new EventPlayerFalldamageImpl(ptr, true);

  static EventPlayerFalldamage IGameEvent<EventPlayerFalldamage>.FromExternal(nint ptr) => new EventPlayerFalldamageImpl(ptr, false);

  static string IGameEvent<EventPlayerFalldamage>.GetName() => "player_falldamage";

  static uint IGameEvent<EventPlayerFalldamage>.GetHash() => 0x594A7109u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: float
  /// </summary>
  float Damage { get; set; }

}
