using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inferno_startburn"
/// </summary>
public interface EventInfernoStartburn : IGameEvent<EventInfernoStartburn> {

  static EventInfernoStartburn IGameEvent<EventInfernoStartburn>.FromAllocated(nint ptr) => new EventInfernoStartburnImpl(ptr, true);

  static EventInfernoStartburn IGameEvent<EventInfernoStartburn>.FromExternal(nint ptr) => new EventInfernoStartburnImpl(ptr, false);

  static string IGameEvent<EventInfernoStartburn>.GetName() => "inferno_startburn";

  static uint IGameEvent<EventInfernoStartburn>.GetHash() => 0xD080B17Au;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float X { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Y { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Z { get; set; }

}
