using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_bombzone"
/// </summary>
public interface EventExitBombzone : IGameEvent<EventExitBombzone> {

  static EventExitBombzone IGameEvent<EventExitBombzone>.Create() => new EventExitBombzoneImpl();

  static string IGameEvent<EventExitBombzone>.GetName() => "exit_bombzone";

  static uint IGameEvent<EventExitBombzone>.GetHash() => 0xF5ADEBDCu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool HasBomb { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool IsPlanted { get; set; }

}
