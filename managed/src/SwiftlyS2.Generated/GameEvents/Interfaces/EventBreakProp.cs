using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "break_prop"
/// </summary>
public interface EventBreakProp : IGameEvent<EventBreakProp> {

  static EventBreakProp IGameEvent<EventBreakProp>.FromAllocated(nint ptr) => new EventBreakPropImpl(ptr, true);

  static EventBreakProp IGameEvent<EventBreakProp>.FromExternal(nint ptr) => new EventBreakPropImpl(ptr, false);

  static string IGameEvent<EventBreakProp>.GetName() => "break_prop";

  static uint IGameEvent<EventBreakProp>.GetHash() => 0x20D10398u;
  /// <summary>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

  /// <summary>
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool PlayerHeld { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool PlayerThrown { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool PlayerDropped { get; set; }

}
