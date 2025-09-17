using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_remove"
/// </summary>
public interface EventItemRemove : ITypedGameEvent<EventItemRemove> {

  static EventItemRemove ITypedGameEvent<EventItemRemove>.Create() => new EventItemRemoveImpl();

  static string ITypedGameEvent<EventItemRemove>.GetName() => "item_remove";

  static uint ITypedGameEvent<EventItemRemove>.GetHash() => 0x4853B5C7u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  /// <br/>
  /// type: string
  /// </summary>
  string Item { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int DefIndex { get; set; }

}
