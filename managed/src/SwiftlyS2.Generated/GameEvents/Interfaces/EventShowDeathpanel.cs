using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "show_deathpanel"
/// </summary>
public interface EventShowDeathpanel : ITypedGameEvent<EventShowDeathpanel> {

  static EventShowDeathpanel ITypedGameEvent<EventShowDeathpanel>.Wrap(IGameEvent accessor) => new EventShowDeathpanelImpl(accessor);

  static string ITypedGameEvent<EventShowDeathpanel>.GetName() => "show_deathpanel";

  static uint ITypedGameEvent<EventShowDeathpanel>.GetHash() => 0x2AB9F7A1u;
  /// <summary>
  /// endindex of the one who was killed
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int Victim { get; set; }

  /// <summary>
  /// entindex of the killer entity
  /// <br/>
  /// type: ehandle
  /// </summary>
  nint Killer { get; set; }

  /// <summary>
  /// type: player_controller
  /// </summary>
  int KillerController { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short HitsTaken { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short DamageTaken { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short HitsGiven { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short DamageGiven { get; set; }

}
