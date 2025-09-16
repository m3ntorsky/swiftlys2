using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "instructor_server_hint_stop"
/// destroys a server/map created hint
/// </summary>
public interface EventInstructorServerHintStop : IGameEvent<EventInstructorServerHintStop> {

  static EventInstructorServerHintStop IGameEvent<EventInstructorServerHintStop>.FromAllocated(nint ptr) => new EventInstructorServerHintStopImpl(ptr, true);

  static EventInstructorServerHintStop IGameEvent<EventInstructorServerHintStop>.FromExternal(nint ptr) => new EventInstructorServerHintStopImpl(ptr, false);

  static string IGameEvent<EventInstructorServerHintStop>.GetName() => "instructor_server_hint_stop";

  static uint IGameEvent<EventInstructorServerHintStop>.GetHash() => 0xEA673171u;
  /// <summary>
  /// The hint to stop. Will stop ALL hints with this name
  /// <br/>
  /// type: string
  /// </summary>
  string HintName { get; set; }

  /// <summary>
  /// entity id of the env_instructor_hint that fired the event
  /// <br/>
  /// type: long
  /// </summary>
  int HintEntindex { get; set; }

}
