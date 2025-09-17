using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_rescue_zone"
/// </summary>
public interface EventExitRescueZone : ITypedGameEvent<EventExitRescueZone> {

  static EventExitRescueZone ITypedGameEvent<EventExitRescueZone>.Create() => new EventExitRescueZoneImpl();

  static string ITypedGameEvent<EventExitRescueZone>.GetName() => "exit_rescue_zone";

  static uint ITypedGameEvent<EventExitRescueZone>.GetHash() => 0xEC6242D2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
