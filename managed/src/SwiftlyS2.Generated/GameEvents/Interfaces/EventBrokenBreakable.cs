using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "broken_breakable"
/// </summary>
public interface EventBrokenBreakable : ITypedGameEvent<EventBrokenBreakable> {

  static EventBrokenBreakable ITypedGameEvent<EventBrokenBreakable>.Create() => new EventBrokenBreakableImpl();

  static string ITypedGameEvent<EventBrokenBreakable>.GetName() => "broken_breakable";

  static uint ITypedGameEvent<EventBrokenBreakable>.GetHash() => 0x3EBE8AE8u;
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
