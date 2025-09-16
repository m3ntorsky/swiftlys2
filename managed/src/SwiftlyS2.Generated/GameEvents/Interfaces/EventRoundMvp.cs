using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_mvp"
/// </summary>
public interface EventRoundMvp : IGameEvent<EventRoundMvp> {

  static EventRoundMvp IGameEvent<EventRoundMvp>.FromAllocated(nint ptr) => new EventRoundMvpImpl(ptr, true);

  static EventRoundMvp IGameEvent<EventRoundMvp>.FromExternal(nint ptr) => new EventRoundMvpImpl(ptr, false);

  static string IGameEvent<EventRoundMvp>.GetName() => "round_mvp";

  static uint IGameEvent<EventRoundMvp>.GetHash() => 0xC80E399Du;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Reason { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int Value { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int MusickItMvps { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte NoMusic { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int MusickItID { get; set; }

}
