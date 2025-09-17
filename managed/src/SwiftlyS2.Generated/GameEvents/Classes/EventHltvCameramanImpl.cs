using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_cameraman"
/// a spectator/player is a cameraman
/// </summary>
internal class EventHltvCameramanImpl : TypedGameEvent<EventHltvCameraman>, EventHltvCameraman
{


  // camera man entity index
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
