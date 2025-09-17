using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ragdoll_dissolved"
/// </summary>
internal class EventRagdollDissolvedImpl : TypedGameEvent<EventRagdollDissolved>, EventRagdollDissolved
{


  public int EntIndex
  { get => Accessor.GetInt32("entindex"); set => Accessor.SetInt32("entindex", value); }
}
