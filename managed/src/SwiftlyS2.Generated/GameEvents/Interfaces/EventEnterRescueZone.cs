using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_rescue_zone"
/// </summary>
public interface EventEnterRescueZone : IGameEvent<EventEnterRescueZone> {

  static EventEnterRescueZone IGameEvent<EventEnterRescueZone>.FromAllocated(nint ptr) => new EventEnterRescueZoneImpl(ptr, true);

  static EventEnterRescueZone IGameEvent<EventEnterRescueZone>.FromExternal(nint ptr) => new EventEnterRescueZoneImpl(ptr, false);

  static string IGameEvent<EventEnterRescueZone>.GetName() => "enter_rescue_zone";

  static uint IGameEvent<EventEnterRescueZone>.GetHash() => 0xA10C79CAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
