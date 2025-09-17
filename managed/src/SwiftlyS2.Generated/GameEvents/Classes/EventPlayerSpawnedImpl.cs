using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_spawned"
/// </summary>
internal class EventPlayerSpawnedImpl : TypedGameEvent<EventPlayerSpawned>, EventPlayerSpawned
{

  public EventPlayerSpawnedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // true if restart is pending
  public bool InRestart
  { get => Accessor.GetBool("inrestart"); set => Accessor.SetBool("inrestart", value); }
}
