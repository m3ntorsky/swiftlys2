using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "spec_target_updated"
/// </summary>
internal class EventSpecTargetUpdatedImpl : TypedGameEvent<EventSpecTargetUpdated>, EventSpecTargetUpdated
{


  // spectating player
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // ehandle of the target
  public nint Target
  { get => Accessor.GetPtr("target"); set => Accessor.SetPtr("target", value); }
}
