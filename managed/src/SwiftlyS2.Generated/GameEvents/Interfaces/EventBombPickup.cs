using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_pickup"
/// </summary>
public interface EventBombPickup : ITypedGameEvent<EventBombPickup> {

  static EventBombPickup ITypedGameEvent<EventBombPickup>.Wrap(IGameEvent accessor) => new EventBombPickupImpl(accessor);

  static string ITypedGameEvent<EventBombPickup>.GetName() => "bomb_pickup";

  static uint ITypedGameEvent<EventBombPickup>.GetHash() => 0x97693BEEu;
  /// <summary>
  /// player pawn who picked up the bomb
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
