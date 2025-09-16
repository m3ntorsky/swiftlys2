using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "switch_team"
/// </summary>
internal class EventSwitchTeamImpl : GameEvent<EventSwitchTeam>, EventSwitchTeam
{

  public EventSwitchTeamImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // number of active players on both T and CT
  public short NumPlayers
  { get => (short)GetInt("numPlayers"); set => SetInt("numPlayers", value); }

  // number of spectators
  public short NumSpectators
  { get => (short)GetInt("numSpectators"); set => SetInt("numSpectators", value); }

  // average rank of human players
  public short AvgRank
  { get => (short)GetInt("avg_rank"); set => SetInt("avg_rank", value); }

  public short NumTSlotsFree
  { get => (short)GetInt("numTSlotsFree"); set => SetInt("numTSlotsFree", value); }

  public short NumCTSlotsFree
  { get => (short)GetInt("numCTSlotsFree"); set => SetInt("numCTSlotsFree", value); }
}
