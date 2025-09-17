using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_message"
/// a HLTV message send by moderators
/// </summary>
internal class EventHltvMessageImpl : TypedGameEvent<EventHltvMessage>, EventHltvMessage
{


  public string Text
  { get => Accessor.GetString("text"); set => Accessor.SetString("text", value); }
}
