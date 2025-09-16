using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "seasoncoin_levelup"
/// </summary>
public interface EventSeasoncoinLevelup : IGameEvent<EventSeasoncoinLevelup> {

  static EventSeasoncoinLevelup IGameEvent<EventSeasoncoinLevelup>.FromAllocated(nint ptr) => new EventSeasoncoinLevelupImpl(ptr, true);

  static EventSeasoncoinLevelup IGameEvent<EventSeasoncoinLevelup>.FromExternal(nint ptr) => new EventSeasoncoinLevelupImpl(ptr, false);

  static string IGameEvent<EventSeasoncoinLevelup>.GetName() => "seasoncoin_levelup";

  static uint IGameEvent<EventSeasoncoinLevelup>.GetHash() => 0xF0EAD821u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Category { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Rank { get; set; }

}
