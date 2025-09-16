using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_pickup"
/// </summary>
public interface EventBombPickup : IGameEvent<EventBombPickup> {

  static EventBombPickup IGameEvent<EventBombPickup>.FromAllocated(nint ptr) => new EventBombPickupImpl(ptr, true);

  static EventBombPickup IGameEvent<EventBombPickup>.FromExternal(nint ptr) => new EventBombPickupImpl(ptr, false);

  static string IGameEvent<EventBombPickup>.GetName() => "bomb_pickup";

  static uint IGameEvent<EventBombPickup>.GetHash() => 0x97693BEEu;
  /// <summary>
  /// player pawn who picked up the bomb
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
