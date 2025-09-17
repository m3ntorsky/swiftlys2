using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_bombzone"
/// </summary>
public interface EventExitBombzone : ITypedGameEvent<EventExitBombzone> {

  static EventExitBombzone ITypedGameEvent<EventExitBombzone>.Wrap(IGameEvent accessor) => new EventExitBombzoneImpl(accessor);

  static string ITypedGameEvent<EventExitBombzone>.GetName() => "exit_bombzone";

  static uint ITypedGameEvent<EventExitBombzone>.GetHash() => 0xF5ADEBDCu;
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
