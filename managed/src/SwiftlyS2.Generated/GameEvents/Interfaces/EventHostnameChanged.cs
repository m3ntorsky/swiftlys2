using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostname_changed"
/// </summary>
public interface EventHostnameChanged : ITypedGameEvent<EventHostnameChanged> {

  static EventHostnameChanged ITypedGameEvent<EventHostnameChanged>.Create() => new EventHostnameChangedImpl();

  static string ITypedGameEvent<EventHostnameChanged>.GetName() => "hostname_changed";

  static uint ITypedGameEvent<EventHostnameChanged>.GetHash() => 0x81496EB7u;
  /// <summary>
  /// type: string
  /// </summary>
  string Hostname { get; set; }

}
