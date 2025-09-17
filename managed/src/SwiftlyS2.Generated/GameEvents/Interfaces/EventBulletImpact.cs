using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bullet_impact"
/// </summary>
public interface EventBulletImpact : ITypedGameEvent<EventBulletImpact> {

  static EventBulletImpact ITypedGameEvent<EventBulletImpact>.Create() => new EventBulletImpactImpl();

  static string ITypedGameEvent<EventBulletImpact>.GetName() => "bullet_impact";

  static uint ITypedGameEvent<EventBulletImpact>.GetHash() => 0x8B8FCCE8u;
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
