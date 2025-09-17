using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "update_matchmaking_stats"
/// </summary>
public interface EventUpdateMatchmakingStats : ITypedGameEvent<EventUpdateMatchmakingStats> {

  static EventUpdateMatchmakingStats ITypedGameEvent<EventUpdateMatchmakingStats>.Create() => new EventUpdateMatchmakingStatsImpl();

  static string ITypedGameEvent<EventUpdateMatchmakingStats>.GetName() => "update_matchmaking_stats";

  static uint ITypedGameEvent<EventUpdateMatchmakingStats>.GetHash() => 0xFB94AEE7u;
}
