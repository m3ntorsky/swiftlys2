using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_title"
/// </summary>
internal class EventHltvTitleImpl : TypedGameEvent<EventHltvTitle>, EventHltvTitle
{

  public EventHltvTitleImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public string Text
  { get => Accessor.GetString("text"); set => Accessor.SetString("text", value); }
}
