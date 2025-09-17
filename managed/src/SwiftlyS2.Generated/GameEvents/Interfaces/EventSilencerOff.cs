using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "silencer_off"
/// </summary>
public interface EventSilencerOff : ITypedGameEvent<EventSilencerOff> {

  static EventSilencerOff ITypedGameEvent<EventSilencerOff>.Wrap(IGameEvent accessor) => new EventSilencerOffImpl(accessor);

  static string ITypedGameEvent<EventSilencerOff>.GetName() => "silencer_off";

  static uint ITypedGameEvent<EventSilencerOff>.GetHash() => 0x572861ACu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
