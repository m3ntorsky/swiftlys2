using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_chat"
/// a public player chat
/// </summary>
internal class EventPlayerChatImpl : GameEvent<EventPlayerChat>, EventPlayerChat
{

  public EventPlayerChatImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // true if team only chat
  public bool TeamOnly
  { get => GetBool("teamonly"); set => SetBool("teamonly", value); }

  // chatting player
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // chatting player ID
  public short Playerid
  { get => (short)GetInt("playerid"); set => SetInt("playerid", value); }

  // chat text
  public string Text
  { get => GetString("text"); set => SetString("text", value); }
}
