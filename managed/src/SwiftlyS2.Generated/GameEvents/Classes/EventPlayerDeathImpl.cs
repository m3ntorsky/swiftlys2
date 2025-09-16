using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_death"
/// a game event, name may be 32 charaters long
/// </summary>
internal class EventPlayerDeathImpl : GameEvent<EventPlayerDeath>, EventPlayerDeath
{

  public EventPlayerDeathImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID who died
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // user ID who killed
  public int Attacker
  { get => GetPlayerSlot("attacker"); set => SetPlayerSlot("attacker", value); }

  // player who assisted in the kill
  public int Assister
  { get => GetPlayerSlot("assister"); set => SetPlayerSlot("assister", value); }

  // assister helped with a flash
  public bool AssistedFlash
  { get => GetBool("assistedflash"); set => SetBool("assistedflash", value); }

  // weapon name killer used
  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }

  // inventory item id of weapon killer used
  public string WeaponItemid
  { get => GetString("weapon_itemid"); set => SetString("weapon_itemid", value); }

  // faux item id of weapon killer used
  public string WeaponFauxitemid
  { get => GetString("weapon_fauxitemid"); set => SetString("weapon_fauxitemid", value); }

  public string WeaponOriginalownerXuid
  { get => GetString("weapon_originalowner_xuid"); set => SetString("weapon_originalowner_xuid", value); }

  // singals a headshot
  public bool Headshot
  { get => GetBool("headshot"); set => SetBool("headshot", value); }

  // did killer dominate victim with this kill
  public short Dominated
  { get => (short)GetInt("dominated"); set => SetInt("dominated", value); }

  // did killer get revenge on victim with this kill
  public short Revenge
  { get => (short)GetInt("revenge"); set => SetInt("revenge", value); }

  // is the kill resulting in squad wipe
  public short Wipe
  { get => (short)GetInt("wipe"); set => SetInt("wipe", value); }

  // number of objects shot penetrated before killing target
  public short Penetrated
  { get => (short)GetInt("penetrated"); set => SetInt("penetrated", value); }

  // if replay data is unavailable, this will be present and set to false
  public bool NoReplay
  { get => GetBool("noreplay"); set => SetBool("noreplay", value); }

  // kill happened without a scope, used for death notice icon
  public bool NoScope
  { get => GetBool("noscope"); set => SetBool("noscope", value); }

  // hitscan weapon went through smoke grenade
  public bool ThruSmoke
  { get => GetBool("thrusmoke"); set => SetBool("thrusmoke", value); }

  // attacker was blind from flashbang
  public bool AttackerBlind
  { get => GetBool("attackerblind"); set => SetBool("attackerblind", value); }

  // distance to victim in meters
  public float Distance
  { get => GetFloat("distance"); set => SetFloat("distance", value); }

  // damage done to health
  public short DmgHealth
  { get => (short)GetInt("dmg_health"); set => SetInt("dmg_health", value); }

  // damage done to armor
  public byte DmgArmor
  { get => (byte)GetInt("dmg_armor"); set => SetInt("dmg_armor", value); }

  // hitgroup that was damaged
  public byte HitGroup
  { get => (byte)GetInt("hitgroup"); set => SetInt("hitgroup", value); }

  // attacker was in midair
  public bool AttackerInAir
  { get => GetBool("attackerinair"); set => SetBool("attackerinair", value); }
}
