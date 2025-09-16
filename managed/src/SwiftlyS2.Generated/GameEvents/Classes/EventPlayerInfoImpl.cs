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
internal class EventPlayerInfoImpl : GameEvent<EventPlayerInfo>, EventPlayerInfo
{

  public EventPlayerInfoImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player name
  public string Name
  { get => GetString("name"); set => SetString("name", value); }

  // user ID on server (unique on server)
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // player network (i.e steam) id
  public ulong SteamID
  { get => GetUint64("steamid"); set => SetUint64("steamid", value); }

  // true if player is a AI bot
  public bool Bot
  { get => GetBool("bot"); set => SetBool("bot", value); }
}
