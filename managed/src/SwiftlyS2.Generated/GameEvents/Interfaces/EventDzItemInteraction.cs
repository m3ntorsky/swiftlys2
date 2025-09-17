using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dz_item_interaction"
/// </summary>
public interface EventDzItemInteraction : ITypedGameEvent<EventDzItemInteraction> {

  static EventDzItemInteraction ITypedGameEvent<EventDzItemInteraction>.Create() => new EventDzItemInteractionImpl();

  static string ITypedGameEvent<EventDzItemInteraction>.GetName() => "dz_item_interaction";

  static uint ITypedGameEvent<EventDzItemInteraction>.GetHash() => 0x4C0C7044u;
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
