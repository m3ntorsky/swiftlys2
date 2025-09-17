using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "survival_no_respawns_final"
/// </summary>
internal class EventSurvivalNoRespawnsFinalImpl : TypedGameEvent<EventSurvivalNoRespawnsFinal>, EventSurvivalNoRespawnsFinal
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
