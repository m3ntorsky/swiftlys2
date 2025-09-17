using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "clientside_reload_custom_econ"
/// </summary>
internal class EventClientsideReloadCustomEconImpl : TypedGameEvent<EventClientsideReloadCustomEcon>, EventClientsideReloadCustomEcon
{


  public string SteamID
  { get => Accessor.GetString("steamid"); set => Accessor.SetString("steamid", value); }
}
