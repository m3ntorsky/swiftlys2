using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gg_killed_enemy"
/// </summary>
public interface EventGgKilledEnemy : ITypedGameEvent<EventGgKilledEnemy> {

  static EventGgKilledEnemy ITypedGameEvent<EventGgKilledEnemy>.Wrap(IGameEvent accessor) => new EventGgKilledEnemyImpl(accessor);

  static string ITypedGameEvent<EventGgKilledEnemy>.GetName() => "gg_killed_enemy";

  static uint ITypedGameEvent<EventGgKilledEnemy>.GetHash() => 0x85DB35E2u;
  /// <summary>
  /// user ID who died
  /// <br/>
  /// type: player_controller
  /// </summary>
  int VictimID { get; set; }

  /// <summary>
  /// user ID who killed
  /// <br/>
  /// type: player_controller
  /// </summary>
  int AttackerID { get; set; }

  /// <summary>
  /// did killer dominate victim with this kill
  /// <br/>
  /// type: short
  /// </summary>
  short Dominated { get; set; }

  /// <summary>
  /// did killer get revenge on victim with this kill
  /// <br/>
  /// type: short
  /// </summary>
  short Revenge { get; set; }

  /// <summary>
  /// did killer kill with a bonus weapon?
  /// <br/>
  /// type: bool
  /// </summary>
  bool Bonus { get; set; }

}
