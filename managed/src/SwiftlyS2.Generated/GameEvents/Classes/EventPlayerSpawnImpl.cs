using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_spawn"
/// player spawned in game
/// </summary>
internal class EventPlayerSpawnImpl : TypedGameEvent<EventPlayerSpawn>, EventPlayerSpawn
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
