using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bullet_flight_resolution"
/// </summary>
public interface EventBulletFlightResolution : ITypedGameEvent<EventBulletFlightResolution> {

  static EventBulletFlightResolution ITypedGameEvent<EventBulletFlightResolution>.Create() => new EventBulletFlightResolutionImpl();

  static string ITypedGameEvent<EventBulletFlightResolution>.GetName() => "bullet_flight_resolution";

  static uint ITypedGameEvent<EventBulletFlightResolution>.GetHash() => 0xB39BC4E7u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short PosX { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short PosY { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short PosZ { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngX { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngY { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngZ { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartX { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartY { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartZ { get; set; }

}
