using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_disconnect"
/// a client was disconnected
/// </summary>
internal class EventPlayerDisconnectImpl : GameEvent<EventPlayerDisconnect>, EventPlayerDisconnect
{

  public EventPlayerDisconnectImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // see networkdisconnect enum protobuf
  public short Reason
  { get => (short)GetInt("reason"); set => SetInt("reason", value); }

  // player name
  public string Name
  { get => GetString("name"); set => SetString("name", value); }

  // player network (i.e steam) id
  public string NetworkID
  { get => GetString("networkid"); set => SetString("networkid", value); }

  // steam id
  public ulong XuID
  { get => GetUint64("xuid"); set => SetUint64("xuid", value); }

  public short PlayerID
  { get => (short)GetInt("PlayerID"); set => SetInt("PlayerID", value); }
}
