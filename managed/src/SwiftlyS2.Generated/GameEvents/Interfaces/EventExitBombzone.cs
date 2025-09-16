using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_bombzone"
/// </summary>
public interface EventExitBombzone : IGameEvent<EventExitBombzone> {

  static EventExitBombzone IGameEvent<EventExitBombzone>.FromAllocated(nint ptr) => new EventExitBombzoneImpl(ptr, true);

  static EventExitBombzone IGameEvent<EventExitBombzone>.FromExternal(nint ptr) => new EventExitBombzoneImpl(ptr, false);

  static string IGameEvent<EventExitBombzone>.GetName() => "exit_bombzone";

  static uint IGameEvent<EventExitBombzone>.GetHash() => 0xF5ADEBDCu;
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
