using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_hintmessage"
/// </summary>
internal class EventPlayerHintmessageImpl : GameEvent<EventPlayerHintmessage>, EventPlayerHintmessage
{


  // localizable string of a hint
  public string HintMessage
  { get => Accessor.GetString("hintmessage"); set => Accessor.SetString("hintmessage", value); }
}
