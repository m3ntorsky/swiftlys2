using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "other_death"
/// </summary>
internal class EventOtherDeathImpl : GameEvent<EventOtherDeath>, EventOtherDeath
{

  public EventOtherDeathImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // other entity ID who died
  public short OtherID
  { get => (short)GetInt("otherid"); set => SetInt("otherid", value); }

  // other entity type
  public string OtherType
  { get => GetString("othertype"); set => SetString("othertype", value); }

  // user ID who killed
  public short Attacker
  { get => (short)GetInt("attacker"); set => SetInt("attacker", value); }

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

  // number of objects shot penetrated before killing target
  public short Penetrated
  { get => (short)GetInt("penetrated"); set => SetInt("penetrated", value); }

  // kill happened without a scope, used for death notice icon
  public bool NoScope
  { get => GetBool("noscope"); set => SetBool("noscope", value); }

  // hitscan weapon went through smoke grenade
  public bool ThruSmoke
  { get => GetBool("thrusmoke"); set => SetBool("thrusmoke", value); }

  // attacker was blind from flashbang
  public bool AttackerBlind
  { get => GetBool("attackerblind"); set => SetBool("attackerblind", value); }
}
