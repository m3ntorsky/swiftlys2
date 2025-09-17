using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_footstep"
/// </summary>
public interface EventPlayerFootstep : ITypedGameEvent<EventPlayerFootstep> {

  static EventPlayerFootstep ITypedGameEvent<EventPlayerFootstep>.Wrap(IGameEvent accessor) => new EventPlayerFootstepImpl(accessor);

  static string ITypedGameEvent<EventPlayerFootstep>.GetName() => "player_footstep";

  static uint ITypedGameEvent<EventPlayerFootstep>.GetHash() => 0x5EA9530Bu;
  /// <summary>
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
