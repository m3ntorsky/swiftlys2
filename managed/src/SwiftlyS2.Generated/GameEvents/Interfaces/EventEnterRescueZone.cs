using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_rescue_zone"
/// </summary>
public interface EventEnterRescueZone : IGameEvent<EventEnterRescueZone> {

  static EventEnterRescueZone IGameEvent<EventEnterRescueZone>.Create() => new EventEnterRescueZoneImpl();

  static string IGameEvent<EventEnterRescueZone>.GetName() => "enter_rescue_zone";

  static uint IGameEvent<EventEnterRescueZone>.GetHash() => 0xA10C79CAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
