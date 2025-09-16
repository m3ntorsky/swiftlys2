using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "sfuievent"
/// </summary>
public interface EventSfuievent : IGameEvent<EventSfuievent> {

  static EventSfuievent IGameEvent<EventSfuievent>.FromAllocated(nint ptr) => new EventSfuieventImpl(ptr, true);

  static EventSfuievent IGameEvent<EventSfuievent>.FromExternal(nint ptr) => new EventSfuieventImpl(ptr, false);

  static string IGameEvent<EventSfuievent>.GetName() => "sfuievent";

  static uint IGameEvent<EventSfuievent>.GetHash() => 0xA20ACD22u;
  /// <summary>
  /// type: string
  /// </summary>
  string Action { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Data { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot { get; set; }

}
