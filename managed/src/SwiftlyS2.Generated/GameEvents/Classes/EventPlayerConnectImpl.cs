using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_connect"
/// a new client connected
/// </summary>
internal class EventPlayerConnectImpl : TypedGameEvent<EventPlayerConnect>, EventPlayerConnect
{

  public EventPlayerConnectImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player name
  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }

  // user ID on server (unique on server)
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // player network (i.e steam) id
  public string NetworkID
  { get => Accessor.GetString("networkid"); set => Accessor.SetString("networkid", value); }

  // steam id
  public ulong XuID
  { get => Accessor.GetUInt64("xuid"); set => Accessor.SetUInt64("xuid", value); }

  public bool Bot
  { get => Accessor.GetBool("bot"); set => Accessor.SetBool("bot", value); }
}
