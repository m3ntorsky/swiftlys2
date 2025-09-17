using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "decoy_firing"
/// </summary>
public interface EventDecoyFiring : ITypedGameEvent<EventDecoyFiring> {

  static EventDecoyFiring ITypedGameEvent<EventDecoyFiring>.Create() => new EventDecoyFiringImpl();

  static string ITypedGameEvent<EventDecoyFiring>.GetName() => "decoy_firing";

  static uint ITypedGameEvent<EventDecoyFiring>.GetHash() => 0xA0DD941Fu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float X { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Y { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Z { get; set; }

}
