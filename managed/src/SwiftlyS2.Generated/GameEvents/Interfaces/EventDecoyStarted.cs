using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "decoy_started"
/// </summary>
public interface EventDecoyStarted : ITypedGameEvent<EventDecoyStarted> {

  static EventDecoyStarted ITypedGameEvent<EventDecoyStarted>.Wrap(IGameEvent accessor) => new EventDecoyStartedImpl(accessor);

  static string ITypedGameEvent<EventDecoyStarted>.GetName() => "decoy_started";

  static uint ITypedGameEvent<EventDecoyStarted>.GetHash() => 0xD1159B75u;
  /// <summary>
  /// <br/>
  /// type: player_pawn
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
