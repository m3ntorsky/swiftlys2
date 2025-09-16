using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "inventory_updated"
/// </summary>
internal class EventInventoryUpdatedImpl : GameEvent<EventInventoryUpdated>, EventInventoryUpdated
{

  public EventInventoryUpdatedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short ItemDef
  { get => (short)GetInt("itemdef"); set => SetInt("itemdef", value); }

  public int Itemid
  { get => GetInt("itemid"); set => SetInt("itemid", value); }
}
