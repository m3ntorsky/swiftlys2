using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_abortdefuse"
/// </summary>
public interface EventBombAbortdefuse : ITypedGameEvent<EventBombAbortdefuse> {

  static EventBombAbortdefuse ITypedGameEvent<EventBombAbortdefuse>.Create() => new EventBombAbortdefuseImpl();

  static string ITypedGameEvent<EventBombAbortdefuse>.GetName() => "bomb_abortdefuse";

  static uint ITypedGameEvent<EventBombAbortdefuse>.GetHash() => 0x73B79332u;
  /// <summary>
  /// player who was defusing
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
