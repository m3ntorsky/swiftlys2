using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inferno_expire"
/// </summary>
public interface EventInfernoExpire : ITypedGameEvent<EventInfernoExpire> {

  static EventInfernoExpire ITypedGameEvent<EventInfernoExpire>.Create() => new EventInfernoExpireImpl();

  static string ITypedGameEvent<EventInfernoExpire>.GetName() => "inferno_expire";

  static uint ITypedGameEvent<EventInfernoExpire>.GetHash() => 0x6C556CEEu;
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
