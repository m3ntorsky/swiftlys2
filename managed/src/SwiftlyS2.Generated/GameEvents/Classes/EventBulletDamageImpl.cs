using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bullet_damage"
/// </summary>
internal class EventBulletDamageImpl : GameEvent<EventBulletDamage>, EventBulletDamage
{

  public EventBulletDamageImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player index who was hurt
  public int Victim
  { get => GetPlayerSlot("victim"); set => SetPlayerSlot("victim", value); }

  // player index who attacked
  public int Attacker
  { get => GetPlayerSlot("attacker"); set => SetPlayerSlot("attacker", value); }

  // how far the bullet travelled before it hit the player
  public float Distance
  { get => GetFloat("distance"); set => SetFloat("distance", value); }

  // direction vector of the bullet
  public float DamageDirX
  { get => GetFloat("damage_dir_x"); set => SetFloat("damage_dir_x", value); }

  // direction vector of the bullet
  public float DamageDirY
  { get => GetFloat("damage_dir_y"); set => SetFloat("damage_dir_y", value); }

  // direction vector of the bullet
  public float DamageDirZ
  { get => GetFloat("damage_dir_z"); set => SetFloat("damage_dir_z", value); }

  // how many surfaces were penetrated
  public byte NumPenetrations
  { get => (byte)GetInt("num_penetrations"); set => SetInt("num_penetrations", value); }

  // was the shooter noscoped?
  public bool NoScope
  { get => GetBool("no_scope"); set => SetBool("no_scope", value); }

  // was the shooter jumping?
  public bool InAir
  { get => GetBool("in_air"); set => SetBool("in_air", value); }

  // shoot angle x
  public float ShootAngX
  { get => GetFloat("shoot_ang_x"); set => SetFloat("shoot_ang_x", value); }

  // shoot angle y
  public float ShootAngY
  { get => GetFloat("shoot_ang_y"); set => SetFloat("shoot_ang_y", value); }

  // shoot angle z
  public float ShootAngZ
  { get => GetFloat("shoot_ang_z"); set => SetFloat("shoot_ang_z", value); }

  // aim punch x
  public float AimPunchX
  { get => GetFloat("aim_punch_x"); set => SetFloat("aim_punch_x", value); }

  // aim punch y
  public float AimPunchY
  { get => GetFloat("aim_punch_y"); set => SetFloat("aim_punch_y", value); }

  // aim punch z
  public float AimPunchZ
  { get => GetFloat("aim_punch_z"); set => SetFloat("aim_punch_z", value); }

  // attack tick
  public int AttackTickCount
  { get => GetInt("attack_tick_count"); set => SetInt("attack_tick_count", value); }

  // attack frac
  public float AttackTickFrac
  { get => GetFloat("attack_tick_frac"); set => SetFloat("attack_tick_frac", value); }

  // render tick
  public int RenderTickCount
  { get => GetInt("render_tick_count"); set => SetInt("render_tick_count", value); }

  // render frac
  public float RenderTickFrac
  { get => GetFloat("render_tick_frac"); set => SetFloat("render_tick_frac", value); }

  // total inaccuracy
  public float InaccuracyTotal
  { get => GetFloat("inaccuracy_total"); set => SetFloat("inaccuracy_total", value); }

  // move inaccuracy
  public float InaccuracyMove
  { get => GetFloat("inaccuracy_move"); set => SetFloat("inaccuracy_move", value); }

  // air inaccuracy
  public float InaccuracyAir
  { get => GetFloat("inaccuracy_air"); set => SetFloat("inaccuracy_air", value); }

  // recoil index. Yes this is really a float.
  public float RecoilIndex
  { get => GetFloat("recoil_index"); set => SetFloat("recoil_index", value); }

  // lag compensation type
  public int Type
  { get => GetInt("type"); set => SetInt("type", value); }
}
