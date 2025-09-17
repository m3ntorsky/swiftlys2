using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "firstbombs_incoming_warning"
/// </summary>
public interface EventFirstbombsIncomingWarning : ITypedGameEvent<EventFirstbombsIncomingWarning> {

  static EventFirstbombsIncomingWarning ITypedGameEvent<EventFirstbombsIncomingWarning>.Create() => new EventFirstbombsIncomingWarningImpl();

  static string ITypedGameEvent<EventFirstbombsIncomingWarning>.GetName() => "firstbombs_incoming_warning";

  static uint ITypedGameEvent<EventFirstbombsIncomingWarning>.GetHash() => 0xEE565444u;
  /// <summary>
  /// type: bool
  /// </summary>
  bool Global { get; set; }

}
