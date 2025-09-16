using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "tournament_reward"
/// </summary>
internal class EventTournamentRewardImpl : GameEvent<EventTournamentReward>, EventTournamentReward
{

  public EventTournamentRewardImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int DefIndex
  { get => GetInt("defindex"); set => SetInt("defindex", value); }

  public int TotalRewards
  { get => GetInt("totalrewards"); set => SetInt("totalrewards", value); }

  public int AccountID
  { get => GetInt("accountid"); set => SetInt("accountid", value); }
}
