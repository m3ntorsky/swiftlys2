using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_bombzone"
/// </summary>
public interface EventEnterBombzone : IGameEvent<EventEnterBombzone> {

  static EventEnterBombzone IGameEvent<EventEnterBombzone>.FromAllocated(nint ptr) => new EventEnterBombzoneImpl(ptr, true);

  static EventEnterBombzone IGameEvent<EventEnterBombzone>.FromExternal(nint ptr) => new EventEnterBombzoneImpl(ptr, false);

  static string IGameEvent<EventEnterBombzone>.GetName() => "enter_bombzone";

  static uint IGameEvent<EventEnterBombzone>.GetHash() => 0x9175DF94u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool HasBomb { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool IsPlanted { get; set; }

}
