using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inferno_startburn"
/// </summary>
public interface EventInfernoStartburn : ITypedGameEvent<EventInfernoStartburn> {

  static EventInfernoStartburn ITypedGameEvent<EventInfernoStartburn>.Wrap(IGameEvent accessor) => new EventInfernoStartburnImpl(accessor);

  static string ITypedGameEvent<EventInfernoStartburn>.GetName() => "inferno_startburn";

  static uint ITypedGameEvent<EventInfernoStartburn>.GetHash() => 0xD080B17Au;
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
