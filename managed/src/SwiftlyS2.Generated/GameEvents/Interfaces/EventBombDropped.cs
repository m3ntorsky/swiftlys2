using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_dropped"
/// </summary>
public interface EventBombDropped : ITypedGameEvent<EventBombDropped> {

  static EventBombDropped ITypedGameEvent<EventBombDropped>.Create() => new EventBombDroppedImpl();

  static string ITypedGameEvent<EventBombDropped>.GetName() => "bomb_dropped";

  static uint ITypedGameEvent<EventBombDropped>.GetHash() => 0x399275B4u;
  /// <summary>
  /// player who dropped the bomb
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
