using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "dz_item_interaction"
/// </summary>
internal class EventDzItemInteractionImpl : GameEvent<EventDzItemInteraction>, EventDzItemInteraction
{

  public EventDzItemInteractionImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
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
