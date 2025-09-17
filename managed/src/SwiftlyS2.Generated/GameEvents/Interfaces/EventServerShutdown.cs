using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "server_shutdown"
/// server shut down
/// </summary>
public interface EventServerShutdown : ITypedGameEvent<EventServerShutdown> {

  static EventServerShutdown ITypedGameEvent<EventServerShutdown>.Wrap(IGameEvent accessor) => new EventServerShutdownImpl(accessor);

  static string ITypedGameEvent<EventServerShutdown>.GetName() => "server_shutdown";

  static uint ITypedGameEvent<EventServerShutdown>.GetHash() => 0x840A8CCDu;
  /// <summary>
  /// reason why server was shut down
  /// <br/>
  /// type: string
  /// </summary>
  string Reason { get; set; }

}
