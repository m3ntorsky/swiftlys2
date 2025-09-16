using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_radio"
/// </summary>
public interface EventPlayerRadio : IGameEvent<EventPlayerRadio> {

  static EventPlayerRadio IGameEvent<EventPlayerRadio>.FromAllocated(nint ptr) => new EventPlayerRadioImpl(ptr, true);

  static EventPlayerRadio IGameEvent<EventPlayerRadio>.FromExternal(nint ptr) => new EventPlayerRadioImpl(ptr, false);

  static string IGameEvent<EventPlayerRadio>.GetName() => "player_radio";

  static uint IGameEvent<EventPlayerRadio>.GetHash() => 0x133AAE2Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Slot { get; set; }

}
