using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "sfuievent"
/// </summary>
internal class EventSfuieventImpl : GameEvent<EventSfuievent>, EventSfuievent
{

  public EventSfuieventImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Action
  { get => GetString("action"); set => SetString("action", value); }

  public string Data
  { get => GetString("data"); set => SetString("data", value); }

  public byte Slot
  { get => (byte)GetInt("slot"); set => SetInt("slot", value); }
}
