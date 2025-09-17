using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_cameraman"
/// a spectator/player is a cameraman
/// </summary>
public interface EventHltvCameraman : ITypedGameEvent<EventHltvCameraman> {

  static EventHltvCameraman ITypedGameEvent<EventHltvCameraman>.Wrap(IGameEvent accessor) => new EventHltvCameramanImpl(accessor);

  static string ITypedGameEvent<EventHltvCameraman>.GetName() => "hltv_cameraman";

  static uint ITypedGameEvent<EventHltvCameraman>.GetHash() => 0xD54932D5u;
  /// <summary>
  /// camera man entity index
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
