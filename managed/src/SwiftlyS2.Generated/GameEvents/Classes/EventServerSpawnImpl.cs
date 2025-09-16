using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_spawn"
/// send once a server starts
/// </summary>
internal class EventServerSpawnImpl : GameEvent<EventServerSpawn>, EventServerSpawn
{

  public EventServerSpawnImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // public host name
  public string Hostname
  { get => GetString("hostname"); set => SetString("hostname", value); }

  // hostame, IP or DNS name
  public string Address
  { get => GetString("address"); set => SetString("address", value); }

  // server port
  public short Port
  { get => (short)GetInt("port"); set => SetInt("port", value); }

  // game dir
  public string Game
  { get => GetString("game"); set => SetString("game", value); }

  // map name
  public string MapName
  { get => GetString("mapname"); set => SetString("mapname", value); }

  // addon name
  public string AddonName
  { get => GetString("addonname"); set => SetString("addonname", value); }

  // max players
  public int MaxPlayers
  { get => GetInt("maxplayers"); set => SetInt("maxplayers", value); }

  // WIN32, LINUX
  public string Os
  { get => GetString("os"); set => SetString("os", value); }

  // true if dedicated server
  public bool Dedicated
  { get => GetBool("dedicated"); set => SetBool("dedicated", value); }

  // true if password protected
  public bool Password
  { get => GetBool("password"); set => SetBool("password", value); }
}
