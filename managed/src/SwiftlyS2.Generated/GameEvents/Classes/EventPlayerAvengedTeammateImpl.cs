using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_avenged_teammate"
/// </summary>
internal class EventPlayerAvengedTeammateImpl : GameEvent<EventPlayerAvengedTeammate>, EventPlayerAvengedTeammate
{

  public EventPlayerAvengedTeammateImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int AvengerId
  { get => GetPlayerSlot("avenger_id"); set => SetPlayerSlot("avenger_id", value); }

  public int AvengedPlayerId
  { get => GetPlayerSlot("avenged_player_id"); set => SetPlayerSlot("avenged_player_id", value); }
}
