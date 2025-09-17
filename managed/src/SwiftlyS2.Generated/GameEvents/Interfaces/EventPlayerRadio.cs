using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_radio"
/// </summary>
public interface EventPlayerRadio : ITypedGameEvent<EventPlayerRadio> {

  static EventPlayerRadio ITypedGameEvent<EventPlayerRadio>.Wrap(IGameEvent accessor) => new EventPlayerRadioImpl(accessor);

  static string ITypedGameEvent<EventPlayerRadio>.GetName() => "player_radio";

  static uint ITypedGameEvent<EventPlayerRadio>.GetHash() => 0x133AAE2Cu;
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
