using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "defuser_pickup"
/// </summary>
public interface EventDefuserPickup : IGameEvent<EventDefuserPickup> {

  static EventDefuserPickup IGameEvent<EventDefuserPickup>.FromAllocated(nint ptr) => new EventDefuserPickupImpl(ptr, true);

  static EventDefuserPickup IGameEvent<EventDefuserPickup>.FromExternal(nint ptr) => new EventDefuserPickupImpl(ptr, false);

  static string IGameEvent<EventDefuserPickup>.GetName() => "defuser_pickup";

  static uint IGameEvent<EventDefuserPickup>.GetHash() => 0xA9099A0Cu;
  /// <summary>
  /// defuser's entity ID
  /// <br/>
  /// type: long
  /// </summary>
  int EntityID { get; set; }

  /// <summary>
  /// player who picked up the defuser
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
