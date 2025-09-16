using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "choppers_incoming_warning"
/// </summary>
public interface EventChoppersIncomingWarning : IGameEvent<EventChoppersIncomingWarning> {

  static EventChoppersIncomingWarning IGameEvent<EventChoppersIncomingWarning>.FromAllocated(nint ptr) => new EventChoppersIncomingWarningImpl(ptr, true);

  static EventChoppersIncomingWarning IGameEvent<EventChoppersIncomingWarning>.FromExternal(nint ptr) => new EventChoppersIncomingWarningImpl(ptr, false);

  static string IGameEvent<EventChoppersIncomingWarning>.GetName() => "choppers_incoming_warning";

  static uint IGameEvent<EventChoppersIncomingWarning>.GetHash() => 0x68E589D1u;
  /// <summary>
  /// type: bool
  /// </summary>
  bool Global { get; set; }

}
