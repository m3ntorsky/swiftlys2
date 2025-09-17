using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "enter_rescue_zone"
/// </summary>
internal class EventEnterRescueZoneImpl : TypedGameEvent<EventEnterRescueZone>, EventEnterRescueZone
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
