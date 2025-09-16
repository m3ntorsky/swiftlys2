using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_begindefuse"
/// </summary>
public interface EventBombBegindefuse : IGameEvent<EventBombBegindefuse> {

  static EventBombBegindefuse IGameEvent<EventBombBegindefuse>.FromAllocated(nint ptr) => new EventBombBegindefuseImpl(ptr, true);

  static EventBombBegindefuse IGameEvent<EventBombBegindefuse>.FromExternal(nint ptr) => new EventBombBegindefuseImpl(ptr, false);

  static string IGameEvent<EventBombBegindefuse>.GetName() => "bomb_begindefuse";

  static uint IGameEvent<EventBombBegindefuse>.GetHash() => 0xC3C7D299u;
  /// <summary>
  /// player who is defusing
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool HasKit { get; set; }

}
