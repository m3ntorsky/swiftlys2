using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "spec_target_updated"
/// </summary>
internal class EventSpecTargetUpdatedImpl : GameEvent<EventSpecTargetUpdated>, EventSpecTargetUpdated
{

  public EventSpecTargetUpdatedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // spectating player
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // ehandle of the target
  public nint Target
  { get => GetPtr("target"); set => SetPtr("target", value); }
}
