using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_spawn"
/// player spawned in game
/// </summary>
public interface EventPlayerSpawn : ITypedGameEvent<EventPlayerSpawn> {

  static EventPlayerSpawn ITypedGameEvent<EventPlayerSpawn>.Wrap(IGameEvent accessor) => new EventPlayerSpawnImpl(accessor);

  static string ITypedGameEvent<EventPlayerSpawn>.GetName() => "player_spawn";

  static uint ITypedGameEvent<EventPlayerSpawn>.GetHash() => 0x5BC11C80u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
