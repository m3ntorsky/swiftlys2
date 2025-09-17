using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_match_end_restart"
/// </summary>
public interface EventCsMatchEndRestart : ITypedGameEvent<EventCsMatchEndRestart> {

  static EventCsMatchEndRestart ITypedGameEvent<EventCsMatchEndRestart>.Wrap(IGameEvent accessor) => new EventCsMatchEndRestartImpl(accessor);

  static string ITypedGameEvent<EventCsMatchEndRestart>.GetName() => "cs_match_end_restart";

  static uint ITypedGameEvent<EventCsMatchEndRestart>.GetHash() => 0xFB2BFA6Fu;
}
