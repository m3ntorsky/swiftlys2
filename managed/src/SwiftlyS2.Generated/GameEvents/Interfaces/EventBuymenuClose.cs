using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buymenu_close"
/// </summary>
public interface EventBuymenuClose : IGameEvent<EventBuymenuClose> {

  static EventBuymenuClose IGameEvent<EventBuymenuClose>.FromAllocated(nint ptr) => new EventBuymenuCloseImpl(ptr, true);

  static EventBuymenuClose IGameEvent<EventBuymenuClose>.FromExternal(nint ptr) => new EventBuymenuCloseImpl(ptr, false);

  static string IGameEvent<EventBuymenuClose>.GetName() => "buymenu_close";

  static uint IGameEvent<EventBuymenuClose>.GetHash() => 0xFFC1EF17u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
