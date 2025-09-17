using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inferno_extinguish"
/// </summary>
public interface EventInfernoExtinguish : ITypedGameEvent<EventInfernoExtinguish> {

  static EventInfernoExtinguish ITypedGameEvent<EventInfernoExtinguish>.Create() => new EventInfernoExtinguishImpl();

  static string ITypedGameEvent<EventInfernoExtinguish>.GetName() => "inferno_extinguish";

  static uint ITypedGameEvent<EventInfernoExtinguish>.GetHash() => 0x9A4147B1u;
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
