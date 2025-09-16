using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_rank_entity"
/// an entity ranking
/// </summary>
internal class EventHltvRankEntityImpl : GameEvent<EventHltvRankEntity>, EventHltvRankEntity
{

  public EventHltvRankEntityImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player slot
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // ranking, how interesting is this entity to view
  public float Rank
  { get => GetFloat("rank"); set => SetFloat("rank", value); }

  // best/closest target entity
  public int Target
  { get => GetPlayerSlot("target"); set => SetPlayerSlot("target", value); }
}
