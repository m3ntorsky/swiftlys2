using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "decoy_detonate"
/// </summary>
public interface EventDecoyDetonate : ITypedGameEvent<EventDecoyDetonate> {

  static EventDecoyDetonate ITypedGameEvent<EventDecoyDetonate>.Wrap(IGameEvent accessor) => new EventDecoyDetonateImpl(accessor);

  static string ITypedGameEvent<EventDecoyDetonate>.GetName() => "decoy_detonate";

  static uint ITypedGameEvent<EventDecoyDetonate>.GetHash() => 0xDA5B1520u;
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
