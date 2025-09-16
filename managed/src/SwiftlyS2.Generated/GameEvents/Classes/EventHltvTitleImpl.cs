using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_title"
/// </summary>
internal class EventHltvTitleImpl : GameEvent<EventHltvTitle>, EventHltvTitle
{

  public EventHltvTitleImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Text
  { get => GetString("text"); set => SetString("text", value); }
}
