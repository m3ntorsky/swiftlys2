using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "smokegrenade_detonate"
/// </summary>
public interface EventSmokegrenadeDetonate : ITypedGameEvent<EventSmokegrenadeDetonate> {

  static EventSmokegrenadeDetonate ITypedGameEvent<EventSmokegrenadeDetonate>.Create() => new EventSmokegrenadeDetonateImpl();

  static string ITypedGameEvent<EventSmokegrenadeDetonate>.GetName() => "smokegrenade_detonate";

  static uint ITypedGameEvent<EventSmokegrenadeDetonate>.GetHash() => 0xA786E81Du;
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
