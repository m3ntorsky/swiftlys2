using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_spawn"
/// player spawned in game
/// </summary>
public interface EventPlayerSpawn : IGameEvent<EventPlayerSpawn> {

  static EventPlayerSpawn IGameEvent<EventPlayerSpawn>.FromAllocated(nint ptr) => new EventPlayerSpawnImpl(ptr, true);

  static EventPlayerSpawn IGameEvent<EventPlayerSpawn>.FromExternal(nint ptr) => new EventPlayerSpawnImpl(ptr, false);

  static string IGameEvent<EventPlayerSpawn>.GetName() => "player_spawn";

  static uint IGameEvent<EventPlayerSpawn>.GetHash() => 0x5BC11C80u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
