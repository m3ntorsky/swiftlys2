using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "loot_crate_opened"
/// </summary>
internal class EventLootCrateOpenedImpl : TypedGameEvent<EventLootCrateOpened>, EventLootCrateOpened
{

  public EventLootCrateOpenedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player entindex
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // type of crate (metal, wood, or paradrop)
  public string Type
  { get => Accessor.GetString("type"); set => Accessor.SetString("type", value); }
}
