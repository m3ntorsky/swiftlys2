using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_given_c4"
/// </summary>
public interface EventPlayerGivenC4 : ITypedGameEvent<EventPlayerGivenC4> {

  static EventPlayerGivenC4 ITypedGameEvent<EventPlayerGivenC4>.Create() => new EventPlayerGivenC4Impl();

  static string ITypedGameEvent<EventPlayerGivenC4>.GetName() => "player_given_c4";

  static uint ITypedGameEvent<EventPlayerGivenC4>.GetHash() => 0x0491CF9Cu;
  /// <summary>
  /// user ID who received the c4
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
