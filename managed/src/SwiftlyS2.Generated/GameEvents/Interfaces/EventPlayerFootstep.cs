using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_footstep"
/// </summary>
public interface EventPlayerFootstep : IGameEvent<EventPlayerFootstep> {

  static EventPlayerFootstep IGameEvent<EventPlayerFootstep>.FromAllocated(nint ptr) => new EventPlayerFootstepImpl(ptr, true);

  static EventPlayerFootstep IGameEvent<EventPlayerFootstep>.FromExternal(nint ptr) => new EventPlayerFootstepImpl(ptr, false);

  static string IGameEvent<EventPlayerFootstep>.GetName() => "player_footstep";

  static uint IGameEvent<EventPlayerFootstep>.GetHash() => 0x5EA9530Bu;
  /// <summary>
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
