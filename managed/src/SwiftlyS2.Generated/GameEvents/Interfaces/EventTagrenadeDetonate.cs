using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "tagrenade_detonate"
/// </summary>
public interface EventTagrenadeDetonate : ITypedGameEvent<EventTagrenadeDetonate> {

  static EventTagrenadeDetonate ITypedGameEvent<EventTagrenadeDetonate>.Create() => new EventTagrenadeDetonateImpl();

  static string ITypedGameEvent<EventTagrenadeDetonate>.GetName() => "tagrenade_detonate";

  static uint ITypedGameEvent<EventTagrenadeDetonate>.GetHash() => 0x727702BDu;
  /// <summary>
  /// <br/>
  /// type: player_controller
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
