using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "smokegrenade_expired"
/// </summary>
public interface EventSmokegrenadeExpired : IGameEvent<EventSmokegrenadeExpired> {

  static EventSmokegrenadeExpired IGameEvent<EventSmokegrenadeExpired>.FromAllocated(nint ptr) => new EventSmokegrenadeExpiredImpl(ptr, true);

  static EventSmokegrenadeExpired IGameEvent<EventSmokegrenadeExpired>.FromExternal(nint ptr) => new EventSmokegrenadeExpiredImpl(ptr, false);

  static string IGameEvent<EventSmokegrenadeExpired>.GetName() => "smokegrenade_expired";

  static uint IGameEvent<EventSmokegrenadeExpired>.GetHash() => 0x45406DF6u;
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
