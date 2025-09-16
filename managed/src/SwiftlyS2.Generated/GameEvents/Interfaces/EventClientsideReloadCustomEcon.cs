using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "clientside_reload_custom_econ"
/// </summary>
public interface EventClientsideReloadCustomEcon : IGameEvent<EventClientsideReloadCustomEcon> {

  static EventClientsideReloadCustomEcon IGameEvent<EventClientsideReloadCustomEcon>.FromAllocated(nint ptr) => new EventClientsideReloadCustomEconImpl(ptr, true);

  static EventClientsideReloadCustomEcon IGameEvent<EventClientsideReloadCustomEcon>.FromExternal(nint ptr) => new EventClientsideReloadCustomEconImpl(ptr, false);

  static string IGameEvent<EventClientsideReloadCustomEcon>.GetName() => "clientside_reload_custom_econ";

  static uint IGameEvent<EventClientsideReloadCustomEcon>.GetHash() => 0x22B74A75u;
  /// <summary>
  /// type: string
  /// </summary>
  string SteamID { get; set; }

}
