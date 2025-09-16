using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_spawned"
/// </summary>
internal class EventPlayerSpawnedImpl : GameEvent<EventPlayerSpawned>, EventPlayerSpawned
{

  public EventPlayerSpawnedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // true if restart is pending
  public bool InRestart
  { get => GetBool("inrestart"); set => SetBool("inrestart", value); }
}
