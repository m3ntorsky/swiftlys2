using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_activate"
/// </summary>
internal class EventPlayerActivateImpl : GameEvent<EventPlayerActivate>, EventPlayerActivate
{

  public EventPlayerActivateImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
