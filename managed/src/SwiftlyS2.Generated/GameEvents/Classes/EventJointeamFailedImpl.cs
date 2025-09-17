using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "jointeam_failed"
/// </summary>
internal class EventJointeamFailedImpl : TypedGameEvent<EventJointeamFailed>, EventJointeamFailed
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // 0 = team_full
  public byte Reason
  { get => (byte)Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }
}
