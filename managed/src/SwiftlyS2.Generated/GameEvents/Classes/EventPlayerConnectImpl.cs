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
internal class EventPlayerConnectImpl : GameEvent<EventPlayerConnect>, EventPlayerConnect
{

  public EventPlayerConnectImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player name
  public string Name
  { get => GetString("name"); set => SetString("name", value); }

  // user ID on server (unique on server)
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // player network (i.e steam) id
  public string NetworkID
  { get => GetString("networkid"); set => SetString("networkid", value); }

  // steam id
  public ulong XuID
  { get => GetUint64("xuid"); set => SetUint64("xuid", value); }

  public bool Bot
  { get => GetBool("bot"); set => SetBool("bot", value); }
}
