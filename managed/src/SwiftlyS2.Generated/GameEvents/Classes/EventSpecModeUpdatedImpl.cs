using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "spec_mode_updated"
/// </summary>
internal class EventSpecModeUpdatedImpl : GameEvent<EventSpecModeUpdated>, EventSpecModeUpdated
{

  public EventSpecModeUpdatedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // spectating player
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
