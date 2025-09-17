using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "silencer_detach"
/// </summary>
public interface EventSilencerDetach : ITypedGameEvent<EventSilencerDetach> {

  static EventSilencerDetach ITypedGameEvent<EventSilencerDetach>.Wrap(IGameEvent accessor) => new EventSilencerDetachImpl(accessor);

  static string ITypedGameEvent<EventSilencerDetach>.GetName() => "silencer_detach";

  static uint ITypedGameEvent<EventSilencerDetach>.GetHash() => 0x1670A6D0u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
