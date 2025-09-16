using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "game_message"
/// a message send by game logic to everyone
/// </summary>
internal class EventGameMessageImpl : GameEvent<EventGameMessage>, EventGameMessage
{

  public EventGameMessageImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // 0 = console, 1 = HUD
  public byte Target
  { get => (byte)GetInt("target"); set => SetInt("target", value); }

  // the message text
  public string Text
  { get => GetString("text"); set => SetString("text", value); }
}
