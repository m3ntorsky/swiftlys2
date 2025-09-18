using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dz_item_interaction"
/// </summary>
public interface EventDzItemInteraction : IGameEvent<EventDzItemInteraction> {

  static EventDzItemInteraction IGameEvent<EventDzItemInteraction>.Create() => new EventDzItemInteractionImpl();

  static string IGameEvent<EventDzItemInteraction>.GetName() => "dz_item_interaction";

  static uint IGameEvent<EventDzItemInteraction>.GetHash() => 0x4C0C7044u;
  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

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
