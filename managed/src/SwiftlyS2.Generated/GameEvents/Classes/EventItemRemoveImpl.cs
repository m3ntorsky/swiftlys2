using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_remove"
/// </summary>
internal class EventItemRemoveImpl : GameEvent<EventItemRemove>, EventItemRemove
{

  public EventItemRemoveImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => GetString("item"); set => SetString("item", value); }

  public int DefIndex
  { get => GetInt("defindex"); set => SetInt("defindex", value); }
}
