using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hegrenade_detonate"
/// </summary>
public interface EventHegrenadeDetonate : IGameEvent<EventHegrenadeDetonate> {

  static EventHegrenadeDetonate IGameEvent<EventHegrenadeDetonate>.FromAllocated(nint ptr) => new EventHegrenadeDetonateImpl(ptr, true);

  static EventHegrenadeDetonate IGameEvent<EventHegrenadeDetonate>.FromExternal(nint ptr) => new EventHegrenadeDetonateImpl(ptr, false);

  static string IGameEvent<EventHegrenadeDetonate>.GetName() => "hegrenade_detonate";

  static uint IGameEvent<EventHegrenadeDetonate>.GetHash() => 0x96A1A98Du;
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
