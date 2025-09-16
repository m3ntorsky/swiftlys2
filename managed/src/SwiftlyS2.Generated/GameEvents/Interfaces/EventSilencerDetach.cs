using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "silencer_detach"
/// </summary>
public interface EventSilencerDetach : IGameEvent<EventSilencerDetach> {

  static EventSilencerDetach IGameEvent<EventSilencerDetach>.FromAllocated(nint ptr) => new EventSilencerDetachImpl(ptr, true);

  static EventSilencerDetach IGameEvent<EventSilencerDetach>.FromExternal(nint ptr) => new EventSilencerDetachImpl(ptr, false);

  static string IGameEvent<EventSilencerDetach>.GetName() => "silencer_detach";

  static uint IGameEvent<EventSilencerDetach>.GetHash() => 0x1670A6D0u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
