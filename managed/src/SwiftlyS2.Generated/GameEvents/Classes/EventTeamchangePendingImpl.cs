using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "teamchange_pending"
/// </summary>
internal class EventTeamchangePendingImpl : GameEvent<EventTeamchangePending>, EventTeamchangePending
{

  public EventTeamchangePendingImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public byte ToTeam
  { get => (byte)GetInt("toteam"); set => SetInt("toteam", value); }
}
