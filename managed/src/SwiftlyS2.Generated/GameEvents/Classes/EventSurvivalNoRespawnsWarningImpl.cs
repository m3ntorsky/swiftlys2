using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "survival_no_respawns_warning"
/// </summary>
internal class EventSurvivalNoRespawnsWarningImpl : GameEvent<EventSurvivalNoRespawnsWarning>, EventSurvivalNoRespawnsWarning
{

  public EventSurvivalNoRespawnsWarningImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
