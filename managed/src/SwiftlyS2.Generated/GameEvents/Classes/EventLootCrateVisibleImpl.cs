using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "loot_crate_visible"
/// </summary>
internal class EventLootCrateVisibleImpl : GameEvent<EventLootCrateVisible>, EventLootCrateVisible
{

  public EventLootCrateVisibleImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player entindex
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // crate entindex
  public short Subject
  { get => (short)GetInt("subject"); set => SetInt("subject", value); }

  // type of crate (metal, wood, or paradrop)
  public string Type
  { get => GetString("type"); set => SetString("type", value); }
}
