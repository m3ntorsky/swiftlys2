using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "grenade_bounce"
/// </summary>
internal class EventGrenadeBounceImpl : TypedGameEvent<EventGrenadeBounce>, EventGrenadeBounce
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
