using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "sfuievent"
/// </summary>
public interface EventSfuievent : ITypedGameEvent<EventSfuievent> {

  static EventSfuievent ITypedGameEvent<EventSfuievent>.Create() => new EventSfuieventImpl();

  static string ITypedGameEvent<EventSfuievent>.GetName() => "sfuievent";

  static uint ITypedGameEvent<EventSfuievent>.GetHash() => 0xA20ACD22u;
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
