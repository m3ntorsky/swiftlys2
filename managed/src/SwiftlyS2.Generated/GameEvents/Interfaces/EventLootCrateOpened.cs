using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "loot_crate_opened"
/// </summary>
public interface EventLootCrateOpened : ITypedGameEvent<EventLootCrateOpened> {

  static EventLootCrateOpened ITypedGameEvent<EventLootCrateOpened>.Create() => new EventLootCrateOpenedImpl();

  static string ITypedGameEvent<EventLootCrateOpened>.GetName() => "loot_crate_opened";

  static uint ITypedGameEvent<EventLootCrateOpened>.GetHash() => 0x18E203D5u;
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
