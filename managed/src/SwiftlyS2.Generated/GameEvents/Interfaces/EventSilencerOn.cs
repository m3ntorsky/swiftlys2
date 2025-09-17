using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "silencer_on"
/// </summary>
public interface EventSilencerOn : ITypedGameEvent<EventSilencerOn> {

  static EventSilencerOn ITypedGameEvent<EventSilencerOn>.Wrap(IGameEvent accessor) => new EventSilencerOnImpl(accessor);

  static string ITypedGameEvent<EventSilencerOn>.GetName() => "silencer_on";

  static uint ITypedGameEvent<EventSilencerOn>.GetHash() => 0xA834DFDAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
