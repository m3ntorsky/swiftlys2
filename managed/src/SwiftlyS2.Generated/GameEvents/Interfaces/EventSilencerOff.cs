using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "silencer_off"
/// </summary>
public interface EventSilencerOff : IGameEvent<EventSilencerOff> {

  static EventSilencerOff IGameEvent<EventSilencerOff>.FromAllocated(nint ptr) => new EventSilencerOffImpl(ptr, true);

  static EventSilencerOff IGameEvent<EventSilencerOff>.FromExternal(nint ptr) => new EventSilencerOffImpl(ptr, false);

  static string IGameEvent<EventSilencerOff>.GetName() => "silencer_off";

  static uint IGameEvent<EventSilencerOff>.GetHash() => 0x572861ACu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
