using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "jointeam_failed"
/// </summary>
internal class EventJointeamFailedImpl : GameEvent<EventJointeamFailed>, EventJointeamFailed
{

  public EventJointeamFailedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // 0 = team_full
  public byte Reason
  { get => (byte)GetInt("reason"); set => SetInt("reason", value); }
}
