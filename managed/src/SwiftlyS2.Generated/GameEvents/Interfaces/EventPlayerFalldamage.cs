using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_falldamage"
/// </summary>
public interface EventPlayerFalldamage : ITypedGameEvent<EventPlayerFalldamage> {

  static EventPlayerFalldamage ITypedGameEvent<EventPlayerFalldamage>.Wrap(IGameEvent accessor) => new EventPlayerFalldamageImpl(accessor);

  static string ITypedGameEvent<EventPlayerFalldamage>.GetName() => "player_falldamage";

  static uint ITypedGameEvent<EventPlayerFalldamage>.GetHash() => 0x594A7109u;
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
