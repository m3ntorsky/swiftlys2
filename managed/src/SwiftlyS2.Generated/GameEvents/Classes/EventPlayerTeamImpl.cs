using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_team"
/// </summary>
internal class EventPlayerTeamImpl : GameEvent<EventPlayerTeam>, EventPlayerTeam
{

  public EventPlayerTeamImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // team id
  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }

  // old team id
  public byte OldTeam
  { get => (byte)GetInt("oldteam"); set => SetInt("oldteam", value); }

  // team change because player disconnects
  public bool Disconnect
  { get => GetBool("disconnect"); set => SetBool("disconnect", value); }

  public bool Silent
  { get => GetBool("silent"); set => SetBool("silent", value); }

  public string Name
  { get => GetString("name"); set => SetString("name", value); }

  public bool IsBot
  { get => GetBool("isbot"); set => SetBool("isbot", value); }
}
