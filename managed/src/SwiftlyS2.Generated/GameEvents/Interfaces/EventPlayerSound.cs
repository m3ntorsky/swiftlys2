using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_sound"
/// </summary>
public interface EventPlayerSound : IGameEvent<EventPlayerSound> {

  static EventPlayerSound IGameEvent<EventPlayerSound>.FromAllocated(nint ptr) => new EventPlayerSoundImpl(ptr, true);

  static EventPlayerSound IGameEvent<EventPlayerSound>.FromExternal(nint ptr) => new EventPlayerSoundImpl(ptr, false);

  static string IGameEvent<EventPlayerSound>.GetName() => "player_sound";

  static uint IGameEvent<EventPlayerSound>.GetHash() => 0xE562BC6Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: int
  /// </summary>
  int Radius { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Duration { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Step { get; set; }

}
