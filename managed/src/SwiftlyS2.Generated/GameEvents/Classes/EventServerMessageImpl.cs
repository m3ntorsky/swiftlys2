using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_message"
/// a generic server message
/// </summary>
internal class EventServerMessageImpl : GameEvent<EventServerMessage>, EventServerMessage
{

  public EventServerMessageImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // the message text
  public string Text
  { get => GetString("text"); set => SetString("text", value); }
}
