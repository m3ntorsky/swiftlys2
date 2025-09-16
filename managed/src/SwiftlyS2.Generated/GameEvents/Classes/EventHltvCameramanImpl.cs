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
internal class EventHltvCameramanImpl : GameEvent<EventHltvCameraman>, EventHltvCameraman
{

  public EventHltvCameramanImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // camera man entity index
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
