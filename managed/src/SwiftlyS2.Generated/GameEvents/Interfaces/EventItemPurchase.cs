using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_purchase"
/// </summary>
public interface EventItemPurchase : IGameEvent<EventItemPurchase> {

  static EventItemPurchase IGameEvent<EventItemPurchase>.FromAllocated(nint ptr) => new EventItemPurchaseImpl(ptr, true);

  static EventItemPurchase IGameEvent<EventItemPurchase>.FromExternal(nint ptr) => new EventItemPurchaseImpl(ptr, false);

  static string IGameEvent<EventItemPurchase>.GetName() => "item_purchase";

  static uint IGameEvent<EventItemPurchase>.GetHash() => 0x4400FB1Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Team { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short LoadOut { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

}
