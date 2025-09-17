using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "defuser_dropped"
/// </summary>
public interface EventDefuserDropped : ITypedGameEvent<EventDefuserDropped> {

  static EventDefuserDropped ITypedGameEvent<EventDefuserDropped>.Create() => new EventDefuserDroppedImpl();

  static string ITypedGameEvent<EventDefuserDropped>.GetName() => "defuser_dropped";

  static uint ITypedGameEvent<EventDefuserDropped>.GetHash() => 0xA5E094F6u;
  /// <summary>
  /// defuser's entity ID
  /// <br/>
  /// type: long
  /// </summary>
  int EntityID { get; set; }

}
