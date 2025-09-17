using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "entity_visible"
/// </summary>
public interface EventEntityVisible : ITypedGameEvent<EventEntityVisible> {

  static EventEntityVisible ITypedGameEvent<EventEntityVisible>.Create() => new EventEntityVisibleImpl();

  static string ITypedGameEvent<EventEntityVisible>.GetName() => "entity_visible";

  static uint ITypedGameEvent<EventEntityVisible>.GetHash() => 0xC4D03823u;
  /// <summary>
  /// The player who sees the entity
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// Entindex of the entity they see
  /// <br/>
  /// type: long
  /// </summary>
  int Subject { get; set; }

  /// <summary>
  /// Classname of the entity they see
  /// <br/>
  /// type: string
  /// </summary>
  string ClassName { get; set; }

  /// <summary>
  /// name of the entity they see
  /// <br/>
  /// type: string
  /// </summary>
  string EntityName { get; set; }

}
