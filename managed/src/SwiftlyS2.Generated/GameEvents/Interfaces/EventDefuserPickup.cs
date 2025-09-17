using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "defuser_pickup"
/// </summary>
public interface EventDefuserPickup : ITypedGameEvent<EventDefuserPickup> {

  static EventDefuserPickup ITypedGameEvent<EventDefuserPickup>.Wrap(IGameEvent accessor) => new EventDefuserPickupImpl(accessor);

  static string ITypedGameEvent<EventDefuserPickup>.GetName() => "defuser_pickup";

  static uint ITypedGameEvent<EventDefuserPickup>.GetHash() => 0xA9099A0Cu;
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
