using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "team_score"
/// team score changed
/// </summary>
internal class EventTeamScoreImpl : GameEvent<EventTeamScore>, EventTeamScore
{

  public EventTeamScoreImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // team id
  public byte TeamID
  { get => (byte)GetInt("teamid"); set => SetInt("teamid", value); }

  // total team score
  public short Score
  { get => (short)GetInt("score"); set => SetInt("score", value); }
}
