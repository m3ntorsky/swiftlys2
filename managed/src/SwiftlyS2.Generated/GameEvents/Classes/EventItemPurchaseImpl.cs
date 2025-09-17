using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_purchase"
/// </summary>
internal class EventItemPurchaseImpl : TypedGameEvent<EventItemPurchase>, EventItemPurchase
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Team
  { get => (short)Accessor.GetInt32("team"); set => Accessor.SetInt32("team", value); }

  public short LoadOut
  { get => (short)Accessor.GetInt32("loadout"); set => Accessor.SetInt32("loadout", value); }

  public string Weapon
  { get => Accessor.GetString("weapon"); set => Accessor.SetString("weapon", value); }
}
