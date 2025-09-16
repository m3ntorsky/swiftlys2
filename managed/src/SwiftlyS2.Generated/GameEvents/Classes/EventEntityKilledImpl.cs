using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "entity_killed"
/// </summary>
internal class EventEntityKilledImpl : GameEvent<EventEntityKilled>, EventEntityKilled
{

  public EventEntityKilledImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int EntindexKilled
  { get => GetInt("entindex_killed"); set => SetInt("entindex_killed", value); }

  public int EntindexAttacker
  { get => GetInt("entindex_attacker"); set => SetInt("entindex_attacker", value); }

  public int EntindexInflictor
  { get => GetInt("entindex_inflictor"); set => SetInt("entindex_inflictor", value); }

  public int DamageBits
  { get => GetInt("damagebits"); set => SetInt("damagebits", value); }
}
