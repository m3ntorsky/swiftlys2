using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "flare_ignite_npc"
/// </summary>
internal class EventFlareIgniteNpcImpl : GameEvent<EventFlareIgniteNpc>, EventFlareIgniteNpc
{

  public EventFlareIgniteNpcImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // entity ignited
  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }
}
