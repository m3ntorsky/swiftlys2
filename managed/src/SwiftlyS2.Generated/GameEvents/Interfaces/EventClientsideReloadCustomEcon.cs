using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "clientside_reload_custom_econ"
/// </summary>
public interface EventClientsideReloadCustomEcon : ITypedGameEvent<EventClientsideReloadCustomEcon> {

  static EventClientsideReloadCustomEcon ITypedGameEvent<EventClientsideReloadCustomEcon>.Wrap(IGameEvent accessor) => new EventClientsideReloadCustomEconImpl(accessor);

  static string ITypedGameEvent<EventClientsideReloadCustomEcon>.GetName() => "clientside_reload_custom_econ";

  static uint ITypedGameEvent<EventClientsideReloadCustomEcon>.GetHash() => 0x22B74A75u;
  /// <summary>
  /// type: string
  /// </summary>
  string SteamID { get; set; }

}
