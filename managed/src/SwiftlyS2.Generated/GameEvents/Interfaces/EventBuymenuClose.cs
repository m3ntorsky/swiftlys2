using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buymenu_close"
/// </summary>
public interface EventBuymenuClose : ITypedGameEvent<EventBuymenuClose> {

  static EventBuymenuClose ITypedGameEvent<EventBuymenuClose>.Create() => new EventBuymenuCloseImpl();

  static string ITypedGameEvent<EventBuymenuClose>.GetName() => "buymenu_close";

  static uint ITypedGameEvent<EventBuymenuClose>.GetHash() => 0xFFC1EF17u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
