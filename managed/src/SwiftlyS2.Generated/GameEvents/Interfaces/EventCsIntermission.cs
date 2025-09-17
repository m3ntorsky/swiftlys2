using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_intermission"
/// </summary>
public interface EventCsIntermission : ITypedGameEvent<EventCsIntermission> {

  static EventCsIntermission ITypedGameEvent<EventCsIntermission>.Create() => new EventCsIntermissionImpl();

  static string ITypedGameEvent<EventCsIntermission>.GetName() => "cs_intermission";

  static uint ITypedGameEvent<EventCsIntermission>.GetHash() => 0x1BDF3E80u;
}
