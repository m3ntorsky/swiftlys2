using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_cameraman"
/// a spectator/player is a cameraman
/// </summary>
public interface EventHltvCameraman : IGameEvent<EventHltvCameraman> {

  static EventHltvCameraman IGameEvent<EventHltvCameraman>.FromAllocated(nint ptr) => new EventHltvCameramanImpl(ptr, true);

  static EventHltvCameraman IGameEvent<EventHltvCameraman>.FromExternal(nint ptr) => new EventHltvCameramanImpl(ptr, false);

  static string IGameEvent<EventHltvCameraman>.GetName() => "hltv_cameraman";

  static uint IGameEvent<EventHltvCameraman>.GetHash() => 0xD54932D5u;
  /// <summary>
  /// camera man entity index
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
