using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "physgun_pickup"
/// </summary>
public interface EventPhysgunPickup : ITypedGameEvent<EventPhysgunPickup> {

  static EventPhysgunPickup ITypedGameEvent<EventPhysgunPickup>.Wrap(IGameEvent accessor) => new EventPhysgunPickupImpl(accessor);

  static string ITypedGameEvent<EventPhysgunPickup>.GetName() => "physgun_pickup";

  static uint ITypedGameEvent<EventPhysgunPickup>.GetHash() => 0x5E27B9FAu;
  /// <summary>
  /// entity picked up
  /// <br/>
  /// type: ehandle
  /// </summary>
  nint Target { get; set; }

}
