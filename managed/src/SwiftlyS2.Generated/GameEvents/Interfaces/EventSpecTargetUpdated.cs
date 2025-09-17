using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "spec_target_updated"
/// </summary>
public interface EventSpecTargetUpdated : ITypedGameEvent<EventSpecTargetUpdated> {

  static EventSpecTargetUpdated ITypedGameEvent<EventSpecTargetUpdated>.Create() => new EventSpecTargetUpdatedImpl();

  static string ITypedGameEvent<EventSpecTargetUpdated>.GetName() => "spec_target_updated";

  static uint ITypedGameEvent<EventSpecTargetUpdated>.GetHash() => 0x89A1984Au;
  /// <summary>
  /// spectating player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// ehandle of the target
  /// <br/>
  /// type: ehandle
  /// </summary>
  nint Target { get; set; }

}
