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
internal class EventPlayerChatImpl : TypedGameEvent<EventPlayerChat>, EventPlayerChat
{


  // true if team only chat
  public bool TeamOnly
  { get => Accessor.GetBool("teamonly"); set => Accessor.SetBool("teamonly", value); }

  // chatting player
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // chatting player ID
  public short Playerid
  { get => (short)Accessor.GetInt32("playerid"); set => Accessor.SetInt32("playerid", value); }

  // chat text
  public string Text
  { get => Accessor.GetString("text"); set => Accessor.SetString("text", value); }
}
