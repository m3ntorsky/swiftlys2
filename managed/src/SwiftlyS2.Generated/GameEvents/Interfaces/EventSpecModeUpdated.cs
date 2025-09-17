using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "spec_mode_updated"
/// </summary>
public interface EventSpecModeUpdated : ITypedGameEvent<EventSpecModeUpdated> {

  static EventSpecModeUpdated ITypedGameEvent<EventSpecModeUpdated>.Wrap(IGameEvent accessor) => new EventSpecModeUpdatedImpl(accessor);

  static string ITypedGameEvent<EventSpecModeUpdated>.GetName() => "spec_mode_updated";

  static uint ITypedGameEvent<EventSpecModeUpdated>.GetHash() => 0x25E84B54u;
  /// <summary>
  /// spectating player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
