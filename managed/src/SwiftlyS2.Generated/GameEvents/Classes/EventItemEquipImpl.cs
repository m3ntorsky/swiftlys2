using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_equip"
/// </summary>
internal class EventItemEquipImpl : GameEvent<EventItemEquip>, EventItemEquip
{

  public EventItemEquipImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => GetString("item"); set => SetString("item", value); }

  public int DefIndex
  { get => GetInt("defindex"); set => SetInt("defindex", value); }

  public bool CanZoom
  { get => GetBool("canzoom"); set => SetBool("canzoom", value); }

  public bool HasSilencer
  { get => GetBool("hassilencer"); set => SetBool("hassilencer", value); }

  public bool IsSilenced
  { get => GetBool("issilenced"); set => SetBool("issilenced", value); }

  public bool HasTracers
  { get => GetBool("hastracers"); set => SetBool("hastracers", value); }

  public short WepType
  { get => (short)GetInt("weptype"); set => SetInt("weptype", value); }

  public bool IsPainted
  { get => GetBool("ispainted"); set => SetBool("ispainted", value); }
}
