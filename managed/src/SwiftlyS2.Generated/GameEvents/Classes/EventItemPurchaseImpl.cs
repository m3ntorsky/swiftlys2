using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_purchase"
/// </summary>
internal class EventItemPurchaseImpl : GameEvent<EventItemPurchase>, EventItemPurchase
{

  public EventItemPurchaseImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Team
  { get => (short)GetInt("team"); set => SetInt("team", value); }

  public short LoadOut
  { get => (short)GetInt("loadout"); set => SetInt("loadout", value); }

  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }
}
