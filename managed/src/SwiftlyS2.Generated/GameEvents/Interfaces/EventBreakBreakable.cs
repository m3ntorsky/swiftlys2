using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "break_breakable"
/// </summary>
public interface EventBreakBreakable : ITypedGameEvent<EventBreakBreakable> {

  static EventBreakBreakable ITypedGameEvent<EventBreakBreakable>.Wrap(IGameEvent accessor) => new EventBreakBreakableImpl(accessor);

  static string ITypedGameEvent<EventBreakBreakable>.GetName() => "break_breakable";

  static uint ITypedGameEvent<EventBreakBreakable>.GetHash() => 0x7CBB3150u;
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
  /// BREAK_GLASS, BREAK_WOOD, etc
  /// <br/>
  /// type: byte
  /// </summary>
  byte Material { get; set; }

}
