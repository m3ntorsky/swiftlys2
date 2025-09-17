using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "sfuievent"
/// </summary>
internal class EventSfuieventImpl : TypedGameEvent<EventSfuievent>, EventSfuievent
{


  public string Action
  { get => Accessor.GetString("action"); set => Accessor.SetString("action", value); }

  public string Data
  { get => Accessor.GetString("data"); set => Accessor.SetString("data", value); }

  public byte Slot
  { get => (byte)Accessor.GetInt32("slot"); set => Accessor.SetInt32("slot", value); }
}
