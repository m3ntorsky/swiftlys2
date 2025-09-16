using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "clientside_reload_custom_econ"
/// </summary>
internal class EventClientsideReloadCustomEconImpl : GameEvent<EventClientsideReloadCustomEcon>, EventClientsideReloadCustomEcon
{

  public EventClientsideReloadCustomEconImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string SteamID
  { get => GetString("steamid"); set => SetString("steamid", value); }
}
