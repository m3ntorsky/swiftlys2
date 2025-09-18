using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "physgun_pickup"
/// </summary>
public interface EventPhysgunPickup : IGameEvent<EventPhysgunPickup> {

  static EventPhysgunPickup IGameEvent<EventPhysgunPickup>.Create() => new EventPhysgunPickupImpl();

  static string IGameEvent<EventPhysgunPickup>.GetName() => "physgun_pickup";

  static uint IGameEvent<EventPhysgunPickup>.GetHash() => 0x5E27B9FAu;
  /// <summary>
  /// entity picked up
  /// <br/>
  /// type: ehandle
  /// </summary>
  nint Target { get; set; }

}
