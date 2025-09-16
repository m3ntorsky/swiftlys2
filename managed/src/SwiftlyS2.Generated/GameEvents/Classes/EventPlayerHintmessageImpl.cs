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

  public EventPlayerHintmessageImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // localizable string of a hint
  public string HintMessage
  { get => GetString("hintmessage"); set => SetString("hintmessage", value); }
}
