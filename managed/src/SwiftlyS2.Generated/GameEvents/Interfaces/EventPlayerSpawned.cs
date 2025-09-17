using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_spawned"
/// </summary>
public interface EventPlayerSpawned : ITypedGameEvent<EventPlayerSpawned> {

  static EventPlayerSpawned ITypedGameEvent<EventPlayerSpawned>.Create() => new EventPlayerSpawnedImpl();

  static string ITypedGameEvent<EventPlayerSpawned>.GetName() => "player_spawned";

  static uint ITypedGameEvent<EventPlayerSpawned>.GetHash() => 0x7DC35E81u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// true if restart is pending
  /// <br/>
  /// type: bool
  /// </summary>
  bool InRestart { get; set; }

}
