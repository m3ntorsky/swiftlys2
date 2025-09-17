using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_bombzone"
/// </summary>
public interface EventEnterBombzone : ITypedGameEvent<EventEnterBombzone> {

  static EventEnterBombzone ITypedGameEvent<EventEnterBombzone>.Wrap(IGameEvent accessor) => new EventEnterBombzoneImpl(accessor);

  static string ITypedGameEvent<EventEnterBombzone>.GetName() => "enter_bombzone";

  static uint ITypedGameEvent<EventEnterBombzone>.GetHash() => 0x9175DF94u;
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
