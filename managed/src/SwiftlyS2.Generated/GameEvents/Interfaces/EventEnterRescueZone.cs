using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_rescue_zone"
/// </summary>
public interface EventEnterRescueZone : ITypedGameEvent<EventEnterRescueZone> {

  static EventEnterRescueZone ITypedGameEvent<EventEnterRescueZone>.Create() => new EventEnterRescueZoneImpl();

  static string ITypedGameEvent<EventEnterRescueZone>.GetName() => "enter_rescue_zone";

  static uint ITypedGameEvent<EventEnterRescueZone>.GetHash() => 0xA10C79CAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
