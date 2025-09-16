using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_rank_entity"
/// an entity ranking
/// </summary>
public interface EventHltvRankEntity : IGameEvent<EventHltvRankEntity> {

  static EventHltvRankEntity IGameEvent<EventHltvRankEntity>.FromAllocated(nint ptr) => new EventHltvRankEntityImpl(ptr, true);

  static EventHltvRankEntity IGameEvent<EventHltvRankEntity>.FromExternal(nint ptr) => new EventHltvRankEntityImpl(ptr, false);

  static string IGameEvent<EventHltvRankEntity>.GetName() => "hltv_rank_entity";

  static uint IGameEvent<EventHltvRankEntity>.GetHash() => 0xC49644C0u;
  /// <summary>
  /// player slot
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// ranking, how interesting is this entity to view
  /// <br/>
  /// type: float
  /// </summary>
  float Rank { get; set; }

  /// <summary>
  /// best/closest target entity
  /// <br/>
  /// type: player_controller
  /// </summary>
  int Target { get; set; }

}
