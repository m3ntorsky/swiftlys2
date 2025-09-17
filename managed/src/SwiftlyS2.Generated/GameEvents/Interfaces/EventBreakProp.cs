using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "break_prop"
/// </summary>
public interface EventBreakProp : ITypedGameEvent<EventBreakProp> {

  static EventBreakProp ITypedGameEvent<EventBreakProp>.Wrap(IGameEvent accessor) => new EventBreakPropImpl(accessor);

  static string ITypedGameEvent<EventBreakProp>.GetName() => "break_prop";

  static uint ITypedGameEvent<EventBreakProp>.GetHash() => 0x20D10398u;
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
