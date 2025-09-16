using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_chat"
/// a HLTV chat msg sent by spectators
/// </summary>
internal class EventHltvChatImpl : GameEvent<EventHltvChat>, EventHltvChat
{

  public EventHltvChatImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Text
  { get => GetString("text"); set => SetString("text", value); }

  // steam id
  public ulong SteamID
  { get => GetUint64("steamID"); set => SetUint64("steamID", value); }
}
