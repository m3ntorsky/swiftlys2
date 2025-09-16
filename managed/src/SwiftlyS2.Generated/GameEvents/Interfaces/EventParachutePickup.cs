using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "parachute_pickup"
/// </summary>
public interface EventParachutePickup : IGameEvent<EventParachutePickup> {

  static EventParachutePickup IGameEvent<EventParachutePickup>.FromAllocated(nint ptr) => new EventParachutePickupImpl(ptr, true);

  static EventParachutePickup IGameEvent<EventParachutePickup>.FromExternal(nint ptr) => new EventParachutePickupImpl(ptr, false);

  static string IGameEvent<EventParachutePickup>.GetName() => "parachute_pickup";

  static uint IGameEvent<EventParachutePickup>.GetHash() => 0x9A331261u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
