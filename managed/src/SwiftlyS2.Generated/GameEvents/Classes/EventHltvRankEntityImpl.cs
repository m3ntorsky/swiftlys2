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
internal class EventHltvRankEntityImpl : TypedGameEvent<EventHltvRankEntity>, EventHltvRankEntity
{

  public EventHltvRankEntityImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player slot
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // ranking, how interesting is this entity to view
  public float Rank
  { get => Accessor.GetFloat("rank"); set => Accessor.SetFloat("rank", value); }

  // best/closest target entity
  public int Target
  { get => Accessor.GetPlayerSlot("target"); set => Accessor.SetPlayerSlot("target", value); }
}
