using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "server_cvar"
/// a server console var has changed
/// </summary>
public interface EventServerCvar : ITypedGameEvent<EventServerCvar> {

  static EventServerCvar ITypedGameEvent<EventServerCvar>.Create() => new EventServerCvarImpl();

  static string ITypedGameEvent<EventServerCvar>.GetName() => "server_cvar";

  static uint ITypedGameEvent<EventServerCvar>.GetHash() => 0x11BA3D6Du;
  /// <summary>
  /// cvar name, eg "mp_roundtime"
  /// <br/>
  /// type: string
  /// </summary>
  string CVarName { get; set; }

  /// <summary>
  /// new cvar value
  /// <br/>
  /// type: string
  /// </summary>
  string CVarValue { get; set; }

}
