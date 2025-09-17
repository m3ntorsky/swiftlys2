using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hegrenade_detonate"
/// </summary>
public interface EventHegrenadeDetonate : ITypedGameEvent<EventHegrenadeDetonate> {

  static EventHegrenadeDetonate ITypedGameEvent<EventHegrenadeDetonate>.Create() => new EventHegrenadeDetonateImpl();

  static string ITypedGameEvent<EventHegrenadeDetonate>.GetName() => "hegrenade_detonate";

  static uint ITypedGameEvent<EventHegrenadeDetonate>.GetHash() => 0x96A1A98Du;
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
