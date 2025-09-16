using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "tagrenade_detonate"
/// </summary>
public interface EventTagrenadeDetonate : IGameEvent<EventTagrenadeDetonate> {

  static EventTagrenadeDetonate IGameEvent<EventTagrenadeDetonate>.FromAllocated(nint ptr) => new EventTagrenadeDetonateImpl(ptr, true);

  static EventTagrenadeDetonate IGameEvent<EventTagrenadeDetonate>.FromExternal(nint ptr) => new EventTagrenadeDetonateImpl(ptr, false);

  static string IGameEvent<EventTagrenadeDetonate>.GetName() => "tagrenade_detonate";

  static uint IGameEvent<EventTagrenadeDetonate>.GetHash() => 0x727702BDu;
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
