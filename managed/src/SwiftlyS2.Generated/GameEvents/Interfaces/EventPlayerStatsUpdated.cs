using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_stats_updated"
/// </summary>
public interface EventPlayerStatsUpdated : ITypedGameEvent<EventPlayerStatsUpdated> {

  static EventPlayerStatsUpdated ITypedGameEvent<EventPlayerStatsUpdated>.Create() => new EventPlayerStatsUpdatedImpl();

  static string ITypedGameEvent<EventPlayerStatsUpdated>.GetName() => "player_stats_updated";

  static uint ITypedGameEvent<EventPlayerStatsUpdated>.GetHash() => 0x9F0E110Cu;
  /// <summary>
  /// type: bool
  /// </summary>
  bool ForceUpload { get; set; }

}
