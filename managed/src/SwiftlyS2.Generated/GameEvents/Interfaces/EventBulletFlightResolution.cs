using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bullet_flight_resolution"
/// </summary>
public interface EventBulletFlightResolution : IGameEvent<EventBulletFlightResolution> {

  static EventBulletFlightResolution IGameEvent<EventBulletFlightResolution>.FromAllocated(nint ptr) => new EventBulletFlightResolutionImpl(ptr, true);

  static EventBulletFlightResolution IGameEvent<EventBulletFlightResolution>.FromExternal(nint ptr) => new EventBulletFlightResolutionImpl(ptr, false);

  static string IGameEvent<EventBulletFlightResolution>.GetName() => "bullet_flight_resolution";

  static uint IGameEvent<EventBulletFlightResolution>.GetHash() => 0xB39BC4E7u;
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
