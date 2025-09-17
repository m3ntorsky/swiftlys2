using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "trial_time_expired"
/// </summary>
internal class EventTrialTimeExpiredImpl : TypedGameEvent<EventTrialTimeExpired>, EventTrialTimeExpired
{


  // player whose time has expired
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
