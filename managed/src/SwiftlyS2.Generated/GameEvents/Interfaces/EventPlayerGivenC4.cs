using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_given_c4"
/// </summary>
public interface EventPlayerGivenC4 : IGameEvent<EventPlayerGivenC4> {

  static EventPlayerGivenC4 IGameEvent<EventPlayerGivenC4>.FromAllocated(nint ptr) => new EventPlayerGivenC4Impl(ptr, true);

  static EventPlayerGivenC4 IGameEvent<EventPlayerGivenC4>.FromExternal(nint ptr) => new EventPlayerGivenC4Impl(ptr, false);

  static string IGameEvent<EventPlayerGivenC4>.GetName() => "player_given_c4";

  static uint IGameEvent<EventPlayerGivenC4>.GetHash() => 0x0491CF9Cu;
  /// <summary>
  /// user ID who received the c4
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
