using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "seasoncoin_levelup"
/// </summary>
internal class EventSeasoncoinLevelupImpl : GameEvent<EventSeasoncoinLevelup>, EventSeasoncoinLevelup
{

  public EventSeasoncoinLevelupImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Category
  { get => (short)GetInt("category"); set => SetInt("category", value); }

  public short Rank
  { get => (short)GetInt("rank"); set => SetInt("rank", value); }
}
