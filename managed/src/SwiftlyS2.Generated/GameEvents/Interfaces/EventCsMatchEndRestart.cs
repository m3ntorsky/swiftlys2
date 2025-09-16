using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_match_end_restart"
/// </summary>
public interface EventCsMatchEndRestart : IGameEvent<EventCsMatchEndRestart> {

  static EventCsMatchEndRestart IGameEvent<EventCsMatchEndRestart>.FromAllocated(nint ptr) => new EventCsMatchEndRestartImpl(ptr, true);

  static EventCsMatchEndRestart IGameEvent<EventCsMatchEndRestart>.FromExternal(nint ptr) => new EventCsMatchEndRestartImpl(ptr, false);

  static string IGameEvent<EventCsMatchEndRestart>.GetName() => "cs_match_end_restart";

  static uint IGameEvent<EventCsMatchEndRestart>.GetHash() => 0xFB2BFA6Fu;
}
