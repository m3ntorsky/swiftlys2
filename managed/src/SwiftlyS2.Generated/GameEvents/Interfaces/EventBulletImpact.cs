using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bullet_impact"
/// </summary>
public interface EventBulletImpact : IGameEvent<EventBulletImpact> {

  static EventBulletImpact IGameEvent<EventBulletImpact>.FromAllocated(nint ptr) => new EventBulletImpactImpl(ptr, true);

  static EventBulletImpact IGameEvent<EventBulletImpact>.FromExternal(nint ptr) => new EventBulletImpactImpl(ptr, false);

  static string IGameEvent<EventBulletImpact>.GetName() => "bullet_impact";

  static uint IGameEvent<EventBulletImpact>.GetHash() => 0x8B8FCCE8u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

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
