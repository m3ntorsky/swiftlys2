using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_rescue_zone"
/// </summary>
public interface EventExitRescueZone : IGameEvent<EventExitRescueZone> {

  static EventExitRescueZone IGameEvent<EventExitRescueZone>.FromAllocated(nint ptr) => new EventExitRescueZoneImpl(ptr, true);

  static EventExitRescueZone IGameEvent<EventExitRescueZone>.FromExternal(nint ptr) => new EventExitRescueZoneImpl(ptr, false);

  static string IGameEvent<EventExitRescueZone>.GetName() => "exit_rescue_zone";

  static uint IGameEvent<EventExitRescueZone>.GetHash() => 0xEC6242D2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
