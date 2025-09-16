using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "loot_crate_opened"
/// </summary>
internal class EventLootCrateOpenedImpl : GameEvent<EventLootCrateOpened>, EventLootCrateOpened
{

  public EventLootCrateOpenedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player entindex
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // type of crate (metal, wood, or paradrop)
  public string Type
  { get => GetString("type"); set => SetString("type", value); }
}
