using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "show_survival_respawn_status"
/// </summary>
internal class EventShowSurvivalRespawnStatusImpl : GameEvent<EventShowSurvivalRespawnStatus>, EventShowSurvivalRespawnStatus
{

  public EventShowSurvivalRespawnStatusImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string LocToken
  { get => GetString("loc_token"); set => SetString("loc_token", value); }

  public int Duration
  { get => GetInt("duration"); set => SetInt("duration", value); }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
