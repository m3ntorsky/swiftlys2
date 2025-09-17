using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "loot_crate_visible"
/// </summary>
public interface EventLootCrateVisible : ITypedGameEvent<EventLootCrateVisible> {

  static EventLootCrateVisible ITypedGameEvent<EventLootCrateVisible>.Wrap(IGameEvent accessor) => new EventLootCrateVisibleImpl(accessor);

  static string ITypedGameEvent<EventLootCrateVisible>.GetName() => "loot_crate_visible";

  static uint ITypedGameEvent<EventLootCrateVisible>.GetHash() => 0x1926ED06u;
  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// crate entindex
  /// <br/>
  /// type: short
  /// </summary>
  short Subject { get; set; }

  /// <summary>
  /// type of crate (metal, wood, or paradrop)
  /// <br/>
  /// type: string
  /// </summary>
  string Type { get; set; }

}
