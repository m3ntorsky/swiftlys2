using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_hurt"
/// </summary>
public interface EventPlayerHurt : ITypedGameEvent<EventPlayerHurt> {

  static EventPlayerHurt ITypedGameEvent<EventPlayerHurt>.Wrap(IGameEvent accessor) => new EventPlayerHurtImpl(accessor);

  static string ITypedGameEvent<EventPlayerHurt>.GetName() => "player_hurt";

  static uint ITypedGameEvent<EventPlayerHurt>.GetHash() => 0x1B30DDF0u;
  /// <summary>
  /// player who was hurt
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// player who attacked
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int Attacker { get; set; }

  /// <summary>
  /// remaining health points
  /// <br/>
  /// type: byte
  /// </summary>
  byte Health { get; set; }

  /// <summary>
  /// remaining armor points
  /// <br/>
  /// type: byte
  /// </summary>
  byte Armor { get; set; }

  /// <summary>
  /// weapon name attacker used, if not the world
  /// <br/>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

  /// <summary>
  /// damage done to health
  /// <br/>
  /// type: short
  /// </summary>
  short DmgHealth { get; set; }

  /// <summary>
  /// damage done to armor
  /// <br/>
  /// type: byte
  /// </summary>
  byte DmgArmor { get; set; }

  /// <summary>
  /// hitgroup that was damaged
  /// <br/>
  /// type: byte
  /// </summary>
  byte HitGroup { get; set; }

}
