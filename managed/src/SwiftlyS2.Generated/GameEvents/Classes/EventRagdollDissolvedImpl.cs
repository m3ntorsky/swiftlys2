using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ragdoll_dissolved"
/// </summary>
internal class EventRagdollDissolvedImpl : GameEvent<EventRagdollDissolved>, EventRagdollDissolved
{

  public EventRagdollDissolvedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }
}
