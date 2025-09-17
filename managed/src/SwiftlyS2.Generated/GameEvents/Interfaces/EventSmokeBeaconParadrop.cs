using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "smoke_beacon_paradrop"
/// </summary>
public interface EventSmokeBeaconParadrop : ITypedGameEvent<EventSmokeBeaconParadrop> {

  static EventSmokeBeaconParadrop ITypedGameEvent<EventSmokeBeaconParadrop>.Create() => new EventSmokeBeaconParadropImpl();

  static string ITypedGameEvent<EventSmokeBeaconParadrop>.GetName() => "smoke_beacon_paradrop";

  static uint ITypedGameEvent<EventSmokeBeaconParadrop>.GetHash() => 0xA68BF79Bu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short ParaDrop { get; set; }

}
