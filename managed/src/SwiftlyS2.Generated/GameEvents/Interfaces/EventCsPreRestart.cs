using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_pre_restart"
/// </summary>
public interface EventCsPreRestart : IGameEvent<EventCsPreRestart> {

  static EventCsPreRestart IGameEvent<EventCsPreRestart>.FromAllocated(nint ptr) => new EventCsPreRestartImpl(ptr, true);

  static EventCsPreRestart IGameEvent<EventCsPreRestart>.FromExternal(nint ptr) => new EventCsPreRestartImpl(ptr, false);

  static string IGameEvent<EventCsPreRestart>.GetName() => "cs_pre_restart";

  static uint IGameEvent<EventCsPreRestart>.GetHash() => 0xE870A219u;
}
