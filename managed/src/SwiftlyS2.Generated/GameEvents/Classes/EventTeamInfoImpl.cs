using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "team_info"
/// info about team
/// </summary>
internal class EventTeamInfoImpl : GameEvent<EventTeamInfo>, EventTeamInfo
{

  public EventTeamInfoImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // unique team id
  public byte TeamID
  { get => (byte)GetInt("teamid"); set => SetInt("teamid", value); }

  // team name eg "Team Blue"
  public string Teamname
  { get => GetString("teamname"); set => SetString("teamname", value); }
}
