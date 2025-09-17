using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_pre_restart"
/// </summary>
public interface EventCsPreRestart : ITypedGameEvent<EventCsPreRestart> {

  static EventCsPreRestart ITypedGameEvent<EventCsPreRestart>.Wrap(IGameEvent accessor) => new EventCsPreRestartImpl(accessor);

  static string ITypedGameEvent<EventCsPreRestart>.GetName() => "cs_pre_restart";

  static uint ITypedGameEvent<EventCsPreRestart>.GetHash() => 0xE870A219u;
}
