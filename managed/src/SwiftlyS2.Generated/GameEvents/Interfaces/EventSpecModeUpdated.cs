using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "spec_mode_updated"
/// </summary>
public interface EventSpecModeUpdated : IGameEvent<EventSpecModeUpdated> {

  static EventSpecModeUpdated IGameEvent<EventSpecModeUpdated>.FromAllocated(nint ptr) => new EventSpecModeUpdatedImpl(ptr, true);

  static EventSpecModeUpdated IGameEvent<EventSpecModeUpdated>.FromExternal(nint ptr) => new EventSpecModeUpdatedImpl(ptr, false);

  static string IGameEvent<EventSpecModeUpdated>.GetName() => "spec_mode_updated";

  static uint IGameEvent<EventSpecModeUpdated>.GetHash() => 0x25E84B54u;
  /// <summary>
  /// spectating player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
