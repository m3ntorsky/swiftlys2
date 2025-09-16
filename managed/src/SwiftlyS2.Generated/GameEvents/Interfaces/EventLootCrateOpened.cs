using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "loot_crate_opened"
/// </summary>
public interface EventLootCrateOpened : IGameEvent<EventLootCrateOpened> {

  static EventLootCrateOpened IGameEvent<EventLootCrateOpened>.FromAllocated(nint ptr) => new EventLootCrateOpenedImpl(ptr, true);

  static EventLootCrateOpened IGameEvent<EventLootCrateOpened>.FromExternal(nint ptr) => new EventLootCrateOpenedImpl(ptr, false);

  static string IGameEvent<EventLootCrateOpened>.GetName() => "loot_crate_opened";

  static uint IGameEvent<EventLootCrateOpened>.GetHash() => 0x18E203D5u;
  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type of crate (metal, wood, or paradrop)
  /// <br/>
  /// type: string
  /// </summary>
  string Type { get; set; }

}
