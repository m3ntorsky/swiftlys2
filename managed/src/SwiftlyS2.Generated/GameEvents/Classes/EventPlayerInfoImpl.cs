using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_info"
/// a player changed his name
/// </summary>
internal class EventPlayerInfoImpl : TypedGameEvent<EventPlayerInfo>, EventPlayerInfo
{


  // player name
  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }

  // user ID on server (unique on server)
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // player network (i.e steam) id
  public ulong SteamID
  { get => Accessor.GetUInt64("steamid"); set => Accessor.SetUInt64("steamid", value); }

  // true if player is a AI bot
  public bool Bot
  { get => Accessor.GetBool("bot"); set => Accessor.SetBool("bot", value); }
}
