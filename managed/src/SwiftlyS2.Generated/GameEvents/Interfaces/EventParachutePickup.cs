using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "parachute_pickup"
/// </summary>
public interface EventParachutePickup : ITypedGameEvent<EventParachutePickup> {

  static EventParachutePickup ITypedGameEvent<EventParachutePickup>.Wrap(IGameEvent accessor) => new EventParachutePickupImpl(accessor);

  static string ITypedGameEvent<EventParachutePickup>.GetName() => "parachute_pickup";

  static uint ITypedGameEvent<EventParachutePickup>.GetHash() => 0x9A331261u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
