using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "ragdoll_dissolved"
/// </summary>
public interface EventRagdollDissolved : IGameEvent<EventRagdollDissolved> {

  static EventRagdollDissolved IGameEvent<EventRagdollDissolved>.FromAllocated(nint ptr) => new EventRagdollDissolvedImpl(ptr, true);

  static EventRagdollDissolved IGameEvent<EventRagdollDissolved>.FromExternal(nint ptr) => new EventRagdollDissolvedImpl(ptr, false);

  static string IGameEvent<EventRagdollDissolved>.GetName() => "ragdoll_dissolved";

  static uint IGameEvent<EventRagdollDissolved>.GetHash() => 0x633046FAu;
  /// <summary>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
