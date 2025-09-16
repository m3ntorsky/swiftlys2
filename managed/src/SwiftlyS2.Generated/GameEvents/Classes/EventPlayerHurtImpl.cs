using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_hurt"
/// </summary>
internal class EventPlayerHurtImpl : GameEvent<EventPlayerHurt>, EventPlayerHurt
{

  public EventPlayerHurtImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who was hurt
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // player who attacked
  public int Attacker
  { get => GetPlayerSlot("attacker"); set => SetPlayerSlot("attacker", value); }

  // remaining health points
  public byte Health
  { get => (byte)GetInt("health"); set => SetInt("health", value); }

  // remaining armor points
  public byte Armor
  { get => (byte)GetInt("armor"); set => SetInt("armor", value); }

  // weapon name attacker used, if not the world
  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }

  // damage done to health
  public short DmgHealth
  { get => (short)GetInt("dmg_health"); set => SetInt("dmg_health", value); }

  // damage done to armor
  public byte DmgArmor
  { get => (byte)GetInt("dmg_armor"); set => SetInt("dmg_armor", value); }

  // hitgroup that was damaged
  public byte HitGroup
  { get => (byte)GetInt("hitgroup"); set => SetInt("hitgroup", value); }
}
